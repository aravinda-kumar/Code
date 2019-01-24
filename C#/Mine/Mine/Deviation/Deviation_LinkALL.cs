using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;

/// <summary>
/// 全部连接
/// </summary>
namespace Mine
{
    public partial class FormDeviation : Form
    {
        //全部启动按钮事件
        private void btn_ConnectedALL_Click(object sender, EventArgs e)
        {
            //禁用所有独立连接
            btn_EndConnect.Enabled = btn_HamConnect.Enabled = btn_HeadConnect.Enabled = false;
            //对机头处的信息进行监听
            //全部启动按钮禁用   
            btn_ConnectedALL.Enabled = false;
            //状态复位按钮启用
            btn_DisConnectedALL.Enabled = true;
            //全部退出按钮启用
            btn_Reset.Enabled = true;

            try
            {
                //机尾开始监听

                //实例化机尾处的监听套接字类，参数分别使用IPV4，流套接字，TCP协议
                socketWatch01 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                //生成IP地址以及套接字信息。
                IPAddress ipAddress01 = IPAddress.Parse(cbBox_IP1.Text.Trim());
                IPEndPoint endPoint01 = new IPEndPoint(ipAddress01, int.Parse(cbBox_PORT1.Text.Trim()));
                //监听套接字类实例和套接字绑定。套接字=IP地址+网络端口；
                socketWatch01.Bind(endPoint01);
                //这一个实例上最多响应20个客户端套接字
                socketWatch01.Listen(20);

                //开辟多线程去监听事件Thread中传入的是进程中要执行的函数
                threadWatch01 = new Thread(new ParameterizedThreadStart(WatchConnecting01));
                //线程后台运行
                threadWatch01.IsBackground = true;
                //start中传入的是线程中要执行的函数的参数
                threadWatch01.Start(socketWatch01);
                lbl_EndNotice.Text = "开始监听 ......";

                #region
                ////重锤开始监听

                ////实例化机尾处的监听套接字类，参数分别使用IPV4，流套接字，TCP协议
                //socketWatch02 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                ////生成IP地址以及套接字信息。
                //IPAddress ipAddress02 = IPAddress.Parse(cbBox_IP2.Text.Trim());
                //IPEndPoint endPoint02 = new IPEndPoint(ipAddress02, int.Parse(cbBox_PORT2.Text.Trim()));
                ////监听套接字类实例和套接字绑定。套接字=IP地址+网络端口；
                //socketWatch02.Bind(endPoint02);
                ////这一个实例上最多响应20个客户端套接字
                //socketWatch02.Listen(20);

                ////开辟多线程去监听事件Thread中传入的是进程中要执行的函数
                //threadWatch02 = new Thread(new ParameterizedThreadStart(WatchConnecting02));
                ////线程后台运行
                //threadWatch02.IsBackground = true;
                ////start中传入的是线程中要执行的函数的参数
                //threadWatch01.Start(socketWatch02);
                //lbl_HamNotice.Text = "开始监听 ......";

                ////机头开始监听

                ////实例化机尾处的监听套接字类，参数分别使用IPV4，流套接字，TCP协议
                //socketWatch03 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                ////生成IP地址以及套接字信息。
                //IPAddress ipAddress03 = IPAddress.Parse(cbBox_IP3.Text.Trim());
                //IPEndPoint endPoint03 = new IPEndPoint(ipAddress03, int.Parse(cbBox_PORT3.Text.Trim()));
                ////监听套接字类实例和套接字绑定。套接字=IP地址+网络端口；
                //socketWacth01.Bind(endPoint03);
                ////这一个实例上最多响应20个客户端套接字
                //socketWacth01.Listen(20);

                ////开辟多线程去监听事件Thread中传入的是进程中要执行的函数
                //threadWatch03 = new Thread(new ParameterizedThreadStart(WatchConnecting03));
                ////线程后台运行
                //threadWatch03.IsBackground = true;
                ////start中传入的是线程中要执行的函数的参数
                //threadWatch03.Start(socketWatch03);
                //lbl_HeadNotice.Text = "开始监听 ......";
                #endregion
            }
            catch { }
        }
    }
}