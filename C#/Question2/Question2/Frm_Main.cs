using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question2
{
    public partial class Main_Frm : Form
    {
        public Main_Frm()
        {
            InitializeComponent();
        }

        private void Main_Frm_Load(object sender, EventArgs e)
        {
            //主窗口加载开始计时
            timer_Now.Enabled = true;
            var dt = DateTime.Now;
            lbl_TimeNow.Text = dt.ToLongTimeString().ToString();

            //生成引导界面
            Guide guide = new Guide();
            guide.ShowDialog();
        }
        Frm_Server server = null;
        //打开服务器端的界面
        private void btn_Server_Click(object sender, EventArgs e)
        {
            if (server == null)
            {
                server = new Frm_Server();
                server.Show();
                //子窗口关闭后释放实例
                server.FormClosing += ReleaseObjct_Server;
            }
            else
            {
                server.Activate();
            }
        }
        private void ReleaseObjct_Server(object sender, FormClosingEventArgs e)
        {
            //释放实例
            server = null;
        }

        Frm_Client client = null;
        int client_Count = 0;
        //打开客户端的界面
        private void btn_Client_Click(object sender, EventArgs e)
        {
            if(client_Count<3)
            {
                client = new Frm_Client();
                client.Show();
                client.FormClosing += ReleaseObjct_Client;
                client_Count++;
            }
        }
        private void ReleaseObjct_Client(object sender, FormClosingEventArgs e)
        {
            client_Count--;
            //释放实例
            //client = null;
        }
        //主窗口关闭时间
        private void Main_Frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //判断主窗口关闭前是否还有子窗口打开，若存在子窗口，则禁止关闭
            if (server != null || client_Count > 0) 
            {
                if (MessageBox.Show("请关闭所有子窗口！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    //按下确定按钮后，取消关闭主窗口
                    e.Cancel = true;
                }
            }
        }

        //计时中断时间
        private void timer_Now_Tick(object sender, EventArgs e)
        {
            //刷新当前时间
            var dt = DateTime.Now;
            lbl_TimeNow.Text = dt.ToLongTimeString().ToString();
        }
    }
}
