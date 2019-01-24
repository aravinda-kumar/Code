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
        //构造函数
        public FormTear()
        {
            //初始化相关内容
            InitializeComponent();
            //允许子线程操作控件
            CheckForIllegalCrossThreadCalls = false;
        }

        //装载函数
        private void FormTear_Load(object sender, EventArgs e)
        {
            //全部断开禁用
            btn_DisconnectedALL.Enabled = false;
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
        }
    }
}
