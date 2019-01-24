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
        //计时器事件
        private void timer_pic_end_Tick(object sender, EventArgs e)
        {
            //Console.WriteLine("*************************");
            //每秒更新一次图片索引值
            _picIndex01++;
            //只有两张图片，技术到2的时候需要复位
            if (_picIndex01 == 2)
            {
                _picIndex01 = 0;
            }
        }

        private void timer_pic_ham_Tick(object sender, EventArgs e)
        {
            _picIndex02++;
            if (_picIndex02 == 2)
            {
                _picIndex02 = 0;
            }
        }

        private void timer_pic_head_Tick(object sender, EventArgs e)
        {
            _picIndex03++;
            if (_picIndex03 == 2)
            {
                _picIndex03 = 0;
            }
        }
    }
}