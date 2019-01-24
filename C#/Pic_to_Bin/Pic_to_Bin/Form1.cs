using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pic_to_Bin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        //加载图片并显示
        private void btn_Load_Click(object sender, EventArgs e)
        {
            OpenFileDialog dia = new OpenFileDialog();
            dia.InitialDirectory = @"E:\JZS\CsharpNote\Pic_to_Bin\Pic_to_Bin";
            dia.Title = "请选择要发送的文件";
            dia.Filter = "图片文件|*.*";
            dia.ShowDialog();
            txtBox_Path.Text = dia.FileName;
            pic_Oringin.ImageLocation = txtBox_Path.Text;
        }

        Thread threadToBinary = null;

        //将图片转换成二进制文件
        private void btn_ToBin_Click(object sender, EventArgs e)
        {
            threadToBinary = new Thread(ConvertToBinart);
            threadToBinary.IsBackground = true;
            threadToBinary.Start();
            
        }
        private void ConvertToBinart()
        {
            //拼接成测试图片路径
            string fullPath = txtBox_Path.Text;
            //初始化类
            Bitmap bmp = new Bitmap(Image.FromFile(fullPath));
            Console.WriteLine("+++++++++++++++++++++++++");
            Console.WriteLine(bmp);
            MemoryStream ms = new MemoryStream();
            bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
            ms.Flush();
            //将二进制数据存到byte数字中
            byte[] bmpBytes = ms.ToArray();
            // richTextBox1.Text = Convert.ToBase64String(bmpBytes);

            string txtPath = @"E:\JZS\CsharpNote\Pic_to_Bin\Pic_to_Bin\bin.txt";
            FileStream fs = new FileStream(txtPath, FileMode.OpenOrCreate);
            BinaryWriter binWriter = new BinaryWriter(fs);
            binWriter.Write(bmpBytes, 0, bmpBytes.Length);
            binWriter.Close();
            fs.Close();

            //foreach (var item in bmpBytes)
            //{
            //    richTextBox_Bin.Text += item;
            //}
        }

        private void btn_ToPic_Click(object sender, EventArgs e)
        {
            //获取二进制数据
            string txtPath = @"E:\JZS\CsharpNote\SocketPic\SocketPic\log\rgb.txt";
            //string txtPath = @"E:\JZS\CsharpNote\Pic_to_Bin\Pic_to_Bin\bin.txt";
            byte[] pageData = null;

            FileStream fs = new FileStream(txtPath, FileMode.Open);
            BinaryReader binReader = new BinaryReader(fs);

            pageData = new byte[fs.Length];
            binReader.Read(pageData, 0, (int)fs.Length);

            binReader.Close();
            fs.Close();


            int[,] pixels = new int[320 * 240, 3];
            int count = 0;

            var bitmap = new Bitmap(320, 240, PixelFormat.Format32bppRgb);

            for (int i = 0; i < pageData.Length - 1; i = i + 2)
            {
                //int 4byte
                int intLow = pageData[i+1];
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

            #region
            //string path = @"C:\Users\SHUNCS\Desktop\rgb.bmp";
            //Bitmap bmp = new Bitmap(path);
            //byte[,] pixels = new byte[bmp.Width * bmp.Height, 3];
            //int count = 0;
            //for (int width = 0; width < bmp.Width; width++)
            //{
            //    for (int height = 0; height < bmp.Height; height++)
            //    {
            //        int tmpR = bmp.GetPixel(width, height).R >> 3;
            //        int tmpG = bmp.GetPixel(width, height).G >> 2;
            //        int tmpB = bmp.GetPixel(width, height).B >> 3;
            //        pixels[count, 0] = (byte)(tmpR << 3);
            //        pixels[count, 1] = (byte)(tmpG << 2);
            //        pixels[count, 2] = (byte)(tmpB << 3);
            //        count++;
            //    }
            //}
            #endregion
            
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
            pic_Convert.Image = bitmap;
            bitmap.Save("E:\\JZS\\CsharpNote\\SocketPic\\SocketPic\\log\\rgb.bmp");


            #region
            //Bitmap OvImage = new Bitmap(320, 240);
            ////Color color = new Color();
            ////color.A
            ////OvImage.SetPixel()

            //string RecvDataText = null;
            //for (int i = 0; i < pageData.Length; i++)
            //{
            //    Int32 Row = pageData.Length / 3 / 160;
            //    Int32 DataH = (pageData[i] >> 4) * 17;
            //    Int32 DataL = (pageData[i] & 0x0f) * 17;
            //    RecvDataText += (pageData[i].ToString("X2") + " ");//长度变成了3倍！



            //    //高4位是一个像素
            //    Color newColorH = Color.FromArgb(DataH, DataH, DataH);
            //    OvImage.SetPixel(Row, i * 2, newColorH);

            //    //低4位是下一个像素
            //    Color newColorL = Color.FromArgb(DataL, DataL, DataL);
            //    OvImage.SetPixel(Row, i * 2 + 1, newColorL);

            //}
            //pic_Convert.Image = OvImage;
            ////tbxRecvData.Text += RecvDataText;//更新接收框数据
            //tbxRecvLength.Text = (tbxRecvData.TextLength / 3).ToString();//更新接收框数据长度

            ////将二进制流数据转换为图片
            //MemoryStream ms = new MemoryStream(pageData, 0, pageData.Length);
            //Bitmap bm = new Bitmap(ms);
            //bm.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);


            ////ms.Write(pageData, 0, pageData.Length);
            //Image image = Image.FromStream(ms);
            //string path = @"E:\JZS\CsharpNote\SocketPic\SocketPic\log\123.bmp";
            //image.Save(path);
            //pic_Convert.Image = Image.FromStream(ms);
            //Bitmap bmp = new Bitmap(new MemoryStream(pageData));
            //string path = Application.StartupPath;
            //string fullPath = path + "\\images\\" + Guid.NewGuid().ToString() + ".png";
            //richTextBox1.Text = fullPath;
            //bmp.Save(fullPath, System.Drawing.Imaging.ImageFormat.Png);
            #endregion
        }
    }
}
