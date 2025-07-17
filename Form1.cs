using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace SerialReaderApp
{
    public partial class Form1 : Form
    {
        private SerialPort serialPort;

        public Form1()
        {
            InitializeComponent();
            InitializeSerialPort();
        }

        private void InitializeSerialPort()
        {
            serialPort = new SerialPort
            {
                BaudRate = 9600,
                Parity = Parity.None,
                StopBits = StopBits.One,
                DataBits = 8,
                Handshake = Handshake.None,
                ReadTimeout = 500,
                WriteTimeout = 500
            };

            serialPort.DataReceived += SerialPort_DataReceived;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxPorts.Items.AddRange(SerialPort.GetPortNames());
            if (comboBoxPorts.Items.Count > 0)
                comboBoxPorts.SelectedIndex = 0;

            buttonDisconnect.Enabled = false;
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (comboBoxPorts.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir seri port seçin.");
                return;
            }

            try
            {
                serialPort.PortName = comboBoxPorts.SelectedItem.ToString();
                serialPort.Open();

                buttonConnect.Enabled = false;
                buttonDisconnect.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Seri port açılamadı: {ex.Message}");
            }
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort.IsOpen)
                {
                    serialPort.DataReceived -= SerialPort_DataReceived;
                    serialPort.Close();

                    buttonConnect.Enabled = true;
                    buttonDisconnect.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Seri port kapatılamadı: {ex.Message}");
            }
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string line = serialPort.ReadLine();
                BeginInvoke(new Action(() =>
                {
                    listBoxData.Items.Insert(0, line.Trim());
                }));
            }
            catch (TimeoutException)
            {
                // ignore
            }
            catch (IOException ioex)
            {
                BeginInvoke(new Action(() =>
                {
                    MessageBox.Show($"G/Ç Hatası: {ioex.Message}");
                }));
            }
            catch (Exception ex)
            {
                BeginInvoke(new Action(() =>
                {
                    MessageBox.Show($"Bilinmeyen hata: {ex.Message}");
                }));
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.DataReceived -= SerialPort_DataReceived;
                serialPort.Close();
            }
            base.OnFormClosing(e);
        }
    }
}
