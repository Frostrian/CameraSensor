namespace CameraSensor
{
    partial class FormCameraSensor
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnStart = new Button();
            txtLog = new RichTextBox();
            txtStaticIp = new TextBox();
            txtMqttHost = new TextBox();
            txtMqttUser = new TextBox();
            txtSSID = new TextBox();
            txtMqttPass = new TextBox();
            txtWifiPass = new TextBox();
            txtMqttPort = new TextBox();
            txtDeviceId = new TextBox();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 221);
            label8.Name = "label8";
            label8.Size = new Size(45, 15);
            label8.TabIndex = 21;
            label8.Text = "staticIp";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 192);
            label7.Name = "label7";
            label7.Size = new Size(56, 15);
            label7.TabIndex = 19;
            label7.Text = "mqttPass";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 163);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 18;
            label6.Text = "mqttUser";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 134);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 17;
            label5.Text = "mqttPort";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 105);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 16;
            label4.Text = "mqttHost";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 76);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 15;
            label3.Text = "Pass";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 47);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 14;
            label2.Text = "Wifi";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 20;
            label1.Text = "deviceId";
            // 
            // btnStart
            // 
            btnStart.Location = new Point(218, 15);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(296, 23);
            btnStart.TabIndex = 13;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // txtLog
            // 
            txtLog.Location = new Point(218, 44);
            txtLog.Name = "txtLog";
            txtLog.Size = new Size(296, 197);
            txtLog.TabIndex = 12;
            txtLog.Text = "";
            // 
            // txtStaticIp
            // 
            txtStaticIp.Location = new Point(85, 218);
            txtStaticIp.Name = "txtStaticIp";
            txtStaticIp.Size = new Size(100, 23);
            txtStaticIp.TabIndex = 10;
            txtStaticIp.Text = "192.168.1.41";
            // 
            // txtMqttHost
            // 
            txtMqttHost.Location = new Point(85, 102);
            txtMqttHost.Name = "txtMqttHost";
            txtMqttHost.Size = new Size(100, 23);
            txtMqttHost.TabIndex = 9;
            txtMqttHost.Text = "localhost";
            // 
            // txtMqttUser
            // 
            txtMqttUser.Location = new Point(85, 160);
            txtMqttUser.Name = "txtMqttUser";
            txtMqttUser.Size = new Size(100, 23);
            txtMqttUser.TabIndex = 8;
            txtMqttUser.Text = "camuser";
            // 
            // txtSSID
            // 
            txtSSID.Location = new Point(85, 44);
            txtSSID.Name = "txtSSID";
            txtSSID.Size = new Size(100, 23);
            txtSSID.TabIndex = 7;
            txtSSID.Text = "OfficeWiFi";
            // 
            // txtMqttPass
            // 
            txtMqttPass.Location = new Point(85, 189);
            txtMqttPass.Name = "txtMqttPass";
            txtMqttPass.Size = new Size(100, 23);
            txtMqttPass.TabIndex = 6;
            txtMqttPass.Text = "campass";
            // 
            // txtWifiPass
            // 
            txtWifiPass.Location = new Point(85, 73);
            txtWifiPass.Name = "txtWifiPass";
            txtWifiPass.Size = new Size(100, 23);
            txtWifiPass.TabIndex = 5;
            txtWifiPass.Text = "12345678";
            // 
            // txtMqttPort
            // 
            txtMqttPort.Location = new Point(85, 131);
            txtMqttPort.Name = "txtMqttPort";
            txtMqttPort.Size = new Size(100, 23);
            txtMqttPort.TabIndex = 11;
            txtMqttPort.Text = "1883";
            // 
            // txtDeviceId
            // 
            txtDeviceId.Location = new Point(85, 15);
            txtDeviceId.Name = "txtDeviceId";
            txtDeviceId.Size = new Size(100, 23);
            txtDeviceId.TabIndex = 4;
            txtDeviceId.Text = "CAM_001";
            // 
            // FormCameraSensor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 256);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnStart);
            Controls.Add(txtLog);
            Controls.Add(txtStaticIp);
            Controls.Add(txtMqttHost);
            Controls.Add(txtMqttUser);
            Controls.Add(txtSSID);
            Controls.Add(txtMqttPass);
            Controls.Add(txtWifiPass);
            Controls.Add(txtMqttPort);
            Controls.Add(txtDeviceId);
            Name = "FormCameraSensor";
            Text = "Camera Config";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnStart;
        private RichTextBox txtLog;
        private TextBox txtStaticIp;
        private TextBox txtMqttHost;
        private TextBox txtMqttUser;
        private TextBox txtSSID;
        private TextBox txtMqttPass;
        private TextBox txtWifiPass;
        private TextBox txtMqttPort;
        private TextBox txtDeviceId;
    }
}
