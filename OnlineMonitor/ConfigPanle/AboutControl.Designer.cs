namespace OnlineMonitor.ConfigPanle
{
    partial class AboutControl
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
            this.AboutControlLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AboutControlLbl
            // 
            this.AboutControlLbl.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AboutControlLbl.ForeColor = System.Drawing.SystemColors.WindowText;
            this.AboutControlLbl.Location = new System.Drawing.Point(25, 64);
            this.AboutControlLbl.Name = "AboutControlLbl";
            this.AboutControlLbl.Size = new System.Drawing.Size(658, 20);
            this.AboutControlLbl.TabIndex = 0;
            this.AboutControlLbl.Text = "本程序用于监控设备网络在线情况。";
            // 
            // AboutControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.AboutControlLbl);
            this.Name = "AboutControl";
            this.Size = new System.Drawing.Size(700, 420);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label AboutControlLbl;
    }
}
