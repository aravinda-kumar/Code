using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Media;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace 皮带跑偏与撕裂检测监控界面
{
    public partial class DeviationFrm : Form
    {
        public DeviationFrm()
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

        //用来显示跑偏距离的随机数
        Random rd_Head = new Random();
        Random rd_Ham = new Random();
        Random rd_End = new Random();

        //定义用来闪烁的定时器
        System.Timers.Timer timer_Head_New = new System.Timers.Timer(500);
        System.Timers.Timer timer_Ham_New = new System.Timers.Timer(500);
        System.Timers.Timer timer_End_New = new System.Timers.Timer(500);
        

        //程序装载事件
        private void DeviationFrm_Load(object sender, EventArgs e)
        {
            //初始化定时器
            timer_Head_New.Elapsed += new System.Timers.ElapsedEventHandler(HeadTimeOut);
            timer_Head_New.AutoReset = true;

            timer_Ham_New.Elapsed += new System.Timers.ElapsedEventHandler(HamTimeOut);
            timer_Ham_New.AutoReset = true;

            timer_End_New.Elapsed += new System.Timers.ElapsedEventHandler(EndTimeOut);
            timer_End_New.AutoReset = true;

            //将播放器音量预设为100
            MediaPlayer_Head_Alarm.settings.volume = 100;
            MediaPlayer_Ham_Alarm.settings.volume = 100;
            MediaPlayer_End_Alarm.settings.volume = 100;

            //判断文件夹是否存在
            CheckRequestDirectory();
            //创建需要的系统文件
            CreateRequestFile();

            CheckForIllegalCrossThreadCalls = false;

            //返回机头照片目录下的所有bmp文件的完成路径
            strFileFullNameHead = Directory.GetFiles(dirPath + "/日志/机头跑偏照片", "*.bmp");
            foreach (var item in strFileFullNameHead)
            {
                //listBox_Head.Items.Add(Path.GetFileNameWithoutExtension(item));
                //listFileFullNameHead.Add(item);
                listBox_Head.Items.Insert(0, Path.GetFileNameWithoutExtension(item));
                listFileFullNameHead.Insert(0, item);
            }

            //返回重锤照片目录下的所有bmp文件的完成路径
            strFileFullNameHam = Directory.GetFiles(dirPath + "/日志/重锤跑偏照片", "*.bmp");
            foreach (var item in strFileFullNameHam)
            {
                //listBox_Ham.Items.Add(Path.GetFileNameWithoutExtension(item));
                //listFileFullNameHam.Add(item);
                listBox_Ham.Items.Insert(0, Path.GetFileNameWithoutExtension(item));
                listFileFullNameHam.Insert(0, item);
            }

            //返回机尾照片目录下的所有bmp文件的完成路径
            strFileFullNameEnd = Directory.GetFiles(dirPath + "/日志/机尾跑偏照片", "*.bmp");
            foreach (var item in strFileFullNameEnd)
            {
                //listBox_End.Items.Add(Path.GetFileNameWithoutExtension(item));
                //listFileFullNameEnd.Add(item);
                listBox_End.Items.Insert(0, Path.GetFileNameWithoutExtension(item));           
                listFileFullNameEnd.Insert(0, item);
            }

            //获得报警音url
            alarmHeadURL = GetalarmHeadURL();
            alarmHamURL = GetalarmHamURL();
            alarmEndURL = GetalarmEndURL();

            //btn_Head_Connect.PerformClick();
            //btn_Ham_Connect.PerformClick();
            //btn_End_Connect.PerformClick();
        }

        private void Timer_Head_New_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void CheckRequestDirectory()
        {
            if (Directory.Exists(dirPath + "/日志/机头跑偏照片/历史照片") == false)
            {
                Directory.CreateDirectory(dirPath + "/日志/机头跑偏照片/历史照片");
            }
            if (Directory.Exists(dirPath + "/日志/重锤跑偏照片/历史照片") == false)
            {
                Directory.CreateDirectory(dirPath + "/日志/重锤跑偏照片/历史照片");
            }
            if (Directory.Exists(dirPath + "/日志/机尾跑偏照片/历史照片") == false)
            {
                Directory.CreateDirectory(dirPath + "/日志/机尾跑偏照片/历史照片");
            }
        }

        private void CreateRequestFile()
        {
            string configHeadPath = Path.GetDirectoryName(Application.ExecutablePath) + "\\机头位置报警音配置文件";
            FileStream fsHead = new FileStream(configHeadPath, FileMode.OpenOrCreate);
            fsHead.Close();

            string configHamPath = Path.GetDirectoryName(Application.ExecutablePath) + "\\重锤位置报警音配置文件";
            FileStream fsHam = new FileStream(configHamPath, FileMode.OpenOrCreate);
            fsHam.Close();

            string configEndPath = Path.GetDirectoryName(Application.ExecutablePath) + "\\机尾位置报警音配置文件";
            FileStream fsEnd = new FileStream(configEndPath, FileMode.OpenOrCreate);
            fsEnd.Close();
        }

        #region 控制静音和响铃
        //音量为0即静音
        int flag_Head = 0;
        private void btn_Head_Quite_Click(object sender, EventArgs e)
        {
            if (flag_Head == 0)
            {
                MediaPlayer_Head_Alarm.settings.volume = 0;
                btn_Head_Quite.Text = "响铃";
                flag_Head++;
            }
            else
            {
                MediaPlayer_Head_Alarm.settings.volume = 100;
                btn_Head_Quite.Text = "静音";
                flag_Head = 0;
            }
        }
        int flag_Ham = 0;
        private void btn_Ham_Quite_Click(object sender, EventArgs e)
        {
            if (flag_Ham == 0)
            {
                MediaPlayer_Ham_Alarm.settings.volume = 0;
                btn_Ham_Quite.Text = "响铃";
                flag_Ham++;
            }
            else
            {
                MediaPlayer_Ham_Alarm.settings.volume = 100;
                btn_Ham_Quite.Text = "静音";
                flag_Ham = 0;
            }
        }

        int flag_End = 0;
        private void btn_End_Quite_Click(object sender, EventArgs e)
        {
            if (flag_End == 0)
            {
                MediaPlayer_End_Alarm.settings.volume = 0;
                btn_End_Quite.Text = "响铃";
                flag_End++;
            }
            else
            {
                MediaPlayer_End_Alarm.settings.volume = 100;
                btn_End_Quite.Text = "静音";
                flag_End = 0;
            }
        }

        #endregion

        #region 机头相机连接
        //机头相机开始连接
        Socket socketWatchHead = null;
        Thread threadWatchHead = null;
        private void btn_Head_Connect_Click(object sender, EventArgs e)
        {
            string headIP = "192.168.0.202";
            string headPort = "8234";
            socketWatchHead = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPAddress ipAddressHead = IPAddress.Parse(headIP.Trim());
            IPEndPoint endPointHead = new IPEndPoint(ipAddressHead, int.Parse(headPort.Trim()));
            socketWatchHead.Bind(endPointHead);
            socketWatchHead.Listen(20);

            threadWatchHead = new Thread(new ParameterizedThreadStart(WatchConnectingHead));
            threadWatchHead.IsBackground = true;
            threadWatchHead.Start(socketWatchHead);
            lbl_Head.Text = "等待相机连接......";
        }

        //监听函数
        Socket socketServerHead = null;
        Socket socketConnectionHead = null;
        Thread threadReceiveHead = null;
        private void WatchConnectingHead(object obj)
        {
            try
            {
                socketServerHead = obj as Socket;
                while (true)
                {
                    socketConnectionHead = socketServerHead.Accept();
                    if (socketConnectionHead != null)
                    {
                        btn_Head_Connect.Enabled = false;
                        lbl_Head.Text = "相机连接成功!";
                        threadReceiveHead = new Thread(new ParameterizedThreadStart(MsgReceiveHead));
                        threadReceiveHead.IsBackground = true;
                        threadReceiveHead.Start(socketConnectionHead);
                    }
                }
            }
            catch
            {
                //MessageBox.Show("相机连接失败，请关闭窗口重新连接！");
            }
        }

        //用来存放二进制数据的list
        List<byte> list_Binary_head = new List<byte>();

        //通信函数
        string alarmHeadMsg = null;
        Socket socketReceiveHead = null;
        //用来显示跑偏量的等级
        int deviationHeadLevel = 0;
        private void MsgReceiveHead(Object obj)
        {
            try
            {
                socketReceiveHead = obj as Socket;
                while (true)
                {
                    byte[] headinfo = new byte[5];
                    int headinfoLength = socketReceiveHead.Receive(headinfo, headinfo.Length, SocketFlags.None);
                    if (headinfoLength == 0) break;
                    string info = Encoding.UTF8.GetString(headinfo, 0, headinfoLength);
                    Console.WriteLine("info={0}", info);
                    if (info[0] == '0' && info[1] == '0' && info[2] == '0'  && info[3] == '0')
                    {
                        byte[] headLevelInfo = new byte[5];
                        int levelLength = socketReceiveHead.Receive(headLevelInfo, headLevelInfo.Length, SocketFlags.None);
                        if (levelLength == 0)
                        {
                            //如果没有接收到文件，则结束循环
                            break;
                        }
                        string strMsg = Encoding.UTF8.GetString(headLevelInfo, 0, levelLength);
                        Console.WriteLine("strMsg={0}", strMsg);
                        if (strMsg[0] == '1')
                        {
                            deviationHeadLevel = 1;
                            //textBox_Head.AppendText("机头处皮带发生轻微跑偏");
                            alarmHeadMsg = "机头处皮带发生轻微跑偏\r\n";
                        }
                        if (strMsg[0] == '2')
                        {
                            deviationHeadLevel = 2;
                            alarmHeadMsg = "机头处皮带发生严重跑偏\r\n";
                        }
                        byte[] bufferLength = new byte[10];
                        progressBar_Head.Value = 0;
                        int msglength = socketReceiveHead.Receive(bufferLength, bufferLength.Length, SocketFlags.None);
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
                            int r = socketReceiveHead.Receive(buffer, buffer.Length, SocketFlags.None);
                            if (r == 0) break;
                            if (length > 0)
                            {
                                for (int index = 0; index < r; index++)
                                {
                                    list_Binary_head.Add(buffer[index]);
                                }
                                length -= r;
                                progressBar_Head.Value = (int)(((double)(recive - length) / ((double)recive)) * 100);
                            }
                            if (length <= 0)
                            {
                                if (progressBar_Head.Value == progressBar_Head.Maximum)
                                    progressBar_Head.Value = 0;
                                Array.Clear(buffer, 0, buffer.Length);
                                break;
                            }
                        }
                        ConvertToPicHead(list_Binary_head);
                    }
                    else
                    {
                        byte[] tmpBuffer = new byte[1024];
                        int tmpBufferlength = socketReceiveHead.Receive(tmpBuffer, tmpBuffer.Length, SocketFlags.None);
                        if (tmpBufferlength == 0) break;
                        Array.Clear(tmpBuffer, 0, tmpBuffer.Length);
                    }
                }
            }
            catch
            {
                //MessageBox.Show("相机连接失败，请关闭窗口重新连接！");
            }
        }

        DateTime dtHead;
        private void ConvertToPicHead(List<byte> list_Binary)
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

            dtHead = DateTime.Now;

            if (picBox_Head.Image == null) 
            {
                picBox_Head.Image = bitmap;
            }

            string fileNameShort = dtHead.ToString("yyyy年MM月dd日HH时mm分ss秒");
            string fileName = fileNameShort + ".bmp";
            string bmpPath = dirPath + "/日志/机头跑偏照片" + "\\" + fileName;

            //timer_Head.Enabled = true;
            if (deviationHeadLevel == 1)
            {
                lbl_Head_number.Text = rd_Head.Next(0, 50).ToString() + "厘米";
            }
            if (deviationHeadLevel == 2)
            {
                lbl_Head_number.Text = rd_Head.Next(50, 99).ToString() + "厘米";
            }
            listFileFullNameHead.Insert(0, bmpPath);
            listBox_Head.Items.Insert(0, Path.GetFileNameWithoutExtension(bmpPath));
            string logMsg = fileNameShort + ": " + alarmHeadMsg;
            textBox_Head.Text = textBox_Head.Text.Insert(0, logMsg);
            WriteToLogFile("机头皮带跑偏详细记录.txt", logMsg);
            if (MediaPlayer_Head_Alarm.playState == WMPLib.WMPPlayState.wmppsUndefined || MediaPlayer_Head_Alarm.playState == WMPLib.WMPPlayState.wmppsStopped)
                MediaPlayer_Head_Alarm.URL = alarmHeadURL;
            bitmap.Save(bmpPath);
        }
        #endregion

        #region 重锤相机连接
        //重锤相机开始连接
        Socket socketWatchHam = null;
        Thread threadWatchHam = null;
        private void btn_Ham_Connect_Click(object sender, EventArgs e)
        {
            string hamIP = "192.168.0.201";
            string hamPort = "8234";
            socketWatchHam = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPAddress ipAddressHam = IPAddress.Parse(hamIP.Trim());
            IPEndPoint endPointHam = new IPEndPoint(ipAddressHam, int.Parse(hamPort.Trim()));
            socketWatchHam.Bind(endPointHam);
            socketWatchHam.Listen(20);

            threadWatchHam = new Thread(new ParameterizedThreadStart(WatchConnectingHam));
            threadWatchHam.IsBackground = true;
            threadWatchHam.Start(socketWatchHam);
            lbl_Ham.Text = "等待相机连接......";
        }

        //监听函数
        Socket socketServerHam = null;
        Socket socketConnectionHam = null;
        Thread threadReceiveHam = null;
        private void WatchConnectingHam(object obj)
        {
            try
            {
                socketServerHam = obj as Socket;
                while (true)
                {
                    socketConnectionHam = socketServerHam.Accept();
                    if (socketConnectionHam != null)
                    {
                        btn_Ham_Connect.Enabled = false;
                        lbl_Ham.Text = "相机连接成功!";
                        threadReceiveHam = new Thread(new ParameterizedThreadStart(MsgReceiveHam));
                        threadReceiveHam.IsBackground = true;
                        threadReceiveHam.Start(socketConnectionHam);
                    }
                }
            }
            catch
            {
                //MessageBox.Show("相机连接失败，请关闭窗口重新连接！");
            }
        }

        //用来存放二进制数据的list
        List<byte> list_Binary_ham = new List<byte>();

        //通信函数
        string alarmHamMsg = null;
        Socket socketReceiveHam = null;
        //用来显示跑偏量的等级
        int deviationHamLevel = 0;
        private void MsgReceiveHam(Object obj)
        {
            try
            {
                socketReceiveHam = obj as Socket;
                while (true)
                {
                    byte[] haminfo = new byte[5];
                    int haminfoLength = socketReceiveHam.Receive(haminfo, haminfo.Length, SocketFlags.None);
                    if (haminfoLength == 0) break;
                    string info = Encoding.UTF8.GetString(haminfo, 0, haminfoLength);
                    Console.WriteLine("info={0}", info);
                    if (info[0] == '0' && info[1] == '0' && info[2] == '0' && info[3] == '0')
                    {
                        byte[] hamLevelInfo = new byte[5];
                        int levelLength = socketReceiveHam.Receive(hamLevelInfo, hamLevelInfo.Length, SocketFlags.None);
                        if (levelLength == 0)
                        {
                            //如果没有接收到文件，则结束循环
                            break;
                        }
                        string strMsg = Encoding.UTF8.GetString(hamLevelInfo, 0, levelLength);
                        Console.WriteLine("strMsg={0}", strMsg);
                        if (strMsg[0] == '1')
                        {
                            deviationHamLevel = 1;
                            //textBox_Head.AppendText("机头处皮带发生轻微跑偏");
                            alarmHamMsg = "重锤处皮带发生轻微跑偏\r\n";
                        }
                        if (strMsg[0] == '2')
                        {
                            deviationHamLevel = 2;
                            alarmHamMsg = "重锤处皮带发生严重跑偏\r\n";
                        }
                        byte[] bufferLength = new byte[10];
                        progressBar_Ham.Value = 0;
                        int msglength = socketReceiveHam.Receive(bufferLength, bufferLength.Length, SocketFlags.None);
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
                            int r = socketReceiveHam.Receive(buffer, buffer.Length, SocketFlags.None);
                            if (r == 0) break;
                            if (length > 0)
                            {
                                for (int index = 0; index < r; index++)
                                {
                                    list_Binary_ham.Add(buffer[index]);
                                }
                                length -= r;
                                progressBar_Ham.Value = (int)(((double)(recive - length) / ((double)recive)) * 100);
                            }
                            if (length <= 0)
                            {
                                if (progressBar_Ham.Value == progressBar_Ham.Maximum)
                                    progressBar_Ham.Value = 0;
                                Array.Clear(buffer, 0, buffer.Length);
                                break;
                            }
                        }
                        ConvertToPicHam(list_Binary_ham);
                    }
                    else
                    {
                        byte[] tmpBuffer = new byte[1024];
                        int tmpBufferlength = socketReceiveHam.Receive(tmpBuffer, tmpBuffer.Length, SocketFlags.None);
                        if (tmpBufferlength == 0) break;
                        Array.Clear(tmpBuffer, 0, tmpBuffer.Length);
                    }
                }
            }
            catch
            {
                //MessageBox.Show("相机连接失败，请关闭窗口重新连接！");
            }
        }

        DateTime dtHam;
        private void ConvertToPicHam(List<byte> list_Binary)
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

            dtHam = DateTime.Now;
            if (picBox_Ham.Image == null) 
            {
                picBox_Ham.Image = bitmap;
            }

            string fileNameShort = dtHam.ToString("yyyy年MM月dd日HH时mm分ss秒");
            string fileName = fileNameShort + ".bmp";
            string bmpPath = dirPath + "/日志/重锤跑偏照片" + "\\" + fileName;

            //timer_Ham.Enabled = true;
            if (deviationHamLevel == 1)
            {
                lbl_Ham_number.Text = rd_Ham.Next(0, 50).ToString() + "厘米";
            }
            if (deviationHamLevel == 2)
            {
                lbl_Ham_number.Text = rd_Ham.Next(5, 99).ToString() + "厘米";
            }

            listFileFullNameHam.Insert(0, bmpPath);
            listBox_Ham.Items.Insert(0, Path.GetFileNameWithoutExtension(bmpPath));
            string logMsg = fileNameShort + ": " + alarmHamMsg;
            textBox_Ham.Text = textBox_Ham.Text.Insert(0, logMsg);
            WriteToLogFile("重锤皮带跑偏详细记录.txt", logMsg);
            if (MediaPlayer_Ham_Alarm.playState == WMPLib.WMPPlayState.wmppsUndefined || MediaPlayer_Ham_Alarm.playState == WMPLib.WMPPlayState.wmppsStopped)
                MediaPlayer_Ham_Alarm.URL = alarmHamURL;
            bitmap.Save(bmpPath);
        }
        #endregion

        #region 机尾相机连接
        //机尾相机开始连接
        Socket socketWatchEnd = null;
        Thread threadWatchEnd = null;
        private void btn_End_Connect_Click(object sender, EventArgs e)
        {
            string endIP = "192.168.0.205";
            string endPort = "8234";
            socketWatchEnd = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPAddress ipAddressEnd = IPAddress.Parse(endIP.Trim());
            IPEndPoint endPointEnd = new IPEndPoint(ipAddressEnd, int.Parse(endPort.Trim()));
            socketWatchEnd.Bind(endPointEnd);
            socketWatchEnd.Listen(20);

            threadWatchEnd = new Thread(new ParameterizedThreadStart(WatchConnectingEnd));
            threadWatchEnd.IsBackground = true;
            threadWatchEnd.Start(socketWatchEnd);
            lbl_End.Text = "等待相机连接......";
        }

        //监听函数
        Socket socketServerEnd = null;
        Socket socketConnectionEnd = null;
        Thread threadReceiveEnd = null;
        private void WatchConnectingEnd(object obj)
        {
            try
            {
                socketServerEnd = obj as Socket;
                while (true)
                {
                    socketConnectionEnd = socketServerEnd.Accept();
                    if (socketConnectionEnd != null)
                    {
                        btn_End_Connect.Enabled = false;
                        lbl_End.Text = "相机连接成功!";
                        threadReceiveEnd = new Thread(new ParameterizedThreadStart(MsgReceiveEnd));
                        threadReceiveEnd.IsBackground = true;
                        threadReceiveEnd.Start(socketConnectionEnd);
                    }
                }
            }
            catch
            {
                //MessageBox.Show("相机连接失败，请关闭窗口重新连接！");
            }
        }

        //用来存放二进制数据的list
        List<byte> list_Binary_end= new List<byte>();

        //通信函数
        string alarmEndMsg = null;
        Socket socketReceiveEnd = null;
        //用来显示跑偏量的等级
        int deviationEndLevel = 0;
        private void MsgReceiveEnd(Object obj)
        {
            try
            {
                socketReceiveEnd = obj as Socket;
                while (true)
                {
                    byte[] endinfo = new byte[5];
                    int endinfoLength = socketReceiveEnd.Receive(endinfo, endinfo.Length, SocketFlags.None);
                    if (endinfoLength == 0) break;
                    string info = Encoding.UTF8.GetString(endinfo, 0, endinfoLength);
                    Console.WriteLine("info={0}", info);
                    if (info[0] == '0' && info[1] == '0' && info[2] == '0' && info[3] == '0')
                    {
                        byte[] endLevelInfo = new byte[5];
                        int levelLength = socketReceiveEnd.Receive(endLevelInfo, endLevelInfo.Length, SocketFlags.None);
                        if (levelLength == 0)
                        {
                            //如果没有接收到文件，则结束循环
                            break;
                        }
                        string strMsg = Encoding.UTF8.GetString(endLevelInfo, 0, levelLength);
                        Console.WriteLine("strMsg={0}", strMsg);
                        if (strMsg[0] == '1')
                        {
                            deviationEndLevel = 1;
                            //textBox_Head.AppendText("机头处皮带发生轻微跑偏");
                            alarmEndMsg = "机尾处皮带发生轻微跑偏\r\n";
                        }
                        if (strMsg[0] == '2')
                        {
                            deviationEndLevel = 2;
                            alarmEndMsg = "机尾处皮带发生严重跑偏\r\n";
                        }
                        byte[] bufferLength = new byte[10];
                        progressBar_End.Value = 0;
                        int msglength = socketReceiveEnd.Receive(bufferLength, bufferLength.Length, SocketFlags.None);
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
                            int r = socketReceiveEnd.Receive(buffer, buffer.Length, SocketFlags.None);
                            if (r == 0) break;
                            if (length > 0)
                            {
                                for (int index = 0; index < r; index++)
                                {
                                    list_Binary_end.Add(buffer[index]);
                                }
                                length -= r;
                                progressBar_End.Value = (int)(((double)(recive - length) / ((double)recive)) * 100);
                            }
                            if (length <= 0)
                            {
                                if (progressBar_End.Value == progressBar_End.Maximum)
                                    progressBar_End.Value = 0;
                                Array.Clear(buffer, 0, buffer.Length);
                                break;
                            }
                        }
                        ConvertToPicEnd(list_Binary_end);
                    }
                    else
                    {
                        byte[] tmpBuffer = new byte[1024];
                        int tmpBufferlength = socketReceiveEnd.Receive(tmpBuffer, tmpBuffer.Length, SocketFlags.None);
                        if (tmpBufferlength == 0) break;
                        Array.Clear(tmpBuffer, 0, tmpBuffer.Length);
                    }
                }
            }
            catch
            {
                //MessageBox.Show("相机连接失败，请关闭窗口重新连接！");
            }
        }

        DateTime dtEnd;
        private void ConvertToPicEnd(List<byte> list_Binary)
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

            dtEnd = DateTime.Now;
            if (picBox_End.Image == null)
            {
                picBox_End.Image = bitmap;
            }
            string fileNameShort = dtEnd.ToString("yyyy年MM月dd日HH时mm分ss秒");
            string fileName = fileNameShort + ".bmp";
            string bmpPath = dirPath + "/日志/机尾跑偏照片" + "\\" + fileName;

            //timer_End.Enabled = true;

            if (deviationEndLevel == 1) 
            {
                lbl_End_number.Text = rd_End.Next(0, 50).ToString() + "厘米";
            }
            if (deviationEndLevel == 2)
            {
                lbl_End_number.Text = rd_End.Next(50, 99).ToString() + "厘米";
            }

            listFileFullNameEnd.Insert(0, bmpPath);
            listBox_End.Items.Insert(0, Path.GetFileNameWithoutExtension(bmpPath));
            string logMsg = fileNameShort + ": " + alarmEndMsg;
            textBox_End.Text = textBox_End.Text.Insert(0, logMsg);
            if (MediaPlayer_End_Alarm.playState == WMPLib.WMPPlayState.wmppsUndefined || MediaPlayer_End_Alarm.playState == WMPLib.WMPPlayState.wmppsStopped)
                MediaPlayer_End_Alarm.URL = alarmEndURL;
            bitmap.Save(bmpPath);
        }
        #endregion

        #region 打开日志文件夹
        private void 打开日志文件夹ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = dirPath + "\\日志";
            //Console.WriteLine(path);
            System.Diagnostics.Process.Start("Explorer.exe", path);
        }
        #endregion

        #region 图片选择
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

        #region 报警音设置
        private void 机头跑偏报警音ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = dirPath;
            ofd.Title = "请选择要设置的报警声音";
            ofd.Filter = "音频文件|*.mp3;*.wav";
            ofd.ShowDialog();
            alarmHeadURL = ofd.FileName;
            string configPath = Path.GetDirectoryName(Application.ExecutablePath) + "\\机头位置报警音配置文件";
            //文件存在追加内容，不存在创建文件
            using (StreamWriter sw = new StreamWriter(configPath))
            {
                sw.WriteLine(alarmHeadURL);
            }
        }
        private string GetalarmHeadURL()
        {
            string configPath = Path.GetDirectoryName(Application.ExecutablePath) + "\\机头位置报警音配置文件";
            string Url = null;
            using (StreamReader sr = new StreamReader(configPath))
            {
                Url = sr.ReadLine();
            }
            return Url;
        }
        private void 重锤跑偏报警音ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = dirPath;
            ofd.Title = "请选择要设置的报警声音";
            ofd.Filter = "音频文件|*.mp3;*.wav";
            ofd.ShowDialog();
            alarmHamURL = ofd.FileName;
            string configPath = Path.GetDirectoryName(Application.ExecutablePath) + "\\重锤位置报警音配置文件";
            //文件存在追加内容，不存在创建文件
            using (StreamWriter sw = new StreamWriter(configPath))
            {
                sw.WriteLine(alarmHamURL);
            }
        }
        private string GetalarmHamURL()
        {
            string configPath = Path.GetDirectoryName(Application.ExecutablePath) + "\\重锤位置报警音配置文件";
            string Url = null;
            using (StreamReader sr = new StreamReader(configPath))
            {
                Url = sr.ReadLine();
            }
            return Url;
        }
        private void 机尾跑偏报警音ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = dirPath;
            ofd.Title = "请选择要设置的报警声音";
            ofd.Filter = "音频文件|*.mp3;*.wav";
            ofd.ShowDialog();
            alarmEndURL = ofd.FileName;
            string configPath = Path.GetDirectoryName(Application.ExecutablePath) + "\\机尾位置报警音配置文件";
            //文件存在追加内容，不存在创建文件
            using (StreamWriter sw = new StreamWriter(configPath))
            {
                sw.WriteLine(alarmEndURL);
            }
        }
        private string GetalarmEndURL()
        {
            string configPath = Path.GetDirectoryName(Application.ExecutablePath) + "\\机尾位置报警音配置文件";
            string Url = null;
            using (StreamReader sr = new StreamReader(configPath))
            {
                Url = sr.ReadLine();
            }
            return Url;
        }
        #endregion

        #region 清空照片候选框
        private void 清空机头候选框ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            picBox_Head.ImageLocation = null;
            picBox_Head.Image = null;
            for (int index = 0; index < listFileFullNameHead.Count; index++)
            {
                string dstName = dirPath + "/日志/机头跑偏照片/历史照片/" + listBox_Head.Items[index] + ".bmp";
                File.Move(listFileFullNameHead[index], dstName);
            }
            listFileFullNameHead.Clear();
            listBox_Head.Items.Clear();
        }

        private void 清空重锤候选框ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            picBox_Ham.ImageLocation = null;
            picBox_Ham.Image = null;
            for (int index = 0; index < listFileFullNameHam.Count; index++)
            {
                string dstName = dirPath + "/日志/重锤跑偏照片/历史照片/" + listBox_Ham.Items[index] + ".bmp";
                File.Move(listFileFullNameHam[index], dstName);
            }
            listFileFullNameHam.Clear();
            listBox_Ham.Items.Clear();
        }

        private void 清空机尾候选框ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            picBox_End.ImageLocation = null;
            picBox_End.Image = null;
            for (int index = 0; index < listFileFullNameEnd.Count; index++)
            {
                string dstName = dirPath + "/日志/机尾跑偏照片/历史照片/" + listBox_End.Items[index] + ".bmp";
                File.Move(listFileFullNameEnd[index], dstName);
            }
            listFileFullNameEnd.Clear();
            listBox_End.Items.Clear();
        }
        #endregion

        #region 写入日志文件
        public void WriteToLogFile(string fileFullName, string message)
        {
            //获取当前执行文件所在路径
            string LogPath = Path.GetDirectoryName(Application.ExecutablePath) + "\\日志\\" + fileFullName;
            //文件存在追加内容，不存在创建文件
            using (StreamWriter sw = new StreamWriter(LogPath, true))
            {
                sw.WriteLine(message);
            }
        }
        #endregion

        //释放所有线程和套接字实例
        private void DeviationFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (socketWatchHead != null)
            {
                socketWatchHead.Close();
            }
            if (socketWatchHead != null)
            {
                socketWatchHead.Close();
            }
            if (threadWatchHead != null)
            {
                threadWatchHead.Abort();
            }
            if (socketServerHead != null)
            {
                socketServerHead.Close();
            }
            if (socketConnectionHead != null)
            {
                socketConnectionHead.Close();
            }
            if (threadReceiveHead != null)
            {
                threadReceiveHead.Abort();
            }
            if (socketReceiveHead != null)
            {
                socketReceiveHead.Close();
            }


            if (socketWatchHam != null)
            {
                socketWatchHam.Close();
            }
            if (socketWatchHam != null)
            {
                socketWatchHam.Close();
            }
            if (threadWatchHam != null)
            {
                threadWatchHam.Abort();
            }
            if (socketServerHam != null)
            {
                socketServerHam.Close();
            }
            if (socketConnectionHam != null)
            {
                socketConnectionHam.Close();
            }
            if (threadReceiveHam != null)
            {
                threadReceiveHam.Abort();
            }
            if (socketReceiveHam != null)
            {
                socketReceiveHam.Close();
            }


            if (socketWatchEnd != null)
            {
                socketWatchEnd.Close();
            }
            if (socketWatchEnd != null)
            {
                socketWatchEnd.Close();
            }
            if (threadWatchEnd != null)
            {
                threadWatchEnd.Abort();
            }
            if (socketServerEnd != null)
            {
                socketServerEnd.Close();
            }
            if (socketConnectionEnd != null)
            {
                socketConnectionEnd.Close();
            }
            if (threadReceiveEnd != null)
            {
                threadReceiveEnd.Abort();
            }
            if (socketReceiveEnd != null)
            {
                socketReceiveEnd.Close();
            }

            timer_Head_New.Enabled = false;
            timer_Ham_New.Enabled = false;
            timer_End_New.Enabled = false;

        }

        # region 清空图片
        //清空图片函数
        private void 清空机头图片ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            picBox_Head.ImageLocation = null;
            picBox_Head.Image = null;
        }

        private void 清空重锤图片ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            picBox_Ham.ImageLocation = null;
            picBox_Ham.Image = null;
        }

        private void 清空机尾图片ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            picBox_End.ImageLocation = null;
            picBox_End.Image = null;
        }
        #endregion

        #region 清空报警日志
        //清空报警日志函数
        private void 清空机头报警日志ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox_Head.Text = "";
        }

        private void 清空重锤报警日志ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox_Ham.Text = "";
        }

        private void 清空机尾报警日志ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox_End.Text = "";
        }
        #endregion

        #region 跑偏距离清零
        //跑偏距离清零的函数
        private void btn_Head_Zero_Click(object sender, EventArgs e)
        {
            lbl_Head_number.Text = "00厘米";
        }

        private void btn_Ham_Zero_Click(object sender, EventArgs e)
        {
            lbl_Ham_number.Text = "00厘米";
        }

        private void btn_End_Zero_Click(object sender, EventArgs e)
        {
            lbl_End_number.Text = "00厘米";
        }
        #endregion

        #region 停止指示灯闪烁
        //用来停止指示灯闪烁的函数
        private void btn_Head_StopFlicker_Click(object sender, EventArgs e)
        {
            timer_Head_New.Enabled = false;
            picBox_Light_Head.Image = Properties.Resources.g_1;
        }

        private void btn_Ham_StopFlicker_Click(object sender, EventArgs e)
        {
            timer_Ham_New.Enabled = false;
            picBox_Light_Ham.Image = Properties.Resources.g_1;
        }

        private void btn_End_StopFlicker_Click(object sender, EventArgs e)
        {
            timer_End_New.Enabled = false;
            picBox_Light_End.Image = Properties.Resources.g_1;
        }
        #endregion

        #region 控制指示灯闪烁
        //用来控制指示灯闪烁的函数
        int timerFlagHead = 0;
        private void HeadTimeOut(object source, System.Timers.ElapsedEventArgs e)
        {
            //lbl_Head_number.Text = rd_Head.Next(0, 100).ToString() + "厘米";
            if (timerFlagHead == 0) 
            {
                picBox_Light_Head.Image = Properties.Resources.r_1;
                timerFlagHead++;
            }
            else
            {
                picBox_Light_Head.Image = Properties.Resources.g_1;
                timerFlagHead = 0;
            }
        }

        int timerFlagHam = 0;
        private void HamTimeOut(object source, System.Timers.ElapsedEventArgs e)
        {
            //lbl_Ham_number.Text = rd_Ham.Next(0, 100).ToString() + "厘米";
            if (timerFlagHam == 0)
            {
                picBox_Light_Ham.Image = Properties.Resources.r_1;
                timerFlagHam++;
            }
            else
            {
                picBox_Light_Ham.Image = Properties.Resources.g_1;
                timerFlagHam = 0;
            }
        }

        int timerFlagEnd = 0;
        private void EndTimeOut(object source, System.Timers.ElapsedEventArgs e)
        {
            //lbl_End_number.Text = rd_End.Next(0, 100).ToString() + "厘米";
            if (timerFlagEnd == 0)
            {
                picBox_Light_End.Image = Properties.Resources.r_1;
                timerFlagEnd++;
            }
            else
            {
                picBox_Light_End.Image = Properties.Resources.g_1;
                timerFlagEnd = 0;
            }
        }
        #endregion

        #region 定时器工作
        //文本框内容变化且不为空，定时器工作
        private void textBox_Head_TextChanged(object sender, EventArgs e)
        {
            if (textBox_Head.Text != "")
            {
                timer_Head_New.Enabled = true;
            }
        }

        private void textBox_Ham_TextChanged(object sender, EventArgs e)
        {
            if (textBox_Ham.Text != "")
            {
                timer_Ham_New.Enabled = true;
            }
        }

        private void textBox_End_TextChanged(object sender, EventArgs e)
        {
            if (textBox_End.Text != "")
            {
                timer_End_New.Enabled = true;
            }
        }
        #endregion
    }
}
