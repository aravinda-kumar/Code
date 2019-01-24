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
/// 机头相机连接
/// </summary>
namespace Mine
{
    public partial class FormDeviation : Form
    {
        //监听函数
        private void WatchConnecting03(object obj)
        {
            //为了避免断开连接时候报异常，用了try()catch()结构
            try
            {
                Socket socketServer = obj as Socket;
                while (true)
                {
                    socketConnection03 = socketServer.Accept();
                    //建立连接之后启用机尾断开按钮
                    if (socketConnection03 != null)
                        btn_HeadDisConnect.Enabled = true;
                    string strIP = "远程主机：" + socketConnection03.RemoteEndPoint + "连接成功。";
                    lbl_HeadNotice.Text = strIP;

                    threadReceive03 = new Thread(new ParameterizedThreadStart(MsgReceive03));
                    threadReceive03.IsBackground = true;
                    threadReceive03.Start(socketConnection03);
                }
            }
            catch { }
        }
        //通信函数
        private void MsgReceive03(object obj)
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
                        lbl_Head_Nums.Text = (++_MsgNumbers03).ToString();
                        txtBox_LogHead.AppendText(strReceiveMsg);
                        if (mediaPlayerAlarm.playState == WMPLib.WMPPlayState.wmppsUndefined || mediaPlayerAlarm.playState == WMPLib.WMPPlayState.wmppsStopped)
                            mediaPlayerAlarm.URL = @"E:\JZS\CsharpNote\Mine\Mine\Resources\bak\机头 处皮带发生跑偏.mp3";
                    }
                }
            }
            catch { }
        }
    }
}