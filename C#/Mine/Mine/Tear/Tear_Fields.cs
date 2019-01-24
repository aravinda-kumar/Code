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
        #region 用于监听的线程和套接字
        //用于监听机头处的线程和套接字
        Thread threadHeadWatch01 = null;
        Thread threadHeadWatch02 = null;
        Thread threadHeadWatch03 = null;

        Socket socketHeadWatch01 = null;
        Socket socketHeadWatch02 = null;
        Socket socketHeadWatch03 = null;

        //用于监听重锤处的线程和套接字
        Thread threadHamWatch01 = null;
        Thread threadHamWatch02 = null;
        Thread threadHamWatch03 = null;

        Socket socketHamWacth01 = null;
        Socket socketHamWacth02 = null;
        Socket socketHamWacth03 = null;

        //用于监听机尾处的线程和套接字
        Thread threadEndWatch01 = null;
        Thread threadEndWatch02 = null;
        Thread threadEndWatch03 = null;

        Socket socketEndWatch01 = null;
        Socket socketEndWatch02 = null;
        Socket socketEndWatch03 = null;
        #endregion


        #region 用于通信的线程和套接字
        Thread threadHeadReceive01 = null;
        Socket socketHeadConnection01 = null;

        Thread threadHeadReceive02 = null;
        Socket socketHeadConnection02 = null;

        Thread threadHeadReceive03 = null;
        Socket socketHeadConnection03 = null;

        Thread threadHamReceive01 = null;
        Socket socketHamConnection01 = null;

        Thread threadHamReceive02 = null;
        Socket socketHamConnection02 = null;

        Thread threadHamReceive03 = null;
        Socket socketHamConnection03 = null;

        Thread threadEndReceive01 = null;
        Socket socketEndConnection01 = null;

        Thread threadEndReceive02 = null;
        Socket socketEndConnection02 = null;

        Thread threadEndReceive03 = null;
        Socket socketEndConnection03 = null;
        #endregion

        //图片索引
        
        //机头位置
        int _picIndex11 = 0;
        int _picIndex12 = 0;
        int _picIndex13 = 0;

        //重锤位置
        int _picIndex21 = 0;
        int _picIndex22 = 0;
        int _picIndex23 = 0;

        //机尾位置
        int _picIndex31 = 0;
        int _picIndex32 = 0;
        int _picIndex33 = 0;
    }
}