using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;


namespace Mine
{
    public partial class FormDeviation : Form
    {
        //机头位置连接
        private void btn_HeadConnect_Click(object sender, EventArgs e)
        {
            //按钮设置
            btn_HeadConnect.Enabled = false;
            btn_ConnectedALL.Enabled = false;
            btn_DisConnectedALL.Enabled = true;
            btn_Reset.Enabled = true;

            //开始监听
            socketWatch03 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPAddress ipAddress03 = IPAddress.Parse(cbBox_IP3.Text.Trim());
            IPEndPoint endPoint03 = new IPEndPoint(ipAddress03, int.Parse(cbBox_PORT3.Text.Trim()));
            socketWatch03.Bind(endPoint03);
            socketWatch03.Listen(20);

            threadWatch03 = new Thread(new ParameterizedThreadStart(WatchConnecting03));
            threadWatch03.IsBackground = true;
            threadWatch03.Start(socketWatch03);
            lbl_HeadNotice.Text = "开始监听 ......";
        }

        //机头位置断开
        private void btn_HeadDisConnect_Click(object sender, EventArgs e)
        {
            btn_HeadDisConnect.Enabled = false;
            btn_HeadConnect.Enabled = true;

            //关闭对应套接字和线程
            socketWatch03.Close();
            socketConnection03.Close();

            threadWatch03.Abort();
            threadReceive03.Abort();

            //复位提示信息
            lbl_HeadNotice.Text = "重锤未连接";

            //关闭定时器
            timer_pic_head.Enabled = false;
        }
    }
}