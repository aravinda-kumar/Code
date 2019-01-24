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
/// 本文件中存放的是撕裂文件中所用的所有字段
/// </summary>
namespace Mine
{
    public partial class FormDeviation : Form
    {
        //用于监听机尾处的线程和套接字
        Thread threadWatch01 = null;
        Socket socketWatch01 = null;

        //用于监听重锤处的线程和套接字
        Thread threadWatch02 = null;
        Socket socketWatch02 = null;

        //用于监听机头处的线程和套接字
        Thread threadWatch03 = null;
        Socket socketWatch03 = null;

        //用于记录接收到的消息数
        long _MsgNumbers01 = 0;
        long _MsgNumbers02 = 0;
        long _MsgNumbers03 = 0;

        //用于通信的线程和套接字
        Thread threadReceive01 = null;
        Socket socketConnection01 = null;

        Thread threadReceive02 = null;
        Socket socketConnection02 = null;

        Thread threadReceive03 = null;
        Socket socketConnection03 = null;

        //图片索引
        int _picIndex01 = 0;
        int _picIndex02 = 0;
        int _picIndex03 = 0;
    }
}