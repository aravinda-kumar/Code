namespace 串口调试
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbnPic = new System.Windows.Forms.RadioButton();
            this.btnOpenCOM = new System.Windows.Forms.Button();
            this.btnCheckCOM = new System.Windows.Forms.Button();
            this.rbnHex = new System.Windows.Forms.RadioButton();
            this.rbnChar = new System.Windows.Forms.RadioButton();
            this.cbxDataBits = new System.Windows.Forms.ComboBox();
            this.cbxParity = new System.Windows.Forms.ComboBox();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.cbxStopBits = new System.Windows.Forms.ComboBox();
            this.cbxBaudRate = new System.Windows.Forms.ComboBox();
            this.cbxCOMPort = new System.Windows.Forms.ComboBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbxRecvData = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnCleanData = new System.Windows.Forms.Button();
            this.tbxSendData = new System.Windows.Forms.TextBox();
            this.sp1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pbxRecvImg = new System.Windows.Forms.PictureBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnSendPic = new System.Windows.Forms.Button();
            this.btnClearPic = new System.Windows.Forms.Button();
            this.pbxSendImg = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRecvImg)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSendImg)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.groupBox1.Controls.Add(this.rbnPic);
            this.groupBox1.Controls.Add(this.btnOpenCOM);
            this.groupBox1.Controls.Add(this.btnCheckCOM);
            this.groupBox1.Controls.Add(this.rbnHex);
            this.groupBox1.Controls.Add(this.rbnChar);
            this.groupBox1.Controls.Add(this.cbxDataBits);
            this.groupBox1.Controls.Add(this.cbxParity);
            this.groupBox1.Controls.Add(this.lbl5);
            this.groupBox1.Controls.Add(this.lbl4);
            this.groupBox1.Controls.Add(this.cbxStopBits);
            this.groupBox1.Controls.Add(this.cbxBaudRate);
            this.groupBox1.Controls.Add(this.cbxCOMPort);
            this.groupBox1.Controls.Add(this.lbl3);
            this.groupBox1.Controls.Add(this.lbl2);
            this.groupBox1.Controls.Add(this.lbl1);
            this.groupBox1.Location = new System.Drawing.Point(216, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(561, 136);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "串口设置";
            // 
            // rbnPic
            // 
            this.rbnPic.AutoSize = true;
            this.rbnPic.Location = new System.Drawing.Point(412, 106);
            this.rbnPic.Name = "rbnPic";
            this.rbnPic.Size = new System.Drawing.Size(71, 16);
            this.rbnPic.TabIndex = 15;
            this.rbnPic.TabStop = true;
            this.rbnPic.Text = "图片显示";
            this.rbnPic.UseVisualStyleBackColor = true;
            // 
            // btnOpenCOM
            // 
            this.btnOpenCOM.Location = new System.Drawing.Point(460, 68);
            this.btnOpenCOM.Name = "btnOpenCOM";
            this.btnOpenCOM.Size = new System.Drawing.Size(76, 32);
            this.btnOpenCOM.TabIndex = 14;
            this.btnOpenCOM.Text = "打开串口";
            this.btnOpenCOM.UseVisualStyleBackColor = true;
            this.btnOpenCOM.Click += new System.EventHandler(this.btnOpenCOM_Click);
            // 
            // btnCheckCOM
            // 
            this.btnCheckCOM.Location = new System.Drawing.Point(460, 20);
            this.btnCheckCOM.Name = "btnCheckCOM";
            this.btnCheckCOM.Size = new System.Drawing.Size(76, 31);
            this.btnCheckCOM.TabIndex = 13;
            this.btnCheckCOM.Text = "串口检测";
            this.btnCheckCOM.UseVisualStyleBackColor = true;
            this.btnCheckCOM.Click += new System.EventHandler(this.btnCheckCOM_Click);
            // 
            // rbnHex
            // 
            this.rbnHex.AutoSize = true;
            this.rbnHex.Location = new System.Drawing.Point(324, 106);
            this.rbnHex.Name = "rbnHex";
            this.rbnHex.Size = new System.Drawing.Size(65, 16);
            this.rbnHex.TabIndex = 12;
            this.rbnHex.Text = "HEX显示";
            this.rbnHex.UseVisualStyleBackColor = true;
            // 
            // rbnChar
            // 
            this.rbnChar.AutoSize = true;
            this.rbnChar.Checked = true;
            this.rbnChar.Location = new System.Drawing.Point(237, 106);
            this.rbnChar.Name = "rbnChar";
            this.rbnChar.Size = new System.Drawing.Size(71, 16);
            this.rbnChar.TabIndex = 11;
            this.rbnChar.TabStop = true;
            this.rbnChar.Text = "字符显示";
            this.rbnChar.UseVisualStyleBackColor = true;
            // 
            // cbxDataBits
            // 
            this.cbxDataBits.FormattingEnabled = true;
            this.cbxDataBits.Location = new System.Drawing.Point(293, 68);
            this.cbxDataBits.Name = "cbxDataBits";
            this.cbxDataBits.Size = new System.Drawing.Size(126, 20);
            this.cbxDataBits.TabIndex = 10;
            // 
            // cbxParity
            // 
            this.cbxParity.FormattingEnabled = true;
            this.cbxParity.Location = new System.Drawing.Point(293, 22);
            this.cbxParity.Name = "cbxParity";
            this.cbxParity.Size = new System.Drawing.Size(126, 20);
            this.cbxParity.TabIndex = 9;
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(235, 68);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(41, 12);
            this.lbl5.TabIndex = 7;
            this.lbl5.Text = "数据位";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(236, 27);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(53, 12);
            this.lbl4.TabIndex = 6;
            this.lbl4.Text = "奇偶校验";
            // 
            // cbxStopBits
            // 
            this.cbxStopBits.FormattingEnabled = true;
            this.cbxStopBits.Location = new System.Drawing.Point(77, 102);
            this.cbxStopBits.Name = "cbxStopBits";
            this.cbxStopBits.Size = new System.Drawing.Size(129, 20);
            this.cbxStopBits.TabIndex = 5;
            // 
            // cbxBaudRate
            // 
            this.cbxBaudRate.FormattingEnabled = true;
            this.cbxBaudRate.Location = new System.Drawing.Point(76, 64);
            this.cbxBaudRate.Name = "cbxBaudRate";
            this.cbxBaudRate.Size = new System.Drawing.Size(130, 20);
            this.cbxBaudRate.TabIndex = 4;
            // 
            // cbxCOMPort
            // 
            this.cbxCOMPort.DisplayMember = "COM1 COM2";
            this.cbxCOMPort.FormattingEnabled = true;
            this.cbxCOMPort.Location = new System.Drawing.Point(76, 27);
            this.cbxCOMPort.Name = "cbxCOMPort";
            this.cbxCOMPort.Size = new System.Drawing.Size(130, 20);
            this.cbxCOMPort.TabIndex = 3;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(17, 102);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(53, 12);
            this.lbl3.TabIndex = 2;
            this.lbl3.Text = "停止位：";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(17, 64);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(53, 12);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "波特率：";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(17, 30);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(53, 12);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "串口号：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbxRecvData);
            this.groupBox2.Location = new System.Drawing.Point(23, 166);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(469, 217);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "数据接收";
            // 
            // tbxRecvData
            // 
            this.tbxRecvData.Location = new System.Drawing.Point(14, 22);
            this.tbxRecvData.Multiline = true;
            this.tbxRecvData.Name = "tbxRecvData";
            this.tbxRecvData.ReadOnly = true;
            this.tbxRecvData.Size = new System.Drawing.Size(431, 180);
            this.tbxRecvData.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSend);
            this.groupBox3.Controls.Add(this.btnCleanData);
            this.groupBox3.Controls.Add(this.tbxSendData);
            this.groupBox3.Location = new System.Drawing.Point(23, 389);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(469, 142);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "数据发送";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(379, 87);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(68, 25);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "发送数据";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnCleanData
            // 
            this.btnCleanData.Location = new System.Drawing.Point(379, 39);
            this.btnCleanData.Name = "btnCleanData";
            this.btnCleanData.Size = new System.Drawing.Size(70, 25);
            this.btnCleanData.TabIndex = 1;
            this.btnCleanData.Text = "清空数据";
            this.btnCleanData.UseVisualStyleBackColor = true;
            this.btnCleanData.Click += new System.EventHandler(this.btnCleanData_Click);
            // 
            // tbxSendData
            // 
            this.tbxSendData.Location = new System.Drawing.Point(21, 16);
            this.tbxSendData.Multiline = true;
            this.tbxSendData.Name = "tbxSendData";
            this.tbxSendData.Size = new System.Drawing.Size(338, 120);
            this.tbxSendData.TabIndex = 0;
            // 
            // sp1
            // 
            this.sp1.DtrEnable = true;
            this.sp1.ReadBufferSize = 4096000;
            this.sp1.RtsEnable = true;
            this.sp1.WriteBufferSize = 500;
            this.sp1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.sp1_DataReceived);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pbxRecvImg);
            this.groupBox4.Location = new System.Drawing.Point(498, 166);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(487, 217);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "图片接收";
            // 
            // pbxRecvImg
            // 
            this.pbxRecvImg.Location = new System.Drawing.Point(7, 22);
            this.pbxRecvImg.Name = "pbxRecvImg";
            this.pbxRecvImg.Size = new System.Drawing.Size(474, 180);
            this.pbxRecvImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxRecvImg.TabIndex = 0;
            this.pbxRecvImg.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnSendPic);
            this.groupBox5.Controls.Add(this.btnClearPic);
            this.groupBox5.Controls.Add(this.pbxSendImg);
            this.groupBox5.Location = new System.Drawing.Point(498, 390);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(487, 141);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "图片发送";
            // 
            // btnSendPic
            // 
            this.btnSendPic.Location = new System.Drawing.Point(401, 86);
            this.btnSendPic.Name = "btnSendPic";
            this.btnSendPic.Size = new System.Drawing.Size(66, 23);
            this.btnSendPic.TabIndex = 2;
            this.btnSendPic.Text = "发送图片";
            this.btnSendPic.UseVisualStyleBackColor = true;
            this.btnSendPic.Click += new System.EventHandler(this.btnSendPic_Click);
            // 
            // btnClearPic
            // 
            this.btnClearPic.Location = new System.Drawing.Point(401, 39);
            this.btnClearPic.Name = "btnClearPic";
            this.btnClearPic.Size = new System.Drawing.Size(66, 25);
            this.btnClearPic.TabIndex = 1;
            this.btnClearPic.Text = "清空图片";
            this.btnClearPic.UseVisualStyleBackColor = true;
            this.btnClearPic.Click += new System.EventHandler(this.btnClearPic_Click);
            // 
            // pbxSendImg
            // 
            this.pbxSendImg.Location = new System.Drawing.Point(9, 18);
            this.pbxSendImg.Name = "pbxSendImg";
            this.pbxSendImg.Size = new System.Drawing.Size(371, 114);
            this.pbxSendImg.TabIndex = 0;
            this.pbxSendImg.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 543);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRecvImg)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxSendImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnOpenCOM;
        private System.Windows.Forms.Button btnCheckCOM;
        private System.Windows.Forms.RadioButton rbnHex;
        private System.Windows.Forms.RadioButton rbnChar;
        private System.Windows.Forms.ComboBox cbxDataBits;
        private System.Windows.Forms.ComboBox cbxParity;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.ComboBox cbxStopBits;
        private System.Windows.Forms.ComboBox cbxBaudRate;
        private System.Windows.Forms.ComboBox cbxCOMPort;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox tbxRecvData;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnCleanData;
        private System.Windows.Forms.TextBox tbxSendData;
        private System.IO.Ports.SerialPort sp1;
        private System.Windows.Forms.RadioButton rbnPic;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox pbxRecvImg;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnSendPic;
        private System.Windows.Forms.Button btnClearPic;
        private System.Windows.Forms.PictureBox pbxSendImg;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;

    }
}

