using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Net.Sockets;
using System.Net;
using AxMSCommLib;

namespace 停等协议
{
    public partial class Form1 : Form
    {
        string savedPath, sendPath;//打开路径与保存路径
        byte[] senddata, receivedata, persistdata;//发送数据与接收数据。receivedata最后为全部有效帧的集合
        byte[] databack;//发送数据备份
        //persistdata为要存入硬盘的数据
        int receiveindex = 0;//写到receivedata数组的第receiveindex位
        PictureBox receivepic, sendpic;
        int length = 128;//每个帧的有效数据长度
        Thread thread;
        int count = 0;//记录桢的数量
        string state = "";//当前状态，发送或接收
        byte code = 0;//序列号
        //  UdpClient udp;
        // int myport, partnerport;
        bool isfinished = false;//是否发送结束
        private delegate void FlushClient();//代理
        
        public Form1()
        {
            InitializeComponent();
         //初始化
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
            axMSComm1.CommPort = 1;
            if (axMSComm1.PortOpen)
                axMSComm1.PortOpen = false;
            axMSComm1.RThreshold = (short)(length + 8);
            axMSComm1.Settings = "9600,n,8,1";
            axMSComm1.Handshaking = MSCommLib.HandshakeConstants.comNone;
            axMSComm1.InputMode = MSCommLib.InputModeConstants.comInputModeBinary;
            axMSComm1.InputLen = 0;
            axMSComm1.OnComm += new System.EventHandler(this.OnComm);
            axMSComm1.PortOpen = true;
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
            openFileDialog1.Filter = "All Files|*.*|BMP Files|*.bmp|TXT Files|*.txt";
            axMSComm1.InBufferCount = 0;//清空缓冲

 

        }
        //显示状态信息
        private void  Message() {
            label1.Text = "状态为"+state+"桢大小为"+length+"个字节,已经"+state+" "+count+"桢";
            
        }

        private void showReceive()//显示收到的数据
        {
            if (isfinished) return;
            byte[] d = new byte[receivedata.Length - 1];
            Array.Copy(receivedata, 1, d, 0, d.Length);
            persistdata = d;
            if (receivedata[0] == 1)//判断是否为图片
            {
                

                    MemoryStream ms = new MemoryStream(d);
                    Image img = Image.FromStream(ms, true);

                    receivepic = new PictureBox();
                    receivepic.Image = img;
                    receivepic.Height = img.Height;
                    receivepic.Width = img.Width;
                    receivePanel.Controls.Add(receivepic);
                    receivePanel.Controls.Remove(revtext);
                
            }
            else//txt
            {
                receivePanel.Controls.Remove(receivepic);
                revtext.Text = System.Text.Encoding.Default.GetString(d);
                receivePanel.Controls.Add(revtext);

            }
          
            isfinished = true;
            MessageBox.Show("接收结束");
            button2.Enabled = true;

        }
        private void OnComm(object sender, EventArgs e)//接收方法
        {

            byte[] rdata =new byte[axMSComm1.InBufferCount];
            Array.Copy((byte[])axMSComm1.Input, 0, rdata, 0, rdata.Length);
            if (rdata.Length != length+8 && rdata.Length != 5)
            {
                axMSComm1.InBufferCount = 0;
                return;
            }
            count++;//收/发的桢数加一
            if (rdata.Length > 5)//判断是否为确认帧
            {//不是确认帧

                byte[] data = new byte[5];
                data[0] = 16;
                data[1] = 2;
                data[2] = rdata[2];//序号
                data[3] = 16;
                data[4] = 3;

                if (receivedata != null)
                {
                    byte[] cd = new byte[receivedata.Length];
                    Array.Copy(receivedata, 0, cd, 0, receivedata.Length);
                    Array.Copy(cd, 0, receivedata, 0, cd.Length);
                    receivedata = new byte[receivedata.Length + rdata[3]];
                    Array.Copy(cd, 0, receivedata, 0, cd.Length);
                    Array.Copy(rdata, 4, receivedata, cd.Length, rdata[3]);
                }
                else
                {
                    receivedata = new byte[rdata[3]];
                    Array.Copy(rdata, 4, receivedata, 0, rdata[3]);

                }

                if (rdata[2] == 255)//收到结束桢
                {

                    FlushClient fc = new FlushClient(showReceive);//显示收到的数据
                    this.BeginInvoke(fc);//调用代理
                    

                }
                else
                    isfinished = false;
                // udp.Send(data, data.Length, new IPEndPoint(IPAddress.Parse("127.0.0.1"), partnerport));
                axMSComm1.Output = data;
            }
            else if (rdata.Length == 5)//确认帧
            {
                
                if (code == rdata[2] || rdata[2] == 255)
                {


                    if (senddata.Length > length)
                    {
                        byte[] data = new byte[senddata.Length - length];
                        Array.Copy(senddata, length, data, 0, data.Length);
                        senddata = data;//在发送数据中删除已发送的数据

                    }

                    if (rdata[2] != 255)
                    {

                        thread.Interrupt();//唤醒线程，以发送下一个桢
                    }
                    else
                    {
                        isfinished = true;
                        
                        FlushClient fc = new FlushClient(sendOver);//显示发送结束
                        this.BeginInvoke(fc);//调用代理
                        senddata = new byte[databack.Length];
                        Array.Copy(databack, 0, senddata, 0, databack.Length);
                        MessageBox.Show("发送结束");
                    }
                }



            }


           
            if (code == 0) code = 1;
            else code = 0;

            FlushClient f = new FlushClient(Message);
            this.BeginInvoke(f);//调用代理

        }
        private void sendOver()
        {
            button4.Enabled = true;
        }
        private void button1_Click(object sender, EventArgs e)//浏览按钮
        {

            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
            sendPath = openFileDialog1.FileName;
            FileInfo fi = new FileInfo(sendPath);
            FileStream fs = fi.Open(FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(fs);
            senddata = new byte[fs.Length];
            reader.Read(senddata, 0, senddata.Length);//读文件数据进senddata
            byte[] da = new byte[senddata.Length];
            Array.Copy(senddata, 0, da, 0, senddata.Length);
            if (!sendPath.EndsWith(".txt"))
            {
                MemoryStream ms = new MemoryStream(da);
                Image img = Image.FromStream(ms, true);//生成图片


                sendpic = new PictureBox();
                sendpic.Image = img;

                sendpic.Height = img.Height;
                sendpic.Width = img.Width;
                sendPanel.Controls.Add(sendpic);
                if (text != null)
                {
                    sendPanel.Controls.Remove(text);

                }

            }
            else
            {

                text.Text = System.Text.Encoding.Default.GetString(senddata);
                sendPanel.Controls.Add(text);
                sendPanel.Controls.Remove(sendpic);
            }
            byte[] data = new byte[senddata.Length + 1];
            Array.Copy(senddata, 0, data, 1, senddata.Length);
            if (!sendPath.EndsWith(".txt") )//判断是什么类型的文件
                data[0] = 1;//如果是图片文件，则在有效数据前加一位1标识为BMP
            else
                data[0] = 0;//如果是TXT文件，则在有效数据前加一位0标识为TXT
            fs.Close();
            senddata = data;

        }

        private void send()//发送方法
        {

            while (true)
            {
                byte[] data = null;
                if (isfinished)
                {

                    return;
                }

                if (senddata.Length < length)//最后一帧
                {
                    //构造帧
                    data = new byte[8 + length];
                    data[0] = 16;
                    data[1] = 2;
                    data[2] = 255;
                    data[3] = (byte)senddata.Length;
                    Array.Copy(senddata, 0, data, 4, senddata.Length);
                    int c = 0;
                    for (int i = 0; i < senddata.Length; i++)//计算校验码
                        c += data[i + 4];
                    data[5 + senddata.Length] = (byte)(c % 256);
                    data[6 + senddata.Length] = 16;
                    data[7 + senddata.Length] = 3;

                }
                else//非最后一帧
                {
                    //构造帧
                    data = new byte[8 + length];
                    data[0] = 16;
                    data[1] = 2;
                    data[2] = code;
                    data[3] = (byte)length;
                    Array.Copy(senddata, 0, data, 4, length);//数组复制
                    int c = 0;
                    for (int i = 0; i < length; i++)
                        c += data[i + 4];
                    data[5 + length] = (byte)(c % 256);
                    data[6 + length] = 16;
                    data[7 + length] = 3;
                }
                // udp.Send(data, data.Length, new IPEndPoint(IPAddress.Parse("127.0.0.1"), partnerport));
                axMSComm1.Output = data;//发送数据
                //

                try
                {
                    Thread.Sleep(1000);//等待2秒 如果没有收到接收帧则 自动唤醒

                }
                catch { }
            }


        }

        private void button2_Click(object sender, EventArgs e)//发送按钮
        {
            count = 0;
            state = "发送";
            Message();
            if (axMSComm1.PortOpen)
                axMSComm1.PortOpen = false;
            axMSComm1.RThreshold = (short)4;//接收超过4个字节时就触发comm方法，因为当前状态是 发送 它只会收到却确认桢，确认桢大小为5
            
            axMSComm1.PortOpen = true;
           
            axMSComm1.InBufferCount = 0;
            thread = new Thread(send);
            isfinished = false;
            thread.Start();
            button4.Enabled = false;
           
            databack=new byte[senddata.Length];
            Array.Copy(senddata,0,databack,0,databack.Length);
        }

        private void button3_Click(object sender, EventArgs e)//保存按钮
        {
            if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;

            savedPath = saveFileDialog1.FileName;
            FileInfo fi = new FileInfo(savedPath);
            FileStream fs = fi.Open(FileMode.OpenOrCreate, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);

            bw.Write(persistdata, 0, persistdata.Length);
            receivedata = null;
            fs.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                thread.Abort();//线程销毁
            }
            catch { }
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            count = 0;
            state = "接收";
            receivedata = null;
            button2.Enabled = false;
            Message();
            if (axMSComm1.PortOpen)
                axMSComm1.PortOpen = false;
            axMSComm1.RThreshold = (short)(length + 8);//接收超过length + 8个字节时就触发comm方法，因为当前状态是 发送 它不会收到却确认桢，确认桢大小为5
            
            axMSComm1.PortOpen = true;
            axMSComm1.InBufferCount = 0;
        }


    }
}
