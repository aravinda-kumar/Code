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
        //机尾1号连接
        private void btn_EndConnect1_Click(object sender, EventArgs e)
        {
            //按钮设置
            btn_EndConnect1.Enabled = false;
            btn_ConnectedALL.Enabled = false;
            btn_DisconnectedALL.Enabled = btn_Reset.Enabled = true;


            socketEndWatch01 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPAddress ipAddress31 = IPAddress.Parse(cbBox_IP7.Text.Trim());
            IPEndPoint endPoint31 = new IPEndPoint(ipAddress31, int.Parse(cbBox_PORT7.Text.Trim()));
            socketEndWatch01.Bind(endPoint31);
            socketEndWatch01.Listen(20);

            threadEndWatch01 = new Thread(new ParameterizedThreadStart(WatchConnecting31));
            threadEndWatch01.IsBackground = true;
            threadEndWatch01.Start(socketEndWatch01);
            lbl_EndNotice1.Text = "开始监听 ......";
        }

        //机尾1号通信
        private void btn_EndDisconnect1_Click(object sender, EventArgs e)
        {
            //按钮设置
            btn_EndConnect1.Enabled = true;
            btn_EndDisconnect1.Enabled = false;
            btn_ConnectedALL.Enabled = true;
            btn_Reset.Enabled = true;
            btn_DisconnectedALL.Enabled = true;

            //恢复提示信息
            lbl_EndNotice1.Text = "机尾1号未连接";

            //取消相关线程和套接字实例
            if (socketEndWatch01 != null)
                socketEndWatch01 = null;
            if (socketEndConnection01 != null)
                socketEndConnection01 = null;

            if (threadEndWatch01 != null)
                threadEndWatch01 = null;
            if (threadEndReceive01 != null)
                threadEndReceive01 = null;

            //关闭定时器
            timer_End1.Enabled = false;
        }
    }
}
