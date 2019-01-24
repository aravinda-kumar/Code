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
        //机尾3号连接
        private void btn_EndConnect3_Click(object sender, EventArgs e)
        {
            //按钮设置
            btn_EndConnect3.Enabled = false;
            btn_ConnectedALL.Enabled = false;
            btn_DisconnectedALL.Enabled = btn_Reset.Enabled = true;


            socketEndWatch03 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPAddress ipAddress33 = IPAddress.Parse(cbBox_IP9.Text.Trim());
            IPEndPoint endPoint33 = new IPEndPoint(ipAddress33, int.Parse(cbBox_PORT9.Text.Trim()));
            socketEndWatch03.Bind(endPoint33);
            socketEndWatch03.Listen(20);

            threadEndWatch03 = new Thread(new ParameterizedThreadStart(WatchConnecting33));
            threadEndWatch03.IsBackground = true;
            threadEndWatch03.Start(socketEndWatch03);
            lbl_EndNotice3.Text = "开始监听 ......";
        }

        //机尾3号通信
        private void btn_EndDisconnect3_Click(object sender, EventArgs e)
        {
            //按钮设置
            btn_EndConnect3.Enabled = true;
            btn_EndDisconnect3.Enabled = false;
            btn_ConnectedALL.Enabled = true;
            btn_Reset.Enabled = true;
            btn_DisconnectedALL.Enabled = true;

            //恢复提示信息
            lbl_EndNotice3.Text = "机尾2号未连接";

            //取消相关线程和套接字实例
            if (socketEndWatch03 != null)
                socketEndWatch03 = null;
            if (socketEndConnection03 != null)
                socketEndConnection03 = null;

            if (threadEndWatch03 != null)
                threadEndWatch03 = null;
            if (threadEndReceive03 != null)
                threadEndReceive03 = null;

            //关闭定时器
            timer_End3.Enabled = false;
        }
    }
}
