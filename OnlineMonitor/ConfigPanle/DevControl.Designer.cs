namespace OnlineMonitor.ConfigPanle
{
    partial class DevControl
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
            this.DevlistView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // DevlistView
            // 
            this.DevlistView.BackColor = System.Drawing.Color.Violet;
            this.DevlistView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DevlistView.Location = new System.Drawing.Point(0, 30);
            this.DevlistView.Name = "DevlistView";
            this.DevlistView.Size = new System.Drawing.Size(700, 390);
            this.DevlistView.TabIndex = 0;
            this.DevlistView.UseCompatibleStateImageBehavior = false;
            // 
            // DevControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.DevlistView);
            this.Name = "DevControl";
            this.Size = new System.Drawing.Size(700, 420);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView DevlistView;
    }
}
