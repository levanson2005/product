namespace traffic
{
    partial class lable_reset
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
            this.groupBox1_Setup = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_Port = new System.Windows.Forms.TextBox();
            this.textBox_IP4 = new System.Windows.Forms.TextBox();
            this.textBox_IP1 = new System.Windows.Forms.TextBox();
            this.textBox_IP3 = new System.Windows.Forms.TextBox();
            this.textBox_IP2 = new System.Windows.Forms.TextBox();
            this.ldldata = new System.Windows.Forms.Label();
            this.button_Disconnect = new System.Windows.Forms.Button();
            this.button_Connect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_LED = new System.Windows.Forms.GroupBox();
            this.pictureBox_Number = new System.Windows.Forms.PictureBox();
            this.pictureBox_Light = new System.Windows.Forms.PictureBox();
            this.groupBox_GUIMode = new System.Windows.Forms.GroupBox();
            this.checkBox_GUI = new System.Windows.Forms.CheckBox();
            this.checkBox_Manual = new System.Windows.Forms.CheckBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox_ControlMode = new System.Windows.Forms.GroupBox();
            this.btn_O = new System.Windows.Forms.Button();
            this.btn_P = new System.Windows.Forms.Button();
            this.btn_B = new System.Windows.Forms.Button();
            this.timerAuto = new System.Windows.Forms.Timer(this.components);
            this.label_Time = new System.Windows.Forms.Label();
            this.label_Mode = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.numGreen = new System.Windows.Forms.NumericUpDown();
            this.numYellow = new System.Windows.Forms.NumericUpDown();
            this.numRed = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.timeCLock = new System.Windows.Forms.Timer(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1_Setup.SuspendLayout();
            this.groupBox_LED.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Number)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Light)).BeginInit();
            this.groupBox_GUIMode.SuspendLayout();
            this.groupBox_ControlMode.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRed)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1_Setup
            // 
            this.groupBox1_Setup.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox1_Setup.Controls.Add(this.label10);
            this.groupBox1_Setup.Controls.Add(this.textBox_Port);
            this.groupBox1_Setup.Controls.Add(this.textBox_IP4);
            this.groupBox1_Setup.Controls.Add(this.textBox_IP1);
            this.groupBox1_Setup.Controls.Add(this.textBox_IP3);
            this.groupBox1_Setup.Controls.Add(this.textBox_IP2);
            this.groupBox1_Setup.Controls.Add(this.ldldata);
            this.groupBox1_Setup.Controls.Add(this.button_Disconnect);
            this.groupBox1_Setup.Controls.Add(this.button_Connect);
            this.groupBox1_Setup.Controls.Add(this.label1);
            this.groupBox1_Setup.ForeColor = System.Drawing.Color.Black;
            this.groupBox1_Setup.Location = new System.Drawing.Point(12, 27);
            this.groupBox1_Setup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1_Setup.Name = "groupBox1_Setup";
            this.groupBox1_Setup.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1_Setup.Size = new System.Drawing.Size(320, 194);
            this.groupBox1_Setup.TabIndex = 0;
            this.groupBox1_Setup.TabStop = false;
            this.groupBox1_Setup.Text = "COMMUNICATION SETUP";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 23);
            this.label10.TabIndex = 13;
            this.label10.Text = "textBox_Port ";
            // 
            // textBox_Port
            // 
            this.textBox_Port.Location = new System.Drawing.Point(122, 88);
            this.textBox_Port.Name = "textBox_Port";
            this.textBox_Port.Size = new System.Drawing.Size(79, 30);
            this.textBox_Port.TabIndex = 12;
            this.textBox_Port.TextChanged += new System.EventHandler(this.textBox_Port_TextChanged);
            // 
            // textBox_IP4
            // 
            this.textBox_IP4.Location = new System.Drawing.Point(265, 46);
            this.textBox_IP4.Name = "textBox_IP4";
            this.textBox_IP4.Size = new System.Drawing.Size(44, 30);
            this.textBox_IP4.TabIndex = 11;
            // 
            // textBox_IP1
            // 
            this.textBox_IP1.Location = new System.Drawing.Point(99, 46);
            this.textBox_IP1.Name = "textBox_IP1";
            this.textBox_IP1.Size = new System.Drawing.Size(44, 30);
            this.textBox_IP1.TabIndex = 10;
            // 
            // textBox_IP3
            // 
            this.textBox_IP3.Location = new System.Drawing.Point(211, 46);
            this.textBox_IP3.Name = "textBox_IP3";
            this.textBox_IP3.Size = new System.Drawing.Size(44, 30);
            this.textBox_IP3.TabIndex = 9;
            // 
            // textBox_IP2
            // 
            this.textBox_IP2.Location = new System.Drawing.Point(157, 46);
            this.textBox_IP2.Name = "textBox_IP2";
            this.textBox_IP2.Size = new System.Drawing.Size(44, 30);
            this.textBox_IP2.TabIndex = 8;
            this.textBox_IP2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // ldldata
            // 
            this.ldldata.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(47)))), ((int)(((byte)(77)))));
            this.ldldata.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ldldata.Location = new System.Drawing.Point(209, 85);
            this.ldldata.Name = "ldldata";
            this.ldldata.Size = new System.Drawing.Size(100, 35);
            this.ldldata.TabIndex = 6;
            this.ldldata.Text = "Status";
            this.ldldata.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_Disconnect
            // 
            this.button_Disconnect.BackColor = System.Drawing.Color.IndianRed;
            this.button_Disconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Disconnect.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.button_Disconnect.Location = new System.Drawing.Point(160, 137);
            this.button_Disconnect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Disconnect.Name = "button_Disconnect";
            this.button_Disconnect.Size = new System.Drawing.Size(105, 37);
            this.button_Disconnect.TabIndex = 3;
            this.button_Disconnect.Text = "Disconnect";
            this.button_Disconnect.UseVisualStyleBackColor = false;
            this.button_Disconnect.Click += new System.EventHandler(this.button_Disconnect_Click);
            // 
            // button_Connect
            // 
            this.button_Connect.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button_Connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Connect.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.button_Connect.Location = new System.Drawing.Point(20, 137);
            this.button_Connect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Connect.Name = "button_Connect";
            this.button_Connect.Size = new System.Drawing.Size(105, 37);
            this.button_Connect.TabIndex = 3;
            this.button_Connect.Text = "Connect";
            this.button_Connect.UseVisualStyleBackColor = false;
            this.button_Connect.Click += new System.EventHandler(this.button_Connect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "COM port";
            // 
            // groupBox_LED
            // 
            this.groupBox_LED.Controls.Add(this.pictureBox_Number);
            this.groupBox_LED.Controls.Add(this.pictureBox_Light);
            this.groupBox_LED.ForeColor = System.Drawing.Color.Black;
            this.groupBox_LED.Location = new System.Drawing.Point(327, 248);
            this.groupBox_LED.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_LED.Name = "groupBox_LED";
            this.groupBox_LED.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_LED.Size = new System.Drawing.Size(261, 230);
            this.groupBox_LED.TabIndex = 1;
            this.groupBox_LED.TabStop = false;
            this.groupBox_LED.Text = "TRAFFIC DISPLAY";
            this.groupBox_LED.Enter += new System.EventHandler(this.groupBox_LED_Enter);
            // 
            // pictureBox_Number
            // 
            this.pictureBox_Number.Location = new System.Drawing.Point(129, 31);
            this.pictureBox_Number.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox_Number.Name = "pictureBox_Number";
            this.pictureBox_Number.Size = new System.Drawing.Size(111, 185);
            this.pictureBox_Number.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Number.TabIndex = 1;
            this.pictureBox_Number.TabStop = false;
            this.pictureBox_Number.Click += new System.EventHandler(this.pictureBox_Number_Click);
            // 
            // pictureBox_Light
            // 
            this.pictureBox_Light.ErrorImage = null;
            this.pictureBox_Light.Image = global::traffic.Properties.Resources.yl;
            this.pictureBox_Light.Location = new System.Drawing.Point(6, 31);
            this.pictureBox_Light.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox_Light.Name = "pictureBox_Light";
            this.pictureBox_Light.Size = new System.Drawing.Size(100, 191);
            this.pictureBox_Light.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Light.TabIndex = 0;
            this.pictureBox_Light.TabStop = false;
            // 
            // groupBox_GUIMode
            // 
            this.groupBox_GUIMode.Controls.Add(this.checkBox_GUI);
            this.groupBox_GUIMode.Controls.Add(this.checkBox_Manual);
            this.groupBox_GUIMode.ForeColor = System.Drawing.Color.Black;
            this.groupBox_GUIMode.Location = new System.Drawing.Point(20, 229);
            this.groupBox_GUIMode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_GUIMode.Name = "groupBox_GUIMode";
            this.groupBox_GUIMode.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_GUIMode.Size = new System.Drawing.Size(133, 152);
            this.groupBox_GUIMode.TabIndex = 2;
            this.groupBox_GUIMode.TabStop = false;
            this.groupBox_GUIMode.Text = "CONTROL SOURCE";
            // 
            // checkBox_GUI
            // 
            this.checkBox_GUI.AutoSize = true;
            this.checkBox_GUI.Location = new System.Drawing.Point(6, 112);
            this.checkBox_GUI.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox_GUI.Name = "checkBox_GUI";
            this.checkBox_GUI.Size = new System.Drawing.Size(61, 27);
            this.checkBox_GUI.TabIndex = 7;
            this.checkBox_GUI.Text = "GUI";
            this.checkBox_GUI.UseVisualStyleBackColor = true;
            this.checkBox_GUI.CheckedChanged += new System.EventHandler(this.checkBox_GUI_CheckedChanged);
            // 
            // checkBox_Manual
            // 
            this.checkBox_Manual.AutoSize = true;
            this.checkBox_Manual.Location = new System.Drawing.Point(7, 55);
            this.checkBox_Manual.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox_Manual.Name = "checkBox_Manual";
            this.checkBox_Manual.Size = new System.Drawing.Size(89, 27);
            this.checkBox_Manual.TabIndex = 5;
            this.checkBox_Manual.Text = "Manual";
            this.checkBox_Manual.UseVisualStyleBackColor = true;
            this.checkBox_Manual.CheckedChanged += new System.EventHandler(this.checkBox_Manual_CheckedChanged);
            // 
            // groupBox_ControlMode
            // 
            this.groupBox_ControlMode.Controls.Add(this.btn_O);
            this.groupBox_ControlMode.Controls.Add(this.btn_P);
            this.groupBox_ControlMode.Controls.Add(this.btn_B);
            this.groupBox_ControlMode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_ControlMode.ForeColor = System.Drawing.Color.Black;
            this.groupBox_ControlMode.Location = new System.Drawing.Point(177, 229);
            this.groupBox_ControlMode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_ControlMode.Name = "groupBox_ControlMode";
            this.groupBox_ControlMode.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_ControlMode.Size = new System.Drawing.Size(144, 152);
            this.groupBox_ControlMode.TabIndex = 3;
            this.groupBox_ControlMode.TabStop = false;
            this.groupBox_ControlMode.Text = "CONTROL MODE";
            // 
            // btn_O
            // 
            this.btn_O.BackColor = System.Drawing.Color.Gold;
            this.btn_O.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_O.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_O.ForeColor = System.Drawing.Color.Black;
            this.btn_O.Location = new System.Drawing.Point(6, 71);
            this.btn_O.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_O.Name = "btn_O";
            this.btn_O.Size = new System.Drawing.Size(108, 37);
            this.btn_O.TabIndex = 10;
            this.btn_O.Text = "MODE2-VANG";
            this.btn_O.UseVisualStyleBackColor = false;
            this.btn_O.Click += new System.EventHandler(this.btn_O_Click);
            // 
            // btn_P
            // 
            this.btn_P.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_P.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_P.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_P.ForeColor = System.Drawing.Color.Black;
            this.btn_P.Location = new System.Drawing.Point(7, 112);
            this.btn_P.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_P.Name = "btn_P";
            this.btn_P.Size = new System.Drawing.Size(107, 36);
            this.btn_P.TabIndex = 10;
            this.btn_P.Text = "MODE3 AUTO";
            this.btn_P.UseVisualStyleBackColor = false;
            this.btn_P.Click += new System.EventHandler(this.btn_P_Click);
            // 
            // btn_B
            // 
            this.btn_B.BackColor = System.Drawing.Color.Tomato;
            this.btn_B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_B.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_B.ForeColor = System.Drawing.Color.Black;
            this.btn_B.Location = new System.Drawing.Point(6, 28);
            this.btn_B.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_B.Name = "btn_B";
            this.btn_B.Size = new System.Drawing.Size(108, 38);
            this.btn_B.TabIndex = 10;
            this.btn_B.Text = "MODE1- DO";
            this.btn_B.UseVisualStyleBackColor = false;
            this.btn_B.Click += new System.EventHandler(this.btn_B_Click);
            // 
            // timerAuto
            // 
            this.timerAuto.Tag = "Event";
            this.timerAuto.Tick += new System.EventHandler(this.timerAuto_Tick);
            // 
            // label_Time
            // 
            this.label_Time.AutoSize = true;
            this.label_Time.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Time.ForeColor = System.Drawing.Color.Black;
            this.label_Time.Location = new System.Drawing.Point(17, 385);
            this.label_Time.Name = "label_Time";
            this.label_Time.Size = new System.Drawing.Size(138, 28);
            this.label_Time.TabIndex = 4;
            this.label_Time.Text = "Date and Time";
            this.label_Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Time.Click += new System.EventHandler(this.label_Time_Click);
            // 
            // label_Mode
            // 
            this.label_Mode.AutoSize = true;
            this.label_Mode.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Mode.ForeColor = System.Drawing.Color.Black;
            this.label_Mode.Location = new System.Drawing.Point(16, 455);
            this.label_Mode.Name = "label_Mode";
            this.label_Mode.Size = new System.Drawing.Size(117, 23);
            this.label_Mode.TabIndex = 5;
            this.label_Mode.Text = "Current Mode";
            this.label_Mode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Mode.Click += new System.EventHandler(this.label_Mode_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 710);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "StudentID:23703231";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(199, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(275, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = " TRAFFIC LIGHT CONTROL SYSTEM";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(169, 710);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Dương Viết Hùng";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.numGreen);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.numYellow);
            this.groupBox1.Controls.Add(this.numRed);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(338, 27);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(242, 204);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TRAFFIC LIGHT TIME SETUP";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.Location = new System.Drawing.Point(18, 154);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 33);
            this.button1.TabIndex = 10;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numGreen
            // 
            this.numGreen.Location = new System.Drawing.Point(126, 114);
            this.numGreen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.numGreen.Size = new System.Drawing.Size(103, 30);
            this.numGreen.TabIndex = 9;
            this.numGreen.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numGreen.ValueChanged += new System.EventHandler(this.numGreen_ValueChanged);
            // 
            // numYellow
            // 
            this.numYellow.Location = new System.Drawing.Point(126, 69);
            this.numYellow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.numYellow.Size = new System.Drawing.Size(103, 30);
            this.numYellow.TabIndex = 8;
            this.numYellow.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numYellow.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // numRed
            // 
            this.numRed.Location = new System.Drawing.Point(126, 31);
            this.numRed.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.numRed.Size = new System.Drawing.Size(103, 30);
            this.numRed.TabIndex = 7;
            this.numRed.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numRed.ValueChanged += new System.EventHandler(this.numRed_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Yellow;
            this.label7.Location = new System.Drawing.Point(17, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 23);
            this.label7.TabIndex = 2;
            this.label7.Text = "Yellow";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Green;
            this.label6.Location = new System.Drawing.Point(17, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = "Green";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(17, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Red";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(165, 154);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 34);
            this.button2.TabIndex = 13;
            this.button2.Text = "RESET";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timeCLock
            // 
            this.timeCLock.Interval = 1000;
            this.timeCLock.Tick += new System.EventHandler(this.timeCLock_Tick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(81, 422);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 23);
            this.label8.TabIndex = 14;
            this.label8.Text = "LE VAN SON";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(209, 422);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 23);
            this.label9.TabIndex = 15;
            this.label9.Text = "23695991";
            // 
            // lable_reset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(597, 494);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_Mode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_Time);
            this.Controls.Add(this.groupBox_ControlMode);
            this.Controls.Add(this.groupBox_GUIMode);
            this.Controls.Add(this.groupBox_LED);
            this.Controls.Add(this.groupBox1_Setup);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ForeColor = System.Drawing.Color.Gray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "lable_reset";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1_Setup.ResumeLayout(false);
            this.groupBox1_Setup.PerformLayout();
            this.groupBox_LED.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Number)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Light)).EndInit();
            this.groupBox_GUIMode.ResumeLayout(false);
            this.groupBox_GUIMode.PerformLayout();
            this.groupBox_ControlMode.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1_Setup;
        private System.Windows.Forms.Button button_Disconnect;
        private System.Windows.Forms.Button button_Connect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox_LED;
        private System.Windows.Forms.GroupBox groupBox_GUIMode;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBox_ControlMode;
        private System.Windows.Forms.PictureBox pictureBox_Number;
        private System.Windows.Forms.PictureBox pictureBox_Light;
        private System.Windows.Forms.Timer timerAuto;
        private System.Windows.Forms.Button btn_O;
        private System.Windows.Forms.Button btn_P;
        private System.Windows.Forms.Button btn_B;
        private System.Windows.Forms.Label label_Time;
        private System.Windows.Forms.CheckBox checkBox_Manual;
        private System.Windows.Forms.CheckBox checkBox_GUI;
        private System.Windows.Forms.Label label_Mode;
        private System.Windows.Forms.Label ldldata;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;




        private System.Windows.Forms.NumericUpDown numGreen;
        private System.Windows.Forms.NumericUpDown numYellow;
        private System.Windows.Forms.NumericUpDown numRed;
        private System.Windows.Forms.Timer timeCLock;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_Port;
        private System.Windows.Forms.TextBox textBox_IP4;
        private System.Windows.Forms.TextBox textBox_IP1;
        private System.Windows.Forms.TextBox textBox_IP3;
        private System.Windows.Forms.TextBox textBox_IP2;
    }
}

