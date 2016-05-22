namespace VeegStation
{
    partial class StationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StationForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnPlayBack = new System.Windows.Forms.ToolStripButton();
            this.btnRecord = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAssociate = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.picturePreview = new System.Windows.Forms.PictureBox();
            this.chartWave = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timerProbe = new System.Windows.Forms.Timer(this.components);
            this.timerVideo = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.labelUSBStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelVideoStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lvFiles = new System.Windows.Forms.ListView();
            this.HasVideo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SerialNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PatientName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Duration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StartTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lvVideoFiles = new System.Windows.Forms.ListView();
            this.HasEeg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RecordTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VideoDuration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartWave)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPlayBack,
            this.btnRecord,
            this.toolStripSeparator3,
            this.btnAssociate,
            this.toolStripSeparator4,
            this.btnRefresh});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(944, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnPlayBack
            // 
            this.btnPlayBack.Image = ((System.Drawing.Image)(resources.GetObject("btnPlayBack.Image")));
            this.btnPlayBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPlayBack.Name = "btnPlayBack";
            this.btnPlayBack.Size = new System.Drawing.Size(76, 22);
            this.btnPlayBack.Text = "数据回放";
            this.btnPlayBack.Click += new System.EventHandler(this.btnPlayBack_Click);
            // 
            // btnRecord
            // 
            this.btnRecord.Image = ((System.Drawing.Image)(resources.GetObject("btnRecord.Image")));
            this.btnRecord.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(76, 22);
            this.btnRecord.Text = "录制视频";
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnAssociate
            // 
            this.btnAssociate.Image = ((System.Drawing.Image)(resources.GetObject("btnAssociate.Image")));
            this.btnAssociate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAssociate.Name = "btnAssociate";
            this.btnAssociate.Size = new System.Drawing.Size(76, 22);
            this.btnAssociate.Text = "视频关联";
            this.btnAssociate.Click += new System.EventHandler(this.toolButtonAssociate_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(76, 22);
            this.btnRefresh.Text = "刷新文件";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // picturePreview
            // 
            this.picturePreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picturePreview.BackColor = System.Drawing.Color.Black;
            this.picturePreview.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.picturePreview.Location = new System.Drawing.Point(6, 19);
            this.picturePreview.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picturePreview.Name = "picturePreview";
            this.picturePreview.Size = new System.Drawing.Size(192, 144);
            this.picturePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePreview.TabIndex = 2;
            this.picturePreview.TabStop = false;
            // 
            // chartWave
            // 
            this.chartWave.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartWave.BackColor = System.Drawing.SystemColors.Control;
            chartArea1.AxisX.InterlacedColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.AxisX.LabelStyle.Interval = 1D;
            chartArea1.AxisX.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorGrid.Interval = 1D;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.PowderBlue;
            chartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDotDot;
            chartArea1.AxisX.MajorTickMark.Interval = 1D;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Gray;
            chartArea1.AxisX.Maximum = 8D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisX.MinorGrid.Enabled = true;
            chartArea1.AxisX.MinorGrid.Interval = 128D;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.SkyBlue;
            chartArea1.AxisX.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisY.InterlacedColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.AxisY.IsInterlaced = true;
            chartArea1.AxisY.LabelStyle.Enabled = false;
            chartArea1.AxisY.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MajorGrid.Interval = 200D;
            chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea1.AxisY.MajorTickMark.Enabled = false;
            chartArea1.AxisY.Maximum = 4000D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.BackColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.chartWave.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chartWave.Legends.Add(legend1);
            this.chartWave.Location = new System.Drawing.Point(771, 497);
            this.chartWave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chartWave.Name = "chartWave";
            this.chartWave.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartWave.Series.Add(series1);
            this.chartWave.Size = new System.Drawing.Size(149, 153);
            this.chartWave.TabIndex = 3;
            this.chartWave.Text = "chart1";
            this.chartWave.Visible = false;
            // 
            // timerProbe
            // 
            this.timerProbe.Interval = 200;
            // 
            // timerVideo
            // 
            this.timerVideo.Interval = 40;
            this.timerVideo.Tick += new System.EventHandler(this.timerVideo_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelUSBStatus,
            this.labelVideoStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 656);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(944, 26);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // labelUSBStatus
            // 
            this.labelUSBStatus.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.labelUSBStatus.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.labelUSBStatus.Enabled = false;
            this.labelUSBStatus.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelUSBStatus.Name = "labelUSBStatus";
            this.labelUSBStatus.Size = new System.Drawing.Size(48, 21);
            this.labelUSBStatus.Text = "脑电仪";
            // 
            // labelVideoStatus
            // 
            this.labelVideoStatus.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.labelVideoStatus.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.labelVideoStatus.Enabled = false;
            this.labelVideoStatus.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelVideoStatus.Name = "labelVideoStatus";
            this.labelVideoStatus.Size = new System.Drawing.Size(48, 21);
            this.labelVideoStatus.Text = "摄像机";
            // 
            // lvFiles
            // 
            this.lvFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvFiles.BackColor = System.Drawing.SystemColors.Window;
            this.lvFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.HasVideo,
            this.SerialNo,
            this.PatientName,
            this.Duration,
            this.StartTime});
            this.lvFiles.FullRowSelect = true;
            this.lvFiles.GridLines = true;
            this.lvFiles.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvFiles.HideSelection = false;
            this.lvFiles.Location = new System.Drawing.Point(3, 19);
            this.lvFiles.Name = "lvFiles";
            this.lvFiles.OwnerDraw = true;
            this.lvFiles.Size = new System.Drawing.Size(416, 603);
            this.lvFiles.TabIndex = 5;
            this.lvFiles.UseCompatibleStateImageBehavior = false;
            this.lvFiles.View = System.Windows.Forms.View.Details;
            this.lvFiles.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.My_DrawColumnHeader);
            this.lvFiles.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.My_DrawItem);
            this.lvFiles.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.My_DrawSubItem);
            this.lvFiles.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvFiles_ItemSelectionChanged);
            // 
            // HasVideo
            // 
            this.HasVideo.Text = "";
            this.HasVideo.Width = 25;
            // 
            // SerialNo
            // 
            this.SerialNo.Text = "脑电图号";
            this.SerialNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SerialNo.Width = 115;
            // 
            // PatientName
            // 
            this.PatientName.Text = "姓名";
            this.PatientName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PatientName.Width = 55;
            // 
            // Duration
            // 
            this.Duration.Text = "时长";
            this.Duration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Duration.Width = 65;
            // 
            // StartTime
            // 
            this.StartTime.Text = "检查日期";
            this.StartTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.StartTime.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "脑电数据";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "未关联视频文件";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 28);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lvFiles);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lvVideoFiles);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Size = new System.Drawing.Size(712, 625);
            this.splitContainer1.SplitterDistance = 422;
            this.splitContainer1.TabIndex = 9;
            // 
            // lvVideoFiles
            // 
            this.lvVideoFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvVideoFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.HasEeg,
            this.RecordTime,
            this.VideoDuration});
            this.lvVideoFiles.FullRowSelect = true;
            this.lvVideoFiles.GridLines = true;
            this.lvVideoFiles.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvVideoFiles.HideSelection = false;
            this.lvVideoFiles.Location = new System.Drawing.Point(6, 19);
            this.lvVideoFiles.Name = "lvVideoFiles";
            this.lvVideoFiles.OwnerDraw = true;
            this.lvVideoFiles.Size = new System.Drawing.Size(277, 603);
            this.lvVideoFiles.TabIndex = 9;
            this.lvVideoFiles.UseCompatibleStateImageBehavior = false;
            this.lvVideoFiles.View = System.Windows.Forms.View.Details;
            this.lvVideoFiles.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.My_DrawColumnHeader);
            this.lvVideoFiles.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.My_DrawItem);
            this.lvVideoFiles.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.My_DrawSubItem);
            this.lvVideoFiles.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvVideoFiles_ItemSelectionChanged);
            this.lvVideoFiles.Leave += new System.EventHandler(this.lvVideoFiles_Leave);
            // 
            // HasEeg
            // 
            this.HasEeg.Text = "";
            this.HasEeg.Width = 20;
            // 
            // RecordTime
            // 
            this.RecordTime.Text = "录制日期";
            this.RecordTime.Width = 128;
            // 
            // VideoDuration
            // 
            this.VideoDuration.Text = "时长";
            this.VideoDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(747, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "脑电详情";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.picturePreview);
            this.groupBox1.Location = new System.Drawing.Point(730, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 170);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "视频预览";
            // 
            // StationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 682);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.chartWave);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "StationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "杭州妞诺视频和脑电数据同步回放软件";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AcqForm_FormClosed);
            this.Load += new System.EventHandler(this.AcqForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.StationForm_KeyDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartWave)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.PictureBox picturePreview;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartWave;
        private System.Windows.Forms.Timer timerProbe;
        private System.Windows.Forms.Timer timerVideo;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel labelUSBStatus;
        private System.Windows.Forms.ToolStripStatusLabel labelVideoStatus;
        private System.Windows.Forms.ListView lvFiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripButton btnRecord;
        private System.Windows.Forms.ToolStripButton btnAssociate;
        private System.Windows.Forms.ToolStripButton btnPlayBack;
        private System.Windows.Forms.ColumnHeader HasVideo;
        private System.Windows.Forms.ColumnHeader SerialNo;
        private System.Windows.Forms.ColumnHeader PatientName;
        private System.Windows.Forms.ColumnHeader Duration;
        private System.Windows.Forms.ColumnHeader StartTime;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView lvVideoFiles;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ColumnHeader RecordTime;
        private System.Windows.Forms.ColumnHeader VideoDuration;
        private System.Windows.Forms.ColumnHeader HasEeg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripButton btnRefresh;
    }
}

