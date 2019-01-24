
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;//串口
using System.IO;//数据流和文件
using System.Threading;//线程
using System.Text.RegularExpressions;


namespace USBCamera
{
    public partial class USBCamera : Form
    { 
        /// <summary>
        /// 串口部分的变量定义
        /// </summary>
        private SerialPort comm = new SerialPort();
        private   StringBuilder builder = new StringBuilder();//避免在事件处理方法中反复的创建，定义到外面。     
        private long received_count = 0;//接收计数     
        private long send_count = 0;//发送计数 
        byte []  receive=new  byte[153600];
        public Bitmap myBitmap;
        //public bool pick;//jia
        private Point m_ptStart = new Point(0, 0);
        private Point m_ptEnd = new Point(0, 0);
        // true: MouseUp or false: MouseMove
        private bool m_bMouseDown = false;
        int m;//起始点横坐标
        int n;//起始点纵坐标
        int j;//终止点横坐标
        int k;//终止点纵坐标
       

        
         public USBCamera()
        {
            InitializeComponent();
           // this.pictureBox1.MouseClick += new MouseEventHandler(pictureBox1_MouseClick);
            this.pictureBox1.MouseDown += new MouseEventHandler(pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new MouseEventHandler(pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new MouseEventHandler(pictureBox1_MouseUp);    
           
            }

        
         void Form1_Load(object sender, EventArgs e)
        {

            //pick = false  ;
            string[] ports = SerialPort.GetPortNames();
            Array.Sort(ports);
            toolStripComBoxPortName.Items.AddRange(ports);
            toolStripComBoxPortName.SelectedIndex = toolStripComBoxPortName.Items.Count > 0 ? 0 : -1;
            toolStripComBoxBaudrate.Items.Add("4800");
            toolStripComBoxBaudrate.Items.Add("9600");
            toolStripComBoxBaudrate.Items.Add("19200");
            toolStripComBoxBaudrate.Items.Add("38400");
            toolStripComBoxBaudrate.Items.Add("57600");
            toolStripComBoxBaudrate.Items.Add("115200");
            //textBox3.Text = "100";
            toolStripComBoxBaudrate.SelectedIndex = toolStripComBoxBaudrate.Items.IndexOf("115200");//初始化SerialPort对象 
            textBox2.Text = "a";
            

            //初始化SerialPort对象     
            comm.NewLine = "/r/n";
            //添加事件注册     
            comm.DataReceived += comm_DataReceived;
            //以上为串口部分
           
           
        }
       
        /***********************打开串口*******************/
        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                //根据当前串口对象，来判断操作     
                if (comm.IsOpen)
                {
                    //打开时点击，则关闭串口     
                    comm.Close();
                }
                else
                {
                    //关闭时点击，则设置好端口，波特率后打开     
                    comm.PortName = toolStripComBoxPortName.Text;
                    comm.BaudRate = int.Parse(toolStripComBoxBaudrate.Text);
                    try
                    {
                        comm.Open();
                    }
                    catch (Exception ex)
                    {
                        //捕获到异常信息，创建一个新的comm对象，之前的不能用了。     
                        comm = new SerialPort();
                        //现实异常信息给客户。     
                        MessageBox.Show(ex.Message);
                    }
                }
                //设置按钮的状态     
                button7.Text = comm.IsOpen ? "关闭串口" : "打开串口";
                button4.Enabled = comm.IsOpen;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /********************自动换行*************************/
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.WordWrap = checkBox2.Checked;
        }
        /***********************清空发送计数************************/
        private void button6_Click(object sender, EventArgs e)
        {
            label4.Text = "0";
        }
        /*************************清空发送区*********************/
        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }
        /*******************发送数据****************************/
        private void button4_Click(object sender, EventArgs e)
        {
           
            
                try
                {
                    //定义一个变量，记录发送了几个字节     
                    int n = 0;
                    //16进制发送     
                    if (checkBox3.Checked)
                    {
                        //我们不管规则了。如果写错了一些，我们允许的，只用正则得到有效的十六进制数     
                        MatchCollection mc = Regex.Matches(textBox2.Text, @"(?i)[/da-f]{2}");
                        List<byte> buf = new List<byte>();//填充到这个临时列表中     
                        //依次添加到列表中     
                        foreach (Match m in mc)
                        {
                            buf.Add(byte.Parse(m.Value, System.Globalization.NumberStyles.HexNumber));
                        }
                        //转换列表为数组后发送     
                        comm.Write(buf.ToArray(), 0, buf.Count);
                        //记录发送的字节数     
                        n = buf.Count;
                    }
                    else//ascii编码直接发送     
                    {
                        comm.Write(textBox2.Text);
                        n = textBox2.Text.Length;
                    }
                    send_count += n;//累加发送字节数     
                    label4.Text = send_count.ToString();//更新界面   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
               
            

        }
        
        /*********************清空接收计数**********************/
        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text = "0";
        }
        /*******************清空接收区*****************************/
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
        /*******************************接收数据函数*********************/
        void comm_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {



            if (received_count == 153600)//此处为新加，目的是可以连续采集数据，可以连续显示图片
            {
                byte[] receiv1 = new byte[153600];
                receive = receiv1;
                received_count = 0;
            }
               
            
               int n = comm.BytesToRead;//先记录下来，避免某种原因，人为的原因，操作几次之间时间长，缓存不一致     
                byte[] buf = new byte[n];//声明一个临时数组存储当前来的串口数据  
                comm.Read(buf, 0, n);//读取缓冲数据 
                for (int j = 0; j < n; j++)
                {
                    receive[received_count + j] = buf[j];
                }
                received_count += n;//增加接收计数     
                    
                builder.Length = 0;//清除字符串构造器的内容     
                //因为要访问ui资源，所以需要使用invoke方式同步ui。 
               

               
                //label5.Text = m.ToString();


                    this.Invoke((EventHandler)(delegate
                    {
                        //判断是否是显示为16进制     
                        if (checkBox1.Checked)
                        {
                            //依次的拼接出16进制字符串     
                            foreach (byte b in buf)
                            {
                                builder.Append(b.ToString("X2") + " ");
                            }
                        }
                        else
                        {
                            //直接按ASCII规则转换成字符串     
                            builder.Append(Encoding.ASCII.GetString(buf));
                        }
                        //追加的形式添加到文本框末端，并滚动到最后。     
                        this.textBox1.AppendText(builder.ToString());
                        //修改接收计数     
                        label2.Text = received_count.ToString();
                    }));
               
                
                
           
          
        }
        /************************保存数据*********************/
        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog s_fileDialog = new SaveFileDialog();
            s_fileDialog.Filter = "TXT Files(*.txt)|*.txt|All Files(*.*)|*.*";
            if (s_fileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamWriter sw = new StreamWriter(s_fileDialog.FileName, true);
                    sw.WriteLine(textBox1.Text);
                    sw.Close();
                    textBox1.Text = string.Empty;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            /************以下加入的是图像显示*****************
            string hex = textBox1.Text;
            int len = (hex.Length / 2);
            byte[] result = new byte[len];
            char[] achar = hex.ToCharArray();
            for (int i = 0; i < len; i++)
            {
                int pos = i * 2;
                result[i] =(byte )( Convert.ToByte(achar[pos]) << 4 | Convert.ToByte (achar[pos + 1]));
            }
            pictureBox1.Width = 320;
            pictureBox1.Height = 240;
            Bitmap CurBitmap = (Bitmap)pictureBox1.Image;//获得当前图像，并作为位图处理

            USBCameraDLL.CameraDrawpicture.Draw_picture(320, 240, result , CurBitmap, pictureBox1);*/
 
        }
       

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (comm.IsOpen)
            {
                try
                {
                    //定义一个变量，记录发送了几个字节     
                    int n = 0;
                    //16进制发送     
                    if (checkBox3.Checked)
                    {
                        //我们不管规则了。如果写错了一些，我们允许的，只用正则得到有效的十六进制数     
                        MatchCollection mc = Regex.Matches(textBox2.Text, @"(?i)[/da-f]{2}");
                        List<byte> buf = new List<byte>();//填充到这个临时列表中     
                        //依次添加到列表中     
                        foreach (Match m in mc)
                        {
                            buf.Add(byte.Parse(m.Value, System.Globalization.NumberStyles.HexNumber));
                        }
                        //转换列表为数组后发送     
                        comm.Write(buf.ToArray(), 0, buf.Count);
                        //记录发送的字节数     
                        n = buf.Count;
                    }
                    else//ascii编码直接发送     
                    {
                        comm.Write(textBox2.Text);
                        n = textBox2.Text.Length;
                    }
                    send_count += n;//累加发送字节数     
                    label4.Text = send_count.ToString();//更新界面   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    /**************显示图片*********************///使用文件处理暂时显示图像是正确的，暂时得到的数据不对
        private void button8_Click(object sender, EventArgs e)
        {
            /*StreamReader sr = File.OpenText(path);
            string m = sr.ReadToEnd();
            byte[] b2 = new byte[153600];
            b2 = System.Text.Encoding.Unicode.GetBytes(m);*/
           
            pictureBox1.Width = 320;
            pictureBox1.Height = 240;
            Bitmap CurBitmap = (Bitmap)pictureBox1.Image;//获得当前图像，并作为位图处理

            USBCameraDLL.CameraDrawpicture.Draw_picture(320, 240, receive , CurBitmap, pictureBox1);
            string path = @"E:\2.text";
            if (File.Exists(path))
                File.Delete(path);
            StreamWriter sw = File.CreateText(path);
            string ss = System.Text.Encoding.Unicode.GetString(receive);
            sw.WriteLine(ss);
            sw.Close();
           
        }
       
       /* private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(string.Format("象素坐标({0},{1})", e.X, e.Y));
        }*/
        
        /*******************鼠标在picturebox中移动事件*********************/
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }

            m_ptEnd = new Point(e.X, e.Y);
            this.pictureBox1.Refresh();
        }
        /****************************鼠标按下事件**************************/
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }
            if (!m_bMouseDown)
            {
                m_ptStart = new Point(e.X, e.Y);
                m_ptEnd = new Point(e.X, e.Y);
            }
            m_bMouseDown = !m_bMouseDown;
            textBox3.Text = string.Format("象素坐标({0},{1})", e.X, e.Y);
            m = e.X;
            n = e.Y;
        }
        /********************鼠标弹起事件******************************/
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }
            if (m_ptStart.X >= 0 && m_ptEnd.X >= 0
                 && m_ptStart.Y >= 0 && m_ptEnd.Y >= 0
                 && m_ptStart.X <= 320 && m_ptEnd.X <= 320
                 && m_ptStart.Y <= 240 && m_ptEnd.Y <= 240)
            {
                m_ptEnd = new Point(e.X, e.Y);
                m_bMouseDown = !m_bMouseDown;
                this.pictureBox1.Refresh();
            }
            else
            {
                m_ptEnd = m_ptStart;
                m_bMouseDown = !m_bMouseDown;
                this.pictureBox1.Refresh();
            }
            textBox4.Text = string.Format("象素坐标({0},{1})", e.X, e.Y);
            j = e.X;
            k = e.Y;
        }
        /*********************picturebox画图事件************************/
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
        
            if (m_ptStart.Equals(m_ptEnd)) return;
          //  e.Graphics.DrawLine(System.Drawing.Pens.Red, m_ptStart, m_ptEnd);此行为画两点之间的斜线
           
           
           if (m_ptEnd.X - m_ptStart.X < 0 || m_ptEnd.Y - m_ptStart.Y < 0)
           {
               return;
          }
           e.Graphics.DrawRectangle(System.Drawing.Pens.Blue, m_ptStart.X, m_ptStart.Y, m_ptEnd.X - m_ptStart.X, m_ptEnd.Y - m_ptStart.Y);
        }
        /**************************计算均值*****************************/
        private void button9_Click(object sender, EventArgs e)
        {
            byte[] a = new byte[2];
            a[0] = receive[n * 640 + m * 2 + 1];
            a[1] = receive[n * 640 + m * 2 + 1];
            int r1 = (a[0] & 0xf8)>>3;
            int b1 = a[1] & 0x1f;
            int p = (a[0] & 0x07) << 3;
            int q = (a[1] & 0xe0) >> 5;
            int g1 = p + q;
            int t = 0;
            byte [] kuang=new byte [(j-m+1)*2*(k -n +1)];
            for (int v = n; v <= k; v++)//列
            {
                for (int s = n * 640 + m * 2 + 1; s <= n * 640 + j * 2 + 2;s++ )//将receive[s]添加到kuang中
                {
                    kuang[t] = receive[s];//kuang[]为新数组
                    t++;
                }//hang
            }
            for (int u = 0; u <t; u = u + 2)
            {
                int r = (kuang[u] & 0xf8)>>3;
                r1 = (r1 + r) / 2;
                int b = kuang[u + 1] & 0x1f;
                b1 = (b1 + b) / 2;
                int p1 = (kuang[u] & 0x07) << 3;
                int q1 = (kuang[u+1] & 0xe0) >> 5;
                int g = p1 + q1;
                g1 = (g1 + g) / 2;
               
            }
            textBox7.Text = string.Format("rgb值为({0},{1}，{2})", r1, g1, b1);
            
        }

        
  
    }
}
