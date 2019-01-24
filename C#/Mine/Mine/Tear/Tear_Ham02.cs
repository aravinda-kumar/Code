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
        //重锤2号连接
        private void btn_HamConnect2_Click(object sender, EventArgs e)
        {
            //按钮设置
            btn_HamConnect2.Enabled = false;
            btn_ConnectedALL.Enabled = false;
            btn_DisconnectedALL.Enabled = btn_Reset.Enabled = true;


            socketHamWacth02 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPAddress ipAddress22 = IPAddress.Parse(cbBox_IP5.Text.Trim());
            IPEndPoint endPoint22 = new IPEndPoint(ipAddress22, int.Parse(cbBox_PORT5.Text.Trim()));
            socketHamWacth02.Bind(endPoint22);
            socketHamWacth02.Listen(20);

            threadHamWatch02 = new Thread(new ParameterizedThreadStart(WatchConnecting22));
            threadHamWatch02.IsBackground = true;
            threadHamWatch02.Start(socketHamWacth02);
            lbl_HamNotice2.Text = "开始监听 ......";
        }

        //重锤2号通信
        private void btn_HamDisconnect2_Click(object sender, EventArgs e)
        {
            //按钮设置
            btn_HamConnect2.Enabled = true;
            btn_HamDisconnect2.Enabled = false;
            btn_ConnectedALL.Enabled = true;
            btn_Reset.Enabled = true;
            btn_DisconnectedALL.Enabled = true;

            //恢复提示信息
            lbl_HamNotice2.Text = "重锤2号未连接";

            //取消相关线程和套接字实例
            if (socketHamWacth02 != null)
                socketHamWacth02 = null;
            if (socketHamConnection02 != null)
                socketHamConnection02 = null;

            if (threadHamWatch02 != null)
                threadHamWatch02 = null;
            if (threadHamReceive02 != null)
                threadHamReceive02 = null;

            //关闭定时器
            timer_Ham2.Enabled = false;
        }
    }
}
