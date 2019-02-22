using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 多线程测试
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }

        Thread thread01 = null;
        Thread thread02 = null;
        Thread thread03 = null;

        string[] countryName = new string[] { "China", "Japan", "USA", "UK", "Spanish" };

        List<string> listName = new List<string>();
        private void button1_Click(object sender, EventArgs e)
        {
            thread01 = new Thread(AddList01);
            thread01.IsBackground = true;
            thread01.Start();

            thread02 = new Thread(AddList02);
            thread02.IsBackground = true;
            thread02.Start();

            thread03 = new Thread(AddList03);
            thread03.IsBackground = true;
            thread03.Start();
        }
        
        private void AddList01()
        {
            string name = "China";
            Display(name, "线程1");
        }

        private void AddList02()
        {
            string name = "Japan";
            Display(name, "线程2");
        }

        private void AddList03()
        {
            string name = "USA";
            Display(name, "线程3");
        }

        private static readonly object lockerheadobj = new object();
        void Display(string name, string threadName)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            lock (lockerheadobj)
            {
                listName.Insert(0, name);
                listBox1.Items.Insert(0, name.ToUpper());
                listBox2.Items.Insert(0, name.ToLower());
                textBox1.Text = textBox1.Text.Insert(0, threadName+"\r\n");
                WriteToLogFile("123.txt", threadName+ name);
                if (MediaPlayer.playState == WMPLib.WMPPlayState.wmppsUndefined || MediaPlayer.playState == WMPLib.WMPPlayState.wmppsStopped)
                    MediaPlayer.URL = @"E:\JZS\Code\C#\皮带跑偏与撕裂检测监控界面\皮带跑偏与撕裂检测监控界面\Resources\机头处皮带发生跑偏.wav";
            }
            sw.Stop();
            Console.WriteLine("{1}加锁程序耗时{0}", sw.Elapsed.ToString(), threadName);
        }

        static ReaderWriterLockSlim WriteToLogFileLock = new ReaderWriterLockSlim();
        public void WriteToLogFile(string fileFullName, string message)
        {
            try
            {
                WriteToLogFileLock.EnterWriteLock();
                //获取当前执行文件所在路径
                string LogPath = Path.GetDirectoryName(Application.ExecutablePath) + fileFullName;
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

        private void button2_Click(object sender, EventArgs e)
        {
            listName.Clear();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            textBox1.Text = "";
        }
    }
}
