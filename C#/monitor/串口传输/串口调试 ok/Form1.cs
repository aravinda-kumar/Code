using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.IO;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;


namespace 串口调试
{
    public partial class Form1 : Form
    {
        //SerialPort sp1 = new SerialPort();//声明一个串口类
        bool isOpen = false;//打开串口标志位
        bool isSetProperty = false;//属性设置标志位             
        string filename = "";
        int HeadCount=0;
        int ReceiveState=0;
        Color color;//显示一个点的颜色
        int PointColor=0;//用来计算各分量的值存入四个字节
        byte[] head=new byte[54];
        int width=0;
        int height=0;
        int column = 0;
        int row = 0;
        Bitmap originPicture = null;
        byte[] RecvDataBuf = new byte[132];   //接收数据数组
        byte[] SendDataBuf = new byte[132];   //发送数据数组
        byte SOH = 0x01;
        byte PacketNo = 0x01;     //包号      
        byte EOT = 0x04;          //正文结束
        byte ACK = 0x06;          //肯定
        byte NAK = 0x15;          //否定
        byte CAN = 0x18;          //无条件取消传输
        byte CtrlZ = 0x1A;
       
        byte parity;
        public Form1()
        {
            
            //sp1.DataReceived += new SerialDataReceivedEventHandler(sp1_DataReceived);
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            this.MaximizeBox = false;

            for (int i = 1; i <= 10; i++) //假设最大支持到串口10
            {
                cbxCOMPort.Items.Add("COM" + i);
            }
            cbxCOMPort.SelectedIndex = 0;//设当前指点选项的索引值为0

            //列出常用波特率
            cbxBaudRate.Items.Add("1200");
            cbxBaudRate.Items.Add("2400");
            cbxBaudRate.Items.Add("4800");
            cbxBaudRate.Items.Add("9600");
            cbxBaudRate.Items.Add("19200");
            cbxBaudRate.Items.Add("38400");
            cbxBaudRate.Items.Add("43000");
            cbxBaudRate.Items.Add("56000");
            cbxBaudRate.Items.Add("57600");
            cbxBaudRate.Items.Add("115200");
            cbxBaudRate.SelectedIndex = 3;

            //列出停止位
            //cbxStopBits.Items.Add("0");
            cbxStopBits.Items.Add("1");
            cbxStopBits.Items.Add("1.5");
            cbxStopBits.Items.Add("2");
            cbxStopBits.SelectedIndex = 0;

            //列出奇偶校验位
            cbxParity.Items.Add("无");
            cbxParity.Items.Add("奇校验");
            cbxParity.Items.Add("偶校验");
            cbxParity.SelectedIndex = 0;

            //列出数据位
            cbxDataBits.Items.Add("8");
            cbxDataBits.Items.Add("7");
            cbxDataBits.Items.Add("6");
            cbxDataBits.Items.Add("5");
            cbxDataBits.SelectedIndex = 0;

            //默认为char显示
            rbnChar.Checked = true;

        }

        private void btnCheckCOM_Click(object sender, EventArgs e)
        {
            bool comExistence = false;//有可用串口标志位
            cbxCOMPort.Items.Clear();//清楚当前串口号中的所有串口名称
            for (int i = 1; i <= 10; i++)
            {
                try
                {
                    //SerialPort sp= new SerialPort("COM" + i); //实例化端口
                    sp1 = new SerialPort("COM" + i);
                    sp1.Open();
                    sp1.Close();
                    cbxCOMPort.Items.Add("COM" + i);
                    comExistence = true;
                }
                catch
                {
                    continue;
                }

            }
            if (comExistence)
            {
                cbxCOMPort.SelectedIndex = 0; //显示第一个添加的索引
            }
            else
            {
                MessageBox.Show("没有找到可用串口！", "错误提示");//“错误提示”显示在标题栏，“没找到串口”为显示文本
            }
        }

        //检查串口是否设置
        private bool CheckPortSetting()
        {
            if (cbxCOMPort.Text.Trim() == "") return false;
            if (cbxBaudRate.Text.Trim() == "") return false;
            if (cbxDataBits.Text.Trim() == "") return false;
            if (cbxParity.Text.Trim() == "") return false;
            if (cbxDataBits.Text.Trim() == "") return false;
            else return true;
        }

        private bool CheckSendData()
        {
            if (!rbnPic.Checked)
            {
                if (tbxSendData.Text.Trim() == "") return false;
                else return true;
            }
            else
            {
                if (pbxSendImg.Image == null) return false;
                else return true;
            }
        }

        //设置串口的属性
        private void SetPortProperty()
        {
            sp1.PortName = cbxCOMPort.Text.Trim();  //设置串口名

            sp1.BaudRate = Convert.ToInt32(cbxBaudRate.Text.Trim());//设置串口的波特率

            float f = Convert.ToSingle(cbxStopBits.Text.Trim());//将数字的制定字符串表示形式转换为等效的单精度浮点数
            if (f == 0)
            {
                sp1.StopBits = StopBits.None;
            }
            else if (f == 1.5)
            {
                sp1.StopBits = StopBits.OnePointFive;
            }
            else if (f == 2)
            {
                sp1.StopBits = StopBits.Two;

            }
            else
            {
                sp1.StopBits = StopBits.One;
            }

            sp1.DataBits = Convert.ToInt16(cbxDataBits.Text.Trim());//设置数据位

            string s = cbxParity.Text.Trim(); //设置奇偶校验位
            if (s.CompareTo("无") == 0) //与字符串是否在同一位置，在前面，还是在后面
            {
                sp1.Parity = Parity.None;
            }
            else if (s.CompareTo("奇校验") == 0)
            {
                sp1.Parity = Parity.Odd;
            }
            else if (s.CompareTo("偶校验") == 0)
            {
                sp1.Parity = Parity.Even;
            }
            else
            {
                sp1.Parity = Parity.None;
            }

            sp1.ReadTimeout = -1;//设置超时读取时间

            sp1.RtsEnable = true;//该值指示在串行通信中是否启用请求发送（RTS）信号

            //定义DataReceived事件，当串口收到数据后触发事件

        }

        //定义DataReceived事件，当串口收到数据后触发事件


        //sp1.DataReceived += new SerialDataReceivedEventHandler(sp1_DataReceived);//将其放在页面刷新之后
        public void sp1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            //sp1.DataReceived += new SerialDataReceivedEventHandler(sp1_DataReceived);//将其放在页面刷新之后
            //this.Invoke是跨线程访问ui的方法
            this.Invoke((EventHandler)(delegate
            {
                sp1.DataReceived += new SerialDataReceivedEventHandler(sp1_DataReceived);//将其放在页面刷新之后
                try
                {
                    byte[] ReceiveData = new byte[132]; //创建字节数组
                    sp1.Read(ReceiveData, 0, ReceiveData.Length); //读取所接收到的数据
                    int sum = 0;
                    if (ReceiveData[1] + ReceiveData[2] == 0xff)
                    {
                        for (int i = 3; i < 131; i++)
                        {
                            if (ReceiveData[0] == SOH)
                            {
                                sum += ReceiveData[i];
                            }
                            else  //EOT
                            {
                                if (ReceiveData[i] == CtrlZ)
                                {
                                    ReceiveData[i] = 0x00;
                                }
                                sum += ReceiveData[i];
                            }
                        }
                        parity = (byte)(sum % 256);
                        if (parity == ReceiveData[131])
                        {
                            sp1.Write("ACK");
                            Show(ReceiveData);
                        }
                        else
                        {
                            sp1.Write("NAK");
                        }
                    }
                    else if (ReceiveData[1] + ReceiveData[2] != 0xff)
                    {
                        sp1.Write("NAK");
                    }
                }
                catch
                {
                    sp1.Write("CAN");
                }
                sp1.DiscardInBuffer();//丢弃接收缓冲区的数据
            }));
        }

        public void Show(byte[] ReceiveData)
        {
            if (rbnChar.Checked)
            {
                for (int i = 3; i < 131; i++)
                {
                    tbxRecvData.Text += ReceiveData[i];
                }
            }
            else if (rbnHex.Checked)
            {
                //Byte[] ReceiveData = new Byte[sp1.BytesToRead];
                //sp1.Read(ReceiveData, 0, ReceiveData.Length); 
                string RecvDataText = null;
                for (int i = 3; i < 131; i++)
                {
                    RecvDataText += ("0x" + ReceiveData[i].ToString("X2") + " ");//X为十六进制 2为每次都是两位数 这样看着整齐
                }
                tbxRecvData.Text += RecvDataText;

            }
            else
            {
                //byte[] RecvBmData = new byte[sp1.BytesToRead];//创建字节数组
                //sp1.Read(RecvBmData, 0, RecvBmData.Length);//读取所接收到的数据
                for (int i = 3; i < 131; i++)
                {
                    byte data = ReceiveData[i];
                    if (HeadCount < 57)
                    {
                        head[HeadCount] = data;
                    }
                    HeadCount += 1;
                    if (HeadCount == 57)
                    {
                        width = getWidth(head);
                        height = getHeight(head);
                        column = height - 1;
                        originPicture = new Bitmap(width, height);
                    }
                    if (HeadCount > 57)
                    {
                        if (ReceiveState == 0)
                        {
                            PointColor = 0xff << 24;//全不透明
                            PointColor += data;//B
                            ReceiveState++;
                        }
                        else if (ReceiveState == 1)
                        {
                            PointColor += data << 8;//G
                            ReceiveState++;
                        }
                        else if (ReceiveState == 2)
                        {
                            PointColor += data << 16;//R
                            color = Color.FromArgb(PointColor);
                            //originPicture.SetPixel(height - 1, 0, color);//三个字节一个像素点
                            originPicture.SetPixel(row, column, color);
                            ReceiveState = 0;
                            PointColor = 0;//ARGB归零
                            row += 1;
                            if (row == width)
                            {
                                row = 0;
                                column--;
                            }
                            if (column == -1)//图片接收完成
                            {
                                this.Invoke((EventHandler)delegate { this.pbxRecvImg.Image = (Bitmap)originPicture.Clone(); });
                                break;
                            }
                        }
                    }
                }
            }
        }
           public int getWidth(byte[] buffer)
           {
                byte[] aWide=buffer.Skip(21).Take(4).ToArray();
                width =(int) ((aWide[3] << 24) + (aWide[2] << 16) + (aWide[1] << 8) + (aWide[0]));
                return width;
           }
           public int getHeight(byte[] buffer)
           {
                byte[] aHeight=buffer.Skip(25).Take(4).ToArray();
                height = (int)((aHeight[3] << 24) + (aHeight[2] << 16) + (aHeight[1] << 8) + (aHeight[0]));
                return height;
           }
        
        private void btnSend_Click(object sender, EventArgs e)
        {
            //写串口数据
            if (isOpen)
            {
                try
                {
                        sp1.WriteLine(tbxSendData.Text);
                                  
                }
                catch
                {
                    MessageBox.Show("发送数据时发生错误！", "错误提示");
                    return;
                }
            }

            else
            {
                MessageBox.Show("串口未打开！", "错误提示");
                return;
            }


            //检测要发送的数据
            if (!CheckSendData())
            {
                MessageBox.Show("请输入要发送的数据！", "错误提示");
                return;
            }
        }

       
        private void btnOpenCOM_Click(object sender, EventArgs e)
        {
            if (isOpen == false)
            {
                if (!CheckPortSetting())
                {
                    MessageBox.Show("串口未设置！", "错误提示");
                    return;
                }
                if (!isSetProperty)//串口未设置则设置串口
                {
                    SetPortProperty();
                    isSetProperty = true;
                }
                try//打开串口
                {
                    sp1.Open();
                    isOpen = true;
                    btnOpenCOM.Text = "关闭串口";
                    //串口打开后则相关的串口设置按钮便不可再用
                    cbxCOMPort.Enabled = false;
                    cbxBaudRate.Enabled = false;
                    cbxDataBits.Enabled = false;
                    cbxParity.Enabled = false;
                    cbxStopBits.Enabled = false;
                    rbnChar.Enabled = false;
                    rbnHex.Enabled = false;
                }
                catch
                {
                    //打开串口失败后，相应标志位取消
                    isSetProperty = false;
                    isOpen = false;
                    MessageBox.Show("串口无效或已被占用！", "错误提示");
                }
            }

            else
            {
                try //打开串口
                {
                    sp1.Close();
                    isOpen = false;
                    isSetProperty = false;
                    btnOpenCOM.Text = "打开串口";
                    //关闭串口后，串口设置选项便可以继续使用
                    cbxCOMPort.Enabled = true;
                    cbxBaudRate.Enabled = true;
                    cbxDataBits.Enabled = true;
                    cbxParity.Enabled = true;
                    cbxStopBits.Enabled = true;
                    rbnChar.Enabled = true;
                    rbnHex.Enabled = true;
                }
                catch
                {
                    MessageBox.Show("关闭串口时发生错误！", "错误提示");
                }
            }

        }

        private void btnCleanData_Click(object sender, EventArgs e)
        {
            tbxRecvData.Text = "";
            tbxSendData.Text = "";
            tbxSendData.Focus();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void btnSendPic_Click(object sender, EventArgs e)
        {
            //写串口数据
            if (isOpen)
            {
                try
                {
                    //设置打开文件类型
                    openFileDialog1.Filter = "BMP格式图片文件|*bmp";
                    //获取文件路径
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        //获得文件路径文件名
                        filename = openFileDialog1.FileName;
                        pbxSendImg.Image = Image.FromFile(filename);
                        Bitmap bmp = (Bitmap)pbxSendImg.Image;
                        MemoryStream ms = new MemoryStream();
                        bmp.Save(ms, ImageFormat.Bmp);
                        byte[] buffer = new byte[ms.Length];
                        ms.Seek(0, SeekOrigin.Begin);
                        ms.Read(buffer, 0, buffer.Length);
                        //sp1.Write(buffer, 0, buffer.Length);
                        SendDataBuf[0] = SOH;
                        SendDataBuf[1] = PacketNo;
                        SendDataBuf[2] = (byte)(0xff - PacketNo);
                        int sum = 0;
                        for (int i = 0; i < 128; i++)
                        {                             
                            SendDataBuf[i + 3] = buffer[i];
                            sum += SendDataBuf[i + 3];                   
                        }
                        parity = (byte)(sum % 256);
                        SendDataBuf[131] = parity;
                        sp1.Write(SendDataBuf, 0, 131);

                        Thread.Sleep(100);
                        if (sp1.ReadByte() == ACK)
                        {
                         if (buffer.Length - 128 * PacketNo > 128)
                         {
                            for (int i = 128; i < buffer.Length; i += 128)
                            {
                                sum = 0;
                                PacketNo += 1;
                                SendDataBuf[0] = SOH;
                                SendDataBuf[1] = PacketNo;
                                SendDataBuf[2] = (byte)(0xff - PacketNo);

                                for (int j = 0; j < 128; j++)
                                {
                                    SendDataBuf[j + 3] = buffer[i + j];
                                    sum += SendDataBuf[j + 3];
                                }
                                parity = (byte)(sum % 256);
                                SendDataBuf[131] = parity;
                                sp1.Write(SendDataBuf, 0, 131);
                            }
                          }
                         else
                        {
                            sum = 0;
                            SendDataBuf[0] = EOT;
                            PacketNo += 1;
                            SendDataBuf[1] = PacketNo;
                            SendDataBuf[2] = (byte)(0xff - PacketNo);
                            for (int j = 0; j < buffer.Length-128*(PacketNo-1); j++)
                            {
                                SendDataBuf[j + 3] = buffer[128*(PacketNo-1)+j];
                                sum += SendDataBuf[j + 3];
                            }
                            parity = (byte)(sum % 256);
                            for (int j = buffer.Length; j <128*PacketNo ; j++)
                            {
                                SendDataBuf[j] = CtrlZ;
                            }
                            SendDataBuf[131] = parity;
                            sp1.Write(SendDataBuf, 0, 131);
                        }

                      }    
                                if (sp1.ReadByte() == NAK)
                                {
                                    sp1.Write(SendDataBuf, 0, 131);
                                }
                                if (sp1.ReadByte() == CAN)
                                {
                                    return;
                                }
                                else
                                {
                                    sp1.Write(SendDataBuf, 0, 131);
                                }
                          }
                      
                      }
                

                catch
                {
                    MessageBox.Show("发送数据时发生错误！", "错误提示");
                    return;
                }
            }

            else
            {
                MessageBox.Show("串口未打开！", "错误提示");
                return;
            }

            //检测要发送的数据
            if (!CheckSendData())
            {
                MessageBox.Show("请输入要发送的数据！", "错误提示");
                return;
            }
        }

        private void btnClearPic_Click(object sender, EventArgs e)
        {
            pbxSendImg.Image = null;
            pbxRecvImg.Image = null;
            HeadCount = 0;
            //pbxSendImg.Focus();
        }   

    }
}
