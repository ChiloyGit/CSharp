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
            this.MainPanle = new System.Windows.Forms.Panel();
            this.SetBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.HomeBtn = new System.Windows.Forms.Button();
            this.MainLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MainPanle
            // 
            this.MainPanle.BackColor = System.Drawing.Color.Violet;
            this.MainPanle.Location = new System.Drawing.Point(30, 30);
            this.MainPanle.Name = "MainPanle";
            this.MainPanle.Size = new System.Drawing.Size(840, 420);
            this.MainPanle.TabIndex = 4;
            // 
            // SetBtn
            // 
            this.SetBtn.BackgroundImage = global::OnlineMonitor.Properties.Resources.Setting;
            this.SetBtn.FlatAppearance.BorderSize = 0;
            this.SetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetBtn.Location = new System.Drawing.Point(840, 0);
            this.SetBtn.Name = "SetBtn";
            this.SetBtn.Size = new System.Drawing.Size(30, 30);
            this.SetBtn.TabIndex = 3;
            this.SetBtn.UseVisualStyleBackColor = true;
            this.SetBtn.Click += new System.EventHandler(this.SetBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Image = global::OnlineMonitor.Properties.Resources.Exit;
            this.ExitBtn.Location = new System.Drawing.Point(870, 0);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(30, 30);
            this.ExitBtn.TabIndex = 2;
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // HomeBtn
            // 
            this.HomeBtn.FlatAppearance.BorderSize = 0;
            this.HomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeBtn.Image = global::OnlineMonitor.Properties.Resources.Home;
            this.HomeBtn.Location = new System.Drawing.Point(810, 0);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(30, 30);
            this.HomeBtn.TabIndex = 1;
            this.HomeBtn.UseVisualStyleBackColor = true;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // MainLabel
            // 
            this.MainLabel.Image = global::OnlineMonitor.Properties.Resources.MonitorText;
            this.MainLabel.Location = new System.Drawing.Point(0, 0);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(810, 30);
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
            this.Controls.Add(this.MainPanle);
            this.Controls.Add(this.SetBtn);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.HomeBtn);
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
        private System.Windows.Forms.Button HomeBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button SetBtn;
        private System.Windows.Forms.Panel MainPanle;
    }
}

