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
        //机头3号连接
        private void btn_HeadConnect3_Click(object sender, EventArgs e)
        {
            //按钮设置
            btn_HeadConnect3.Enabled = false;
            btn_ConnectedALL.Enabled = false;
            btn_DisconnectedALL.Enabled = btn_Reset.Enabled = true;


            socketHeadWatch03 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPAddress ipAddress13 = IPAddress.Parse(cbBox_IP3.Text.Trim());
            IPEndPoint endPoint13 = new IPEndPoint(ipAddress13, int.Parse(cbBox_PORT3.Text.Trim()));
            socketHeadWatch03.Bind(endPoint13);
            socketHeadWatch03.Listen(20);

            threadHeadWatch03 = new Thread(new ParameterizedThreadStart(WatchConnecting13));
            threadHeadWatch03.IsBackground = true;
            threadHeadWatch03.Start(socketHeadWatch03);
            lbl_HeadNotice3.Text = "开始监听 ......";
        }

        //机头3号通信
        private void btn_HeadDisconnect3_Click(object sender, EventArgs e)
        {
            //按钮设置
            btn_HeadConnect3.Enabled = true;
            btn_HeadDisconnect3.Enabled = false;
            btn_ConnectedALL.Enabled = true;
            btn_Reset.Enabled = true;
            btn_DisconnectedALL.Enabled = true;

            //恢复提示信息
            lbl_HeadNotice3.Text = "机头3号未连接";

            //取消相关线程和套接字实例
            if (socketHeadWatch03 != null)
                socketHeadWatch03 = null;
            if (socketHeadConnection03 != null)
                socketHeadConnection03 = null;

            if (threadHeadWatch03 != null)
                threadHeadWatch03 = null;
            if (threadHeadReceive03 != null)
                threadHeadReceive03 = null;

            //关闭定时器
            timer_Head3.Enabled = false;
        }
    }
}
