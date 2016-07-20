namespace miniUART
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.PortText = new System.Windows.Forms.TextBox();
            this.Buadrate = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox35 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox34 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox33 = new System.Windows.Forms.TextBox();
            this.textBox32 = new System.Windows.Forms.TextBox();
            this.textBox31 = new System.Windows.Forms.TextBox();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.textBox30 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox29 = new System.Windows.Forms.TextBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.textBox28 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox27 = new System.Windows.Forms.TextBox();
            this.textBox26 = new System.Windows.Forms.TextBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.textBox25 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox0 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox36 = new System.Windows.Forms.TextBox();
            this.textBox37 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(215, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Open UART";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.ReadBufferSize = 8096;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // PortText
            // 
            this.PortText.Location = new System.Drawing.Point(72, 50);
            this.PortText.Name = "PortText";
            this.PortText.Size = new System.Drawing.Size(100, 22);
            this.PortText.TabIndex = 1;
            this.PortText.Text = "COM4";
            // 
            // Buadrate
            // 
            this.Buadrate.Location = new System.Drawing.Point(72, 78);
            this.Buadrate.Name = "Buadrate";
            this.Buadrate.Size = new System.Drawing.Size(100, 22);
            this.Buadrate.TabIndex = 2;
            this.Buadrate.Text = "9600";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(315, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Close UART";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(215, 76);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "test Button";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBox37);
            this.panel1.Controls.Add(this.textBox36);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox35);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox34);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox33);
            this.panel1.Controls.Add(this.textBox32);
            this.panel1.Controls.Add(this.textBox31);
            this.panel1.Controls.Add(this.textBox23);
            this.panel1.Controls.Add(this.textBox30);
            this.panel1.Controls.Add(this.textBox15);
            this.panel1.Controls.Add(this.textBox29);
            this.panel1.Controls.Add(this.textBox22);
            this.panel1.Controls.Add(this.textBox28);
            this.panel1.Controls.Add(this.textBox7);
            this.panel1.Controls.Add(this.textBox27);
            this.panel1.Controls.Add(this.textBox26);
            this.panel1.Controls.Add(this.textBox21);
            this.panel1.Controls.Add(this.textBox25);
            this.panel1.Controls.Add(this.textBox14);
            this.panel1.Controls.Add(this.textBox24);
            this.panel1.Controls.Add(this.textBox20);
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(this.textBox19);
            this.panel1.Controls.Add(this.textBox18);
            this.panel1.Controls.Add(this.textBox13);
            this.panel1.Controls.Add(this.textBox17);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.textBox16);
            this.panel1.Controls.Add(this.textBox12);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.textBox11);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox10);
            this.panel1.Controls.Add(this.textBox9);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox8);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.textBox0);
            this.panel1.Location = new System.Drawing.Point(146, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(948, 372);
            this.panel1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(755, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 12);
            this.label4.TabIndex = 22;
            this.label4.Text = "Hex";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(755, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 12);
            this.label3.TabIndex = 22;
            this.label3.Text = "Hex";
            // 
            // textBox35
            // 
            this.textBox35.Location = new System.Drawing.Point(824, 141);
            this.textBox35.Multiline = true;
            this.textBox35.Name = "textBox35";
            this.textBox35.Size = new System.Drawing.Size(100, 22);
            this.textBox35.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(755, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 12);
            this.label2.TabIndex = 22;
            this.label2.Text = "Hex";
            // 
            // textBox34
            // 
            this.textBox34.Location = new System.Drawing.Point(824, 103);
            this.textBox34.Multiline = true;
            this.textBox34.Name = "textBox34";
            this.textBox34.Size = new System.Drawing.Size(100, 22);
            this.textBox34.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(755, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 12);
            this.label1.TabIndex = 20;
            this.label1.Text = "Hex";
            // 
            // textBox33
            // 
            this.textBox33.Location = new System.Drawing.Point(824, 59);
            this.textBox33.Multiline = true;
            this.textBox33.Name = "textBox33";
            this.textBox33.Size = new System.Drawing.Size(100, 22);
            this.textBox33.TabIndex = 21;
            // 
            // textBox32
            // 
            this.textBox32.Location = new System.Drawing.Point(824, 18);
            this.textBox32.Multiline = true;
            this.textBox32.Name = "textBox32";
            this.textBox32.Size = new System.Drawing.Size(100, 22);
            this.textBox32.TabIndex = 19;
            // 
            // textBox31
            // 
            this.textBox31.Location = new System.Drawing.Point(10, 141);
            this.textBox31.Name = "textBox31";
            this.textBox31.Size = new System.Drawing.Size(82, 22);
            this.textBox31.TabIndex = 18;
            this.textBox31.Text = "0";
            this.textBox31.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox23
            // 
            this.textBox23.Location = new System.Drawing.Point(10, 103);
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(82, 22);
            this.textBox23.TabIndex = 18;
            this.textBox23.Text = "0";
            this.textBox23.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox30
            // 
            this.textBox30.Location = new System.Drawing.Point(98, 141);
            this.textBox30.Name = "textBox30";
            this.textBox30.Size = new System.Drawing.Size(82, 22);
            this.textBox30.TabIndex = 12;
            this.textBox30.Text = "0";
            this.textBox30.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(10, 59);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(82, 22);
            this.textBox15.TabIndex = 18;
            this.textBox15.Text = "0";
            this.textBox15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox29
            // 
            this.textBox29.Location = new System.Drawing.Point(186, 141);
            this.textBox29.Name = "textBox29";
            this.textBox29.Size = new System.Drawing.Size(82, 22);
            this.textBox29.TabIndex = 13;
            this.textBox29.Text = "0";
            this.textBox29.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox22
            // 
            this.textBox22.Location = new System.Drawing.Point(98, 103);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(82, 22);
            this.textBox22.TabIndex = 12;
            this.textBox22.Text = "0";
            this.textBox22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox28
            // 
            this.textBox28.Location = new System.Drawing.Point(274, 141);
            this.textBox28.Name = "textBox28";
            this.textBox28.Size = new System.Drawing.Size(82, 22);
            this.textBox28.TabIndex = 14;
            this.textBox28.Text = "0";
            this.textBox28.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(10, 18);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(82, 22);
            this.textBox7.TabIndex = 10;
            this.textBox7.Text = "0";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox27
            // 
            this.textBox27.Location = new System.Drawing.Point(362, 141);
            this.textBox27.Name = "textBox27";
            this.textBox27.Size = new System.Drawing.Size(82, 22);
            this.textBox27.TabIndex = 17;
            this.textBox27.Text = "0";
            this.textBox27.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox26
            // 
            this.textBox26.Location = new System.Drawing.Point(450, 141);
            this.textBox26.Name = "textBox26";
            this.textBox26.Size = new System.Drawing.Size(82, 22);
            this.textBox26.TabIndex = 16;
            this.textBox26.Text = "0";
            this.textBox26.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox21
            // 
            this.textBox21.Location = new System.Drawing.Point(186, 103);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(82, 22);
            this.textBox21.TabIndex = 13;
            this.textBox21.Text = "0";
            this.textBox21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox25
            // 
            this.textBox25.Location = new System.Drawing.Point(538, 141);
            this.textBox25.Name = "textBox25";
            this.textBox25.Size = new System.Drawing.Size(82, 22);
            this.textBox25.TabIndex = 15;
            this.textBox25.Text = "0";
            this.textBox25.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(98, 59);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(82, 22);
            this.textBox14.TabIndex = 12;
            this.textBox14.Text = "0";
            this.textBox14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox24
            // 
            this.textBox24.Location = new System.Drawing.Point(626, 141);
            this.textBox24.Name = "textBox24";
            this.textBox24.Size = new System.Drawing.Size(82, 22);
            this.textBox24.TabIndex = 11;
            this.textBox24.Text = "0";
            this.textBox24.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox20
            // 
            this.textBox20.Location = new System.Drawing.Point(274, 103);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(82, 22);
            this.textBox20.TabIndex = 14;
            this.textBox20.Text = "0";
            this.textBox20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(98, 18);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(82, 22);
            this.textBox6.TabIndex = 7;
            this.textBox6.Text = "0";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox19
            // 
            this.textBox19.Location = new System.Drawing.Point(362, 103);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(82, 22);
            this.textBox19.TabIndex = 17;
            this.textBox19.Text = "0";
            this.textBox19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(450, 103);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(82, 22);
            this.textBox18.TabIndex = 16;
            this.textBox18.Text = "0";
            this.textBox18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(186, 59);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(82, 22);
            this.textBox13.TabIndex = 13;
            this.textBox13.Text = "0";
            this.textBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(538, 103);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(82, 22);
            this.textBox17.TabIndex = 15;
            this.textBox17.Text = "0";
            this.textBox17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(186, 18);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(82, 22);
            this.textBox5.TabIndex = 7;
            this.textBox5.Text = "0";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(626, 103);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(82, 22);
            this.textBox16.TabIndex = 11;
            this.textBox16.Text = "0";
            this.textBox16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(274, 59);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(82, 22);
            this.textBox12.TabIndex = 14;
            this.textBox12.Text = "0";
            this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(274, 18);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(82, 22);
            this.textBox4.TabIndex = 7;
            this.textBox4.Text = "0";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(362, 59);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(82, 22);
            this.textBox11.TabIndex = 17;
            this.textBox11.Text = "0";
            this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(362, 18);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(82, 22);
            this.textBox3.TabIndex = 9;
            this.textBox3.Text = "0";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(450, 59);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(82, 22);
            this.textBox10.TabIndex = 16;
            this.textBox10.Text = "0";
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(538, 59);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(82, 22);
            this.textBox9.TabIndex = 15;
            this.textBox9.Text = "0";
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(450, 18);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(82, 22);
            this.textBox2.TabIndex = 8;
            this.textBox2.Text = "0";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(626, 59);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(82, 22);
            this.textBox8.TabIndex = 11;
            this.textBox8.Text = "0";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(538, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(82, 22);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox0
            // 
            this.textBox0.Location = new System.Drawing.Point(626, 18);
            this.textBox0.Name = "textBox0";
            this.textBox0.Size = new System.Drawing.Size(82, 22);
            this.textBox0.TabIndex = 6;
            this.textBox0.Text = "0";
            this.textBox0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(315, 78);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Clear";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(487, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(403, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 12);
            this.label5.TabIndex = 21;
            this.label5.Text = "Connect State : ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(487, 61);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Padding = new System.Windows.Forms.Padding(5);
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // textBox36
            // 
            this.textBox36.Location = new System.Drawing.Point(10, 237);
            this.textBox36.Multiline = true;
            this.textBox36.Name = "textBox36";
            this.textBox36.Size = new System.Drawing.Size(698, 115);
            this.textBox36.TabIndex = 23;
            // 
            // textBox37
            // 
            this.textBox37.Location = new System.Drawing.Point(824, 237);
            this.textBox37.Multiline = true;
            this.textBox37.Name = "textBox37";
            this.textBox37.Size = new System.Drawing.Size(100, 22);
            this.textBox37.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(755, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 12);
            this.label6.TabIndex = 25;
            this.label6.Text = "Counter";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 554);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Buadrate);
            this.Controls.Add(this.PortText);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox PortText;
        private System.Windows.Forms.TextBox Buadrate;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox31;
        private System.Windows.Forms.TextBox textBox23;
        private System.Windows.Forms.TextBox textBox30;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox29;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.TextBox textBox28;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox27;
        private System.Windows.Forms.TextBox textBox26;
        private System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.TextBox textBox25;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox24;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox0;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox32;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox35;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox34;
        private System.Windows.Forms.TextBox textBox33;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox36;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox37;
    }
}

