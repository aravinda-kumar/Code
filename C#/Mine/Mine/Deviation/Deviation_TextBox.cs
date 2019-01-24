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
        //文本框内容改变事件
        private void txtBox_LogEnd_TextChanged(object sender, EventArgs e)
        {
            //文本框中不为空，向日志中增加语句，指示灯闪烁
            if (txtBox_LogEnd.Text != null)
            {
                timer_pic_end.Enabled = true;
                pic_End.Image = imgList_Alarm.Images[_picIndex01];
                WriteLog.WriteToLogFile("机尾跑偏报警日志.txt", "机尾处出现跑偏！");
            }
            else
            {
                //关闭指示灯
                timer_pic_end.Enabled = false;
            }

        }

        private void txtBox_LogHam_TextChanged(object sender, EventArgs e)
        {
            if (txtBox_LogHam.Text != null)
            {
                timer_pic_ham.Enabled = true;
                pic_Ham.Image = imgList_Alarm.Images[_picIndex02];
                WriteLog.WriteToLogFile("重锤跑偏报警日志.txt", "重锤处出现跑偏！");
            }
            else
            {
                timer_pic_ham.Enabled = false;
            }
        }

        private void txtBox_LogHead_TextChanged(object sender, EventArgs e)
        {
            if (txtBox_LogHead.Text != null)
            {
                timer_pic_head.Enabled = true;
                pic_Head.Image = imgList_Alarm.Images[_picIndex03];
                WriteLog.WriteToLogFile("机头跑偏报警日志.txt", "机头处出现跑偏！");
            }
            else
            {
                timer_pic_head.Enabled = false;
            }
        }
    }
}