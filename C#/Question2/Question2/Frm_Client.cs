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
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace Question2
{
    public partial class Frm_Client : Form
    {
        public Frm_Client()
        {
            InitializeComponent();
        }

        private void Frm_Client_Load(object sender, EventArgs e)
        {
            //允许线程操作控件
            CheckForIllegalCrossThreadCalls = false;

            //给信息提示栏添加提示信息
            listView_Msg.Columns.Add("时间", 250);
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

            //为cbbox添加初始值
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

        Socket socketSend = null;
        Socket socketReceive = null;
        JavaScriptSerializer ser = new JavaScriptSerializer();
        //开始连接按钮
        private void btn_Connect_Click(object sender, EventArgs e)
        {
            try
            {
                lbl_State.Text = "开始连接......";
                socketSend = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPAddress ip = IPAddress.Parse(txtbox_IP.Text.Trim());
                socketSend.Connect(ip, Convert.ToInt32(txtbox_Port.Text.Trim()));
                lbl_State.Text = "服务器连接成功......";

                Thread threadSend = new Thread(new ParameterizedThreadStart(Receive));
                threadSend.Start(socketSend);
            }
            catch
            {
                MessageBox.Show("无法连接到服务器......");
            }
        }

        private void Receive(object obj)
        {
            socketReceive = obj as Socket;
            try
            {
                while (true)
                {
                    byte[] buffer = new byte[1024 * 8];
                    int msgLength = socketReceive.Receive(buffer, buffer.Length, SocketFlags.None);
                    if (msgLength == 0)
                    {
                        break;
                    }
                    string strInfo = Encoding.Default.GetString(buffer, 0, msgLength);
                    Json json = ser.Deserialize<Json>(strInfo);
                    DateTime dt = DateTime.Now;
                    var Items = new ListViewItem(dt.ToString("yyyy年MM月dd日HH时mm分ss秒"));
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

                    listView_Msg.Items.Add(Items);
                }
            }
            catch { }
        }

        //发送数据
        private void btn_Send_Click(object sender, EventArgs e)
        {
            Json json = null;
            try
            {
                json = new Json()
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
            }
            catch
            {
                MessageBox.Show("注意数据内容!");
                MessageBox.Show("选择后请重新连接");
            }  
            string sendMsg = ser.Serialize(json);
            byte[] buffer = Encoding.Default.GetBytes(sendMsg);
            try
            {
                socketSend.Send(buffer);
            }
            catch
            {
                MessageBox.Show("连接已断开！","ERROR");
            }
            
        }

        private void timer_Socket_Tick(object sender, EventArgs e)
        {
            if (socketSend != null)
            {
                if (socketSend.Poll(10, SelectMode.SelectRead))
                {
                    lbl_State.Text = "服务器未连接...";
                    //socketReceive.Close();
                    //socketSend.Close();
                }
            }
        }
    }
}
