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
        //构造函数
        public FormDeviation()
        {
            //初始化相关控件内容
            InitializeComponent();
            //允许线程初始化控件
            CheckForIllegalCrossThreadCalls = false;
        }

        //窗口装载事件
        private void FormDeviation_Load(object sender, EventArgs e)
        {
            //全部连接按钮启动
            btn_ConnectedALL.Enabled = true;
            //将全部退出按钮禁用
            btn_DisConnectedALL.Enabled = false;
            //状态复位按钮禁用
            btn_Reset.Enabled = false;
            //启用所有独立连接
            btn_EndConnect.Enabled = btn_HamConnect.Enabled = btn_HeadConnect.Enabled = true;
            //机尾断开禁用
            btn_EndDisConnect.Enabled = btn_HamDisConnect.Enabled = btn_HeadDisConnect.Enabled = false;
        }

        

        
    }
}
