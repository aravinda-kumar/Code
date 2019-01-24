using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;

namespace socket
{
    public partial class 服务器端 : Form
    {
        public 服务器端()
        {
            InitializeComponent();
        }
        //定义回调：解决跨线程访问问题
        private delegate void SetTextValueCallBack(string strValue);
        //定义接收客户端发送消息的回调
        private delegate void ReceiveMsgCallBack(string strReceive);
        //声明回调
        private SetTextValueCallBack setCallBack;
        private ReceiveMsgCallBack receiveCallBack;

        //定义、声明回调给combobox控件添加元素
        private delegate void SetCmbCallBack(string strItem);

        //用于通信的socket
        Socket socketSend = null;
        //用于监听的socket
        Socket socketWatch = null;


        //创建监听连接的线程
        Thread AcceptSocketThread;
        //接收客户端发送消息的线程
        Thread threadReceive;

        //开始监听按钮
        private void btn_Listen_Click(object sender, EventArgs e)
        {
            try
            {
                //当点击开始监听的时候，在服务器端创建一个负责监听IP地址和socket号的socket
                socketWatch = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                //获取IP地址
                IPAddress ip = IPAddress.Parse(txtBox_IP.Text.Trim());
                //绑定IP地址和端口号
                IPEndPoint point = new IPEndPoint(ip, Convert.ToInt32(txtBox_Port.Text.Trim()));
                socketWatch.Bind(point);
                txtBox_Log.AppendText("监听成功" + "\r\n");

                //开始监听：设置可以同时连接的最大请求数
                socketWatch.Listen(10);

                //实例化回调
                //txt_Log增加值
                setCallBack = new SetTextValueCallBack(SetTextValue);
                receiveCallBack = new ReceiveMsgCallBack(ReceiveMsg);

                //创建线程
                //StartListen是线程中要执行的方法，socketWatch是线程中方法的参数
                AcceptSocketThread = new Thread(new ParameterizedThreadStart(StartListen));
                AcceptSocketThread.IsBackground = true;
                AcceptSocketThread.Start(socketWatch);
            }
            catch { }
        }
        /// <summary>
        /// 等待客户端连接，并且创建和它通信用的socket
        /// </summary>
        /// <param name="obj"></param>
        private void StartListen(object obj)
        {
            Socket socketWatch = obj as Socket;
            try
            {
                while (true)
                {
                    //等待客户端连接，并且创建和它通信用的socket
                    socketSend = socketWatch.Accept();
                    //获得远程主机的IP地址和端口号
                    string strIP = "远程主机：" + socketSend.RemoteEndPoint + "连接成功";
                    //string strMsg = "远程主机：" + socketSend.RemoteEndPoint + "连接成功";

                    //使用回调
                    //txtBox_Log.AppendText(strIP);
                    txtBox_Log.Invoke(setCallBack, strIP);

                    //定义接收客户端消息的线程
                    threadReceive = new Thread(new ParameterizedThreadStart(Receive));
                    threadReceive.IsBackground = true;
                    threadReceive.Start(socketSend);
                }
            }
            catch { }
        }
        /// <summary>
        /// 服务器端不停的接收消息
        /// </summary>
        /// <param name="obj"></param>
        //Socket socketSend = null;
        private void Receive(object obj)
        {
            try
            {
                socketSend = obj as Socket;
                while (true)
                {
                    //客户端连接成功后，服务器接收客户端发送的消息
                    byte[] buffer = new byte[1024*1024*3];
                    //接收到的有效字节数
                    int count = socketSend.Receive(buffer);
                    if (count == 0)
                    {
                        break;
                    }
                    else
                    {
                        string str = Encoding.Default.GetString(buffer, 0, count);
                        string strReceiveMsg = "接收：" + socketSend.RemoteEndPoint + "发送的消息：" + str;
                        txtBox_Log.Invoke(receiveCallBack, strReceiveMsg);
                    }
                }
            }
            catch{}
        }
        //回调的方法
        private void SetTextValue(string strValue)
        {
            txtBox_Log.AppendText(strValue + "\r\n");
        }
        private void ReceiveMsg(string strMsg)
        {
            txtBox_Log.AppendText(strMsg + "\r\n");
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            socketWatch.Close();
            socketSend.Close();

            //终止线程
            AcceptSocketThread.Abort();
            threadReceive.Abort();
        }

        private void 服务器端_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            txtBox_IP.Text = "127.0.0.1";
            txtBox_Port.Text = "8080";
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<byte> list = new List<byte>();
            string filepath = txtBox_Path.Text.Trim();
            Console.WriteLine("filepath={0}", txtBox_Path.Text.Trim());
            using (FileStream sw = new FileStream(filepath, FileMode.Open, FileAccess.Read))
            {
                byte[] buffer = new byte[1024 * 1024 * 5];
                Console.WriteLine(buffer.Length);
                int r = sw.Read(buffer, 0, buffer.Length);
                Console.WriteLine("r={0}", r);
                list.Add(2);
                list.AddRange(buffer);
                byte[] newbuffer = list.ToArray();
                Console.WriteLine("newbuffer.Length={0}", newbuffer.Length);
                socketSend.Send(newbuffer, 0, r+1, SocketFlags.None);
            }

        }

        private void txtBox_Msg_TextChanged(object sender, EventArgs e)
        {
        }

        private void btn_SendMsg_Click(object sender, EventArgs e)
        {
            try
            {
                string strMsg = txtBox_Msg.Text.Trim();
                byte[] buffer = Encoding.UTF8.GetBytes(strMsg);
                List<byte> list = new List<byte>();
                list.Add(0);
                list.AddRange(buffer);
                byte[] newbuffer = list.ToArray();
                socketSend.Send(newbuffer);
            }
            catch{}
        }

        private void btn_Path_Click(object sender, EventArgs e)
        {
            OpenFileDialog dia = new OpenFileDialog();
            dia.InitialDirectory = @"C:\Users\SHUNCS\Desktop";
            dia.Title = "请选择要发送的文件";
            dia.Filter = "图片文件|*.jpg";
            dia.ShowDialog();
            txtBox_Path.Text = dia.FileName;
            Console.WriteLine(txtBox_Path.Text.Trim());
        }
    }
}
