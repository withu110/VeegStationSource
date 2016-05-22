namespace VeegStation
{
    partial class RecordingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecordingForm));
            this.panelPreview = new System.Windows.Forms.Panel();
            this.textNow = new System.Windows.Forms.TextBox();
            this.textDuration = new System.Windows.Forms.TextBox();
            this.timerShowNow = new System.Windows.Forms.Timer(this.components);
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelPreview
            // 
            this.panelPreview.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelPreview.Location = new System.Drawing.Point(12, 69);
            this.panelPreview.Name = "panelPreview";
            this.panelPreview.Size = new System.Drawing.Size(720, 540);
            this.panelPreview.TabIndex = 0;
            // 
            // textNow
            // 
            this.textNow.BackColor = System.Drawing.Color.DimGray;
            this.textNow.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNow.ForeColor = System.Drawing.Color.Lime;
            this.textNow.Location = new System.Drawing.Point(12, 12);
            this.textNow.Name = "textNow";
            this.textNow.ReadOnly = true;
            this.textNow.Size = new System.Drawing.Size(307, 36);
            this.textNow.TabIndex = 1;
            this.textNow.TabStop = false;
            this.textNow.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textDuration
            // 
            this.textDuration.BackColor = System.Drawing.Color.DimGray;
            this.textDuration.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDuration.ForeColor = System.Drawing.Color.Lime;
            this.textDuration.Location = new System.Drawing.Point(325, 12);
            this.textDuration.Name = "textDuration";
            this.textDuration.ReadOnly = true;
            this.textDuration.Size = new System.Drawing.Size(160, 36);
            this.textDuration.TabIndex = 2;
            this.textDuration.TabStop = false;
            this.textDuration.Text = "N/A";
            this.textDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // timerShowNow
            // 
            this.timerShowNow.Enabled = true;
            this.timerShowNow.Tick += new System.EventHandler(this.timerShowNow_Tick);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(560, 10);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 3;
            this.buttonStart.Text = "录制";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(641, 10);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 4;
            this.buttonStop.Text = "结束";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // RecordingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 621);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textDuration);
            this.Controls.Add(this.textNow);
            this.Controls.Add(this.panelPreview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RecordingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "录制视频";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RecordingForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RecordingForm_FormClosed);
            this.Load += new System.EventHandler(this.RecordingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelPreview;
        private System.Windows.Forms.TextBox textNow;
        private System.Windows.Forms.TextBox textDuration;
        private System.Windows.Forms.Timer timerShowNow;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
    }
}