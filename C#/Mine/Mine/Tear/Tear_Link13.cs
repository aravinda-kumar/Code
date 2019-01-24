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
        //机头3号监听函数
        private void WatchConnecting13(object obj)
        {
            //为了避免断开连接时候报异常，用了try()catch()结构
            try
            {
                Socket socketServer = obj as Socket;
                while (true)
                {
                    socketHeadConnection03 = socketServer.Accept();
                    //建立连接之后启用机尾断开按钮
                    if (socketHeadConnection03 != null)
                        btn_HeadDisconnect3.Enabled = true;
                    string strIP = "远程主机：" + socketHeadConnection03.RemoteEndPoint + "连接成功。";
                    lbl_HeadNotice3.Text = strIP;

                    threadHeadReceive03 = new Thread(new ParameterizedThreadStart(MsgReceive13));
                    threadHeadReceive03.IsBackground = true;
                    threadHeadReceive03.Start(socketHeadConnection03);
                }
            }
            catch { }
        }
        //机头1号通信函数
        private void MsgReceive13(object obj)
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
                        txtBox_LogHead3.AppendText(strReceiveMsg);
                    }
                }
            }
            catch { }
        }
    }
}
