using System;
using System.IO.Ports;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace traffic
{
    public partial class lable_reset : Form
    {
        private readonly object _serialLock = new object();
        private string lastData = "";
        private string currentMode = "";
        private bool _isSending = false;
        private bool _suppressCheckEvent = false;

        public lable_reset()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
            serialPort1.DataReceived += serialPort1_DataReceived;
        }

        // =========================================================
        //  DATA RECEIVED
        // =========================================================
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string data;
            lock (_serialLock) { data = serialPort1.ReadExisting(); }

            this.Invoke(new Action(() =>
            {
                foreach (char c in data)
                {
                    switch (c)
                    {
                        case 'R':
                            pictureBox_Light.Image = Properties.Resources.r;
                            break;
                        case 'Y':
                            pictureBox_Light.Image = Properties.Resources.yl;
                            // Khi Mode 2 (O) hoặc Mode 3 ban đêm → xóa LED 7 đoạn
                            if (currentMode == "O" || (currentMode == "P" && IsNightTime()))
                                pictureBox_Number.Image = null;
                            break;
                        case 'F':
                            pictureBox_Light.Image = Properties.Resources.off_1;
                            // Khi Mode 2 (O) hoặc Mode 3 ban đêm → xóa LED 7 đoạn
                            if (currentMode == "O" || (currentMode == "P" && IsNightTime()))
                                pictureBox_Number.Image = null;
                            break;
                        case 'G':
                            pictureBox_Light.Image = Properties.Resources.gr;
                            break;

                        case 'B':
                            if (currentMode != "B")
                            {
                                timeCLock.Stop();
                                currentMode = "B";
                                lastData = "";
                                pictureBox_Light.Image = Properties.Resources.r;
                                pictureBox_Number.Image = null;
                                label_Mode.Text = "MODE 1 - Đỏ liên tục (Manual)";
                            }
                            break;

                        case 'O':
                            if (currentMode != "O")
                            {
                                timeCLock.Stop();
                                currentMode = "O";
                                lastData = "";
                                pictureBox_Light.Image = Properties.Resources.off_1;
                                pictureBox_Number.Image = null;
                                label_Mode.Text = "MODE 2 - Vàng nhấp nháy (Manual)";
                            }
                            break;

                        case 'P':
                            if (currentMode != "P")
                            {
                                timeCLock.Stop();
                                currentMode = "P";
                                lastData = "";
                                SendDayNight();
                                timeCLock.Interval = 5000;
                                timeCLock.Start();
                                label_Mode.Text = "MODE 3 - Theo thời gian (Manual)";
                            }
                            break;

                        case 'X':
                            label_Mode.Text = label_Mode.Text.Replace(" ✓", "") + " ✓";
                            break;

                        default:
                            if (char.IsDigit(c))
                            {
                                if (currentMode == "O" || (currentMode == "P" && IsNightTime()))
                                {
                                    pictureBox_Number.Image = null;
                                }
                                else
                                {
                                    ShowNumber(c - '0');
                                }
                            }
                            break;
                    }
                }
            }));
        }

        // =========================================================
        //  FORM LOAD
        // =========================================================
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox_SelectCOM.Items.Clear();
            foreach (string port in SerialPort.GetPortNames())
                comboBox_SelectCOM.Items.Add(port);

            numRed.Minimum = 1; numRed.Maximum = 9;
            numYellow.Minimum = 1; numYellow.Maximum = 9;
            numGreen.Minimum = 1; numGreen.Maximum = 9;
            numRed.ReadOnly = false;
            numYellow.ReadOnly = false;
            numGreen.ReadOnly = false;

            timerAuto.Interval = 1000;
            timeCLock.Interval = 5000;
            timerAuto.Start();

            SetUIConnected(false);
        }

        // =========================================================
        //  HELPER UI
        // =========================================================
        private void SetUIConnected(bool connected)
        {
            button_Connect.Enabled = !connected;
            button_Disconnect.Enabled = connected;
            groupBox_LED.Enabled = connected;
            groupBox_GUIMode.Enabled = connected;

            groupBox_ControlMode.Enabled = false;
            groupBox1.Enabled = false;
            numRed.Enabled = false;
            numYellow.Enabled = false;
            numGreen.Enabled = false;
            btn_B.Enabled = false;
            btn_O.Enabled = false;
            btn_P.Enabled = false;

            _suppressCheckEvent = true;
            checkBox_GUI.Checked = false;
            checkBox_Manual.Checked = false;
            _suppressCheckEvent = false;
        }

        // =========================================================
        //  GỬI PACKET 5 BYTE: T + r + y + g + mode
        //
        //  FIX CHẬM:
        //  1. Bỏ Task.Run bọc ngoài Write -> Write trực tiếp, không tạo thread thừa
        //  2. Giảm Task.Delay từ 150ms -> 50ms (đủ để PIC xử lý 5 byte @ 9600baud)
        //  3. _isSending reset trong finally -> LUÔN được reset dù có lỗi
        // =========================================================
        private async Task SendPacketSafe(byte red, byte yellow, byte green, string modeCmd)
        {
            if (!serialPort1.IsOpen || _isSending) return;
            _isSending = true;

            bool clockWasRunning = timeCLock.Enabled;
            timeCLock.Stop();

            try
            {
                byte[] packet = new byte[5];
                packet[0] = (byte)'T';
                packet[1] = (byte)('0' + red);
                packet[2] = (byte)('0' + yellow);
                packet[3] = (byte)('0' + green);
                packet[4] = (byte)modeCmd[0];

                // Cần gửi từng byte và chờ một khoảng trễ nhỏ để PIC18 có thể chạy kịp vòng lặp
                // Delay_ms(10) bên trong C, tránh gây lỗi tràn bộ đệm phần cứng (OERR)
                for (int i = 0; i < 5; i++)
                {
                    lock (_serialLock)
                    {
                        serialPort1.Write(packet, i, 1);
                    }
                    await Task.Delay(20);
                }

                // Chờ PIC xử lý và echo 'X' về
                await Task.Delay(50);

                label_Mode.Text = $"Applied: R={red}s Y={yellow}s G={green}s [{modeCmd}]";

                if (modeCmd == "P")
                {
                    lastData = "";
                    SendDayNight();
                    timeCLock.Start();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // LUÔN reset _isSending, kể cả khi có exception
                _isSending = false;
            }
        }

        // =========================================================
        //  CONNECT
        // =========================================================
        private void button_Connect_Click(object sender, EventArgs e)
        {
            if (comboBox_SelectCOM.Text == "")
            {
                MessageBox.Show("Please select COM Port first!");
                return;
            }

            try
            {
                serialPort1.PortName = comboBox_SelectCOM.Text;
                serialPort1.BaudRate = 9600;
                serialPort1.DataBits = 8;
                serialPort1.Parity = Parity.None;
                serialPort1.StopBits = StopBits.One;
                serialPort1.Open();

                ldldata.Text = "Connected";
                ldldata.BackColor = System.Drawing.Color.Green;

                currentMode = "";
                lastData = "";
                _isSending = false;
                timeCLock.Stop();

                pictureBox_Light.Image = Properties.Resources.off_1;
                pictureBox_Number.Image = null;
                label_Mode.Text = "Connected - Vui lòng chọn MANUAL hoặc GUI";

                SetUIConnected(true);
            }
            catch
            {
                MessageBox.Show("COM connection failed.");
            }
        }

        // =========================================================
        //  DISCONNECT
        // =========================================================
        private void button_Disconnect_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen) return;
            timeCLock.Stop();
            serialPort1.Close();

            currentMode = "";
            lastData = "";
            _isSending = false;

            ldldata.Text = "Disconnected";
            ldldata.BackColor = System.Drawing.Color.LightCoral;
            label_Mode.Text = "";
            pictureBox_Light.Image = Properties.Resources.off_1;
            pictureBox_Number.Image = null;

            SetUIConnected(false);
        }

        // =========================================================
        //  TIMER DONG HO
        // =========================================================
        private void timerAuto_Tick(object sender, EventArgs e)
        {
            label_Time.Text = DateTime.Now.ToString("HH:mm:ss  dd/MM/yyyy");
        }

        // =========================================================
        //  timeCLock - gui D/N khi MODE P
        // =========================================================
        private void timeCLock_Tick(object sender, EventArgs e)
        {
            if (currentMode != "P") { timeCLock.Stop(); return; }
            if (_isSending) return;
            SendDayNight();
        }

        // =========================================================
        //  SEND DAY/NIGHT
        // =========================================================
        private bool IsNightTime()
        {
            int h = DateTime.Now.Hour;
            return (h < 5 || h >= 22);
        }

        private void SendDayNight()
        {
            if (!serialPort1.IsOpen || _isSending) return;
            string data = IsNightTime() ? "N" : "D";
            if (data != lastData)
            {
                lock (_serialLock) { serialPort1.Write(data); }
                lastData = data;

                // Khi chuyển sang ban đêm → xóa ngay LED 7 đoạn
                if (data == "N")
                    pictureBox_Number.Image = null;
            }
        }

        // =========================================================
        //  CHECKBOX GUI
        // =========================================================
        private void checkBox_GUI_CheckedChanged(object sender, EventArgs e)
        {
            if (_suppressCheckEvent) return;
            if (!checkBox_GUI.Checked) return;

            _suppressCheckEvent = true;
            checkBox_Manual.Checked = false;
            _suppressCheckEvent = false;

            groupBox_ControlMode.Enabled = true;
            groupBox1.Enabled = true;
            numRed.Enabled = true;
            numYellow.Enabled = true;
            numGreen.Enabled = true;
            btn_B.Enabled = true;
            btn_O.Enabled = true;
            btn_P.Enabled = true;

            if (serialPort1.IsOpen)
            {
                lock (_serialLock) { serialPort1.Write("G"); }
                System.Threading.Thread.Sleep(20);
                string modeToSend = string.IsNullOrEmpty(currentMode) ? "A" : currentMode;
                lock (_serialLock) { serialPort1.Write(modeToSend); }
            }

            if (currentMode == "P")
            {
                SendDayNight();
                timeCLock.Start();
                label_Mode.Text = "GUI MODE - MODE 3 (Theo thời gian)";
            }
            else if (currentMode == "B")
            {
                label_Mode.Text = "GUI MODE - MODE 1 (Đỏ liên tục)";
            }
            else if (currentMode == "O")
            {
                label_Mode.Text = "GUI MODE - MODE 2 (Vàng nhấp nháy)";
            }
            else
            {
                currentMode = "A";
                label_Mode.Text = "GUI MODE - AUTO";
            }
        }

        // =========================================================
        //  CHECKBOX MANUAL
        // =========================================================
        private void checkBox_Manual_CheckedChanged(object sender, EventArgs e)
        {
            if (_suppressCheckEvent) return;
            if (!checkBox_Manual.Checked) return;

            _suppressCheckEvent = true;
            checkBox_GUI.Checked = false;
            _suppressCheckEvent = false;

            groupBox_ControlMode.Enabled = false;
            groupBox1.Enabled = false;
            numRed.Enabled = false;
            numYellow.Enabled = false;
            numGreen.Enabled = false;
            btn_B.Enabled = false;
            btn_O.Enabled = false;
            btn_P.Enabled = false;

            _isSending = false;   // Reset phòng trường hợp bị kẹt

            if (serialPort1.IsOpen)
                lock (_serialLock) { serialPort1.Write("M"); }

            label_Mode.Text = "MANUAL MODE - Dùng nút vật lý trên breadboard";
        }

        // =========================================================
        //  MODE BUTTONS
        // =========================================================
        private void btn_B_Click(object sender, EventArgs e)
        {
            if (currentMode == "B") return;
            timeCLock.Stop();
            currentMode = "B"; lastData = "";
            pictureBox_Light.Image = Properties.Resources.r;
            pictureBox_Number.Image = null;
            if (serialPort1.IsOpen)
                lock (_serialLock) { serialPort1.Write("B"); }
            label_Mode.Text = "MODE 1 - Đỏ liên tục";
        }

        private void btn_O_Click(object sender, EventArgs e)
        {
            if (currentMode == "O") return;
            timeCLock.Stop();
            currentMode = "O"; lastData = "";
            pictureBox_Light.Image = Properties.Resources.off_1;
            pictureBox_Number.Image = null;
            if (serialPort1.IsOpen)
                lock (_serialLock) { serialPort1.Write("O"); }
            label_Mode.Text = "MODE 2 - Vàng nhấp nháy";
        }

        private void btn_P_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen) return;
            if (currentMode == "P") return;
            timeCLock.Stop();
            currentMode = "P"; lastData = "";
            lock (_serialLock) { serialPort1.Write("P"); }
            System.Threading.Thread.Sleep(30);
            SendDayNight();
            timeCLock.Start();
            label_Mode.Text = "MODE 3 - Theo thời gian";
        }

        // =========================================================
        //  APPLY TIMING
        //  FIX: Thông báo rõ khi đang bận thay vì im lặng
        // =========================================================
        private async void button1_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                MessageBox.Show("Chưa kết nối COM!");
                return;
            }
            if (!checkBox_GUI.Checked)
            {
                MessageBox.Show("Vui lòng chọn chế độ GUI trước!");
                return;
            }
            if (_isSending)
            {
                label_Mode.Text = "Đang xử lý, vui lòng chờ...";
                return;
            }

            byte r = (byte)numRed.Value;
            byte y = (byte)numYellow.Value;
            byte g = (byte)numGreen.Value;

            string modeCmd = string.IsNullOrEmpty(currentMode) ? "A" : currentMode;
            if (modeCmd != "A" && modeCmd != "B" && modeCmd != "O" && modeCmd != "P")
                modeCmd = "A";

            button1.Enabled = false;
            button2.Enabled = false;
            await SendPacketSafe(r, y, g, modeCmd);
            button1.Enabled = true;
            button2.Enabled = true;
        }

        // =========================================================
        //  RESET
        //  FIX: Bo lblStatus (khong ton tai) -> dung button truc tiep
        //       _isSending duoc reset trong SendPacketSafe.finally
        // =========================================================
        private async void button2_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen) return;
            if (_isSending)
            {
                label_Mode.Text = "Đang xử lý, vui lòng chờ...";
                return;
            }

            timeCLock.Stop();
            currentMode = "A";
            lastData = "";

            numRed.Value = 5;
            numYellow.Value = 3;
            numGreen.Value = 8;

            button1.Enabled = false;
            button2.Enabled = false;
            await SendPacketSafe(5, 3, 8, "A");
            button1.Enabled = true;
            button2.Enabled = true;

            pictureBox_Light.Image = Properties.Resources.r;
            pictureBox_Number.Image = null;
            label_Mode.Text = "RESET OK - R=5s Y=3s G=8s [AUTO]";
        }

        // =========================================================
        //  FORM CLOSING
        // =========================================================
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Confirm Exit",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
            else if (serialPort1.IsOpen) serialPort1.Close();
        }

        // =========================================================
        //  SHOW NUMBER 7-SEG
        // =========================================================
        private void ShowNumber(int n)
        {
            switch (n)
            {
                case 0: pictureBox_Number.Image = Properties.Resources.khong; break;
                case 1: pictureBox_Number.Image = Properties.Resources.mot; break;
                case 2: pictureBox_Number.Image = Properties.Resources.hai; break;
                case 3: pictureBox_Number.Image = Properties.Resources.ba; break;
                case 4: pictureBox_Number.Image = Properties.Resources.bon; break;
                case 5: pictureBox_Number.Image = Properties.Resources.nam; break;
                case 6: pictureBox_Number.Image = Properties.Resources.sau; break;
                case 7: pictureBox_Number.Image = Properties.Resources.bay; break;
                case 8: pictureBox_Number.Image = Properties.Resources.tam; break;
                case 9: pictureBox_Number.Image = Properties.Resources.chin; break;
            }
        }

        // =========================================================
        //  COMBOBOX COM
        // =========================================================
        private void comboBox_SelectCOM_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort1.PortName = comboBox_SelectCOM.Text;
            serialPort1.BaudRate = 9600;
            if (comboBox_SelectCOM.Text != "") button_Connect.Enabled = true;
        }

        private void groupBox_LED_Enter(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void label_Time_Click(object sender, EventArgs e) { }
        private void label_Mode_Click(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void numericUpDown2_ValueChanged(object sender, EventArgs e) { }
        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void numRed_ValueChanged(object sender, EventArgs e) { }
        private void pictureBox_Number_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void numGreen_ValueChanged(object sender, EventArgs e) { }
    }
}