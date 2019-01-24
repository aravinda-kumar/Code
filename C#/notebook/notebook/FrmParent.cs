using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notebook
{
    public partial class FrmParent : Form
    {
        public FrmParent()
        {
            InitializeComponent();
        }
        //新建
        private void tsm_NewItem_Click(object sender, EventArgs e)
        {
            //实例化一个子窗体对象
            FrmChild child = new FrmChild();
            //设置窗体的父窗体
            child.MdiParent = this;
            child.Show();
        }
        //关闭
        private void tsm_Close_Click(object sender, EventArgs e)
        {
            FrmChild frm = (this.ActiveMdiChild) as FrmChild;
            frm.Close();
        }
        //关闭全部
        private void tsm_CloseAll_Click(object sender, EventArgs e)
        {
            //获取当前父窗口的子窗口的集合；
            Form[] frms = (this.MdiChildren);
            foreach (var form in frms)
                form.Close();
        }
        //退出
        private void tsm_Quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
