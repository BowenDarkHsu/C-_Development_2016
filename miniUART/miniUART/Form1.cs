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
        string[] ByteTable = { "0000", "0001", "0010", "0011", "0100", "0101", "0110", "0111", "1000", "1001", "1010", "1011", "1100", "1101", "1110", "1111" };
        char[] HexTable = {'0','1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
        private const int UartOnceQuantity = 6;
        private int UartCounter = 0;
        private bool StartFlag = false;
        private bool EndFlag = false;
        private int PackageCounter = 0;
        public Form1()
        {
            InitializeComponent();         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mySerial = new SerialPort(PortText.Text);
            mySerial.BaudRate = Int32.Parse(Buadrate.Text);
            //mySerial.BaudRate = 9600;
            mySerial.StopBits = StopBits.One;
            mySerial.DataBits = 8;
            mySerial.Handshake = Handshake.None;
            mySerial.RtsEnable = true;
            mySerial.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);

            mySerial.Open();
            Console.WriteLine("Press any key to continue...");
            Console.WriteLine();

            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            mySerial.Close();
            pictureBox2.Visible = false;
            pictureBox1.Visible = true;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            byte data_one = 0x96;            
            mySerial.Write(data_one.ToString());            
        }
        // 96 Data0 Data1 Data2 Data3 55
        // 96 Data0 Data1 Data2 Data3 D5
        // 96 Data0 Data1 Data2 Data3 95

        //  7   6   5   4   3   2   1   0   
        //  15  14  13  12  11  10  9   8
        //  23  22  21  20  19  18  17  16
        //  31  30  29  28  27  26  25  24   
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            int IntBuffer = sp.ReadByte();
            int Byte_High = IntBuffer / 16;
            int Byte_Low = IntBuffer % 16;



            
            if (0 == (UartCounter))
            {
                if (9 == Byte_High)
                {
                    if (6 == Byte_Low)
                    {
                        StartFlag = true;
                        UartCounter = UartCounter + 1;                       
                    }
                }

            }
            else if (5 == (UartCounter))
            {
                if ((5 == Byte_High) || (13 == Byte_High) || (9 == Byte_High))
                {
                    if (5 == Byte_Low)
                    {
                        EndFlag = true;
                        UartCounter = UartCounter + 1;
                        if (((UartCounter) == UartOnceQuantity) && EndFlag)
                        {
                            UartCounter = 0;
                            StartFlag = false;
                            EndFlag = false;
                        }                        
                    }
                }
            }
            else
            {
                if ((StartFlag) && (!EndFlag))
                {
                    switch (UartCounter)
                    {
                        case 1:
                            this.Invoke((MethodInvoker)delegate
                            {
                                textBox0.Text = ByteTable[Byte_Low].ElementAt(3).ToString();
                                textBox1.Text = ByteTable[Byte_Low].ElementAt(2).ToString();
                                textBox2.Text = ByteTable[Byte_Low].ElementAt(1).ToString();
                                textBox3.Text = ByteTable[Byte_Low].ElementAt(0).ToString();
                                textBox4.Text = ByteTable[Byte_High].ElementAt(3).ToString();
                                textBox5.Text = ByteTable[Byte_High].ElementAt(2).ToString();
                                textBox6.Text = ByteTable[Byte_High].ElementAt(1).ToString();
                                textBox7.Text = ByteTable[Byte_High].ElementAt(0).ToString();

                                textBox32.Text = HexTable[Byte_High].ToString() + HexTable[Byte_Low].ToString();
                            });

                            break;
                        case 2:
                            this.Invoke((MethodInvoker)delegate
                            {
                                textBox8.Text = ByteTable[Byte_Low].ElementAt(3).ToString();
                                textBox9.Text = ByteTable[Byte_Low].ElementAt(2).ToString();
                                textBox10.Text = ByteTable[Byte_Low].ElementAt(1).ToString();
                                textBox11.Text = ByteTable[Byte_Low].ElementAt(0).ToString();
                                textBox12.Text = ByteTable[Byte_High].ElementAt(3).ToString();
                                textBox13.Text = ByteTable[Byte_High].ElementAt(2).ToString();
                                textBox14.Text = ByteTable[Byte_High].ElementAt(1).ToString();
                                textBox15.Text = ByteTable[Byte_High].ElementAt(0).ToString();

                                textBox33.Text = HexTable[Byte_High].ToString() + HexTable[Byte_Low].ToString();
                            });
                            break;
                        case 3:
                            this.Invoke((MethodInvoker)delegate
                            {
                                textBox16.Text = ByteTable[Byte_Low].ElementAt(3).ToString();
                                textBox17.Text = ByteTable[Byte_Low].ElementAt(2).ToString();
                                textBox18.Text = ByteTable[Byte_Low].ElementAt(1).ToString();
                                textBox19.Text = ByteTable[Byte_Low].ElementAt(0).ToString();
                                textBox20.Text = ByteTable[Byte_High].ElementAt(3).ToString();
                                textBox21.Text = ByteTable[Byte_High].ElementAt(2).ToString();
                                textBox22.Text = ByteTable[Byte_High].ElementAt(1).ToString();
                                textBox23.Text = ByteTable[Byte_High].ElementAt(0).ToString();

                                textBox34.Text = HexTable[Byte_High].ToString() + HexTable[Byte_Low].ToString();
                            });
                            break;
                        case 4:
                            this.Invoke((MethodInvoker)delegate
                            {
                                textBox24.Text = ByteTable[Byte_Low].ElementAt(3).ToString();
                                textBox25.Text = ByteTable[Byte_Low].ElementAt(2).ToString();
                                textBox26.Text = ByteTable[Byte_Low].ElementAt(1).ToString();
                                textBox27.Text = ByteTable[Byte_Low].ElementAt(0).ToString();
                                textBox28.Text = ByteTable[Byte_High].ElementAt(3).ToString();
                                textBox29.Text = ByteTable[Byte_High].ElementAt(2).ToString();
                                textBox30.Text = ByteTable[Byte_High].ElementAt(1).ToString();
                                textBox31.Text = ByteTable[Byte_High].ElementAt(0).ToString();

                                textBox35.Text = HexTable[Byte_High].ToString() + HexTable[Byte_Low].ToString();
                            });
                            break;
                        default:
                            break;
                    }
                    UartCounter = UartCounter + 1;
                    
                }
                //// Display Info   
                //Console.WriteLine(" Data Received: ");
                //Console.WriteLine(Byte_High);
                //Console.WriteLine(Byte_Low);
                //Console.WriteLine(ByteTable[Byte_High]);
                //Console.WriteLine(ByteTable[Byte_Low]);
                //// 96 --> 9 <==>   1    0    0    1
                ////                (0)  (1)  (2)  (3)
                //Console.WriteLine(ByteTable[Byte_High].ElementAt(0));
                //Console.WriteLine(ByteTable[Byte_High].ElementAt(1));
                //Console.WriteLine(ByteTable[Byte_High].ElementAt(2));
                //Console.WriteLine(ByteTable[Byte_High].ElementAt(3));
                //// 96 --> 6 <==> 0110
                //Console.WriteLine(ByteTable[Byte_Low].ElementAt(0));
                //Console.WriteLine(ByteTable[Byte_Low].ElementAt(1));
                //Console.WriteLine(ByteTable[Byte_Low].ElementAt(2));
                //Console.WriteLine(ByteTable[Byte_Low].ElementAt(3));
            }
            PackageCounter = PackageCounter + 1;
            this.Invoke((MethodInvoker)delegate
            {
                textBox36.Text = textBox36.Text + " " + HexTable[Byte_High].ToString() + HexTable[Byte_Low].ToString();
                textBox37.Text = PackageCounter.ToString();
            });
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PackageCounter = 0;
            textBox37.Text = "";
            textBox36.Text = "";
            textBox0.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";

            textBox16.Text = "";
            textBox17.Text = "";
            textBox18.Text = "";
            textBox19.Text = "";
            textBox20.Text = "";
            textBox21.Text = "";
            textBox22.Text = "";
            textBox23.Text = "";

            textBox24.Text = "";
            textBox25.Text = "";
            textBox26.Text = "";
            textBox27.Text = "";
            textBox28.Text = "";
            textBox29.Text = "";
            textBox30.Text = "";
            textBox31.Text = "";

            textBox32.Text = "";
            textBox33.Text = "";
            textBox34.Text = "";
            textBox35.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
