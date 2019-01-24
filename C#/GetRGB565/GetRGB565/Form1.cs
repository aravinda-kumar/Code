using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetRGB565
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string path = @"C:\Users\SHUNCS\Desktop\rgb.bmp";
            string logPath = @"C:\Users\SHUNCS\Desktop\code.txt";
            Bitmap bmp = new Bitmap(path);
            byte[,] pixels = new byte[bmp.Width*bmp.Height, 3];
            int count = 0;
            for (int width = 0; width < bmp.Width; width++) 
            {
                for (int height = 0; height < bmp.Height; height++)
                {
                    int tmpR = bmp.GetPixel(width, height).R>>3;
                    int tmpG = bmp.GetPixel(width, height).G>>2;
                    int tmpB = bmp.GetPixel(width, height).B>>3;
                    pixels[count, 0] = (byte)tmpR;
                    pixels[count, 1] = (byte)tmpG;
                    pixels[count, 2] = (byte)tmpB;
                    count++;
                }
            }
            Console.WriteLine(pixels.Length);
            using (BinaryWriter bw = new BinaryWriter(new FileStream(logPath, FileMode.Create)))
            {
                for (int index = 0; index < pixels.Length/3; index++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        bw.Write(pixels[index, j]);
                    }
                    
                }
            }
            
        }
    }
}
