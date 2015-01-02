namespace Source
{
    partial class Window
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
            this.SetPacket = new System.Windows.Forms.Button();
            this.SetRequests = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.Ping = new System.Windows.Forms.Button();
            this.AmmountRequests = new System.Windows.Forms.TextBox();
            this.IPv4 = new System.Windows.Forms.CheckBox();
            this.UnReq = new System.Windows.Forms.CheckBox();
            this.IPv6 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.IP = new System.Windows.Forms.TextBox();
            this.DataPacket = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SetPacket
            // 
            this.SetPacket.Location = new System.Drawing.Point(118, 12);
            this.SetPacket.Name = "SetPacket";
            this.SetPacket.Size = new System.Drawing.Size(75, 23);
            this.SetPacket.TabIndex = 1;
            this.SetPacket.Text = "Set Packet";
            this.SetPacket.UseVisualStyleBackColor = true;
            this.SetPacket.Click += new System.EventHandler(this.SetPacket_Click);
            // 
            // SetRequests
            // 
            this.SetRequests.Location = new System.Drawing.Point(199, 12);
            this.SetRequests.Name = "SetRequests";
            this.SetRequests.Size = new System.Drawing.Size(93, 23);
            this.SetRequests.TabIndex = 2;
            this.SetRequests.Text = "Set Requests";
            this.SetRequests.UseVisualStyleBackColor = true;
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(12, 72);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 23);
            this.Reset.TabIndex = 3;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            // 
            // Ping
            // 
            this.Ping.Location = new System.Drawing.Point(12, 101);
            this.Ping.Name = "Ping";
            this.Ping.Size = new System.Drawing.Size(75, 23);
            this.Ping.TabIndex = 4;
            this.Ping.Text = "Ping IP";
            this.Ping.UseVisualStyleBackColor = true;
            // 
            // AmmountRequests
            // 
            this.AmmountRequests.Location = new System.Drawing.Point(199, 41);
            this.AmmountRequests.Name = "AmmountRequests";
            this.AmmountRequests.Size = new System.Drawing.Size(93, 20);
            this.AmmountRequests.TabIndex = 8;
            this.AmmountRequests.Text = "10";
            this.AmmountRequests.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AmmountRequests.TextChanged += new System.EventHandler(this.AmmountRequests_TextChanged);
            // 
            // IPv4
            // 
            this.IPv4.AutoSize = true;
            this.IPv4.Checked = true;
            this.IPv4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.IPv4.Location = new System.Drawing.Point(93, 105);
            this.IPv4.Name = "IPv4";
            this.IPv4.Size = new System.Drawing.Size(78, 17);
            this.IPv4.TabIndex = 9;
            this.IPv4.Text = "Force IPv4";
            this.IPv4.UseVisualStyleBackColor = true;
            // 
            // UnReq
            // 
            this.UnReq.AutoSize = true;
            this.UnReq.Location = new System.Drawing.Point(93, 76);
            this.UnReq.Name = "UnReq";
            this.UnReq.Size = new System.Drawing.Size(170, 17);
            this.UnReq.TabIndex = 10;
            this.UnReq.Text = "Send Packets Till Host Stops?";
            this.UnReq.UseVisualStyleBackColor = true;
            // 
            // IPv6
            // 
            this.IPv6.AutoSize = true;
            this.IPv6.Location = new System.Drawing.Point(185, 105);
            this.IPv6.Name = "IPv6";
            this.IPv6.Size = new System.Drawing.Size(78, 17);
            this.IPv6.TabIndex = 11;
            this.IPv6.Text = "Force IPv6";
            this.IPv6.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Byte(s)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Set IP";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // IP
            // 
            this.IP.Location = new System.Drawing.Point(12, 41);
            this.IP.Name = "IP";
            this.IP.Size = new System.Drawing.Size(100, 20);
            this.IP.TabIndex = 14;
            this.IP.Text = "192.168.0.1";
            this.IP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DataPacket
            // 
            this.DataPacket.Location = new System.Drawing.Point(118, 41);
            this.DataPacket.Name = "DataPacket";
            this.DataPacket.Size = new System.Drawing.Size(30, 20);
            this.DataPacket.TabIndex = 15;
            this.DataPacket.Text = "10";
            this.DataPacket.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(304, 151);
            this.Controls.Add(this.DataPacket);
            this.Controls.Add(this.IP);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IPv6);
            this.Controls.Add(this.UnReq);
            this.Controls.Add(this.IPv4);
            this.Controls.Add(this.AmmountRequests);
            this.Controls.Add(this.Ping);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.SetRequests);
            this.Controls.Add(this.SetPacket);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Window";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.Text = "Server Test Tool Kit";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SetPacket;
        private System.Windows.Forms.Button SetRequests;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button Ping;
        private System.Windows.Forms.TextBox AmmountRequests;
        private System.Windows.Forms.CheckBox IPv4;
        private System.Windows.Forms.CheckBox UnReq;
        private System.Windows.Forms.CheckBox IPv6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox IP;
        private System.Windows.Forms.TextBox DataPacket;
    }
}

