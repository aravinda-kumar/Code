using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mine
{
    public partial class FormTear : Form
    {
        //机头2号监听函数
        private void WatchConnecting12(object obj)
        {
            //为了避免断开连接时候报异常，用了try()catch()结构
            try
            {
                Socket socketServer = obj as Socket;
                while (true)
                {
                    socketHeadConnection02 = socketServer.Accept();
                    //建立连接之后启用机尾断开按钮
                    if (socketHeadConnection02 != null)
                        btn_HeadDisconnect2.Enabled = true;
                    string strIP = "远程主机：" + socketHeadConnection02.RemoteEndPoint + "连接成功。";
                    lbl_HeadNotice2.Text = strIP;

                    threadHeadReceive02 = new Thread(new ParameterizedThreadStart(MsgReceive12));
                    threadHeadReceive02.IsBackground = true;
                    threadHeadReceive02.Start(socketHeadConnection02);
                }
            }
            catch { }
        }
        //机头2号通信函数
        private void MsgReceive12(object obj)
        {
            try
            {
                Socket socketSend = obj as Socket;
                while (true)
                {
                    //开辟1M的缓冲区
                    byte[] buffer = new byte[1048576];
                    int count = socketSend.Receive(buffer);
                    if (count == 0)
                    {
                        break;
                    }
                    else
                    {
                        string str = Encoding.UTF8.GetString(buffer, 0, count);
                        string strReceiveMsg = "接收：" + socketSend.RemoteEndPoint + "发送的消息：" + str + "。\r\n";
                        txtBox_LogHead2.AppendText(strReceiveMsg);
                    }
                }
            }
            catch { }
        }
    }
}
