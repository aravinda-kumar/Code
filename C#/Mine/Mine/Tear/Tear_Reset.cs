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
        //状态复位
        private void btn_Reset_Click(object sender, EventArgs e)
        {
            //全部断开禁用
            btn_DisconnectedALL.Enabled = false;
            //全部清空禁用
            btn_ClearALL.Enabled = false;
            //状态复位禁用
            btn_Reset.Enabled = false;
            //全部连接启用
            btn_ConnectedALL.Enabled = true;
            //所有独立连接启用
            btn_EndConnect1.Enabled = btn_EndConnect2.Enabled = btn_EndConnect3.Enabled = true;
            btn_HamConnect1.Enabled = btn_HamConnect2.Enabled = btn_HamConnect3.Enabled = true;
            btn_HeadConnect1.Enabled = btn_HeadConnect2.Enabled = btn_HeadConnect3.Enabled = true;
            //所有独立断开禁用
            btn_EndDisconnect1.Enabled = btn_EndDisconnect2.Enabled = btn_EndDisconnect3.Enabled = false;
            btn_HamDisconnect1.Enabled = btn_HamDisconnect2.Enabled = btn_HamDisconnect3.Enabled = false;
            btn_HeadDisconnect1.Enabled = btn_HeadDisconnect2.Enabled = btn_HeadDisconnect3.Enabled = false;

            //所有文本框清空
            txtBox_LogEnd1.Text = txtBox_LogEnd2.Text = txtBox_LogEnd3.Text = "";
            txtBox_LogHam1.Text = txtBox_LogHam2.Text = txtBox_LogHam3.Text = "";
            txtBox_LogHead1.Text = txtBox_LogHead2.Text = txtBox_LogHead3.Text = "";

            //所有定时器停止
            timer_End1.Enabled = timer_End2.Enabled = timer_End3.Enabled = false;
            timer_Ham1.Enabled = timer_Ham2.Enabled = timer_Ham3.Enabled = false;
            timer_Head1.Enabled = timer_Head2.Enabled = timer_Head3.Enabled = false;

            //图片恢复默认值
            picBox_End1.Image = picBox_End2.Image = picBox_End3.Image = imgList_Alarm.Images[0];
            picBox_Ham1.Image = picBox_Ham2.Image = picBox_Ham3.Image = imgList_Alarm.Images[0];
            picBox_Head1.Image = picBox_Head2.Image = picBox_Head3.Image = imgList_Alarm.Images[0];

            //提示信息恢复未连接
            lbl_EndNotice1.Text = "机尾1号未连接";
            lbl_EndNotice2.Text = "机尾2号未连接";
            lbl_EndNotice3.Text = "机尾3号未连接";

            lbl_HamNotice1.Text = "重锤1号未连接";
            lbl_HamNotice2.Text = "重锤2号未连接";
            lbl_HamNotice3.Text = "重锤3号未连接";

            lbl_HeadNotice1.Text = "机头1号未连接";
            lbl_HeadNotice2.Text = "机头2号未连接";
            lbl_HeadNotice3.Text = "机头3号未连接";

            //抛弃所有监听线程和套接字实例
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
            if (socketHeadConnection01 != null)
                socketHeadConnection01.Close();

            if (threadHeadReceive02 != null)
                threadHeadReceive02.Abort();
            if (socketHeadConnection02 != null)
                socketHeadConnection02.Close();

            if (threadHeadReceive03 != null)
                threadHeadReceive03.Abort();
            if (socketHeadConnection03 != null)
                socketHeadConnection03.Close();

            if (threadHamReceive01 != null)
                threadHamReceive01.Abort();
            if (socketHamConnection01 != null)
                socketHamConnection01.Close();

            if (threadHamReceive02 != null)
                threadHamReceive02.Abort();
            if (socketHamConnection02 != null)
                socketHamConnection02.Close();

            if (threadHamReceive03 != null)
                threadHamReceive03.Abort();
            if (socketHamConnection03 != null)
                socketHamConnection03.Close();

            if (threadEndReceive01 != null)
                threadEndReceive01.Abort();
            if (socketEndConnection01 != null)
                socketEndConnection01.Close();

            if (threadEndReceive02 != null)
                threadEndReceive02.Abort();
            if (socketEndConnection02 != null)
                socketEndConnection02.Close();

            if (threadEndReceive03 != null)
                threadEndReceive03.Abort();
            if (socketEndConnection03 != null)
                socketEndConnection03.Close();
        }
    }
}
