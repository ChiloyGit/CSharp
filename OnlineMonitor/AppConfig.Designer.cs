namespace OnlineMonitor
{
    partial class AppConfig
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.ConfigSplitContainer = new System.Windows.Forms.SplitContainer();
            this.AboutConfigBtn = new System.Windows.Forms.Button();
            this.DevConfigBtn = new System.Windows.Forms.Button();
            this.UserConfigBtn = new System.Windows.Forms.Button();
            this.GenaConfigBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ConfigSplitContainer)).BeginInit();
            this.ConfigSplitContainer.Panel1.SuspendLayout();
            this.ConfigSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConfigSplitContainer
            // 
            this.ConfigSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConfigSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.ConfigSplitContainer.IsSplitterFixed = true;
            this.ConfigSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.ConfigSplitContainer.Name = "ConfigSplitContainer";
            // 
            // ConfigSplitContainer.Panel1
            // 
            this.ConfigSplitContainer.Panel1.Controls.Add(this.AboutConfigBtn);
            this.ConfigSplitContainer.Panel1.Controls.Add(this.DevConfigBtn);
            this.ConfigSplitContainer.Panel1.Controls.Add(this.UserConfigBtn);
            this.ConfigSplitContainer.Panel1.Controls.Add(this.GenaConfigBtn);
            this.ConfigSplitContainer.Panel1MinSize = 100;
            this.ConfigSplitContainer.Size = new System.Drawing.Size(840, 420);
            this.ConfigSplitContainer.SplitterDistance = 125;
            this.ConfigSplitContainer.TabIndex = 0;
            // 
            // AboutConfigBtn
            // 
            this.AboutConfigBtn.BackColor = System.Drawing.Color.Purple;
            this.AboutConfigBtn.FlatAppearance.BorderSize = 0;
            this.AboutConfigBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutConfigBtn.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AboutConfigBtn.ForeColor = System.Drawing.Color.Transparent;
            this.AboutConfigBtn.Location = new System.Drawing.Point(25, 331);
            this.AboutConfigBtn.Name = "AboutConfigBtn";
            this.AboutConfigBtn.Size = new System.Drawing.Size(75, 25);
            this.AboutConfigBtn.TabIndex = 3;
            this.AboutConfigBtn.Text = "关 于";
            this.AboutConfigBtn.UseVisualStyleBackColor = false;
            this.AboutConfigBtn.Click += new System.EventHandler(this.AboutConfigBtn_Click);
            // 
            // DevConfigBtn
            // 
            this.DevConfigBtn.BackColor = System.Drawing.Color.Purple;
            this.DevConfigBtn.FlatAppearance.BorderSize = 0;
            this.DevConfigBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DevConfigBtn.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DevConfigBtn.ForeColor = System.Drawing.Color.Transparent;
            this.DevConfigBtn.Location = new System.Drawing.Point(25, 242);
            this.DevConfigBtn.Name = "DevConfigBtn";
            this.DevConfigBtn.Size = new System.Drawing.Size(75, 25);
            this.DevConfigBtn.TabIndex = 2;
            this.DevConfigBtn.Text = "设 备";
            this.DevConfigBtn.UseVisualStyleBackColor = false;
            this.DevConfigBtn.Click += new System.EventHandler(this.DevConfigBtn_Click);
            // 
            // UserConfigBtn
            // 
            this.UserConfigBtn.BackColor = System.Drawing.Color.Purple;
            this.UserConfigBtn.FlatAppearance.BorderSize = 0;
            this.UserConfigBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserConfigBtn.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UserConfigBtn.ForeColor = System.Drawing.Color.Transparent;
            this.UserConfigBtn.Location = new System.Drawing.Point(25, 153);
            this.UserConfigBtn.Name = "UserConfigBtn";
            this.UserConfigBtn.Size = new System.Drawing.Size(75, 25);
            this.UserConfigBtn.TabIndex = 1;
            this.UserConfigBtn.Text = "用 户";
            this.UserConfigBtn.UseVisualStyleBackColor = false;
            this.UserConfigBtn.Click += new System.EventHandler(this.UserConfigBtn_Click);
            // 
            // GenaConfigBtn
            // 
            this.GenaConfigBtn.BackColor = System.Drawing.Color.Purple;
            this.GenaConfigBtn.FlatAppearance.BorderSize = 0;
            this.GenaConfigBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenaConfigBtn.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GenaConfigBtn.ForeColor = System.Drawing.Color.Transparent;
            this.GenaConfigBtn.Location = new System.Drawing.Point(25, 64);
            this.GenaConfigBtn.Name = "GenaConfigBtn";
            this.GenaConfigBtn.Size = new System.Drawing.Size(75, 25);
            this.GenaConfigBtn.TabIndex = 0;
            this.GenaConfigBtn.Text = "常 规";
            this.GenaConfigBtn.UseVisualStyleBackColor = false;
            this.GenaConfigBtn.Click += new System.EventHandler(this.GenaConfigBtn_Click);
            // 
            // AppConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ConfigSplitContainer);
            this.Name = "AppConfig";
            this.Size = new System.Drawing.Size(840, 420);
            this.ConfigSplitContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ConfigSplitContainer)).EndInit();
            this.ConfigSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer ConfigSplitContainer;
        private System.Windows.Forms.Button GenaConfigBtn;
        private System.Windows.Forms.Button AboutConfigBtn;
        private System.Windows.Forms.Button DevConfigBtn;
        private System.Windows.Forms.Button UserConfigBtn;
    }
}
