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
        //重锤3号连接
        private void btn_HamConnect3_Click(object sender, EventArgs e)
        {
            //按钮设置
            btn_HamConnect3.Enabled = false;
            btn_ConnectedALL.Enabled = false;
            btn_DisconnectedALL.Enabled = btn_Reset.Enabled = true;


            socketHamWacth02 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPAddress ipAddress23 = IPAddress.Parse(cbBox_IP6.Text.Trim());
            IPEndPoint endPoint23 = new IPEndPoint(ipAddress23, int.Parse(cbBox_PORT6.Text.Trim()));
            socketHamWacth03.Bind(endPoint23);
            socketHamWacth03.Listen(20);

            threadHamWatch03 = new Thread(new ParameterizedThreadStart(WatchConnecting23));
            threadHamWatch03.IsBackground = true;
            threadHamWatch03.Start(socketHamWacth03);
            lbl_HamNotice3.Text = "开始监听 ......";
        }

        //重锤3号通信
        private void btn_HamDisconnect3_Click(object sender, EventArgs e)
        {
            //按钮设置
            btn_HamConnect3.Enabled = true;
            btn_HamDisconnect3.Enabled = false;
            btn_ConnectedALL.Enabled = true;
            btn_Reset.Enabled = true;
            btn_DisconnectedALL.Enabled = true;

            //恢复提示信息
            lbl_HamNotice3.Text = "重锤3号未连接";

            //取消相关线程和套接字实例
            if (socketHamWacth03 != null)
                socketHamWacth03 = null;
            if (socketHamConnection03 != null)
                socketHamConnection03 = null;

            if (threadHamWatch03 != null)
                threadHamWatch03 = null;
            if (threadHamReceive03 != null)
                threadHamReceive03 = null;

            //关闭定时器
            timer_Ham3.Enabled = false;
        }
    }
}
