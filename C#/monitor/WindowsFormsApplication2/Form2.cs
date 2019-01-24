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
using System.Runtime.InteropServices;
using System.IO;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.Media;

namespace WindowsFormsApplication2
{
    public partial class Form2 : Form
    {
        int index1 = 0;
        string[] pathlist1 ={
        @"F:\showpicture\11.jpg",
        @"F:\showpicture\12.jpg",
        @"F:\showpicture\13.jpg"
        };//图片路径列表

        int index2 = 0;
        string[] pathlist2 ={
        @"F:\showpicture\21.jpg",
        @"F:\showpicture\22.jpg",
        @"F:\showpicture\23.jpg"
        };//图片路径列表

        int index3 = 0;
        string[] pathlist3 ={
        @"F:\showpicture\31.jpg",
        @"F:\showpicture\32.jpg",
        @"F:\showpicture\33.jpg"
        };//图片路径列表

        //窗口构造函数，允许线程操作控件
        public Form2()
        {
            InitializeComponent();
            //关闭对所有控件的非法线程操作检查
            //使得子线程可以操作控件
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
            //this.BackgroundImage = Image.FromFile("F:\\login interface\\main.jpg");
            //关闭对文本框的非法线程操作检查
            TextBox.CheckForIllegalCrossThreadCalls = false;
        }


        //整个皮带上用来检测跑偏的相机以供只有三个
        //①号相机
        Thread threadWatch = null; //负责监听客户端的线程
        Socket socketWatch = null; //负责监听客户端的套接字
        int count1 = 0;   //1号跑偏次数
        //②号相机
        Thread threadWatch1 = null; //负责监听客户端的线程
        Socket socketWatch1 = null; //负责监听客户端的套接字
        int count2 = 0;   //2号跑偏次数
        //③号相机
        Thread threadWatch2 = null; //负责监听客户端的线程
        Socket socketWatch2 = null; //负责监听客户端的套接字
        int count3 = 0;   //3号跑偏次数


        //filelist:文件播放列表
        List<string> fileList = new List<string>();
        //控制P1的播放，从listbox3选择播放文件
        private void button5_Click(object sender, EventArgs e)
        {
            //获取P1的URL路径
            //textBox6没有获得值
            axWindowsMediaPlayer1.URL = this.listBox3.Text;
            axWindowsMediaPlayer1.URL = this.textBox6.Text;
            axWindowsMediaPlayer1.Ctlcontrols.play();
            /*axWindowsMediaPlayer1.settings.autoStart = true;            //设置自动播放
            axWindowsMediaPlayer1.settings.setMode("loop", true);     //设置循环播放
            fileList.Add(@"F:\\Video Source P1\\P1.mp4");
            fileList.Add(@"F:\\Video Source P1\\P2.mp4");
            fileList.Add(@"F:\\Video Source P1\\P3.mp4");
            fileList.Add(@"F:\\Video Source P1\\P4.mp4");
            for (int g = 0; g < fileList.Count; g++)
            {
                listBox1.Items.Add(fileList[g]);
            }

            //默认选择第一项
            this.listBox1.SelectedIndex = 0;
            axWindowsMediaPlayer1.URL = fileList[listBox1.SelectedIndex];
            axWindowsMediaPlayer1.Ctlcontrols.play();
             */

        }


        //是一种循环播放的实现
        void nextMusic(int index)
        {
            //listBox1.SelectedIndices.Clear();
            index++;
            if (index == listBox1.Items.Count)
            {
                index = 0;
            }
            axWindowsMediaPlayer1.URL = fileList[index];
            listBox1.SelectedIndex = index;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }
        //控制视频播放器1的循环播放100ms
        private void timer1_Tick(object sender, EventArgs e)
        {
            //P1播放
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                //d1指的是媒体文件的总长度
                double d1 = Convert.ToDouble(axWindowsMediaPlayer1.currentMedia.duration.ToString());
                //d2是指当前进度+1
                double d2 = Convert.ToDouble(axWindowsMediaPlayer1.Ctlcontrols.currentPosition.ToString()) + 1;
                if (d1 <= d2)
                {
                    //listbox1:媒体文件列表
                    nextMusic(listBox1.SelectedIndex);
                }
            }
        }


        //设置特定位置的IP地址号和端口号，关闭视频播放器的自动播放功能
        private void Form2_Load_1(object sender, EventArgs e)
        {

            axWindowsMediaPlayer1.settings.autoStart = false;

            for (int i = 201; i < 301; i++)
            {
                comboBox1.Items.Add("192.168.0." + i.ToString());
            }
            //comboBox1.Text = "192.168.0.201";//ip地址默认值
            for (int i = 34; i < 100; i++)
            {
                comboBox2.Items.Add("82" + i.ToString());
            }
            //comboBox2.Text = "8234";//端口默认值
            axWindowsMediaPlayer1.settings.autoStart = false;
        }

        //启动按钮点击，绑定相关套接字，部分按钮失效
        private void button1_Click(object sender, EventArgs e)
        {

            //1号连接
            //启动和①号连接按钮失效
            button1.Enabled = false;
            button8.Enabled = false;
            //退出和关闭网络按钮有效
            button12.Enabled = true;
            button2.Enabled = true;

            //一号报警信息文本框不为空
            if (textBox1.Text != "")
            {
                //没有报警信息，图片开始闪烁
                timer2.Interval = 1000;//设置timer1控件时间间隔为1000ms即1秒
                timer2.Start();//开始
            }
            /*
            if (textBox3.Text != "")
            {
                timer3.Interval = 1000;//设置timer1控件时间间隔为1000ms即1秒
                timer3.Start();//开始
            }
            if (textBox4.Text != "")
            {
                timer4.Interval = 1000;//设置timer1控件时间间隔为1000ms即1秒
                timer4.Start();//开始
            }*/

            //定义一个套接字用于监听客户端发来的信息  包含3个参数(IP4寻址协议,流式连接,TCP协议)
            socketWatch = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //服务端发送信息 需要1个IP地址和端口号
            IPAddress ipaddress = IPAddress.Parse(comboBox1.Text.Trim()); //获取文本框输入的IP地址
            //将IP地址和端口号绑定到网络节点endpoint上 
            IPEndPoint endpoint = new IPEndPoint(ipaddress, int.Parse(comboBox2.Text.Trim())); //获取文本框上输入的端口号
            //监听绑定的网络节点
            socketWatch.Bind(endpoint);
            //将套接字的监听队列长度限制为20，即最大可以连接20个套接字
            socketWatch.Listen(20);
            //创建一个监听线程 
            threadWatch = new Thread(WatchConnecting);
            //将窗体线程设置为与后台同步
            threadWatch.IsBackground = true;
            //启动线程
            threadWatch.Start();
            //启动线程后 txtMsg文本框显示相应提示
            //textBox1.AppendText("开始监听客户端传来的信息!" + "\r\n");

            //2号连接按钮失效
            button11.Enabled = false;
            if (textBox1.Text != "")
            {
                timer2.Interval = 1000;//设置timer2控件时间间隔为1000ms即1秒
                timer2.Start();//开始
            }
            if (textBox3.Text != "")
            {
                timer3.Interval = 1000;//设置timer3控件时间间隔为1000ms即1秒
                timer3.Start();//开始
            }
            if (textBox4.Text != "")
            {
                timer4.Interval = 1000;//设置timer4控件时间间隔为1000ms即1秒
                timer4.Start();//开始
            }
            button1.Enabled = false;
            button2.Enabled = true;
            //定义一个套接字用于监听客户端发来的信息  包含3个参数(IP4寻址协议,流式连接,TCP协议)
            socketWatch1 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //服务端发送信息 需要1个IP地址和端口号
            IPAddress ipaddress1 = IPAddress.Parse(comboBox3.Text.Trim()); //获取文本框输入的IP地址
            //将IP地址和端口号绑定到网络节点endpoint上 
            IPEndPoint endpoint1 = new IPEndPoint(ipaddress1, int.Parse(comboBox4.Text.Trim())); //获取文本框上输入的端口号
            //监听绑定的网络节点
            socketWatch1.Bind(endpoint1);
            //将套接字的监听队列长度限制为20
            socketWatch1.Listen(20);
            //创建一个监听线程 
            threadWatch1 = new Thread(WatchConnecting1);
            //将窗体线程设置为与后台同步
            threadWatch1.IsBackground = true;
            //启动线程
            threadWatch1.Start();
            //启动线程后 txtMsg文本框显示相应提示
            //textBox1.AppendText("开始监听客户端传来的信息!" + "\r\n");

            //3号连接按钮失效
            button10.Enabled = false;
            /*
            if (textBox1.Text != "")
            {
                timer2.Interval = 1000;//设置timer1控件时间间隔为1000ms即1秒
                timer2.Start();//开始
            }
         
            if (textBox3.Text != "")
            {
                timer3.Interval = 1000;//设置timer1控件时间间隔为1000ms即1秒
                timer3.Start();//开始
            }*/
            if (textBox4.Text != "")
            {
                timer4.Interval = 1000;//设置timer1控件时间间隔为1000ms即1秒
                timer4.Start();//开始
            }

            //定义一个套接字用于监听客户端发来的信息  包含3个参数(IP4寻址协议,流式连接,TCP协议)
            socketWatch2 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //服务端发送信息 需要1个IP地址和端口号
            IPAddress ipaddress2 = IPAddress.Parse(comboBox6.Text.Trim()); //获取文本框输入的IP地址
            //将IP地址和端口号绑定到网络节点endpoint上 
            IPEndPoint endpoint2 = new IPEndPoint(ipaddress2, int.Parse(comboBox5.Text.Trim())); //获取文本框上输入的端口号
            //监听绑定的网络节点
            socketWatch2.Bind(endpoint2);
            //将套接字的监听队列长度限制为20
            socketWatch2.Listen(20);
            //创建一个监听线程
            threadWatch2 = new Thread(WatchConnecting2);
            //将窗体线程设置为与后台同步
            threadWatch2.IsBackground = true;
            //启动线程
            threadWatch2.Start();
            //启动线程后 txtMsg文本框显示相应提示
            //textBox1.AppendText("开始监听客户端传来的信息!" + "\r\n");
        }
        //创建一个负责和客户端通信的套接字 
        Socket socConnection = null;
        Socket socConnection1 = null;
        Socket socConnection2 = null;

        string str;
        string str1;
        string str2;


        /// <summary>
        /// 监听客户端发来的请求
        /// </summary>
        //①号相机监听，并开辟新的线程指向传输功能
        private void WatchConnecting()
        {
            while (true)  //持续不断监听客户端发来的请求
            {
                socConnection = socketWatch.Accept();
                // textBox1.AppendText("客户端连接成功" + "\r\n");
                //创建一个通信线程 
                ParameterizedThreadStart pts = new ParameterizedThreadStart(ServerRecMsg);
                Thread thr = new Thread(pts);
                thr.IsBackground = true;
                //启动线程
                thr.Start(socConnection);
            }
        }
        //②号相机监听，并开辟新的线程指向传输功能
        private void WatchConnecting1()
        {
            while (true)  //持续不断监听客户端发来的请求
            {
                socConnection1 = socketWatch1.Accept();
                // textBox1.AppendText("客户端连接成功" + "\r\n");
                //创建一个通信线程 
                ParameterizedThreadStart pts1 = new ParameterizedThreadStart(ServerRecMsg1);
                Thread thr1 = new Thread(pts1);
                thr1.IsBackground = true;
                //启动线程
                thr1.Start(socConnection1);
            }
        }
        //③号相机监听，并开辟新的线程指向传输功能
        private void WatchConnecting2()
        {
            while (true)  //持续不断监听客户端发来的请求
            {
                socConnection2 = socketWatch2.Accept();
                // textBox1.AppendText("客户端连接成功" + "\r\n");
                //创建一个通信线程 
                ParameterizedThreadStart pts2 = new ParameterizedThreadStart(ServerRecMsg2);
                Thread thr2 = new Thread(pts2);
                thr2.IsBackground = true;
                //启动线程
                thr2.Start(socConnection2);
            }
        }
        /// 接收客户端发来的信息 
        /// </summary>
        /// <param name="socketClientPara">客户端套接字对象</param>
        /// 
        //①号相机，向服务器发送信息
        private void ServerRecMsg(object socketClientPara)
        {
            Socket socketServer = socketClientPara as Socket;
            try
            {
                while (true)
                {
                    //创建一个内存缓冲区 其大小为1024*1024字节  即1M
                    byte[] arrServerRecMsg = new byte[1024 * 1024];
                    //将接收到的信息存入到内存缓冲区,并返回其字节数组的长度
                    int length = socketServer.Receive(arrServerRecMsg);

                    //将机器接受到的字节数组转换为人可以读懂的字符串
                    string strSRecMsg = Encoding.UTF8.GetString(arrServerRecMsg, 0, length);
                    str = strSRecMsg;
                    System.Timers.Timer t = new System.Timers.Timer(50000);
                    t.Enabled = true;
                    //将发送的字符串信息附加到文本框txtMsg上  
                    //textBox1.AppendText(GetCurrentTime() + "  " + strSRecMsg + " " + (count1 + 1) + " ");
                    textBox1.AppendText(GetCurrentTime() + "  " + strSRecMsg);
                    textBox9.AppendText(" 今日跑偏" + count1 + "次" + "\r\n");
                }
            }
            catch
            {
                this.Close();//关闭当前窗体
            }
        }

        //②号相机，向服务器发送信息
        private void ServerRecMsg1(object socketClientPara)
        {
            Socket socketServer1 = socketClientPara as Socket;
            try
            {
                while (true)
                {
                    //创建一个内存缓冲区 其大小为1024*1024字节  即1M
                    byte[] arrServerRecMsg1 = new byte[1024 * 1024];
                    //将接收到的信息存入到内存缓冲区,并返回其字节数组的长度
                    int length1 = socketServer1.Receive(arrServerRecMsg1);
                    //将机器接受到的字节数组转换为人可以读懂的字符串
                    string strSRecMsg1 = Encoding.UTF8.GetString(arrServerRecMsg1, 0, length1);
                    str1 = strSRecMsg1;
                    System.Timers.Timer t = new System.Timers.Timer(50000);
                    t.Enabled = true;
                    //将发送的字符串信息附加到文本框txtMsg上  
                    // textBox3.AppendText(GetCurrentTime() + "  " + strSRecMsg1 + " " + (count2+1) + " ");
                    textBox3.AppendText(GetCurrentTime() + "  " + strSRecMsg1);
                    textBox10.AppendText(" 今日跑偏" + count2 + "次" + "\r\n");
                }
            }
            catch
            {
                this.Close();//关闭当前窗体
            }
        }
        //③号相机，向服务器发送信息
        private void ServerRecMsg2(object socketClientPara)
        {
            Socket socketServer2 = socketClientPara as Socket;
            try
            {
                while (true)
                {
                    //创建一个内存缓冲区 其大小为1024*1024字节  即1M
                    byte[] arrServerRecMsg2 = new byte[1024 * 1024];
                    //将接收到的信息存入到内存缓冲区,并返回其字节数组的长度
                    int length2 = socketServer2.Receive(arrServerRecMsg2);
                    //将机器接受到的字节数组转换为人可以读懂的字符串
                    string strSRecMsg2 = Encoding.UTF8.GetString(arrServerRecMsg2, 0, length2);
                    str2 = strSRecMsg2;
                    System.Timers.Timer t = new System.Timers.Timer(10000);
                    t.Enabled = true;
                    //将发送的字符串信息附加到文本框txtMsg上  
                    // textBox4.AppendText(GetCurrentTime() + "  " + strSRecMsg2 + " " + (count3 + 1) + " ");
                    textBox4.AppendText(GetCurrentTime() + "  " + strSRecMsg2);
                    textBox11.AppendText(" 今日跑偏" + count3 + "次" + "\r\n");
                }
            }
            catch
            {
                this.Close();//关闭当前窗体
            }
        }

        //获得当前系统时间
        private DateTime GetCurrentTime()
        {
            DateTime currentTime = new DateTime();
            currentTime = DateTime.Now;
            return currentTime;
        }
        //关闭网络
        private void button2_Click(object sender, EventArgs e)
        {
            //关闭端口
            try
            {
                socConnection.Close();//关闭网络
                button1.Enabled = true;//打开网络按钮可用
                button2.Enabled = false;//关闭网络按钮不可用
            }
            catch
            {
                MessageBox.Show("网络关闭错误", "错误");
            }
        }
        //清屏按钮
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";//清屏
            textBox3.Text = "";//清屏
            textBox4.Text = "";//清屏

            SoundPlayer player = new SoundPlayer();
            player.Stop();
        }


        private void button9_Click(object sender, EventArgs e)
        {

        }

        //二号连接按钮触发
        private void button11_Click(object sender, EventArgs e)
        {
            //启动按钮、二号连接、退出按钮关闭
            button1.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = true;
            if (textBox1.Text != "")
            {
                timer2.Interval = 1000;//设置timer1控件时间间隔为1000ms即1秒
                timer2.Start();//开始
            }
            if (textBox3.Text != "")
            {
                timer3.Interval = 1000;//设置timer1控件时间间隔为1000ms即1秒
                timer3.Start();//开始
            }
            if (textBox4.Text != "")
            {
                timer4.Interval = 1000;//设置timer1控件时间间隔为1000ms即1秒
                timer4.Start();//开始
            }
            //启动按钮失效
            button1.Enabled = false;
            //关闭网络有效
            button2.Enabled = true;
            //定义一个套接字用于监听客户端发来的信息  包含3个参数(IP4寻址协议,流式连接,TCP协议)
            socketWatch1 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //服务端发送信息 需要1个IP地址和端口号
            IPAddress ipaddress1 = IPAddress.Parse(comboBox3.Text.Trim()); //获取文本框输入的IP地址
            //将IP地址和端口号绑定到网络节点endpoint上 
            IPEndPoint endpoint1 = new IPEndPoint(ipaddress1, int.Parse(comboBox4.Text.Trim())); //获取文本框上输入的端口号
            //监听绑定的网络节点
            socketWatch1.Bind(endpoint1);
            //将套接字的监听队列长度限制为20
            socketWatch1.Listen(20);
            //创建一个监听线程 
            threadWatch1 = new Thread(WatchConnecting1);
            //将窗体线程设置为与后台同步
            threadWatch1.IsBackground = true;
            //启动线程
            threadWatch1.Start();
            //启动线程后 txtMsg文本框显示相应提示
            //textBox1.AppendText("开始监听客户端传来的信息!" + "\r\n");
            //P1自动播放
            axWindowsMediaPlayer1.settings.autoStart = true;      //设置自动播放
                                                                  //报警

        }

        //p2播放按钮
        private void button7_Click(object sender, EventArgs e)
        {
            //listBox3中存放的是特定文件夹下的文件
            axWindowsMediaPlayer2.URL = this.listBox3.Text;
            axWindowsMediaPlayer2.Ctlcontrols.play();
            /*axWindowsMediaPlayer2.settings.autoStart = true;            //设置自动播放
            axWindowsMediaPlayer2.settings.setMode("loop", true);     //设置循环播放
            fileList.Add(@"F:\\Video Source P1\\P1.mp4");
            fileList.Add(@"F:\\Video Source P1\\P2.mp4");
            fileList.Add(@"F:\\Video Source P1\\P3.mp4");
            fileList.Add(@"F:\\Video Source P1\\P4.mp4");
            for (int g = 0; g < fileList.Count; g++)
            {
                listBox2.Items.Add(fileList[g]);
            }

            //默认选择第一项
            this.listBox2.SelectedIndex = 0;
            axWindowsMediaPlayer2.URL = fileList[listBox1.SelectedIndex];
            axWindowsMediaPlayer2.Ctlcontrols.play();*/
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        //退出按钮
        private void button12_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //触发2按钮
        private void button6_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }
        //1号连接按钮
        private void button8_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer2.Ctlcontrols.stop();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        //每秒触发一次tick事件,触发时机尾，重锤，机头处的图片开始闪烁；
        private void timer2_Tick(object sender, EventArgs e)
        {
            //机尾处的pic
            pictureBox2.ImageLocation = pathlist1[(index1++) % pathlist1.Length];
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            //重锤处的pic
            pictureBox3.ImageLocation = pathlist2[(index2++) % pathlist2.Length];
        }
        private void timer4_Tick(object sender, EventArgs e)
        {
            //机头处的pic
            pictureBox4.ImageLocation = pathlist3[(index3++) % pathlist3.Length];
        }

        //一号报警信息
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                timer2.Interval = 1000;//设置timer1控件时间间隔为1000ms即1秒
                timer2.Start();//开始
            }
            else if (textBox1.Text == "")
            {
                timer2.Stop();
                Image image = Image.FromFile("F:\\showpicture\\g_1.jpg");
                pictureBox2.Image = image;
            }

            button9.PerformClick();
            count1++;
        }


        //二号报警信息
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                timer3.Interval = 1000;//设置timer1控件时间间隔为1000ms即1秒
                timer3.Start();//开始
            }
            else if (textBox3.Text == "")
            {
                timer3.Stop();
                Image image = Image.FromFile("F:\\showpicture\\g_1.jpg");
                pictureBox3.Image = image;
            }

            button6.PerformClick();
            count2++;
        }

        //三号报警信息
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text != "")
            {
                timer4.Interval = 1000;//设置timer1控件时间间隔为1000ms即1秒
                timer4.Start();//开始
            }
            else if (textBox4.Text == "")
            {
                timer4.Stop();
                Image image = Image.FromFile("F:\\showpicture\\g_1.jpg");
                pictureBox4.Image = image;
            }

            button4.PerformClick();
            count3++;
        }


        //添加日志输出类output
        //机尾报警日志
        public void output(string log)
        {
            //如果日志信息长度超过100行，则自动清空
            if (textBox5.GetLineFromCharIndex(textBox5.Text.Length) > 100)
                textBox5.Text = "";
            //添加日志
            textBox5.AppendText(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss ") + log + "\r\n");
            write(log);
        }
        //添加记录日志类write
        //可以用using重写
        public void write(string msg)
        {
            //获取当前程序目录fullname
            string logPath = Path.GetDirectoryName(Application.ExecutablePath);
            //新建文件
            System.IO.StreamWriter sw = System.IO.File.AppendText(logPath + "/皮带机尾处跑偏报警日志.txt");
            //写入日志信息
            sw.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss ") + msg);
            //关闭文件
            sw.Close();
            sw.Dispose();
        }

        //重锤报警日志
        //添加日志输出类output
        public void output1(string log1)
        {
            //如果日志信息长度超过100行，则自动清空
            if (textBox2.GetLineFromCharIndex(textBox2.Text.Length) > 100)
                textBox2.Text = "";
            //添加日志
            textBox2.AppendText(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss ") + log1 + "\r\n");
            write1(log1);
        }
        //添加记录日志类write
        public void write1(string msg1)
        {
            //获取当前程序目录
            string logPath1 = Path.GetDirectoryName(Application.ExecutablePath);
            //新建文件
            System.IO.StreamWriter sw1 = System.IO.File.AppendText(logPath1 + "/皮带重锤处跑偏报警日志.txt");
            //写入日志信息
            sw1.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss ") + msg1);
            //关闭文件
            sw1.Close();
            sw1.Dispose();
        }
        //机头报警日志
        //添加日志输出类output
        public void output2(string log2)
        {
            //如果日志信息长度超过100行，则自动清空
            if (textBox8.GetLineFromCharIndex(textBox8.Text.Length) > 100)
                textBox8.Text = "";
            //添加日志
            textBox8.AppendText(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss ") + log2 + "\r\n");
            write2(log2);
        }
        //添加记录日志类write
        public void write2(string msg2)
        {
            //获取当前程序目录
            string logPath2 = Path.GetDirectoryName(Application.ExecutablePath);
            //新建文件
            System.IO.StreamWriter sw2 = System.IO.File.AppendText(logPath2 + "/皮带机头处跑偏报警日志.txt");
            //写入日志信息
            sw2.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss ") + msg2);
            //关闭文件
            sw2.Close();
            sw2.Dispose();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            //清空日志信息

        }

        //触发①语音报警
        private void button9_Click_1(object sender, EventArgs e)
        {
            //语音报警
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = @"C:\Users\john\Desktop\TCP_Picture\08.wav";
            //player.Load(); //同步加载声音  
            //player.Play(); //启用新线程播放  
            //player.PlayLooping(); //循环播放模式 
            //客户端传回来的信息
            output(str + "皮带机尾处跑偏报警");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //触发②语音报警
        private void button6_Click_1(object sender, EventArgs e)
        {
            //语音报警
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = @"C:\Users\john\Desktop\TCP_Picture\08.wav";
            player.Load(); //同步加载声音  
            //player.Play(); //启用新线程播放  
            player.PlayLooping(); //循环播放模式 
            output1(str1 + "皮带重锤处跑偏报警");
        }

        //触发③语音报警
        private void button4_Click(object sender, EventArgs e)
        {
            //语音报警
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = @"C:\Users\john\Desktop\TCP_Picture\08.wav";
            player.Load(); //同步加载声音  
            //player.Play(); //启用新线程播放  
            player.PlayLooping(); //循环播放模式 
            output2(str2 + "皮带机头处跑偏报警");
        }

        //一号连接按钮
        private void button8_Click_1(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button8.Enabled = false;
            button12.Enabled = true;
            button2.Enabled = true;

            if (textBox1.Text != "")
            {
                timer2.Interval = 1000;//设置timer1控件时间间隔为1000ms即1秒
                timer2.Start();//开始
            }
            /*
            if (textBox3.Text != "")
            {
                timer3.Interval = 1000;//设置timer1控件时间间隔为1000ms即1秒
                timer3.Start();//开始
            }
            if (textBox4.Text != "")
            {
                timer4.Interval = 1000;//设置timer1控件时间间隔为1000ms即1秒
                timer4.Start();//开始
            }*/
            textBox1.AppendText("Connected"); 
            //定义一个套接字用于监听客户端发来的信息  包含3个参数(IP4寻址协议,流式连接,TCP协议)
            socketWatch = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //服务端发送信息 需要1个IP地址和端口号
            IPAddress ipaddress = IPAddress.Parse(comboBox1.Text.Trim()); //获取文本框输入的IP地址
            //将IP地址和端口号绑定到网络节点endpoint上 
            IPEndPoint endpoint = new IPEndPoint(ipaddress, int.Parse(comboBox2.Text.Trim())); //获取文本框上输入的端口号
            //监听绑定的网络节点
            socketWatch.Bind(endpoint);
            //将套接字的监听队列长度限制为20
            socketWatch.Listen(20);
            //创建一个监听线程 
            threadWatch = new Thread(WatchConnecting);
            //将窗体线程设置为与后台同步
            threadWatch.IsBackground = true;
            //启动线程
            threadWatch.Start();
            //启动线程后 txtMsg文本框显示相应提示
            //textBox1.AppendText("开始监听客户端传来的信息!" + "\r\n");
        }

        //三号连接按钮
        private void button10_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button10.Enabled = false;
            button12.Enabled = true;
            button2.Enabled = true;
            /*
            if (textBox1.Text != "")
            {
                timer2.Interval = 1000;//设置timer1控件时间间隔为1000ms即1秒
                timer2.Start();//开始
            }
         
            if (textBox3.Text != "")
            {
                timer3.Interval = 1000;//设置timer1控件时间间隔为1000ms即1秒
                timer3.Start();//开始
            }*/
            if (textBox4.Text != "")
            {
                timer4.Interval = 1000;//设置timer1控件时间间隔为1000ms即1秒
                timer4.Start();//开始
            }

            //定义一个套接字用于监听客户端发来的信息  包含3个参数(IP4寻址协议,流式连接,TCP协议)
            socketWatch2 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //服务端发送信息 需要1个IP地址和端口号
            IPAddress ipaddress2 = IPAddress.Parse(comboBox6.Text.Trim()); //获取文本框输入的IP地址
            //将IP地址和端口号绑定到网络节点endpoint上 
            IPEndPoint endpoint2 = new IPEndPoint(ipaddress2, int.Parse(comboBox5.Text.Trim())); //获取文本框上输入的端口号
            //监听绑定的网络节点
            socketWatch2.Bind(endpoint2);
            //将套接字的监听队列长度限制为20
            socketWatch2.Listen(20);
            //创建一个监听线程 
            threadWatch2 = new Thread(WatchConnecting2);
            //将窗体线程设置为与后台同步
            threadWatch2.IsBackground = true;
            //启动线程
            threadWatch2.Start();
            //启动线程后 txtMsg文本框显示相应提示
            //textBox1.AppendText("开始监听客户端传来的信息!" + "\r\n");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //刷新按钮的时间

        //重新刷新播放器目录
        private void button13_Click(object sender, EventArgs e)
        {
            //利用指定位置的文件夹创建实例
            // 文件夹是怎么创建的
            DirectoryInfo theFolder = new DirectoryInfo(@"C:\surveillance video");
            //返回当前目录下的所有目录
            DirectoryInfo[] dirInfo = theFolder.GetDirectories();
            //遍历文件夹
            foreach (DirectoryInfo NextFolder in dirInfo)
            {
                //遍历其中的每一个文件夹
                // this.listBox1.Items.Add(NextFolder.Name);
                //获得子目录中的文件
                FileInfo[] fileInfo = NextFolder.GetFiles();
                foreach (FileInfo NextFile in fileInfo)  //遍历文件
                    this.listBox3.Items.Add(@"C:\surveillance video" + "\\" + NextFolder.Name + "\\" + NextFile.Name);
            }
        }

        //打开监控网页
        private void button14_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://192.168.0.250/doc/page/preview.asp");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
