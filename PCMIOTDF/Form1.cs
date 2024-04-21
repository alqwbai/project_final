using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using PCMIOTDF.Devices;
namespace PCMIOTDF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        public void ScanPort()
        {
                PortSelectionCB.Text = "";
                PortSelectionCB.Items.Clear();
                String[] ports = SerialPort.GetPortNames();
                PortSelectionCB.Items.AddRange(ports);
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           //ScanPort();
        }
        
        /*-------------------------------Scan Port ------------------------*/
        private void ScanPortBT_Click(object sender, EventArgs e)
        {
            ScanPort();
        }
        public bool ConnectPort()
        {
            try
            {
                if (PortSelectionCB.Text != "" || BoardTypeCB.Text != "")
                {

                    serialPort1.PortName = PortSelectionCB.Text;
                    serialPort1.BaudRate = 115200;
                    serialPort1.Open();


                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK);
            }
            return false;
        }


        private void ConnectBT_Click(object sender, EventArgs e)
        {
            //ArduinoInfo ar = new ArduinoInfo();
            //ar.ConnectPortt(PortSelectionCB.Text);
            if (ConnectPort() == true)
            {
                ScanPortBT.Enabled = false;
                PortSelectionCB.Enabled = false;
                BoardTypeCB.Enabled = false;
                groupBox2.Enabled = true;
            }
           // this.Height = 650;+
        }

        /*-------------------------------End Scan Port ------------------------*/


        /*-------------------------------Connected To Wifi ------------------------*/
        string WifiTextBox;
        string PasswordTextBox;
        string ConfirmWifiTextBox;
        string ConfirmPasswordTextBox;
        public bool CheackFieldWifi(string wifi, string password, string ConfirmWifi, string ConfirmPassword)
        {
            // Check if username and password are not empty
            if (string.IsNullOrEmpty(wifi))
            {
                MessageBox.Show("Please enter Wifi and password", "Error!", MessageBoxButtons.OK);
                return false;
            }

            // Check if passwords match
            if (password != ConfirmPassword)
            {
                MessageBox.Show("Passwords do not match", "Error!", MessageBoxButtons.OK);
                return false;
            }
            if (wifi != ConfirmWifi)
            {
                MessageBox.Show("Wifi do not match", "Error!", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }

        private void CheackBT_Click(object sender, EventArgs e)
        {
            //checks And Enter The Wifi And PassWord
            WifiTextBox = NameWifiTBt.Text.Trim();
            PasswordTextBox = PasswordTB.Text.Trim();
            ConfirmWifiTextBox = ConfirmNameWifiTB.Text.Trim();
            ConfirmPasswordTextBox = ConfirmPasswordTB.Text.Trim();


            bool isValid = CheackFieldWifi(WifiTextBox, PasswordTextBox, ConfirmWifiTextBox, ConfirmPasswordTextBox);

            if (isValid)
            {
                // Login successful
                sendBT.Enabled = true;
                MessageBox.Show("Logged in successfully!");
            }
            else
            {
                // Login failed
                MessageBox.Show("Invalid credentials");
            }
        }

        private void SendBT_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(serialPort1.IsOpen)) { serialPort1.Open(); }
                // serialPort1.Write(outgoingTB.Text);
                
                serialPort1.WriteLine("##SSID" + WifiTextBox + "##" + "##PASS" + PasswordTextBox + "##\n");

                WifiTextBox = "";
                PasswordTextBox = "";
             }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK);
            }
        }
      

        private void Button1_Click(object sender, EventArgs e)
        {
            IncomingTB.Text = "";
           // ArduinoInfoPorts();
          // IncomingTB.Text = (digitalPinCountInt + "==" + analogPinCountInt).ToString();
        }

        private void SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            this.Invoke(new EventHandler(SerialPort1_DataReceived));
        }
      
        private void SerialPort1_DataReceived(object sender, EventArgs e)
        {
            string dump = serialPort1.ReadLine();
            dataPinsArduino += dump;
            IncomingTB.Text = IncomingTB.Text + dump;
        }
        int analogPinCountInt;
        int digitalPinCountInt;
        string dataPinsArduino;
        void ArduinoInfoPorts()
        {
            try
            {

                if (dataPinsArduino != null)
                {
                    string[] parts = dataPinsArduino.Split('*'); // تقسيم البيانات باستخدام "#" كفاصل
                   
                    // استخراج قيمة عدد دبابيس القياس التناظري
                    if (parts.Length > 0)
                    {
                        string analogPinCountStr = parts[0].Split('=')[1];
                        analogPinCountInt = int.Parse(analogPinCountStr);
                       // IncomingTB.Text = digitalPinCountInt + "==" + analogPinCountInt).ToString();
                        //IncomingTB.Text = analogPinCountInt.ToString();
                    }

                    // استخراج قيمة عدد دبابيس الإدخال/الإخراج الرقمية
                    if (parts.Length > 1 && parts[1].StartsWith("DigitalPinCount="))
                    {
                        string digitalPinCountStr = parts[1].Split('=')[1];
                        digitalPinCountInt = int.Parse(digitalPinCountStr);
                       // IncomingTB.Text = IncomingTB.Text + digitalPinCountInt.ToString();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK);

            }
        }
        void SendDataToPlatform()
        {
            List<ArduinoAPI> Namess = new List<ArduinoAPI>();
            ArduinoAPI arduinoAPI = new ArduinoAPI();
            arduinoAPI.AnalogPinCount = 5;
            arduinoAPI.ArduinoType = "Naji";
            Namess.Add(arduinoAPI);
           // string result = Namess.Find(c => c.Contains("k")).FirstOrDefault();
        }
        /*-------------------------------End Connected To Wifi ------------------------*/
    }
}
