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
            this.DIListView = new System.Windows.Forms.ListView();
            this.RemoveDevBtn = new System.Windows.Forms.Button();
            this.ApplyBtn = new System.Windows.Forms.Button();
            this.AddDevBtn = new System.Windows.Forms.Button();
            this.ReturnBtn = new System.Windows.Forms.Button();
            this.DevPanel = new System.Windows.Forms.Panel();
            this.DevTypeTBox = new System.Windows.Forms.TextBox();
            this.DevIPTBox = new System.Windows.Forms.TextBox();
            this.DevTypelbl = new System.Windows.Forms.Label();
            this.DevOSlbl = new System.Windows.Forms.Label();
            this.DevIPlbl = new System.Windows.Forms.Label();
            this.DevRoomTBox = new System.Windows.Forms.TextBox();
            this.DevRoomlbl = new System.Windows.Forms.Label();
            this.DevNameTBox = new System.Windows.Forms.TextBox();
            this.DevNamelbl = new System.Windows.Forms.Label();
            this.DevPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DIListView
            // 
            this.DIListView.BackColor = System.Drawing.SystemColors.Control;
            this.DIListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DIListView.ForeColor = System.Drawing.Color.White;
            this.DIListView.Location = new System.Drawing.Point(0, 30);
            this.DIListView.Name = "DIListView";
            this.DIListView.Size = new System.Drawing.Size(700, 390);
            this.DIListView.TabIndex = 0;
            this.DIListView.UseCompatibleStateImageBehavior = false;
            // 
            // RemoveDevBtn
            // 
            this.RemoveDevBtn.BackgroundImage = global::OnlineMonitor.Properties.Resources.Remove;
            this.RemoveDevBtn.FlatAppearance.BorderSize = 0;
            this.RemoveDevBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveDevBtn.Location = new System.Drawing.Point(670, 0);
            this.RemoveDevBtn.Name = "RemoveDevBtn";
            this.RemoveDevBtn.Size = new System.Drawing.Size(30, 30);
            this.RemoveDevBtn.TabIndex = 5;
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
            this.ApplyBtn.TabIndex = 8;
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
            this.AddDevBtn.TabIndex = 6;
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
            this.ReturnBtn.TabIndex = 7;
            this.ReturnBtn.UseVisualStyleBackColor = true;
            this.ReturnBtn.Click += new System.EventHandler(this.ReturnBtn_Click);
            // 
            // DevPanel
            // 
            this.DevPanel.BackColor = System.Drawing.Color.Purple;
            this.DevPanel.Controls.Add(this.DevTypeTBox);
            this.DevPanel.Controls.Add(this.DevIPTBox);
            this.DevPanel.Controls.Add(this.DevTypelbl);
            this.DevPanel.Controls.Add(this.DevOSlbl);
            this.DevPanel.Controls.Add(this.DevIPlbl);
            this.DevPanel.Controls.Add(this.DevRoomTBox);
            this.DevPanel.Controls.Add(this.DevRoomlbl);
            this.DevPanel.Controls.Add(this.DevNameTBox);
            this.DevPanel.Controls.Add(this.DevNamelbl);
            this.DevPanel.Location = new System.Drawing.Point(0, 30);
            this.DevPanel.Name = "DevPanel";
            this.DevPanel.Size = new System.Drawing.Size(700, 390);
            this.DevPanel.TabIndex = 9;
            // 
            // DevTypeTBox
            // 
            this.DevTypeTBox.Location = new System.Drawing.Point(510, 186);
            this.DevTypeTBox.Multiline = true;
            this.DevTypeTBox.Name = "DevTypeTBox";
            this.DevTypeTBox.Size = new System.Drawing.Size(150, 25);
            this.DevTypeTBox.TabIndex = 20;
            // 
            // DevIPTBox
            // 
            this.DevIPTBox.Location = new System.Drawing.Point(160, 186);
            this.DevIPTBox.Multiline = true;
            this.DevIPTBox.Name = "DevIPTBox";
            this.DevIPTBox.Size = new System.Drawing.Size(150, 25);
            this.DevIPTBox.TabIndex = 19;
            // 
            // DevTypelbl
            // 
            this.DevTypelbl.ForeColor = System.Drawing.Color.White;
            this.DevTypelbl.Location = new System.Drawing.Point(390, 183);
            this.DevTypelbl.Name = "DevTypelbl";
            this.DevTypelbl.Size = new System.Drawing.Size(80, 25);
            this.DevTypelbl.TabIndex = 18;
            this.DevTypelbl.Text = "设  备：";
            this.DevTypelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DevOSlbl
            // 
            this.DevOSlbl.ForeColor = System.Drawing.Color.White;
            this.DevOSlbl.Location = new System.Drawing.Point(40, 272);
            this.DevOSlbl.Name = "DevOSlbl";
            this.DevOSlbl.Size = new System.Drawing.Size(80, 25);
            this.DevOSlbl.TabIndex = 17;
            this.DevOSlbl.Text = "系  统：";
            this.DevOSlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DevIPlbl
            // 
            this.DevIPlbl.ForeColor = System.Drawing.Color.White;
            this.DevIPlbl.Location = new System.Drawing.Point(40, 183);
            this.DevIPlbl.Name = "DevIPlbl";
            this.DevIPlbl.Size = new System.Drawing.Size(80, 25);
            this.DevIPlbl.TabIndex = 16;
            this.DevIPlbl.Text = "I   P：";
            this.DevIPlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DevRoomTBox
            // 
            this.DevRoomTBox.Location = new System.Drawing.Point(510, 94);
            this.DevRoomTBox.Multiline = true;
            this.DevRoomTBox.Name = "DevRoomTBox";
            this.DevRoomTBox.Size = new System.Drawing.Size(150, 25);
            this.DevRoomTBox.TabIndex = 15;
            // 
            // DevRoomlbl
            // 
            this.DevRoomlbl.ForeColor = System.Drawing.Color.White;
            this.DevRoomlbl.Location = new System.Drawing.Point(390, 94);
            this.DevRoomlbl.Name = "DevRoomlbl";
            this.DevRoomlbl.Size = new System.Drawing.Size(80, 25);
            this.DevRoomlbl.TabIndex = 14;
            this.DevRoomlbl.Text = "位  置：";
            this.DevRoomlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DevNameTBox
            // 
            this.DevNameTBox.Location = new System.Drawing.Point(160, 94);
            this.DevNameTBox.Multiline = true;
            this.DevNameTBox.Name = "DevNameTBox";
            this.DevNameTBox.Size = new System.Drawing.Size(150, 25);
            this.DevNameTBox.TabIndex = 13;
            // 
            // DevNamelbl
            // 
            this.DevNamelbl.ForeColor = System.Drawing.Color.White;
            this.DevNamelbl.Location = new System.Drawing.Point(40, 94);
            this.DevNamelbl.Name = "DevNamelbl";
            this.DevNamelbl.Size = new System.Drawing.Size(80, 25);
            this.DevNamelbl.TabIndex = 12;
            this.DevNamelbl.Text = "名  称：";
            this.DevNamelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DevControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.Controls.Add(this.RemoveDevBtn);
            this.Controls.Add(this.ApplyBtn);
            this.Controls.Add(this.AddDevBtn);
            this.Controls.Add(this.ReturnBtn);
            this.Controls.Add(this.DIListView);
            this.Controls.Add(this.DevPanel);
            this.Name = "DevControl";
            this.Size = new System.Drawing.Size(700, 420);
            this.DevPanel.ResumeLayout(false);
            this.DevPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView DIListView;
        private System.Windows.Forms.Button RemoveDevBtn;
        private System.Windows.Forms.Button AddDevBtn;
        private System.Windows.Forms.Button ReturnBtn;
        private System.Windows.Forms.Button ApplyBtn;
        private System.Windows.Forms.Panel DevPanel;
        private System.Windows.Forms.TextBox DevTypeTBox;
        private System.Windows.Forms.TextBox DevIPTBox;
        private System.Windows.Forms.Label DevTypelbl;
        private System.Windows.Forms.Label DevOSlbl;
        private System.Windows.Forms.Label DevIPlbl;
        private System.Windows.Forms.TextBox DevRoomTBox;
        private System.Windows.Forms.Label DevRoomlbl;
        private System.Windows.Forms.TextBox DevNameTBox;
        private System.Windows.Forms.Label DevNamelbl;
    }
}
