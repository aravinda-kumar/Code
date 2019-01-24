﻿using System;
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
        //机尾1号监听函数
        private void WatchConnecting31(object obj)
        {
            //为了避免断开连接时候报异常，用了try()catch()结构
            try
            {
                Socket socketServer = obj as Socket;
                while (true)
                {
                    socketEndConnection01 = socketServer.Accept();
                    //建立连接之后启用机尾断开按钮
                    if (socketEndConnection01 != null)
                        btn_EndDisconnect1.Enabled = true;
                    string strIP = "远程主机：" + socketEndConnection01.RemoteEndPoint + "连接成功。";
                    lbl_EndNotice1.Text = strIP;

                    threadEndReceive01 = new Thread(new ParameterizedThreadStart(MsgReceive31));
                    threadEndReceive01.IsBackground = true;
                    threadEndReceive01.Start(socketEndConnection01);
                }
            }
            catch { }
        }
        //机尾1号通信函数
        private void MsgReceive31(object obj)
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
                        txtBox_LogEnd1.AppendText(strReceiveMsg);
                    }
                }
            }
            catch { }
        }
    }
}
