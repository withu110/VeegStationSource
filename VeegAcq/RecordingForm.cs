using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

// nVLC
using Declarations;
using Declarations.Players;
using Declarations.Media;
using Implementation;

using System.Configuration;

namespace VeegStation
{
    public partial class RecordingForm : Form
    {
        private IVideoPlayer _player;
        private IMedia _media;
        private Process _ffmpeg;
        private DateTime _start;

        //xcg
        //记录系统配置文件中摄像机的IP
        private string cameraIP;

        public RecordingForm()
        {
            InitializeComponent();
            //xcg
            // 获取系统配置文件中摄像机的IP
            cameraIP = Properties.Settings.Default.CameraIP;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
                Close();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (_ffmpeg != null)
            {
                return;
            }
            _start = DateTime.Now;
            _ffmpeg = new Process();
            _ffmpeg.StartInfo.UseShellExecute = false;
            _ffmpeg.StartInfo.CreateNoWindow = true;
            _ffmpeg.StartInfo.RedirectStandardInput = true;
            _ffmpeg.StartInfo.RedirectStandardOutput = true;
            _ffmpeg.StartInfo.RedirectStandardError = true;
            _ffmpeg.StartInfo.FileName = "ffmpeg.exe";
            //_ffmpeg.StartInfo.Arguments = "-i \"rtsp://admin:admin@" + DefaultConfig.CameraIP + ":554/cam/realmonitor?channel=1&subtype=1\" "
                //+ DefaultConfig.VideoSegmentPath + "\\" + _start.ToString("yyyyMMddHHmmss") + ".mp4";
            //xcg
            _ffmpeg.StartInfo.Arguments = "-i \"rtsp://admin:admin@" + cameraIP + ":554/cam/realmonitor?channel=1&subtype=1\" "
            + DefaultConfig.VideoSegmentPath + "\\" + _start.ToString("yyyyMMddHHmmss") + ".mp4";
            _ffmpeg.Start();
            _ffmpeg.ErrorDataReceived += ffmpeg_ErrorDataReceived;
            _ffmpeg.OutputDataReceived += ffmpeg_OutputDataReceived;
            _ffmpeg.BeginErrorReadLine();
            _ffmpeg.BeginOutputReadLine();
        }

        private void ffmpeg_ErrorDataReceived(object Sender, DataReceivedEventArgs e)
        {
            if (e.Data != null && e.Data.Length != 0)
            {
                Debug.WriteLine(string.Format("STDERR: {0}", e.Data));
            }
        }

        private void ffmpeg_OutputDataReceived(object Sender, DataReceivedEventArgs e)
        {
            if (e.Data != null && e.Data.Length != 0)
            {
                Debug.WriteLine(string.Format("STDOUT: {0}", e.Data));
            }
        }

        private void RecordingForm_Load(object sender, EventArgs e)
        {
            IMediaPlayerFactory factory = new MediaPlayerFactory();
            //_media = factory.CreateMedia<IMedia>("rtsp://admin:admin@" + DefaultConfig.CameraIP + ":554/cam/realmonitor?channel=1&subtype=1", DefaultConfig.PlayerOptions);
            //xcg
            _media = factory.CreateMedia<IMedia>("rtsp://admin:admin@" + cameraIP + ":554/cam/realmonitor?channel=1&subtype=1", DefaultConfig.PlayerOptions);
            _player = factory.CreatePlayer<IVideoPlayer>();
            _player.AspectRatio = AspectRatioMode.Mode2;
            _player.Open(_media);
            _player.Play();

        }

        private bool CanClose()
        {
            if (_ffmpeg == null)
            {
                return true;
            }
            if (MessageBox.Show("在停止录制视频之前，应先停止录制脑电。\n脑电仪已经关闭了吗？", "是否停止录制视频", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                return true;
            }
            return false;
        }
        private void RecordingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!CanClose())
            {
                e.Cancel = true;
            }
        }

        private void RecordingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_ffmpeg != null)
            {
                _ffmpeg.StandardInput.WriteLine("q");
                _ffmpeg.WaitForExit(5000);
                if (!_ffmpeg.HasExited)
                {
                    try
                    {
                        _ffmpeg.Kill();
                    }
                    catch
                    { }
                }
                _ffmpeg.Dispose();
                _ffmpeg = null;
            }
            _player.Stop();
            _player.Dispose();
            _media.Dispose();
        }

        private void timerShowNow_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            textNow.Text = now.ToString("s").Replace('T', ' ');
            if (_ffmpeg != null)
            {
                TimeSpan ts = now - _start;
                string duration = ts.ToString();
                duration = duration.Substring(0, duration.LastIndexOf('.'));
                textDuration.Text = duration;
            }
        }
    }
}
