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
        //全部清空事件
        private void btn_ClearALL_Click(object sender, EventArgs e)
        {
            //将文本框个表格中的数据清除
            txtBox_LogEnd.Text = txtBox_LogHam.Text = txtBox_LogHead.Text = "";
            lbl_End_Nums.Text = lbl_Ham_Nums.Text = lbl_Head_Nums.Text = "0";

            //将消息数字归零
            _MsgNumbers01 = _MsgNumbers02 = _MsgNumbers03 = 0;
        }
    }
}