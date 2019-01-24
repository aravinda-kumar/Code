using System;  
using System.Collections.Generic;  
using System.ComponentModel;  
using System.Data;  
using System.Drawing;  
using System.Linq;  
using System.Text;  
using System.Windows.Forms;  
using System.IO.Ports;  
using System.Text.RegularExpressions;

namespace WindowsFormsApplication21
{
    public partial class Form1 : Form
    {

        private StringBuilder builder = new StringBuilder();//避免在事件处理方法中反复的创建，定义到外面。   
        private long received_count = 0;//接收计数   
        private long send_count = 0;//发送计数
        private bool Listening = false;//是否没有执行完invoke相关操作   
        private bool closing = false;//是否正在关闭串口，执行Application.DoEvents，并阻止再次invoke

        string curFileName;
        static int width;
        static int height;
        Bitmap bmp1 = null;
        byte[] d =null;//设置缓存区用来接收完整的传送数据
        public static int x = 0;//与d配套使用，用来记录每次接收缓存区里数据的个数
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //初始化下拉串口名称列表框   
            string[] ports = SerialPort.GetPortNames();
            Array.Sort(ports);
            comboBox1.Items.AddRange(ports);
            comboBox1.SelectedIndex = comboBox1.Items.Count > 0 ? 0 : -1;
            comboBox2.SelectedIndex = comboBox2.Items.IndexOf("9600");
            //初始化SerialPort对象      
            serialPort1.NewLine = "/r/n";
            serialPort1.RtsEnable = true;//设置是否启用发送请求信号
        }
        //该事件在一次传送过程中会触发多次，每次都把系统分配的缓存区里数据读至buf数组里
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            if (closing) return;//如果正在关闭，忽略操作，直接返回，尽快的完成串口监听线程的一次循环   
            try
            {
                Listening = true;//设置标记，说明我已经开始处理数据，一会儿要使用系统UI的。 
                int n = serialPort1.BytesToRead;//先记录下来，避免某种原因，人为的原因，操作几次之间时间长，缓存不一致   
                byte[] buf = new byte[n];//声明一个临时数组存储当前来的串口数据   
                received_count += n;//增加接收计数   
                serialPort1.Read(buf, 0, n);//读取缓冲数据   
                builder.Remove(0, builder.Length);//清除字符串构造器的内容   
                //因为要访问ui资源，所以需要使用invoke方式同步ui。   
                this.Invoke((EventHandler)(delegate
                {
                    for (int i = 0; i < n; i++)
                    {
                        //richTextBox2.Text = richTextBox2.Text + buf[i].ToString() + ",";
                        d[x + i] = buf[i];
                    }
                    x = x + n;
                }));
            }
            finally
            {
                Listening = false;//我用完了，ui可以关闭串口了。   
            }

        }

        private void button1_Click(object sender, EventArgs e)//打开串口
        {
            button1.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = true;

            
            serialPort1.PortName = comboBox1.Text;
            serialPort1.BaudRate = int.Parse(comboBox2.Text);
            try
            {
                serialPort1.Open();
            }
            catch (Exception ex)
            {
                //捕获到异常信息，创建一个新的comm对象，之前的不能用了。   
                serialPort1 = new SerialPort();
                //现实异常信息给客户。   
                MessageBox.Show(ex.Message);
            } 
        }

        private void button2_Click(object sender, EventArgs e)//关闭串口
        {
            button3.Enabled = false;
            button2.Enabled = false;
            button1.Enabled = true;
            
            
            if (serialPort1.IsOpen)
            {
                closing = true;
                while (Listening) Application.DoEvents();  

                //打开时点击，则关闭串口   
                serialPort1.Close();
                closing = false;
            }  

        }

        private void button3_Click(object sender, EventArgs e)//发送数据
        {
            if (bmp1 != null)
            {
                Bitmap result = new Bitmap(width, height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                result = (Bitmap)bmp1.Clone();
                Rectangle rect = new Rectangle(0, 0, result.Width, result.Height);
                System.Drawing.Imaging.BitmapData bmpData = result.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadWrite, result.PixelFormat);
                IntPtr ptr = bmpData.Scan0;
                int bytes = bmpData.Stride * bmpData.Height;
                byte[] rgbValues = new byte[bytes];
                System.Runtime.InteropServices.Marshal.Copy(ptr, rgbValues, 0, bytes);

                //for (int i = 0; i < rgbValues.Length; i++)
                //{
                //    richTextBox1.Text = richTextBox1.Text + rgbValues[i].ToString() + ",";
                //}

                serialPort1.Write(rgbValues, 0, rgbValues.Length);//这个发送是发送图片的


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {


        }

        private void button5_Click(object sender, EventArgs e)
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
                    d=new byte[3*width*height];

                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)//显示传送后图片
        {
            Bitmap result = new Bitmap(width, height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            Rectangle rect = new Rectangle(0, 0, width, height);
            System.Drawing.Imaging.BitmapData bmpData = result.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadWrite, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            IntPtr ptr = bmpData.Scan0;
            System.Runtime.InteropServices.Marshal.Copy(d, 0, ptr, 3 * width * height);
            result.UnlockBits(bmpData);
            pictureBox2.Image = result;
            x = 0;
        }
    }
}
