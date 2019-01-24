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
        //重锤1号连接
        private void btn_HamConnect1_Click(object sender, EventArgs e)
        {
            //按钮设置
            btn_HamConnect1.Enabled = false;
            btn_ConnectedALL.Enabled = false;
            btn_DisconnectedALL.Enabled = btn_Reset.Enabled = true;


            socketHamWacth01 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPAddress ipAddress21 = IPAddress.Parse(cbBox_IP4.Text.Trim());
            IPEndPoint endPoint21 = new IPEndPoint(ipAddress21, int.Parse(cbBox_PORT4.Text.Trim()));
            socketHamWacth01.Bind(endPoint21);
            socketHamWacth01.Listen(20);

            threadHamWatch01 = new Thread(new ParameterizedThreadStart(WatchConnecting21));
            threadHamWatch01.IsBackground = true;
            threadHamWatch01.Start(socketHamWacth01);
            lbl_HamNotice1.Text = "开始监听 ......";
        }

        //重锤1号通信
        private void btn_HamDisconnect1_Click(object sender, EventArgs e)
        {
            //按钮设置
            btn_HamConnect1.Enabled = true;
            btn_HamDisconnect1.Enabled = false;
            btn_ConnectedALL.Enabled = true;
            btn_Reset.Enabled = true;
            btn_DisconnectedALL.Enabled = true;

            //恢复提示信息
            lbl_HamNotice1.Text = "重锤1号未连接";

            //取消相关线程和套接字实例
            if (socketHamWacth01 != null)
                socketHamWacth01 = null;
            if (socketHamConnection01 != null)
                socketHamConnection01 = null;

            if (threadHamWatch01 != null)
                threadHamWatch01 = null;
            if (threadHamReceive01 != null)
                threadHamReceive01 = null;

            //关闭定时器
            timer_Ham1.Enabled = false;

        }
    }
}
