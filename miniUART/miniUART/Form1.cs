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


namespace miniUART
{

    public partial class Form1 : Form
    {
        SerialPort mySerial; 
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mySerial = new SerialPort(textBox1.Text);
            //mySerial.BaudRate = Int32.Parse(textBox2.Text);
            mySerial.BaudRate = 9600;
            mySerial.StopBits = StopBits.One;
            mySerial.DataBits = 8;
            mySerial.Handshake = Handshake.None;
            mySerial.RtsEnable = true;
            mySerial.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);

            mySerial.Open();
            Console.WriteLine("Press any key to continue...");
            Console.WriteLine();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            mySerial.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            mySerial.Write("123");
        }
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();
            Console.WriteLine("Data Received:");
            Console.WriteLine(indata);
            
        }


    }
}
