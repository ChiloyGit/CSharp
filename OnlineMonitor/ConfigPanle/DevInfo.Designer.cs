namespace OnlineMonitor.ConfigPanle
{
    partial class DevInfo
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
            this.DINamelbl = new System.Windows.Forms.Label();
            this.DINameTBox = new System.Windows.Forms.TextBox();
            this.DIRoomlbl = new System.Windows.Forms.Label();
            this.DIRoomTBox = new System.Windows.Forms.TextBox();
            this.DIIPlbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DITypelbl = new System.Windows.Forms.Label();
            this.DIIPTBox = new System.Windows.Forms.TextBox();
            this.DITypeTBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DINamelbl
            // 
            this.DINamelbl.ForeColor = System.Drawing.Color.White;
            this.DINamelbl.Location = new System.Drawing.Point(40, 64);
            this.DINamelbl.Name = "DINamelbl";
            this.DINamelbl.Size = new System.Drawing.Size(80, 25);
            this.DINamelbl.TabIndex = 0;
            this.DINamelbl.Text = "标  记：";
            this.DINamelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DINameTBox
            // 
            this.DINameTBox.Location = new System.Drawing.Point(160, 64);
            this.DINameTBox.Multiline = true;
            this.DINameTBox.Name = "DINameTBox";
            this.DINameTBox.Size = new System.Drawing.Size(150, 25);
            this.DINameTBox.TabIndex = 4;
            // 
            // DIRoomlbl
            // 
            this.DIRoomlbl.ForeColor = System.Drawing.Color.White;
            this.DIRoomlbl.Location = new System.Drawing.Point(390, 64);
            this.DIRoomlbl.Name = "DIRoomlbl";
            this.DIRoomlbl.Size = new System.Drawing.Size(80, 25);
            this.DIRoomlbl.TabIndex = 5;
            this.DIRoomlbl.Text = "位  置：";
            this.DIRoomlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DIRoomTBox
            // 
            this.DIRoomTBox.Location = new System.Drawing.Point(510, 64);
            this.DIRoomTBox.Multiline = true;
            this.DIRoomTBox.Name = "DIRoomTBox";
            this.DIRoomTBox.Size = new System.Drawing.Size(150, 25);
            this.DIRoomTBox.TabIndex = 6;
            // 
            // DIIPlbl
            // 
            this.DIIPlbl.ForeColor = System.Drawing.Color.White;
            this.DIIPlbl.Location = new System.Drawing.Point(40, 153);
            this.DIIPlbl.Name = "DIIPlbl";
            this.DIIPlbl.Size = new System.Drawing.Size(80, 25);
            this.DIIPlbl.TabIndex = 7;
            this.DIIPlbl.Text = "I   P：";
            this.DIIPlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(40, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "种  类：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DITypelbl
            // 
            this.DITypelbl.ForeColor = System.Drawing.Color.White;
            this.DITypelbl.Location = new System.Drawing.Point(390, 153);
            this.DITypelbl.Name = "DITypelbl";
            this.DITypelbl.Size = new System.Drawing.Size(80, 25);
            this.DITypelbl.TabIndex = 9;
            this.DITypelbl.Text = "种  类：";
            this.DITypelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DIIPTBox
            // 
            this.DIIPTBox.Location = new System.Drawing.Point(160, 156);
            this.DIIPTBox.Multiline = true;
            this.DIIPTBox.Name = "DIIPTBox";
            this.DIIPTBox.Size = new System.Drawing.Size(150, 25);
            this.DIIPTBox.TabIndex = 10;
            // 
            // DITypeTBox
            // 
            this.DITypeTBox.Location = new System.Drawing.Point(510, 156);
            this.DITypeTBox.Multiline = true;
            this.DITypeTBox.Name = "DITypeTBox";
            this.DITypeTBox.Size = new System.Drawing.Size(150, 25);
            this.DITypeTBox.TabIndex = 11;
            // 
            // DevInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.Controls.Add(this.DITypeTBox);
            this.Controls.Add(this.DIIPTBox);
            this.Controls.Add(this.DITypelbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DIIPlbl);
            this.Controls.Add(this.DIRoomTBox);
            this.Controls.Add(this.DIRoomlbl);
            this.Controls.Add(this.DINameTBox);
            this.Controls.Add(this.DINamelbl);
            this.Name = "DevInfo";
            this.Size = new System.Drawing.Size(700, 390);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DINamelbl;
        private System.Windows.Forms.TextBox DINameTBox;
        private System.Windows.Forms.Label DIRoomlbl;
        private System.Windows.Forms.TextBox DIRoomTBox;
        private System.Windows.Forms.Label DIIPlbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label DITypelbl;
        private System.Windows.Forms.TextBox DIIPTBox;
        private System.Windows.Forms.TextBox DITypeTBox;
    }
}
