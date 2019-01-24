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
        //机尾2号连接
        private void btn_EndConnect2_Click(object sender, EventArgs e)
        {
            //按钮设置
            btn_EndConnect2.Enabled = false;
            btn_ConnectedALL.Enabled = false;
            btn_DisconnectedALL.Enabled = btn_Reset.Enabled = true;


            socketEndWatch02 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPAddress ipAddress32 = IPAddress.Parse(cbBox_IP8.Text.Trim());
            IPEndPoint endPoint32 = new IPEndPoint(ipAddress32, int.Parse(cbBox_PORT8.Text.Trim()));
            socketEndWatch02.Bind(endPoint32);
            socketEndWatch02.Listen(20);

            threadEndWatch02 = new Thread(new ParameterizedThreadStart(WatchConnecting32));
            threadEndWatch02.IsBackground = true;
            threadEndWatch02.Start(socketEndWatch02);
            lbl_EndNotice2.Text = "开始监听 ......";
        }

        //机尾2号通信
        private void btn_EndDisconnect2_Click(object sender, EventArgs e)
        {
            //按钮设置
            btn_EndConnect2.Enabled = true;
            btn_EndDisconnect2.Enabled = false;
            btn_ConnectedALL.Enabled = true;
            btn_Reset.Enabled = true;
            btn_DisconnectedALL.Enabled = true;

            //恢复提示信息
            lbl_EndNotice2.Text = "机尾2号未连接";

            //取消相关线程和套接字实例
            if (socketEndWatch02 != null)
                socketEndWatch02 = null;
            if (socketEndConnection02 != null)
                socketEndConnection02 = null;

            if (threadEndWatch02 != null)
                threadEndWatch02 = null;
            if (threadEndReceive02 != null)
                threadEndReceive02 = null;

            //关闭定时器
            timer_End2.Enabled = false;
        }
    }
}
