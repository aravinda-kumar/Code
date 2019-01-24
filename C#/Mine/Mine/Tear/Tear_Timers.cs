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
        //计时器事件
        private void timer_Head1_Tick(object sender, EventArgs e)
        {
            //每秒更新一次图片索引值
            _picIndex11++;
            //只有两张图片，技术到2的时候需要复位
            if (_picIndex11 == 2)
            {
                _picIndex11 = 0;
            }
        }

        private void timer_Head2_Tick(object sender, EventArgs e)
        {
            //每秒更新一次图片索引值
            _picIndex12++;
            //只有两张图片，技术到2的时候需要复位
            if (_picIndex12 == 2)
            {
                _picIndex12 = 0;
            }
        }

        private void timer_Head3_Tick(object sender, EventArgs e)
        {
            //每秒更新一次图片索引值
            _picIndex13++;
            //只有两张图片，技术到2的时候需要复位
            if (_picIndex13 == 2)
            {
                _picIndex13 = 0;
            }
        }

        private void timer_Ham1_Tick(object sender, EventArgs e)
        {
            //每秒更新一次图片索引值
            _picIndex21++;
            //只有两张图片，技术到2的时候需要复位
            if (_picIndex21 == 2)
            {
                _picIndex21 = 0;
            }
        }

        private void timer_Ham2_Tick(object sender, EventArgs e)
        {
            //每秒更新一次图片索引值
            _picIndex22++;
            //只有两张图片，技术到2的时候需要复位
            if (_picIndex22 == 2)
            {
                _picIndex22 = 0;
            }
        }

        private void timer_Ham3_Tick(object sender, EventArgs e)
        {
            //每秒更新一次图片索引值
            _picIndex23++;
            //只有两张图片，技术到2的时候需要复位
            if (_picIndex23 == 2)
            {
                _picIndex23 = 0;
            }
        }

        private void timer_End1_Tick(object sender, EventArgs e)
        {
            //每秒更新一次图片索引值
            _picIndex31++;
            //只有两张图片，技术到2的时候需要复位
            if (_picIndex31 == 2)
            {
                _picIndex31 = 0;
            }
        }

        private void timer_End2_Tick(object sender, EventArgs e)
        {
            //每秒更新一次图片索引值
            _picIndex32++;
            //只有两张图片，技术到2的时候需要复位
            if (_picIndex32 == 2)
            {
                _picIndex32 = 0;
            }
        }

        private void timer_End3_Tick(object sender, EventArgs e)
        {
            //每秒更新一次图片索引值
            _picIndex33++;
            //只有两张图片，技术到2的时候需要复位
            if (_picIndex33 == 2)
            {
                _picIndex33 = 0;
            }
        }
    }
}