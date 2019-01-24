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
        //重锤2号监听函数
        private void WatchConnecting22(object obj)
        {
            //为了避免断开连接时候报异常，用了try()catch()结构
            try
            {
                Socket socketServer = obj as Socket;
                while (true)
                {
                    socketHamConnection02 = socketServer.Accept();
                    //建立连接之后启用机尾断开按钮
                    if (socketHamConnection02 != null)
                        btn_HamDisconnect2.Enabled = true;
                    string strIP = "远程主机：" + socketHamConnection02.RemoteEndPoint + "连接成功。";
                    lbl_HamNotice2.Text = strIP;

                    threadHamReceive02 = new Thread(new ParameterizedThreadStart(MsgReceive22));
                    threadHamReceive02.IsBackground = true;
                    threadHamReceive02.Start(socketHamConnection02);
                }
            }
            catch { }
        }
        //重锤2号通信函数
        private void MsgReceive22(object obj)
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
                        txtBox_LogHam2.AppendText(strReceiveMsg);
                    }
                }
            }
            catch { }
        }
    }
}
