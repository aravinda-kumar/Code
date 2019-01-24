using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Threading;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        private StringBuilder builder = new StringBuilder();//避免在事件处理方法中反复的创建，定义到外面。   
        private long received_count = 0;//接收计数   
        private long send_count = 0;//发送计数
        private bool Listening = false;//是否没有执行完invoke相关操作   
        private bool closing = false;//是否正在关闭串口，执行Application.DoEvents，并阻止再次invoke
        private bool serialPortstate = false;
        string curFileName;
        static int width;
        static int height;
        static int recl=0;
        static int a = 0;
        Bitmap bmp1 = null;
        byte[] picFile = null;
  
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
            //初始化下拉串口名称列表框   
            string[] ports = SerialPort.GetPortNames();
            Array.Sort(ports);
            comboBox1.Items.AddRange(ports);
            comboBox1.SelectedIndex = comboBox1.Items.Count > 0 ? 0 : -1;
            comboBox2.SelectedIndex = comboBox2.Items.IndexOf("9600 14400 19200");
            //初始化SerialPort对象      
            serialPort1.NewLine = "/r/n";
            serialPort1.RtsEnable = true;//设置是否启用发送请求信号
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = true;
            serialPortstate = true;

            serialPort1.PortName = comboBox1.Text;
            serialPort1.BaudRate = int.Parse(comboBox2.Text);
            try
            {
                serialPort1.Open();
                this.Text += "(" + serialPort1.PortName + "  " + serialPort1.BaudRate.ToString() + ")";
            }


            catch (Exception ex)
            {
                //捕获到异常信息，创建一个新的comm对象，之前的不能用了。   
                serialPort1 = new SerialPort();
                //现实异常信息给客户。   
                MessageBox.Show(ex.Message);
            } 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            button2.Enabled = false;
            button1.Enabled = true;



            if (serialPort1.IsOpen)
            {
                closing = true;
                while (Listening) Application.DoEvents();

                //打开时点击，则关闭串口   
                serialPort1.Close();
                closing = false;
                this.Text = "VLC system test";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null && serialPortstate == true)
            {
                if (comboBox3.Text == "字符测试模式")
                {
                    serialPort1.Write(textBox1.Text);
                    send_count += textBox1.Text.Length;
                    label4.Text = "已发送：" + send_count;
                }
                else { MessageBox.Show("请使用图片测试模式！"); }
            }
            else { MessageBox.Show("请打开串口！"); }
        }



        private void button5_Click(object sender, EventArgs e)
        {
            if (serialPortstate == true)
            {
                if (comboBox3.Text == "图片测试模式")
                {
                    recl = picFile.Length;
                    serialPort1.Write(picFile, 0, picFile.Length);
                }
                else
                {
                    MessageBox.Show("请使用字符测试模式");
                }
                
            }
            else
            {
                MessageBox.Show("请打开串口");
            }
        }

       private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            
            if (closing) return;//如果正在关闭，忽略操作，直接返回，尽快的完成串口监听线程的一次循环   
            try
            {
                Listening = true;//设置标记，说明我已经开始处理数据，一会儿要使用系统UI的。 
               


                
                
                
                 if (comboBox3.Text == "字符测试模式")
                 {
                     int n = serialPort1.BytesToRead;//先记录下来，避免某种原因，人为的原因，操作几次之间时间长，缓存不一致   
                     received_count += n;//增加接收计数   
                     String readMsg = (serialPort1.ReadExisting()).ToString();
                     this.Invoke(new EventHandler(delegate
                 {
                     if (readMsg.Equals("\n") || readMsg.Equals("\r"))
                     {
                         readMsg = "\r\n";
                     }
                     this.textBox2.Text += readMsg;
                     this.textBox2.SelectionStart = this.textBox1.TextLength;
                     this.textBox2.ScrollToCaret();

                    
                     label5.Text = "已接收：" + received_count;
                 }));


                 }
                 
                if (a == 0&&comboBox3.Text=="图片测试模式")
                {
                    progressBar1.Maximum = 100;//设置最大长度值
                    progressBar1.Value = 0;//设置当前值
                    progressBar1.Step = 10;//设置没次增长多少
                    for (int i = 0; i < 10; i++)//循环
                    {
                        System.Threading.Thread.Sleep(1000);//暂停1秒
                        progressBar1.Value += progressBar1.Step;//让进度条增加一次

                    }

                         recl=serialPort1.BytesToRead;
                         byte[] recFile = new byte[recl];
                         a = 1;
                         for (int i = 0; i < recl; i++)
                         { recFile[i] = (byte)(serialPort1.ReadByte()); }

                         if (recFile != null)
                         {
                             System.IO.MemoryStream stream = new System.IO.MemoryStream((byte[])recFile);
                             Image pic = Image.FromStream(stream);
                             this.pictureBox2.Image = pic;

                             //serialPort1.DiscardInBuffer();
                             //serialPort1.DiscardOutBuffer();
                             a = 1;

                         }



                 } 
                     /*this.Invoke(new EventHandler(delegate
                     {
                        //
                         System.IO.MemoryStream stream = new System.IO.MemoryStream((byte[])picFile);

                         Image pic = Image.FromStream(stream); 


                         this.pictureBox2.Image = pic;
                     }));*/
                 
            }
            finally
            {
                Listening = false;
            }
            
            //
        }

        private void textBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.textBox1.Clear();
            
            send_count = 0;
            label4.Text = "已发送："+send_count;
        }

        private void textBox2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.textBox2.Clear();
            
            received_count = 0;
            label5.Text = "已接收："+received_count;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnDlg = new OpenFileDialog();
            opnDlg.Filter = "所有图像文件 | *.bmp; *.pcx; *.png; *.jpg; *.gif;" +
                "*.tif; *.ico; *.dxf; *.cgm; *.cdr; *.wmf; *.eps; *.emf|" +
                "位图( *.bmp; *.jpg; *.png;...) | *.bmp; *.pcx; *.png; *.jpg; *.gif; *.tif; *.ico|" +
                "矢量图( *.wmf; *.eps; *.emf;...) | *.dxf; *.cgm; *.cdr; *.wmf; *.eps; *.emf";
            opnDlg.Title = "打开图像文件";
            opnDlg.ShowHelp = true;
            if (opnDlg.ShowDialog() == DialogResult.OK)
            {
                curFileName = opnDlg.FileName;
                try
                {
                    bmp1 = new Bitmap(curFileName);
                    pictureBox1.Image = bmp1;

                    width = bmp1.Width;
                    height = bmp1.Height;
                    FileStream fileStream = new FileStream(curFileName, FileMode.Open, FileAccess.Read, FileShare.Read);
                    picFile = new byte[fileStream.Length];
                    fileStream.Read(picFile, 0, picFile.Length);
                    
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }
            }

        }

        private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            bmp1 = null;
            pictureBox1.Image = bmp1;
        }


        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (serialPortstate == true)
            {
                a = 0;
                serialPort1.DiscardInBuffer();
                serialPort1.DiscardOutBuffer();
                progressBar1.Value = 0;
                MessageBox.Show("清除缓存成功，可重新传送图片！");
            }
            else { MessageBox.Show("串口还未打开"); }
        }

        private void pictureBox2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            bmp1 = null;
            pictureBox2.Image = bmp1;
        }







    }
}
