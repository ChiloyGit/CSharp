namespace OnlineMonitor
{
    partial class HomePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.MonitorBtn = new System.Windows.Forms.Button();
            this.DeviceBtn = new System.Windows.Forms.Button();
            this.UserBtn = new System.Windows.Forms.Button();
            this.SetBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MonitorBtn
            // 
            this.MonitorBtn.Image = global::OnlineMonitor.Properties.Resources.Monitor;
            this.MonitorBtn.Location = new System.Drawing.Point(100, 40);
            this.MonitorBtn.Name = "MonitorBtn";
            this.MonitorBtn.Size = new System.Drawing.Size(100, 60);
            this.MonitorBtn.TabIndex = 0;
            this.MonitorBtn.Text = "Monitor";
            this.MonitorBtn.UseVisualStyleBackColor = true;
            // 
            // DeviceBtn
            // 
            this.DeviceBtn.Location = new System.Drawing.Point(275, 40);
            this.DeviceBtn.Name = "DeviceBtn";
            this.DeviceBtn.Size = new System.Drawing.Size(100, 60);
            this.DeviceBtn.TabIndex = 1;
            this.DeviceBtn.Text = "Device";
            this.DeviceBtn.UseVisualStyleBackColor = true;
            // 
            // UserBtn
            // 
            this.UserBtn.Location = new System.Drawing.Point(100, 170);
            this.UserBtn.Name = "UserBtn";
            this.UserBtn.Size = new System.Drawing.Size(100, 60);
            this.UserBtn.TabIndex = 2;
            this.UserBtn.Text = "User";
            this.UserBtn.UseVisualStyleBackColor = true;
            // 
            // SetBtn
            // 
            this.SetBtn.Location = new System.Drawing.Point(275, 170);
            this.SetBtn.Name = "SetBtn";
            this.SetBtn.Size = new System.Drawing.Size(100, 60);
            this.SetBtn.TabIndex = 3;
            this.SetBtn.Text = "SetUp";
            this.SetBtn.UseVisualStyleBackColor = true;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 282);
            this.Controls.Add(this.SetBtn);
            this.Controls.Add(this.UserBtn);
            this.Controls.Add(this.DeviceBtn);
            this.Controls.Add(this.MonitorBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "HomePage";
            this.Text = "Online Monitor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MonitorBtn;
        private System.Windows.Forms.Button DeviceBtn;
        private System.Windows.Forms.Button UserBtn;
        private System.Windows.Forms.Button SetBtn;
    }
}