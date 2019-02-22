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
using System.Threading;
using System.IO;
using System.Diagnostics;

namespace socket_Client
{
    public partial class FormClient : Form
    {
        public FormClient()
        {
            InitializeComponent();
        }

        //定义回调
        private delegate void SetTextCallBack(string strValue);
        //声明
        private SetTextCallBack setCallBack;

        //定义接收服务端发送消息的回调
        private delegate void ReceiveMsgCallBack(string strMsg);
        //声明
        private ReceiveMsgCallBack receiveCallBack;

        //创建连接的Socket
        Socket socketSend;
        //创建接收客户端发送消息的线程
        Thread threadReceive;
        
        //连接按钮
        private void btn_Connect_Click(object sender, EventArgs e)
        {
            try
            {
                //txtBox_Log.Invoke(setCallBack, "开始连接......\r\n");
                txtBox_Log.AppendText("开始连接......\r\n");
                socketSend = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPAddress ip = IPAddress.Parse(txtBox_IP.Text.Trim());
                socketSend.Connect(ip, Convert.ToInt32(txtBox_Port.Text.Trim()));

                //实例化回调
                setCallBack = new SetTextCallBack(SetValue);
                receiveCallBack = new ReceiveMsgCallBack(SetValue);
                txtBox_Log.Invoke(setCallBack, "连接成功\r\n");

                //开启一个新的线程不停的接收服务器发送消息的线程
                threadReceive = new Thread(new ThreadStart(Receive));
                //设置为后台线程
                threadReceive.IsBackground = true;
                threadReceive.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("连接服务端出错:" + ex.ToString());
            }
        }

        private void SetValue(string strValue)
        {
            txtBox_Log.AppendText(strValue + "\r\n");
        }

        //接口服务器发送的消息
        private void Receive()
        {
            try
            {
                while (true)
                {
                    byte[] buffer = new byte[1024 * 1024 * 5];
                    int r = socketSend.Receive(buffer);
                    Console.WriteLine("r={0}", r);
                    if (r == 0)
                    {
                        break;
                    }
                    else
                    {
                        //判断发送的数据的类型
                        if (buffer[0] == 0)//表示发送的是文字消息
                        {
                            string str = Encoding.UTF8.GetString(buffer, 1, r - 1);
                            txtBox_Log.Invoke(receiveCallBack, "接收远程服务器:" + socketSend.RemoteEndPoint + "发送的消息:" + str);
                        }
                        //表示发送的是文本文件
                        if (buffer[0] == 1)
                        {
                            string strPath = Path.GetDirectoryName(Application.ExecutablePath) + "\\log.txt";
                            using (FileStream fsWrite = new FileStream(strPath, FileMode.OpenOrCreate, FileAccess.Write))
                            {
                                fsWrite.Write(buffer, 1, r - 1);
                            }
                            using (StreamReader sr = new StreamReader(strPath, Encoding.Default))
                            {
                                while (sr.ReadLine() != null)
                                    txtBox_Log.AppendText(sr.ReadLine());
                            }
                        }
                        //表示发送的是图片文件
                        if (buffer[0] == 2)
                        {
                            string strPath = Path.GetDirectoryName(Application.ExecutablePath) + "\\log.jpg";
                            using (FileStream fsWrite = new FileStream(strPath, FileMode.OpenOrCreate, FileAccess.Write))
                            {
                                fsWrite.Write(buffer, 1, r - 1);
                            }
                            pic_Receive.ImageLocation = strPath;
                        }
                    }
                }
            }
            catch
            {
            }
        }

        private void FormClient_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            Console.WriteLine("In Load");
            //txtBox_IP.Text = "192.168.0.201";
            //txtBox_Port.Text = "8234";
        }

        //给服务器发送消息
        private void btn_Send_Click(object sender, EventArgs e)
        {
            try
            {
                string strMsg = txtBox_Msg.Text.Trim();
                byte[] buffer = new byte[2048];
                buffer = Encoding.Default.GetBytes(strMsg);
                int receive = socketSend.Send(buffer);
            }
            catch (Exception ex)
            {
                MessageBox.Show("发送消息出错:" + ex.Message);
            }
        }

        private void btn_Path_Click(object sender, EventArgs e)
        {
            OpenFileDialog dia = new OpenFileDialog();
            dia.InitialDirectory = @"E:\JZS\Code\C#\socket_Client\socket_Client\bin\Debug\pic";
            dia.Title = "请选择要发送的文件";
            dia.Filter = "图片文件|*.bmp";
            dia.ShowDialog();
            txtBox_Path.Text = dia.FileName;
            Console.WriteLine(txtBox_Path.Text.Trim());
        }

        private void btn_Path_2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dia = new OpenFileDialog();
            dia.InitialDirectory = @"E:\JZS\Code\C#\socket_Client\socket_Client\bin\Debug\pic";
            dia.Title = "请选择要发送的文件";
            dia.Filter = "图片文件|*.bmp";
            dia.ShowDialog();
            txtBox_Path_2.Text = dia.FileName;
            Console.WriteLine(txtBox_Path_2.Text.Trim());
        }

        private void btn_Path_3_Click(object sender, EventArgs e)
        {
            OpenFileDialog dia = new OpenFileDialog();
            dia.InitialDirectory = @"E:\JZS\Code\C#\socket_Client\socket_Client\bin\Debug\pic";
            dia.Title = "请选择要发送的文件";
            dia.Filter = "图片文件|*.bmp";
            dia.ShowDialog();
            txtBox_Path_3.Text = dia.FileName;
            Console.WriteLine(txtBox_Path_3.Text.Trim());
        }

        private void btn_SendFile_Click(object sender, EventArgs e)
        {
            string filepath = txtBox_Path.Text.Trim();
            #region
            //FileInfo EzoneFile = new FileInfo(filepath);
            //FileStream EzoneStream = EzoneFile.OpenRead();

            //int PacketSize = 10000;
            //int PacketCount = (int)(EzoneStream.Length / ((long)PacketSize));
            //int LastDataPacket = (int)(EzoneStream.Length - ((long)(PacketSize * PacketCount)));
            //TransferFiles.SendVarData(socketSend, Encoding.UTF8.GetBytes(EzoneFile.Name));
            //TransferFiles.SendVarData(socketSend, Encoding.UTF8.GetBytes(PacketSize.ToString()));
            //TransferFiles.SendVarData(socketSend, Encoding.UTF8.GetBytes(PacketCount.ToString()));
            //TransferFiles.SendVarData(socketSend, Encoding.UTF8.GetBytes(LastDataPacket.ToString()));
            ////bool isCut = false;
            //byte[] data = new byte[PacketSize];
            //for (int i = 0; i < PacketCount; i++)
            //{
            //    //从文件流读取数据并填充数据包
            //    EzoneStream.Read(data, 0, data.Length);
            //    //发送数据包
            //    if (TransferFiles.SendVarData(socketSend, data) == 3)
            //    {
            //        //isCut = true;
            //        break;
            //    }

            //}
            //if (LastDataPacket != 0)
            //{
            //    data = new byte[LastDataPacket];
            //    EzoneStream.Read(data, 0, data.Length);
            //    TransferFiles.SendVarData(socketSend, data);
            //}
            ////关闭套接字
            //socketSend.Close();
            ////关闭文件流
            //EzoneStream.Close();
            #endregion
            using (FileStream sw = new FileStream(filepath, FileMode.Open, FileAccess.Read))
            {
                byte[] buffer = new byte[1024 * 1024];
                int r = sw.Read(buffer, 0, buffer.Length);
                Console.WriteLine("small r={0}", r);
                socketSend.Send(buffer, 0, r + 1, SocketFlags.None);
            }
        }

        private void btn_SendBigFile_Click(object sender, EventArgs e)
        {
            //获取文件路径
            string filePath = txtBox_Path.Text.Trim();
            try
            {
                //读取选择的文件
                using (FileStream fsRead = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    //发送报警信息
                    string head = "0000";
                    byte[] headinfo = Encoding.UTF8.GetBytes(head);
                    socketSend.Send(headinfo);
                    string level = "1111";
                    byte[] levelinfo = Encoding.UTF8.GetBytes(level);
                    socketSend.Send(levelinfo);
                    for (int i = 0; i < 300000000; i++) ;
                    //1. 第一步：发送一个包，表示文件的长度，让客户端知道后续要接收几个包来重新组织成一个文件
                    long length = fsRead.Length;
                    //Console.WriteLine("文件长度length ={0}", length);
                    //加文件头和文件尾

                    byte[] byteLength = Encoding.UTF8.GetBytes(length.ToString());
                    //Console.WriteLine("byteLength={0}", byteLength.Length);
                    socketSend.Send(byteLength);

                    //进行不到1S的延时，避免数据出现粘包的情况
                    //Stopwatch sw = new Stopwatch();
                    //sw.Start();
                    for (int i = 0; i < 300000000; i++);
                    //sw.Stop();
                    //Console.WriteLine(sw.Elapsed.ToString());
                    
                    //2. 第二步：每次发送一个400byte的包，如果文件较大，则会拆分为多个包
                    byte[] buffer = new byte[400];
                    long send = 0; //发送的字节数                  
                    while (true)  //大文件断点多次传输
                    {
                        int r = fsRead.Read(buffer, 0, buffer.Length);
                        //Console.WriteLine("read r ={0}", r);
                        if (r == 0)
                        {
                            break;
                        }
                        socketSend.Send(buffer, 0, r, SocketFlags.None);
                        send += r;
                        //Console.WriteLine("{0}: 已发送：{1}/{2}", socketSend.RemoteEndPoint, send, length);
                    }
                    //Console.WriteLine("发送完成");
                }
            }
            catch{}
        }

        //创建连接的Socket
        Socket socketSend_2;
        private void btn_Connect_2_Click(object sender, EventArgs e)
        {
            try
            {
                txtBox_Log.AppendText("开始连接......\r\n");
                socketSend_2 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPAddress ip = IPAddress.Parse(txtBox_IP_2.Text.Trim());
                socketSend_2.Connect(ip, Convert.ToInt32(txtBox_Port_2.Text.Trim()));

                txtBox_Log.AppendText( "连接成功\r\n");
            }
            catch  {}
        }

        //创建连接的Socket
        Socket socketSend_3;
        private void btn_Connect_3_Click(object sender, EventArgs e)
        {
            try
            {
                txtBox_Log.AppendText("开始连接......\r\n");
                socketSend_3 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPAddress ip = IPAddress.Parse(txtBox_IP_3.Text.Trim());
                socketSend_3.Connect(ip, Convert.ToInt32(txtBox_Port_3.Text.Trim()));

                txtBox_Log.AppendText("连接成功\r\n");
            }
            catch { }
        }

        private void btn_SendBigFile_2_Click(object sender, EventArgs e)
        {
            //获取文件路径
            string filePath = txtBox_Path_2.Text.Trim();
            try
            {
                //读取选择的文件
                using (FileStream fsRead = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    //发送报警信息
                    string head = "0000";
                    byte[] headinfo = Encoding.UTF8.GetBytes(head);
                    socketSend_2.Send(headinfo);
                    string level = "1111";
                    byte[] levelinfo = Encoding.UTF8.GetBytes(level);
                    socketSend_2.Send(levelinfo);
                    for (int i = 0; i < 300000000; i++) ;
                    //1. 第一步：发送一个包，表示文件的长度，让客户端知道后续要接收几个包来重新组织成一个文件
                    long length = fsRead.Length;
                    //Console.WriteLine("文件长度length ={0}", length);
                    //加文件头和文件尾

                    byte[] byteLength = Encoding.UTF8.GetBytes(length.ToString());
                    //Console.WriteLine("byteLength={0}", byteLength.Length);
                    socketSend_2.Send(byteLength);

                    //进行不到1S的延时，避免数据出现粘包的情况
                    //Stopwatch sw = new Stopwatch();
                    //sw.Start();
                    for (int i = 0; i < 300000000; i++) ;
                    //sw.Stop();
                    //Console.WriteLine(sw.Elapsed.ToString());

                    //2. 第二步：每次发送一个400byte的包，如果文件较大，则会拆分为多个包
                    byte[] buffer = new byte[400];
                    long send = 0; //发送的字节数                  
                    while (true)  //大文件断点多次传输
                    {
                        int r = fsRead.Read(buffer, 0, buffer.Length);
                        //Console.WriteLine("read r ={0}", r);
                        if (r == 0)
                        {
                            break;
                        }
                        socketSend_2.Send(buffer, 0, r, SocketFlags.None);
                        send += r;
                        //Console.WriteLine("{0}: 已发送：{1}/{2}", socketSend_2.RemoteEndPoint, send, length);
                    }
                    //Console.WriteLine("发送完成");
                }
            }
            catch { }
        }

        private void btn_SendBigFile_3_Click(object sender, EventArgs e)
        {
            //获取文件路径
            string filePath = txtBox_Path_3.Text.Trim();
            try
            {
                //读取选择的文件
                using (FileStream fsRead = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    //发送报警信息
                    string head = "0000";
                    byte[] headinfo = Encoding.UTF8.GetBytes(head);
                    socketSend_3.Send(headinfo);
                    string level = "1111";
                    byte[] levelinfo = Encoding.UTF8.GetBytes(level);
                    socketSend_3.Send(levelinfo);
                    for (int i = 0; i < 300000000; i++) ;
                    //1. 第一步：发送一个包，表示文件的长度，让客户端知道后续要接收几个包来重新组织成一个文件
                    long length = fsRead.Length;
                    //Console.WriteLine("文件长度length ={0}", length);
                    //加文件头和文件尾

                    byte[] byteLength = Encoding.UTF8.GetBytes(length.ToString());
                    //Console.WriteLine("byteLength={0}", byteLength.Length);
                    socketSend_3.Send(byteLength);

                    //进行不到1S的延时，避免数据出现粘包的情况
                    //Stopwatch sw = new Stopwatch();
                    //sw.Start();
                    for (int i = 0; i < 300000000; i++) ;
                    //sw.Stop();
                    //Console.WriteLine(sw.Elapsed.ToString());

                    //2. 第二步：每次发送一个400byte的包，如果文件较大，则会拆分为多个包
                    byte[] buffer = new byte[400];
                    long send = 0; //发送的字节数                  
                    while (true)  //大文件断点多次传输
                    {
                        int r = fsRead.Read(buffer, 0, buffer.Length);
                        //Console.WriteLine("read r ={0}", r);
                        if (r == 0)
                        {
                            break;
                        }
                        socketSend_3.Send(buffer, 0, r, SocketFlags.None);
                        send += r;
                        //Console.WriteLine("{0}: 已发送：{1}/{2}", socketSend_3.RemoteEndPoint, send, length);
                    }
                    //Console.WriteLine("发送完成");
                }
            }
            catch { }
        }

        private void btn_Send_All_Click(object sender, EventArgs e)
        {
            btn_SendBigFile.PerformClick();
            btn_SendBigFile_2.PerformClick();
            btn_SendBigFile_3.PerformClick();
        }

        private void btn_Connect_All_Click(object sender, EventArgs e)
        {
            btn_Connect.PerformClick();
            btn_Connect_2.PerformClick();
            btn_Connect_3.PerformClick();
        }
    }
}