namespace USB_TrafficLightControl
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitleMain = new System.Windows.Forms.Label();
            this.grpComm = new System.Windows.Forms.GroupBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cboHIDDevice = new System.Windows.Forms.ComboBox();
            this.lblHIDDevice = new System.Windows.Forms.Label();
            this.grpSource = new System.Windows.Forms.GroupBox();
            this.rbGUI = new System.Windows.Forms.RadioButton();
            this.rbManual = new System.Windows.Forms.RadioButton();
            this.grpTime = new System.Windows.Forms.GroupBox();
            this.numGreen = new System.Windows.Forms.NumericUpDown();
            this.numYellow = new System.Windows.Forms.NumericUpDown();
            this.numRed = new System.Windows.Forms.NumericUpDown();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnApplyTime = new System.Windows.Forms.Button();
            this.lblGreenCap = new System.Windows.Forms.Label();
            this.lblYellowCap = new System.Windows.Forms.Label();
            this.lblRedCap = new System.Windows.Forms.Label();
            this.lblTimingStatus = new System.Windows.Forms.Label();
            this.lblClock = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.grpDisplay = new System.Windows.Forms.GroupBox();
            this.pictureBox_Number = new System.Windows.Forms.PictureBox();
            this.pictureBox_Light = new System.Windows.Forms.PictureBox();
            this.lblNameStudent = new System.Windows.Forms.Label();
            this.lblIDStudent = new System.Windows.Forms.Label();
            this.grpMode = new System.Windows.Forms.GroupBox();
            this.btnMode3 = new System.Windows.Forms.Button();
            this.btnMode2 = new System.Windows.Forms.Button();
            this.btnMode1 = new System.Windows.Forms.Button();
            this.lblControlMode = new System.Windows.Forms.Label();
            this.lblCurrentMode = new System.Windows.Forms.Label();
            this.grpComm.SuspendLayout();
            this.grpSource.SuspendLayout();
            this.grpTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRed)).BeginInit();
            this.grpDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Number)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Light)).BeginInit();
            this.grpMode.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitleMain
            // 
            this.lblTitleMain.AutoSize = true;
            this.lblTitleMain.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitleMain.Location = new System.Drawing.Point(178, 9);
            this.lblTitleMain.Name = "lblTitleMain";
            this.lblTitleMain.Size = new System.Drawing.Size(333, 28);
            this.lblTitleMain.TabIndex = 0;
            this.lblTitleMain.Text = "TRAFFIC LIGHT CONTROL SYSTEM";
            // 
            // grpComm
            // 
            this.grpComm.Controls.Add(this.lblStatus);
            this.grpComm.Controls.Add(this.cboHIDDevice);
            this.grpComm.Controls.Add(this.lblHIDDevice);
            this.grpComm.Location = new System.Drawing.Point(15, 45);
            this.grpComm.Name = "grpComm";
            this.grpComm.Size = new System.Drawing.Size(301, 150);
            this.grpComm.TabIndex = 1;
            this.grpComm.TabStop = false;
            this.grpComm.Text = "COMMUNICATION SETUP";
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.Gray;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(100, 65);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(172, 42);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "USB Disconnected";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboHIDDevice
            // 
            this.cboHIDDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHIDDevice.FormattingEnabled = true;
            this.cboHIDDevice.Location = new System.Drawing.Point(100, 30);
            this.cboHIDDevice.Name = "cboHIDDevice";
            this.cboHIDDevice.Size = new System.Drawing.Size(172, 28);
            this.cboHIDDevice.TabIndex = 1;
            // 
            // lblHIDDevice
            // 
            this.lblHIDDevice.AutoSize = true;
            this.lblHIDDevice.Location = new System.Drawing.Point(15, 33);
            this.lblHIDDevice.Name = "lblHIDDevice";
            this.lblHIDDevice.Size = new System.Drawing.Size(84, 20);
            this.lblHIDDevice.TabIndex = 0;
            this.lblHIDDevice.Text = "HID Device";
            // 
            // grpSource
            // 
            this.grpSource.Controls.Add(this.rbGUI);
            this.grpSource.Controls.Add(this.rbManual);
            this.grpSource.Location = new System.Drawing.Point(16, 317);
            this.grpSource.Name = "grpSource";
            this.grpSource.Size = new System.Drawing.Size(153, 95);
            this.grpSource.TabIndex = 2;
            this.grpSource.TabStop = false;
            this.grpSource.Text = "CONTROL SOURCE";
            // 
            // rbGUI
            // 
            this.rbGUI.AutoSize = true;
            this.rbGUI.Enabled = false;
            this.rbGUI.Location = new System.Drawing.Point(15, 60);
            this.rbGUI.Name = "rbGUI";
            this.rbGUI.Size = new System.Drawing.Size(54, 24);
            this.rbGUI.TabIndex = 1;
            this.rbGUI.Text = "GUI";
            this.rbGUI.UseVisualStyleBackColor = true;
            this.rbGUI.CheckedChanged += new System.EventHandler(this.rbGUI_CheckedChanged);
            // 
            // rbManual
            // 
            this.rbManual.AutoSize = true;
            this.rbManual.Checked = true;
            this.rbManual.Enabled = false;
            this.rbManual.Location = new System.Drawing.Point(15, 30);
            this.rbManual.Name = "rbManual";
            this.rbManual.Size = new System.Drawing.Size(79, 24);
            this.rbManual.TabIndex = 0;
            this.rbManual.TabStop = true;
            this.rbManual.Text = "Manual";
            this.rbManual.UseVisualStyleBackColor = true;
            this.rbManual.CheckedChanged += new System.EventHandler(this.rbManual_CheckedChanged);
            // 
            // grpTime
            // 
            this.grpTime.Controls.Add(this.numGreen);
            this.grpTime.Controls.Add(this.numYellow);
            this.grpTime.Controls.Add(this.numRed);
            this.grpTime.Controls.Add(this.btnReset);
            this.grpTime.Controls.Add(this.btnApplyTime);
            this.grpTime.Controls.Add(this.lblGreenCap);
            this.grpTime.Controls.Add(this.lblYellowCap);
            this.grpTime.Controls.Add(this.lblRedCap);
            this.grpTime.Location = new System.Drawing.Point(376, 317);
            this.grpTime.Name = "grpTime";
            this.grpTime.Size = new System.Drawing.Size(248, 164);
            this.grpTime.TabIndex = 3;
            this.grpTime.TabStop = false;
            this.grpTime.Text = "TRAFFIC LIGHT TIME SETUP";
            // 
            // numGreen
            // 
            this.numGreen.Location = new System.Drawing.Point(120, 91);
            this.numGreen.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numGreen.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numGreen.Name = "numGreen";
            this.numGreen.ReadOnly = true;
            this.numGreen.Size = new System.Drawing.Size(114, 27);
            this.numGreen.TabIndex = 10;
            this.numGreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numGreen.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // numYellow
            // 
            this.numYellow.Location = new System.Drawing.Point(120, 60);
            this.numYellow.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numYellow.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numYellow.Name = "numYellow";
            this.numYellow.ReadOnly = true;
            this.numYellow.Size = new System.Drawing.Size(114, 27);
            this.numYellow.TabIndex = 9;
            this.numYellow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numYellow.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // numRed
            // 
            this.numRed.Location = new System.Drawing.Point(120, 26);
            this.numRed.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numRed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRed.Name = "numRed";
            this.numRed.ReadOnly = true;
            this.numRed.Size = new System.Drawing.Size(114, 27);
            this.numRed.TabIndex = 8;
            this.numRed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numRed.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(120, 123);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(101, 35);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnApplyTime
            // 
            this.btnApplyTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnApplyTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplyTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnApplyTime.ForeColor = System.Drawing.Color.White;
            this.btnApplyTime.Location = new System.Drawing.Point(18, 125);
            this.btnApplyTime.Name = "btnApplyTime";
            this.btnApplyTime.Size = new System.Drawing.Size(96, 30);
            this.btnApplyTime.TabIndex = 6;
            this.btnApplyTime.Text = "Apply";
            this.btnApplyTime.UseVisualStyleBackColor = false;
            this.btnApplyTime.Click += new System.EventHandler(this.btnApplyTime_Click);
            // 
            // lblGreenCap
            // 
            this.lblGreenCap.BackColor = System.Drawing.Color.LimeGreen;
            this.lblGreenCap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblGreenCap.ForeColor = System.Drawing.Color.White;
            this.lblGreenCap.Location = new System.Drawing.Point(20, 92);
            this.lblGreenCap.Name = "lblGreenCap";
            this.lblGreenCap.Size = new System.Drawing.Size(70, 23);
            this.lblGreenCap.TabIndex = 4;
            this.lblGreenCap.Text = "Green";
            this.lblGreenCap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblYellowCap
            // 
            this.lblYellowCap.BackColor = System.Drawing.Color.Yellow;
            this.lblYellowCap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblYellowCap.ForeColor = System.Drawing.Color.Black;
            this.lblYellowCap.Location = new System.Drawing.Point(20, 55);
            this.lblYellowCap.Name = "lblYellowCap";
            this.lblYellowCap.Size = new System.Drawing.Size(70, 23);
            this.lblYellowCap.TabIndex = 2;
            this.lblYellowCap.Text = "Yellow";
            this.lblYellowCap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRedCap
            // 
            this.lblRedCap.BackColor = System.Drawing.Color.Red;
            this.lblRedCap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblRedCap.ForeColor = System.Drawing.Color.White;
            this.lblRedCap.Location = new System.Drawing.Point(20, 25);
            this.lblRedCap.Name = "lblRedCap";
            this.lblRedCap.Size = new System.Drawing.Size(70, 23);
            this.lblRedCap.TabIndex = 0;
            this.lblRedCap.Text = "Red";
            this.lblRedCap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTimingStatus
            // 
            this.lblTimingStatus.AutoSize = true;
            this.lblTimingStatus.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblTimingStatus.Location = new System.Drawing.Point(8, 218);
            this.lblTimingStatus.Name = "lblTimingStatus";
            this.lblTimingStatus.Size = new System.Drawing.Size(179, 20);
            this.lblTimingStatus.TabIndex = 4;
            this.lblTimingStatus.Text = " Đỏ=0s Vàng=0s Xanh=0s";
            this.lblTimingStatus.Click += new System.EventHandler(this.lblTimingStatus_Click);
            // 
            // lblClock
            // 
            this.lblClock.AutoSize = true;
            this.lblClock.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblClock.Location = new System.Drawing.Point(19, 426);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(80, 23);
            this.lblClock.TabIndex = 5;
            this.lblClock.Text = "00:00:00";
            this.lblClock.Click += new System.EventHandler(this.lblClock_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDate.Location = new System.Drawing.Point(19, 291);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(104, 23);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "01-01-2025";
            // 
            // grpDisplay
            // 
            this.grpDisplay.BackColor = System.Drawing.SystemColors.Highlight;
            this.grpDisplay.Controls.Add(this.pictureBox_Number);
            this.grpDisplay.Controls.Add(this.pictureBox_Light);
            this.grpDisplay.Location = new System.Drawing.Point(345, 40);
            this.grpDisplay.Name = "grpDisplay";
            this.grpDisplay.Size = new System.Drawing.Size(307, 246);
            this.grpDisplay.TabIndex = 7;
            this.grpDisplay.TabStop = false;
            this.grpDisplay.Text = "TRAFFIC DISPLAY";
            // 
            // pictureBox_Number
            // 
            this.pictureBox_Number.ErrorImage = global::USB_TrafficLightControl.Properties.Resources._7;
            this.pictureBox_Number.Image = global::USB_TrafficLightControl.Properties.Resources._8;
            this.pictureBox_Number.Location = new System.Drawing.Point(141, 18);
            this.pictureBox_Number.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox_Number.Name = "pictureBox_Number";
            this.pictureBox_Number.Size = new System.Drawing.Size(155, 221);
            this.pictureBox_Number.TabIndex = 14;
            this.pictureBox_Number.TabStop = false;
            // 
            // pictureBox_Light
            // 
            this.pictureBox_Light.ErrorImage = global::USB_TrafficLightControl.Properties.Resources.r;
            this.pictureBox_Light.Image = global::USB_TrafficLightControl.Properties.Resources.r;
            this.pictureBox_Light.Location = new System.Drawing.Point(6, 18);
            this.pictureBox_Light.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox_Light.Name = "pictureBox_Light";
            this.pictureBox_Light.Size = new System.Drawing.Size(102, 194);
            this.pictureBox_Light.TabIndex = 13;
            this.pictureBox_Light.TabStop = false;
            // 
            // lblNameStudent
            // 
            this.lblNameStudent.AutoSize = true;
            this.lblNameStudent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNameStudent.Location = new System.Drawing.Point(14, 455);
            this.lblNameStudent.Name = "lblNameStudent";
            this.lblNameStudent.Size = new System.Drawing.Size(96, 20);
            this.lblNameStudent.TabIndex = 8;
            this.lblNameStudent.Text = "LE VAN SON";
            // 
            // lblIDStudent
            // 
            this.lblIDStudent.AutoSize = true;
            this.lblIDStudent.Location = new System.Drawing.Point(114, 455);
            this.lblIDStudent.Name = "lblIDStudent";
            this.lblIDStudent.Size = new System.Drawing.Size(73, 20);
            this.lblIDStudent.TabIndex = 9;
            this.lblIDStudent.Text = "23695991";
            // 
            // grpMode
            // 
            this.grpMode.Controls.Add(this.btnMode3);
            this.grpMode.Controls.Add(this.btnMode2);
            this.grpMode.Controls.Add(this.btnMode1);
            this.grpMode.Location = new System.Drawing.Point(197, 317);
            this.grpMode.Name = "grpMode";
            this.grpMode.Size = new System.Drawing.Size(150, 170);
            this.grpMode.TabIndex = 10;
            this.grpMode.TabStop = false;
            this.grpMode.Text = "CONTROL MODE";
            // 
            // btnMode3
            // 
            this.btnMode3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMode3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMode3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnMode3.Location = new System.Drawing.Point(17, 122);
            this.btnMode3.Name = "btnMode3";
            this.btnMode3.Size = new System.Drawing.Size(119, 42);
            this.btnMode3.TabIndex = 2;
            this.btnMode3.Text = "MODE3-AUTO";
            this.btnMode3.UseVisualStyleBackColor = false;
            this.btnMode3.Click += new System.EventHandler(this.btnMode3_Click);
            // 
            // btnMode2
            // 
            this.btnMode2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMode2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMode2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnMode2.Location = new System.Drawing.Point(17, 74);
            this.btnMode2.Name = "btnMode2";
            this.btnMode2.Size = new System.Drawing.Size(119, 42);
            this.btnMode2.TabIndex = 1;
            this.btnMode2.Text = "MODE2 -Vàng\r\n";
            this.btnMode2.UseVisualStyleBackColor = false;
            this.btnMode2.Click += new System.EventHandler(this.btnMode2_Click);
            // 
            // btnMode1
            // 
            this.btnMode1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMode1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMode1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnMode1.Location = new System.Drawing.Point(17, 26);
            this.btnMode1.Name = "btnMode1";
            this.btnMode1.Size = new System.Drawing.Size(119, 42);
            this.btnMode1.TabIndex = 0;
            this.btnMode1.Text = "MODE1-ĐỎ";
            this.btnMode1.UseVisualStyleBackColor = false;
            this.btnMode1.Click += new System.EventHandler(this.btnMode1_Click);
            // 
            // lblControlMode
            // 
            this.lblControlMode.AutoSize = true;
            this.lblControlMode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblControlMode.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblControlMode.Location = new System.Drawing.Point(19, 259);
            this.lblControlMode.Name = "lblControlMode";
            this.lblControlMode.Size = new System.Drawing.Size(194, 20);
            this.lblControlMode.TabIndex = 11;
            this.lblControlMode.Text = "Chế độ: MANUAL (Tại trụ)";
            // 
            // lblCurrentMode
            // 
            this.lblCurrentMode.AutoSize = true;
            this.lblCurrentMode.ForeColor = System.Drawing.Color.DimGray;
            this.lblCurrentMode.Location = new System.Drawing.Point(187, 218);
            this.lblCurrentMode.Name = "lblCurrentMode";
            this.lblCurrentMode.Size = new System.Drawing.Size(146, 20);
            this.lblCurrentMode.TabIndex = 12;
            this.lblCurrentMode.Text = "Chờ kết nối Proteus...";
            this.lblCurrentMode.Click += new System.EventHandler(this.lblCurrentMode_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(698, 517);
            this.Controls.Add(this.lblCurrentMode);
            this.Controls.Add(this.lblControlMode);
            this.Controls.Add(this.grpTime);
            this.Controls.Add(this.grpMode);
            this.Controls.Add(this.lblIDStudent);
            this.Controls.Add(this.lblNameStudent);
            this.Controls.Add(this.grpDisplay);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblClock);
            this.Controls.Add(this.lblTimingStatus);
            this.Controls.Add(this.grpSource);
            this.Controls.Add(this.grpComm);
            this.Controls.Add(this.lblTitleMain);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TRAFFIC LIGHT CONTROL SYSTEM";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpComm.ResumeLayout(false);
            this.grpComm.PerformLayout();
            this.grpSource.ResumeLayout(false);
            this.grpSource.PerformLayout();
            this.grpTime.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRed)).EndInit();
            this.grpDisplay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Number)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Light)).EndInit();
            this.grpMode.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitleMain;
        private System.Windows.Forms.GroupBox grpComm;
        private System.Windows.Forms.Label lblHIDDevice;
        private System.Windows.Forms.ComboBox cboHIDDevice;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox grpSource;
        private System.Windows.Forms.RadioButton rbManual;
        private System.Windows.Forms.RadioButton rbGUI;
        private System.Windows.Forms.GroupBox grpTime;
        private System.Windows.Forms.Label lblRedCap;
        private System.Windows.Forms.Label lblYellowCap;
        private System.Windows.Forms.Label lblGreenCap;
        private System.Windows.Forms.NumericUpDown numRed;
        private System.Windows.Forms.NumericUpDown numYellow;
        private System.Windows.Forms.NumericUpDown numGreen;
        private System.Windows.Forms.Button btnApplyTime;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblTimingStatus;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.GroupBox grpDisplay;
        private System.Windows.Forms.Label lblNameStudent;
        private System.Windows.Forms.Label lblIDStudent;
        private System.Windows.Forms.GroupBox grpMode;
        private System.Windows.Forms.Button btnMode1;
        private System.Windows.Forms.Button btnMode2;
        private System.Windows.Forms.Button btnMode3;
        private System.Windows.Forms.Label lblControlMode;
        private System.Windows.Forms.Label lblCurrentMode;
        private System.Windows.Forms.PictureBox pictureBox_Light;
        private System.Windows.Forms.PictureBox pictureBox_Number;
    }
}
