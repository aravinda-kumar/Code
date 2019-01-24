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


namespace Mine
{
    public partial class FormDeviation : Form
    {
        //机尾连接
        private void btn_EndConnect_Click(object sender, EventArgs e)
        {
            //机尾连接禁用
            btn_EndConnect.Enabled = false;
            //对机头处的信息进行监听
            //全部启动按钮禁用   
            btn_ConnectedALL.Enabled = false;
            //状态复位按钮启用
            btn_DisConnectedALL.Enabled = true;
            //全部退出按钮启用
            btn_Reset.Enabled = true;
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
        }

        //机尾断开事件
        private void btn_EndDisConnect_Click(object sender, EventArgs e)
        {
            //机尾断开禁用
            btn_EndDisConnect.Enabled = false;
            //机尾连接启用
            btn_EndConnect.Enabled = true;

            //关闭对应套接字和线程
            socketWatch01.Close();
            socketConnection01.Close();

            threadWatch01.Abort();
            threadReceive01.Abort();

            //复位提示信息
            lbl_EndNotice.Text = "机尾未连接";

            //关闭定时器
            timer_pic_end.Enabled = false;
        }
    }
}