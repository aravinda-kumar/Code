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


namespace Mine
{
    public partial class FormDeviation : Form
    {
        //全部复位
        private void btn_Reset_Click(object sender, EventArgs e)
        {
            //断开所有连接，复位所有数据
            txtBox_LogEnd.Text = txtBox_LogHam.Text = txtBox_LogHead.Text = "";
            lbl_End_Nums.Text = lbl_Ham_Nums.Text = lbl_Head_Nums.Text = "0";

            //将消息数字归零
            _MsgNumbers01 = _MsgNumbers02 = _MsgNumbers03 = 0;

            //断开所有连接
            lbl_EndNotice.Text = "机尾未连接";
            lbl_HamNotice.Text = "重锤未连接";
            lbl_HeadNotice.Text = "机头未连接";

            //全部连接按钮有效
            btn_ConnectedALL.Enabled = true;
            //全部断开按钮禁用
            btn_DisConnectedALL.Enabled = false;
            //状态复位按钮禁用
            btn_Reset.Enabled = false;
            //所有独立连接按钮启用
            btn_EndConnect.Enabled = btn_HamConnect.Enabled = btn_HeadConnect.Enabled = true;
            //机尾断开禁用
            btn_EndDisConnect.Enabled = btn_HamDisConnect.Enabled = btn_HeadDisConnect.Enabled = false;

            //所有定时器停止
            timer_pic_end.Enabled = timer_pic_ham.Enabled = timer_pic_head.Enabled = false;

            //取消相应套接字和线程
            if (socketWatch01 != null)
                socketWatch01.Close();
            if (socketConnection01 != null)
                socketConnection01.Close();
            if (threadReceive01 != null)
                threadReceive01.Abort();
            if (threadWatch01 != null)
                threadWatch01.Abort();

            if (socketWatch02 != null)
                socketWatch02.Close();
            if (socketConnection02 != null)
                socketConnection02.Close();
            if (threadReceive02 != null)
                threadReceive02.Abort();
            if (threadWatch02 != null)
                threadWatch02.Abort();

            if (socketWatch03 != null)
                socketWatch03.Close();
            if (socketConnection03 != null)
                socketConnection03.Close();
            if (threadReceive03 != null)
                threadReceive03.Abort();
            if (threadWatch03 != null)
                threadWatch03.Abort();

            //图片回复正常状态图片；
            pic_End.Image = pic_Ham.Image = pic_Head.Image = imgList_Alarm.Images[0];
        }
    }
}