namespace OnlineMonitor.ConfigPanle
{
    partial class UserInfo
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
            this.DITypeTBox = new System.Windows.Forms.TextBox();
            this.UIMailTBox = new System.Windows.Forms.TextBox();
            this.DITypelbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UIMaillbl = new System.Windows.Forms.Label();
            this.UIMobileTBox = new System.Windows.Forms.TextBox();
            this.UIMobilelbl = new System.Windows.Forms.Label();
            this.UINameTBox = new System.Windows.Forms.TextBox();
            this.UINamelbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DITypeTBox
            // 
            this.DITypeTBox.Location = new System.Drawing.Point(510, 186);
            this.DITypeTBox.Multiline = true;
            this.DITypeTBox.Name = "DITypeTBox";
            this.DITypeTBox.Size = new System.Drawing.Size(150, 25);
            this.DITypeTBox.TabIndex = 29;
            // 
            // UIMailTBox
            // 
            this.UIMailTBox.Location = new System.Drawing.Point(160, 186);
            this.UIMailTBox.Multiline = true;
            this.UIMailTBox.Name = "UIMailTBox";
            this.UIMailTBox.Size = new System.Drawing.Size(150, 25);
            this.UIMailTBox.TabIndex = 28;
            // 
            // DITypelbl
            // 
            this.DITypelbl.ForeColor = System.Drawing.Color.White;
            this.DITypelbl.Location = new System.Drawing.Point(390, 183);
            this.DITypelbl.Name = "DITypelbl";
            this.DITypelbl.Size = new System.Drawing.Size(80, 25);
            this.DITypelbl.TabIndex = 27;
            this.DITypelbl.Text = "种  类：";
            this.DITypelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(40, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "种  类：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UIMaillbl
            // 
            this.UIMaillbl.ForeColor = System.Drawing.Color.White;
            this.UIMaillbl.Location = new System.Drawing.Point(40, 183);
            this.UIMaillbl.Name = "UIMaillbl";
            this.UIMaillbl.Size = new System.Drawing.Size(80, 25);
            this.UIMaillbl.TabIndex = 25;
            this.UIMaillbl.Text = "邮 箱：";
            this.UIMaillbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UIMobileTBox
            // 
            this.UIMobileTBox.Location = new System.Drawing.Point(510, 94);
            this.UIMobileTBox.Multiline = true;
            this.UIMobileTBox.Name = "UIMobileTBox";
            this.UIMobileTBox.Size = new System.Drawing.Size(150, 25);
            this.UIMobileTBox.TabIndex = 24;
            // 
            // UIMobilelbl
            // 
            this.UIMobilelbl.ForeColor = System.Drawing.Color.White;
            this.UIMobilelbl.Location = new System.Drawing.Point(390, 94);
            this.UIMobilelbl.Name = "UIMobilelbl";
            this.UIMobilelbl.Size = new System.Drawing.Size(80, 25);
            this.UIMobilelbl.TabIndex = 23;
            this.UIMobilelbl.Text = "手  机：";
            this.UIMobilelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UINameTBox
            // 
            this.UINameTBox.Location = new System.Drawing.Point(160, 94);
            this.UINameTBox.Multiline = true;
            this.UINameTBox.Name = "UINameTBox";
            this.UINameTBox.Size = new System.Drawing.Size(150, 25);
            this.UINameTBox.TabIndex = 22;
            // 
            // UINamelbl
            // 
            this.UINamelbl.ForeColor = System.Drawing.Color.White;
            this.UINamelbl.Location = new System.Drawing.Point(40, 94);
            this.UINamelbl.Name = "UINamelbl";
            this.UINamelbl.Size = new System.Drawing.Size(80, 25);
            this.UINamelbl.TabIndex = 21;
            this.UINamelbl.Text = "姓  名：";
            this.UINamelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.DITypeTBox);
            this.Controls.Add(this.UIMailTBox);
            this.Controls.Add(this.DITypelbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UIMaillbl);
            this.Controls.Add(this.UIMobileTBox);
            this.Controls.Add(this.UIMobilelbl);
            this.Controls.Add(this.UINameTBox);
            this.Controls.Add(this.UINamelbl);
            this.Name = "UserInfo";
            this.Size = new System.Drawing.Size(700, 390);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DITypeTBox;
        private System.Windows.Forms.TextBox UIMailTBox;
        private System.Windows.Forms.Label DITypelbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label UIMaillbl;
        private System.Windows.Forms.TextBox UIMobileTBox;
        private System.Windows.Forms.Label UIMobilelbl;
        private System.Windows.Forms.TextBox UINameTBox;
        private System.Windows.Forms.Label UINamelbl;
    }
}
