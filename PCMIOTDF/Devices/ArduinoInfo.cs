using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using PCMIOTDF;
using System.Windows.Forms;

namespace PCMIOTDF.Devices
{
   /* public class ArduinoInfo
    {
        private SerialPort serialPort1 = new SerialPort();
        String[] ports;
        Dictionary<string, object> ArduinoBoardType = new Dictionary<string, object>();

        public bool ConnectPort(string portName, string BoardType)
        {
            try
            {
                if (ports.Length > 0 || ArduinoBoardType.Count > 0)
                {
                    serialPort1.PortName = portName;
                    
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

        public bool ConnectPortt(string portName)
        {
            try
            {
                ports = SerialPort.GetPortNames();
                serialPort1.PortName = portName;

                serialPort1.Open();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK);
            }
            return false;
        }
        /* 
         * 
         
         public void ScanPort()
          {
              String[] ports = SerialPort.GetPortNames();
              //PortSelectionCB.Items.AddRange(ports);
          }

          public bool ConnectPortt(string portName, string BoardTypeCB)
          {
              try
              {
                  serialPort1.PortName = portName;

                  serialPort1.Open();
                  return true;
              }
              catch (Exception ex)
              {
                  MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK);
              }
              return false;
          }
          public List<PortConnectionInfo> ConnectPort<T>(string portName, string BoardTypeCB)
          {
              serialPort1.PortName = portName;
              serialPort1.Open();
              string BoardType = BoardTypeCB;

              // إنشاء قائمة من نوع PortConnectionInfo
              List<PortConnectionInfo> connectionInfo = new List<PortConnectionInfo>();
              connectionInfo.Add(new PortConnectionInfo
              {
                  PortName = portName,
                  BoardType = BoardType,
                  IsConnected = serialPort1.IsOpen
              });

              // ترجيع القائمة
              return connectionInfo;
          }
          public class PortConnectionInfo
          {
              public string PortName { get; set; }
              public string BoardType { get; set; }
              public bool IsConnected { get; set; }
          }
          *

    }*/
    public class ArduinoAPI
    {
        public string ArduinoType { get; set; }
        public int AnalogPinCount { get; set; }
        public int DgitalPinCount { get; set; }
        public string WifiName { get; set; }
        public string PasswordWifi { get; set; }
        public string APIkeyArduino { get; set; }
        public bool IsConnected { get; set; }
    }
   public class postData
    {
        public string name { get; set; }
        public string address { get; set; }
        public int age { get; set; }
    }
    public class PostResponsID
    {
     
        public int id { get; set; }
    }
}
