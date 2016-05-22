using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

// nVLC, strange namespaces :(
using Declarations;
using Declarations.Players;
using Declarations.Media;
using Implementation;

namespace VeegStation
{
    public partial class PlaybackForm : Form
    {
        //////////////////////////////
        NatFileInfo natfileinfo;
        PationInfo pationinfo;

        private const int WINDOW_SECONDS = 10;
        private NationFileInfo _nfi = null;

        private List<EegPacket> _packets = new List<EegPacket>();

        private int _Page;
        private DateTime? _LastTime = null;
        private double _CurrentOffset;

        private IVideoPlayer _player;
        private IMedia _media;

        public PlaybackForm(NationFileInfo EegFile)
        {
            InitializeComponent();
            natfileinfo = new NatFileInfo(EegFile.NedFullName);
            pationinfo = new PationInfo(EegFile.NedFullName, natfileinfo.PatOff);

            _Page = 0;
            try
            {
                _nfi = EegFile;
            }
            catch
            { }
        }

        private void LoadData(int Offset)
        {
            if (_nfi == null)
            {
                return;
            }
            int loadRec = WINDOW_SECONDS * _nfi.SampleRate;
            DateTime begin = DateTime.Now;
            FileStream fs = new FileStream(_nfi.NedFullName, FileMode.Open, FileAccess.Read);
            fs.Seek(0x200, SeekOrigin.Begin);
            fs.Seek(0x6c * Offset * loadRec, SeekOrigin.Current);
            byte[] buf = new byte[0x6c];
            _packets.Clear();
            foreach (int x in Enumerable.Range(0, loadRec))
            {
                if (fs.Read(buf, 0, 0x6c) < 0x6c)
                {
                    break;
                }
                double ekg = Util.RawToSignal((short)(buf[6] | (buf[7] << 8)));
                List<double> eeg = new List<double>();
                foreach (int off in Enumerable.Range(0, 19))
                {
                    eeg.Add(Util.RawToSignal((short)(buf[28 + 2 * off] | (buf[29 + 2 * off] << 8))));
                }
                EegPacket pkt = new EegPacket(ekg, eeg.ToArray());
                _packets.Add(pkt);
            }
            fs.Close();
            fs.Dispose();
            DateTime end = DateTime.Now;
            Debug.WriteLine(string.Format("Read a window of data {0} records in {0} seconds", _packets.Count, (end - begin).TotalSeconds));
        }

        private void ShowData()
        {
            DateTime begin = DateTime.Now;
            SeriesCollection col = chartWave.Series;
            chartWave.SuspendLayout();
            foreach (int sIdx in Enumerable.Range(0, 20))
            {
                col[sIdx].Points.Clear();
            }
            foreach (int tIdx in Enumerable.Range(0, _packets.Count))
            {
                col[19].Points.AddXY(tIdx / 128.0, _packets[tIdx].EKG + 50);
                foreach (int sIdx in Enumerable.Range(0, 19))
                {
                    double val = _packets[tIdx].EEG[sIdx];
                    val /= 20;
                    val += (2000 - 100 * sIdx - 50);
                    col[sIdx].Points.AddXY(tIdx / 128.0, val);
                }
            }
            chartWave.ResumeLayout();
            labelPage.Text = (_Page + 1).ToString() + "/" + ((_nfi.SampleCount + (WINDOW_SECONDS * _nfi.SampleRate) - 1) / (WINDOW_SECONDS * _nfi.SampleRate)).ToString();
            DateTime end = DateTime.Now;
            Debug.WriteLine(string.Format("Show a window of data in {0} seconds", (end - begin).TotalSeconds));
        }
        private void PlaybackForm_Load(object sender, EventArgs e)
        {
            if (_nfi == null)
            {
                Close();
                return;
            }

            chartWave.Series.Clear();
            foreach (int idx in Enumerable.Range(0, 20))
            {
                Series ser = new Series();
                ser.ChartType = SeriesChartType.FastLine;
                ser.BorderDashStyle = ChartDashStyle.Solid;
                //ser.Color = Color.Black;
                chartWave.Series.Add(ser);
            }
            chartWave.ChartAreas[0].AxisX.Maximum = WINDOW_SECONDS;
            //hsProgress.
            if (_nfi != null)
            {
                LoadData(0);
                ShowData();
            }

            IMediaPlayerFactory factory = new MediaPlayerFactory();
            _player = factory.CreatePlayer<IVideoPlayer>();
            _player.WindowHandle = panelVideo.Handle;
            //     _player.WindowHandle=pictureBox1.Handle;
            _player.AspectRatio = AspectRatioMode.Mode2; // fill?

            if (_nfi.HasVideo)
            {
                _media = factory.CreateMedia<IMediaFromFile>(_nfi.VideoFullName);
                _player.Open(_media);
                Debug.WriteLine(_player.IsSeekable);
                Debug.WriteLine(_player.Length);
                _player.Time = (long)_nfi.VideoOffset * 1000;
                //_player.Play();
                _player.Pause();
            }
        }

        private void PagePrev()
        {
            if (_Page > 0)
            {
                _Page -= 1;
                _CurrentOffset = _Page * chartWave.ChartAreas[0].AxisX.Maximum;
                LoadData(_Page);
                ShowData();
                set_hsScrollBarValue();
            }
        }

        private void PageNext()
        {
            if (_Page < (_nfi.SampleCount + (WINDOW_SECONDS * _nfi.SampleRate) - 1) / (WINDOW_SECONDS * _nfi.SampleRate))
            {
                _Page += 1;
                _CurrentOffset = _Page * chartWave.ChartAreas[0].AxisX.Maximum;
                LoadData(_Page);
                ShowData();
                //_startTimeInPage = DateTime.Now;
                set_hsScrollBarValue();
            }
        }

        private void PageNext_2()
        {
            if (_Page < (_nfi.SampleCount + (WINDOW_SECONDS * _nfi.SampleRate) - 1) / (WINDOW_SECONDS * _nfi.SampleRate))
            {
                _Page += 1;
                _CurrentOffset = _Page * chartWave.ChartAreas[0].AxisX.Maximum + _CurrentOffset;
                LoadData(_Page);
                ShowData();
                //_startTimeInPage = DateTime.Now;
                set_hsScrollBarValue();
            }
        }



        private void SetTimeLine()
        {
            chartWave.ChartAreas[0].AxisX.StripLines[0].IntervalOffset = _CurrentOffset - _Page * chartWave.ChartAreas[0].AxisX.Maximum;////////添加需要拖动的一些位置进行
        }
        private void SyncVideo()
        {
            //_player.Position = (float)_CurrentOffset * 1000;
            _player.Time = (long)_CurrentOffset * 1000;
            //+ hsProgress.Value * 100;//自己添加" + hsProgress.Value*100 "
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            //timer.Enabled = false;
            Pause();
            PagePrev();
            SetTimeLine();///////////////////////////////////////////修改为_2
            SyncVideo();
            //_player.Play();
            //_player.Pause();
            set_BtnEnable();
            hsProgerss_Video.Value = 0;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //timer.Enabled = false;                       
            Pause();
            PageNext();/////////////////PageNext()修改为PageNext_2();
            SetTimeLine();/////////////////////修改为_2
            SyncVideo();
            //_player.Play();
            // _player.Pause();
            set_BtnEnable();
            hsProgerss_Video.Value = 0;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            _CurrentOffset += (now - _LastTime.Value).TotalSeconds;
            _LastTime = now;
            if (_CurrentOffset > _nfi.Duration.TotalSeconds)/////////////////
            {
                Pause();
                _CurrentOffset = 0;
                _Page = 0;
                _LastTime = null;
            }

            if (_CurrentOffset > (_Page + 1) * chartWave.ChartAreas[0].AxisX.Maximum)
            {
                PageNext();
                hsProgerss_Video.Value = 0;////////////////////添加用于更新进度条使用
            }
            else
            {
                if (hsProgerss_Video.Maximum == hsProgerss_Video.Value)
                {
                    timer.Enabled = false;
                    //   hsProgress.Value = 0;
                }
                else
                {
                    // 如果最大值减去每次滚动的1，最后剩下的不足1，就加上剩下的
                    if (hsProgerss_Video.Maximum - hsProgerss_Video.Value < 1)
                        hsProgerss_Video.Value += hsProgerss_Video.Maximum - hsProgerss_Video.Value;
                    else
                        hsProgerss_Video.Value += 1;
                }
                //        SetTimeLine_2();
                SetTimeLine();
            }

        }

        private void Play()
        {
            if (!_LastTime.HasValue)
            {
                _LastTime = DateTime.Now;
            }
            timer.Enabled = true;
            if (_nfi.HasVideo)
            {
                // TODO:
                //_player.Time = (long)(_nfi.VideoOffset * 1000);
                if (!_player.IsPlaying)
                    _player.Play();
            }
            else
            {
                timer.Enabled = false;
                MessageBox.Show("没有视频", "提示");
            }
            btnPlay.Enabled = false;
            btnPause.Enabled = true;
        }

        private void Pause()
        {
            timer.Enabled = false;
            _LastTime = null;
            if (_nfi.HasVideo)
            {
                if (_player.IsPlaying)
                    _player.Pause();
            }
            btnPause.Enabled = false;
            btnPlay.Enabled = true;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Play();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            Pause();
        }

        //private void hsProgress_ValueChanged(object sender, EventArgs e)
        //{
        //    if (_Page < (_nfi.SampleCount + (WINDOW_SECONDS * _nfi.SampleRate) - 1) / (WINDOW_SECONDS * _nfi.SampleRate))
        //    {
        //        int max = (_nfi.SampleCount + (WINDOW_SECONDS * _nfi.SampleRate) - 1) / (WINDOW_SECONDS * _nfi.SampleRate);
        //        _Page = (int)((float)hsProgress.Value / 92.0f * max + 0.5 );
        //        _CurrentOffset = _Page * chartWave.ChartAreas[0].AxisX.Maximum;
        //        LoadData(_Page);
        //        ShowData();
        //        set_BtnEnable();
        //        //_startTimeInPage = DateTime.Now;
        //    }
        //    Debug.WriteLine(string.Format("Scroll changed to {0}", hsProgress.Value));
        //    SetTimeLine();
        //    SyncVideo();
        //    //_player.Play();
        //    //_player.Pause();
        //}

        private void set_hsScrollBarValue()
        {
            int maxPage = (_nfi.SampleCount + (WINDOW_SECONDS * _nfi.SampleRate) - 1) / (WINDOW_SECONDS * _nfi.SampleRate);
            int value = (int)((float)(_Page + 1) / (float)maxPage * 91 + 0.5);
            hsProgress.Value = value;
        }

        private void hsProgress_MouseCaptureChanged(object sender, EventArgs e)
        {
            Debug.WriteLine(string.Format("Scroll mouse cap changed {0}", e));
            Pause();
            set_BtnEnable();
            hsProgerss_Video.Value = 0;
        }

        private void panel_next_click(object sender, EventArgs e)
        {
            btnNext_Click(sender, e);
        }

        private void panel_prev_click(object sender, EventArgs e)
        {
            btnPrev_Click(sender, e);
        }

        private void set_BtnEnable()
        {
            if (_Page <= 0)
            {
                btnPrev.Enabled = false;
                // panel_prev.Cursor = System.Windows.Forms.Cursors.Default;
                panel_prev.Visible = false;
                return;
            }
            else if ((_Page + 1) >= ((_nfi.SampleCount + (WINDOW_SECONDS * _nfi.SampleRate) - 1) / (WINDOW_SECONDS * _nfi.SampleRate)))
            {
                btnNext.Enabled = false;
                //panel_next.Cursor = System.Windows.Forms.Cursors.Default;
                panel_next.Visible = false;
                return;
            }
            btnPrev.Enabled = true;
            btnNext.Enabled = true;
            //panel_next.Cursor = System.Windows.Forms.Cursors.Hand;
            //panel_prev.Cursor = System.Windows.Forms.Cursors.Hand;
            panel_next.Visible = true;
            panel_prev.Visible = true;
        }

        private void btn_enlarge_Click(object sender, EventArgs e)
        {
            if (_player.VideoScale <= 2.0f)
                _player.VideoScale += 0.5f;
            else MessageBox.Show("已放大到最大化");
        }

        private void btn_shrink_Click(object sender, EventArgs e)
        {
            if (_player.VideoScale >= 0)
            {
                _player.VideoScale -= 0.5f;
            }
            else MessageBox.Show("已经缩小到最小");
        }

        private void PagePrev_2()
        {
            if (_Page > 0)
            {
                _CurrentOffset = _Page * chartWave.ChartAreas[0].AxisX.Maximum;
                LoadData(_Page);
                ShowData();
                set_hsScrollBarValue();
            }
            else
                _CurrentOffset = 0;
        }
        private void SetTimeLine_2()
        {
            chartWave.ChartAreas[0].AxisX.StripLines[0].IntervalOffset = hsProgerss_Video.Value * 0.1;
        }
        private void hsProgerss_Video_Scroll(object sender, ScrollEventArgs e)
        {
            timer.Enabled = false;
            PagePrev_2();
            _player.Time = (long)(_CurrentOffset * 1000 + hsProgerss_Video.Value * 100);
            _CurrentOffset = _CurrentOffset + hsProgerss_Video.Value * 0.1;
            SetTimeLine();
            Pause();
        }

        private void pationInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Set_PationInfoPanel(pationinfo);
            this.PationInfoPanel.Visible = true;
            this.DetectionInfoPanel.Visible = false;
        }

        private void detectionInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Set_DetectionInfoPanel(natfileinfo, pationinfo);
            this.PationInfoPanel.Visible = false;
            this.DetectionInfoPanel.Visible = true;
        }

        private void hideingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.PationInfoPanel.Visible = false;
            this.DetectionInfoPanel.Visible = false;
        }

        private void Set_PationInfoPanel(PationInfo _pationinfo)
        {
            this.PatNameTextBt.Text = _pationinfo.Name;
            this.PatGenderCB.Text = _pationinfo.Gender;
            this.PatIDTextBt.Text = _pationinfo.ID;
            this.PatAgeTextBt.Text = _pationinfo.Age;
            this.SingleHandAdvanCB.Text = _pationinfo.Handedness;
        }

        private void Set_DetectionInfoPanel(NatFileInfo _nationfileinfo, PationInfo _pationinfo)
        {
            this.DetectionTextBt.Text = _pationinfo.ID;
            this.RequesterTextBt.Text = _pationinfo.Name;
            this.TechnicianTextBt.Text = _pationinfo.ResidentDoctor;
            this.PhysicianTextBT.Text = _pationinfo.OperateDoctor;
            this.PationStateTextBt.Text = _pationinfo.State;
            this.PharmacyTextBt.Text = _pationinfo.Medicine;
            this.DetectionRemarksTextBt.Text = _pationinfo.Diagnosis;
            this.FilePathTextBt.Text = _pationinfo.FilePath;
        }

        Point pt;
        private void PationInfoPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int px = System.Windows.Forms.Control.MousePosition.X - pt.X;
                int py = System.Windows.Forms.Control.MousePosition.Y - pt.Y;
                PationInfoPanel.Location = new Point(PationInfoPanel.Location.X + px, PationInfoPanel.Location.Y + py);

                pt = System.Windows.Forms.Control.MousePosition;
            }
        }

        private void PationInfoPanel_MouseDown(object sender, MouseEventArgs e)
        {
            pt = System.Windows.Forms.Control.MousePosition;
        }

        Point _pt;
        private void DetectionInfoPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int px = System.Windows.Forms.Control.MousePosition.X - _pt.X;
                int py = System.Windows.Forms.Control.MousePosition.Y - _pt.Y;
                DetectionInfoPanel.Location = new Point(DetectionInfoPanel.Location.X + px, DetectionInfoPanel.Location.Y + py);

                _pt = System.Windows.Forms.Control.MousePosition;
            }
        }

        private void DetectionInfoPanel_MouseDown(object sender, MouseEventArgs e)
        {
            _pt = System.Windows.Forms.Control.MousePosition;
        }

        private void hsProgress_ValueChanged(object sender, ScrollEventArgs e)
        {
            if (_Page < (_nfi.SampleCount + (WINDOW_SECONDS * _nfi.SampleRate) - 1) / (WINDOW_SECONDS * _nfi.SampleRate))
            {
                int max = (_nfi.SampleCount + (WINDOW_SECONDS * _nfi.SampleRate) - 1) / (WINDOW_SECONDS * _nfi.SampleRate);
                _Page = (int)((float)hsProgress.Value / 91.0f * (max - 1) + 0.5);
                _CurrentOffset = _Page * chartWave.ChartAreas[0].AxisX.Maximum;
                LoadData(_Page);
                ShowData();
                set_BtnEnable();
                //_startTimeInPage = DateTime.Now;
            }
            Debug.WriteLine(string.Format("Scroll changed to {0}", hsProgress.Value));
            SetTimeLine();
            SyncVideo();
            //_player.Play();
            //_player.Pause();
        }

        private void panelVideo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("********");
        }
    }
}
