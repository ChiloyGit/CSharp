namespace OnlineMonitor.ConfigPanle
{
    partial class UsersControl
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
            this.RemoveDevBtn = new System.Windows.Forms.Button();
            this.ApplyBtn = new System.Windows.Forms.Button();
            this.AddDevBtn = new System.Windows.Forms.Button();
            this.ReturnBtn = new System.Windows.Forms.Button();
            this.UIListView = new System.Windows.Forms.ListView();
            this.UserPanle = new System.Windows.Forms.Panel();
            this.DITypeTBox = new System.Windows.Forms.TextBox();
            this.UserMailTBox = new System.Windows.Forms.TextBox();
            this.UserTypelbl = new System.Windows.Forms.Label();
            this.Userlabel2 = new System.Windows.Forms.Label();
            this.UserMaillbl = new System.Windows.Forms.Label();
            this.UserMobileTBox = new System.Windows.Forms.TextBox();
            this.UserMobilelbl = new System.Windows.Forms.Label();
            this.UserNameTBox = new System.Windows.Forms.TextBox();
            this.UserNamelbl = new System.Windows.Forms.Label();
            this.UserPanle.SuspendLayout();
            this.SuspendLayout();
            // 
            // RemoveDevBtn
            // 
            this.RemoveDevBtn.BackgroundImage = global::OnlineMonitor.Properties.Resources.Remove;
            this.RemoveDevBtn.FlatAppearance.BorderSize = 0;
            this.RemoveDevBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveDevBtn.Location = new System.Drawing.Point(670, 0);
            this.RemoveDevBtn.Name = "RemoveDevBtn";
            this.RemoveDevBtn.Size = new System.Drawing.Size(30, 30);
            this.RemoveDevBtn.TabIndex = 9;
            this.RemoveDevBtn.UseVisualStyleBackColor = true;
            this.RemoveDevBtn.Click += new System.EventHandler(this.RemoveDevBtn_Click);
            // 
            // ApplyBtn
            // 
            this.ApplyBtn.BackgroundImage = global::OnlineMonitor.Properties.Resources.Apply;
            this.ApplyBtn.FlatAppearance.BorderSize = 0;
            this.ApplyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ApplyBtn.Location = new System.Drawing.Point(670, 0);
            this.ApplyBtn.Name = "ApplyBtn";
            this.ApplyBtn.Size = new System.Drawing.Size(30, 30);
            this.ApplyBtn.TabIndex = 12;
            this.ApplyBtn.UseVisualStyleBackColor = true;
            this.ApplyBtn.Click += new System.EventHandler(this.ApplyBtn_Click);
            // 
            // AddDevBtn
            // 
            this.AddDevBtn.BackgroundImage = global::OnlineMonitor.Properties.Resources.Add;
            this.AddDevBtn.FlatAppearance.BorderSize = 0;
            this.AddDevBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddDevBtn.Location = new System.Drawing.Point(640, 0);
            this.AddDevBtn.Name = "AddDevBtn";
            this.AddDevBtn.Size = new System.Drawing.Size(30, 30);
            this.AddDevBtn.TabIndex = 10;
            this.AddDevBtn.UseVisualStyleBackColor = true;
            this.AddDevBtn.Click += new System.EventHandler(this.AddDevBtn_Click);
            // 
            // ReturnBtn
            // 
            this.ReturnBtn.BackgroundImage = global::OnlineMonitor.Properties.Resources.Return;
            this.ReturnBtn.FlatAppearance.BorderSize = 0;
            this.ReturnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReturnBtn.Location = new System.Drawing.Point(640, 0);
            this.ReturnBtn.Name = "ReturnBtn";
            this.ReturnBtn.Size = new System.Drawing.Size(30, 30);
            this.ReturnBtn.TabIndex = 11;
            this.ReturnBtn.UseVisualStyleBackColor = true;
            this.ReturnBtn.Click += new System.EventHandler(this.ReturnBtn_Click);
            // 
            // UIListView
            // 
            this.UIListView.BackColor = System.Drawing.Color.Purple;
            this.UIListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UIListView.Location = new System.Drawing.Point(0, 30);
            this.UIListView.Name = "UIListView";
            this.UIListView.Size = new System.Drawing.Size(700, 390);
            this.UIListView.TabIndex = 13;
            this.UIListView.UseCompatibleStateImageBehavior = false;
            // 
            // UserPanle
            // 
            this.UserPanle.Controls.Add(this.DITypeTBox);
            this.UserPanle.Controls.Add(this.UserMailTBox);
            this.UserPanle.Controls.Add(this.UserTypelbl);
            this.UserPanle.Controls.Add(this.Userlabel2);
            this.UserPanle.Controls.Add(this.UserMaillbl);
            this.UserPanle.Controls.Add(this.UserMobileTBox);
            this.UserPanle.Controls.Add(this.UserMobilelbl);
            this.UserPanle.Controls.Add(this.UserNameTBox);
            this.UserPanle.Controls.Add(this.UserNamelbl);
            this.UserPanle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserPanle.Location = new System.Drawing.Point(0, 0);
            this.UserPanle.Name = "UserPanle";
            this.UserPanle.Size = new System.Drawing.Size(700, 420);
            this.UserPanle.TabIndex = 14;
            // 
            // DITypeTBox
            // 
            this.DITypeTBox.Location = new System.Drawing.Point(510, 201);
            this.DITypeTBox.Multiline = true;
            this.DITypeTBox.Name = "DITypeTBox";
            this.DITypeTBox.Size = new System.Drawing.Size(150, 25);
            this.DITypeTBox.TabIndex = 38;
            // 
            // UserMailTBox
            // 
            this.UserMailTBox.Location = new System.Drawing.Point(160, 201);
            this.UserMailTBox.Multiline = true;
            this.UserMailTBox.Name = "UserMailTBox";
            this.UserMailTBox.Size = new System.Drawing.Size(150, 25);
            this.UserMailTBox.TabIndex = 37;
            // 
            // UserTypelbl
            // 
            this.UserTypelbl.ForeColor = System.Drawing.Color.White;
            this.UserTypelbl.Location = new System.Drawing.Point(390, 198);
            this.UserTypelbl.Name = "UserTypelbl";
            this.UserTypelbl.Size = new System.Drawing.Size(80, 25);
            this.UserTypelbl.TabIndex = 36;
            this.UserTypelbl.Text = "种  类：";
            this.UserTypelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Userlabel2
            // 
            this.Userlabel2.ForeColor = System.Drawing.Color.White;
            this.Userlabel2.Location = new System.Drawing.Point(40, 287);
            this.Userlabel2.Name = "Userlabel2";
            this.Userlabel2.Size = new System.Drawing.Size(80, 25);
            this.Userlabel2.TabIndex = 35;
            this.Userlabel2.Text = "种  类：";
            this.Userlabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserMaillbl
            // 
            this.UserMaillbl.ForeColor = System.Drawing.Color.White;
            this.UserMaillbl.Location = new System.Drawing.Point(40, 198);
            this.UserMaillbl.Name = "UserMaillbl";
            this.UserMaillbl.Size = new System.Drawing.Size(80, 25);
            this.UserMaillbl.TabIndex = 34;
            this.UserMaillbl.Text = "邮 箱：";
            this.UserMaillbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserMobileTBox
            // 
            this.UserMobileTBox.Location = new System.Drawing.Point(510, 109);
            this.UserMobileTBox.Multiline = true;
            this.UserMobileTBox.Name = "UserMobileTBox";
            this.UserMobileTBox.Size = new System.Drawing.Size(150, 25);
            this.UserMobileTBox.TabIndex = 33;
            // 
            // UserMobilelbl
            // 
            this.UserMobilelbl.ForeColor = System.Drawing.Color.White;
            this.UserMobilelbl.Location = new System.Drawing.Point(390, 109);
            this.UserMobilelbl.Name = "UserMobilelbl";
            this.UserMobilelbl.Size = new System.Drawing.Size(80, 25);
            this.UserMobilelbl.TabIndex = 32;
            this.UserMobilelbl.Text = "手  机：";
            this.UserMobilelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserNameTBox
            // 
            this.UserNameTBox.Location = new System.Drawing.Point(160, 109);
            this.UserNameTBox.Multiline = true;
            this.UserNameTBox.Name = "UserNameTBox";
            this.UserNameTBox.Size = new System.Drawing.Size(150, 25);
            this.UserNameTBox.TabIndex = 31;
            // 
            // UserNamelbl
            // 
            this.UserNamelbl.ForeColor = System.Drawing.Color.White;
            this.UserNamelbl.Location = new System.Drawing.Point(40, 109);
            this.UserNamelbl.Name = "UserNamelbl";
            this.UserNamelbl.Size = new System.Drawing.Size(80, 25);
            this.UserNamelbl.TabIndex = 30;
            this.UserNamelbl.Text = "姓  名：";
            this.UserNamelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UsersControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.Controls.Add(this.AddDevBtn);
            this.Controls.Add(this.RemoveDevBtn);
            this.Controls.Add(this.ReturnBtn);
            this.Controls.Add(this.ApplyBtn);
            this.Controls.Add(this.UIListView);
            this.Controls.Add(this.UserPanle);
            this.Name = "UsersControl";
            this.Size = new System.Drawing.Size(700, 420);
            this.UserPanle.ResumeLayout(false);
            this.UserPanle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RemoveDevBtn;
        private System.Windows.Forms.Button ApplyBtn;
        private System.Windows.Forms.Button AddDevBtn;
        private System.Windows.Forms.Button ReturnBtn;
        private System.Windows.Forms.ListView UIListView;
        private System.Windows.Forms.Panel UserPanle;
        private System.Windows.Forms.TextBox DITypeTBox;
        private System.Windows.Forms.TextBox UserMailTBox;
        private System.Windows.Forms.Label UserTypelbl;
        private System.Windows.Forms.Label Userlabel2;
        private System.Windows.Forms.Label UserMaillbl;
        private System.Windows.Forms.TextBox UserMobileTBox;
        private System.Windows.Forms.Label UserMobilelbl;
        private System.Windows.Forms.TextBox UserNameTBox;
        private System.Windows.Forms.Label UserNamelbl;
    }
}
