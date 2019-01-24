using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 皮带跑偏与撕裂检测监控界面
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        TearFrm tearFrm = null;
        //创建撕裂检测界面
        private void btn_Tear_Click(object sender, EventArgs e)
        {
            //判断子窗口是否有实例
            if (tearFrm == null)
            {
                tearFrm = new TearFrm();
                tearFrm.Show();
                //子窗口关闭后增加释放实例的功能
                tearFrm.FormClosing += ReleaseObjct_Tear;
            }
            else
            {
                //存在子窗口打开的时候，重新选择打开的子窗口
                tearFrm.Activate();
            }
        }
        //释放撕裂界面示例事件
        private void ReleaseObjct_Tear(object sender, FormClosingEventArgs e)
        {
            //释放实例
            tearFrm = null;
        }

        DeviationFrm deviationFrm = null;
        //创建跑偏检测界面
        private void btn_Deviation_Click(object sender, EventArgs e)
        {
            //判断子窗口是否有实例
            if (deviationFrm == null)
            {
                deviationFrm = new DeviationFrm();
                deviationFrm.Show();
                //子窗口关闭后增加释放实例的功能
                deviationFrm.FormClosing += ReleaseObjct_Deviation;
            }
            else
            {
                //存在子窗口打开的时候，重新选择打开的子窗口
                deviationFrm.Activate();
            }
        }
        //释放跑偏界面示例事件
        private void ReleaseObjct_Deviation(object sender, FormClosingEventArgs e)
        {
            //释放实例
            deviationFrm = null;
        }

        //退出程序
        private void btn_Quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //窗口关闭时触发事件
        private void MainFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //判断主窗口关闭前是否还有子窗口打开
            //只要有一个子窗口打开，主窗口就不允许关闭
            if (tearFrm != null || deviationFrm != null)
            {
                if (MessageBox.Show("请关闭所有子窗口！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    //按下确定按钮后，取消关闭主窗口
                    e.Cancel = true;
                }
            }
        }
    }
}
