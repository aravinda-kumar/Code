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
        //日志文本框中内容发生变化
        private void txtBox_LogHead1_TextChanged(object sender, EventArgs e)
        {
            //文本框中不为空，向日志中增加语句，指示灯闪烁
            if (txtBox_LogHead1.Text != null)
            {
                timer_Head1.Enabled = true;
                picBox_Head1.Image = imgList_Alarm.Images[_picIndex11];
                WriteLog.WriteToLogFile("机头撕裂报警日志.txt", "机头处撕裂！");
            }
            else
            {
                //关闭指示灯
                timer_Head1.Enabled = false;
            }
        }

        private void txtBox_LogHead2_TextChanged(object sender, EventArgs e)
        {
            //文本框中不为空，向日志中增加语句，指示灯闪烁
            if (txtBox_LogHead2.Text != null)
            {
                timer_Head2.Enabled = true;
                picBox_Head2.Image = imgList_Alarm.Images[_picIndex12];
                WriteLog.WriteToLogFile("机头撕裂报警日志.txt", "机头处撕裂！");
            }
            else
            {
                //关闭指示灯
                timer_Head2.Enabled = false;
            }
        }

        private void txtBox_LogHead3_TextChanged(object sender, EventArgs e)
        {
            //文本框中不为空，向日志中增加语句，指示灯闪烁
            if (txtBox_LogHead3.Text != null)
            {
                timer_Head3.Enabled = true;
                picBox_Head3.Image = imgList_Alarm.Images[_picIndex13];
                WriteLog.WriteToLogFile("机头撕裂报警日志.txt", "机头处出现撕裂！");
            }
            else
            {
                //关闭指示灯
                timer_Head3.Enabled = false;
            }
        }

        private void txtBox_LogHam1_TextChanged(object sender, EventArgs e)
        {
            //文本框中不为空，向日志中增加语句，指示灯闪烁
            if (txtBox_LogHam1.Text != null)
            {
                timer_Ham1.Enabled = true;
                picBox_Ham1.Image = imgList_Alarm.Images[_picIndex21];
                WriteLog.WriteToLogFile("重锤撕裂报警日志.txt", "重锤处出现撕裂！");
            }
            else
            {
                //关闭指示灯
                timer_Ham1.Enabled = false;
            }
        }

        private void txtBox_LogHam2_TextChanged(object sender, EventArgs e)
        {
            //文本框中不为空，向日志中增加语句，指示灯闪烁
            if (txtBox_LogHam2.Text != null)
            {
                timer_Ham2.Enabled = true;
                picBox_Ham2.Image = imgList_Alarm.Images[_picIndex22];
                WriteLog.WriteToLogFile("重锤撕裂报警日志.txt", "重锤处出现撕裂！");
            }
            else
            {
                //关闭指示灯
                timer_Ham2.Enabled = false;
            }
        }

        private void txtBox_LogHam3_TextChanged(object sender, EventArgs e)
        {
            //文本框中不为空，向日志中增加语句，指示灯闪烁
            if (txtBox_LogHam3.Text != null)
            {
                timer_Ham3.Enabled = true;
                picBox_Ham3.Image = imgList_Alarm.Images[_picIndex23];
                WriteLog.WriteToLogFile("重锤撕裂报警日志.txt", "重锤处出现撕裂！");
            }
            else
            {
                //关闭指示灯
                timer_Ham3.Enabled = false;
            }
        }

        private void txtBox_LogEnd1_TextChanged(object sender, EventArgs e)
        {
            //文本框中不为空，向日志中增加语句，指示灯闪烁
            if (txtBox_LogEnd1.Text != null)
            {
                timer_End1.Enabled = true;
                picBox_End1.Image = imgList_Alarm.Images[_picIndex31];
                WriteLog.WriteToLogFile("机尾撕裂报警日志.txt", "机尾处出现撕裂！");
            }
            else
            {
                //关闭指示灯
                timer_End1.Enabled = false;
            }
        }

        private void txtBox_LogEnd2_TextChanged(object sender, EventArgs e)
        {
            //文本框中不为空，向日志中增加语句，指示灯闪烁
            if (txtBox_LogEnd2.Text != null)
            {
                timer_End2.Enabled = true;
                picBox_End2.Image = imgList_Alarm.Images[_picIndex32];
                WriteLog.WriteToLogFile("机尾撕裂报警日志.txt", "机尾处出现撕裂！");
            }
            else
            {
                //关闭指示灯
                timer_End2.Enabled = false;
            }
        }

        private void txtBox_LogEnd3_TextChanged(object sender, EventArgs e)
        {
            //文本框中不为空，向日志中增加语句，指示灯闪烁
            if (txtBox_LogEnd3.Text != null)
            {
                timer_End3.Enabled = true;
                picBox_End3.Image = imgList_Alarm.Images[_picIndex33];
                WriteLog.WriteToLogFile("机尾撕裂报警日志.txt", "机尾处出现撕裂！");
            }
            else
            {
                //关闭指示灯
                timer_End3.Enabled = false;
            }
        }
    }
}
