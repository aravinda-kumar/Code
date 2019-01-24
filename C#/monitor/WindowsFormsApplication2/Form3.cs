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
    public partial class Form3 : Form
    {
        #region 闪烁图片
        //机尾1号
        int index11 = 0;
        string[] pathlist11 ={
        @"F:\showpicture\11.jpg",
        @"F:\showpicture\12.jpg",
        @"F:\showpicture\13.jpg"
        };//图片路径列表

        //机尾2号
        int index12 = 0;
        string[] pathlist12 ={
        @"F:\showpicture\14.jpg",
        @"F:\showpicture\15.jpg",
        @"F:\showpicture\16.jpg"
        };//图片路径列表

        //机尾3号
        int index13 = 0;
        string[] pathlist13 ={
        @"F:\showpicture\17.jpg",
        @"F:\showpicture\18.jpg",
        @"F:\showpicture\19.jpg"
        };//图片路径列表

        //重锤1号
        int index21 = 0;
        string[] pathlist21 ={
        @"F:\showpicture\21.jpg",
        @"F:\showpicture\22.jpg",
        @"F:\showpicture\23.jpg"
        };//图片路径列表

        //重锤2号
        int index22 = 0;
        string[] pathlist22 ={
        @"F:\showpicture\24.jpg",
        @"F:\showpicture\25.jpg",
        @"F:\showpicture\26.jpg"
        };//图片路径列表

        //重锤3号
        int index23 = 0;
        string[] pathlist23 ={
        @"F:\showpicture\27.jpg",
        @"F:\showpicture\28.jpg",
        @"F:\showpicture\29.jpg"
        };//图片路径列表

        //机头1号
        int index31 = 0;
        string[] pathlist31 ={
        @"F:\showpicture\31.jpg",
        @"F:\showpicture\32.jpg",
        @"F:\showpicture\33.jpg"
        };//图片路径列表

        //机头2号
        int index32 = 0;
        string[] pathlist32 ={
        @"F:\showpicture\34.jpg",
        @"F:\showpicture\35.jpg",
        @"F:\showpicture\36.jpg"
        };//图片路径列表

        //机头3号
        int index33 = 0;
        string[] pathlist33 ={
        @"F:\showpicture\37.jpg",
        @"F:\showpicture\38.jpg",
        @"F:\showpicture\39.jpg"
        };//图片路径列表
        #endregion

        public Form3()
        {
            InitializeComponent();
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
            //this.BackgroundImage = Image.FromFile("F:\\login interface\\main.jpg");
            //关闭对文本框的非法线程操作检查
            TextBox.CheckForIllegalCrossThreadCalls = false;
        }

        #region 监听用的线程和套接字
        //机尾①号相机
        Thread threadWatch = null; //负责监听客户端的线程
        Socket socketWatch = null; //负责监听客户端的套接字
        //机尾②号相机
        Thread threadWatch12 = null; //负责监听客户端的线程
        Socket socketWatch12 = null; //负责监听客户端的套接字
        //机尾③号相机
        Thread threadWatch13 = null; //负责监听客户端的线程
        Socket socketWatch13 = null; //负责监听客户端的套接字

        //重锤①号相机
        Thread threadWatch21 = null; //负责监听客户端的线程
        Socket socketWatch21 = null; //负责监听客户端的套接字
        //重锤②号相机
        Thread threadWatch22 = null; //负责监听客户端的线程
        Socket socketWatch22 = null; //负责监听客户端的套接字
        //重锤③号相机
        Thread threadWatch23 = null; //负责监听客户端的线程
        Socket socketWatch23 = null; //负责监听客户端的套接字

        //机头①号相机
        Thread threadWatch31 = null; //负责监听客户端的线程
        Socket socketWatch31 = null; //负责监听客户端的套接字
        //机头②号相机
        Thread threadWatch32 = null; //负责监听客户端的线程
        Socket socketWatch32 = null; //负责监听客户端的套接字
        //机头③号相机
        Thread threadWatch33 = null; //负责监听客户端的线程
        Socket socketWatch33 = null; //负责监听客户端的套接字
        #endregion
        
        //加载设置设置IP1的地址和端口
        private void Form3_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.autoStart = false;

            for (int i = 201; i < 301; i++)
            {
                comboBox1.Items.Add("192.168.0." + i.ToString());
            }
           // comboBox1.Text = "192.168.0.201";//ip地址默认值
            for (int i = 34; i < 100; i++)
            {
                comboBox2.Items.Add("82" + i.ToString());
            }
            //comboBox2.Text = "8234";//端口默认值

            axWindowsMediaPlayer1.settings.autoStart = false;
        }
       
        private void label5_Click(object sender, EventArgs e)
        {
           
        }

       // 机尾2号按钮
        private void button11_Click(object sender, EventArgs e)
        {
            //启动按钮和机尾2号按钮失效，退出按钮有效
            button1.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = true;
           
            //有报警日志出现，图片开始闪烁
            if (textBox4.Text != "")
            {
                timer3.Interval = 1000;//设置timer1控件时间间隔为1000ms即1秒
                timer3.Start();//开始
            }
            //关闭网络有效
            button2.Enabled = true;

            //监听线程
            //定义一个套接字用于监听客户端发来的信息  包含3个参数(IP4寻址协议,流式连接,TCP协议)
            socketWatch12 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //服务端发送信息 需要1个IP地址和端口号
            IPAddress ipaddress12 = IPAddress.Parse(comboBox4.Text.Trim()); //获取文本框输入的IP地址
            //将IP地址和端口号绑定到网络节点endpoint上 
            IPEndPoint endpoint12 = new IPEndPoint(ipaddress12, int.Parse(comboBox3.Text.Trim())); //获取文本框上输入的端口号
            //监听绑定的网络节点
            socketWatch12.Bind(endpoint12);
            //将套接字的监听队列长度限制为20
            socketWatch12.Listen(20);
            //创建一个监听线程 
            threadWatch12 = new Thread(WatchConnecting12);
            //将窗体线程设置为与后台同步
            threadWatch12.IsBackground = true;
            //启动线程
            threadWatch12.Start();
            //启动线程后 txtMsg文本框显示相应提示
            //textBox1.AppendText("开始监听客户端传来的信息!" + "\r\n");
            //P1自动播放
            axWindowsMediaPlayer1.settings.autoStart = true;      //设置自动播放
            //报警
            
        }

        #region blankevent

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        #endregion

        //关闭传输按钮
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //清屏按钮
        private void button3_Click(object sender, EventArgs e)
        {
            textBox9.Text = "";//清屏
            textBox10.Text = "";//清屏
            textBox14.Text = "";//清屏

            textBox15.Text = "";//清屏
            textBox16.Text = "";//清屏
            textBox17.Text = "";//清屏

            textBox18.Text = "";//清屏
            textBox19.Text = "";//清屏
            textBox20.Text = "";//清屏
            
            SoundPlayer player = new SoundPlayer();
            player.Stop();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
           
        }

        //关闭网络
        private void button2_Click(object sender, EventArgs e)
        {
            //关闭端口
            try
            {
                socConnection.Close();//关闭串口
                button1.Enabled = true;//打开串口按钮可用
                button2.Enabled = false;//关闭串口按钮不可用
            }
            catch
            {
                MessageBox.Show("网络关闭错误", "错误");
            }
        }

        //启动按钮
        private void button1_Click(object sender, EventArgs e)
        {
           //机尾1号
            button1.Enabled = false;
            button18.Enabled = false;
            button12.Enabled = true;

            if (textBox1.Text != "")
            {
                timer2.Interval = 1000;//设置timer1控件时间间隔为1000ms即1秒
                timer2.Start();//开始
            }
            button2.Enabled = true;
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

            //机尾2号
            button11.Enabled = false;
            if (textBox4.Text != "")
            {
                timer3.Interval = 1000;//设置timer1控件时间间隔为1000ms即1秒
                timer3.Start();//开始
            }
            button2.Enabled = true;
            //定义一个套接字用于监听客户端发来的信息  包含3个参数(IP4寻址协议,流式连接,TCP协议)
            socketWatch12 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //服务端发送信息 需要1个IP地址和端口号
            IPAddress ipaddress12 = IPAddress.Parse(comboBox4.Text.Trim()); //获取文本框输入的IP地址
            //将IP地址和端口号绑定到网络节点endpoint上 
            IPEndPoint endpoint12 = new IPEndPoint(ipaddress12, int.Parse(comboBox3.Text.Trim())); //获取文本框上输入的端口号
            //监听绑定的网络节点
            socketWatch12.Bind(endpoint12);
            //将套接字的监听队列长度限制为20
            socketWatch12.Listen(20);
            //创建一个监听线程 
            threadWatch12 = new Thread(WatchConnecting12);
            //将窗体线程设置为与后台同步
            threadWatch12.IsBackground = true;
            //启动线程
            threadWatch12.Start();
            //启动线程后 txtMsg文本框显示相应提示
            //textBox1.AppendText("开始监听客户端传来的信息!" + "\r\n");

            //机尾3号
            button19.Enabled = false;
            if (textBox13.Text != "")
            {
                timer4.Interval = 1000;//设置timer1控件时间间隔为1000ms即1秒
                timer4.Start();//开始
            }
            button2.Enabled = true;
            //定义一个套接字用于监听客户端发来的信息  包含3个参数(IP4寻址协议,流式连接,TCP协议)
            socketWatch13 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //服务端发送信息 需要1个IP地址和端口号
            IPAddress ipaddress13 = IPAddress.Parse(comboBox6.Text.Trim()); //获取文本框输入的IP地址
            //将IP地址和端口号绑定到网络节点endpoint上 
            IPEndPoint endpoint13 = new IPEndPoint(ipaddress13, int.Parse(comboBox5.Text.Trim())); //获取文本框上输入的端口号
            //监听绑定的网络节点
            socketWatch13.Bind(endpoint13);
            //将套接字的监听队列长度限制为20
            socketWatch13.Listen(20);
            //创建一个监听线程 
            threadWatch13 = new Thread(WatchConnecting13);
            //将窗体线程设置为与后台同步
            threadWatch13.IsBackground = true;
            //启动线程
            threadWatch13.Start();
            //启动线程后 txtMsg文本框显示相应提示
            //textBox1.AppendText("开始监听客户端传来的信息!" + "\r\n");

            //重锤1号
            button22.Enabled = false;

            if (textBox7.Text != "")
            {
                timer5.Interval = 1000;//设置timer1控件时间间隔为1000ms即1秒
                timer5.Start();//开始
            }
            button2.Enabled = true;
            //定义一个套接字用于监听客户端发来的信息  包含3个参数(IP4寻址协议,流式连接,TCP协议)
            socketWatch21 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //服务端发送信息 需要1个IP地址和端口号
            IPAddress ipaddress21 = IPAddress.Parse(comboBox8.Text.Trim()); //获取文本框输入的IP地址
            //将IP地址和端口号绑定到网络节点endpoint上 
            IPEndPoint endpoint21 = new IPEndPoint(ipaddress21, int.Parse(comboBox7.Text.Trim())); //获取文本框上输入的端口号
            //监听绑定的网络节点
            socketWatch21.Bind(endpoint21);
            //将套接字的监听队列长度限制为20
            socketWatch21.Listen(20);
            //创建一个监听线程 
            threadWatch21 = new Thread(WatchConnecting21);
            //将窗体线程设置为与后台同步
            threadWatch21.IsBackground = true;
            //启动线程
            threadWatch21.Start();
            //启动线程后 txtMsg文本框显示相应提示
            //textBox1.AppendText("开始监听客户端传来的信息!" + "\r\n");

            //重锤2号
            
            button21.Enabled = false;
           

            if (textBox6.Text != "")
            {
                timer6.Interval = 1000;//设置timer1控件时间间隔为1000ms即1秒
                timer6.Start();//开始
            }
            button2.Enabled = true;
            //定义一个套接字用于监听客户端发来的信息  包含3个参数(IP4寻址协议,流式连接,TCP协议)
            socketWatch22 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //服务端发送信息 需要1个IP地址和端口号
            IPAddress ipaddress22 = IPAddress.Parse(comboBox10.Text.Trim()); //获取文本框输入的IP地址
            //将IP地址和端口号绑定到网络节点endpoint上 
            IPEndPoint endpoint22 = new IPEndPoint(ipaddress22, int.Parse(comboBox9.Text.Trim())); //获取文本框上输入的端口号
            //监听绑定的网络节点
            socketWatch22.Bind(endpoint22);
            //将套接字的监听队列长度限制为20
            socketWatch22.Listen(20);
            //创建一个监听线程 
            threadWatch22 = new Thread(WatchConnecting22);
            //将窗体线程设置为与后台同步
            threadWatch22.IsBackground = true;
            //启动线程
            threadWatch22.Start();
            //启动线程后 txtMsg文本框显示相应提示
            //textBox1.AppendText("开始监听客户端传来的信息!" + "\r\n");

            //重锤3号
            button1.Enabled = false;
            button20.Enabled = false;
            button12.Enabled = true;

            if (textBox5.Text != "")
            {
                timer7.Interval = 1000;//设置timer1控件时间间隔为1000ms即1秒
                timer7.Start();//开始
            }
            button2.Enabled = true;
            //定义一个套接字用于监听客户端发来的信息  包含3个参数(IP4寻址协议,流式连接,TCP协议)
            socketWatch23 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //服务端发送信息 需要1个IP地址和端口号
            IPAddress ipaddress23 = IPAddress.Parse(comboBox12.Text.Trim()); //获取文本框输入的IP地址
            //将IP地址和端口号绑定到网络节点endpoint上 
            IPEndPoint endpoint23 = new IPEndPoint(ipaddress23, int.Parse(comboBox11.Text.Trim())); //获取文本框上输入的端口号
            //监听绑定的网络节点
            socketWatch23.Bind(endpoint23);
            //将套接字的监听队列长度限制为20
            socketWatch23.Listen(20);
            //创建一个监听线程 
            threadWatch23 = new Thread(WatchConnecting23);
            //将窗体线程设置为与后台同步
            threadWatch23.IsBackground = true;
            //启动线程
            threadWatch23.Start();
            //启动线程后 txtMsg文本框显示相应提示
            //textBox1.AppendText("开始监听客户端传来的信息!" + "\r\n");

            //机头1号
            
            button25.Enabled = false;
           

            if (textBox8.Text != "")
            {
                timer8.Interval = 1000;//设置timer1控件时间间隔为1000ms即1秒
                timer8.Start();//开始
            }
            button2.Enabled = true;
            //定义一个套接字用于监听客户端发来的信息  包含3个参数(IP4寻址协议,流式连接,TCP协议)
            socketWatch31 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //服务端发送信息 需要1个IP地址和端口号
            IPAddress ipaddress31 = IPAddress.Parse(comboBox14.Text.Trim()); //获取文本框输入的IP地址
            //将IP地址和端口号绑定到网络节点endpoint上 
            IPEndPoint endpoint31 = new IPEndPoint(ipaddress31, int.Parse(comboBox13.Text.Trim())); //获取文本框上输入的端口号
            //监听绑定的网络节点
            socketWatch31.Bind(endpoint31);
            //将套接字的监听队列长度限制为20
            socketWatch31.Listen(20);
            //创建一个监听线程 
            threadWatch31 = new Thread(WatchConnecting31);
            //将窗体线程设置为与后台同步
            threadWatch31.IsBackground = true;
            //启动线程
            threadWatch31.Start();
            //启动线程后 txtMsg文本框显示相应提示
            //textBox1.AppendText("开始监听客户端传来的信息!" + "\r\n");

            //机头2号
           
            button24.Enabled = false;
           

            if (textBox3.Text != "")
            {
                timer9.Interval = 1000;//设置timer1控件时间间隔为1000ms即1秒
                timer9.Start();//开始
            }
            button2.Enabled = true;
            //定义一个套接字用于监听客户端发来的信息  包含3个参数(IP4寻址协议,流式连接,TCP协议)
            socketWatch32 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //服务端发送信息 需要1个IP地址和端口号
            IPAddress ipaddress32 = IPAddress.Parse(comboBox16.Text.Trim()); //获取文本框输入的IP地址
            //将IP地址和端口号绑定到网络节点endpoint上 
            IPEndPoint endpoint32 = new IPEndPoint(ipaddress32, int.Parse(comboBox15.Text.Trim())); //获取文本框上输入的端口号
            //监听绑定的网络节点
            socketWatch32.Bind(endpoint32);
            //将套接字的监听队列长度限制为20
            socketWatch32.Listen(20);
            //创建一个监听线程 
            threadWatch32 = new Thread(WatchConnecting32);
            //将窗体线程设置为与后台同步
            threadWatch32.IsBackground = true;
            //启动线程
            threadWatch32.Start();
            //启动线程后 txtMsg文本框显示相应提示
            //textBox1.AppendText("开始监听客户端传来的信息!" + "\r\n");

            //机头3号
            button23.Enabled = false;

            if (textBox2.Text != "")
            {
                timer10.Interval = 1000;//设置timer1控件时间间隔为1000ms即1秒
                timer10.Start();//开始
            }
            button2.Enabled = true;
            //定义一个套接字用于监听客户端发来的信息  包含3个参数(IP4寻址协议,流式连接,TCP协议)
            socketWatch33 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //服务端发送信息 需要1个IP地址和端口号
            IPAddress ipaddress33 = IPAddress.Parse(comboBox18.Text.Trim()); //获取文本框输入的IP地址
            //将IP地址和端口号绑定到网络节点endpoint上 
            IPEndPoint endpoint33 = new IPEndPoint(ipaddress33, int.Parse(comboBox17.Text.Trim())); //获取文本框上输入的端口号
            //监听绑定的网络节点
            socketWatch33.Bind(endpoint33);
            //将套接字的监听队列长度限制为20
            socketWatch33.Listen(20);
            //创建一个监听线程 
            threadWatch33 = new Thread(WatchConnecting33);
            //将窗体线程设置为与后台同步
            threadWatch33.IsBackground = true;
            //启动线程
            threadWatch33.Start();

            #region comment
            //启动线程后 txtMsg文本框显示相应提示
            //textBox1.AppendText("开始监听客户端传来的信息!" + "\r\n");
            /* button1.Enabled = false;
            button11.Enabled = false;
            button2.Enabled = true;
            //机尾
            if (textBox1.Text != "")
            {
                timer2.Interval = 1000;//设置timer1控件时间间隔为1000ms即1秒
                timer2.Start();//开始
            }
            if (textBox4.Text != "")
            {
                timer3.Interval = 1000;//设置timer1控件时间间隔为1000ms即1秒
                timer3.Start();//开始
            }
            if (textBox13.Text != "")
            {
                timer4.Interval = 1000;//设置timer1控件时间间隔为1000ms即1秒
                timer4.Start();//开始
            }
            //重锤
            if (textBox7.Text != "")
            {
                timer5.Interval = 1000;//设置timer1控件时间间隔为1000ms即1秒
                timer5.Start();//开始
            }
            if (textBox6.Text != "")
            {
                timer6.Interval = 1000;//设置timer1控件时间间隔为1000ms即1秒
                timer6.Start();//开始
            }
            if (textBox5.Text != "")
            {
                timer7.Interval = 1000;//设置timer1控件时间间隔为1000ms即1秒
                timer7.Start();//开始
            }
            
            //机头
            if (textBox8.Text != "")
            {
                timer8.Interval = 1000;//设置timer1控件时间间隔为1000ms即1秒
                timer8.Start();//开始
            }
            if (textBox3.Text != "")
            {
                timer9.Interval = 1000;//设置timer1控件时间间隔为1000ms即1秒
                timer9.Start();//开始
            }
            if (textBox2.Text != "")
            {
                timer10.Interval = 1000;//设置timer1控件时间间隔为1000ms即1秒
                timer10.Start();//开始
            }
            button1.Enabled = false;
            button2.Enabled = true;
            //机尾
            //定义一个套接字用于监听客户端发来的信息  包含3个参数(IP4寻址协议,流式连接,TCP协议)
            socketWatch = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socketWatch12 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socketWatch13 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            //重锤
            //定义一个套接字用于监听客户端发来的信息  包含3个参数(IP4寻址协议,流式连接,TCP协议)
            socketWatch21 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socketWatch22 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socketWatch23 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            //机头
            //定义一个套接字用于监听客户端发来的信息  包含3个参数(IP4寻址协议,流式连接,TCP协议)
            socketWatch31 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socketWatch32 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socketWatch33 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            
            //机尾
            //服务端发送信息 需要1个IP地址和端口号
            IPAddress ipaddress = IPAddress.Parse(comboBox1.Text.Trim()); //获取文本框输入的IP地址
            IPAddress ipaddress12 = IPAddress.Parse(comboBox4.Text.Trim()); //获取文本框输入的IP地址
            IPAddress ipaddress13 = IPAddress.Parse(comboBox6.Text.Trim()); //获取文本框输入的IP地址

            //重锤
            //服务端发送信息 需要1个IP地址和端口号
            IPAddress ipaddress21 = IPAddress.Parse(comboBox8.Text.Trim()); //获取文本框输入的IP地址
            IPAddress ipaddress22 = IPAddress.Parse(comboBox10.Text.Trim()); //获取文本框输入的IP地址
            IPAddress ipaddress23 = IPAddress.Parse(comboBox12.Text.Trim()); //获取文本框输入的IP地址

            //机头
            //服务端发送信息 需要1个IP地址和端口号
            IPAddress ipaddress31 = IPAddress.Parse(comboBox14.Text.Trim()); //获取文本框输入的IP地址
            IPAddress ipaddress32 = IPAddress.Parse(comboBox16.Text.Trim()); //获取文本框输入的IP地址
            IPAddress ipaddress33 = IPAddress.Parse(comboBox18.Text.Trim()); //获取文本框输入的IP地址

            //机尾
            //将IP地址和端口号绑定到网络节点endpoint上 
            IPEndPoint endpoint = new IPEndPoint(ipaddress, int.Parse(comboBox2.Text.Trim())); //获取文本框上输入的端口号
            IPEndPoint endpoint12 = new IPEndPoint(ipaddress12, int.Parse(comboBox3.Text.Trim())); //获取文本框上输入的端口号
            IPEndPoint endpoint13 = new IPEndPoint(ipaddress13, int.Parse(comboBox5.Text.Trim())); //获取文本框上输入的端口号

            //重锤
            //将IP地址和端口号绑定到网络节点endpoint上 
            IPEndPoint endpoint21 = new IPEndPoint(ipaddress21, int.Parse(comboBox7.Text.Trim())); //获取文本框上输入的端口号
            IPEndPoint endpoint22 = new IPEndPoint(ipaddress22, int.Parse(comboBox9.Text.Trim())); //获取文本框上输入的端口号
            IPEndPoint endpoint23 = new IPEndPoint(ipaddress23, int.Parse(comboBox11.Text.Trim())); //获取文本框上输入的端口号

            //机头
            //将IP地址和端口号绑定到网络节点endpoint上 
            IPEndPoint endpoint31 = new IPEndPoint(ipaddress31, int.Parse(comboBox13.Text.Trim())); //获取文本框上输入的端口号
            IPEndPoint endpoint32 = new IPEndPoint(ipaddress32, int.Parse(comboBox15.Text.Trim())); //获取文本框上输入的端口号
            IPEndPoint endpoint33 = new IPEndPoint(ipaddress33, int.Parse(comboBox17.Text.Trim())); //获取文本框上输入的端口号
            
            //机尾
            //监听绑定的网络节点
            socketWatch.Bind(endpoint);
            socketWatch12.Bind(endpoint12);
            socketWatch13.Bind(endpoint13);

            //重锤
            //监听绑定的网络节点
            socketWatch21.Bind(endpoint21);
            socketWatch22.Bind(endpoint22);
            socketWatch23.Bind(endpoint23);

            //机头
            //监听绑定的网络节点
            socketWatch31.Bind(endpoint31);
            socketWatch32.Bind(endpoint32);
            socketWatch33.Bind(endpoint33);

            //机尾
            //将套接字的监听队列长度限制为20
            socketWatch.Listen(20);
            socketWatch12.Listen(20);
            socketWatch13.Listen(20);

            //重锤
            //将套接字的监听队列长度限制为20
            socketWatch21.Listen(20);
            socketWatch22.Listen(20);
            socketWatch23.Listen(20);

            //机头
            //将套接字的监听队列长度限制为20
            socketWatch31.Listen(20);
            socketWatch32.Listen(20);
            socketWatch33.Listen(20);

            //机尾
            //创建一个监听线程 
            threadWatch = new Thread(WatchConnecting);
            threadWatch12 = new Thread(WatchConnecting12);
            threadWatch13 = new Thread(WatchConnecting13);

            //重锤
            //创建一个监听线程 
            threadWatch21 = new Thread(WatchConnecting21);
            threadWatch22 = new Thread(WatchConnecting22);
            threadWatch23 = new Thread(WatchConnecting23);

            //机头
            //创建一个监听线程 
            threadWatch31 = new Thread(WatchConnecting31);
            threadWatch32 = new Thread(WatchConnecting32);
            threadWatch33 = new Thread(WatchConnecting33);

            //机尾
            //将窗体线程设置为与后台同步
            threadWatch.IsBackground = true;
            threadWatch12.IsBackground = true;
            threadWatch13.IsBackground = true;

            //重锤
            //将窗体线程设置为与后台同步
            threadWatch21.IsBackground = true;
            threadWatch22.IsBackground = true;
            threadWatch23.IsBackground = true;

            //机头
            //将窗体线程设置为与后台同步
            threadWatch31.IsBackground = true;
            threadWatch32.IsBackground = true;
            threadWatch33.IsBackground = true;
           
            //机尾
            //启动线程
            threadWatch.Start();
            threadWatch12.Start();
            threadWatch13.Start();

            //重锤
            //启动线程
            threadWatch21.Start();
            threadWatch22.Start();
            threadWatch23.Start();

            //机头
            //启动线程
            threadWatch31.Start();
            threadWatch32.Start();
            threadWatch33.Start();
            //启动线程后 txtMsg文本框显示相应提示
            //textBox1.AppendText("开始监听客户端传来的信息!" + "\r\n");*/
            #endregion
        }

        #region 通信套接字
        //机尾
        //创建一个负责和客户端通信的套接字 
        Socket socConnection = null;
        Socket socConnection12 = null;
        Socket socConnection13 = null;

        //重锤
        //创建一个负责和客户端通信的套接字 
        Socket socConnection21 = null;
        Socket socConnection22 = null;
        Socket socConnection23 = null;

        //机头
        //创建一个负责和客户端通信的套接字 
        Socket socConnection31 = null;
        Socket socConnection32 = null;
        Socket socConnection33 = null;
        #endregion

        #region 日志字符串
        //机尾
        string str;
        string str12;
        string str13;

        //重锤
        string str21;
        string str22;
        string str23;

        //机头
        string str31;
        string str32;
        string str33;
        #endregion


        #region 监听操作
        /// <summary>
        /// 监听客户端发来的请求
        /// </summary>
        //机尾①号相机
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
        //机尾②号相机
        private void WatchConnecting12()
        {
            while (true)  //持续不断监听客户端发来的请求
            {
                socConnection12 = socketWatch12.Accept();
                // textBox1.AppendText("客户端连接成功" + "\r\n");
                //创建一个通信线程 
                ParameterizedThreadStart pts12 = new ParameterizedThreadStart(ServerRecMsg12);
                Thread thr12 = new Thread(pts12);
                thr12.IsBackground = true;
                //启动线程
                thr12.Start(socConnection12);
            }
        }
        //机尾③号相机
        private void WatchConnecting13()
        {
            while (true)  //持续不断监听客户端发来的请求
            {
                socConnection13 = socketWatch13.Accept();
                // textBox1.AppendText("客户端连接成功" + "\r\n");
                //创建一个通信线程 
                ParameterizedThreadStart pts13 = new ParameterizedThreadStart(ServerRecMsg13);
                Thread thr13 = new Thread(pts13);
                thr13.IsBackground = true;
                //启动线程
                thr13.Start(socConnection13);
            }
        }

        /// <summary>
        /// 监听客户端发来的请求
        /// </summary>
        //重锤①号相机
        private void WatchConnecting21()
        {
            while (true)  //持续不断监听客户端发来的请求
            {
                socConnection21 = socketWatch21.Accept();
                // textBox1.AppendText("客户端连接成功" + "\r\n");
                //创建一个通信线程 
                ParameterizedThreadStart pts21 = new ParameterizedThreadStart(ServerRecMsg21);
                Thread thr21 = new Thread(pts21);
                thr21.IsBackground = true;
                //启动线程
                thr21.Start(socConnection21);
            }
        }
        //重锤②号相机
        private void WatchConnecting22()
        {
            while (true)  //持续不断监听客户端发来的请求
            {
                socConnection22 = socketWatch22.Accept();
                // textBox1.AppendText("客户端连接成功" + "\r\n");
                //创建一个通信线程 
                ParameterizedThreadStart pts22 = new ParameterizedThreadStart(ServerRecMsg22);
                Thread thr22 = new Thread(pts22);
                thr22.IsBackground = true;
                //启动线程
                thr22.Start(socConnection22);
            }
        }
        //重锤③号相机
        private void WatchConnecting23()
        {
            while (true)  //持续不断监听客户端发来的请求
            {
                socConnection23 = socketWatch23.Accept();
                // textBox1.AppendText("客户端连接成功" + "\r\n");
                //创建一个通信线程 
                ParameterizedThreadStart pts23 = new ParameterizedThreadStart(ServerRecMsg23);
                Thread thr23 = new Thread(pts23);
                thr23.IsBackground = true;
                //启动线程
                thr23.Start(socConnection23);
            }
        }

        /// <summary>
        /// 监听客户端发来的请求
        /// </summary>
        //机头①号相机
        private void WatchConnecting31()
        {
            while (true)  //持续不断监听客户端发来的请求
            {
                socConnection31 = socketWatch31.Accept();
                // textBox1.AppendText("客户端连接成功" + "\r\n");
                //创建一个通信线程 
                ParameterizedThreadStart pts31 = new ParameterizedThreadStart(ServerRecMsg31);
                Thread thr31 = new Thread(pts31);
                thr31.IsBackground = true;
                //启动线程
                thr31.Start(socConnection31);
            }
        }
        //机头②号相机
        private void WatchConnecting32()
        {
            while (true)  //持续不断监听客户端发来的请求
            {
                socConnection32 = socketWatch32.Accept();
                // textBox1.AppendText("客户端连接成功" + "\r\n");
                //创建一个通信线程 
                ParameterizedThreadStart pts32 = new ParameterizedThreadStart(ServerRecMsg32);
                Thread thr32 = new Thread(pts32);
                thr32.IsBackground = true;
                //启动线程
                thr32.Start(socConnection32);
            }
        }
        //机头③号相机
        private void WatchConnecting33()
        {
            while (true)  //持续不断监听客户端发来的请求
            {
                socConnection33 = socketWatch33.Accept();
                // textBox1.AppendText("客户端连接成功" + "\r\n");
                //创建一个通信线程 
                ParameterizedThreadStart pts33 = new ParameterizedThreadStart(ServerRecMsg33);
                Thread thr33 = new Thread(pts33);
                thr33.IsBackground = true;
                //启动线程
                thr33.Start(socConnection33);
            }
        }
        #endregion

        #region 信息发送
        /// 接收客户端发来的信息 
        /// </summary>
        /// <param name="socketClientPara">客户端套接字对象</param>
        /// 
        //机尾①号相机
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
                    //将发送的字符串信息附加到文本框txtMsg上  
                    textBox9.AppendText(GetCurrentTime() + "  " + strSRecMsg);
                }
            }
            catch
            {
                this.Close();//关闭当前窗体
            }
        }

        //机尾②号相机
        private void ServerRecMsg12(object socketClientPara)
        {
            Socket socketServer12 = socketClientPara as Socket;
            try
            {
                while (true)
                {
                    //创建一个内存缓冲区 其大小为1024*1024字节  即1M
                    byte[] arrServerRecMsg12 = new byte[1024 * 1024];
                    //将接收到的信息存入到内存缓冲区,并返回其字节数组的长度
                    int length12 = socketServer12.Receive(arrServerRecMsg12);
                    //将机器接受到的字节数组转换为人可以读懂的字符串
                    string strSRecMsg12 = Encoding.UTF8.GetString(arrServerRecMsg12, 0, length12);
                    str12 = strSRecMsg12;
                    //将发送的字符串信息附加到文本框txtMsg上  
                    textBox10.AppendText(GetCurrentTime() + "  " + strSRecMsg12);
                }
            }
            catch
            {
                this.Close();//关闭当前窗体
            }
        }
        //机尾③号相机
        private void ServerRecMsg13(object socketClientPara)
        {
            Socket socketServer13 = socketClientPara as Socket;
            try
            {
                while (true)
                {
                    //创建一个内存缓冲区 其大小为1024*1024字节  即1M
                    byte[] arrServerRecMsg13 = new byte[1024 * 1024];
                    //将接收到的信息存入到内存缓冲区,并返回其字节数组的长度
                    int length13 = socketServer13.Receive(arrServerRecMsg13);
                    //将机器接受到的字节数组转换为人可以读懂的字符串
                    string strSRecMsg13 = Encoding.UTF8.GetString(arrServerRecMsg13, 0, length13);
                    str13 = strSRecMsg13;
                    //将发送的字符串信息附加到文本框txtMsg上  
                    textBox14.AppendText(GetCurrentTime() + "  " + strSRecMsg13);
                }
            }
            catch
            {
                this.Close();//关闭当前窗体
            }
        }

        /// 接收客户端发来的信息 
        /// </summary>
        /// <param name="socketClientPara">客户端套接字对象</param>
        /// 
        //重锤①号相机
        private void ServerRecMsg21(object socketClientPara)
        {
            Socket socketServer21 = socketClientPara as Socket;
            try
            {
                while (true)
                {
                    //创建一个内存缓冲区 其大小为1024*1024字节  即1M
                    byte[] arrServerRecMsg21 = new byte[1024 * 1024];
                    //将接收到的信息存入到内存缓冲区,并返回其字节数组的长度
                    int length21 = socketServer21.Receive(arrServerRecMsg21);

                    //将机器接受到的字节数组转换为人可以读懂的字符串
                    string strSRecMsg21 = Encoding.UTF8.GetString(arrServerRecMsg21, 0, length21);
                    str21 = strSRecMsg21;
                    //将发送的字符串信息附加到文本框txtMsg上  
                    textBox15.AppendText(GetCurrentTime() + "  " + strSRecMsg21);
                }
            }
            catch
            {
                this.Close();//关闭当前窗体
            }
        }

        //重锤②号相机
        private void ServerRecMsg22(object socketClientPara)
        {
            Socket socketServer22 = socketClientPara as Socket;
            try
            {
                while (true)
                {
                    //创建一个内存缓冲区 其大小为1024*1024字节  即1M
                    byte[] arrServerRecMsg22 = new byte[1024 * 1024];
                    //将接收到的信息存入到内存缓冲区,并返回其字节数组的长度
                    int length22 = socketServer22.Receive(arrServerRecMsg22);
                    //将机器接受到的字节数组转换为人可以读懂的字符串
                    string strSRecMsg22 = Encoding.UTF8.GetString(arrServerRecMsg22, 0, length22);
                    str22 = strSRecMsg22;
                    //将发送的字符串信息附加到文本框txtMsg上  
                    textBox16.AppendText(GetCurrentTime() + "  " + strSRecMsg22);
                }
            }
            catch
            {
                this.Close();//关闭当前窗体
            }
        }
        //重锤③号相机
        private void ServerRecMsg23(object socketClientPara)
        {
            Socket socketServer23 = socketClientPara as Socket;
            try
            {
                while (true)
                {
                    //创建一个内存缓冲区 其大小为1024*1024字节  即1M
                    byte[] arrServerRecMsg23 = new byte[1024 * 1024];
                    //将接收到的信息存入到内存缓冲区,并返回其字节数组的长度
                    int length23 = socketServer23.Receive(arrServerRecMsg23);
                    //将机器接受到的字节数组转换为人可以读懂的字符串
                    string strSRecMsg23 = Encoding.UTF8.GetString(arrServerRecMsg23, 0, length23);
                    str23 = strSRecMsg23;
                    //将发送的字符串信息附加到文本框txtMsg上  
                     textBox17.AppendText(GetCurrentTime() + "  " + strSRecMsg23);
                }
            }
            catch
            {
                this.Close();//关闭当前窗体
            }
        }

        /// 接收客户端发来的信息 
        /// </summary>
        /// <param name="socketClientPara">客户端套接字对象</param>
        /// 
        //机头①号相机
        private void ServerRecMsg31(object socketClientPara)
        {
            Socket socketServer31 = socketClientPara as Socket;
            try
            {
                while (true)
                {
                    //创建一个内存缓冲区 其大小为1024*1024字节  即1M
                    byte[] arrServerRecMsg31 = new byte[1024 * 1024];
                    //将接收到的信息存入到内存缓冲区,并返回其字节数组的长度
                    int length31 = socketServer31.Receive(arrServerRecMsg31);

                    //将机器接受到的字节数组转换为人可以读懂的字符串
                    string strSRecMsg31 = Encoding.UTF8.GetString(arrServerRecMsg31, 0, length31);
                    str31 = strSRecMsg31;
                    //将发送的字符串信息附加到文本框txtMsg上  
                    textBox18.AppendText(GetCurrentTime() + "  " + strSRecMsg31);
                }
            }
            catch
            {
                this.Close();//关闭当前窗体
            }
        }

        //机头②号相机
        private void ServerRecMsg32(object socketClientPara)
        {
            Socket socketServer32 = socketClientPara as Socket;
            try
            {
                while (true)
                {
                    //创建一个内存缓冲区 其大小为1024*1024字节  即1M
                    byte[] arrServerRecMsg32 = new byte[1024 * 1024];
                    //将接收到的信息存入到内存缓冲区,并返回其字节数组的长度
                    int length32 = socketServer32.Receive(arrServerRecMsg32);
                    //将机器接受到的字节数组转换为人可以读懂的字符串
                    string strSRecMsg32 = Encoding.UTF8.GetString(arrServerRecMsg32, 0, length32);
                    str32 = strSRecMsg32;
                    //将发送的字符串信息附加到文本框txtMsg上  
                    textBox19.AppendText(GetCurrentTime() + "  " + strSRecMsg32);
                }
            }
            catch
            {
                this.Close();//关闭当前窗体
            }
        }
        //机头③号相机
        private void ServerRecMsg33(object socketClientPara)
        {
            Socket socketServer33 = socketClientPara as Socket;
            try
            {
                while (true)
                {
                    //创建一个内存缓冲区 其大小为1024*1024字节  即1M
                    byte[] arrServerRecMsg33 = new byte[1024 * 1024];
                    //将接收到的信息存入到内存缓冲区,并返回其字节数组的长度
                    int length33 = socketServer33.Receive(arrServerRecMsg33);
                    //将机器接受到的字节数组转换为人可以读懂的字符串
                    string strSRecMsg33 = Encoding.UTF8.GetString(arrServerRecMsg33, 0, length33);
                    str33 = strSRecMsg33;
                    //将发送的字符串信息附加到文本框txtMsg上  
                     textBox20.AppendText(GetCurrentTime() + "  " + strSRecMsg33);
                }
            }
            catch
            {
                this.Close();//关闭当前窗体
            }
        }

        #endregion

        //获取系统时间
        private DateTime GetCurrentTime()
        {
            DateTime currentTime = new DateTime();
            currentTime = DateTime.Now;
            return currentTime;
        }
        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        
        List<string> fileList = new List<string>();     //播放列表
        //S1播放
        private void button5_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = this.listBox3.Text;
            axWindowsMediaPlayer1.URL = this.textBox11.Text;
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

        //S2播放
        private void button7_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer2.URL = this.listBox3.Text;
            axWindowsMediaPlayer2.URL = this.textBox12.Text;
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

        //触发4
        private void button6_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        //触发5按钮
        private void button8_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer2.Ctlcontrols.stop();
        }

        //退出按钮
        private void button12_Click(object sender, EventArgs e)
        {
            this.Close();
            
            SoundPlayer player = new SoundPlayer();
            player.Stop();
             
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox2.ImageLocation = pathlist11[(index11++) % pathlist11.Length];
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }
        //报警日志
        //添加日志输出类output
       /* public void output(string log)
        {
            //如果日志信息长度超过100行，则自动清空
            if (textBox1.GetLineFromCharIndex(textBox13.Text.Length) > 100)
                textBox1.Text = "";
            //添加日志
            textBox1.AppendText(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss ") + log + "\r\n");
            write(log);
        }
        //添加记录日志类write
        public void write(string msg)
        {
            //获取当前程序目录
            string logPath = Path.GetDirectoryName(Application.ExecutablePath);
            //新建文件
            System.IO.StreamWriter sw = System.IO.File.AppendText(logPath + "/报警日志.txt");
            //写入日志信息
            sw.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss ") + msg);
            //关闭文件
            sw.Close();
            sw.Dispose();
        }*/

        //触发1
        private void button9_Click(object sender, EventArgs e)
        {
            //语音报警
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = @"C:\Users\john\Desktop\TCP_Picture\08.wav";
            player.Load(); //同步加载声音  
            //player.Play(); //启用新线程播放  
            player.PlayLooping(); //循环播放模式  
            //player.PlaySync(); //UI线程同步播放 

            output11(str + "\r\n" + "皮带机尾处①号裂缝报警！！！");
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            pictureBox4.ImageLocation = pathlist12[(index12++) % pathlist12.Length];
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
             //P1播放
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                double d1 = Convert.ToDouble(axWindowsMediaPlayer1.currentMedia.duration.ToString());
                double d2 = Convert.ToDouble(axWindowsMediaPlayer1.Ctlcontrols.currentPosition.ToString()) + 1;
                if (d1 <= d2)
                {
                    nextMusic(listBox1.SelectedIndex);
                }
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            pictureBox3.ImageLocation = pathlist13[(index13++) % pathlist13.Length];
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            pictureBox6.ImageLocation = pathlist21[(index21++) % pathlist21.Length];
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            pictureBox5.ImageLocation = pathlist22[(index22++) % pathlist22.Length];
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = pathlist23[(index23++) % pathlist23.Length];
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            pictureBox9.ImageLocation = pathlist31[(index31++) % pathlist31.Length];
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void timer9_Tick(object sender, EventArgs e)
        {
            pictureBox8.ImageLocation = pathlist32[(index32++) % pathlist32.Length];
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void timer10_Tick(object sender, EventArgs e)
        {
            pictureBox7.ImageLocation = pathlist33[(index33++) % pathlist33.Length];
        }

        //机尾①号报警日志
        //添加日志输出类output
        public void output11(string log11)
        {
            //如果日志信息长度超过100行，则自动清空
            if (textBox1.GetLineFromCharIndex(textBox1.Text.Length) > 100)
                textBox1.Text = "";
            //添加日志
            textBox1.AppendText(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss ") + log11 + "\r\n");
            write11(log11);
        }
        //添加记录日志类write
        public void write11(string msg11)
        {
            //获取当前程序目录
            string logPath11 = Path.GetDirectoryName(Application.ExecutablePath);
            //新建文件
            System.IO.StreamWriter sw11 = System.IO.File.AppendText(logPath11 + "/皮带机尾处①号撕裂报警日志.txt");
            //写入日志信息
            sw11.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss ") + msg11);
            //关闭文件
            sw11.Close();
            sw11.Dispose();
        }

        //机尾②号报警日志
        //添加日志输出类output
        public void output12(string log12)
        {
            //如果日志信息长度超过100行，则自动清空
            if (textBox4.GetLineFromCharIndex(textBox4.Text.Length) > 100)
                textBox4.Text = "";
            //添加日志
            textBox4.AppendText(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss ") + log12 + "\r\n");
            write12(log12);
        }
        //添加记录日志类write
        public void write12(string msg12)
        {
            //获取当前程序目录
            string logPath12 = Path.GetDirectoryName(Application.ExecutablePath);
            //新建文件
            System.IO.StreamWriter sw12 = System.IO.File.AppendText(logPath12 + "/皮带机尾处②号撕裂报警日志.txt");
            //写入日志信息
            sw12.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss ") + msg12);
            //关闭文件
            sw12.Close();
            sw12.Dispose();
        }
        //机尾③号报警日志
        //添加日志输出类output
        public void output13(string log13)
        {
            //如果日志信息长度超过100行，则自动清空
            if (textBox13.GetLineFromCharIndex(textBox13.Text.Length) > 100)
                textBox13.Text = "";
            //添加日志
            textBox13.AppendText(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss ") + log13 + "\r\n");
            write13(log13);
        }
        //添加记录日志类write
        public void write13(string msg13)
        {
            //获取当前程序目录
            string logPath13 = Path.GetDirectoryName(Application.ExecutablePath);
            //新建文件
            System.IO.StreamWriter sw13 = System.IO.File.AppendText(logPath13 + "/皮带机尾处③号撕裂报警日志.txt");
            //写入日志信息
            sw13.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss ") + msg13);
            //关闭文件
            sw13.Close();
            sw13.Dispose();
        }

        //重锤①号报警日志
        //添加日志输出类output
        public void output21(string log21)
        {
            //如果日志信息长度超过100行，则自动清空
            if (textBox7.GetLineFromCharIndex(textBox7.Text.Length) > 100)
                textBox7.Text = "";
            //添加日志
            textBox7.AppendText(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss ") + log21 + "\r\n");
            write21(log21);
        }
        //添加记录日志类write
        public void write21(string msg21)
        {
            //获取当前程序目录
            string logPath21 = Path.GetDirectoryName(Application.ExecutablePath);
            //新建文件
            System.IO.StreamWriter sw21 = System.IO.File.AppendText(logPath21 + "/皮带重锤处①号撕裂报警日志.txt");
            //写入日志信息
            sw21.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss ") + msg21);
            //关闭文件
            sw21.Close();
            sw21.Dispose();
        }

        //重锤②号报警日志
        //添加日志输出类output
        public void output22(string log22)
        {
            //如果日志信息长度超过100行，则自动清空
            if (textBox6.GetLineFromCharIndex(textBox6.Text.Length) > 100)
                textBox6.Text = "";
            //添加日志
            textBox6.AppendText(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss ") + log22 + "\r\n");
            write22(log22);
        }
        //添加记录日志类write
        public void write22(string msg22)
        {
            //获取当前程序目录
            string logPath22 = Path.GetDirectoryName(Application.ExecutablePath);
            //新建文件
            System.IO.StreamWriter sw22 = System.IO.File.AppendText(logPath22 + "/皮带重锤处②号撕裂报警日志.txt");
            //写入日志信息
            sw22.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss ") + msg22);
            //关闭文件
            sw22.Close();
            sw22.Dispose();
        }
        //重锤③号报警日志
        //添加日志输出类output
        public void output23(string log23)
        {
            //如果日志信息长度超过100行，则自动清空
            if (textBox5.GetLineFromCharIndex(textBox5.Text.Length) > 100)
                textBox5.Text = "";
            //添加日志
            textBox5.AppendText(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss ") + log23 + "\r\n");
            write23(log23);
        }
        //添加记录日志类write
        public void write23(string msg23)
        {
            //获取当前程序目录
            string logPath23 = Path.GetDirectoryName(Application.ExecutablePath);
            //新建文件
            System.IO.StreamWriter sw23 = System.IO.File.AppendText(logPath23 + "/皮带重锤处③号撕裂报警日志.txt");
            //写入日志信息
            sw23.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss ") + msg23);
            //关闭文件
            sw23.Close();
            sw23.Dispose();
        }

        //机头①号报警日志
        //添加日志输出类output
        public void output31(string log31)
        {
            //如果日志信息长度超过100行，则自动清空
            if (textBox8.GetLineFromCharIndex(textBox8.Text.Length) > 100)
                textBox8.Text = "";
            //添加日志
            textBox8.AppendText(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss ") + log31 + "\r\n");
            write31(log31);
        }
        //添加记录日志类write
        public void write31(string msg31)
        {
            //获取当前程序目录
            string logPath31 = Path.GetDirectoryName(Application.ExecutablePath);
            //新建文件
            System.IO.StreamWriter sw31 = System.IO.File.AppendText(logPath31 + "/皮带机头处①号撕裂报警日志.txt");
            //写入日志信息
            sw31.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss ") + msg31);
            //关闭文件
            sw31.Close();
            sw31.Dispose();
        }

        //机头②号报警日志
        //添加日志输出类output
        public void output32(string log32)
        {
            //如果日志信息长度超过100行，则自动清空
            if (textBox3.GetLineFromCharIndex(textBox3.Text.Length) > 100)
                textBox3.Text = "";
            //添加日志
            textBox3.AppendText(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss ") + log32 + "\r\n");
            write32(log32);
        }
        //添加记录日志类write
        public void write32(string msg32)
        {
            //获取当前程序目录
            string logPath32 = Path.GetDirectoryName(Application.ExecutablePath);
            //新建文件
            System.IO.StreamWriter sw32 = System.IO.File.AppendText(logPath32 + "/皮带机头处②号撕裂报警日志.txt");
            //写入日志信息
            sw32.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss ") + msg32);
            //关闭文件
            sw32.Close();
            sw32.Dispose();
        }
        //机头③号报警日志
        //添加日志输出类output
        public void output33(string log33)
        {
            //如果日志信息长度超过100行，则自动清空
            if (textBox2.GetLineFromCharIndex(textBox2.Text.Length) > 100)
                textBox2.Text = "";
            //添加日志
            textBox2.AppendText(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss ") + log33 + "\r\n");
            write34(log33);
        }
        //添加记录日志类write
        public void write34(string msg33)
        {
            //获取当前程序目录
            string logPath33 = Path.GetDirectoryName(Application.ExecutablePath);
            //新建文件
            System.IO.StreamWriter sw33 = System.IO.File.AppendText(logPath33 + "/皮带机头处③号撕裂报警日志.txt");
            //写入日志信息
            sw33.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss ") + msg33);
            //关闭文件
            sw33.Close();
            sw33.Dispose();
        }

        //触发2
        private void button17_Click(object sender, EventArgs e)
        {
            //语音报警
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = @"C:\Users\john\Desktop\TCP_Picture\08.wav";
            player.Load(); //同步加载声音  
            //player.Play(); //启用新线程播放  
            player.PlayLooping(); //循环播放模式  
            output12(str12 + "\r\n" + "皮带机尾处②号裂缝报警");
        }
        //触发3
        private void button14_Click(object sender, EventArgs e)
        {
            //语音报警
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = @"C:\Users\john\Desktop\TCP_Picture\08.wav";
            player.Load(); //同步加载声音  
            //player.Play(); //启用新线程播放  
            player.PlayLooping(); //循环播放模式 
            output13(str13 + "\r\n" + "皮带机尾处③号裂缝报警");
        }
        //触发4
        private void button6_Click_1(object sender, EventArgs e)
        {
            //语音报警
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = @"C:\Users\john\Desktop\TCP_Picture\08.wav";
            player.Load(); //同步加载声音  
            //player.Play(); //启用新线程播放  
            player.PlayLooping(); //循环播放模式 
            output21(str21 + "\r\n" + "皮带重锤处①号裂缝报警");
        }

        //触发5
        private void button8_Click_1(object sender, EventArgs e)
        {
            //语音报警
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = @"C:\Users\john\Desktop\TCP_Picture\08.wav";
            player.Load(); //同步加载声音  
            //player.Play(); //启用新线程播放  
            player.PlayLooping(); //循环播放模式 
            output22(str22 + "\r\n" + "皮带重锤处②号裂缝报警");
        }

        //触发6
        private void button10_Click(object sender, EventArgs e)
        {
            //语音报警
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = @"C:\Users\john\Desktop\TCP_Picture\08.wav";
            player.Load(); //同步加载声音  
            //player.Play(); //启用新线程播放  
            player.PlayLooping(); //循环播放模式 
            output23(str23 + "\r\n" + "皮带重锤处③号裂缝报警");
        }

        //触发7
        private void button13_Click(object sender, EventArgs e)
        {
            //语音报警
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = @"C:\Users\john\Desktop\TCP_Picture\08.wav";
            player.Load(); //同步加载声音  
            //player.Play(); //启用新线程播放  
            player.PlayLooping(); //循环播放模式 
            output31(str31 + "\r\n" + "皮带机头处①号裂缝报警");
        }

        //触发8
        private void button15_Click(object sender, EventArgs e)
        {
            //语音报警
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = @"C:\Users\john\Desktop\TCP_Picture\08.wav";
            player.Load(); //同步加载声音  
            //player.Play(); //启用新线程播放  
            player.PlayLooping(); //循环播放模式 
            output32(str32 + "\r\n" + "皮带机头处②号裂缝报警");
        }

        //触发9
        private void button16_Click(object sender, EventArgs e)
        {
            //语音报警
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = @"C:\Users\john\Desktop\TCP_Picture\08.wav";
            player.Load(); //同步加载声音  
            //player.Play(); //启用新线程播放  
            player.PlayLooping(); //循环播放模式 
            output33(str33 + "\r\n" + "皮带机头处③号裂缝报警");
        }

        //是否有撕裂
        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (textBox9.Text != "")
            {
                timer2.Interval = 1000;//设置timer1控件时间间隔为1000ms即1秒
                timer2.Start();//开始
            }
            else if (textBox9.Text == "")
            {
                timer2.Stop();
                Image image = Image.FromFile("F:\\showpicture\\g_1.jpg");
                pictureBox2.Image = image;
            }
            button9.PerformClick();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (textBox10.Text != "")
            {
                timer3.Interval = 1000;//设置timer1控件时间间隔为1000ms即1秒
                timer3.Start();//开始
            }
            else if (textBox10.Text == "")
            {
                timer3.Stop();
                Image image = Image.FromFile("F:\\showpicture\\g_1.jpg");
                pictureBox3.Image = image;
            }
            button17.PerformClick();
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            if (textBox14.Text != "")
            {
                timer4.Interval = 1000;//设置timer1控件时间间隔为1000ms即1秒
                timer4.Start();//开始
            }
            else if (textBox14.Text == "")
            {
                timer4.Stop();
                Image image = Image.FromFile("F:\\showpicture\\g_1.jpg");
                pictureBox4.Image = image;
            }
            button14.PerformClick();
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            if (textBox15.Text != "")
            {
                timer5.Interval = 1000;//设置timer1控件时间间隔为1000ms即1秒
                timer5.Start();//开始
            }
            else if (textBox15.Text == "")
            {
                timer5.Stop();
                Image image = Image.FromFile("F:\\showpicture\\g_1.jpg");
                pictureBox6.Image = image;
            }
            button6.PerformClick();
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            if (textBox16.Text != "")
            {
                timer6.Interval = 1000;//设置timer1控件时间间隔为1000ms即1秒
                timer6.Start();//开始
            }
            else if (textBox16.Text == "")
            {
                timer6.Stop();
                Image image = Image.FromFile("F:\\showpicture\\g_1.jpg");
                pictureBox5.Image = image;
            }
            button8.PerformClick();
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            if (textBox17.Text != "")
            {
                timer7.Interval = 1000;//设置timer1控件时间间隔为1000ms即1秒
                timer7.Start();//开始
            }
            else if (textBox17.Text == "")
            {
                timer7.Stop();
                Image image = Image.FromFile("F:\\showpicture\\g_1.jpg");
                pictureBox1.Image = image;
            }
            button10.PerformClick();
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {
            if (textBox18.Text != "")
            {
                timer8.Interval = 1000;//设置timer1控件时间间隔为1000ms即1秒
                timer8.Start();//开始
            }
            else if (textBox18.Text == "")
            {
                timer8.Stop();
                Image image = Image.FromFile("F:\\showpicture\\g_1.jpg");
                pictureBox9.Image = image;
            }
            button13.PerformClick();
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {
            if (textBox19.Text != "")
            {
                timer9.Interval = 1000;//设置timer1控件时间间隔为1000ms即1秒
                timer9.Start();//开始
            }
            else if (textBox19.Text == "")
            {
                timer9.Stop();
                Image image = Image.FromFile("F:\\showpicture\\g_1.jpg");
                pictureBox8.Image = image;
            }
            button15.PerformClick();
        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {
            if (textBox20.Text != "")
            {
                timer10.Interval = 1000;//设置timer1控件时间间隔为1000ms即1秒
                timer10.Start();//开始
            }
            else if (textBox20.Text == "")
            {
                timer10.Stop();
                Image image = Image.FromFile("F:\\showpicture\\g_1.jpg");
                pictureBox7.Image = image;
            }
            button16.PerformClick();
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        //机尾1号启动
        private void button18_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button18.Enabled = false;
            button12.Enabled = true;

            if (textBox1.Text != "")
            {
                timer2.Interval = 1000;//设置timer1控件时间间隔为1000ms即1秒
                timer2.Start();//开始
            }
            button2.Enabled = true;
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
            threadWatch = new Thread(WatchConnecting);            //将窗体线程设置为与后台同步
            threadWatch.IsBackground = true;
            //启动线程
            threadWatch.Start();
            //启动线程后 txtMsg文本框显示相应提示
            //textBox1.AppendText("开始监听客户端传来的信息!" + "\r\n");
        }

        //机尾3号启动
        private void button19_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button19.Enabled = false;
            button12.Enabled = true;

            if (textBox13.Text != "")
            {
                timer4.Interval = 1000;//设置timer1控件时间间隔为1000ms即1秒
                timer4.Start();//开始
            }
            button2.Enabled = true;
            //定义一个套接字用于监听客户端发来的信息  包含3个参数(IP4寻址协议,流式连接,TCP协议)
            socketWatch13 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //服务端发送信息 需要1个IP地址和端口号
            IPAddress ipaddress13 = IPAddress.Parse(comboBox6.Text.Trim()); //获取文本框输入的IP地址
            //将IP地址和端口号绑定到网络节点endpoint上 
            IPEndPoint endpoint13 = new IPEndPoint(ipaddress13, int.Parse(comboBox5.Text.Trim())); //获取文本框上输入的端口号
            //监听绑定的网络节点
            socketWatch13.Bind(endpoint13);
            //将套接字的监听队列长度限制为20
            socketWatch13.Listen(20);
            //创建一个监听线程 
            threadWatch13 = new Thread(WatchConnecting13);
            //将窗体线程设置为与后台同步
            threadWatch13.IsBackground = true;
            //启动线程
            threadWatch13.Start();
            //启动线程后 txtMsg文本框显示相应提示
            //textBox1.AppendText("开始监听客户端传来的信息!" + "\r\n");
        }

        //重锤1号启动
        private void button22_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button22.Enabled = false;
            button12.Enabled = true;

            if (textBox7.Text != "")
            {
                timer5.Interval = 1000;//设置timer1控件时间间隔为1000ms即1秒
                timer5.Start();//开始
            }
            button2.Enabled = true;
            //定义一个套接字用于监听客户端发来的信息  包含3个参数(IP4寻址协议,流式连接,TCP协议)
            socketWatch21 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //服务端发送信息 需要1个IP地址和端口号
            IPAddress ipaddress21 = IPAddress.Parse(comboBox8.Text.Trim()); //获取文本框输入的IP地址
            //将IP地址和端口号绑定到网络节点endpoint上 
            IPEndPoint endpoint21 = new IPEndPoint(ipaddress21, int.Parse(comboBox7.Text.Trim())); //获取文本框上输入的端口号
            //监听绑定的网络节点
            socketWatch21.Bind(endpoint21);
            //将套接字的监听队列长度限制为20
            socketWatch21.Listen(20);
            //创建一个监听线程 
            threadWatch21 = new Thread(WatchConnecting21);
            //将窗体线程设置为与后台同步
            threadWatch21.IsBackground = true;
            //启动线程
            threadWatch21.Start();
            //启动线程后 txtMsg文本框显示相应提示
            //textBox1.AppendText("开始监听客户端传来的信息!" + "\r\n");
        }
        
        //重锤2号启动
        private void button21_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button21.Enabled = false;
            button12.Enabled = true;

            if (textBox6.Text != "")
            {
                timer6.Interval = 1000;//设置timer1控件时间间隔为1000ms即1秒
                timer6.Start();//开始
            }
            button2.Enabled = true;
            //定义一个套接字用于监听客户端发来的信息  包含3个参数(IP4寻址协议,流式连接,TCP协议)
            socketWatch22 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //服务端发送信息 需要1个IP地址和端口号
            IPAddress ipaddress22 = IPAddress.Parse(comboBox10.Text.Trim()); //获取文本框输入的IP地址
            //将IP地址和端口号绑定到网络节点endpoint上 
            IPEndPoint endpoint22 = new IPEndPoint(ipaddress22, int.Parse(comboBox9.Text.Trim())); //获取文本框上输入的端口号
            //监听绑定的网络节点
            socketWatch22.Bind(endpoint22);
            //将套接字的监听队列长度限制为20
            socketWatch22.Listen(20);
            //创建一个监听线程 
            threadWatch22 = new Thread(WatchConnecting22);
            //将窗体线程设置为与后台同步
            threadWatch22.IsBackground = true;
            //启动线程
            threadWatch22.Start();
            //启动线程后 txtMsg文本框显示相应提示
            //textBox1.AppendText("开始监听客户端传来的信息!" + "\r\n");
        }
        
        //重锤3号启动
        private void button20_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button20.Enabled = false;
            button12.Enabled = true;

            if (textBox5.Text != "")
            {
                timer7.Interval = 1000;//设置timer1控件时间间隔为1000ms即1秒
                timer7.Start();//开始
            }
            button2.Enabled = true;
            //定义一个套接字用于监听客户端发来的信息  包含3个参数(IP4寻址协议,流式连接,TCP协议)
            socketWatch23 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //服务端发送信息 需要1个IP地址和端口号
            IPAddress ipaddress23 = IPAddress.Parse(comboBox12.Text.Trim()); //获取文本框输入的IP地址
            //将IP地址和端口号绑定到网络节点endpoint上 
            IPEndPoint endpoint23 = new IPEndPoint(ipaddress23, int.Parse(comboBox11.Text.Trim())); //获取文本框上输入的端口号
            //监听绑定的网络节点
            socketWatch23.Bind(endpoint23);
            //将套接字的监听队列长度限制为20
            socketWatch23.Listen(20);
            //创建一个监听线程 
            threadWatch23 = new Thread(WatchConnecting23);
            //将窗体线程设置为与后台同步
            threadWatch23.IsBackground = true;
            //启动线程
            threadWatch23.Start();
            //启动线程后 txtMsg文本框显示相应提示
            //textBox1.AppendText("开始监听客户端传来的信息!" + "\r\n");
        }
        
        //机头1号启动
        private void button25_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button25.Enabled = false;
            button12.Enabled = true;

            if (textBox8.Text != "")
            {
                timer8.Interval = 1000;//设置timer1控件时间间隔为1000ms即1秒
                timer8.Start();//开始
            }
            button2.Enabled = true;
            //定义一个套接字用于监听客户端发来的信息  包含3个参数(IP4寻址协议,流式连接,TCP协议)
            socketWatch31 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //服务端发送信息 需要1个IP地址和端口号
            IPAddress ipaddress31 = IPAddress.Parse(comboBox14.Text.Trim()); //获取文本框输入的IP地址
            //将IP地址和端口号绑定到网络节点endpoint上 
            IPEndPoint endpoint31 = new IPEndPoint(ipaddress31, int.Parse(comboBox13.Text.Trim())); //获取文本框上输入的端口号
            //监听绑定的网络节点
            socketWatch31.Bind(endpoint31);
            //将套接字的监听队列长度限制为20
            socketWatch31.Listen(20);
            //创建一个监听线程 
            threadWatch31 = new Thread(WatchConnecting31);
            //将窗体线程设置为与后台同步
            threadWatch31.IsBackground = true;
            //启动线程
            threadWatch31.Start();
            //启动线程后 txtMsg文本框显示相应提示
            //textBox1.AppendText("开始监听客户端传来的信息!" + "\r\n");
        }
        //机头2号启动
        private void button24_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button24.Enabled = false;
            button12.Enabled = true;

            if (textBox3.Text != "")
            {
                timer9.Interval = 1000;//设置timer1控件时间间隔为1000ms即1秒
                timer9.Start();//开始
            }
            button2.Enabled = true;
            //定义一个套接字用于监听客户端发来的信息  包含3个参数(IP4寻址协议,流式连接,TCP协议)
            socketWatch32 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //服务端发送信息 需要1个IP地址和端口号
            IPAddress ipaddress32 = IPAddress.Parse(comboBox16.Text.Trim()); //获取文本框输入的IP地址
            //将IP地址和端口号绑定到网络节点endpoint上 
            IPEndPoint endpoint32 = new IPEndPoint(ipaddress32, int.Parse(comboBox15.Text.Trim())); //获取文本框上输入的端口号
            //监听绑定的网络节点
            socketWatch32.Bind(endpoint32);
            //将套接字的监听队列长度限制为20
            socketWatch32.Listen(20);
            //创建一个监听线程 
            threadWatch32 = new Thread(WatchConnecting32);
            //将窗体线程设置为与后台同步
            threadWatch32.IsBackground = true;
            //启动线程
            threadWatch32.Start();
            //启动线程后 txtMsg文本框显示相应提示
            //textBox1.AppendText("开始监听客户端传来的信息!" + "\r\n");
        }
        //机头3号启动
        private void button23_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button23.Enabled = false;
            button12.Enabled = true;

            if (textBox2.Text != "")
            {
                timer10.Interval = 1000;//设置timer1控件时间间隔为1000ms即1秒
                timer10.Start();//开始
            }
            button2.Enabled = true;
            //定义一个套接字用于监听客户端发来的信息  包含3个参数(IP4寻址协议,流式连接,TCP协议)
            socketWatch33 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //服务端发送信息 需要1个IP地址和端口号
            IPAddress ipaddress33 = IPAddress.Parse(comboBox18.Text.Trim()); //获取文本框输入的IP地址
            //将IP地址和端口号绑定到网络节点endpoint上 
            IPEndPoint endpoint33 = new IPEndPoint(ipaddress33, int.Parse(comboBox17.Text.Trim())); //获取文本框上输入的端口号
            //监听绑定的网络节点
            socketWatch33.Bind(endpoint33);
            //将套接字的监听队列长度限制为20
            socketWatch33.Listen(20);
            //创建一个监听线程 
            threadWatch33 = new Thread(WatchConnecting33);
            //将窗体线程设置为与后台同步
            threadWatch33.IsBackground = true;
            //启动线程
            threadWatch33.Start();
            //启动线程后 txtMsg文本框显示相应提示
            //textBox1.AppendText("开始监听客户端传来的信息!" + "\r\n");
        }

        //刷新按钮
        private void button26_Click(object sender, EventArgs e)
        {
            DirectoryInfo theFolder = new DirectoryInfo(@"C:\surveillance video");
            DirectoryInfo[] dirInfo = theFolder.GetDirectories();
            //遍历文件夹
            foreach (DirectoryInfo NextFolder in dirInfo)
            {
                // this.listBox1.Items.Add(NextFolder.Name);
                FileInfo[] fileInfo = NextFolder.GetFiles();
                foreach (FileInfo NextFile in fileInfo)  //遍历文件
                    this.listBox3.Items.Add(@"C:\surveillance video" + "\\" + NextFolder.Name + "\\" + NextFile.Name);
            }
        }

        //监控网页按钮
        private void button27_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://192.168.0.250/doc/page/preview.asp");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
    }
}
