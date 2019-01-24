/*******************************************************************************
*  Copyright (C) 2011 - All Rights Reserved		
* 软件作者:	骑飞家族
* 版权所有: 骑飞电子	
* 创建日期:	2011年10月30日 
* 软件历史:	2011年11月10日修改
* Version:  2.0 
* Demo 淘宝地址：http://store.taobao.com/shop/view_shop.htm?asker=wangwang&shop_nick=qifeidianzi
**********************************************************************************************************************************************
懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒
懒懒懒懒懒懒懒懒懒懒懒一懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒困一懒懒懒懒懒懒懒懒懒懒懒懒懒懒一一一一一一一懒懒懒懒懒懒懒
懒懒困一一一一懒一一一一一一二懒懒懒懒困一一一一一一一一懒懒懒懒懒懒懒懒懒四厲懒懒一一懒懒懒一懒懒懒懒懒懒懒懒懒一一一一四四一一一懒懒懒懒懒懒
懒懒懒懒懒懒一懒懒懒一二一懒懒懒懒懒懒一一一一四厲二一四懒一一懒懒懒懒懒四一一一一一一一一一一一懒懒懒懒懒懒懒懒四懒懒四一一一一厲懒懒懒懒懒懒
懒懒懒四厲厲一懒懒厲懒懒懒四懒懒懒懒懒懒懒懒懒懒懒困一懒一一懒懒懒懒懒懒懒一一厲厲一一厲厲厲一一懒懒懒懒懒懒厲厲厲厲厲厲一一厲厲厲懒懒懒懒懒懒
懒懒懒一懒二一一一一一一一一一一一懒懒懒懒懒懒懒懒二一一困懒懒懒懒懒懒懒懒一一一一一一一一一一四懒懒懒懒懒一一一一一一一一一一一一一一一懒懒懒
懒懒懒一一一一一厲二一一厲一懒厲懒懒懒懒懒懒懒懒懒一一一一一懒懒懒懒懒懒懒一一懒懒一一懒懒懒一困懒懒懒懒懒一一四懒懒懒懒一一懒懒困一一四懒懒懒
懒懒懒懒懒懒懒一困一懒一厲一懒懒懒懒懒懒懒懒懒懒懒困一懒懒一一懒懒懒懒懒懒一一一一一一一一一一厲懒懒懒懒懒懒懒懒懒懒懒懒一一厲懒懒懒懒懒懒懒懒
懒二一一一懒四困厲一一一厲一懒懒懒懒懒懒懒懒懒懒懒懒一一懒懒懒懒懒懒懒懒懒懒懒懒懒四一厲懒懒懒懒懒懒一懒懒懒懒懒懒懒懒懒一一厲懒懒懒懒懒懒懒懒
懒懒懒懒懒懒一懒懒懒懒懒一一懒懒懒懒懒懒懒懒懒懒懒懒厲一一一一一一困懒懒懒懒懒懒懒懒一一一一一一一一一懒懒懒懒懒困懒懒厲一一懒懒懒懒懒懒懒懒懒
懒懒懒懒一一一懒懒困一一一一懒懒懒懒懒懒懒懒懒懒懒懒懒懒一一一一一懒懒懒懒懒懒懒懒懒懒一一一一一一一懒懒懒懒懒懒懒一一一一四懒懒懒懒懒懒懒懒懒
懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒懒
**********************************************************************************************************************************************/



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace USBCamera
{
    public partial class USBCamera : Form
    {
        public USBCamera()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            int DevNum = 0;
            StringBuilder DevStr = new StringBuilder(C8051fUSBCameraDLL.SI_MAX_DEVICE_STRLEN);
            int i;

            comboBox_Device.Items.Clear();
            C8051fUSBCameraDLL.Status = C8051fUSBCameraDLL.SI_GetNumDevices(ref DevNum);

            if (C8051fUSBCameraDLL.Status == C8051fUSBCameraDLL.SI_SUCCESS)
            {
                for (i = 0; i < DevNum; i++)
                {
                    C8051fUSBCameraDLL.Status = C8051fUSBCameraDLL.SI_GetProductString(i, DevStr, C8051fUSBCameraDLL.SI_RETURN_SERIAL_NUMBER);
                    comboBox_Device.Items.Insert(i, DevStr);
                }
                this.comboBox_Device.SelectedIndex = 0;  
            }
            else
            {
                MessageBox.Show("Error finding USB device.  Aborting application.");
            }
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            Int32 IOBufSize = 640;
            Byte[] IOBuf = new Byte[IOBufSize];
            Byte[] IOBuf1 = new Byte[153600];
            Int32 BytesSucceed = 0;
            Int32 BytesWriteRequest = IOBufSize - 639;
            Int32 BytesReadRequest = IOBufSize;
            Bitmap CurBitmap = (Bitmap)pictureBox1.Image;
            Rectangle rect = new Rectangle(0, 0, CurBitmap.Width, CurBitmap.Height);
            for (int i = 0; i < 240; i++)
            {
                IOBuf[0] = 0x03;
                C8051fUSBCameraDLL.Status = C8051fUSBCameraDLL.SI_Write(C8051fUSBCameraDLL.hUSBDevice, ref IOBuf[0], BytesWriteRequest, ref BytesSucceed, 0);
                BytesSucceed = 0;

                C8051fUSBCameraDLL.Status = C8051fUSBCameraDLL.SI_Read(C8051fUSBCameraDLL.hUSBDevice, ref IOBuf[0], BytesReadRequest, ref BytesSucceed, 0);

                if ((BytesSucceed != BytesReadRequest) || (C8051fUSBCameraDLL.Status != C8051fUSBCameraDLL.SI_SUCCESS))
                {
                    MessageBox.Show("Error writing to USB. Read " + BytesSucceed.ToString() + " of " + BytesReadRequest.ToString() + " bytes. Application is aborting. Reset hardware and try again.");
                    Application.Exit();
                }
                for (int j = 0; j < 640; j++)
                {
                    IOBuf1[640 * i + j] = IOBuf[j];
                }

            }

           USBCameraDLL.CameraDrawpicture.Draw_picture(320, 240, IOBuf1, CurBitmap, pictureBox1);

        }

        private void usb连续传输图像_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            usb传图.Enabled = false;
        }

        private void usb传图_Click(object sender, EventArgs e)
        {
            Int32 IOBufSize = 640;
            Byte[] IOBuf = new Byte[IOBufSize];
            Byte[] IOBuf1 = new Byte[153600];
            Int32 BytesSucceed = 0;
            Int32 BytesWriteRequest = IOBufSize - 639;
            Int32 BytesReadRequest = IOBufSize;

            for (int i = 0; i < 240; i++)
            {
                IOBuf[0] = 0x03;
                C8051fUSBCameraDLL.Status = C8051fUSBCameraDLL.SI_Write(C8051fUSBCameraDLL.hUSBDevice, ref IOBuf[0], BytesWriteRequest, ref BytesSucceed, 0);
                BytesSucceed = 0;
                C8051fUSBCameraDLL.Status = C8051fUSBCameraDLL.SI_Read(C8051fUSBCameraDLL.hUSBDevice, ref IOBuf[0], BytesReadRequest, ref BytesSucceed, 0);
                if ((BytesSucceed != BytesReadRequest) || (C8051fUSBCameraDLL.Status != C8051fUSBCameraDLL.SI_SUCCESS))
                {
                    MessageBox.Show("Error writing to USB. Read " + BytesSucceed.ToString() + " of " + BytesReadRequest.ToString() + " bytes. Application is aborting. Reset hardware and try again.");
                    Application.Exit();
                }
                for (int j = 0; j < 640; j++)
                {
                    IOBuf1[640 * i + j] = IOBuf[j];

                }

            }
            pictureBox1.Width = 320;
            pictureBox1.Height = 240;
            Bitmap CurBitmap = (Bitmap)pictureBox1.Image;//获得当前图像，并作为位图处理

            USBCameraDLL.CameraDrawpicture.Draw_picture(320, 240, IOBuf1, CurBitmap, pictureBox1);
           
        }

        private void 关闭usb_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            C8051fUSBCameraDLL.Status = C8051fUSBCameraDLL.SI_Close(C8051fUSBCameraDLL.hUSBDevice);

            comboBox_Device.Items.Clear();
            usb传图.Enabled = false;
            usb连续传输图像.Enabled = false;
        }

        private void 打开usb_Click(object sender, EventArgs e)
        {
            int DevNum = 0;
            StringBuilder DevStr = new StringBuilder(C8051fUSBCameraDLL.SI_MAX_DEVICE_STRLEN);
            int i;

            comboBox_Device.Items.Clear();
            C8051fUSBCameraDLL.Status = C8051fUSBCameraDLL.SI_GetNumDevices(ref DevNum);

            if (C8051fUSBCameraDLL.Status == C8051fUSBCameraDLL.SI_SUCCESS)
            {
                for (i = 0; i < DevNum; i++)
                {
                    C8051fUSBCameraDLL.Status = C8051fUSBCameraDLL.SI_GetProductString(i, DevStr, C8051fUSBCameraDLL.SI_RETURN_SERIAL_NUMBER);
                    comboBox_Device.Items.Insert(i, DevStr);
                }
                this.comboBox_Device.SelectedIndex = 0;  // then set combo list to first item
            }
            else
            {
                MessageBox.Show("Error finding USB device.  Aborting application.");
                Application.Exit();
            }

            C8051fUSBCameraDLL.Status = C8051fUSBCameraDLL.SI_Close(C8051fUSBCameraDLL.hUSBDevice);
            C8051fUSBCameraDLL.Status = C8051fUSBCameraDLL.SI_SetTimeouts(300, 300);

            C8051fUSBCameraDLL.Status = C8051fUSBCameraDLL.SI_Open(comboBox_Device.SelectedIndex, ref C8051fUSBCameraDLL.hUSBDevice);
            if (C8051fUSBCameraDLL.Status != C8051fUSBCameraDLL.SI_SUCCESS)
            {
                MessageBox.Show("Error opening device: " + comboBox_Device.Text + ". Application is aborting. Reset hardware and try again.");
                Application.Exit();
            }
            usb传图.Enabled = true;
            usb连续传输图像.Enabled = true;
        }  
    }
}
