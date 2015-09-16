namespace OnlineMonitor
{
    partial class MonitorFrm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonitorFrm));
            this.ExitBtn = new System.Windows.Forms.Button();
            this.MiniBtn = new System.Windows.Forms.Button();
            this.MainLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackgroundImage = global::OnlineMonitor.Properties.Resources.Exit;
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Location = new System.Drawing.Point(870, 0);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(30, 30);
            this.ExitBtn.TabIndex = 2;
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // MiniBtn
            // 
            this.MiniBtn.BackgroundImage = global::OnlineMonitor.Properties.Resources.MiniSize;
            this.MiniBtn.FlatAppearance.BorderSize = 0;
            this.MiniBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MiniBtn.Location = new System.Drawing.Point(840, 0);
            this.MiniBtn.Name = "MiniBtn";
            this.MiniBtn.Size = new System.Drawing.Size(30, 30);
            this.MiniBtn.TabIndex = 1;
            this.MiniBtn.UseVisualStyleBackColor = true;
            // 
            // MainLabel
            // 
            this.MainLabel.Image = global::OnlineMonitor.Properties.Resources.MonitorText;
            this.MainLabel.Location = new System.Drawing.Point(0, 0);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(840, 30);
            this.MainLabel.TabIndex = 0;
            this.MainLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MonitorFrm_MouseDown);
            this.MainLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MonitorFrm_MouseMove);
            this.MainLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MonitorFrm_MouseUp);
            // 
            // MonitorFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(900, 480);
            this.ControlBox = false;
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.MiniBtn);
            this.Controls.Add(this.MainLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 480);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(900, 480);
            this.Name = "MonitorFrm";
            this.Text = "Online Monitor";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MonitorFrm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MonitorFrm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MonitorFrm_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.Button MiniBtn;
        private System.Windows.Forms.Button ExitBtn;
    }
}

