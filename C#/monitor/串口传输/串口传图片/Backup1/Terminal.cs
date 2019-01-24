/* 
 * Project:    SerialPort Terminal
 * Company:    Coad .NET, http://coad.net
 * Author:     Noah Coad, http://coad.net/noah
 * Created:    March 2005
 * 
 * Notes:      This was created to demonstrate how to use the SerialPort control for
 *             communicating with your PC's Serial RS-232 COM Port
 * 
 *             It is for educational purposes only and not sanctified for industrial use. :)
 * 
 *             Search for "comport" to see how I'm using the SerialPort control.
 */

#region Namespace Inclusions
using System;
using System.Data;
using System.Text;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections.Generic;

using SerialPortTerminal.Properties;
using System.IO;
#endregion

namespace SerialPortTerminal
{
  #region Public Enumerations
  public enum DataMode { Text, Hex }
  public enum LogMsgType { Incoming, Outgoing, Normal, Warning, Error };
  #endregion

  public partial class frmTerminal : Form
  {
    #region Local Variables

      private int pageNum = 0;
      private byte[] sendbuffer = new byte[256];
      private byte[] picByte;//存放图片的buffer
      private int FrameNum;//图片数据分解成的帧数目
      private int yushu;//最后一帧数据的字节数
      //private byte[] sendendbuffer;
      private byte[] receiveBuffer;
      private int receiveNum = 0;//接收到数据帧的个数

      private byte[] ReBuffer = new byte[512];//接收缓存
      private List<byte> receivebuffer = new List<byte>();
      bool FrameStart = true;

      private int length = 0;

      private int receivebytes;
      private string picPath;
      private int delay;

      private byte[] testSend = new byte[256];
      int startMin ;
      int startSec ;
      int startMillSec ;

      System.Timers.Timer myTimer = new System.Timers.Timer();
      //Timer myTimer = new Timer();

    // The main control for communicating through the RS-232 port
    private SerialPort comport = new SerialPort();

    // Various colors for logging info
    private Color[] LogMsgTypeColor = { Color.Blue, Color.Green, Color.Black, Color.Orange, Color.Red };

    // Temp holder for whether a key was pressed
    private bool KeyHandled = false;
    
    #endregion

    #region Constructor
    public frmTerminal()
    {
      // Build the form
      InitializeComponent();

      // Restore the users settings
      InitializeControlValues();

      // Enable/disable controls based on the current state
      EnableControls();

      myTimer.Elapsed += new System.Timers.ElapsedEventHandler(myTimer_Elapsed);
      myTimer.Interval = 2000; //定时10s
      myTimer.AutoReset = true;
      myTimer.Enabled = false;
      myTimer.Stop();
      // When data is recieved through the port, call this method
      comport.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);
    }
    #endregion

    #region Local Methods
    
    /// <summary> Save the user's settings. </summary>
  /*  private void SaveSettings()
    {
      Settings.Default.BaudRate = int.Parse(cmbBaudRate.Text);
      Settings.Default.DataBits = int.Parse(cmbDataBits.Text);
      Settings.Default.DataMode = CurrentDataMode;
      Settings.Default.Parity = (Parity)Enum.Parse(typeof(Parity), cmbParity.Text);
      Settings.Default.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cmbStopBits.Text);
      Settings.Default.PortName = cmbPortName.Text;

      Settings.Default.Save();
    }*/

    /// <summary> Populate the form's controls with default settings. </summary>
    private void InitializeControlValues()
    {
      //cmbParity.Items.Clear(); 
        //cmbParity.Items.AddRange(Enum.GetNames(typeof(Parity)));
      //cmbStopBits.Items.Clear(); cmbStopBits.Items.AddRange(Enum.GetNames(typeof(StopBits)));

      //cmbParity.Text = Settings.Default.Parity.ToString();
      //cmbStopBits.Text = Settings.Default.StopBits.ToString();
      //cmbDataBits.Text = Settings.Default.DataBits.ToString();
      //cmbParity.Text = Settings.Default.Parity.ToString();
      cmbBaudRate.Text = Settings.Default.BaudRate.ToString();
      //CurrentDataMode = Settings.Default.DataMode;

      cmbPortName.Items.Clear();
      foreach (string s in SerialPort.GetPortNames())
        cmbPortName.Items.Add(s);

      if (cmbPortName.Items.Contains(Settings.Default.PortName)) cmbPortName.Text = Settings.Default.PortName;
      else if (cmbPortName.Items.Count > 0) cmbPortName.SelectedIndex = 0;
      else
      {
        MessageBox.Show(this, "There are no COM Ports detected on this computer.\nPlease install a COM Port and restart this app.", "No COM Ports Installed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        this.Close();
      }
    }

    /// <summary> Enable/disable controls based on the app's current state. </summary>
    private void EnableControls()
    {
      // Enable/disable controls based on whether the port is open or not
      gbPortSettings.Enabled = !comport.IsOpen;
      groupBox1.Enabled = comport.IsOpen;
       btnSend.Enabled = comport.IsOpen  ;

      // btnSend.Enabled = true;
      if (comport.IsOpen) btnOpenPort.Text = "&关闭串口";
      else btnOpenPort.Text = "&打开串口";
    }

    /// <summary> Send the user's data currently entered in the 'send' box.</summary>
    private void SendData(byte[] data)
    {
      try
        {
          // Send the binary data out the port
          comport.Write(data, 0, data.Length);
          Log(LogMsgType.Error, ByteArrayToHexString(data) + "\n");
        }
        catch (FormatException)
        {

        }
      }
      
    /// <summary> Log data to the terminal window. </summary>
    /// <param name="msgtype"> The type of message to be written. </param>
    /// <param name="msg"> The string containing the message to be shown. </param>
    private void Log(LogMsgType msgtype, string msg)
    {
      rtfTerminal.Invoke(new EventHandler(delegate
      {
        rtfTerminal.SelectedText = string.Empty;
        rtfTerminal.SelectionFont = new Font(rtfTerminal.SelectionFont, FontStyle.Bold);
        rtfTerminal.SelectionColor = LogMsgTypeColor[(int)msgtype];
        rtfTerminal.AppendText(msg);
        rtfTerminal.ScrollToCaret();
      }));
    }
      

    /// <summary> Convert a string of hex digits (ex: E4 CA B2) to a byte array. </summary>
    /// <param name="s"> The string containing the hex digits (with or without spaces). </param>
    /// <returns> Returns an array of bytes. </returns>
    private byte[] HexStringToByteArray(string s)
    {
      s = s.Replace(" ", "");
      byte[] buffer = new byte[s.Length / 2];
      for (int i = 0; i < s.Length; i += 2)
        buffer[i / 2] = (byte)Convert.ToByte(s.Substring(i, 2), 16);
      return buffer;
    }

    /// <summary> Converts an array of bytes into a formatted string of hex digits (ex: E4 CA B2)</summary>
    /// <param name="data"> The array of bytes to be translated into a string of hex digits. </param>
    /// <returns> Returns a well formatted string of hex digits with spacing. </returns>
    private string ByteArrayToHexString(byte[] data)
    {
      StringBuilder sb = new StringBuilder(data.Length * 3);
      foreach (byte b in data)
        sb.Append(Convert.ToString(b, 16).PadLeft(2, '0').PadRight(3, ' '));
      return sb.ToString().ToUpper();
    }
    #endregion

    #region Local Properties


    #region Event Handlers
    
    
    private void frmTerminal_Shown(object sender, EventArgs e)
    {
      //Log(LogMsgType.Normal, String.Format("Application Started at {0}\n", DateTime.Now));
    }
    private void frmTerminal_FormClosing(object sender, FormClosingEventArgs e)
    {

    }

    private void btnOpenPort_Click(object sender, EventArgs e)
    {
        if (!comport.IsOpen)
        {
            comport.BaudRate = int.Parse(cmbBaudRate.Text);
            comport.PortName = cmbPortName.Text;
            comport.Open();

            //timer1.Interval = Convert.ToInt32(textBox1.Text);

        }
        else
        {
            comport.Close();
            progressBar1.Value = 0;
        }

        EnableControls();
         
    }
    private void showReceivePic()
    {
        myTimer.Stop();
        pictureBox2.Image = null;

        int N = receivebuffer.Count;
        byte[] re = new byte[N];
        int i = 0;
        foreach (byte o in receivebuffer)
        {
            re[i] = o;
            i++;
        }
        i = 0;
        while (re[i] == 0xee)
        {
            i++;
        }
        int startNum = i;//收到的0xee的个数

        byte[] realNum = new byte[4];
        realNum[0] = re[i + 6];
        realNum[1] = re[i + 5];
        realNum[2] = re[i + 4];
        realNum[3] = re[i + 3];
        byte[] realYushu = new byte[4];
        realYushu[0] = re[i + 10];
        realYushu[1] = re[i + 9];
        realYushu[2] = re[i + 8];
        realYushu[3] = re[i + 7];

        int realByteNum = 256 * BitConverter.ToInt32(realNum,0) + BitConverter.ToInt32(realYushu,0);
        byte[] realByte = new byte[realByteNum-20];//真正的数据字节数

        for (i = 0; i < realByteNum-20; i++)
            realByte[i] = re[i + 12 + startNum];

        //Log(LogMsgType.Error, ByteArrayToHexString(re));   
        MemoryStream ms = new MemoryStream(realByte);
        ms.Position = 0;
        pictureBox2.Image = Image.FromStream(ms);
        //ms.Dispose();
        ms.Close();

        receivebuffer.Clear();

    }

      private void getTime()
      {
          int stopMin = DateTime.Now.Minute;
          int stopSec = DateTime.Now.Second;
          int stopMillSec = DateTime.Now.Millisecond;

          //textBox7.Text = stopMin.ToString() + "分" + stopSec.ToString() + "秒" + stopMillSec.ToString() + "毫秒";
          int min, sec, millsec;
          
          if (stopMillSec < startMillSec)
          {
              if (stopSec == 0)
              {
                  stopMin--;
                  stopSec = 59;
                  millsec = 1000 + stopMillSec - startMillSec;
                  sec = stopSec - startSec;
                  min = stopMin - startMin;

                  textBox3.Text = min.ToString() + "分" + sec.ToString() + "秒" + millsec.ToString() + "毫秒";
              }
              else
              {
                  stopSec--;
                  millsec = 1000 + stopMillSec - startMillSec;
                  if (stopSec < startSec)
                  {
                      stopMin--;
                      sec = 60 + stopSec - startSec;
                      min = stopMin - startMin;
                      textBox3.Text = min.ToString() + "分" + sec.ToString() + "秒" + millsec.ToString() + "毫秒";
                  }
                  else
                  {
                      sec = stopSec - startSec;
                      min = stopMin - startMin;
                      textBox3.Text = min.ToString() + "分" + sec.ToString() + "秒" + millsec.ToString() + "毫秒";
                  }
              }
          }
          else
          {
              millsec = stopMillSec - startMillSec;
              if (stopSec < startSec)
              {
                  stopMin--;
                  sec = 60 + stopSec - startSec;
                  min = stopMin - startMin;
                  textBox3.Text = min.ToString() + "分" + sec.ToString() + "秒" + millsec.ToString() + "毫秒";
              }
              else
              {
                  sec = stopSec - startSec;
                  min = stopMin - startMin;
                  textBox3.Text = min.ToString() + "分" + sec.ToString() + "秒" + millsec.ToString() + "毫秒";
              }
          }
      
      }

    private void btnSend_Click(object sender, EventArgs e)
    {
        rtfTerminal.Text = "";
        int N=38;
        delay = Convert.ToInt32(textBox1.Text);

        while (N != 0)
        {
            textBox4.Text = N.ToString();//显示帧数目
            SendData(testSend);
            N--;
            wait(delay);
        }
        /*
        delay = Convert.ToInt32(textBox1.Text);

        int PicLength;
        picByte = System.IO.File.ReadAllBytes(@picPath);
        PicLength = picByte.Length + 20; //发送数据的总长度

        if (PicLength % 256 == 0)
        {
            yushu = 0;
            FrameNum = PicLength / 256;
        }
        else
        {
            FrameNum = PicLength / 256;
            yushu = PicLength % 256;
        }
        textBox4.Text = FrameNum.ToString();//显示帧数目
        textBox5.Text = (PicLength-20).ToString();//显示发送图片的字节数

        byte[] geshu = new byte[4];
        geshu = BitConverter.GetBytes(FrameNum);

        //textBox4.Text = ByteArrayToHexString(geshu);//显示帧数目
        byte[] sendyushu = new byte[4];
        sendyushu = BitConverter.GetBytes(yushu);
        //start[yushu + 5] = sendyushu[3];
        //start[yushu + 6] = sendyushu[2];
        //start[yushu + 7] = sendyushu[1];
        //start[yushu + 8] = sendyushu[0];
        //准备发送数组
        List<byte> s1 = new List<byte>();
        int i=0;
        for(i=0;i<8;i++)//帧头
            s1.Add(0xee);
        s1.Add(0xc0);
        s1.Add(0xff);
        s1.Add(0x08);

        s1.Add(geshu[3]);
        s1.Add(geshu[2]);
        s1.Add(geshu[1]);
        s1.Add(geshu[0]);

        s1.Add(sendyushu[3]);
        s1.Add(sendyushu[2]);
        s1.Add(sendyushu[1]);
        s1.Add(sendyushu[0]);

        s1.Add(0xc1);

        for (int m = 0; m < PicLength-20; m++)
            s1.Add(picByte[m]);

        int frameLength = s1.Count;
        byte[] senddata = new byte[frameLength];
        int n = 0;
        foreach (byte o in s1)
        {
            senddata[n] = o;
            n++;
        }


        startMin = DateTime.Now.Minute;
        startSec = DateTime.Now.Second;
        startMillSec = DateTime.Now.Millisecond;
        //textBox6.Text = startMin.ToString() + "分" + startSec.ToString() + "秒" + startMillSec.ToString() + "毫秒";
        bool send = true;
        while (send)
        {
            if (pageNum < FrameNum)
            {
                for (i = 256 * pageNum; i < 256 * pageNum + 256; i++)
                    sendbuffer[i - 256 * pageNum] = senddata[i];
                byte[] send1 = new byte[32];
                for (i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 32; j++)
                        send1[j] = sendbuffer[32 * i + j];

                    SendData(send1);
                    //Log(LogMsgType.Error, ByteArrayToHexString(send1) + "\n");
                    wait(2);
                }

                //Log(LogMsgType.Error, ByteArrayToHexString(sendbuffer)+"\n");

                progressBar1.Value = pageNum * 100 / FrameNum;
                wait(delay);
            }
            if (pageNum == FrameNum)
            {
                if (yushu != 0)
                {
                    byte[] sendendbuffer = new byte[256];

                    for (int j = 256 * pageNum; j < 256 * pageNum + yushu; j++)
                        sendendbuffer[j - 256 * pageNum] = senddata[j];



                    for (int k = yushu; k < 256; k++)
                        sendendbuffer[ k ] = 0xaa;

                    byte[] send2 = new byte[32];
                    for (i = 0; i < 8; i++)
                    {
                        for (int j = 0; j < 32; j++)
                            send2[j] = sendendbuffer[32 * i + j];

                        SendData(send2);
                        //Log(LogMsgType.Error, ByteArrayToHexString(send2) + "\n");
                        wait(2);
                    }
                    //SendData(sendendbuffer);
                    //Log(LogMsgType.Error, ByteArrayToHexString(sendendbuffer)+"\n");
                    progressBar1.Value = 100;

                    getTime();
                    send = false;
  
                    pageNum = -1;
                }
            }
            pageNum++;
        }//while
        // progressBar1.Value = 0;
         * 
         * 
        /*
        byte[] start = new byte[15];
        start[0] = 0xc2;
        start[1] = 0xaa;
        start[2] = 0x0c;
        start[3] = 0x08;

        byte[] geshu = new byte[4];
        geshu = BitConverter.GetBytes(FrameNum);
        start[4] = geshu[3];
        start[5] = geshu[2];
        start[6] = geshu[1];
        start[7] = geshu[0];

        byte[] sendyushu = new byte[4];
        sendyushu = BitConverter.GetBytes(yushu);
        start[8] = sendyushu[3];
        start[9] = sendyushu[2];
        start[10] = sendyushu[1];
        start[11] = sendyushu[0];

        start[12] = 0xc3;
        start[13] = 0xc3;
        start[14] = 0xc3;
        */
        //SendData(start);
       // progressBar1.Value = 0;

        //timer1.Start();

        /*/pictureBox1.Image.Save(@"f:\pic.jpg");

        //picByte = ChangePic();

        if(picByte.Length!=0)
            textBox1.Text=picByte.Length.ToString();


        MemoryStream ms = new MemoryStream(picByte);
        ms.Position = 0;
        pictureBox2.Image = Image.FromStream(ms);
        ms.Close();*/
        //SendData(picByte); 
        //textBox1.Text = this.pictureBox1.Image.Size.ToString();

    }

    public void wait(int s)
    {
        int s1 = 1000;
        int s2 = s * s1;
        for (int i = 0; i < s2; i++)
        {
            for (int j = 0; j < s2; j++)
            {

            }
        }
    }
      /*
    private void checkReceive(byte[] data)
    {
        byte[] reBuffer=new byte[256];

        if (data.Length == 256)
        {
            for (int i = 0; i < 256; i++)
            {
                receiveBuffer[i + receiveNum * 256] = data[i];
            }
            receiveNum++;
        }
        else
        {
            int N = data.Length;
            for (int j = 0; j < N; j++)
                receiveBuffer[j + receiveNum * 256] = data[i];

            MemoryStream ms = new MemoryStream(receiveBuffer);
            ms.Position = 0;
            pictureBox2.Image = Image.FromStream(ms);
            ms.Close();
        }
    }
      */
    public void SaveToBuffer(int start, int Length, byte[] data)
    {
        for (int i = 0; i < Length; i++)
            ReBuffer[start + i] = data[i];
    }

    private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
    {

          myTimer.Stop();

          int bytes = comport.BytesToRead;

          byte[] buffer = new byte[bytes];
          
          comport.Read(buffer, 0, bytes);

          receivebytes = bytes;

          
          //Log(LogMsgType.Error, ByteArrayToHexString(buffer));

          for (int i = 0; i < bytes; i++)
              receivebuffer.Add(buffer[i]);
          myTimer.Start();

/*          try
          {
              if (bytes < 256)
              {
                  SaveToBuffer(length, bytes, buffer);
                  length += bytes;
              }
              else
              {
                  checkReceive(buffer);
                  length = 0;
              }

              if (length == 256)
              {
                  checkReceive(ReBuffer);
                  length = 0;
              }
          }
          catch
          {

          }
      try
      {
          if (FrameStart)
          {
              L = bytes;
              SaveToBuffer(0, L, buffer);

              int i = 0;
              while (ReBuffer[i] != 0xC2)
                  i++;
              L1 = i;
              if ((L - L1) > 6)
              {
                  DataLength = ReBuffer[L1 + 3];
                  if ((byte)(DataLength + 7) > (byte)(L - L1))
                      FrameStart = false;
                  else if (DataLength == (byte)(L - L1 - 7))
                  {
                      //timer1.Stop();
                      getLenhth(buffer);
                      FrameStart = false;
                  }
                  else
                      Log(LogMsgType.Outgoing, "读取帧数据出错1！" + "\n");
              }
              else
                  FrameStart = false;
          }
          else
          {
              L2 = bytes;
              SaveToBuffer(L, L2, buffer);
              L = L + L2;
              if ((L - L1) > 6)
              {
                  DataLength = ReBuffer[L1 + 3];
                  if (DataLength == (byte)(L - L1 - 7))
                  {
                      byte[] sendbuffer = new byte[7 + DataLength];
                      for (int i = 0; i < (7 + DataLength); i++)
                          sendbuffer[i] = ReBuffer[i];
                      //timer1.Stop();
                      CheckCmd(sendbuffer);
                      FrameStart = false;
                  }
              }
          }
      }
      catch
      {
      }
 */
    }

    private void txtSendData_KeyDown(object sender, KeyEventArgs e)
    { 
      // If the user presses [ENTER], send the data now
      //if (KeyHandled = e.KeyCode == Keys.Enter) { e.Handled = true; SendData(); } 
    }
    private void txtSendData_KeyPress(object sender, KeyPressEventArgs e)
    { e.Handled = KeyHandled; }
    #endregion

      private void button_head_Click(object sender, EventArgs e)
      {
         
         
      }

      private void button1_left_Click(object sender, EventArgs e)
      {
       
      }

      private void button_stop_Click(object sender, EventArgs e)
      {
         
      }

      private void button_right_Click(object sender, EventArgs e)
      {
          
      }

      private void button_back_Click(object sender, EventArgs e)
      {
          
      }

      private void button1_Click(object sender, EventArgs e)
      {
      
      }

      private void frmTerminal_Load(object sender, EventArgs e)
      {
          for (int i = 0; i < 256; i++)
              testSend[i] = (byte)(i);

          
          
          
          //mytimer.Interval = 5000;
          //mytimer.Enabled = false;
          
          //pictureBox1.Image = Image.FromFile(@"G:\C#自学例程\串口传图片\海边.jpg");
      }

      private void button1_Click_1(object sender, EventArgs e)
      {
          openFileDialog1.ShowDialog();
          textBox2.Text = openFileDialog1.FileName;
          picPath = openFileDialog1.FileName;
          pictureBox1.Image = Image.FromFile(@textBox2.Text);
      }

      private void textBox2_TextChanged(object sender, EventArgs e)
      {

      }
      public void myTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
      {
         // showReceivePic();//显示图像完毕

      }
      private void timer1_Tick(object sender, EventArgs e)
      {
          
      }
  }
}
#endregion
