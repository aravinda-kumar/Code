using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 皮带跑偏与撕裂检测监控界面
{
    public partial class TearFrm : Form
    {
        public TearFrm()
        {
            InitializeComponent();
        }

        //文件存放主目录
        string dirPath = Path.GetDirectoryName(Application.ExecutablePath);

        //用来存放机头位置照片的文件名的列表和数组
        List<string> listFileFullNameHead = new List<string>();
        string[] strFileFullNameHead = null;

        //用来存放重锤位置照片的文件名的列表和数组
        List<string> listFileFullNameHam = new List<string>();
        string[] strFileFullNameHam = null;

        //用来存放机尾位置照片的文件名的列表和数组
        List<string> listFileFullNameEnd = new List<string>();
        string[] strFileFullNameEnd = null;

        //报警音url
        string alarmHeadURL = null;
        string alarmHamURL = null;
        string alarmEndURL = null;

        //定义用来闪烁的定时器
        System.Timers.Timer timer_Head_New = new System.Timers.Timer(500);
        System.Timers.Timer timer_Ham_New = new System.Timers.Timer(500);
        System.Timers.Timer timer_End_New = new System.Timers.Timer(500);

        private void TearFrm_Load(object sender, EventArgs e)
        {
            //允许线程操作控件
            CheckForIllegalCrossThreadCalls = false;

            //将播放器音量预设为100
            MediaPlayerHead.settings.volume = 100;
            MediaPlayerHam.settings.volume = 100;
            MediaPlayerEnd.settings.volume = 100;

            //创建相关的文件和目录
            CheckRequestDirectory();
            CreateRequestFile();

            //返回机头照片目录下的所有bmp文件的完成路径
            strFileFullNameHead = Directory.GetFiles(dirPath + "/日志/机头撕裂照片", "*.bmp");
            foreach (var item in strFileFullNameHead)
            {
                listBox_Head.Items.Insert(0, Path.GetFileNameWithoutExtension(item));
                listFileFullNameHead.Insert(0, item);
            }

            //返回重锤照片目录下的所有bmp文件的完成路径
            strFileFullNameHam = Directory.GetFiles(dirPath + "/日志/重锤撕裂照片", "*.bmp");
            foreach (var item in strFileFullNameHam)
            {
                listBox_Ham.Items.Insert(0, Path.GetFileNameWithoutExtension(item));
                listFileFullNameHam.Insert(0, item);
            }

            //返回机尾照片目录下的所有bmp文件的完成路径
            strFileFullNameEnd = Directory.GetFiles(dirPath + "/日志/机尾撕裂照片", "*.bmp");
            foreach (var item in strFileFullNameEnd)
            {
                listBox_End.Items.Insert(0, Path.GetFileNameWithoutExtension(item));
                listFileFullNameEnd.Insert(0, item);
            }

            //获得报警音url
            alarmHeadURL = GetalarmHeadURL();
            alarmHamURL = GetalarmHamURL();
            alarmEndURL = GetalarmEndURL();

            //初始化定时器
            timer_Head_New.Elapsed += new System.Timers.ElapsedEventHandler(HeadTimeOut);
            timer_Head_New.AutoReset = true;

            timer_Ham_New.Elapsed += new System.Timers.ElapsedEventHandler(HamTimeOut);
            timer_Ham_New.AutoReset = true;

            timer_End_New.Elapsed += new System.Timers.ElapsedEventHandler(EndTimeOut);
            timer_End_New.AutoReset = true;
            //MediaPlayerEnd.URL = @"C:\Users\SHUNCS\Desktop\李宗盛 - 鬼迷心窍.mp3";

            //timer_Head_New.Enabled = true;
            //timer_Ham_New.Enabled = true;
            //timer_End_New.Enabled = true;
        }

        #region 辅助函数
        private void CheckRequestDirectory()
        {
            if (Directory.Exists(dirPath + "/日志/机头撕裂照片/历史照片") == false)
            {
                Directory.CreateDirectory(dirPath + "/日志/机头撕裂照片/历史照片");
            }
            if (Directory.Exists(dirPath + "/日志/重锤撕裂照片/历史照片") == false)
            {
                Directory.CreateDirectory(dirPath + "/日志/重锤撕裂照片/历史照片");
            }
            if (Directory.Exists(dirPath + "/日志/机尾撕裂照片/历史照片") == false)
            {
                Directory.CreateDirectory(dirPath + "/日志/机尾撕裂照片/历史照片");
            }
        }

        private void CreateRequestFile()
        {
            string configHeadPath = Path.GetDirectoryName(Application.ExecutablePath) + "\\机头位置撕裂报警音配置文件";
            FileStream fsHead = new FileStream(configHeadPath, FileMode.OpenOrCreate);
            fsHead.Close();

            string configHamPath = Path.GetDirectoryName(Application.ExecutablePath) + "\\重锤位置撕裂报警音配置文件";
            FileStream fsHam = new FileStream(configHamPath, FileMode.OpenOrCreate);
            fsHam.Close();

            string configEndPath = Path.GetDirectoryName(Application.ExecutablePath) + "\\机尾位置撕裂报警音配置文件";
            FileStream fsEnd = new FileStream(configEndPath, FileMode.OpenOrCreate);
            fsEnd.Close();
        }

       static ReaderWriterLockSlim WriteToLogFileLock = new ReaderWriterLockSlim();
        public void WriteToLogFile(string fileFullName, string message)
        {
            try
            {
                WriteToLogFileLock.EnterWriteLock();
                //获取当前执行文件所在路径
                string LogPath = Path.GetDirectoryName(Application.ExecutablePath) + "\\日志\\" + fileFullName;
                //文件存在追加内容，不存在创建文件
                using (StreamWriter sw = new StreamWriter(LogPath, true))
                {
                    sw.WriteLine(message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                WriteToLogFileLock.ExitWriteLock();
            }
        }

        #endregion

        #region 选择照片
        private void listBox_Head_SelectedIndexChanged(object sender, EventArgs e)
        {
            picBox_Head.ImageLocation = listFileFullNameHead[listBox_Head.SelectedIndex];
        }

        private void listBox_Ham_SelectedIndexChanged(object sender, EventArgs e)
        {
            picBox_Ham.ImageLocation = listFileFullNameHam[listBox_Ham.SelectedIndex];
        }

        private void listBox_End_SelectedIndexChanged(object sender, EventArgs e)
        {
            picBox_End.ImageLocation = listFileFullNameEnd[listBox_End.SelectedIndex];
        }
        #endregion

        #region 指示灯开始闪烁
        private void txtBox_Head_TextChanged(object sender, EventArgs e)
        {
            if (txtBox_Head.Text != "")
            {
                timer_Head_New.Enabled = true;
            }
        }

        private void txtBox_Ham_TextChanged(object sender, EventArgs e)
        {
            if (txtBox_Ham.Text != "")
            {
                timer_Ham_New.Enabled = true;
            }
        }

        private void txtBox_End_TextChanged(object sender, EventArgs e)
        {
            if (txtBox_End.Text != "")
            {
                timer_End_New.Enabled = true;
            }
        }

        #endregion

        #region 静音设置
        int flag_Head = 0;
        private void btn_Head_Sound_Click(object sender, EventArgs e)
        {
            if (flag_Head == 0)
            {
                btn_Head_Sound.Text = "响铃";
                MediaPlayerHead.settings.volume = 0;
                flag_Head++;
            }
            else
            {
                btn_Head_Sound.Text = "静音";
                MediaPlayerHead.settings.volume = 100;
                flag_Head = 0;
            }
        }

        int flag_Ham = 0;
        private void btn_Ham_Sound_Click(object sender, EventArgs e)
        {
            if (flag_Ham == 0)
            {
                btn_Ham_Sound.Text = "响铃";
                MediaPlayerHam.settings.volume = 0;
                flag_Ham++;
            }
            else
            {
                btn_Ham_Sound.Text = "静音";
                MediaPlayerHam.settings.volume = 100;
                flag_Ham = 0;
            }
        }

        int flag_End = 0;
        private void btn_End_Sound_Click(object sender, EventArgs e)
        {
            if (flag_End == 0)
            {
                btn_End_Sound.Text = "响铃";
                MediaPlayerEnd.settings.volume = 0;
                flag_End++;
            }
            else
            {
                btn_End_Sound.Text = "静音";
                MediaPlayerEnd.settings.volume = 100;
                flag_End = 0;
            }
        }
        #endregion

        #region 指示灯控制
        int timerFlagHead = 0;
        private void HeadTimeOut(object source, System.Timers.ElapsedEventArgs e)
        {
            //txtBox_Head.Text = txtBox_Head.Text.Insert(0, DateTime.Now.ToString("yyyy年MM月dd日HH时mm分ss秒ffff毫秒") + "\r\n");
            //WriteToLogFile("机头皮带撕裂详细记录.txt", DateTime.Now.ToString("yyyy年MM月dd日HH时mm分ss秒ffff毫秒") + "\r\n");
            if (timerFlagHead == 0)
            {
                picBox_Head_Light.Image = Properties.Resources.r_1;
                timerFlagHead = 1;
            }
            else
            {
                picBox_Head_Light.Image = Properties.Resources.g_1;
                timerFlagHead = 0;
            }
        }

        int timerFlagHam = 0;
        private void HamTimeOut(object source, System.Timers.ElapsedEventArgs e)
        {
            //txtBox_Ham.Text = txtBox_Ham.Text.Insert(0, DateTime.Now.ToString("yyyy年MM月dd日HH时mm分ss秒ffff毫秒") + "\r\n");
            //WriteToLogFile("重锤皮带撕裂详细记录.txt", DateTime.Now.ToString("yyyy年MM月dd日HH时mm分ss秒ffff毫秒") + "\r\n");
            if (timerFlagHam == 0)
            {
                picBox_Ham_Light.Image = Properties.Resources.r_1;
                timerFlagHam = 1;
            }
            else
            {
                picBox_Ham_Light.Image = Properties.Resources.g_1;
                timerFlagHam = 0;
            }
        }

        int timerFlagEnd = 0;
        private void EndTimeOut(object source, System.Timers.ElapsedEventArgs e)
        {
            //txtBox_End.Text = txtBox_End.Text.Insert(0, DateTime.Now.ToString("yyyy年MM月dd日HH时mm分ss秒ffff毫秒") + "\r\n");
            //WriteToLogFile("机尾皮带撕裂详细记录.txt", DateTime.Now.ToString("yyyy年MM月dd日HH时mm分ss秒ffff毫秒") + "\r\n");
            if (timerFlagEnd == 0)
            {
                picBox_End_Light.Image = Properties.Resources.r_1;
                timerFlagEnd = 1;
            }
            else
            {
                picBox_End_Light.Image = Properties.Resources.g_1;
                timerFlagEnd = 0;
            }
        }
        private void btn_Head_StopFlicker_Click(object sender, EventArgs e)
        {
            picBox_Head_Light.Image = Properties.Resources.g_1;
            timer_Head_New.Enabled = false;
        }

        private void btn_Ham_StopFlicker_Click(object sender, EventArgs e)
        {
            picBox_Ham_Light.Image = Properties.Resources.g_1;
            timer_Ham_New.Enabled = false;
        }

        private void btn_End_StopFlicker_Click(object sender, EventArgs e)
        {
            picBox_End_Light.Image = Properties.Resources.g_1;
            timer_End_New.Enabled = false;
        }
        #endregion

        #region 系统复位
        private void btn_Head_Reset_Click(object sender, EventArgs e)
        {
            picBox_Head.ImageLocation = null;
            picBox_Head.Image = null;

            for (int index = 0; index < listFileFullNameHead.Count; index++)
            {
                string dstName = dirPath + "/日志/机头撕裂照片/历史照片/" + listBox_Head.Items[index] + ".bmp";
                File.Move(listFileFullNameHead[index], dstName);
            }
            listBox_Head.Items.Clear();
            listFileFullNameHead.Clear();

            txtBox_Head.Clear();
        }

        private void btn_Ham_Reset_Click(object sender, EventArgs e)
        {
            picBox_Ham.Image = null;
            picBox_Ham.ImageLocation = null;

            for (int index = 0; index < listFileFullNameHam.Count; index++)
            {
                string dstName = dirPath + "/日志/重锤撕裂照片/历史照片/" + listBox_Ham.Items[index] + ".bmp";
                File.Move(listFileFullNameHam[index], dstName);
            }
            listBox_Ham.Items.Clear();
            listFileFullNameHam.Clear();

            txtBox_Ham.Clear();
        }

        private void btn_End_Reset_Click(object sender, EventArgs e)
        {
            picBox_End.Image = null;
            picBox_End.ImageLocation = null;

            for (int index = 0; index < listFileFullNameEnd.Count; index++)
            {
                string dstName = dirPath + "/日志/机尾撕裂照片/历史照片/" + listBox_End.Items[index] + ".bmp";
                File.Move(listFileFullNameEnd[index], dstName);
            }
            listBox_End.Items.Clear();
            listFileFullNameEnd.Clear();

            txtBox_End.Clear();
        }
        #endregion

        #region 菜单栏功能设置
        private void 打开日志文件夹ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = dirPath + "\\日志";
            //Console.WriteLine(path);
            System.Diagnostics.Process.Start("Explorer.exe", path);
        }

        private void 机头撕裂报警音设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = dirPath;
            ofd.Title = "请选择要设置的报警声音";
            ofd.Filter = "音频文件|*.mp3;*.wav";
            ofd.ShowDialog();
            alarmHeadURL = ofd.FileName;
            string configPath = Path.GetDirectoryName(Application.ExecutablePath) + "\\机头位置撕裂报警音配置文件";
            //文件存在追加内容，不存在创建文件
            using (StreamWriter sw = new StreamWriter(configPath))
            {
                sw.WriteLine(alarmHeadURL);
            }
        }

        private string GetalarmHeadURL()
        {
            string configPath = Path.GetDirectoryName(Application.ExecutablePath) + "\\机头位置撕裂报警音配置文件";
            string Url = null;
            using (StreamReader sr = new StreamReader(configPath))
            {
                Url = sr.ReadLine();
            }
            return Url;
        }

        private void 重锤撕裂报警音设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = dirPath;
            ofd.Title = "请选择要设置的报警声音";
            ofd.Filter = "音频文件|*.mp3;*.wav";
            ofd.ShowDialog();
            alarmHamURL = ofd.FileName;
            string configPath = Path.GetDirectoryName(Application.ExecutablePath) + "\\重锤位置撕裂报警音配置文件";
            //文件存在追加内容，不存在创建文件
            using (StreamWriter sw = new StreamWriter(configPath))
            {
                sw.WriteLine(alarmHamURL);
            }
        }

        private string GetalarmHamURL()
        {
            string configPath = Path.GetDirectoryName(Application.ExecutablePath) + "\\重锤位置撕裂报警音配置文件";
            string Url = null;
            using (StreamReader sr = new StreamReader(configPath))
            {
                Url = sr.ReadLine();
            }
            return Url;
        }

        private void 机尾撕裂报警音设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = dirPath;
            ofd.Title = "请选择要设置的报警声音";
            ofd.Filter = "音频文件|*.mp3;*.wav";
            ofd.ShowDialog();
            alarmEndURL = ofd.FileName;
            string configPath = Path.GetDirectoryName(Application.ExecutablePath) + "\\机尾位置撕裂报警音配置文件";
            //文件存在追加内容，不存在创建文件
            using (StreamWriter sw = new StreamWriter(configPath))
            {
                sw.WriteLine(alarmEndURL);
            }
        }

        private string GetalarmEndURL()
        {
            string configPath = Path.GetDirectoryName(Application.ExecutablePath) + "\\机尾位置撕裂报警音配置文件";
            string Url = null;
            using (StreamReader sr = new StreamReader(configPath))
            {
                Url = sr.ReadLine();
            }
            return Url;
        }

        private void 清空机头照片ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            picBox_Head.Image = null;
            picBox_Head.ImageLocation = null;
        }

        private void 清空重锤照片ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            picBox_Ham.Image = null;
            picBox_Ham.ImageLocation = null;
        }

        private void 清空机尾照片ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            picBox_End.Image = null;
            picBox_End.ImageLocation = null;
        }

        private void 清空机头照片候选框ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            picBox_Head.Image = null;
            picBox_Head.ImageLocation = null;
            for (int index = 0; index < listFileFullNameHead.Count; index++)
            {
                string dstName = dirPath + "/日志/机头撕裂照片/历史照片/" + listBox_Head.Items[index] + ".bmp";
                File.Move(listFileFullNameHead[index], dstName);
            }
            listBox_Head.Items.Clear();
            listFileFullNameHead.Clear();
        }

        private void 清空重锤照片候选框ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            picBox_Ham.Image = null;
            picBox_Ham.ImageLocation = null;
            for (int index = 0; index < listFileFullNameHam.Count; index++)
            {
                string dstName = dirPath + "/日志/重锤撕裂照片/历史照片/" + listBox_Ham.Items[index] + ".bmp";
                File.Move(listFileFullNameHam[index], dstName);
            }
            listBox_Ham.Items.Clear();
            listFileFullNameHam.Clear();
        }

        private void 清空机尾照片候选框ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            picBox_End.Image = null;
            picBox_End.ImageLocation = null;
            for (int index = 0; index < listFileFullNameEnd.Count; index++)
            {
                string dstName = dirPath + "/日志/机尾撕裂照片/历史照片/" + listBox_End.Items[index] + ".bmp";
                File.Move(listFileFullNameEnd[index], dstName);
            }
            listBox_End.Items.Clear();
            listFileFullNameEnd.Clear();
        }

        private void 清空机头报警日志ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtBox_Head.Text = "";
        }

        private void 清空重锤报警日志ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtBox_Ham.Text = "";
        }

        private void 清空机尾报警日志ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtBox_End.Text = "";
        }
        #endregion

        Thread threadWatchHead01 = null;
        Thread threadWatchHead02 = null;
        Thread threadWatchHead03 = null;
        private void btn_Head_Connect_Click(object sender, EventArgs e)
        {
            threadWatchHead01 = new Thread(WatchConnectingHead01);
            threadWatchHead01.IsBackground = true;
            threadWatchHead01.Start();

            threadWatchHead02 = new Thread(WatchConnectingHead02);
            threadWatchHead02.IsBackground = true;
            threadWatchHead02.Start();

            threadWatchHead03 = new Thread(WatchConnectingHead03);
            threadWatchHead03.IsBackground = true;
            threadWatchHead03.Start();
        }

        private void WatchConnectingHead01()
        {
            Console.WriteLine("现在时间是{0}", DateTime.Now.ToString("yyyy年MM月dd日HH时mm分ss秒ffff毫秒"));
            lock (this)
            {
                string Msg = DateTime.Now.ToString("yyyy年MM月dd日HH时mm分ss秒ffff毫秒") + "\r\n";
                txtBox_Head.Text = txtBox_Head.Text.Insert(0, Msg);
                WriteToLogFile("机头皮带撕裂详细记录.txt", Msg);
            }
            
        }
        private void WatchConnectingHead02()
        {
            Console.WriteLine("现在时间是{0}", DateTime.Now.ToString("yyyy年MM月dd日HH时mm分ss秒ffff毫秒"));
            lock (this)
            {
                string Msg = DateTime.Now.ToString("yyyy年MM月dd日HH时mm分ss秒ffff毫秒") + "\r\n";
                txtBox_Head.Text = txtBox_Head.Text.Insert(0, Msg);
                WriteToLogFile("机头皮带撕裂详细记录.txt", Msg);
            }
        }
        private void WatchConnectingHead03()
        {
            Console.WriteLine("现在时间是{0}", DateTime.Now.ToString("yyyy年MM月dd日HH时mm分ss秒ffff毫秒"));
            lock (this)
            {
                string Msg = DateTime.Now.ToString("yyyy年MM月dd日HH时mm分ss秒ffff毫秒") + "\r\n";
                txtBox_Head.Text = txtBox_Head.Text.Insert(0, Msg);
                WriteToLogFile("机头皮带撕裂详细记录.txt", Msg);
            }
        }

        Thread threadWatchHam01 = null;
        Thread threadWatchHam02 = null;
        Thread threadWatchHam03 = null;
        private void btn_Ham_Connect_Click(object sender, EventArgs e)
        {
            
        }
        Thread threadWatchEnd01 = null;
        Thread threadWatchEnd02 = null;
        Thread threadWatchEnd03 = null;
        private void btn_End_Connect_Click(object sender, EventArgs e)
        {
            
        }

        private void TearFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer_Head_New.Enabled = false;
            timer_Ham_New.Enabled = false;
            timer_End_New.Enabled = false;

            if (threadWatchHead01 != null)
            {
                threadWatchHead01.Abort();
            }

            if (threadWatchHead02 != null)
            {
                threadWatchHead02.Abort();
            }

            if (threadWatchHead03 != null)
            {
                threadWatchHead03.Abort();
            }

            if (threadWatchHam01 != null)
            {
                threadWatchHam01.Abort();
            }

            if (threadWatchHam02 != null)
            {
                threadWatchHam02.Abort();
            }

            if (threadWatchHam03 != null)
            {
                threadWatchHam03.Abort();
            }

            if (threadWatchEnd01 != null)
            {
                threadWatchEnd01.Abort();
            }

            if (threadWatchEnd02 != null)
            {
                threadWatchEnd02.Abort();
            }

            if (threadWatchEnd03 != null)
            {
                threadWatchEnd03.Abort();
            }
        }
    }
}
