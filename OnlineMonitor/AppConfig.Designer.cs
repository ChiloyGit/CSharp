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
            this.ConfigSplitContainer.Panel1.Controls.Add(this.GenaConfigBtn);
            this.ConfigSplitContainer.Panel1MinSize = 100;
            this.ConfigSplitContainer.Size = new System.Drawing.Size(840, 420);
            this.ConfigSplitContainer.SplitterDistance = 125;
            this.ConfigSplitContainer.TabIndex = 0;
            // 
            // GenaConfigBtn
            // 
            this.GenaConfigBtn.BackColor = System.Drawing.Color.Purple;
            this.GenaConfigBtn.FlatAppearance.BorderSize = 0;
            this.GenaConfigBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenaConfigBtn.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GenaConfigBtn.ForeColor = System.Drawing.Color.Transparent;
            this.GenaConfigBtn.Location = new System.Drawing.Point(25, 54);
            this.GenaConfigBtn.Name = "GenaConfigBtn";
            this.GenaConfigBtn.Size = new System.Drawing.Size(75, 23);
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
    }
}
