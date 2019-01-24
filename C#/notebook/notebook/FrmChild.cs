using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Collections;
using System.IO;

namespace notebook
{
    public partial class FrmChild : Form
    {
        public FrmChild()
        {
            InitializeComponent();
        }
        //窗体加载事件
        private void FrmChild_Load(object sender, EventArgs e)
        {
            //窗体加载时加载系统字体
            InstalledFontCollection myFonts = new InstalledFontCollection();
            FontFamily[] ff = myFonts.Families;
            ArrayList list = new ArrayList();
            //获取系统数组的列表中集合的长度
            int count = ff.Length;
            //使用for循环，把字体名称写入到控件中
            for (int i = 0; i < count; i++)
            {
                string fontName = ff[i].Name;
                tscbox_Fonts.Items.Add(fontName);
            }
        }
        //加粗按钮
        private void tsbtn_Bold_Click(object sender, EventArgs e)
        {
            //点击按钮加粗，加粗时再点击按钮取消加粗
            //判断当前字体是加粗
            if(txtBox_Note.Font.Bold)
            {
                txtBox_Note.Font = new Font(txtBox_Note.Font, FontStyle.Regular);
            }
            else
            {
                txtBox_Note.Font = new Font(txtBox_Note.Font, FontStyle.Bold);
            }
        }

        private void tsbtn_Italic_Click(object sender, EventArgs e)
        {
            //点击倾斜，倾斜时再点击按钮取消倾斜
            //判断当前字体是倾斜
            if (txtBox_Note.Font.Italic)
            {
                txtBox_Note.Font = new Font(txtBox_Note.Font, FontStyle.Regular);
            }
            else
            {
                txtBox_Note.Font = new Font(txtBox_Note.Font, FontStyle.Italic);
            }
        }
        //改变选择字体的索引事件
        private void tscbox_Fonts_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fontName = tscbox_Fonts.Items[tscbox_Fonts.SelectedIndex].ToString();
            float fontSize = txtBox_Note.Font.Size;
            txtBox_Note.Font = new Font(fontName, fontSize);
        }
        //改变选择字体的索引事件
        private void tscbox_Size_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fontName = txtBox_Note.Font.Name;
            float fontSize = float.Parse(tscbox_Size.Items[tscbox_Size.SelectedIndex].ToString());
            txtBox_Note.Font = new Font(fontName, fontSize);
        }

        private void tscbox_Size_TextChanged(object sender, EventArgs e)
        {
            string fontName = txtBox_Note.Font.Name;
            float fontSize = txtBox_Note.Font.Size;
            if(float.TryParse(tscbox_Size.Text, out fontSize))
            {
                txtBox_Note.Font = new Font(fontName, fontSize);
            }
            else
            {
                MessageBox.Show("无效字体大小");
            }
        }

        private void tscbox_Fonts_TextChanged(object sender, EventArgs e)
        {

        }
        //保存文档
        private void tsbtn_Save_Click(object sender, EventArgs e)
        {
            if (this.Text == "")
            //if(txtBox_Note.Text.Trim() != "")
            {
                
                //新建一个保存文件的对话框
                //创建一个格式筛选器/过滤器
                saveFileDialog.Filter = "文本文档(*).txt| *.txt";
                //判断用户点击的是保存按钮还是点击按钮
                if(saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //保存文件到用户指定的目录位置
                    //获取用户选择的文件及路径
                    string path = saveFileDialog.FileName;
                    //保存文件到指定的路径
                    //StreamWriter sw = new StreamWriter(path, false);
                    //sw.WriteLine(txtBox_Note.Text.Trim());
                    //sw.Flush();
                    //sw.Close();
                    using (StreamWriter sw = new StreamWriter(path, false))
                    {
                        sw.WriteLine(txtBox_Note.Text.Trim());
                        sw.Flush();
                        this.Text = path;
                    }
                }
            }
            else
            {
                //this.Text.Remove(this.Text.Length - 1);
                using (StreamWriter sw = new StreamWriter(this.Text, false))
                {
                    sw.WriteLine(txtBox_Note.Text.Trim());
                    sw.Flush();
                }
            }
            _Mark = null;
        }
        //打开文档
        private void tsbtn_Open_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "文本文档(*).txt| *.txt";
            //判断用户点击的按钮
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //获取打开文档的路径
                string path = openFileDialog.FileName;
                //读文件，并转为通用的编码规格
                using (StreamReader sr = new StreamReader(path, Encoding.UTF8))
                {
                    txtBox_Note.Text = sr.ReadToEnd();
                    this.Text = path;
                }
            }
        }
        string _Mark = null;
        private void txtBox_Note_TextChanged(object sender, EventArgs e)
        {
            _Mark = "Change";
        }
        
        private void FrmChild_FormClosing(object sender, FormClosingEventArgs e)
        {
            //根据标记的内容决定是都该提示弹窗
            if (_Mark != null)
            {
                if (MessageBox.Show("文档被修改，是否保存?", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    tsbtn_Save_Click(this, e);
                }
            }
        }

        private void tsbtn_New_Click(object sender, EventArgs e)
        {
            txtBox_Note.Text = "";
            _Mark = null;
            this.Text = "";
        }
    }
}
