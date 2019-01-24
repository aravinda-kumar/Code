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

namespace Mine
{
    public partial class FormTear : Form
    {
        //机头1号连接
        private void btn_HeadConnect1_Click(object sender, EventArgs e)
        {
            //按钮设置
            btn_HeadConnect1.Enabled = false;
            btn_ConnectedALL.Enabled = false;
            btn_DisconnectedALL.Enabled = btn_Reset.Enabled = true;

            
            socketHeadWatch01 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPAddress ipAddress11 = IPAddress.Parse(cbBox_IP1.Text.Trim());
            IPEndPoint endPoint11 = new IPEndPoint(ipAddress11, int.Parse(cbBox_PORT1.Text.Trim()));
            socketHeadWatch01.Bind(endPoint11);
            socketHeadWatch01.Listen(20);

            threadHeadWatch01 = new Thread(new ParameterizedThreadStart(WatchConnecting11));
            threadHeadWatch01.IsBackground = true;
            threadHeadWatch01.Start(socketHeadWatch01);
            lbl_HeadNotice1.Text = "开始监听 ......";
        }

        //机头1号通信
        private void btn_HeadDisconnect1_Click(object sender, EventArgs e)
        {
            //按钮设置
            btn_HeadConnect1.Enabled = true;
            btn_HeadDisconnect1.Enabled = false;
            btn_ConnectedALL.Enabled = true;
            btn_Reset.Enabled = true;
            btn_DisconnectedALL.Enabled = true;

            //恢复提示信息
            lbl_HeadNotice1.Text = "机头1号未连接";

            //取消相关线程和套接字实例
            if (socketHeadWatch01 != null)
                socketHeadWatch01 = null;
            if (socketHeadConnection01 != null)
                socketHeadConnection01 = null;

            if (threadHeadWatch01 != null)
                threadHeadWatch01 = null;
            if (threadHeadReceive01 != null)
                threadHeadReceive01 = null;

            //关闭定时器
            timer_Head1.Enabled = false;
        }
    }
}
