using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static float HexStringToFloat(string hexString)
        {
            uint num = uint.Parse(hexString, System.Globalization.NumberStyles.AllowHexSpecifier);

            byte[] floatVals = BitConverter.GetBytes(num);
            float f = BitConverter.ToSingle(floatVals, 0);
            return f;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttonDisconnect.Enabled = false;
            foreach (var serialPort in SerialPort.GetPortNames())
            {
                comboBox1.Items.Add(serialPort);
            }
            comboBox1.SelectedIndex = 0;
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = comboBox1.Text;
            serialPort1.BaudRate = 9600; // 19200
            serialPort1.Parity = Parity.None;
            serialPort1.StopBits = StopBits.One;
            serialPort1.DataBits = 8;

            try
            {
                serialPort1.Open();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Seri port bağlantısı yapılamadı\n Hata : {ex.Message}", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (serialPort1.IsOpen)
            {
                buttonConnect.Enabled = false;
                buttonDisconnect.Enabled = true;
            }
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                buttonConnect.Enabled = true;
                buttonDisconnect.Enabled = false;
            }
        }

        public delegate void veriGoster(String s);

        public void texteYaz(String s)
        {
            textBoxMessages.Text = s;
            string[] data = s.Split(',');
            // takim_id.Text = data[0];
            // labelCounter.Text = data[1];
            // gps_boylam.Text = data[2];
            // gps_enlem.Text = data[3];
            // irtifa.Text = data[4];
            // J_X.Text = data[5];
            // J_Y.Text = data[6];
            // J_Z.Text = data[7];

            // İvme_X.Text = data[7];
            // İvme_Y.Text = data[8];
            // İvme_Z.Text = data[9];

            // gorev_irtifa.Text = data[10];
            // gorev_boylam.Text = data[11];
            // gorev_enlem.Text = data[12];

            takim_id.Text = uint.Parse(data[4], System.Globalization.NumberStyles.HexNumber).ToString();
            labelCounter.Text = uint.Parse(data[5], System.Globalization.NumberStyles.HexNumber).ToString();
            irtifa.Text = HexStringToFloat(data[9].PadLeft(2, '0') + data[8].PadLeft(2, '0') + data[7].PadLeft(2, '0') + data[6].PadLeft(2, '0')).ToString();
            gps_irtifa.Text = HexStringToFloat(data[13].PadLeft(2, '0') + data[12].PadLeft(2, '0') + data[11].PadLeft(2, '0') + data[10].PadLeft(2, '0')).ToString();
            gps_enlem.Text = HexStringToFloat(data[17].PadLeft(2, '0') + data[16].PadLeft(2, '0') + data[15].PadLeft(2, '0') + data[14].PadLeft(2, '0')).ToString();
            gps_boylam.Text = HexStringToFloat(data[21].PadLeft(2, '0') + data[20].PadLeft(2, '0') + data[19].PadLeft(2, '0') + data[18].PadLeft(2, '0')).ToString();
            J_X.Text = HexStringToFloat(data[49].PadLeft(2, '0') + data[48].PadLeft(2, '0') + data[47].PadLeft(2, '0') + data[46].PadLeft(2, '0')).ToString();
            J_Y.Text = HexStringToFloat(data[53].PadLeft(2, '0') + data[52].PadLeft(2, '0') + data[51].PadLeft(2, '0') + data[50].PadLeft(2, '0')).ToString();
            J_Z.Text = HexStringToFloat(data[57].PadLeft(2, '0') + data[56].PadLeft(2, '0') + data[55].PadLeft(2, '0') + data[54].PadLeft(2, '0')).ToString();
            İvme_X.Text = HexStringToFloat(data[61].PadLeft(2, '0') + data[60].PadLeft(2, '0') + data[59].PadLeft(2, '0') + data[58].PadLeft(2, '0')).ToString();
            İvme_Y.Text = HexStringToFloat(data[65].PadLeft(2, '0') + data[64].PadLeft(2, '0') + data[63].PadLeft(2, '0') + data[62].PadLeft(2, '0')).ToString();
            İvme_Z.Text = HexStringToFloat(data[69].PadLeft(2, '0') + data[68].PadLeft(2, '0') + data[67].PadLeft(2, '0') + data[66].PadLeft(2, '0')).ToString();
            gorev_irtifa.Text = HexStringToFloat(data[25].PadLeft(2, '0') + data[24].PadLeft(2, '0') + data[23].PadLeft(2, '0') + data[22].PadLeft(2, '0')).ToString();
            gorev_enlem.Text = HexStringToFloat(data[29].PadLeft(2, '0') + data[28].PadLeft(2, '0') + data[27].PadLeft(2, '0') + data[26].PadLeft(2, '0')).ToString();
            gorev_boylam.Text = HexStringToFloat(data[33].PadLeft(2, '0') + data[32].PadLeft(2, '0') + data[31].PadLeft(2, '0') + data[30].PadLeft(2, '0')).ToString();
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            String gelenVeri = serialPort1.ReadLine();
            //textBoxMessages.Text += gelenVeri;
            textBoxMessages.Invoke(new veriGoster(texteYaz), gelenVeri);
        }

    }
}
