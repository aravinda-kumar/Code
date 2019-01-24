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

namespace LockTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> listArray = new List<string>();
        string[] strs1 = new string[] { "china", "japan", "america", "english", "germay" };
        string[] strs2 = new string[] { "beijing", "tokyo", "washington", "londa", "banger" };
        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }

        Thread thread_1 = null;
        Thread thread_2 = null;
        private void button1_Click(object sender, EventArgs e)
        {
            thread_1 = new Thread(Add_1);
            thread_1.IsBackground = true;
            thread_1.Start();

            thread_2 = new Thread(Add_2);
            thread_2.IsBackground = true;
            thread_2.Start();
        }

        private void Add_1()
        {
            foreach (var item in strs1)
            {
                lock (listArray)
                {
                    listArray.Add(item);
                    textBox1.AppendText(item + "\r\n");
                }
                
            }
        }

        private void Add_2()
        {
            foreach (var item in strs2)
            {
                lock (listArray)
                {
                    listArray.Add(item);
                    textBox1.AppendText(item + "\r\n");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listArray.Clear();
            textBox1.Clear();
        }


        Thread thread_11 = null;
        Thread thread_12 = null;
        Thread thread_13 = null;
        Thread thread_14 = null;
        private void button3_Click(object sender, EventArgs e)
        {
            thread_11 = new Thread(Add_11);
            thread_11.IsBackground = true;
            thread_11.Start();

            thread_12 = new Thread(Add_12);
            thread_12.IsBackground = true;
            thread_12.Start();

            thread_13 = new Thread(Add_13);
            thread_13.IsBackground = true;
            thread_13.Start();

            thread_14 = new Thread(Add_14);
            thread_14.IsBackground = true;
            thread_14.Start();
            //WriteToLogFile("123.txt", DateTime.Now.ToString("yyyy年MM月dd日HH时mm分ss秒ffff毫秒"));
        }

        private void Add_11()
        {
            WriteToLogFile("123.txt", DateTime.Now.ToString("yyyy年MM月dd日HH时mm分ss秒ffff毫秒"));
        }

        private void Add_12()
        {
            WriteToLogFile("123.txt", DateTime.Now.ToString("yyyy年MM月dd日HH时mm分ss秒ffff毫秒"));
        }

        private void Add_13()
        {
            WriteToLogFile("123.txt", DateTime.Now.ToString("yyyy年MM月dd日HH时mm分ss秒ffff毫秒"));
        }

        private void Add_14()
        {
            WriteToLogFile("123.txt", DateTime.Now.ToString("yyyy年MM月dd日HH时mm分ss秒ffff毫秒"));
        }

        static ReaderWriterLockSlim WriteToLogFileLock = new ReaderWriterLockSlim();
        private void WriteToLogFile(string fileFullName, string message)
        {
            try
            {
                WriteToLogFileLock.EnterWriteLock();
                //获取当前执行文件所在路径
                string LogPath = Path.GetDirectoryName(Application.ExecutablePath) + "\\" + fileFullName;
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
    }
}
