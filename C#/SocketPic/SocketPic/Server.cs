using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

namespace SocketPic
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
        }
      

        //用来显示提示信息的字符串
        string strIP = null;

        

        //监听线程和套接字
        Socket socketWatch = null;
        Thread threadWatch = null;

        //用来建立连接和通信的套接字
        Socket socketReceive = null;

        //用来通信的线程
        Thread threadReceive = null;

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            //返回目录下的所有jpg文件的完成路径
            strFileFullName = Directory.GetFiles(dirPath, "*.bmp");
            foreach (var item in strFileFullName)
            {
                list_Pics.Items.Add(Path.GetFileNameWithoutExtension(item));
                listFileFullName.Add(item);
            }
            
        }

        private void btn_Watch_Click(object sender, EventArgs e)
        {
            try
            {
                socketWatch = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPAddress IP = IPAddress.Parse(txtBox_IP.Text.Trim());
                IPEndPoint point = new IPEndPoint(IP, Convert.ToInt32(txtBox_Port.Text.Trim()));
                socketWatch.Bind(point);
                socketWatch.Listen(20);

                threadWatch = new Thread(Watching);
                threadWatch.IsBackground = true;
                threadWatch.Start();
                txtBox_Log.AppendText("开始监听......\r\n");
            }
            catch { }
        }
  
        private void Watching()
        {
            try
            {
                while (true)
                {
                    socketReceive = socketWatch.Accept();
                    strIP = "远程主机：" + socketReceive.RemoteEndPoint;
                    string strIPMsg = strIP + "连接成功\r\n";
                    txtBox_Log.AppendText(strIPMsg);

                    threadReceive = new Thread(Receive);
                    threadReceive.IsBackground = true;
                    threadReceive.Start();
                }
            }
            catch{}
        }


        //用来存放文件名的列表和数组
        List<string> listFileFullName = new List<string>();
        string[] strFileFullName = null;
        //文件存放地址
        string dirPath = "E:\\JZS\\CsharpNote\\SocketPic\\SocketPic\\log";
        //用来缓存数据的空间
        List<byte> bufferList = new List<byte>();
        //用来给图片文件命名
        DateTime dt;

        //用来存放二进制数据的list
        List<byte> list_Binary = new List<byte>();
        private void Receive()
        {
            //string strPath = null;
            //string fileNameShort = null;

            #region 大文件传送
            try
            {
                while (true)
                {
                    //接收判别信息类型的头信息的缓冲区
                    byte[] ack = new byte[4];
                    int msgLength = socketReceive.Receive(ack, ack.Length, SocketFlags.None);
                    if (msgLength == 0) break;
                    string info = Encoding.UTF8.GetString(ack, 0, msgLength);
                    if(info[0] == '0')
                    {
                        byte[] buffer = new byte[4];
                        int r = socketReceive.Receive(buffer, buffer.Length, SocketFlags.None);
                        if (r == 0)
                        {
                            //如果没有接收到文件，则结束循环
                            break;
                        }
                        string strMsg = Encoding.UTF8.GetString(buffer, 0, r);
                        txtBox_Msg.AppendText("Hello World!" + "\r\n");
                        //dt = DateTime.Now;
                        //using(FileStream fs = new FileStream(dirPath+"\\log.txt", FileMode.OpenOrCreate))
                    }
                    else
                    {
                        if (info[0] == '1') 
                        {
                            progressBar_PicLoad.Value = 0;
                            #region 设置文件名(弃用)
                            //设置接收的文件的路劲以及文件名
                            //dt = DateTime.Now;
                            //fileNameShort = dt.ToString("yyyy-MM-dd-HH-mm-ss");
                            //string fileName = fileNameShort + ".txt";
                            //strPath = dirPath + "\\tmp\\" + fileName;
                            //Console.WriteLine("stepath={0}", strPath);
                            #endregion

                            //接收的大文件总的字节数
                            long length = 0;
                            long recive = 0;

                            while (true)
                            {
                                //Console.WriteLine("length ={0}", length);

                                byte[] buffer = new byte[1024 * 2];
                                Array.Clear(buffer, 0, buffer.Length);
                                //接收数据包的长度
                                //receive会阻塞线程，程序一直停在这
                                int r = socketReceive.Receive(buffer, buffer.Length, SocketFlags.None);
                                //Console.WriteLine("r ={0}", r);

                                //确定文件实际接收的文件大小
                                if (r == 0)
                                {
                                    //如果没有接收到文件，则结束循环
                                    break;
                                }
                                if (length > 0)  //判断大文件是否已经保存完
                                {
                                    #region 写入文件(弃用)
                                    //using (FileStream fsWrite = new FileStream(strPath, FileMode.Append, FileAccess.Write))
                                    //{
                                    //    fsWrite.Write(buffer, 0, r);
                                    //    //减去每次保存的字节数
                                    //    length -= r;
                                    //    progressBar_PicLoad.Value = (int)(((double)(recive - length) / ((double)recive)) * 100);

                                    //    if (length <= 0)
                                    //    {
                                    //        Array.Clear(buffer, 0, buffer.Length);
                                    //        break;
                                    //    }
                                    //    continue;
                                    //}
                                    #endregion
                                    for (int index = 0; index < r; index++)
                                    {
                                        list_Binary.Add(buffer[index]);
                                    }
                                    length -= r;
                                    progressBar_PicLoad.Value = (int)(((double)(recive - length) / ((double)recive)) * 100);
                                    if (length <= 0)
                                    {
                                        Array.Clear(buffer, 0, buffer.Length);
                                        break;
                                    }
                                    continue;
                                }
                                string str_Length = Encoding.UTF8.GetString(buffer, 0, r);
                                length = int.Parse(str_Length);
                                recive = length;

                            }
                            ConvertToPic(list_Binary);
                        }
                    }
                    #region
                    //progressBar_PicLoad.Value = 0;
                    ////设置接收的文件的路劲以及文件名
                    //dt = DateTime.Now;
                    //fileNameShort = dt.ToString("yyyy-MM-dd-HH-mm-ss");
                    //string fileName = fileNameShort + ".txt";
                    //strPath = dirPath + "\\tmp\\" + fileName;
                    ////Console.WriteLine("stepath={0}", strPath);

                    ////接收的大文件总的字节数
                    //long length = 0;
                    //long recive = 0; 

                    //while (true)
                    //{
                    //    //Console.WriteLine("length ={0}", length);

                    //    byte[] buffer = new byte[1024 * 2];
                    //    Array.Clear(buffer, 0, buffer.Length);
                    //    //接收数据包的长度
                    //    //receive会阻塞线程，程序一直停在这
                    //    int r = socketReceive.Receive(buffer, buffer.Length, SocketFlags.None);
                    //    //Console.WriteLine("r ={0}", r);

                    //    //确定文件实际接收的文件大小
                    //    if (r == 0)
                    //    {
                    //        //如果没有接收到文件，则结束循环
                    //        break;
                    //    }
                    //    if (length > 0)  //判断大文件是否已经保存完
                    //    {
                    //        using (FileStream fsWrite = new FileStream(strPath, FileMode.Append, FileAccess.Write))
                    //        {
                    //            fsWrite.Write(buffer, 0, r);
                    //            //减去每次保存的字节数
                    //            length -= r;
                    //            progressBar_PicLoad.Value = (int)(((double)(recive - length) / ((double)recive))*100);

                    //            if (length <= 0)
                    //            {
                    //                Array.Clear(buffer, 0, buffer.Length);
                    //                break;
                    //            }
                    //            continue;
                    //        }
                    //    }
                    //    string str_Length = Encoding.UTF8.GetString(buffer, 0, r);
                    //    //Console.WriteLine("str_Length={0}", str_Length);
                    //    length = int.Parse(str_Length);
                    //    recive = length;
                    //}
                    //ConvertToPic(strPath);
                    #endregion
                }
            }
            catch { }
            #endregion
        }

        private void ConvertToPic(List<byte> list_Binary)
        {
            //获取二进制数据
            byte[] pageData = list_Binary.ToArray();
            //清空list便于下次使用
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
            dt = DateTime.Now;
            string fileNameShort = dt.ToString("yyyy-MM-dd-HH-mm-ss");
            string fileName = fileNameShort + ".bmp";
            string bmpPath = dirPath + "\\" + fileName;

            listFileFullName.Add(bmpPath);
            list_Pics.Items.Add(Path.GetFileNameWithoutExtension(bmpPath));
            bitmap.Save(bmpPath);
        }
        ////避免I/O操作
        //private void ConvertToPic(string binaryFilePath)
        //{
        //    //建立存储图片二进制数据的缓冲区
        //    byte[] pageData = null;

        //    //读取图片的二进制数据
        //    FileStream fs = new FileStream(binaryFilePath, FileMode.Open);
        //    BinaryReader binReader = new BinaryReader(fs);
        //    pageData = new byte[fs.Length];
        //    binReader.Read(pageData, 0, (int)fs.Length);
        //    binReader.Close();
        //    fs.Close();

        //    //用来设置存储图片像素值得二维矩阵
        //    int[,] pixels = new int[320 * 240, 3];
        //    int count = 0;

        //    //建立图像缓存数据
        //    var bitmap = new Bitmap(320, 240, PixelFormat.Format32bppRgb);

        //    for (int i = 0; i < pageData.Length - 1; i = i + 2)
        //    {
        //        //分别读取处每一个像素的值
        //        int intLow = pageData[i + 1];
        //        int tmpintHigh = pageData[i];
        //        int tmpHigh = tmpintHigh << 8;
        //        int pixel = tmpHigh | intLow;
        //        int red = (pixel & 0xf800) >> 11;
        //        int green = (pixel & 0x07e0) >> 5;
        //        int blue = (pixel & 0x001f);
        //        pixels[count, 0] = (red << 3);
        //        pixels[count, 1] = (green << 2);
        //        pixels[count, 2] = (blue << 3);
        //        count++;
        //    }
        //    int alpha = 0xff;
        //    count = 0;
        //    for (int y = 0; y < 240; y++)
        //    {
        //        for (int x = 0; x < 320; x++)
        //        {
        //            bitmap.SetPixel(x, y, Color.FromArgb(alpha, pixels[count, 0], pixels[count, 1], pixels[count, 2]));
        //            count++;
        //        }
        //    }
        //    DirectoryInfo pathInforoot = new DirectoryInfo(binaryFilePath);
        //    DirectoryInfo pathInfo = new DirectoryInfo(pathInforoot.Parent.FullName);
        //    string bmpPath = pathInfo.Parent.FullName + "\\" + Path.GetFileNameWithoutExtension(binaryFilePath) + ".bmp";

        //    listFileFullName.Add(bmpPath);
        //    list_Pics.Items.Add(Path.GetFileNameWithoutExtension(bmpPath));
        //    bitmap.Save(bmpPath);
        //}

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            if (socketWatch != null)
            {
                socketWatch = null;
            }
            if (threadWatch != null)
            {
                txtBox_Log.AppendText(strIP + "：连接断开\r\n");
                threadWatch = null;
            }
            if (socketReceive != null)
            {
                socketReceive = null;
            }
            if(threadReceive != null)
            {
                threadReceive = null;
            }
        }
        
        private void list_Pics_SelectedIndexChanged(object sender, EventArgs e)
        {
            //根据选定的文件名称显示对应的图片
            pic_Load.ImageLocation = listFileFullName[list_Pics.SelectedIndex];
        }

        private void timer_Tick(object sender, EventArgs e)
        {

        }

        private void btn_Fresh_Click(object sender, EventArgs e)
        {

        }
    }
}
