using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace MusicPlayer
{
    public partial class Form1 : Form
    {
        //声明一个list用来存储文件的路径
        List<string> urlList = new List<string>();
        double max, min;
        int index = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        //添加歌曲
        private void btn_MusicAdd_Click(object sender, EventArgs e)
        {
            //实例化一个打开文件的对话框
            OpenFileDialog of = new OpenFileDialog();
            //让选择器可以多选文件
            of.Multiselect = true;
            of.Title = "请选择音乐文件";
            //指定文件的类型
            of.Filter = "(*).mp3 | *.mp3";
            if (of.ShowDialog() == DialogResult.OK)
            {
                //文件名包含路径
                string[] nameList = of.FileNames;
                foreach (string name in nameList)
                {
                    urlList.Add(name);
                    //去除文件的扩展名以及路径
                    string url = Path.GetFileNameWithoutExtension(name);
                    //Console.WriteLine(url);
                    listBox_Musics.Items.Add(url);
                }
            }
        }
        //播放
        private void btn_Player_Click(object sender, EventArgs e)
        {
            
            if (listBox_Musics.SelectedIndex<0 || index != listBox_Musics.SelectedIndex)
            {
                if (listBox_Musics.SelectedItem != null)
                    index = listBox_Musics.SelectedIndex;
                listBox_Musics.SelectedItem = listBox_Musics.Items[index];
                //lbl_MusicName.Text = listBox_Musics.Items[index].ToString();
                wmp_Music.URL = urlList[index];
            }
            else
                wmp_Music.Ctlcontrols.play();
            tim_Play.Enabled = true;
        }

        private void btn_Pause_Click(object sender, EventArgs e)
        {
            wmp_Music.Ctlcontrols.pause();
            tim_Play.Enabled = false;
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            wmp_Music.Ctlcontrols.stop();
            tim_Play.Enabled = false;
        }

        private void btn_Previous_Click(object sender, EventArgs e)
        {
            if (listBox_Musics.SelectedIndex > 0)
                listBox_Musics.SelectedIndex--;
            else
                listBox_Musics.SelectedIndex = listBox_Musics.Items.Count - 1;
            //Console.WriteLine(listBox_Musics.SelectedIndex);
            //lbl_MusicName.Text = listBox_Musics.Items[listBox_Musics.SelectedIndex].ToString();
            wmp_Music.URL = urlList[listBox_Musics.SelectedIndex];
            tim_Play.Enabled = true;
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            //Console.WriteLine(listBox_Musics.Items.Count - 1);
            if (listBox_Musics.SelectedIndex < listBox_Musics.Items.Count - 1)
                listBox_Musics.SelectedIndex++;
            else
                listBox_Musics.SelectedIndex = 0;
            //Console.WriteLine(listBox_Musics.SelectedIndex);
            //lbl_MusicName.Text = listBox_Musics.Items[listBox_Musics.SelectedIndex].ToString();
            wmp_Music.URL = urlList[listBox_Musics.SelectedIndex];
            tim_Play.Enabled = true;
        }
        //列表选择发生变化时，播放选中的歌曲
        private void listBox_Musics_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_MusicName.Text = listBox_Musics.Items[listBox_Musics.SelectedIndex].ToString();
            ////获取当前选中歌曲的索引
            //int selectedIndex = listBox_Musics.SelectedIndex;
            ////把获取的索引地址赋值给wmp_Music.URL
            //wmp_Music.URL = urlList[selectedIndex];
            ////wmp_Music.URL = "D:\\音乐\\金玟岐 - 岁月神偷 (Demo).mp3";
        }

        private void listBox_Musics_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //获取当前选中歌曲的索引
            //int selectedIndex = listBox_Musics.SelectedIndex;
            //把获取的索引地址赋值给wmp_Music.URL
            //lbl_MusicName.Text = listBox_Musics.Items[listBox_Musics.SelectedIndex].ToString();
            wmp_Music.URL = urlList[listBox_Musics.SelectedIndex];
            tim_Play.Enabled = true;
        }

        private void tim_Refresh_Tick(object sender, EventArgs e)
        {
            if (listBox_Musics.Items.Count == 0)
            {
                btn_Player.Enabled = false;
                btn_Pause.Enabled = false;
                btn_Stop.Enabled = false;
                btn_Previous.Enabled = false;
                btn_Next.Enabled = false;
            }
            else
            {
                btn_Player.Enabled = true;
                btn_Pause.Enabled = true;
                btn_Stop.Enabled = true;
                btn_Previous.Enabled = true;
                btn_Next.Enabled = true;
            }
        }
        int tick = 0;
        private void tim_Play_Tick(object sender, EventArgs e)
        {
            //获取文件的时间长度;
            max = wmp_Music.currentMedia.duration;
            //获取当前歌曲的播放位置
            min = wmp_Music.Ctlcontrols.currentPosition;
            //类型强转
            tbr_Sch.Maximum = (int)max;
            tbr_Sch.Value = (int)min;

            if(wmp_Music.playState == WMPPlayState.wmppsStopped)
            {
                tim_Play.Enabled = false;
                if(listBox_Musics.SelectedIndex >= 0 && listBox_Musics.SelectedIndex < listBox_Musics.Items.Count - 1)
                {
                    wmp_Music.URL = urlList[++listBox_Musics.SelectedIndex];
                    tim_Play.Enabled = true;
                }
                else
                {
                    listBox_Musics.SelectedIndex = 0;
                    wmp_Music.URL = urlList[listBox_Musics.SelectedIndex];
                    tim_Play.Enabled = true;
                }
            }
            Console.WriteLine(tick++);
        }

        private void tbr_Sch_MouseDown(object sender, MouseEventArgs e)
        {
            //鼠标按下时，获取播放时的位置
            tim_Play.Enabled = false;
            wmp_Music.Ctlcontrols.pause();
        }

        private void tbr_Sch_MouseUp(object sender, MouseEventArgs e)
        {
            double doValue = tbr_Sch.Value;
            wmp_Music.Ctlcontrols.currentPosition = doValue;
            tim_Play.Enabled = true;
            wmp_Music.Ctlcontrols.play();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
