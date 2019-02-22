using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
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
            try
            {
                picBox_Head.ImageLocation = listFileFullNameHead[listBox_Head.SelectedIndex];
            }
            catch  {}
        }

        private void listBox_Ham_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                picBox_Ham.ImageLocation = listFileFullNameHam[listBox_Ham.SelectedIndex];
            }
            catch { }
        }

        private void listBox_End_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                picBox_End.ImageLocation = listFileFullNameEnd[listBox_End.SelectedIndex];
            }
            catch { }
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

        #region 机头连接
        private void btn_Head_Connect_Click(object sender, EventArgs e)
        {
            StartConnectHead01();
            StartConnectHead02();
            StartConnectHead03();
        }

        Thread threadWatchHead01 = null;
        Socket socketWatchHead01 = null;
        private void StartConnectHead01()
        {
            string headIP01 = "192.168.0.201";
            string headPort01 = "8234";
            socketWatchHead01 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPAddress ipAddressHead01 = IPAddress.Parse(headIP01.Trim());
            IPEndPoint endPointHead01 = new IPEndPoint(ipAddressHead01, int.Parse(headPort01.Trim()));
            socketWatchHead01.Bind(endPointHead01);
            socketWatchHead01.Listen(20);

            threadWatchHead01 = new Thread(new ParameterizedThreadStart(WatchConnectingHead01));
            threadWatchHead01.IsBackground = true;
            threadWatchHead01.Start(socketWatchHead01);
            lbl_Head_State_01.Text = "等待连接";
        }

        Socket socketServerHead01 = null;
        Socket socketConnectionHead01 = null;
        Thread threadReceiveHead01 = null;
        private void WatchConnectingHead01(object obj)
        {
            try
            {
                socketServerHead01 = obj as Socket;
                while (true)
                {
                    socketConnectionHead01 = socketServerHead01.Accept();
                    if (socketConnectionHead01 != null)
                    {
                        btn_Head_Connect.Enabled = false;
                        lbl_Head_State_01.Text = "连接成功";
                        threadReceiveHead01 = new Thread(new ParameterizedThreadStart(MsgReceiveHead01));
                        threadReceiveHead01.IsBackground = true;
                        threadReceiveHead01.Start(socketConnectionHead01);
                    }
                }
            }
            catch
            {
                //MessageBox.Show("相机连接失败，请关闭窗口重新连接！");
            }
        }

        //用来存放二进制数据的list
        List<byte> list_Binary_head01 = new List<byte>();

        //通信函数
        string alarmHeadMsg01 = null;
        Socket socketReceiveHead01 = null;
        private void MsgReceiveHead01(Object obj)
        {
            try
            {
                socketReceiveHead01 = obj as Socket;
                while (true)
                {
                    byte[] headinfo = new byte[5];
                    int headinfoLength = socketReceiveHead01.Receive(headinfo, headinfo.Length, SocketFlags.None);
                    if (headinfoLength == 0) break;
                    string info = Encoding.UTF8.GetString(headinfo, 0, headinfoLength);
                    Console.WriteLine("info={0}", info);
                    if (info[0] == '0' && info[1] == '0' && info[2] == '0' && info[3] == '0')
                    {
                        byte[] headLevelInfo = new byte[5];
                        int levelLength = socketReceiveHead01.Receive(headLevelInfo, headLevelInfo.Length, SocketFlags.None);
                        if (levelLength == 0)
                        {
                            //如果没有接收到文件，则结束循环
                            break;
                        }
                        string strMsg = Encoding.UTF8.GetString(headLevelInfo, 0, levelLength);
                        Console.WriteLine("strMsg={0}", strMsg);
                        if (strMsg[0] == '1')
                        {
                            //textBox_Head.AppendText("机头处皮带发生轻微跑偏");
                            alarmHeadMsg01 = "机头01处皮带发生轻微撕裂\r\n";
                        }
                        if (strMsg[0] == '2')
                        {
                            alarmHeadMsg01 = "机头01处皮带发生严重撕裂\r\n";
                        }
                        byte[] bufferLength = new byte[10];
                        lbl_Head_Receive01.Text = "0%";
                        int msglength = socketReceiveHead01.Receive(bufferLength, bufferLength.Length, SocketFlags.None);
                        if (msglength == 0) break;
                        string str_Length = Encoding.UTF8.GetString(bufferLength, 0, msglength);
                        Console.WriteLine(str_Length);
                        int length = int.Parse(str_Length);
                        Console.WriteLine("length={0}", length);
                        int recive = length;
                        while (true)
                        {
                            byte[] buffer = new byte[1024];
                            Array.Clear(buffer, 0, buffer.Length);
                            int r = socketReceiveHead01.Receive(buffer, buffer.Length, SocketFlags.None);
                            if (r == 0) break;
                            if (length > 0)
                            {
                                for (int index = 0; index < r; index++)
                                {
                                    list_Binary_head01.Add(buffer[index]);
                                }
                                length -= r;
                                lbl_Head_Receive01.Text = ((int)(((double)(recive - length) / ((double)recive)) * 100)).ToString()+"%";
                            }
                            if (length <= 0)
                            {
                                if (lbl_Head_Receive01.Text == "100%")
                                    lbl_Head_Receive01.Text = "0%";
                                Array.Clear(buffer, 0, buffer.Length);
                                break;
                            }
                        }
                        ConvertToPicHead01(list_Binary_head01);
                    }
                    else
                    {
                        byte[] tmpBuffer = new byte[1024];
                        int tmpBufferlength = socketReceiveHead01.Receive(tmpBuffer, tmpBuffer.Length, SocketFlags.None);
                        if (tmpBufferlength == 0) break;
                        Array.Clear(tmpBuffer, 0, tmpBuffer.Length);
                    }
                }
            }
            catch{}
        }

        DateTime dtHead01;
        private void ConvertToPicHead01(List<byte> list_Binary)
        {
            byte[] pageData = list_Binary.ToArray();
            list_Binary.Clear();
            //用来设置存储图片像素值得二维矩阵
            int[,] pixels = new int[320 * 240, 3];
            int count = 0;

            //建立图像缓存数据
            var bitmap = new Bitmap(320, 240, PixelFormat.Format32bppRgb);

            for (int i = 0; i < pageData.Length - 1; i = i + 2)
            {
                //分别读取处每一个像素的值
                int intLow = pageData[i + 1];
                int tmpintHigh = pageData[i];
                int tmpHigh = tmpintHigh << 8;
                int pixel = tmpHigh | intLow;
                int red = (pixel & 0xf800) >> 11;
                int green = (pixel & 0x07e0) >> 5;
                int blue = (pixel & 0x001f);
                pixels[count, 0] = (red << 3);
                pixels[count, 1] = (green << 2);
                pixels[count, 2] = (blue << 3);
                count++;
            }
            int alpha = 0xff;
            count = 0;
            for (int y = 0; y < 240; y++)
            {
                for (int x = 0; x < 320; x++)
                {
                    bitmap.SetPixel(x, y, Color.FromArgb(alpha, pixels[count, 0], pixels[count, 1], pixels[count, 2]));
                    count++;
                }
            }

            CheckRequestDirectory();

            dtHead01 = DateTime.Now;

            string fileNameShort = dtHead01.ToString("yyyy年MM月dd日HH时mm分ss秒ffff毫秒");
            string fileName = fileNameShort + ".bmp";
            string bmpPath = dirPath + "/日志/机头撕裂照片" + "\\" + fileName;
            string logMsg = fileNameShort + ": " + alarmHeadMsg01;

            SaveandShowHead(bmpPath, fileNameShort, bitmap, logMsg);

            if (picBox_Head.Image == null)
            {
                picBox_Head.Image = bitmap;
            }
            //listFileFullNameHead.Insert(0, bmpPath);
            //listBox_Head.Items.Insert(0, Path.GetFileNameWithoutExtension(bmpPath));
            //string logMsg = fileNameShort + ": " + alarmHeadMsg01;
            //txtBox_Head.Text = txtBox_Head.Text.Insert(0, logMsg);
            //WriteToLogFile("机头皮带撕裂详细记录.txt", logMsg);
            //if (MediaPlayerHead.playState == WMPLib.WMPPlayState.wmppsUndefined || MediaPlayerHead.playState == WMPLib.WMPPlayState.wmppsStopped)
            //    MediaPlayerHead.URL = alarmHeadURL;
            //bitmap.Save(bmpPath);
        }


        Thread threadWatchHead02 = null;
        Socket socketWatchHead02 = null;
        private void StartConnectHead02()
        {
            string headIP02 = "192.168.0.201";
            string headPort02 = "8235";
            socketWatchHead02 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPAddress ipAddressHead02 = IPAddress.Parse(headIP02.Trim());
            IPEndPoint endPointHead02 = new IPEndPoint(ipAddressHead02, int.Parse(headPort02.Trim()));
            socketWatchHead02.Bind(endPointHead02);
            socketWatchHead02.Listen(20);

            threadWatchHead02 = new Thread(new ParameterizedThreadStart(WatchConnectingHead02));
            threadWatchHead02.IsBackground = true;
            threadWatchHead02.Start(socketWatchHead02);
            lbl_Head_State_02.Text = "等待连接";
        }

        Socket socketServerHead02 = null;
        Socket socketConnectionHead02 = null;
        Thread threadReceiveHead02 = null;
        private void WatchConnectingHead02(object obj)
        {
            try
            {
                socketServerHead02 = obj as Socket;
                while (true)
                {
                    socketConnectionHead02 = socketServerHead02.Accept();
                    if (socketConnectionHead02 != null)
                    {
                        btn_Head_Connect.Enabled = false;
                        lbl_Head_State_02.Text = "连接成功";
                        threadReceiveHead02 = new Thread(new ParameterizedThreadStart(MsgReceiveHead02));
                        threadReceiveHead02.IsBackground = true;
                        threadReceiveHead02.Start(socketConnectionHead02);
                    }
                }
            }
            catch
            {
                //MessageBox.Show("相机连接失败，请关闭窗口重新连接！");
            }
        }

        //用来存放二进制数据的list
        List<byte> list_Binary_head02 = new List<byte>();

        //通信函数
        string alarmHeadMsg02 = null;
        Socket socketReceiveHead02 = null;
        private void MsgReceiveHead02(Object obj)
        {
            try
            {
                socketReceiveHead02 = obj as Socket;
                while (true)
                {
                    byte[] headinfo = new byte[5];
                    int headinfoLength = socketReceiveHead02.Receive(headinfo, headinfo.Length, SocketFlags.None);
                    if (headinfoLength == 0) break;
                    string info = Encoding.UTF8.GetString(headinfo, 0, headinfoLength);
                    Console.WriteLine("info={0}", info);
                    if (info[0] == '0' && info[1] == '0' && info[2] == '0' && info[3] == '0')
                    {
                        byte[] headLevelInfo = new byte[5];
                        int levelLength = socketReceiveHead02.Receive(headLevelInfo, headLevelInfo.Length, SocketFlags.None);
                        if (levelLength == 0)
                        {
                            //如果没有接收到文件，则结束循环
                            break;
                        }
                        string strMsg = Encoding.UTF8.GetString(headLevelInfo, 0, levelLength);
                        Console.WriteLine("strMsg={0}", strMsg);
                        if (strMsg[0] == '1')
                        {
                            alarmHeadMsg02 = "机头02处皮带发生轻微撕裂\r\n";
                        }
                        if (strMsg[0] == '2')
                        {
                            alarmHeadMsg02 = "机头02处皮带发生严重撕裂\r\n";
                        }
                        byte[] bufferLength = new byte[10];
                        lbl_Head_Receive02.Text = "0%";
                        int msglength = socketReceiveHead02.Receive(bufferLength, bufferLength.Length, SocketFlags.None);
                        if (msglength == 0) break;
                        string str_Length = Encoding.UTF8.GetString(bufferLength, 0, msglength);
                        Console.WriteLine(str_Length);
                        int length = int.Parse(str_Length);
                        Console.WriteLine("length={0}", length);
                        int recive = length;
                        while (true)
                        {
                            byte[] buffer = new byte[1024];
                            Array.Clear(buffer, 0, buffer.Length);
                            int r = socketReceiveHead02.Receive(buffer, buffer.Length, SocketFlags.None);
                            if (r == 0) break;
                            if (length > 0)
                            {
                                for (int index = 0; index < r; index++)
                                {
                                    list_Binary_head02.Add(buffer[index]);
                                }
                                length -= r;
                                lbl_Head_Receive02.Text = ((int)(((double)(recive - length) / ((double)recive)) * 100)).ToString() + "%";
                            }
                            if (length <= 0)
                            {
                                if (lbl_Head_Receive02.Text == "100%")
                                    lbl_Head_Receive02.Text = "0%";
                                Array.Clear(buffer, 0, buffer.Length);
                                break;
                            }
                        }
                        ConvertToPicHead02(list_Binary_head02);
                    }
                    else
                    {
                        byte[] tmpBuffer = new byte[1024];
                        int tmpBufferlength = socketReceiveHead02.Receive(tmpBuffer, tmpBuffer.Length, SocketFlags.None);
                        if (tmpBufferlength == 0) break;
                        Array.Clear(tmpBuffer, 0, tmpBuffer.Length);
                    }
                }
            }
            catch { }
        }

        DateTime dtHead02;
        private void ConvertToPicHead02(List<byte> list_Binary)
        {
            byte[] pageData = list_Binary.ToArray();
            list_Binary.Clear();
            //用来设置存储图片像素值得二维矩阵
            int[,] pixels = new int[320 * 240, 3];
            int count = 0;

            //建立图像缓存数据
            var bitmap = new Bitmap(320, 240, PixelFormat.Format32bppRgb);

            for (int i = 0; i < pageData.Length - 1; i = i + 2)
            {
                //分别读取处每一个像素的值
                int intLow = pageData[i + 1];
                int tmpintHigh = pageData[i];
                int tmpHigh = tmpintHigh << 8;
                int pixel = tmpHigh | intLow;
                int red = (pixel & 0xf800) >> 11;
                int green = (pixel & 0x07e0) >> 5;
                int blue = (pixel & 0x001f);
                pixels[count, 0] = (red << 3);
                pixels[count, 1] = (green << 2);
                pixels[count, 2] = (blue << 3);
                count++;
            }
            int alpha = 0xff;
            count = 0;
            for (int y = 0; y < 240; y++)
            {
                for (int x = 0; x < 320; x++)
                {
                    bitmap.SetPixel(x, y, Color.FromArgb(alpha, pixels[count, 0], pixels[count, 1], pixels[count, 2]));
                    count++;
                }
            }

            CheckRequestDirectory();

            dtHead02 = DateTime.Now;

            string fileNameShort = dtHead02.ToString("yyyy年MM月dd日HH时mm分ss秒ffff毫秒");
            string fileName = fileNameShort + ".bmp";
            string bmpPath = dirPath + "/日志/机头撕裂照片" + "\\" + fileName;
            string logMsg = fileNameShort + ": " + alarmHeadMsg02;

            SaveandShowHead(bmpPath, fileNameShort, bitmap, logMsg);

            if (picBox_Head.Image == null)
            {
                picBox_Head.Image = bitmap;
            }
        }

        Thread threadWatchHead03 = null;
        Socket socketWatchHead03 = null;
        private void StartConnectHead03()
        {
            string headIP03 = "192.168.0.201";
            string headPort03 = "8236";
            socketWatchHead03 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPAddress ipAddressHead03 = IPAddress.Parse(headIP03.Trim());
            IPEndPoint endPointHead03 = new IPEndPoint(ipAddressHead03, int.Parse(headPort03.Trim()));
            socketWatchHead03.Bind(endPointHead03);
            socketWatchHead03.Listen(20);

            threadWatchHead03 = new Thread(new ParameterizedThreadStart(WatchConnectingHead03));
            threadWatchHead03.IsBackground = true;
            threadWatchHead03.Start(socketWatchHead03);
            lbl_Head_State_03.Text = "等待连接";
        }

        Socket socketServerHead03 = null;
        Socket socketConnectionHead03 = null;
        Thread threadReceiveHead03 = null;
        private void WatchConnectingHead03(object obj)
        {
            try
            {
                socketServerHead03 = obj as Socket;
                while (true)
                {
                    socketConnectionHead03 = socketServerHead03.Accept();
                    if (socketConnectionHead03 != null)
                    {
                        btn_Head_Connect.Enabled = false;
                        lbl_Head_State_03.Text = "连接成功";
                        threadReceiveHead03 = new Thread(new ParameterizedThreadStart(MsgReceiveHead03));
                        threadReceiveHead03.IsBackground = true;
                        threadReceiveHead03.Start(socketConnectionHead03);
                    }
                }
            }
            catch
            {
                //MessageBox.Show("相机连接失败，请关闭窗口重新连接！");
            }
        }

        //用来存放二进制数据的list
        List<byte> list_Binary_head03 = new List<byte>();

        //通信函数
        string alarmHeadMsg03 = null;
        Socket socketReceiveHead03 = null;
        private void MsgReceiveHead03(Object obj)
        {
            try
            {
                socketReceiveHead03 = obj as Socket;
                while (true)
                {
                    byte[] headinfo = new byte[5];
                    int headinfoLength = socketReceiveHead03.Receive(headinfo, headinfo.Length, SocketFlags.None);
                    if (headinfoLength == 0) break;
                    string info = Encoding.UTF8.GetString(headinfo, 0, headinfoLength);
                    Console.WriteLine("info={0}", info);
                    if (info[0] == '0' && info[1] == '0' && info[2] == '0' && info[3] == '0')
                    {
                        byte[] headLevelInfo = new byte[5];
                        int levelLength = socketReceiveHead03.Receive(headLevelInfo, headLevelInfo.Length, SocketFlags.None);
                        if (levelLength == 0)
                        {
                            //如果没有接收到文件，则结束循环
                            break;
                        }
                        string strMsg = Encoding.UTF8.GetString(headLevelInfo, 0, levelLength);
                        Console.WriteLine("strMsg={0}", strMsg);
                        if (strMsg[0] == '1')
                        {
                            //textBox_Head.AppendText("机头处皮带发生轻微跑偏");
                            alarmHeadMsg03 = "机头03处皮带发生轻微撕裂\r\n";
                        }
                        if (strMsg[0] == '2')
                        {
                            alarmHeadMsg03 = "机头03处皮带发生严重撕裂\r\n";
                        }
                        byte[] bufferLength = new byte[10];
                        lbl_Head_Receive03.Text = "0%";
                        int msglength = socketReceiveHead03.Receive(bufferLength, bufferLength.Length, SocketFlags.None);
                        if (msglength == 0) break;
                        string str_Length = Encoding.UTF8.GetString(bufferLength, 0, msglength);
                        Console.WriteLine(str_Length);
                        int length = int.Parse(str_Length);
                        Console.WriteLine("length={0}", length);
                        int recive = length;
                        while (true)
                        {
                            byte[] buffer = new byte[1024];
                            Array.Clear(buffer, 0, buffer.Length);
                            int r = socketReceiveHead03.Receive(buffer, buffer.Length, SocketFlags.None);
                            if (r == 0) break;
                            if (length > 0)
                            {
                                for (int index = 0; index < r; index++)
                                {
                                    list_Binary_head03.Add(buffer[index]);
                                }
                                length -= r;
                                lbl_Head_Receive03.Text = ((int)(((double)(recive - length) / ((double)recive)) * 100)).ToString() + "%";
                            }
                            if (length <= 0)
                            {
                                if (lbl_Head_Receive03.Text == "100%")
                                    lbl_Head_Receive03.Text = "0%";
                                Array.Clear(buffer, 0, buffer.Length);
                                break;
                            }
                        }
                        ConvertToPicHead03(list_Binary_head03);
                    }
                    else
                    {
                        byte[] tmpBuffer = new byte[1024];
                        int tmpBufferlength = socketReceiveHead03.Receive(tmpBuffer, tmpBuffer.Length, SocketFlags.None);
                        if (tmpBufferlength == 0) break;
                        Array.Clear(tmpBuffer, 0, tmpBuffer.Length);
                    }
                }
            }
            catch { }
        }

        DateTime dtHead03;
        private void ConvertToPicHead03(List<byte> list_Binary)
        {
            byte[] pageData = list_Binary.ToArray();
            list_Binary.Clear();
            //用来设置存储图片像素值得二维矩阵
            int[,] pixels = new int[320 * 240, 3];
            int count = 0;

            //建立图像缓存数据
            var bitmap = new Bitmap(320, 240, PixelFormat.Format32bppRgb);

            for (int i = 0; i < pageData.Length - 1; i = i + 2)
            {
                //分别读取处每一个像素的值
                int intLow = pageData[i + 1];
                int tmpintHigh = pageData[i];
                int tmpHigh = tmpintHigh << 8;
                int pixel = tmpHigh | intLow;
                int red = (pixel & 0xf800) >> 11;
                int green = (pixel & 0x07e0) >> 5;
                int blue = (pixel & 0x001f);
                pixels[count, 0] = (red << 3);
                pixels[count, 1] = (green << 2);
                pixels[count, 2] = (blue << 3);
                count++;
            }
            int alpha = 0xff;
            count = 0;
            for (int y = 0; y < 240; y++)
            {
                for (int x = 0; x < 320; x++)
                {
                    bitmap.SetPixel(x, y, Color.FromArgb(alpha, pixels[count, 0], pixels[count, 1], pixels[count, 2]));
                    count++;
                }
            }

            CheckRequestDirectory();

            dtHead03 = DateTime.Now;

            string fileNameShort = dtHead03.ToString("yyyy年MM月dd日HH时mm分ss秒ffff毫秒");
            string fileName = fileNameShort + ".bmp";
            string bmpPath = dirPath + "/日志/机头撕裂照片" + "\\" + fileName;
            string logMsg = fileNameShort + ": " + alarmHeadMsg03;

            SaveandShowHead(bmpPath, fileNameShort, bitmap, logMsg);

            if (picBox_Head.Image == null)
            {
                picBox_Head.Image = bitmap;
            }
        }

        private static readonly object lockerheadobj = new object();
        private void SaveandShowHead(string bmpPath, string fileNameShort, Bitmap bitmap, string logMsg)
        {
            //加锁程序耗时00:00:00.0577938
            //Stopwatch sw = new Stopwatch();
            //sw.Start();
            lock (lockerheadobj)
            {
                listFileFullNameHead.Insert(0, bmpPath);
                listBox_Head.Items.Insert(0, Path.GetFileNameWithoutExtension(bmpPath));
                txtBox_Head.Text = txtBox_Head.Text.Insert(0, logMsg);
                WriteToLogFile("机头皮带撕裂详细记录.txt", logMsg);
                if (MediaPlayerHead.playState == WMPLib.WMPPlayState.wmppsUndefined || MediaPlayerHead.playState == WMPLib.WMPPlayState.wmppsStopped)
                    MediaPlayerHead.URL = alarmHeadURL;
                bitmap.Save(bmpPath);
            }
            //sw.Stop();
            //Console.WriteLine("加锁程序耗时{0}", sw.Elapsed.ToString());
        }

        #endregion

        #region 重锤连接
        private void btn_Ham_Connect_Click(object sender, EventArgs e)
        {
            //StartConnectHam01();
            //StartConnectHam02();
            //StartConnectHam03();
        }

        Thread threadWatchHam01 = null;
        Socket socketWatchHam01 = null;
        private void StartConnectHam01()
        {
            string hamIP01 = "192.168.0.201";
            string hamPort01 = "8234";
            socketWatchHam01 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPAddress ipAddressHam01 = IPAddress.Parse(hamIP01.Trim());
            IPEndPoint endPointHam01 = new IPEndPoint(ipAddressHam01, int.Parse(hamPort01.Trim()));
            socketWatchHam01.Bind(endPointHam01);
            socketWatchHam01.Listen(20);

            threadWatchHam01 = new Thread(new ParameterizedThreadStart(WatchConnectingHam01));
            threadWatchHam01.IsBackground = true;
            threadWatchHam01.Start(socketWatchHam01);
            lbl_Ham_State_01.Text = "等待连接";
        }

        Socket socketServerHam01 = null;
        Socket socketConnectionHam01 = null;
        Thread threadReceiveHam01 = null;
        private void WatchConnectingHam01(object obj)
        {
            try
            {
                socketServerHam01 = obj as Socket;
                while (true)
                {
                    socketConnectionHam01 = socketServerHam01.Accept();
                    if (socketConnectionHam01 != null)
                    {
                        btn_Ham_Connect.Enabled = false;
                        lbl_Ham_State_01.Text = "连接成功!";
                        threadReceiveHam01 = new Thread(new ParameterizedThreadStart(MsgReceiveHam01));
                        threadReceiveHam01.IsBackground = true;
                        threadReceiveHam01.Start(socketConnectionHam01);
                    }
                }
            }
            catch
            {
                //MessageBox.Show("相机连接失败，请关闭窗口重新连接！");
            }
        }

        //用来存放二进制数据的list
        List<byte> list_Binary_Ham01 = new List<byte>();

        //通信函数
        string alarmHamMsg01 = null;
        Socket socketReceiveHam01 = null;
        private void MsgReceiveHam01(Object obj)
        {
            try
            {
                socketReceiveHam01 = obj as Socket;
                while (true)
                {
                    byte[] headinfo = new byte[5];
                    int headinfoLength = socketReceiveHam01.Receive(headinfo, headinfo.Length, SocketFlags.None);
                    if (headinfoLength == 0) break;
                    string info = Encoding.UTF8.GetString(headinfo, 0, headinfoLength);
                    Console.WriteLine("info={0}", info);
                    if (info[0] == '0' && info[1] == '0' && info[2] == '0' && info[3] == '0')
                    {
                        byte[] headLevelInfo = new byte[5];
                        int levelLength = socketReceiveHam01.Receive(headLevelInfo, headLevelInfo.Length, SocketFlags.None);
                        if (levelLength == 0)
                        {
                            //如果没有接收到文件，则结束循环
                            break;
                        }
                        string strMsg = Encoding.UTF8.GetString(headLevelInfo, 0, levelLength);
                        Console.WriteLine("strMsg={0}", strMsg);
                        if (strMsg[0] == '1')
                        {
                            //textBox_Head.AppendText("机头处皮带发生轻微跑偏");
                            alarmHamMsg01 = "重锤01处皮带发生轻微撕裂\r\n";
                        }
                        if (strMsg[0] == '2')
                        {
                            alarmHamMsg01 = "重锤01处皮带发生严重撕裂\r\n";
                        }
                        byte[] bufferLength = new byte[10];
                        lbl_Ham_Receive01.Text = "0%";
                        int msglength = socketReceiveHam01.Receive(bufferLength, bufferLength.Length, SocketFlags.None);
                        if (msglength == 0) break;
                        string str_Length = Encoding.UTF8.GetString(bufferLength, 0, msglength);
                        Console.WriteLine(str_Length);
                        int length = int.Parse(str_Length);
                        Console.WriteLine("length={0}", length);
                        int recive = length;
                        while (true)
                        {
                            byte[] buffer = new byte[1024];
                            Array.Clear(buffer, 0, buffer.Length);
                            int r = socketReceiveHam01.Receive(buffer, buffer.Length, SocketFlags.None);
                            if (r == 0) break;
                            if (length > 0)
                            {
                                for (int index = 0; index < r; index++)
                                {
                                    list_Binary_Ham01.Add(buffer[index]);
                                }
                                length -= r;
                                lbl_Ham_Receive01.Text = ((int)(((double)(recive - length) / ((double)recive)) * 100)).ToString() + "%";
                            }
                            if (length <= 0)
                            {
                                if (lbl_Ham_Receive01.Text == "100%")
                                    lbl_Ham_Receive01.Text = "0%";
                                Array.Clear(buffer, 0, buffer.Length);
                                break;
                            }
                        }
                        ConvertToPicHam01(list_Binary_Ham01);
                    }
                    else
                    {
                        byte[] tmpBuffer = new byte[1024];
                        int tmpBufferlength = socketReceiveHam01.Receive(tmpBuffer, tmpBuffer.Length, SocketFlags.None);
                        if (tmpBufferlength == 0) break;
                        Array.Clear(tmpBuffer, 0, tmpBuffer.Length);
                    }
                }
            }
            catch { }
        }

        DateTime dtHam01;
        private void ConvertToPicHam01(List<byte> list_Binary)
        {
            byte[] pageData = list_Binary.ToArray();
            list_Binary.Clear();
            //用来设置存储图片像素值得二维矩阵
            int[,] pixels = new int[320 * 240, 3];
            int count = 0;

            //建立图像缓存数据
            var bitmap = new Bitmap(320, 240, PixelFormat.Format32bppRgb);

            for (int i = 0; i < pageData.Length - 1; i = i + 2)
            {
                //分别读取处每一个像素的值
                int intLow = pageData[i + 1];
                int tmpintHigh = pageData[i];
                int tmpHigh = tmpintHigh << 8;
                int pixel = tmpHigh | intLow;
                int red = (pixel & 0xf800) >> 11;
                int green = (pixel & 0x07e0) >> 5;
                int blue = (pixel & 0x001f);
                pixels[count, 0] = (red << 3);
                pixels[count, 1] = (green << 2);
                pixels[count, 2] = (blue << 3);
                count++;
            }
            int alpha = 0xff;
            count = 0;
            for (int y = 0; y < 240; y++)
            {
                for (int x = 0; x < 320; x++)
                {
                    bitmap.SetPixel(x, y, Color.FromArgb(alpha, pixels[count, 0], pixels[count, 1], pixels[count, 2]));
                    count++;
                }
            }

            CheckRequestDirectory();

            dtHam01 = DateTime.Now;

            string fileNameShort = dtHam01.ToString("yyyy年MM月dd日HH时mm分ss秒ffff毫秒");
            string fileName = fileNameShort + ".bmp";
            string bmpPath = dirPath + "/日志/重锤撕裂照片" + "\\" + fileName;
            string logMsg = fileNameShort + ": " + alarmHamMsg01;

            SaveandShowHam(bmpPath, fileNameShort, bitmap, logMsg);

            if (picBox_Ham.Image == null)
            {
                picBox_Ham.Image = bitmap;
            }
        }

        Thread threadWatchHam02 = null;
        Socket socketWatchHam02 = null;
        private void StartConnectHam02()
        {
            string hamIP02 = "192.168.0.201";
            string hamPort02 = "8234";
            socketWatchHam02 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPAddress ipAddressHam02 = IPAddress.Parse(hamIP02.Trim());
            IPEndPoint endPointHam02 = new IPEndPoint(ipAddressHam02, int.Parse(hamPort02.Trim()));
            socketWatchHam02.Bind(endPointHam02);
            socketWatchHam02.Listen(20);

            threadWatchHam02 = new Thread(new ParameterizedThreadStart(WatchConnectingHam02));
            threadWatchHam02.IsBackground = true;
            threadWatchHam02.Start(socketWatchHam02);
            lbl_Ham_State_02.Text = "等待连接";
        }

        Socket socketServerHam02 = null;
        Socket socketConnectionHam02 = null;
        Thread threadReceiveHam02 = null;
        private void WatchConnectingHam02(object obj)
        {
            try
            {
                socketServerHam02 = obj as Socket;
                while (true)
                {
                    socketConnectionHam02 = socketServerHam02.Accept();
                    if (socketConnectionHam02 != null)
                    {
                        btn_Ham_Connect.Enabled = false;
                        lbl_Ham_State_02.Text = "连接成功!";
                        threadReceiveHam02 = new Thread(new ParameterizedThreadStart(MsgReceiveHam02));
                        threadReceiveHam02.IsBackground = true;
                        threadReceiveHam02.Start(socketConnectionHam02);
                    }
                }
            }
            catch
            {
                //MessageBox.Show("相机连接失败，请关闭窗口重新连接！");
            }
        }

        //用来存放二进制数据的list
        List<byte> list_Binary_Ham02 = new List<byte>();

        //通信函数
        string alarmHamMsg02 = null;
        Socket socketReceiveHam02 = null;
        private void MsgReceiveHam02(Object obj)
        {
            try
            {
                socketReceiveHam02 = obj as Socket;
                while (true)
                {
                    byte[] headinfo = new byte[5];
                    int headinfoLength = socketReceiveHam02.Receive(headinfo, headinfo.Length, SocketFlags.None);
                    if (headinfoLength == 0) break;
                    string info = Encoding.UTF8.GetString(headinfo, 0, headinfoLength);
                    Console.WriteLine("info={0}", info);
                    if (info[0] == '0' && info[1] == '0' && info[2] == '0' && info[3] == '0')
                    {
                        byte[] headLevelInfo = new byte[5];
                        int levelLength = socketReceiveHam02.Receive(headLevelInfo, headLevelInfo.Length, SocketFlags.None);
                        if (levelLength == 0)
                        {
                            //如果没有接收到文件，则结束循环
                            break;
                        }
                        string strMsg = Encoding.UTF8.GetString(headLevelInfo, 0, levelLength);
                        Console.WriteLine("strMsg={0}", strMsg);
                        if (strMsg[0] == '1')
                        {
                            //textBox_Head.AppendText("机头处皮带发生轻微跑偏");
                            alarmHamMsg02 = "重锤02处皮带发生轻微撕裂\r\n";
                        }
                        if (strMsg[0] == '2')
                        {
                            alarmHamMsg02 = "重锤02处皮带发生严重撕裂\r\n";
                        }
                        byte[] bufferLength = new byte[10];
                        lbl_Ham_Receive02.Text = "0%";
                        int msglength = socketReceiveHam02.Receive(bufferLength, bufferLength.Length, SocketFlags.None);
                        if (msglength == 0) break;
                        string str_Length = Encoding.UTF8.GetString(bufferLength, 0, msglength);
                        Console.WriteLine(str_Length);
                        int length = int.Parse(str_Length);
                        Console.WriteLine("length={0}", length);
                        int recive = length;
                        while (true)
                        {
                            byte[] buffer = new byte[1024];
                            Array.Clear(buffer, 0, buffer.Length);
                            int r = socketReceiveHam02.Receive(buffer, buffer.Length, SocketFlags.None);
                            if (r == 0) break;
                            if (length > 0)
                            {
                                for (int index = 0; index < r; index++)
                                {
                                    list_Binary_Ham02.Add(buffer[index]);
                                }
                                length -= r;
                                lbl_Ham_Receive02.Text = ((int)(((double)(recive - length) / ((double)recive)) * 100)).ToString() + "%";
                            }
                            if (length <= 0)
                            {
                                if (lbl_Ham_Receive02.Text == "100%")
                                    lbl_Ham_Receive02.Text = "0%";
                                Array.Clear(buffer, 0, buffer.Length);
                                break;
                            }
                        }
                        ConvertToPicHam02(list_Binary_Ham02);
                    }
                    else
                    {
                        byte[] tmpBuffer = new byte[1024];
                        int tmpBufferlength = socketReceiveHam02.Receive(tmpBuffer, tmpBuffer.Length, SocketFlags.None);
                        if (tmpBufferlength == 0) break;
                        Array.Clear(tmpBuffer, 0, tmpBuffer.Length);
                    }
                }
            }
            catch { }
        }

        DateTime dtHam02;
        private void ConvertToPicHam02(List<byte> list_Binary)
        {
            byte[] pageData = list_Binary.ToArray();
            list_Binary.Clear();
            //用来设置存储图片像素值得二维矩阵
            int[,] pixels = new int[320 * 240, 3];
            int count = 0;

            //建立图像缓存数据
            var bitmap = new Bitmap(320, 240, PixelFormat.Format32bppRgb);

            for (int i = 0; i < pageData.Length - 1; i = i + 2)
            {
                //分别读取处每一个像素的值
                int intLow = pageData[i + 1];
                int tmpintHigh = pageData[i];
                int tmpHigh = tmpintHigh << 8;
                int pixel = tmpHigh | intLow;
                int red = (pixel & 0xf800) >> 11;
                int green = (pixel & 0x07e0) >> 5;
                int blue = (pixel & 0x001f);
                pixels[count, 0] = (red << 3);
                pixels[count, 1] = (green << 2);
                pixels[count, 2] = (blue << 3);
                count++;
            }
            int alpha = 0xff;
            count = 0;
            for (int y = 0; y < 240; y++)
            {
                for (int x = 0; x < 320; x++)
                {
                    bitmap.SetPixel(x, y, Color.FromArgb(alpha, pixels[count, 0], pixels[count, 1], pixels[count, 2]));
                    count++;
                }
            }

            CheckRequestDirectory();

            dtHam02 = DateTime.Now;

            string fileNameShort = dtHam02.ToString("yyyy年MM月dd日HH时mm分ss秒ffff毫秒");
            string fileName = fileNameShort + ".bmp";
            string bmpPath = dirPath + "/日志/重锤撕裂照片" + "\\" + fileName;
            string logMsg = fileNameShort + ": " + alarmHamMsg02;

            SaveandShowHam(bmpPath, fileNameShort, bitmap, logMsg);

            if (picBox_Ham.Image == null)
            {
                picBox_Ham.Image = bitmap;
            }
        }

        Thread threadWatchHam03 = null;
        Socket socketWatchHam03 = null;
        private void StartConnectHam03()
        {
            string hamIP03 = "192.168.0.201";
            string hamPort03 = "8234";
            socketWatchHam03 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPAddress ipAddressHam03 = IPAddress.Parse(hamIP03.Trim());
            IPEndPoint endPointHam03 = new IPEndPoint(ipAddressHam03, int.Parse(hamPort03.Trim()));
            socketWatchHam03.Bind(endPointHam03);
            socketWatchHam03.Listen(20);

            threadWatchHam03 = new Thread(new ParameterizedThreadStart(WatchConnectingHam03));
            threadWatchHam03.IsBackground = true;
            threadWatchHam03.Start(socketWatchHam03);
            lbl_Ham_State_03.Text = "等待连接";
        }

        Socket socketServerHam03 = null;
        Socket socketConnectionHam03 = null;
        Thread threadReceiveHam03 = null;
        private void WatchConnectingHam03(object obj)
        {
            try
            {
                socketServerHam03 = obj as Socket;
                while (true)
                {
                    socketConnectionHam03 = socketServerHam03.Accept();
                    if (socketConnectionHam03 != null)
                    {
                        btn_Ham_Connect.Enabled = false;
                        lbl_Ham_State_03.Text = "连接成功!";
                        threadReceiveHam03 = new Thread(new ParameterizedThreadStart(MsgReceiveHam03));
                        threadReceiveHam03.IsBackground = true;
                        threadReceiveHam03.Start(socketConnectionHam03);
                    }
                }
            }
            catch
            {
                //MessageBox.Show("相机连接失败，请关闭窗口重新连接！");
            }
        }

        //用来存放二进制数据的list
        List<byte> list_Binary_Ham03 = new List<byte>();

        //通信函数
        string alarmHamMsg03 = null;
        Socket socketReceiveHam03 = null;
        private void MsgReceiveHam03(Object obj)
        {
            try
            {
                socketReceiveHam03 = obj as Socket;
                while (true)
                {
                    byte[] headinfo = new byte[5];
                    int headinfoLength = socketReceiveHam03.Receive(headinfo, headinfo.Length, SocketFlags.None);
                    if (headinfoLength == 0) break;
                    string info = Encoding.UTF8.GetString(headinfo, 0, headinfoLength);
                    Console.WriteLine("info={0}", info);
                    if (info[0] == '0' && info[1] == '0' && info[2] == '0' && info[3] == '0')
                    {
                        byte[] headLevelInfo = new byte[5];
                        int levelLength = socketReceiveHam03.Receive(headLevelInfo, headLevelInfo.Length, SocketFlags.None);
                        if (levelLength == 0)
                        {
                            //如果没有接收到文件，则结束循环
                            break;
                        }
                        string strMsg = Encoding.UTF8.GetString(headLevelInfo, 0, levelLength);
                        Console.WriteLine("strMsg={0}", strMsg);
                        if (strMsg[0] == '1')
                        {
                            //textBox_Head.AppendText("机头处皮带发生轻微跑偏");
                            alarmHamMsg03 = "重锤03处皮带发生轻微撕裂\r\n";
                        }
                        if (strMsg[0] == '2')
                        {
                            alarmHamMsg03 = "重锤03处皮带发生严重撕裂\r\n";
                        }
                        byte[] bufferLength = new byte[10];
                        lbl_Ham_Receive03.Text = "0%";
                        int msglength = socketReceiveHam03.Receive(bufferLength, bufferLength.Length, SocketFlags.None);
                        if (msglength == 0) break;
                        string str_Length = Encoding.UTF8.GetString(bufferLength, 0, msglength);
                        Console.WriteLine(str_Length);
                        int length = int.Parse(str_Length);
                        Console.WriteLine("length={0}", length);
                        int recive = length;
                        while (true)
                        {
                            byte[] buffer = new byte[1024];
                            Array.Clear(buffer, 0, buffer.Length);
                            int r = socketReceiveHam03.Receive(buffer, buffer.Length, SocketFlags.None);
                            if (r == 0) break;
                            if (length > 0)
                            {
                                for (int index = 0; index < r; index++)
                                {
                                    list_Binary_Ham03.Add(buffer[index]);
                                }
                                length -= r;
                                lbl_Ham_Receive03.Text = ((int)(((double)(recive - length) / ((double)recive)) * 100)).ToString() + "%";
                            }
                            if (length <= 0)
                            {
                                if (lbl_Ham_Receive03.Text == "100%")
                                    lbl_Ham_Receive03.Text = "0%";
                                Array.Clear(buffer, 0, buffer.Length);
                                break;
                            }
                        }
                        ConvertToPicHam03(list_Binary_Ham03);
                    }
                    else
                    {
                        byte[] tmpBuffer = new byte[1024];
                        int tmpBufferlength = socketReceiveHam03.Receive(tmpBuffer, tmpBuffer.Length, SocketFlags.None);
                        if (tmpBufferlength == 0) break;
                        Array.Clear(tmpBuffer, 0, tmpBuffer.Length);
                    }
                }
            }
            catch { }
        }

        DateTime dtHam03;
        private void ConvertToPicHam03(List<byte> list_Binary)
        {
            byte[] pageData = list_Binary.ToArray();
            list_Binary.Clear();
            //用来设置存储图片像素值得二维矩阵
            int[,] pixels = new int[320 * 240, 3];
            int count = 0;

            //建立图像缓存数据
            var bitmap = new Bitmap(320, 240, PixelFormat.Format32bppRgb);

            for (int i = 0; i < pageData.Length - 1; i = i + 2)
            {
                //分别读取处每一个像素的值
                int intLow = pageData[i + 1];
                int tmpintHigh = pageData[i];
                int tmpHigh = tmpintHigh << 8;
                int pixel = tmpHigh | intLow;
                int red = (pixel & 0xf800) >> 11;
                int green = (pixel & 0x07e0) >> 5;
                int blue = (pixel & 0x001f);
                pixels[count, 0] = (red << 3);
                pixels[count, 1] = (green << 2);
                pixels[count, 2] = (blue << 3);
                count++;
            }
            int alpha = 0xff;
            count = 0;
            for (int y = 0; y < 240; y++)
            {
                for (int x = 0; x < 320; x++)
                {
                    bitmap.SetPixel(x, y, Color.FromArgb(alpha, pixels[count, 0], pixels[count, 1], pixels[count, 2]));
                    count++;
                }
            }

            CheckRequestDirectory();

            dtHam03 = DateTime.Now;

            string fileNameShort = dtHam03.ToString("yyyy年MM月dd日HH时mm分ss秒ffff毫秒");
            string fileName = fileNameShort + ".bmp";
            string bmpPath = dirPath + "/日志/重锤撕裂照片" + "\\" + fileName;
            string logMsg = fileNameShort + ": " + alarmHamMsg03;

            SaveandShowHam(bmpPath, fileNameShort, bitmap, logMsg);

            if (picBox_Ham.Image == null)
            {
                picBox_Ham.Image = bitmap;
            }
        }

        private static readonly object lockerhamobj = new object();
        private void SaveandShowHam(string bmpPath, string fileNameShort, Bitmap bitmap, string logMsg)
        {
            lock (lockerhamobj)
            {
                listFileFullNameHam.Insert(0, bmpPath);
                listBox_Ham.Items.Insert(0, Path.GetFileNameWithoutExtension(bmpPath));
                txtBox_Ham.Text = txtBox_Ham.Text.Insert(0, logMsg);
                WriteToLogFile("重锤皮带撕裂详细记录.txt", logMsg);
                if (MediaPlayerHam.playState == WMPLib.WMPPlayState.wmppsUndefined || MediaPlayerHam.playState == WMPLib.WMPPlayState.wmppsStopped)
                    MediaPlayerHam.URL = alarmHamURL;
                bitmap.Save(bmpPath);
            }
        }
        #endregion

        #region 机尾连接
        private void btn_End_Connect_Click(object sender, EventArgs e)
        {
            //StartConnectEnd01();
            //StartConnectEnd02();
            //StartConnectEnd03();
        }

        Thread threadWatchEnd01 = null;
        Socket socketWatchEnd01 = null;
        private void StartConnectEnd01()
        {
            string endIP01 = "192.168.0.201";
            string endPort01 = "8234";
            socketWatchEnd01 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPAddress ipAddressEnd01 = IPAddress.Parse(endIP01.Trim());
            IPEndPoint endPointEnd01 = new IPEndPoint(ipAddressEnd01, int.Parse(endPort01.Trim()));
            socketWatchEnd01.Bind(endPointEnd01);
            socketWatchEnd01.Listen(20);

            threadWatchEnd01 = new Thread(new ParameterizedThreadStart(WatchConnectingEnd01));
            threadWatchEnd01.IsBackground = true;
            threadWatchEnd01.Start(socketWatchEnd01);
            lbl_End_State_01.Text = "等待连接";
        }

        Socket socketServerEnd01 = null;
        Socket socketConnectionEnd01 = null;
        Thread threadReceiveEnd01 = null;
        private void WatchConnectingEnd01(object obj)
        {
            try
            {
                socketServerEnd01 = obj as Socket;
                while (true)
                {
                    socketConnectionEnd01 = socketServerEnd01.Accept();
                    if (socketConnectionEnd01 != null)
                    {
                        btn_End_Connect.Enabled = false;
                        lbl_End_State_01.Text = "连接成功!";
                        threadReceiveEnd01 = new Thread(new ParameterizedThreadStart(MsgReceiveEnd01));
                        threadReceiveEnd01.IsBackground = true;
                        threadReceiveEnd01.Start(socketConnectionEnd01);
                    }
                }
            }
            catch
            {
                //MessageBox.Show("相机连接失败，请关闭窗口重新连接！");
            }
        }

        //用来存放二进制数据的list
        List<byte> list_Binary_End01 = new List<byte>();

        //通信函数
        string alarmEndMsg01 = null;
        Socket socketReceiveEnd01 = null;
        private void MsgReceiveEnd01(Object obj)
        {
            try
            {
                socketReceiveEnd01 = obj as Socket;
                while (true)
                {
                    byte[] headinfo = new byte[5];
                    int headinfoLength = socketReceiveEnd01.Receive(headinfo, headinfo.Length, SocketFlags.None);
                    if (headinfoLength == 0) break;
                    string info = Encoding.UTF8.GetString(headinfo, 0, headinfoLength);
                    Console.WriteLine("info={0}", info);
                    if (info[0] == '0' && info[1] == '0' && info[2] == '0' && info[3] == '0')
                    {
                        byte[] headLevelInfo = new byte[5];
                        int levelLength = socketReceiveEnd01.Receive(headLevelInfo, headLevelInfo.Length, SocketFlags.None);
                        if (levelLength == 0)
                        {
                            //如果没有接收到文件，则结束循环
                            break;
                        }
                        string strMsg = Encoding.UTF8.GetString(headLevelInfo, 0, levelLength);
                        Console.WriteLine("strMsg={0}", strMsg);
                        if (strMsg[0] == '1')
                        {
                            //textBox_Head.AppendText("机头处皮带发生轻微跑偏");
                            alarmEndMsg01 = "机尾01处皮带发生轻微撕裂\r\n";
                        }
                        if (strMsg[0] == '2')
                        {
                            alarmEndMsg01 = "机尾01处皮带发生严重撕裂\r\n";
                        }
                        byte[] bufferLength = new byte[10];
                        lbl_End_Receive01.Text = "0%";
                        int msglength = socketReceiveEnd01.Receive(bufferLength, bufferLength.Length, SocketFlags.None);
                        if (msglength == 0) break;
                        string str_Length = Encoding.UTF8.GetString(bufferLength, 0, msglength);
                        Console.WriteLine(str_Length);
                        int length = int.Parse(str_Length);
                        Console.WriteLine("length={0}", length);
                        int recive = length;
                        while (true)
                        {
                            byte[] buffer = new byte[1024];
                            Array.Clear(buffer, 0, buffer.Length);
                            int r = socketReceiveEnd01.Receive(buffer, buffer.Length, SocketFlags.None);
                            if (r == 0) break;
                            if (length > 0)
                            {
                                for (int index = 0; index < r; index++)
                                {
                                    list_Binary_End01.Add(buffer[index]);
                                }
                                length -= r;
                                lbl_End_Receive01.Text = ((int)(((double)(recive - length) / ((double)recive)) * 100)).ToString() + "%";
                            }
                            if (length <= 0)
                            {
                                if (lbl_End_Receive01.Text == "100%")
                                    lbl_End_Receive01.Text = "0%";
                                Array.Clear(buffer, 0, buffer.Length);
                                break;
                            }
                        }
                        ConvertToPicEnd01(list_Binary_End01);
                    }
                    else
                    {
                        byte[] tmpBuffer = new byte[1024];
                        int tmpBufferlength = socketReceiveEnd01.Receive(tmpBuffer, tmpBuffer.Length, SocketFlags.None);
                        if (tmpBufferlength == 0) break;
                        Array.Clear(tmpBuffer, 0, tmpBuffer.Length);
                    }
                }
            }
            catch { }
        }

        DateTime dtEnd01;
        private void ConvertToPicEnd01(List<byte> list_Binary)
        {
            byte[] pageData = list_Binary.ToArray();
            list_Binary.Clear();
            //用来设置存储图片像素值得二维矩阵
            int[,] pixels = new int[320 * 240, 3];
            int count = 0;

            //建立图像缓存数据
            var bitmap = new Bitmap(320, 240, PixelFormat.Format32bppRgb);

            for (int i = 0; i < pageData.Length - 1; i = i + 2)
            {
                //分别读取处每一个像素的值
                int intLow = pageData[i + 1];
                int tmpintHigh = pageData[i];
                int tmpHigh = tmpintHigh << 8;
                int pixel = tmpHigh | intLow;
                int red = (pixel & 0xf800) >> 11;
                int green = (pixel & 0x07e0) >> 5;
                int blue = (pixel & 0x001f);
                pixels[count, 0] = (red << 3);
                pixels[count, 1] = (green << 2);
                pixels[count, 2] = (blue << 3);
                count++;
            }
            int alpha = 0xff;
            count = 0;
            for (int y = 0; y < 240; y++)
            {
                for (int x = 0; x < 320; x++)
                {
                    bitmap.SetPixel(x, y, Color.FromArgb(alpha, pixels[count, 0], pixels[count, 1], pixels[count, 2]));
                    count++;
                }
            }

            CheckRequestDirectory();

            dtEnd01 = DateTime.Now;

            string fileNameShort = dtEnd01.ToString("yyyy年MM月dd日HH时mm分ss秒ffff毫秒");
            string fileName = fileNameShort + ".bmp";
            string bmpPath = dirPath + "/日志/机尾撕裂照片" + "\\" + fileName;
            string logMsg = fileNameShort + ": " + alarmEndMsg01;

            SaveandShowEnd(bmpPath, fileNameShort, bitmap, logMsg);

            if (picBox_End.Image == null)
            {
                picBox_End.Image = bitmap;
            }
        }

        Thread threadWatchEnd02 = null;
        Socket socketWatchEnd02 = null;
        private void StartConnectEnd02()
        {
            string endIP02 = "192.168.0.201";
            string endPort02 = "8234";
            socketWatchEnd02 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPAddress ipAddressEnd02 = IPAddress.Parse(endIP02.Trim());
            IPEndPoint endPointEnd02 = new IPEndPoint(ipAddressEnd02, int.Parse(endPort02.Trim()));
            socketWatchEnd02.Bind(endPointEnd02);
            socketWatchEnd02.Listen(20);

            threadWatchEnd02 = new Thread(new ParameterizedThreadStart(WatchConnectingEnd02));
            threadWatchEnd02.IsBackground = true;
            threadWatchEnd02.Start(socketWatchEnd02);
            lbl_End_State_02.Text = "等待连接";
        }

        Socket socketServerEnd02 = null;
        Socket socketConnectionEnd02 = null;
        Thread threadReceiveEnd02 = null;
        private void WatchConnectingEnd02(object obj)
        {
            try
            {
                socketServerEnd02 = obj as Socket;
                while (true)
                {
                    socketConnectionEnd02 = socketServerEnd02.Accept();
                    if (socketConnectionEnd02 != null)
                    {
                        btn_End_Connect.Enabled = false;
                        lbl_End_State_02.Text = "连接成功!";
                        threadReceiveEnd02 = new Thread(new ParameterizedThreadStart(MsgReceiveEnd02));
                        threadReceiveEnd02.IsBackground = true;
                        threadReceiveEnd02.Start(socketConnectionEnd02);
                    }
                }
            }
            catch
            {
                //MessageBox.Show("相机连接失败，请关闭窗口重新连接！");
            }
        }

        //用来存放二进制数据的list
        List<byte> list_Binary_End02 = new List<byte>();

        //通信函数
        string alarmEndMsg02 = null;
        Socket socketReceiveEnd02 = null;
        private void MsgReceiveEnd02(Object obj)
        {
            try
            {
                socketReceiveEnd02 = obj as Socket;
                while (true)
                {
                    byte[] headinfo = new byte[5];
                    int headinfoLength = socketReceiveEnd02.Receive(headinfo, headinfo.Length, SocketFlags.None);
                    if (headinfoLength == 0) break;
                    string info = Encoding.UTF8.GetString(headinfo, 0, headinfoLength);
                    Console.WriteLine("info={0}", info);
                    if (info[0] == '0' && info[1] == '0' && info[2] == '0' && info[3] == '0')
                    {
                        byte[] headLevelInfo = new byte[5];
                        int levelLength = socketReceiveEnd02.Receive(headLevelInfo, headLevelInfo.Length, SocketFlags.None);
                        if (levelLength == 0)
                        {
                            //如果没有接收到文件，则结束循环
                            break;
                        }
                        string strMsg = Encoding.UTF8.GetString(headLevelInfo, 0, levelLength);
                        Console.WriteLine("strMsg={0}", strMsg);
                        if (strMsg[0] == '1')
                        {
                            //textBox_Head.AppendText("机头处皮带发生轻微跑偏");
                            alarmEndMsg02 = "机尾02处皮带发生轻微撕裂\r\n";
                        }
                        if (strMsg[0] == '2')
                        {
                            alarmEndMsg02 = "机尾02处皮带发生严重撕裂\r\n";
                        }
                        byte[] bufferLength = new byte[10];
                        lbl_End_Receive02.Text = "0%";
                        int msglength = socketReceiveEnd02.Receive(bufferLength, bufferLength.Length, SocketFlags.None);
                        if (msglength == 0) break;
                        string str_Length = Encoding.UTF8.GetString(bufferLength, 0, msglength);
                        Console.WriteLine(str_Length);
                        int length = int.Parse(str_Length);
                        Console.WriteLine("length={0}", length);
                        int recive = length;
                        while (true)
                        {
                            byte[] buffer = new byte[1024];
                            Array.Clear(buffer, 0, buffer.Length);
                            int r = socketReceiveEnd02.Receive(buffer, buffer.Length, SocketFlags.None);
                            if (r == 0) break;
                            if (length > 0)
                            {
                                for (int index = 0; index < r; index++)
                                {
                                    list_Binary_End02.Add(buffer[index]);
                                }
                                length -= r;
                                lbl_End_Receive02.Text = ((int)(((double)(recive - length) / ((double)recive)) * 100)).ToString() + "%";
                            }
                            if (length <= 0)
                            {
                                if (lbl_End_Receive02.Text == "100%")
                                    lbl_End_Receive02.Text = "0%";
                                Array.Clear(buffer, 0, buffer.Length);
                                break;
                            }
                        }
                        ConvertToPicEnd02(list_Binary_End02);
                    }
                    else
                    {
                        byte[] tmpBuffer = new byte[1024];
                        int tmpBufferlength = socketReceiveEnd02.Receive(tmpBuffer, tmpBuffer.Length, SocketFlags.None);
                        if (tmpBufferlength == 0) break;
                        Array.Clear(tmpBuffer, 0, tmpBuffer.Length);
                    }
                }
            }
            catch { }
        }

        DateTime dtEnd02;
        private void ConvertToPicEnd02(List<byte> list_Binary)
        {
            byte[] pageData = list_Binary.ToArray();
            list_Binary.Clear();
            //用来设置存储图片像素值得二维矩阵
            int[,] pixels = new int[320 * 240, 3];
            int count = 0;

            //建立图像缓存数据
            var bitmap = new Bitmap(320, 240, PixelFormat.Format32bppRgb);

            for (int i = 0; i < pageData.Length - 1; i = i + 2)
            {
                //分别读取处每一个像素的值
                int intLow = pageData[i + 1];
                int tmpintHigh = pageData[i];
                int tmpHigh = tmpintHigh << 8;
                int pixel = tmpHigh | intLow;
                int red = (pixel & 0xf800) >> 11;
                int green = (pixel & 0x07e0) >> 5;
                int blue = (pixel & 0x001f);
                pixels[count, 0] = (red << 3);
                pixels[count, 1] = (green << 2);
                pixels[count, 2] = (blue << 3);
                count++;
            }
            int alpha = 0xff;
            count = 0;
            for (int y = 0; y < 240; y++)
            {
                for (int x = 0; x < 320; x++)
                {
                    bitmap.SetPixel(x, y, Color.FromArgb(alpha, pixels[count, 0], pixels[count, 1], pixels[count, 2]));
                    count++;
                }
            }

            CheckRequestDirectory();

            dtEnd02 = DateTime.Now;

            string fileNameShort = dtEnd02.ToString("yyyy年MM月dd日HH时mm分ss秒ffff毫秒");
            string fileName = fileNameShort + ".bmp";
            string bmpPath = dirPath + "/日志/机尾撕裂照片" + "\\" + fileName;
            string logMsg = fileNameShort + ": " + alarmEndMsg02;

            SaveandShowEnd(bmpPath, fileNameShort, bitmap, logMsg);

            if (picBox_End.Image == null)
            {
                picBox_End.Image = bitmap;
            }
        }

        Thread threadWatchEnd03 = null;
        Socket socketWatchEnd03 = null;
        private void StartConnectEnd03()
        {
            string endIP03 = "192.168.0.201";
            string endPort03 = "8234";
            socketWatchEnd03 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPAddress ipAddressEnd03 = IPAddress.Parse(endIP03.Trim());
            IPEndPoint endPointEnd03 = new IPEndPoint(ipAddressEnd03, int.Parse(endPort03.Trim()));
            socketWatchEnd03.Bind(endPointEnd03);
            socketWatchEnd03.Listen(20);

            threadWatchEnd03 = new Thread(new ParameterizedThreadStart(WatchConnectingEnd03));
            threadWatchEnd03.IsBackground = true;
            threadWatchEnd03.Start(socketWatchEnd03);
            lbl_End_State_03.Text = "等待连接";
        }

        Socket socketServerEnd03 = null;
        Socket socketConnectionEnd03 = null;
        Thread threadReceiveEnd03 = null;
        private void WatchConnectingEnd03(object obj)
        {
            try
            {
                socketServerEnd03 = obj as Socket;
                while (true)
                {
                    socketConnectionEnd03 = socketServerEnd03.Accept();
                    if (socketConnectionEnd03 != null)
                    {
                        btn_End_Connect.Enabled = false;
                        lbl_End_State_03.Text = "连接成功!";
                        threadReceiveEnd03 = new Thread(new ParameterizedThreadStart(MsgReceiveEnd03));
                        threadReceiveEnd03.IsBackground = true;
                        threadReceiveEnd03.Start(socketConnectionEnd03);
                    }
                }
            }
            catch
            {
                //MessageBox.Show("相机连接失败，请关闭窗口重新连接！");
            }
        }

        //用来存放二进制数据的list
        List<byte> list_Binary_End03 = new List<byte>();

        //通信函数
        string alarmEndMsg03 = null;
        Socket socketReceiveEnd03 = null;
        private void MsgReceiveEnd03(Object obj)
        {
            try
            {
                socketReceiveEnd03 = obj as Socket;
                while (true)
                {
                    byte[] headinfo = new byte[5];
                    int headinfoLength = socketReceiveEnd03.Receive(headinfo, headinfo.Length, SocketFlags.None);
                    if (headinfoLength == 0) break;
                    string info = Encoding.UTF8.GetString(headinfo, 0, headinfoLength);
                    Console.WriteLine("info={0}", info);
                    if (info[0] == '0' && info[1] == '0' && info[2] == '0' && info[3] == '0')
                    {
                        byte[] headLevelInfo = new byte[5];
                        int levelLength = socketReceiveEnd03.Receive(headLevelInfo, headLevelInfo.Length, SocketFlags.None);
                        if (levelLength == 0)
                        {
                            //如果没有接收到文件，则结束循环
                            break;
                        }
                        string strMsg = Encoding.UTF8.GetString(headLevelInfo, 0, levelLength);
                        Console.WriteLine("strMsg={0}", strMsg);
                        if (strMsg[0] == '1')
                        {
                            //textBox_Head.AppendText("机头处皮带发生轻微跑偏");
                            alarmEndMsg03 = "机尾03处皮带发生轻微撕裂\r\n";
                        }
                        if (strMsg[0] == '2')
                        {
                            alarmEndMsg03 = "机尾03处皮带发生严重撕裂\r\n";
                        }
                        byte[] bufferLength = new byte[10];
                        lbl_End_Receive03.Text = "0%";
                        int msglength = socketReceiveEnd03.Receive(bufferLength, bufferLength.Length, SocketFlags.None);
                        if (msglength == 0) break;
                        string str_Length = Encoding.UTF8.GetString(bufferLength, 0, msglength);
                        Console.WriteLine(str_Length);
                        int length = int.Parse(str_Length);
                        Console.WriteLine("length={0}", length);
                        int recive = length;
                        while (true)
                        {
                            byte[] buffer = new byte[1024];
                            Array.Clear(buffer, 0, buffer.Length);
                            int r = socketReceiveEnd03.Receive(buffer, buffer.Length, SocketFlags.None);
                            if (r == 0) break;
                            if (length > 0)
                            {
                                for (int index = 0; index < r; index++)
                                {
                                    list_Binary_End03.Add(buffer[index]);
                                }
                                length -= r;
                                lbl_End_Receive03.Text = ((int)(((double)(recive - length) / ((double)recive)) * 100)).ToString() + "%";
                            }
                            if (length <= 0)
                            {
                                if (lbl_End_Receive03.Text == "100%")
                                    lbl_End_Receive03.Text = "0%";
                                Array.Clear(buffer, 0, buffer.Length);
                                break;
                            }
                        }
                        ConvertToPicEnd03(list_Binary_End03);
                    }
                    else
                    {
                        byte[] tmpBuffer = new byte[1024];
                        int tmpBufferlength = socketReceiveEnd03.Receive(tmpBuffer, tmpBuffer.Length, SocketFlags.None);
                        if (tmpBufferlength == 0) break;
                        Array.Clear(tmpBuffer, 0, tmpBuffer.Length);
                    }
                }
            }
            catch { }
        }

        DateTime dtEnd03;
        private void ConvertToPicEnd03(List<byte> list_Binary)
        {
            byte[] pageData = list_Binary.ToArray();
            list_Binary.Clear();
            //用来设置存储图片像素值得二维矩阵
            int[,] pixels = new int[320 * 240, 3];
            int count = 0;

            //建立图像缓存数据
            var bitmap = new Bitmap(320, 240, PixelFormat.Format32bppRgb);

            for (int i = 0; i < pageData.Length - 1; i = i + 2)
            {
                //分别读取处每一个像素的值
                int intLow = pageData[i + 1];
                int tmpintHigh = pageData[i];
                int tmpHigh = tmpintHigh << 8;
                int pixel = tmpHigh | intLow;
                int red = (pixel & 0xf800) >> 11;
                int green = (pixel & 0x07e0) >> 5;
                int blue = (pixel & 0x001f);
                pixels[count, 0] = (red << 3);
                pixels[count, 1] = (green << 2);
                pixels[count, 2] = (blue << 3);
                count++;
            }
            int alpha = 0xff;
            count = 0;
            for (int y = 0; y < 240; y++)
            {
                for (int x = 0; x < 320; x++)
                {
                    bitmap.SetPixel(x, y, Color.FromArgb(alpha, pixels[count, 0], pixels[count, 1], pixels[count, 2]));
                    count++;
                }
            }

            CheckRequestDirectory();

            dtEnd03 = DateTime.Now;

            string fileNameShort = dtEnd03.ToString("yyyy年MM月dd日HH时mm分ss秒ffff毫秒");
            string fileName = fileNameShort + ".bmp";
            string bmpPath = dirPath + "/日志/机尾撕裂照片" + "\\" + fileName;
            string logMsg = fileNameShort + ": " + alarmEndMsg03;

            SaveandShowEnd(bmpPath, fileNameShort, bitmap, logMsg);

            if (picBox_End.Image == null)
            {
                picBox_End.Image = bitmap;
            }
        }
        private static readonly object lockerendobj = new object();
        private void SaveandShowEnd(string bmpPath, string fileNameShort, Bitmap bitmap, string logMsg)
        {
            lock (lockerendobj)
            {
                listFileFullNameEnd.Insert(0, bmpPath);
                listBox_End.Items.Insert(0, Path.GetFileNameWithoutExtension(bmpPath));
                txtBox_End.Text = txtBox_End.Text.Insert(0, logMsg);
                WriteToLogFile("机尾皮带撕裂详细记录.txt", logMsg);
                if (MediaPlayerEnd.playState == WMPLib.WMPPlayState.wmppsUndefined || MediaPlayerEnd.playState == WMPLib.WMPPlayState.wmppsStopped)
                    MediaPlayerEnd.URL = alarmEndURL;
                bitmap.Save(bmpPath);
            }
        }
        #endregion

        private void TearFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer_Head_New.Enabled = false;
            timer_Ham_New.Enabled = false;
            timer_End_New.Enabled = false;
        }
    }
}
