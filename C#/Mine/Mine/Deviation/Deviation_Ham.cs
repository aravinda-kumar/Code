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
        //重锤连接
        private void btn_HamConnect_Click(object sender, EventArgs e)
        {
            //按钮设置
            btn_HamConnect.Enabled = false;
            btn_ConnectedALL.Enabled = false;
            btn_DisConnectedALL.Enabled = true;
            btn_Reset.Enabled = true;

            //开始监听
            socketWatch02 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPAddress ipAddress02 = IPAddress.Parse(cbBox_IP2.Text.Trim());
            IPEndPoint endPoint02 = new IPEndPoint(ipAddress02, int.Parse(cbBox_PORT2.Text.Trim()));
            socketWatch02.Bind(endPoint02);
            socketWatch02.Listen(20);

            threadWatch02 = new Thread(new ParameterizedThreadStart(WatchConnecting02));
            threadWatch02.IsBackground = true;
            threadWatch02.Start(socketWatch02);
            lbl_HamNotice.Text = "开始监听 ......";
        }

        //重锤断开
        private void btn_HamDisConnect_Click(object sender, EventArgs e)
        {
            btn_HamDisConnect.Enabled = false;
            btn_HamConnect.Enabled = true;

            //关闭对应套接字和线程
            socketWatch02.Close();
            socketConnection02.Close();

            threadWatch02.Abort();
            threadReceive02.Abort();

            //复位提示信息
            lbl_HamNotice.Text = "重锤未连接";

            //关闭定时器
            timer_pic_ham.Enabled = false;
        }
    }
}