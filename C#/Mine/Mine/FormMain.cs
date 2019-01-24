using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mine
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        //弹出皮带撕裂检测窗口
        internal FormTear frmTear;
        private void ReleaseObjct_Tear(object sender, FormClosingEventArgs e)
        {
            //释放实例
            frmTear = null;
        }
        private void btn_Tear_Click(object sender, EventArgs e)
        {
            if(frmTear == null)
            {
                frmTear = new FormTear();
                frmTear.Show();
                //子窗口关闭后增加释放实例的功能
                frmTear.FormClosing += ReleaseObjct_Tear;
            }
            else
            {
                //存在子窗口打开的时候，重新选择打开的子窗口
                frmTear.Activate();
            }
        }

        //弹出皮带跑偏检测窗口
        //函数用来后期释放出窗口
        private void ReleaseObjct_Deviation(object sender, FormClosingEventArgs e)
        {
            //释放实例
            frmDeviation = null;
        }
        internal FormDeviation frmDeviation;
        private void btn_Deviation_Click(object sender, EventArgs e)
        {
            if(frmDeviation == null)
            {
                frmDeviation = new FormDeviation();
                frmDeviation.Show();
                //子窗口关闭后增加释放实例的功能
                frmDeviation.FormClosing += ReleaseObjct_Deviation;
            }
            else
            {
                //存在子窗口打开的时候，重新选择打开的子窗口
                frmDeviation.Activate();
            }
            
        }
        //退出按钮
        private void btn_Quit_Click(object sender, EventArgs e)
        {
            timer_SysTime.Enabled = false;
            this.Close();
        }
        //窗口加载时打开计时器
        private void Form_Main_Load(object sender, EventArgs e)
        {
            timer_SysTime.Enabled = true;
            //为了使主窗口上不出现空白
            //主窗口加载的时候就显示一串时间标记
            var dt = DateTime.Now;
            lbl_Time.Text = dt.ToLongTimeString().ToString();
        }
        //计时工具
        //每秒刷新一次label
        private void timer_SysTime_Tick(object sender, EventArgs e)
        {
            var dt = DateTime.Now;
            lbl_Time.Text = dt.ToLongTimeString().ToString();
        }

        private void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            //判断主窗口关闭前是否还有子窗口打开
            //只要有一个子窗口打开，主窗口就不允许关闭
            if(frmDeviation != null || frmTear != null)
            {
                if(MessageBox.Show("请关闭所有子窗口！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    //按下确定按钮后，取消关闭主窗口
                    e.Cancel = true;
                }
            }
        }
    }
}
