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
        //全部断开
        private void btn_DisconnectedALL_Click(object sender, EventArgs e)
        {
            //按钮状态恢复
            btn_ConnectedALL.Enabled = true;
            btn_Reset.Enabled = true;
            btn_DisconnectedALL.Enabled = false;

            btn_EndConnect1.Enabled = btn_EndConnect2.Enabled = btn_EndConnect3.Enabled = true;
            btn_HamConnect1.Enabled = btn_HamConnect2.Enabled = btn_HamConnect3.Enabled = true;
            btn_HeadConnect1.Enabled = btn_HeadConnect2.Enabled = btn_HeadConnect3.Enabled = true;

            btn_EndDisconnect1.Enabled = btn_EndDisconnect2.Enabled = btn_EndDisconnect3.Enabled = false;
            btn_HamDisconnect1.Enabled = btn_HamDisconnect2.Enabled = btn_HamDisconnect3.Enabled = false;
            btn_HeadDisconnect1.Enabled = btn_HeadDisconnect2.Enabled = btn_HeadDisconnect3.Enabled = false;

            //断开所有连接
            lbl_EndNotice1.Text = "机尾1号未连接";
            lbl_EndNotice2.Text = "机尾2号未连接";
            lbl_EndNotice3.Text = "机尾3号未连接";

            lbl_HamNotice1.Text = "重锤1号未连接";
            lbl_HamNotice2.Text = "重锤2号未连接";
            lbl_HamNotice3.Text = "重锤3号未连接";

            lbl_HeadNotice1.Text = "机头1号未连接";
            lbl_HeadNotice2.Text = "机头2号未连接";
            lbl_HeadNotice3.Text = "机头3号未连接";

            //关闭所有定时器
            timer_End1.Enabled = timer_End2.Enabled = timer_End3.Enabled = false;
            timer_Ham1.Enabled = timer_Ham2.Enabled = timer_Ham3.Enabled = false;
            timer_Head1.Enabled = timer_Head2.Enabled = timer_Head3.Enabled = false;

            //断开套接字线程实例的链接
            if (threadHeadWatch01 != null)
                threadHeadWatch01.Abort();
            if (threadHeadWatch02 != null)
                threadHeadWatch02.Abort();
            if (threadHeadWatch03 != null)
                threadHeadWatch03.Abort();

            if (socketHeadWatch01 != null)
                socketHeadWatch01.Close();
            if (socketHeadWatch02 != null)
                socketHeadWatch02.Close();
            if (socketHeadWatch03 != null)
                socketHeadWatch03.Close();

            if (threadHamWatch01 != null)
                threadHamWatch01.Abort();
            if (threadHamWatch02 != null)
                threadHamWatch02.Abort();
            if (threadHamWatch03 != null)
                threadHamWatch03.Abort();

            if (socketHamWacth01 != null)
                socketHamWacth01.Close();
            if (socketHamWacth02 != null)
                socketHamWacth02.Close();
            if (socketHamWacth03 != null)
                socketHamWacth03.Close();

            if (threadEndWatch01 != null)
                threadEndWatch01.Abort();
            if (threadEndWatch02 != null)
                threadEndWatch02.Abort();
            if (threadEndWatch03 != null)
                threadEndWatch03.Abort();

            if (socketEndWatch01 != null)
                socketEndWatch01.Close();
            if (socketEndWatch02 != null)
                socketEndWatch02.Close();
            if (socketEndWatch03 != null)
                socketEndWatch03.Close();

            //抛弃所有通信线程和套接字实例
            if (threadHeadReceive01 != null)
                threadHeadReceive01.Abort();
            if (threadHeadReceive02 != null)
                threadHeadReceive02.Abort();
            if (threadHeadReceive03 != null)
                threadHeadReceive03.Abort();

            if (socketHeadConnection01 != null)
                socketHeadConnection01.Close();
            if (socketHeadConnection02 != null)
                socketHeadConnection02.Close();           
            if (socketHeadConnection03 != null)
                socketHeadConnection03.Close();

            if (threadHamReceive01 != null)
                threadHamReceive01.Abort();
            if (threadHamReceive02 != null)
                threadHamReceive02.Abort();
            if (threadHamReceive03 != null)
                threadHamReceive03.Abort();

            if (socketHamConnection01 != null)
                socketHamConnection01.Close();  
            if (socketHamConnection02 != null)
                socketHamConnection02.Close();           
            if (socketHamConnection03 != null)
                socketHamConnection03.Close();

            if (threadEndReceive01 != null)
                threadEndReceive01.Abort();
            if (threadEndReceive02 != null)
                threadEndReceive02.Abort();
            if (threadEndReceive03 != null)
                threadEndReceive03.Abort();

            if (socketEndConnection01 != null)
                socketEndConnection01.Close();
            if (socketEndConnection02 != null)
                socketEndConnection02.Close();       
            if (socketEndConnection03 != null)
                socketEndConnection03.Close();
        }
    }
}
