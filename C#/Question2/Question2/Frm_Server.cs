using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.Script.Serialization;
using System.IO;

namespace Question2
{
    
    public partial class Frm_Server : Form
    {
        public Frm_Server()
        {
            InitializeComponent();
        }

        Thread threadWatch= null;
        Socket socketWatch = null;
        Socket socketReceive = null;
        Socket socketSend = null;

        Dictionary<string, Socket> dicSocket = new Dictionary<string, Socket>();
        JavaScriptSerializer ser = new JavaScriptSerializer();
        string strIP = null;

        //开始监听
        private void btn_Watch_Click(object sender, EventArgs e)
        {
            try
            {
                socketWatch = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPAddress ipAddress = IPAddress.Parse(txtbox_IP.Text.Trim());
                IPEndPoint point = new IPEndPoint(ipAddress, Convert.ToInt32(txtbox_Port.Text.Trim()));
                socketWatch.Bind(point);
                socketWatch.Listen(20);

                threadWatch = new Thread(Watching);
                threadWatch.IsBackground = true;
                threadWatch.Start();
                txtbox_Log.AppendText("开始监听......\r\n");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }

        private void Watching()
        {
            try
            {
                while (true)
                {
                    socketReceive = socketWatch.Accept();
                    strIP = socketReceive.RemoteEndPoint.ToString();
                    DateTime dt = DateTime.Now;
                    string strIPMsg = dt.ToString("yyyy年MM月dd日HH时mm分ss秒") + "：" + strIP + "连接成功\r\n";
                    dicSocket.Add(strIP, socketReceive);
                    cbbox_Socket.Items.Add(strIP);
                    txtbox_Log.AppendText(strIPMsg);

                    Thread threadReceive = new Thread(new ParameterizedThreadStart(Receive));
                    threadReceive.IsBackground = true;
                    threadReceive.Start(socketReceive);
                }
            }
            catch {}
        }
        private void Receive(object obj)
        {
            socketSend = obj as Socket;
            try
            {
                while (true)
                {
                    byte[] buffer = new byte[1024 * 8];
                    int msgLength = socketSend.Receive(buffer, buffer.Length, SocketFlags.None);
                    if (msgLength == 0)
                    {
                        break;
                    }
                    string strInfo = Encoding.Default.GetString(buffer, 0, msgLength);
                    Json json = ser.Deserialize<Json>(strInfo);
                    DateTime dt = DateTime.Now;
                    var Items = new ListViewItem(dt.ToString("yyyy年MM月dd日HH时mm分ss秒"));
                    Items.SubItems.Add(strIP);
                    Items.SubItems.Add(json.digital_1_1);
                    Items.SubItems.Add(json.digital_1_2);
                    Items.SubItems.Add(json.digital_2_1);
                    Items.SubItems.Add(json.digital_2_2);
                    Items.SubItems.Add(json.digital_3_1);
                    Items.SubItems.Add(json.digital_3_2);
                    Items.SubItems.Add(json.digital_4_1);
                    Items.SubItems.Add(json.digital_4_2);

                    Items.SubItems.Add(json.analog_1_1);
                    Items.SubItems.Add(json.analog_1_2);
                    Items.SubItems.Add(json.analog_1_3);
                    Items.SubItems.Add(json.analog_1_4);
                    Items.SubItems.Add(json.analog_2_1);
                    Items.SubItems.Add(json.analog_2_2);
                    Items.SubItems.Add(json.analog_2_3);
                    Items.SubItems.Add(json.analog_2_4);
                    Items.SubItems.Add(json.analog_3_1);
                    Items.SubItems.Add(json.analog_3_2);
                    Items.SubItems.Add(json.analog_3_3);
                    Items.SubItems.Add(json.analog_3_4);
                    Items.SubItems.Add(json.analog_4_1);
                    Items.SubItems.Add(json.analog_4_2);
                    Items.SubItems.Add(json.analog_4_3);
                    Items.SubItems.Add(json.analog_4_4);

                    //显示已经接收到的数据
                    listView_Msg.Items.Add(Items);
                }
            }
            catch{}
        }
        //程序加载时的一些操作
        private void Frm_Server_Load(object sender, EventArgs e)
        {
            //允许线程操作控件
            CheckForIllegalCrossThreadCalls = false;

            //给信息提示栏添加提示信息
            listView_Msg.Columns.Add("时间", 250);
            listView_Msg.Columns.Add("地址", 150);
            for (int index = 0; index < 4; index++)
            {
                listView_Msg.Columns.Add("开关量1", 80);
                listView_Msg.Columns.Add("开关量2", 80);
                listView_Msg.Columns.Add("模拟量1", 80);
                listView_Msg.Columns.Add("模拟量2", 80);
                listView_Msg.Columns.Add("模拟量3", 80);
                listView_Msg.Columns.Add("模拟量4", 80);
            }
            listView_Msg.View = View.Details;

            //为开关量添加选项
            cbbox_c1s1.Items.Add("开");
            cbbox_c1s2.Items.Add("开");
            cbbox_c2s1.Items.Add("开");
            cbbox_c2s2.Items.Add("开");
            cbbox_c3s1.Items.Add("开");
            cbbox_c3s2.Items.Add("开");
            cbbox_c4s1.Items.Add("开");
            cbbox_c4s2.Items.Add("开");

            cbbox_c1s1.Items.Add("关");
            cbbox_c1s2.Items.Add("关");
            cbbox_c2s1.Items.Add("关");
            cbbox_c2s2.Items.Add("关");
            cbbox_c3s1.Items.Add("关");
            cbbox_c3s2.Items.Add("关");
            cbbox_c4s1.Items.Add("关");
            cbbox_c4s2.Items.Add("关");

            //开启定时器
            timer_Socket.Enabled = true;
        }

        private void btn_Cut_Click(object sender, EventArgs e)
        {
            if (socketWatch != null)
            {
                socketWatch.Close();
            }
            if (socketReceive != null)
            {
                socketReceive.Close();
            }
            if (socketSend != null)
            {
                socketSend.Close();
            }
            foreach (var item in dicSocket)
            {
                DateTime dt = DateTime.Now;
                txtbox_Log.AppendText(dt.ToString("yyyy年MM月dd日HH时mm分ss秒") + item.Key + "连接断开\r\n");
            }
            dicSocket.Clear();
            cbbox_Socket.Items.Clear();
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            //实例化需要进行传输的类
            Json json = new Json()
            {
                digital_1_1 = cbbox_c1s1.SelectedItem.ToString(),
                digital_1_2 = cbbox_c1s2.SelectedItem.ToString(),
                digital_2_1 = cbbox_c2s1.SelectedItem.ToString(),
                digital_2_2 = cbbox_c2s2.SelectedItem.ToString(),
                digital_3_1 = cbbox_c3s1.SelectedItem.ToString(),
                digital_3_2 = cbbox_c3s2.SelectedItem.ToString(),
                digital_4_1 = cbbox_c4s1.SelectedItem.ToString(),
                digital_4_2 = cbbox_c4s2.SelectedItem.ToString(),

                analog_1_1 = txtbox_c1a1.Text.Trim(),
                analog_1_2 = txtbox_c1a2.Text.Trim(),
                analog_1_3 = txtbox_c1a3.Text.Trim(),
                analog_1_4 = txtbox_c1a4.Text.Trim(),
                analog_2_1 = txtbox_c2a1.Text.Trim(),
                analog_2_2 = txtbox_c2a2.Text.Trim(),
                analog_2_3 = txtbox_c2a3.Text.Trim(),
                analog_2_4 = txtbox_c2a4.Text.Trim(),
                analog_3_1 = txtbox_c3a1.Text.Trim(),
                analog_3_2 = txtbox_c3a2.Text.Trim(),
                analog_3_3 = txtbox_c3a3.Text.Trim(),
                analog_3_4 = txtbox_c3a4.Text.Trim(),
                analog_4_1 = txtbox_c4a1.Text.Trim(),
                analog_4_2 = txtbox_c4a2.Text.Trim(),
                analog_4_3 = txtbox_c4a3.Text.Trim(),
                analog_4_4 = txtbox_c4a4.Text.Trim()
            };

            string sendMsg = ser.Serialize(json);
            File.WriteAllText("output.json", sendMsg);
            byte[] buffer = Encoding.Default.GetBytes(sendMsg);
            string point = null;
            try
            {
                point = cbbox_Socket.SelectedItem.ToString();
            }
            catch
            {
                MessageBox.Show("请选择客户端地址！");
            }
            
            try
            {
                dicSocket[point].Send(buffer);
            }
            catch
            {
                MessageBox.Show("客户端已经断开！");
            }
            
        }

        //检测套接字连接状态
        private void timer_Socket_Tick(object sender, EventArgs e)
        {
            List<string> IPlist = new List<string>();
            foreach (var item in dicSocket)
            {
                IPlist.Add(item.Key);
            }
            foreach (var item in IPlist)
            {
                if (dicSocket[item].Poll(1, SelectMode.SelectRead))
                {
                    DateTime dt = DateTime.Now;
                    txtbox_Log.AppendText(dt.ToString("yyyy年MM月dd日HH时mm分ss秒") + item + "连接断开\r\n");
                    dicSocket.Remove(item);
                    cbbox_Socket.Items.Remove(item);
                }
            }
            IPlist.Clear();
        }
    }
}
