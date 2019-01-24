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
        //全部连接
        private void btn_ConnectedALL_Click(object sender, EventArgs e)
        {
            //按钮显示设置
            btn_ConnectedALL.Enabled = false;
            btn_Reset.Enabled = true;
            btn_DisconnectedALL.Enabled = true;

            btn_EndConnect1.Enabled = btn_EndConnect2.Enabled = btn_EndConnect3.Enabled = false;
            btn_HamConnect1.Enabled = btn_HamConnect2.Enabled = btn_HamConnect3.Enabled = false;
            btn_HeadConnect1.Enabled = btn_HeadConnect2.Enabled = btn_HeadConnect3.Enabled = false;

            btn_EndDisconnect1.Enabled = btn_EndDisconnect2.Enabled = btn_EndDisconnect3.Enabled = false;
            btn_HamDisconnect1.Enabled = btn_HamDisconnect2.Enabled = btn_HamDisconnect3.Enabled = false;
            btn_HeadDisconnect1.Enabled = btn_HeadDisconnect2.Enabled = btn_HeadDisconnect3.Enabled = false;

            //机头1号连接
            socketHeadWatch01 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPAddress ipAddress11 = IPAddress.Parse(cbBox_IP1.Text.Trim());
            IPEndPoint endPoint11 = new IPEndPoint(ipAddress11, int.Parse(cbBox_PORT1.Text.Trim()));
            socketHeadWatch01.Bind(endPoint11);
            socketHeadWatch01.Listen(20);

            threadHeadWatch01 = new Thread(new ParameterizedThreadStart(WatchConnecting11));
            threadHeadWatch01.IsBackground = true;
            threadHeadWatch01.Start(socketHeadWatch01);
            lbl_HeadNotice1.Text = "开始监听 ......";

            #region
            ////机头2号连接
            //socketHeadWatch02 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //IPAddress ipAddress12 = IPAddress.Parse(cbBox_IP2.Text.Trim());
            //IPEndPoint endPoint12 = new IPEndPoint(ipAddress12, int.Parse(cbBox_PORT2.Text.Trim()));
            //socketHeadWatch02.Bind(endPoint12);
            //socketHeadWatch02.Listen(20);

            //threadHeadWatch02 = new Thread(new ParameterizedThreadStart(WatchConnecting12));
            //threadHeadWatch02.IsBackground = true;
            //threadHeadWatch02.Start(socketHeadWatch02);
            //lbl_HeadNotice2.Text = "开始监听 ......";

            ////机头3号连接
            //socketHeadWatch03 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //IPAddress ipAddress13 = IPAddress.Parse(cbBox_IP3.Text.Trim());
            //IPEndPoint endPoint13 = new IPEndPoint(ipAddress13, int.Parse(cbBox_PORT3.Text.Trim()));
            //socketHeadWatch03.Bind(endPoint13);
            //socketHeadWatch03.Listen(20);

            //threadHeadWatch03 = new Thread(new ParameterizedThreadStart(WatchConnecting13));
            //threadHeadWatch03.IsBackground = true;
            //threadHeadWatch03.Start(socketHeadWatch03);
            //lbl_HeadNotice3.Text = "开始监听 ......";

            ////重锤1号连接
            //socketHamWacth01 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //IPAddress ipAddress21 = IPAddress.Parse(cbBox_IP4.Text.Trim());
            //IPEndPoint endPoint21 = new IPEndPoint(ipAddress21, int.Parse(cbBox_PORT4.Text.Trim()));
            //socketHamWacth01.Bind(endPoint21);
            //socketHamWacth01.Listen(20);

            //threadHamWatch01 = new Thread(new ParameterizedThreadStart(WatchConnecting21));
            //threadHamWatch01.IsBackground = true;
            //threadHamWatch01.Start(socketHamWacth01);
            //lbl_HamNotice1.Text = "开始监听 ......";

            ////重锤2号连接
            //socketHamWacth02 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //IPAddress ipAddress22 = IPAddress.Parse(cbBox_IP5.Text.Trim());
            //IPEndPoint endPoint22 = new IPEndPoint(ipAddress22, int.Parse(cbBox_PORT5.Text.Trim()));
            //socketHamWacth02.Bind(endPoint22);
            //socketHamWacth02.Listen(20);

            //threadHamWatch02 = new Thread(new ParameterizedThreadStart(WatchConnecting22));
            //threadHamWatch02.IsBackground = true;
            //threadHamWatch02.Start(socketHamWacth02);
            //lbl_HamNotice2.Text = "开始监听 ......";

            ////重锤3号连接
            //socketHamWacth03 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //IPAddress ipAddress23 = IPAddress.Parse(cbBox_IP6.Text.Trim());
            //IPEndPoint endPoint23 = new IPEndPoint(ipAddress23, int.Parse(cbBox_PORT6.Text.Trim()));
            //socketHamWacth03.Bind(endPoint23);
            //socketHamWacth03.Listen(20);

            //threadHamWatch03 = new Thread(new ParameterizedThreadStart(WatchConnecting23));
            //threadHamWatch03.IsBackground = true;
            //threadHamWatch03.Start(socketHamWacth03);
            //lbl_HamNotice3.Text = "开始监听 ......";

            ////机尾1号连接
            //socketEndWatch01 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //IPAddress ipAddress31 = IPAddress.Parse(cbBox_IP7.Text.Trim());
            //IPEndPoint endPoint31 = new IPEndPoint(ipAddress31, int.Parse(cbBox_PORT7.Text.Trim()));
            //socketEndWatch01.Bind(endPoint31);
            //socketEndWatch01.Listen(20);

            //threadEndWatch01 = new Thread(new ParameterizedThreadStart(WatchConnecting31));
            //threadEndWatch01.IsBackground = true;
            //threadEndWatch01.Start(socketEndWatch01);
            //lbl_EndNotice1.Text = "开始监听 ......";

            ////机尾2号连接
            //socketEndWatch02 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //IPAddress ipAddress32 = IPAddress.Parse(cbBox_IP8.Text.Trim());
            //IPEndPoint endPoint32 = new IPEndPoint(ipAddress32, int.Parse(cbBox_PORT8.Text.Trim()));
            //socketEndWatch02.Bind(endPoint32);
            //socketEndWatch02.Listen(20);

            //threadEndWatch02 = new Thread(new ParameterizedThreadStart(WatchConnecting32));
            //threadEndWatch02.IsBackground = true;
            //threadEndWatch02.Start(socketEndWatch02);
            //lbl_EndNotice2.Text = "开始监听 ......";

            ////机尾3号连接
            //socketEndWatch03 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //IPAddress ipAddress33 = IPAddress.Parse(cbBox_IP9.Text.Trim());
            //IPEndPoint endPoint33 = new IPEndPoint(ipAddress33, int.Parse(cbBox_PORT9.Text.Trim()));
            //socketEndWatch03.Bind(endPoint33);
            //socketEndWatch03.Listen(20);

            //threadEndWatch03 = new Thread(new ParameterizedThreadStart(WatchConnecting33));
            //threadEndWatch03.IsBackground = true;
            //threadEndWatch03.Start(socketEndWatch03);
            //lbl_EndNotice3.Text = "开始监听 ......";
            #endregion
        }
    }
}
