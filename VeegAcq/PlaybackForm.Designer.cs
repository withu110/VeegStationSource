namespace VeegStation
{
    partial class PlaybackForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlaybackForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.StripLine stripLine1 = new System.Windows.Forms.DataVisualization.Charting.StripLine();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnPlay = new System.Windows.Forms.ToolStripButton();
            this.btnPause = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.labelPage = new System.Windows.Forms.ToolStripLabel();
            this.btnPrev = new System.Windows.Forms.ToolStripButton();
            this.btnNext = new System.Windows.Forms.ToolStripButton();
            this.InformationTSSSBt = new System.Windows.Forms.ToolStripDropDownButton();
            this.pationInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detectionInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panelVideo = new System.Windows.Forms.Panel();
            this.chartWave = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.hsProgress = new System.Windows.Forms.HScrollBar();
            this.panel_next = new System.Windows.Forms.Panel();
            this.panel_prev = new System.Windows.Forms.Panel();
            this.btn_enlarge = new System.Windows.Forms.Button();
            this.btn_shrink = new System.Windows.Forms.Button();
            this.hsProgerss_Video = new System.Windows.Forms.HScrollBar();
            this.PationInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.DetectionInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.Hiding = new System.Windows.Forms.ToolStripMenuItem();
            this.PationInfoPanel = new System.Windows.Forms.Panel();
            this.PatAgeL = new System.Windows.Forms.Label();
            this.PatAgeTextBt = new System.Windows.Forms.TextBox();
            this.SingleHandAdvanCB = new System.Windows.Forms.ComboBox();
            this.SingleHandAdvanL = new System.Windows.Forms.Label();
            this.PatGenderCB = new System.Windows.Forms.ComboBox();
            this.PatGenderL = new System.Windows.Forms.Label();
            this.PatNameL = new System.Windows.Forms.Label();
            this.PatNameTextBt = new System.Windows.Forms.TextBox();
            this.PatIDL = new System.Windows.Forms.Label();
            this.PatIDTextBt = new System.Windows.Forms.TextBox();
            this.DetectionInfoPanel = new System.Windows.Forms.Panel();
            this.FilePathL = new System.Windows.Forms.Label();
            this.FilePathTextBt = new System.Windows.Forms.TextBox();
            this.DetectionRemarksL = new System.Windows.Forms.Label();
            this.DetectionRemarksTextBt = new System.Windows.Forms.TextBox();
            this.PharmacyL = new System.Windows.Forms.Label();
            this.PharmacyTextBt = new System.Windows.Forms.TextBox();
            this.PationStateL = new System.Windows.Forms.Label();
            this.PationStateTextBt = new System.Windows.Forms.TextBox();
            this.PhysicianL = new System.Windows.Forms.Label();
            this.PhysicianTextBT = new System.Windows.Forms.TextBox();
            this.TechnicianL = new System.Windows.Forms.Label();
            this.TechnicianTextBt = new System.Windows.Forms.TextBox();
            this.RequesterL = new System.Windows.Forms.Label();
            this.RequesterTextBt = new System.Windows.Forms.TextBox();
            this.DetectinonL = new System.Windows.Forms.Label();
            this.DetectionTextBt = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartWave)).BeginInit();
            this.PationInfoPanel.SuspendLayout();
            this.DetectionInfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPlay,
            this.btnPause,
            this.toolStripSeparator1,
            this.labelPage,
            this.btnPrev,
            this.btnNext,
            this.InformationTSSSBt});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(942, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnPlay
            // 
            this.btnPlay.Image = ((System.Drawing.Image)(resources.GetObject("btnPlay.Image")));
            this.btnPlay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(52, 22);
            this.btnPlay.Text = "播放";
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnPause
            // 
            this.btnPause.Enabled = false;
            this.btnPause.Image = ((System.Drawing.Image)(resources.GetObject("btnPause.Image")));
            this.btnPause.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(52, 22);
            this.btnPause.Text = "暂停";
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // labelPage
            // 
            this.labelPage.AutoSize = false;
            this.labelPage.Name = "labelPage";
            this.labelPage.Size = new System.Drawing.Size(77, 22);
            this.labelPage.Text = "####/####";
            // 
            // btnPrev
            // 
            this.btnPrev.Enabled = false;
            this.btnPrev.Image = ((System.Drawing.Image)(resources.GetObject("btnPrev.Image")));
            this.btnPrev.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(46, 22);
            this.btnPrev.Text = "<<";
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(46, 22);
            this.btnNext.Text = ">>";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // InformationTSSSBt
            // 
            this.InformationTSSSBt.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pationInfoToolStripMenuItem,
            this.detectionInfoToolStripMenuItem,
            this.hideingToolStripMenuItem});
            this.InformationTSSSBt.Image = ((System.Drawing.Image)(resources.GetObject("InformationTSSSBt.Image")));
            this.InformationTSSSBt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.InformationTSSSBt.Name = "InformationTSSSBt";
            this.InformationTSSSBt.Size = new System.Drawing.Size(61, 22);
            this.InformationTSSSBt.Text = "信息";
            // 
            // pationInfoToolStripMenuItem
            // 
            this.pationInfoToolStripMenuItem.Name = "pationInfoToolStripMenuItem";
            this.pationInfoToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.pationInfoToolStripMenuItem.Text = "病人属性";
            this.pationInfoToolStripMenuItem.Click += new System.EventHandler(this.pationInfoToolStripMenuItem_Click);
            // 
            // detectionInfoToolStripMenuItem
            // 
            this.detectionInfoToolStripMenuItem.Name = "detectionInfoToolStripMenuItem";
            this.detectionInfoToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.detectionInfoToolStripMenuItem.Text = "检查属性";
            this.detectionInfoToolStripMenuItem.Click += new System.EventHandler(this.detectionInfoToolStripMenuItem_Click);
            // 
            // hideingToolStripMenuItem
            // 
            this.hideingToolStripMenuItem.Name = "hideingToolStripMenuItem";
            this.hideingToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.hideingToolStripMenuItem.Text = "隐藏";
            this.hideingToolStripMenuItem.Click += new System.EventHandler(this.hideingToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 560);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(942, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panelVideo
            // 
            this.panelVideo.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.panelVideo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelVideo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelVideo.Location = new System.Drawing.Point(770, 28);
            this.panelVideo.Name = "panelVideo";
            this.panelVideo.Size = new System.Drawing.Size(160, 120);
            this.panelVideo.TabIndex = 2;
            this.panelVideo.Click += new System.EventHandler(this.panelVideo_Click);
            // 
            // chartWave
            // 
            this.chartWave.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.AxisX.LabelStyle.Interval = 1D;
            chartArea1.AxisX.LabelStyle.IntervalOffset = 0D;
            chartArea1.AxisX.MajorGrid.Interval = 1D;
            chartArea1.AxisX.MajorGrid.IntervalOffset = 1D;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.LightSalmon;
            chartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisX.MajorTickMark.Interval = 1D;
            chartArea1.AxisX.MajorTickMark.IntervalOffset = 0D;
            chartArea1.AxisX.Maximum = 8D;
            chartArea1.AxisX.Minimum = 0D;
            stripLine1.BorderColor = System.Drawing.Color.Orange;
            stripLine1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            stripLine1.StripWidth = 0.01D;
            chartArea1.AxisX.StripLines.Add(stripLine1);
            chartArea1.AxisY.InterlacedColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.AxisY.IsInterlaced = true;
            chartArea1.AxisY.LabelStyle.Enabled = false;
            chartArea1.AxisY.MajorGrid.Interval = 100D;
            chartArea1.AxisY.MajorGrid.IntervalOffset = 0D;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.MajorTickMark.Interval = 100D;
            chartArea1.AxisY.MajorTickMark.IntervalOffset = 0D;
            chartArea1.AxisY.Maximum = 2000D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.Name = "mainArea";
            this.chartWave.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chartWave.Legends.Add(legend1);
            this.chartWave.Location = new System.Drawing.Point(12, 49);
            this.chartWave.Name = "chartWave";
            series1.ChartArea = "mainArea";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartWave.Series.Add(series1);
            this.chartWave.Size = new System.Drawing.Size(752, 508);
            this.chartWave.TabIndex = 3;
            this.chartWave.Text = "chart1";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // hsProgress
            // 
            this.hsProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hsProgress.Location = new System.Drawing.Point(12, 29);
            this.hsProgress.Name = "hsProgress";
            this.hsProgress.Size = new System.Drawing.Size(752, 17);
            this.hsProgress.TabIndex = 4;
            this.hsProgress.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsProgress_ValueChanged);
            this.hsProgress.MouseCaptureChanged += new System.EventHandler(this.hsProgress_MouseCaptureChanged);
            // 
            // panel_next
            // 
            this.panel_next.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_next.AutoScroll = true;
            this.panel_next.BackColor = System.Drawing.Color.White;
            this.panel_next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel_next.Location = new System.Drawing.Point(718, 49);
            this.panel_next.Margin = new System.Windows.Forms.Padding(0, 3, 30, 3);
            this.panel_next.Name = "panel_next";
            this.panel_next.Size = new System.Drawing.Size(37, 460);
            this.panel_next.TabIndex = 5;
            this.panel_next.Click += new System.EventHandler(this.panel_next_click);
            // 
            // panel_prev
            // 
            this.panel_prev.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel_prev.BackColor = System.Drawing.Color.White;
            this.panel_prev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel_prev.Location = new System.Drawing.Point(12, 49);
            this.panel_prev.Name = "panel_prev";
            this.panel_prev.Size = new System.Drawing.Size(35, 460);
            this.panel_prev.TabIndex = 0;
            this.panel_prev.Visible = false;
            this.panel_prev.Click += new System.EventHandler(this.panel_prev_click);
            // 
            // btn_enlarge
            // 
            this.btn_enlarge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_enlarge.Location = new System.Drawing.Point(770, 154);
            this.btn_enlarge.Name = "btn_enlarge";
            this.btn_enlarge.Size = new System.Drawing.Size(79, 25);
            this.btn_enlarge.TabIndex = 6;
            this.btn_enlarge.Text = "放大";
            this.btn_enlarge.UseVisualStyleBackColor = true;
            this.btn_enlarge.Click += new System.EventHandler(this.btn_enlarge_Click);
            // 
            // btn_shrink
            // 
            this.btn_shrink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_shrink.Location = new System.Drawing.Point(858, 154);
            this.btn_shrink.Name = "btn_shrink";
            this.btn_shrink.Size = new System.Drawing.Size(71, 24);
            this.btn_shrink.TabIndex = 7;
            this.btn_shrink.Text = "缩小";
            this.btn_shrink.UseVisualStyleBackColor = true;
            this.btn_shrink.Click += new System.EventHandler(this.btn_shrink_Click);
            // 
            // hsProgerss_Video
            // 
            this.hsProgerss_Video.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hsProgerss_Video.Location = new System.Drawing.Point(12, 539);
            this.hsProgerss_Video.Name = "hsProgerss_Video";
            this.hsProgerss_Video.Size = new System.Drawing.Size(743, 17);
            this.hsProgerss_Video.TabIndex = 8;
            this.hsProgerss_Video.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsProgerss_Video_Scroll);
            // 
            // PationInfo
            // 
            this.PationInfo.Name = "PationInfo";
            this.PationInfo.Size = new System.Drawing.Size(158, 22);
            this.PationInfo.Text = "Pation Info";
            // 
            // DetectionInfo
            // 
            this.DetectionInfo.Name = "DetectionInfo";
            this.DetectionInfo.Size = new System.Drawing.Size(158, 22);
            this.DetectionInfo.Text = "Detection Info";
            // 
            // Hiding
            // 
            this.Hiding.Name = "Hiding";
            this.Hiding.Size = new System.Drawing.Size(158, 22);
            this.Hiding.Text = "Hiding";
            // 
            // PationInfoPanel
            // 
            this.PationInfoPanel.AllowDrop = true;
            this.PationInfoPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PationInfoPanel.Controls.Add(this.PatAgeL);
            this.PationInfoPanel.Controls.Add(this.PatAgeTextBt);
            this.PationInfoPanel.Controls.Add(this.SingleHandAdvanCB);
            this.PationInfoPanel.Controls.Add(this.SingleHandAdvanL);
            this.PationInfoPanel.Controls.Add(this.PatGenderCB);
            this.PationInfoPanel.Controls.Add(this.PatGenderL);
            this.PationInfoPanel.Controls.Add(this.PatNameL);
            this.PationInfoPanel.Controls.Add(this.PatNameTextBt);
            this.PationInfoPanel.Controls.Add(this.PatIDL);
            this.PationInfoPanel.Controls.Add(this.PatIDTextBt);
            this.PationInfoPanel.Location = new System.Drawing.Point(76, 63);
            this.PationInfoPanel.Name = "PationInfoPanel";
            this.PationInfoPanel.Size = new System.Drawing.Size(264, 145);
            this.PationInfoPanel.TabIndex = 1;
            this.PationInfoPanel.Visible = false;
            this.PationInfoPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PationInfoPanel_MouseDown);
            this.PationInfoPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PationInfoPanel_MouseMove);
            // 
            // PatAgeL
            // 
            this.PatAgeL.AllowDrop = true;
            this.PatAgeL.AutoSize = true;
            this.PatAgeL.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PatAgeL.Location = new System.Drawing.Point(12, 62);
            this.PatAgeL.Name = "PatAgeL";
            this.PatAgeL.Size = new System.Drawing.Size(29, 12);
            this.PatAgeL.TabIndex = 21;
            this.PatAgeL.Text = "年龄";
            this.PatAgeL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PatAgeTextBt
            // 
            this.PatAgeTextBt.Enabled = false;
            this.PatAgeTextBt.Location = new System.Drawing.Point(59, 57);
            this.PatAgeTextBt.Multiline = true;
            this.PatAgeTextBt.Name = "PatAgeTextBt";
            this.PatAgeTextBt.Size = new System.Drawing.Size(190, 20);
            this.PatAgeTextBt.TabIndex = 20;
            // 
            // SingleHandAdvanCB
            // 
            this.SingleHandAdvanCB.AllowDrop = true;
            this.SingleHandAdvanCB.Enabled = false;
            this.SingleHandAdvanCB.FormattingEnabled = true;
            this.SingleHandAdvanCB.Location = new System.Drawing.Point(59, 115);
            this.SingleHandAdvanCB.MaxLength = 32767;
            this.SingleHandAdvanCB.Name = "SingleHandAdvanCB";
            this.SingleHandAdvanCB.Size = new System.Drawing.Size(190, 20);
            this.SingleHandAdvanCB.TabIndex = 19;
            // 
            // SingleHandAdvanL
            // 
            this.SingleHandAdvanL.Location = new System.Drawing.Point(12, 118);
            this.SingleHandAdvanL.Name = "SingleHandAdvanL";
            this.SingleHandAdvanL.Size = new System.Drawing.Size(41, 14);
            this.SingleHandAdvanL.TabIndex = 18;
            this.SingleHandAdvanL.Text = "左右利";
            // 
            // PatGenderCB
            // 
            this.PatGenderCB.AllowDrop = true;
            this.PatGenderCB.Enabled = false;
            this.PatGenderCB.FormattingEnabled = true;
            this.PatGenderCB.Location = new System.Drawing.Point(59, 85);
            this.PatGenderCB.MaxLength = 32767;
            this.PatGenderCB.Name = "PatGenderCB";
            this.PatGenderCB.Size = new System.Drawing.Size(190, 20);
            this.PatGenderCB.TabIndex = 17;
            // 
            // PatGenderL
            // 
            this.PatGenderL.AutoSize = true;
            this.PatGenderL.Location = new System.Drawing.Point(12, 88);
            this.PatGenderL.Name = "PatGenderL";
            this.PatGenderL.Size = new System.Drawing.Size(29, 12);
            this.PatGenderL.TabIndex = 16;
            this.PatGenderL.Text = "性别";
            // 
            // PatNameL
            // 
            this.PatNameL.AllowDrop = true;
            this.PatNameL.AutoSize = true;
            this.PatNameL.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PatNameL.Location = new System.Drawing.Point(12, 36);
            this.PatNameL.Name = "PatNameL";
            this.PatNameL.Size = new System.Drawing.Size(29, 12);
            this.PatNameL.TabIndex = 3;
            this.PatNameL.Text = "姓名";
            this.PatNameL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PatNameTextBt
            // 
            this.PatNameTextBt.Enabled = false;
            this.PatNameTextBt.Location = new System.Drawing.Point(59, 31);
            this.PatNameTextBt.Multiline = true;
            this.PatNameTextBt.Name = "PatNameTextBt";
            this.PatNameTextBt.Size = new System.Drawing.Size(190, 20);
            this.PatNameTextBt.TabIndex = 2;
            // 
            // PatIDL
            // 
            this.PatIDL.AutoSize = true;
            this.PatIDL.Location = new System.Drawing.Point(12, 8);
            this.PatIDL.Name = "PatIDL";
            this.PatIDL.Size = new System.Drawing.Size(41, 12);
            this.PatIDL.TabIndex = 1;
            this.PatIDL.Text = "病人ID";
            // 
            // PatIDTextBt
            // 
            this.PatIDTextBt.Enabled = false;
            this.PatIDTextBt.Location = new System.Drawing.Point(59, 5);
            this.PatIDTextBt.Multiline = true;
            this.PatIDTextBt.Name = "PatIDTextBt";
            this.PatIDTextBt.Size = new System.Drawing.Size(190, 20);
            this.PatIDTextBt.TabIndex = 0;
            // 
            // DetectionInfoPanel
            // 
            this.DetectionInfoPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.DetectionInfoPanel.Controls.Add(this.FilePathL);
            this.DetectionInfoPanel.Controls.Add(this.FilePathTextBt);
            this.DetectionInfoPanel.Controls.Add(this.DetectionRemarksL);
            this.DetectionInfoPanel.Controls.Add(this.DetectionRemarksTextBt);
            this.DetectionInfoPanel.Controls.Add(this.PharmacyL);
            this.DetectionInfoPanel.Controls.Add(this.PharmacyTextBt);
            this.DetectionInfoPanel.Controls.Add(this.PationStateL);
            this.DetectionInfoPanel.Controls.Add(this.PationStateTextBt);
            this.DetectionInfoPanel.Controls.Add(this.PhysicianL);
            this.DetectionInfoPanel.Controls.Add(this.PhysicianTextBT);
            this.DetectionInfoPanel.Controls.Add(this.TechnicianL);
            this.DetectionInfoPanel.Controls.Add(this.TechnicianTextBt);
            this.DetectionInfoPanel.Controls.Add(this.RequesterL);
            this.DetectionInfoPanel.Controls.Add(this.RequesterTextBt);
            this.DetectionInfoPanel.Controls.Add(this.DetectinonL);
            this.DetectionInfoPanel.Controls.Add(this.DetectionTextBt);
            this.DetectionInfoPanel.Location = new System.Drawing.Point(76, 63);
            this.DetectionInfoPanel.Name = "DetectionInfoPanel";
            this.DetectionInfoPanel.Size = new System.Drawing.Size(280, 291);
            this.DetectionInfoPanel.TabIndex = 2;
            this.DetectionInfoPanel.Visible = false;
            this.DetectionInfoPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DetectionInfoPanel_MouseDown);
            this.DetectionInfoPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DetectionInfoPanel_MouseMove);
            // 
            // FilePathL
            // 
            this.FilePathL.AutoSize = true;
            this.FilePathL.Location = new System.Drawing.Point(13, 245);
            this.FilePathL.Name = "FilePathL";
            this.FilePathL.Size = new System.Drawing.Size(53, 12);
            this.FilePathL.TabIndex = 43;
            this.FilePathL.Text = "文件路径";
            // 
            // FilePathTextBt
            // 
            this.FilePathTextBt.Enabled = false;
            this.FilePathTextBt.Location = new System.Drawing.Point(72, 223);
            this.FilePathTextBt.Multiline = true;
            this.FilePathTextBt.Name = "FilePathTextBt";
            this.FilePathTextBt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.FilePathTextBt.Size = new System.Drawing.Size(190, 56);
            this.FilePathTextBt.TabIndex = 42;
            // 
            // DetectionRemarksL
            // 
            this.DetectionRemarksL.AutoSize = true;
            this.DetectionRemarksL.Location = new System.Drawing.Point(13, 182);
            this.DetectionRemarksL.Name = "DetectionRemarksL";
            this.DetectionRemarksL.Size = new System.Drawing.Size(53, 12);
            this.DetectionRemarksL.TabIndex = 39;
            this.DetectionRemarksL.Text = "检验备注";
            // 
            // DetectionRemarksTextBt
            // 
            this.DetectionRemarksTextBt.Enabled = false;
            this.DetectionRemarksTextBt.Location = new System.Drawing.Point(72, 159);
            this.DetectionRemarksTextBt.Multiline = true;
            this.DetectionRemarksTextBt.Name = "DetectionRemarksTextBt";
            this.DetectionRemarksTextBt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DetectionRemarksTextBt.Size = new System.Drawing.Size(190, 58);
            this.DetectionRemarksTextBt.TabIndex = 38;
            // 
            // PharmacyL
            // 
            this.PharmacyL.AutoSize = true;
            this.PharmacyL.Location = new System.Drawing.Point(13, 137);
            this.PharmacyL.Name = "PharmacyL";
            this.PharmacyL.Size = new System.Drawing.Size(29, 12);
            this.PharmacyL.TabIndex = 37;
            this.PharmacyL.Text = "用药";
            // 
            // PharmacyTextBt
            // 
            this.PharmacyTextBt.Enabled = false;
            this.PharmacyTextBt.Location = new System.Drawing.Point(72, 133);
            this.PharmacyTextBt.Multiline = true;
            this.PharmacyTextBt.Name = "PharmacyTextBt";
            this.PharmacyTextBt.Size = new System.Drawing.Size(190, 20);
            this.PharmacyTextBt.TabIndex = 36;
            // 
            // PationStateL
            // 
            this.PationStateL.AutoSize = true;
            this.PationStateL.Location = new System.Drawing.Point(13, 111);
            this.PationStateL.Name = "PationStateL";
            this.PationStateL.Size = new System.Drawing.Size(53, 12);
            this.PationStateL.TabIndex = 35;
            this.PationStateL.Text = "病人状态";
            // 
            // PationStateTextBt
            // 
            this.PationStateTextBt.Enabled = false;
            this.PationStateTextBt.Location = new System.Drawing.Point(72, 107);
            this.PationStateTextBt.Multiline = true;
            this.PationStateTextBt.Name = "PationStateTextBt";
            this.PationStateTextBt.Size = new System.Drawing.Size(190, 20);
            this.PationStateTextBt.TabIndex = 34;
            // 
            // PhysicianL
            // 
            this.PhysicianL.AutoSize = true;
            this.PhysicianL.Location = new System.Drawing.Point(13, 85);
            this.PhysicianL.Name = "PhysicianL";
            this.PhysicianL.Size = new System.Drawing.Size(29, 12);
            this.PhysicianL.TabIndex = 29;
            this.PhysicianL.Text = "医师";
            // 
            // PhysicianTextBT
            // 
            this.PhysicianTextBT.Enabled = false;
            this.PhysicianTextBT.Location = new System.Drawing.Point(72, 81);
            this.PhysicianTextBT.Multiline = true;
            this.PhysicianTextBT.Name = "PhysicianTextBT";
            this.PhysicianTextBT.Size = new System.Drawing.Size(190, 20);
            this.PhysicianTextBT.TabIndex = 28;
            // 
            // TechnicianL
            // 
            this.TechnicianL.AutoSize = true;
            this.TechnicianL.Location = new System.Drawing.Point(13, 60);
            this.TechnicianL.Name = "TechnicianL";
            this.TechnicianL.Size = new System.Drawing.Size(29, 12);
            this.TechnicianL.TabIndex = 27;
            this.TechnicianL.Text = "技师";
            // 
            // TechnicianTextBt
            // 
            this.TechnicianTextBt.Enabled = false;
            this.TechnicianTextBt.Location = new System.Drawing.Point(72, 56);
            this.TechnicianTextBt.Multiline = true;
            this.TechnicianTextBt.Name = "TechnicianTextBt";
            this.TechnicianTextBt.Size = new System.Drawing.Size(190, 20);
            this.TechnicianTextBt.TabIndex = 26;
            // 
            // RequesterL
            // 
            this.RequesterL.AutoSize = true;
            this.RequesterL.Location = new System.Drawing.Point(13, 34);
            this.RequesterL.Name = "RequesterL";
            this.RequesterL.Size = new System.Drawing.Size(41, 12);
            this.RequesterL.TabIndex = 25;
            this.RequesterL.Text = "申请者";
            // 
            // RequesterTextBt
            // 
            this.RequesterTextBt.Enabled = false;
            this.RequesterTextBt.Location = new System.Drawing.Point(72, 30);
            this.RequesterTextBt.Multiline = true;
            this.RequesterTextBt.Name = "RequesterTextBt";
            this.RequesterTextBt.Size = new System.Drawing.Size(190, 20);
            this.RequesterTextBt.TabIndex = 24;
            // 
            // DetectinonL
            // 
            this.DetectinonL.AutoSize = true;
            this.DetectinonL.Location = new System.Drawing.Point(13, 8);
            this.DetectinonL.Name = "DetectinonL";
            this.DetectinonL.Size = new System.Drawing.Size(41, 12);
            this.DetectinonL.TabIndex = 21;
            this.DetectinonL.Text = "检查号";
            // 
            // DetectionTextBt
            // 
            this.DetectionTextBt.Enabled = false;
            this.DetectionTextBt.Location = new System.Drawing.Point(72, 4);
            this.DetectionTextBt.Multiline = true;
            this.DetectionTextBt.Name = "DetectionTextBt";
            this.DetectionTextBt.Size = new System.Drawing.Size(190, 20);
            this.DetectionTextBt.TabIndex = 20;
            // 
            // PlaybackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 582);
            this.Controls.Add(this.panelVideo);
            this.Controls.Add(this.PationInfoPanel);
            this.Controls.Add(this.DetectionInfoPanel);
            this.Controls.Add(this.chartWave);
            this.Controls.Add(this.hsProgerss_Video);
            this.Controls.Add(this.btn_shrink);
            this.Controls.Add(this.btn_enlarge);
            this.Controls.Add(this.panel_prev);
            this.Controls.Add(this.panel_next);
            this.Controls.Add(this.hsProgress);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PlaybackForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "脑电视频回放";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PlaybackForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartWave)).EndInit();
            this.PationInfoPanel.ResumeLayout(false);
            this.PationInfoPanel.PerformLayout();
            this.DetectionInfoPanel.ResumeLayout(false);
            this.DetectionInfoPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panelVideo;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartWave;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStripButton btnPause;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnNext;
        private System.Windows.Forms.ToolStripButton btnPrev;
        private System.Windows.Forms.ToolStripLabel labelPage;
        private System.Windows.Forms.HScrollBar hsProgress;
        private System.Windows.Forms.Panel panel_next;
        private System.Windows.Forms.Panel panel_prev;
        private System.Windows.Forms.Button btn_enlarge;
        private System.Windows.Forms.Button btn_shrink;
        private System.Windows.Forms.HScrollBar hsProgerss_Video;

        //////////////////////////////////////////////////////////////////////////////////////////////////////////
        private System.Windows.Forms.ToolStripMenuItem PationInfo;
        private System.Windows.Forms.ToolStripMenuItem DetectionInfo;
        private System.Windows.Forms.ToolStripMenuItem Hiding;
        private System.Windows.Forms.Panel PationInfoPanel;
        private System.Windows.Forms.Label PatIDL;
        private System.Windows.Forms.TextBox PatIDTextBt;
        private System.Windows.Forms.Label PatNameL;
        private System.Windows.Forms.TextBox PatNameTextBt;
        private System.Windows.Forms.Label PatGenderL;
        private System.Windows.Forms.ComboBox SingleHandAdvanCB;
        private System.Windows.Forms.Label SingleHandAdvanL;
        private System.Windows.Forms.Panel DetectionInfoPanel;
        private System.Windows.Forms.Label DetectinonL;
        private System.Windows.Forms.TextBox DetectionTextBt;
        private System.Windows.Forms.Label DetectionRemarksL;
        private System.Windows.Forms.TextBox DetectionRemarksTextBt;
        private System.Windows.Forms.Label PharmacyL;
        private System.Windows.Forms.TextBox PharmacyTextBt;
        private System.Windows.Forms.Label PationStateL;
        private System.Windows.Forms.TextBox PationStateTextBt;
        private System.Windows.Forms.Label PhysicianL;
        private System.Windows.Forms.TextBox PhysicianTextBT;
        private System.Windows.Forms.Label TechnicianL;
        private System.Windows.Forms.TextBox TechnicianTextBt;
        private System.Windows.Forms.Label RequesterL;
        private System.Windows.Forms.TextBox RequesterTextBt;
        private System.Windows.Forms.ComboBox PatGenderCB;
        private System.Windows.Forms.Label PatAgeL;
        private System.Windows.Forms.TextBox PatAgeTextBt;
        private System.Windows.Forms.ToolStripButton btnPlay;
        private System.Windows.Forms.ToolStripDropDownButton InformationTSSSBt;
        private System.Windows.Forms.ToolStripMenuItem pationInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detectionInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideingToolStripMenuItem;
        private System.Windows.Forms.Label FilePathL;
        private System.Windows.Forms.TextBox FilePathTextBt;
        //////////////////////////////////////////////////////////////////////////////////////////////////////////
    }
}