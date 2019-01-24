using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        SoundPlayer player;
        DateTime dateTime1 = DateTime.Now;
        
        private void btn_Play_Click(object sender, EventArgs e)
        {
            //DateTime dateTime2 = DateTime.Now;
            //try
            //{
            //    if (player == null)
            //    {
            //        player = new SoundPlayer();
            //        player.SoundLocation = @"E:\JZS\CsharpNote\Mine\Mine\Resources\机头处皮带发生跑偏.wav";
            //        player.Load();
            //        player.Play();
            //    }
            //    if(dateTime2.Millisecond - dateTime1.Millisecond >= 2)
            //    {
            //        player = null;
            //    }
            //    dateTime1 = dateTime2;
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            if(mediaPlayer.playState == WMPPlayState.wmppsUndefined || mediaPlayer.playState == WMPPlayState.wmppsStopped)
                mediaPlayer.URL = @"E:\JZS\CsharpNote\Mine\Mine\Resources\bak\机头处皮带发生跑偏.mp3";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (mediaPlayer.playState == WMPPlayState.wmppsUndefined || mediaPlayer.playState == WMPPlayState.wmppsStopped)
                mediaPlayer.URL = @"E:\JZS\CsharpNote\Mine\Mine\Resources\bak\机尾处皮带发生跑偏.mp3";
        }
    }
}
