using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;
using System.IO.Ports;
using System.Timers;

namespace zigbee
{
    public partial class Form1 : Form
    {
        string curFileName;
        Bitmap bmp1 = null;
        int width, height,recl;
        byte[] picFile = null;
        byte []receive = null;
        Int64 receiveflag = 0;
        SerialPort sp = null;
        System.Windows.Forms.Timer t1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnDlg = new OpenFileDialog();
            opnDlg.Filter = "所有图像文件 | *.bmp; *.pcx; *.png; *.jpg; *.gif;" +
                "*.tif; *.ico; *.dxf; *.cgm; *.cdr; *.wmf; *.eps; *.emf|" +
                "位图( *.bmp; *.jpg; *.png;...) | *.bmp; *.pcx; *.png; *.jpg; *.gif; *.tif; *.ico|" +
                "矢量图( *.wmf; *.eps; *.emf;...) | *.dxf; *.cgm; *.cdr; *.wmf; *.eps; *.emf";
            opnDlg.Title = "打开图像文件";
            opnDlg.ShowHelp = true;
            if (opnDlg.ShowDialog() == DialogResult.OK)
            {
                curFileName = opnDlg.FileName;
                try
                {
                    bmp1 = new Bitmap(curFileName);
                    pictureBox1.Image = bmp1;

                    width = bmp1.Width;
                    height = bmp1.Height;
                    FileStream fileStream = new FileStream(curFileName, FileMode.Open, FileAccess.Read, FileShare.Read);
                    picFile = new byte[fileStream.Length];
                    fileStream.Read(picFile, 0, picFile.Length);

                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button6.Enabled = false;
            receive = new byte[100000];
            string[] portsArray = SerialPort.GetPortNames();
            Array.Sort<string>(portsArray);
            foreach (string port in portsArray)
            {

                this.comboBox1.Items.Add(port);

            }
            this.comboBox2.Items.Add("9600");
            this.comboBox2.Items.Add("4800");
            this.comboBox2.Items.Add("19200");
            sp = new SerialPort();

            t1 = new System.Windows.Forms.Timer();
            t1.Interval = 100;
            t1.Tick += new EventHandler(get);
            t1.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sp.PortName = this.comboBox1.SelectedItem.ToString();
            sp.BaudRate = Convert.ToInt16(this.comboBox2.SelectedItem.ToString());
            if (sp.IsOpen == false)
            {
                sp.Open();
                t1.Enabled = true;
                button6.Enabled = true;
                button5.Enabled = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (sp.IsOpen == true)
            {
                sp.Close();
                t1.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (sp.IsOpen == true)
            {
                sp.Write(picFile ,0,picFile .Length );
                //sp.Write("ok");
            }
        }
        public void get(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked == true)
            {
                recl = sp.BytesToRead;
                byte[] recFile = new byte[recl];
                sp.Read(recFile, 0, recl);
                for (int i = 0; i < recl; i++)
                { 
                  receive [receiveflag ++]=recFile [i];
                }
                textBox2.Text = receiveflag.ToString();
                if (recl ==0&&receiveflag !=0)
                {
                    System.IO.MemoryStream stream = new System.IO.MemoryStream((byte[])receive );
                    //Image pic = Image.FromStream(stream);
                    Bitmap pic = new Bitmap(stream);
                    this.pictureBox2.Image = pic;
                    textBox1.Text = "ok";
                    textBox2.Text = receiveflag.ToString();
                    //serialPort1.DiscardInBuffer();
                    //serialPort1.DiscardOutBuffer();
                 
                }
            }
        }
    }
}
