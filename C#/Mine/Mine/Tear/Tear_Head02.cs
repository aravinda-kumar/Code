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
        //机头2号连接
        private void btn_HeadConnect2_Click(object sender, EventArgs e)
        {
            //按钮设置
            btn_HeadConnect2.Enabled = false;
            btn_ConnectedALL.Enabled = false;
            btn_DisconnectedALL.Enabled = btn_Reset.Enabled = true;


            socketHeadWatch02 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPAddress ipAddress12 = IPAddress.Parse(cbBox_IP2.Text.Trim());
            IPEndPoint endPoint12 = new IPEndPoint(ipAddress12, int.Parse(cbBox_PORT2.Text.Trim()));
            socketHeadWatch02.Bind(endPoint12);
            socketHeadWatch02.Listen(20);

            threadHeadWatch02 = new Thread(new ParameterizedThreadStart(WatchConnecting12));
            threadHeadWatch02.IsBackground = true;
            threadHeadWatch02.Start(socketHeadWatch02);
            lbl_HeadNotice2.Text = "开始监听 ......";
        }
        //机头2号通信
        private void btn_HeadDisconnect2_Click(object sender, EventArgs e)
        {
            //按钮设置
            btn_HeadConnect2.Enabled = true;
            btn_HeadDisconnect2.Enabled = false;
            btn_ConnectedALL.Enabled = true;
            btn_Reset.Enabled = true;
            btn_DisconnectedALL.Enabled = true;

            //恢复提示信息
            lbl_HeadNotice2.Text = "机头2号未连接";

            //取消相关线程和套接字实例
            if (socketHeadWatch02 != null)
                socketHeadWatch02 = null;
            if (socketHeadConnection02 != null)
                socketHeadConnection02 = null;

            if (threadHeadWatch02 != null)
                threadHeadWatch02 = null;
            if (threadHeadReceive02 != null)
                threadHeadReceive02 = null;

            //关闭定时器
            timer_Head2.Enabled = false;
        }
    }
}
