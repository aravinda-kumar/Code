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
        //全部清除
        private void btn_ClearALL_Click(object sender, EventArgs e)
        {
            //将所有日志文本框中的内容清空，其他空间不改变状态
            txtBox_LogEnd1.Text = txtBox_LogEnd2.Text = txtBox_LogEnd3.Text = "";
            txtBox_LogHam1.Text = txtBox_LogHam2.Text = txtBox_LogHam3.Text = "";
            txtBox_LogHead1.Text = txtBox_LogHead2.Text = txtBox_LogHead3.Text = "";
        }
    }
}
