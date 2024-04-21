namespace PCMIOTDF
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ConnectBT = new System.Windows.Forms.Button();
            this.ScanPortBT = new System.Windows.Forms.Button();
            this.BoardTypeCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PortSelectionCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sendBT = new System.Windows.Forms.Button();
            this.IncomingTB = new System.Windows.Forms.RichTextBox();
            this.CheackBT = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ConfirmPasswordTB = new System.Windows.Forms.TextBox();
            this.ConfirmNameWifiTB = new System.Windows.Forms.TextBox();
            this.NameWifiTBt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LinkArduinoTB = new System.Windows.Forms.Button();
            this.APIkeyTB = new System.Windows.Forms.TextBox();
            this.LinkBT = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ClearBT = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort1_DataReceived);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ConnectBT);
            this.groupBox1.Controls.Add(this.ScanPortBT);
            this.groupBox1.Controls.Add(this.BoardTypeCB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.PortSelectionCB);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(18, 19);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(689, 135);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Programmer";
            // 
            // ConnectBT
            // 
            this.ConnectBT.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectBT.Location = new System.Drawing.Point(554, 82);
            this.ConnectBT.Margin = new System.Windows.Forms.Padding(4);
            this.ConnectBT.Name = "ConnectBT";
            this.ConnectBT.Size = new System.Drawing.Size(118, 32);
            this.ConnectBT.TabIndex = 11;
            this.ConnectBT.Text = "Connected";
            this.ConnectBT.UseVisualStyleBackColor = true;
            this.ConnectBT.Click += new System.EventHandler(this.ConnectBT_Click);
            // 
            // ScanPortBT
            // 
            this.ScanPortBT.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScanPortBT.Location = new System.Drawing.Point(554, 37);
            this.ScanPortBT.Margin = new System.Windows.Forms.Padding(4);
            this.ScanPortBT.Name = "ScanPortBT";
            this.ScanPortBT.Size = new System.Drawing.Size(118, 32);
            this.ScanPortBT.TabIndex = 10;
            this.ScanPortBT.Text = "Scan Port";
            this.ScanPortBT.UseVisualStyleBackColor = true;
            this.ScanPortBT.Click += new System.EventHandler(this.ScanPortBT_Click);
            // 
            // BoardTypeCB
            // 
            this.BoardTypeCB.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoardTypeCB.FormattingEnabled = true;
            this.BoardTypeCB.Location = new System.Drawing.Point(157, 82);
            this.BoardTypeCB.Margin = new System.Windows.Forms.Padding(4);
            this.BoardTypeCB.Name = "BoardTypeCB";
            this.BoardTypeCB.Size = new System.Drawing.Size(377, 32);
            this.BoardTypeCB.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "BoardType";
            // 
            // PortSelectionCB
            // 
            this.PortSelectionCB.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PortSelectionCB.FormattingEnabled = true;
            this.PortSelectionCB.Location = new System.Drawing.Point(157, 37);
            this.PortSelectionCB.Margin = new System.Windows.Forms.Padding(4);
            this.PortSelectionCB.Name = "PortSelectionCB";
            this.PortSelectionCB.Size = new System.Drawing.Size(377, 32);
            this.PortSelectionCB.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Port Selection";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.sendBT);
            this.groupBox2.Controls.Add(this.IncomingTB);
            this.groupBox2.Controls.Add(this.CheackBT);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.ConfirmPasswordTB);
            this.groupBox2.Controls.Add(this.ConfirmNameWifiTB);
            this.groupBox2.Controls.Add(this.NameWifiTBt);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.PasswordTB);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(18, 187);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Size = new System.Drawing.Size(689, 219);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Wifi Connected";
            // 
            // sendBT
            // 
            this.sendBT.Enabled = false;
            this.sendBT.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendBT.Location = new System.Drawing.Point(560, 40);
            this.sendBT.Margin = new System.Windows.Forms.Padding(4);
            this.sendBT.Name = "sendBT";
            this.sendBT.Size = new System.Drawing.Size(112, 39);
            this.sendBT.TabIndex = 15;
            this.sendBT.Text = "Send";
            this.sendBT.UseVisualStyleBackColor = true;
            this.sendBT.Click += new System.EventHandler(this.SendBT_Click);
            // 
            // IncomingTB
            // 
            this.IncomingTB.Location = new System.Drawing.Point(439, 96);
            this.IncomingTB.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.IncomingTB.Name = "IncomingTB";
            this.IncomingTB.Size = new System.Drawing.Size(233, 102);
            this.IncomingTB.TabIndex = 14;
            this.IncomingTB.Text = "";
            // 
            // CheackBT
            // 
            this.CheackBT.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheackBT.Location = new System.Drawing.Point(439, 40);
            this.CheackBT.Margin = new System.Windows.Forms.Padding(4);
            this.CheackBT.Name = "CheackBT";
            this.CheackBT.Size = new System.Drawing.Size(112, 39);
            this.CheackBT.TabIndex = 13;
            this.CheackBT.Text = "Cheack";
            this.CheackBT.UseVisualStyleBackColor = true;
            this.CheackBT.Click += new System.EventHandler(this.CheackBT_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 166);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(177, 24);
            this.label9.TabIndex = 12;
            this.label9.Text = "Confirm Name Wifi";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(8, 124);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(177, 24);
            this.label10.TabIndex = 11;
            this.label10.Text = "Confirm Name Wifi";
            // 
            // ConfirmPasswordTB
            // 
            this.ConfirmPasswordTB.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPasswordTB.Location = new System.Drawing.Point(185, 164);
            this.ConfirmPasswordTB.Margin = new System.Windows.Forms.Padding(4);
            this.ConfirmPasswordTB.Multiline = true;
            this.ConfirmPasswordTB.Name = "ConfirmPasswordTB";
            this.ConfirmPasswordTB.Size = new System.Drawing.Size(249, 36);
            this.ConfirmPasswordTB.TabIndex = 10;
            // 
            // ConfirmNameWifiTB
            // 
            this.ConfirmNameWifiTB.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmNameWifiTB.Location = new System.Drawing.Point(185, 122);
            this.ConfirmNameWifiTB.Margin = new System.Windows.Forms.Padding(4);
            this.ConfirmNameWifiTB.Multiline = true;
            this.ConfirmNameWifiTB.Name = "ConfirmNameWifiTB";
            this.ConfirmNameWifiTB.Size = new System.Drawing.Size(249, 38);
            this.ConfirmNameWifiTB.TabIndex = 9;
            // 
            // NameWifiTBt
            // 
            this.NameWifiTBt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameWifiTBt.Location = new System.Drawing.Point(185, 38);
            this.NameWifiTBt.Margin = new System.Windows.Forms.Padding(4);
            this.NameWifiTBt.Multiline = true;
            this.NameWifiTBt.Name = "NameWifiTBt";
            this.NameWifiTBt.Size = new System.Drawing.Size(249, 37);
            this.NameWifiTBt.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 82);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 24);
            this.label7.TabIndex = 6;
            this.label7.Text = "Password";
            // 
            // PasswordTB
            // 
            this.PasswordTB.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTB.Location = new System.Drawing.Point(185, 77);
            this.PasswordTB.Margin = new System.Windows.Forms.Padding(4);
            this.PasswordTB.Multiline = true;
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.Size = new System.Drawing.Size(249, 39);
            this.PasswordTB.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 40);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 24);
            this.label8.TabIndex = 4;
            this.label8.Text = "Name Wifi";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.LinkArduinoTB);
            this.groupBox3.Controls.Add(this.APIkeyTB);
            this.groupBox3.Controls.Add(this.LinkBT);
            this.groupBox3.Location = new System.Drawing.Point(18, 427);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox3.Size = new System.Drawing.Size(689, 88);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Link Platform";
            // 
            // LinkArduinoTB
            // 
            this.LinkArduinoTB.Location = new System.Drawing.Point(554, 35);
            this.LinkArduinoTB.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.LinkArduinoTB.Name = "LinkArduinoTB";
            this.LinkArduinoTB.Size = new System.Drawing.Size(118, 38);
            this.LinkArduinoTB.TabIndex = 12;
            this.LinkArduinoTB.Text = "LinkArduino";
            this.LinkArduinoTB.UseVisualStyleBackColor = true;
            // 
            // APIkeyTB
            // 
            this.APIkeyTB.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.APIkeyTB.Location = new System.Drawing.Point(140, 35);
            this.APIkeyTB.Margin = new System.Windows.Forms.Padding(4);
            this.APIkeyTB.Multiline = true;
            this.APIkeyTB.Name = "APIkeyTB";
            this.APIkeyTB.Size = new System.Drawing.Size(394, 39);
            this.APIkeyTB.TabIndex = 11;
            // 
            // LinkBT
            // 
            this.LinkBT.Location = new System.Drawing.Point(11, 35);
            this.LinkBT.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.LinkBT.Name = "LinkBT";
            this.LinkBT.Size = new System.Drawing.Size(115, 38);
            this.LinkBT.TabIndex = 0;
            this.LinkBT.Text = "Link";
            this.LinkBT.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(727, 19);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox4.Size = new System.Drawing.Size(218, 387);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Arduino Info";
            // 
            // ClearBT
            // 
            this.ClearBT.Location = new System.Drawing.Point(781, 462);
            this.ClearBT.Name = "ClearBT";
            this.ClearBT.Size = new System.Drawing.Size(111, 39);
            this.ClearBT.TabIndex = 10;
            this.ClearBT.Text = "Clear";
            this.ClearBT.UseVisualStyleBackColor = true;
            this.ClearBT.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 553);
            this.Controls.Add(this.ClearBT);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ConnectBT;
        private System.Windows.Forms.Button ScanPortBT;
        private System.Windows.Forms.ComboBox BoardTypeCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox PortSelectionCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox NameWifiTBt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ConfirmPasswordTB;
        private System.Windows.Forms.TextBox ConfirmNameWifiTB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button sendBT;
        private System.Windows.Forms.RichTextBox IncomingTB;
        private System.Windows.Forms.Button CheackBT;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox APIkeyTB;
        private System.Windows.Forms.Button LinkBT;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button LinkArduinoTB;
        private System.Windows.Forms.Button ClearBT;
    }
}