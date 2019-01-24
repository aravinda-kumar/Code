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
        //机尾2号监听函数
        private void WatchConnecting32(object obj)
        {
            //为了避免断开连接时候报异常，用了try()catch()结构
            try
            {
                Socket socketServer = obj as Socket;
                while (true)
                {
                    socketEndConnection02 = socketServer.Accept();
                    //建立连接之后启用机尾断开按钮
                    if (socketEndConnection02 != null)
                        btn_EndDisconnect2.Enabled = true;
                    string strIP = "远程主机：" + socketEndConnection02.RemoteEndPoint + "连接成功。";
                    lbl_EndNotice2.Text = strIP;

                    threadEndReceive02 = new Thread(new ParameterizedThreadStart(MsgReceive32));
                    threadEndReceive02.IsBackground = true;
                    threadEndReceive02.Start(socketEndConnection02);
                }
            }
            catch { }
        }
        //机尾2号通信函数
        private void MsgReceive32(object obj)
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
                        txtBox_LogEnd2.AppendText(strReceiveMsg);
                    }
                }
            }
            catch { }
        }
    }
}
