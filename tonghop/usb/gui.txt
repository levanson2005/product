using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using HidSharp;

namespace USB_TrafficLightControl
{
    public partial class Form1 : Form
    {
        enum TrafficMode { Mode1_Red, Mode2_YellowBlink, Mode3_Time, ModeAuto }

        private TrafficMode currentMode = TrafficMode.ModeAuto;
        private bool isGUI = false;
        private int tRed = 5, tYellow = 3, tGreen = 8;
        private bool? lastWasDaytime = null;

        private const int DEFAULT_RED = 5;
        private const int DEFAULT_YELLOW = 3;
        private const int DEFAULT_GREEN = 8;
        private Panel panelTrafficLight;
        private const int USB_VID = 0x04D8;
        private const int USB_PID = 0x0001;

        private HidDevice hidDevice = null;
        private HidStream hidStream = null;
        private Thread readThread = null;
        private volatile bool running = false;

        private System.Windows.Forms.Timer clockTimer = new System.Windows.Forms.Timer();
        private System.Windows.Forms.Timer pollTimer = new System.Windows.Forms.Timer();

        // ============================================================
        //  Resource mapping:
        //  Den giao thong: pictureBox_Light
        //    r.jpg   = den do
        //    yl.jpg  = den vang
        //    gr.jpg  = den xanh
        //    off.png = tat het
        //  7-seg: pictureBox_Number
        //    1.png..9.png = so 1..9
        //    null         = tat
        // ============================================================

        public Form1()
        {
            InitializeComponent();
            InitTimers();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshDeviceList();
            pollTimer.Interval = 1000;
            pollTimer.Tick += PollTimer_Tick;
            pollTimer.Start();
        }

        private void RefreshDeviceList()
        {
            cboHIDDevice.Items.Clear();
            var devices = DeviceList.Local.GetHidDevices().ToList();
            foreach (var dev in devices)
                cboHIDDevice.Items.Add(
                    $"{dev.ProductName ?? "HID Device"} (VID:{dev.VendorID:X4} PID:{dev.ProductID:X4})");
            if (cboHIDDevice.Items.Count > 0) cboHIDDevice.SelectedIndex = 0;
        }

        // ═══════════════════════════════════════════════════════
        // POLL - tu dong ket noi/ngat ket noi
        // ═══════════════════════════════════════════════════════
        private void PollTimer_Tick(object sender, EventArgs e)
        {
            bool found = DeviceList.Local.GetHidDevices(USB_VID, USB_PID).Any();
            if (found && hidStream == null) ConnectDevice();
            if (!found && hidStream != null) DisconnectDevice();
        }

        // ═══════════════════════════════════════════════════════
        // KET NOI
        // ═══════════════════════════════════════════════════════
        private void ConnectDevice()
        {
            try
            {
                hidDevice = DeviceList.Local.GetHidDevices(USB_VID, USB_PID).FirstOrDefault();
                if (hidDevice == null) return;

                hidStream = hidDevice.Open();
                hidStream.ReadTimeout = Timeout.Infinite;
                hidStream.WriteTimeout = 2000;

                running = true;
                readThread = new Thread(ReadLoop) { IsBackground = true };
                readThread.Start();

                lblStatus.Text = "USB Connected";
                lblStatus.BackColor = Color.DodgerBlue;
                lblStatus.ForeColor = Color.White;

                rbGUI.Enabled = rbManual.Enabled = true;
                rbGUI.Checked = true;

                UpdateModeLabel("Đã kết nối");

                // Gui mode hien tai va gio thuc ngay khi ket noi
                SendByte((byte)(isGUI ? 'G' : 'M'));
                Thread.Sleep(50);
                SendBytes(new byte[] { (byte)'H', (byte)DateTime.Now.Hour });
            }
            catch { DisconnectDevice(); }
        }

        private void DisconnectDevice()
        {
            running = false;
            try { hidStream?.Close(); } catch { }
            hidStream = null;
            hidDevice = null;
            readThread = null;

            if (InvokeRequired) { Invoke(new Action(DisconnectUI)); return; }
            DisconnectUI();
        }

        private void DisconnectUI()
        {
            lblStatus.Text = "USB Disconnected";
            lblStatus.BackColor = Color.Gray;
            lblStatus.ForeColor = Color.White;

            rbGUI.Enabled = rbManual.Enabled = false;
            rbManual.Checked = true;
            btnMode1.Enabled = btnMode2.Enabled = btnMode3.Enabled = false;
            SetTimeInputsEnabled(false);

            // Tat het pictureBox
            SetLight("off");
            pictureBox_Number.Image = null;
            UpdateModeLabel("Chờ kết nối...");
        }

        // ═══════════════════════════════════════════════════════
        // READ LOOP
        // ═══════════════════════════════════════════════════════
        private void ReadLoop()
        {
            byte[] buf = new byte[hidDevice.GetMaxInputReportLength()];
            while (running)
            {
                try
                {
                    int len = hidStream.Read(buf, 0, buf.Length);
                    if (len > 0)
                        Invoke(new Action<byte[]>(ProcessUsbData), buf.Take(len).ToArray());
                }
                catch { break; }
            }
            DisconnectDevice();
        }

        // ═══════════════════════════════════════════════════════
        // GUI
        // ═══════════════════════════════════════════════════════
        private void SendByte(byte b)
        {
            try
            {
                if (hidStream == null) return;
                byte[] buf = new byte[hidDevice.GetMaxOutputReportLength()];
                buf[1] = b;
                hidStream.Write(buf);
            }
            catch { }
        }

        private void SendBytes(byte[] payload)
        {
            try
            {
                if (hidStream == null) return;
                byte[] buf = new byte[hidDevice.GetMaxOutputReportLength()];
                for (int i = 0; i < payload.Length && i + 1 < buf.Length; i++)
                    buf[i + 1] = payload[i];
                hidStream.Write(buf);
            }
            catch { }
        }

        // ═══════════════════════════════════════════════════════
        // HELPER: Set hinh anh pictureBox_Light
        //   "r"   = den do
        //   "y"   = den vang
        //   "g"   = den xanh
        //   "off" = tat het
        // ═══════════════════════════════════════════════════════
        private void SetLight(string color)
        {
            switch (color)
            {
                case "r": pictureBox_Light.Image = Properties.Resources.r; break;
                case "y": pictureBox_Light.Image = Properties.Resources.yl; break;
                case "g": pictureBox_Light.Image = Properties.Resources.gr; break;
                default: pictureBox_Light.Image = Properties.Resources.off; break;
            }
        }

        // ═══════════════════════════════════════════════════════
        // HELPER: Hien thi so tren pictureBox_Number
        //   n = 1..9 -> hien anh tuong ung
        //   n = 0 hoac ngoai range -> an (null)
        // ═══════════════════════════════════════════════════════
        private void ShowNumber(int n)
        {
            if (n < 1 || n > 9) { pictureBox_Number.Image = null; return; }

            // Resource ten: 1.png, 2.png ... 9.png
            // Trong Properties.Resources: ten la "_1", "_2" ... hoac "1", "2"
            // Tuy thuoc vao ten resource ban dat - sua lai neu can
            System.Drawing.Image[] imgs = {
                Properties.Resources._1,  // 1
                Properties.Resources._2,  // 2
                Properties.Resources._3,  // 3
                Properties.Resources._4,  // 4
                Properties.Resources._5,  // 5
                Properties.Resources._6,  // 6
                Properties.Resources._7,  // 7
                Properties.Resources._8,  // 8
                Properties.Resources._9   // 9
            };
            pictureBox_Number.Image = imgs[n - 1];
        }

        // ═══════════════════════════════════════════════════════
        // XU LY DU LIEU TU PIC (USB HID)
        // data[0] = ReportID (bo qua)
        // data[1] = lenh
        // data[2] = color (cho 'D')
        // data[3] = sec   (cho 'D')
        // ═══════════════════════════════════════════════════════
        private void ProcessUsbData(byte[] data)
        {
            if (data.Length < 2) return;
            char cmd = (char)data[1];

            switch (cmd)
            {
                // ── AUTO: dong bo den + so giay ──
                // PIC gui moi khi so giay thay doi
                // data[2]='R'/'Y'/'G', data[3]=so_giay
                case 'D':
                    if (data.Length < 4) return;
                    char color = (char)data[2];
                    int sec = data[3];

                    if (color == 'R') { SetLight("r"); UpdateModeLabel("AUTO – Đèn ĐỎ: " + sec + "s"); }
                    if (color == 'Y') { SetLight("y"); UpdateModeLabel("AUTO – Đèn VÀNG: " + sec + "s"); }
                    if (color == 'G') { SetLight("g"); UpdateModeLabel("AUTO – Đèn XANH: " + sec + "s"); }

                    // Hien so giay tren pictureBox_Number
                    ShowNumber(sec);
                    break;

                // ── VANG NHAP NHAY: PIC gui moi 500ms ──
                // data[2] = 1 (sang) hoac 0 (tat)
                case 'B':
                    bool picYellow = (data.Length >= 3 && data[2] == 1);
                    SetLight(picYellow ? "y" : "off");
                    pictureBox_Number.Image = null;   // Tat 7-seg khi nhap nhay
                    if (currentMode == TrafficMode.Mode3_Time)
                        UpdateModeLabel("MODE 3 – Ban đêm (Vàng nháy)");
                    break;

                // ── Nut vat ly B: DO lien tuc ──
                case 'R':
                    if (isGUI) return;
                    currentMode = TrafficMode.Mode1_Red;
                    SetLight("r");
                    pictureBox_Number.Image = null;
                    UpdateModeLabel("MODE 1 – Đỏ liên tục (Manual)");
                    HighlightBtn(btnMode1);
                    break;

                // ── Nut vat ly O: VANG nhay ──
                case 'Y':
                    if (isGUI) return;
                    currentMode = TrafficMode.Mode2_YellowBlink;
                    SetLight("y");
                    pictureBox_Number.Image = null;
                    UpdateModeLabel("MODE 2 – Vàng nhấp nháy (Manual)");
                    HighlightBtn(btnMode2);
                    break;

                // ── Nut vat ly P: MODE3 ──
                case 'A':
                    if (isGUI) return;
                    currentMode = TrafficMode.Mode3_Time;
                    SetLight("off");
                    pictureBox_Number.Image = null;
                    HighlightBtn(btnMode3);
                    bool isDay = (DateTime.Now.Hour >= 5 && DateTime.Now.Hour < 22);
                    UpdateModeLabel(isDay ? "MODE 3 – Ban ngày (AUTO)" : "MODE 3 – Ban đêm (Vàng nháy)");
                    break;

                // ── Xac nhan GUI mode ──
                case 'G':
                    isGUI = true; rbGUI.Checked = true;
                    lblControlMode.Text = "Chế độ: GUI";
                    lblControlMode.ForeColor = Color.Blue;
                    btnMode1.Enabled = btnMode2.Enabled = btnMode3.Enabled = true;
                    SetTimeInputsEnabled(true);
                    break;

                // ── Xac nhan MANUAL mode ──
                case 'M':
                    isGUI = false; rbManual.Checked = true;
                    lblControlMode.Text = "Chế độ: MANUAL";
                    lblControlMode.ForeColor = Color.DarkOrange;
                    btnMode1.Enabled = btnMode2.Enabled = btnMode3.Enabled = false;
                    SetTimeInputsEnabled(false);
                    break;

                // ── Xac nhan set time ──
                case 'S':
                    if (data.Length >= 5)
                        lblTimingStatus.Text = "Đã cài: Đỏ=" + data[2] + "s  Vàng=" + data[3] + "s  Xanh=" + data[4] + "s";
                    break;

                // ── Xac nhan lenh tu GUI ──
                case '1':   // PIC xac nhan MODE1 (Do)
                    SetLight("r");
                    pictureBox_Number.Image = null;
                    UpdateModeLabel("MODE 1 – Đỏ liên tục");
                    break;

                case '2':   // PIC xac nhan MODE2 (Vang nhay)
                    SetLight("y");
                    pictureBox_Number.Image = null;
                    UpdateModeLabel("MODE 2 – Vàng nhấp nháy");
                    break;

                case '3':   // PIC xac nhan AUTO
                    SetLight("off");
                    pictureBox_Number.Image = null;
                    UpdateModeLabel("AUTO – Chờ PIC...");
                    break;
            }
        }

        // ═══════════════════════════════════════════════════════
        // NUT MODE
        // ═══════════════════════════════════════════════════════
        private void btnMode1_Click(object sender, EventArgs e)
        {
            currentMode = TrafficMode.Mode1_Red;
            lastWasDaytime = null;
            SetLight("r");
            pictureBox_Number.Image = null;
            UpdateModeLabel("MODE 1 – Đỏ liên tục");
            HighlightBtn(btnMode1);
            SendByte((byte)'R');
        }

        private void btnMode2_Click(object sender, EventArgs e)
        {
            currentMode = TrafficMode.Mode2_YellowBlink;
            lastWasDaytime = null;
            SetLight("y");
            pictureBox_Number.Image = null;
            UpdateModeLabel("MODE 2 – Vàng nhấp nháy");
            HighlightBtn(btnMode2);
            SendByte((byte)'Y');
        }

        private void btnMode3_Click(object sender, EventArgs e)
        {
            currentMode = TrafficMode.Mode3_Time;
            lastWasDaytime = null;
            SetLight("off");
            pictureBox_Number.Image = null;
            UpdateModeLabel("MODE 3 – Đang đồng bộ...");
            HighlightBtn(btnMode3);
            SendByte((byte)'P');
            CheckTimeMode3(DateTime.Now);
        }

        private void CheckTimeMode3(DateTime now)
        {
            bool isDaytime = (now.Hour >= 5 && now.Hour < 22);
            if (lastWasDaytime == isDaytime) return;
            lastWasDaytime = isDaytime;
            UpdateModeLabel(isDaytime ? "MODE 3 – Ban ngày (AUTO)" : "MODE 3 – Ban đêm (Vàng nháy)");
        }

        private void HighlightBtn(Button active)
        {
            btnMode1.BackColor = (active == btnMode1) ? Color.Red : Color.FromArgb(224, 224, 224);
            btnMode2.BackColor = (active == btnMode2) ? Color.Gold : Color.FromArgb(224, 224, 224);
            btnMode3.BackColor = (active == btnMode3) ? Color.DeepSkyBlue : Color.FromArgb(224, 224, 224);
            btnMode1.ForeColor = (active == btnMode1) ? Color.White : Color.Black;
            btnMode2.ForeColor = Color.Black;
            btnMode3.ForeColor = (active == btnMode3) ? Color.White : Color.Black;
        }

        // ═══════════════════════════════════════════════════════
        // RADIO BUTTON GUI / MANUAL
        // ═══════════════════════════════════════════════════════
        private void rbGUI_CheckedChanged(object sender, EventArgs e)
        {
            if (!rbGUI.Checked) return;
            isGUI = true;
            lblControlMode.Text = "Chế độ: GUI (Máy tính)";
            lblControlMode.ForeColor = Color.Blue;
            btnMode1.Enabled = btnMode2.Enabled = btnMode3.Enabled = true;
            btnReset.Enabled = true;
            SetTimeInputsEnabled(true);
            SendByte((byte)'G');
        }

        private void rbManual_CheckedChanged(object sender, EventArgs e)
        {
            if (!rbManual.Checked) return;
            isGUI = false;
            lblControlMode.Text = "Chế độ: MANUAL (Tại trụ)";
            lblControlMode.ForeColor = Color.DarkOrange;
            btnMode1.Enabled = btnMode2.Enabled = btnMode3.Enabled = false;
            btnReset.Enabled = false;
            SetTimeInputsEnabled(false);
            UpdateModeLabel("MANUAL – Điều khiển tay");
            SendByte((byte)'M');
        }

        // ═══════════════════════════════════════════════════════
        // TIMERS
        // ═══════════════════════════════════════════════════════
        private void InitTimers()
        {
            clockTimer.Interval = 1000;
            clockTimer.Tick += (s, e) =>
            {
                var now = DateTime.Now;
                lblClock.Text = now.ToString("HH:mm:ss");
                lblDate.Text = now.ToString("dd/MM/yyyy");

                // Gui gio xuong PIC moi giay (PIC dung de quyet dinh MODE3)
                SendBytes(new byte[] { (byte)'H', (byte)now.Hour });

                if (currentMode == TrafficMode.Mode3_Time)
                    CheckTimeMode3(now);
            };
            clockTimer.Start();
        }

        // ═══════════════════════════════════════════════════════
        // HELPERS
        // ═══════════════════════════════════════════════════════
        private void SetTimeInputsEnabled(bool en)
        {
            numRed.Enabled = numYellow.Enabled = numGreen.Enabled = btnApplyTime.Enabled = en;
        }

        private void UpdateModeLabel(string text)
        {
            lblCurrentMode.Text = text;
            lblCurrentMode.ForeColor = Color.Lime;
        }

        // ═══════════════════════════════════════════════════════
        // APPLY / RESET TIMING
        // ═══════════════════════════════════════════════════════
        private void btnApplyTime_Click(object sender, EventArgs e)
        {
            tRed = (int)numRed.Value;
            tYellow = (int)numYellow.Value;
            tGreen = (int)numGreen.Value;
            SendBytes(new byte[] { (byte)'T', (byte)tRed, (byte)tYellow, (byte)tGreen });
            lblTimingStatus.Text = "Đã cài: Đỏ=" + tRed + "s  Vàng=" + tYellow + "s  Xanh=" + tGreen + "s";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            numRed.Value = DEFAULT_RED;
            numYellow.Value = DEFAULT_YELLOW;
            numGreen.Value = DEFAULT_GREEN;
            btnApplyTime_Click(null, null);
        }

        // ═══════════════════════════════════════════════════════
        // STUBS + FORM CLOSING
        // ═══════════════════════════════════════════════════════
        private void txtNumberOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void panelTrafficLight_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            var r = new Rectangle(5, 5, panelTrafficLight.Width - 10, panelTrafficLight.Height - 10);
            using (var br = new SolidBrush(Color.Gainsboro)) g.FillRoundedRectangle(br, r, 10);
            using (var pen = new Pen(Color.Gray, 1)) g.DrawRoundedRectangle(pen, r, 10);
        }

        private void lblClock_Click(object sender, EventArgs e) { }
        private void lblCurrentMode_Click(object sender, EventArgs e) { }
        private void lblTimingStatus_Click(object sender, EventArgs e) { }
        private void numericUpDown2_ValueChanged(object sender, EventArgs e) { }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Bạn có muốn thoát chương trình không?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) e.Cancel = true;
        }
    }

    // GraphicsExtensions giu nguyen
    public static class GraphicsExtensions
    {
        public static void FillRoundedRectangle(this Graphics g, Brush b, Rectangle r, int radius)
        { using (var path = BuildPath(r, radius)) g.FillPath(b, path); }
        public static void DrawRoundedRectangle(this Graphics g, Pen p, Rectangle r, int radius)
        { using (var path = BuildPath(r, radius)) g.DrawPath(p, path); }
        private static System.Drawing.Drawing2D.GraphicsPath BuildPath(Rectangle r, int radius)
        {
            int d = radius * 2;
            var path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(r.X, r.Y, d, d, 180, 90);
            path.AddArc(r.Right - d, r.Y, d, d, 270, 90);
            path.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90);
            path.AddArc(r.X, r.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}