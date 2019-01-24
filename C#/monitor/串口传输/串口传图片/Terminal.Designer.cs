namespace SerialPortTerminal
{
  partial class frmTerminal
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTerminal));
        this.btnSend = new System.Windows.Forms.Button();
        this.cmbPortName = new System.Windows.Forms.ComboBox();
        this.cmbBaudRate = new System.Windows.Forms.ComboBox();
        this.lblComPort = new System.Windows.Forms.Label();
        this.lblBaudRate = new System.Windows.Forms.Label();
        this.btnOpenPort = new System.Windows.Forms.Button();
        this.gbPortSettings = new System.Windows.Forms.GroupBox();
        this.progressBar1 = new System.Windows.Forms.ProgressBar();
        this.label1 = new System.Windows.Forms.Label();
        this.textBox1 = new System.Windows.Forms.TextBox();
        this.pictureBox2 = new System.Windows.Forms.PictureBox();
        this.label2 = new System.Windows.Forms.Label();
        this.pictureBox1 = new System.Windows.Forms.PictureBox();
        this.button1 = new System.Windows.Forms.Button();
        this.textBox2 = new System.Windows.Forms.TextBox();
        this.label4 = new System.Windows.Forms.Label();
        this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
        this.groupBox1 = new System.Windows.Forms.GroupBox();
        this.label3 = new System.Windows.Forms.Label();
        this.rtfTerminal = new System.Windows.Forms.RichTextBox();
        this.textBox4 = new System.Windows.Forms.TextBox();
        this.textBox5 = new System.Windows.Forms.TextBox();
        this.label5 = new System.Windows.Forms.Label();
        this.label6 = new System.Windows.Forms.Label();
        this.label7 = new System.Windows.Forms.Label();
        this.textBox3 = new System.Windows.Forms.TextBox();
        this.gbPortSettings.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
        this.groupBox1.SuspendLayout();
        this.SuspendLayout();
        // 
        // btnSend
        // 
        this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        this.btnSend.Location = new System.Drawing.Point(381, 61);
        this.btnSend.Name = "btnSend";
        this.btnSend.Size = new System.Drawing.Size(75, 23);
        this.btnSend.TabIndex = 3;
        this.btnSend.Text = "发送图片";
        this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
        // 
        // cmbPortName
        // 
        this.cmbPortName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cmbPortName.FormattingEnabled = true;
        this.cmbPortName.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6"});
        this.cmbPortName.Location = new System.Drawing.Point(28, 42);
        this.cmbPortName.Name = "cmbPortName";
        this.cmbPortName.Size = new System.Drawing.Size(67, 20);
        this.cmbPortName.TabIndex = 1;
        // 
        // cmbBaudRate
        // 
        this.cmbBaudRate.FormattingEnabled = true;
        this.cmbBaudRate.Items.AddRange(new object[] {
            "4800",
            "9600",
            "38400",
            "115200"});
        this.cmbBaudRate.Location = new System.Drawing.Point(139, 42);
        this.cmbBaudRate.Name = "cmbBaudRate";
        this.cmbBaudRate.Size = new System.Drawing.Size(93, 20);
        this.cmbBaudRate.TabIndex = 3;
        // 
        // lblComPort
        // 
        this.lblComPort.AutoSize = true;
        this.lblComPort.Location = new System.Drawing.Point(27, 22);
        this.lblComPort.Name = "lblComPort";
        this.lblComPort.Size = new System.Drawing.Size(47, 12);
        this.lblComPort.TabIndex = 0;
        this.lblComPort.Text = "串口号:";
        // 
        // lblBaudRate
        // 
        this.lblBaudRate.AutoSize = true;
        this.lblBaudRate.Location = new System.Drawing.Point(137, 22);
        this.lblBaudRate.Name = "lblBaudRate";
        this.lblBaudRate.Size = new System.Drawing.Size(47, 12);
        this.lblBaudRate.TabIndex = 2;
        this.lblBaudRate.Text = "波特率:";
        // 
        // btnOpenPort
        // 
        this.btnOpenPort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                    | System.Windows.Forms.AnchorStyles.Right)));
        this.btnOpenPort.Location = new System.Drawing.Point(308, 616);
        this.btnOpenPort.Name = "btnOpenPort";
        this.btnOpenPort.Size = new System.Drawing.Size(71, 24);
        this.btnOpenPort.TabIndex = 6;
        this.btnOpenPort.Text = "打开串口";
        this.btnOpenPort.Click += new System.EventHandler(this.btnOpenPort_Click);
        // 
        // gbPortSettings
        // 
        this.gbPortSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                    | System.Windows.Forms.AnchorStyles.Right)));
        this.gbPortSettings.Controls.Add(this.lblComPort);
        this.gbPortSettings.Controls.Add(this.cmbPortName);
        this.gbPortSettings.Controls.Add(this.cmbBaudRate);
        this.gbPortSettings.Controls.Add(this.lblBaudRate);
        this.gbPortSettings.Location = new System.Drawing.Point(30, 550);
        this.gbPortSettings.Name = "gbPortSettings";
        this.gbPortSettings.Size = new System.Drawing.Size(250, 73);
        this.gbPortSettings.TabIndex = 4;
        this.gbPortSettings.TabStop = false;
        this.gbPortSettings.Text = "串口设置";
        // 
        // progressBar1
        // 
        this.progressBar1.Location = new System.Drawing.Point(132, 496);
        this.progressBar1.Name = "progressBar1";
        this.progressBar1.Size = new System.Drawing.Size(401, 23);
        this.progressBar1.TabIndex = 15;
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Location = new System.Drawing.Point(61, 503);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(65, 12);
        this.label1.TabIndex = 16;
        this.label1.Text = "发送进度：";
        // 
        // textBox1
        // 
        this.textBox1.Location = new System.Drawing.Point(124, 65);
        this.textBox1.Name = "textBox1";
        this.textBox1.Size = new System.Drawing.Size(129, 21);
        this.textBox1.TabIndex = 17;
        this.textBox1.Text = "40";
        // 
        // pictureBox2
        // 
        this.pictureBox2.Location = new System.Drawing.Point(504, 31);
        this.pictureBox2.Name = "pictureBox2";
        this.pictureBox2.Size = new System.Drawing.Size(431, 349);
        this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        this.pictureBox2.TabIndex = 18;
        this.pictureBox2.TabStop = false;
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Location = new System.Drawing.Point(37, 73);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(83, 12);
        this.label2.TabIndex = 19;
        this.label2.Text = "发送时间间隔:";
        // 
        // pictureBox1
        // 
        this.pictureBox1.Location = new System.Drawing.Point(30, 31);
        this.pictureBox1.Name = "pictureBox1";
        this.pictureBox1.Size = new System.Drawing.Size(438, 349);
        this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        this.pictureBox1.TabIndex = 21;
        this.pictureBox1.TabStop = false;
        // 
        // button1
        // 
        this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        this.button1.Location = new System.Drawing.Point(381, 27);
        this.button1.Name = "button1";
        this.button1.Size = new System.Drawing.Size(75, 23);
        this.button1.TabIndex = 23;
        this.button1.Text = "选择图片";
        this.button1.Click += new System.EventHandler(this.button1_Click_1);
        // 
        // textBox2
        // 
        this.textBox2.Location = new System.Drawing.Point(124, 28);
        this.textBox2.Name = "textBox2";
        this.textBox2.Size = new System.Drawing.Size(226, 21);
        this.textBox2.TabIndex = 24;
        this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
        // 
        // label4
        // 
        this.label4.AutoSize = true;
        this.label4.Location = new System.Drawing.Point(55, 32);
        this.label4.Name = "label4";
        this.label4.Size = new System.Drawing.Size(65, 12);
        this.label4.TabIndex = 25;
        this.label4.Text = "图片位置：";
        // 
        // openFileDialog1
        // 
        this.openFileDialog1.FileName = "openFileDialog1";
        // 
        // groupBox1
        // 
        this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                    | System.Windows.Forms.AnchorStyles.Right)));
        this.groupBox1.Controls.Add(this.btnSend);
        this.groupBox1.Controls.Add(this.label4);
        this.groupBox1.Controls.Add(this.textBox1);
        this.groupBox1.Controls.Add(this.textBox2);
        this.groupBox1.Controls.Add(this.label2);
        this.groupBox1.Controls.Add(this.button1);
        this.groupBox1.Controls.Add(this.label3);
        this.groupBox1.Location = new System.Drawing.Point(444, 539);
        this.groupBox1.Name = "groupBox1";
        this.groupBox1.Size = new System.Drawing.Size(491, 101);
        this.groupBox1.TabIndex = 26;
        this.groupBox1.TabStop = false;
        this.groupBox1.Text = "设置";
        // 
        // label3
        // 
        this.label3.AutoSize = true;
        this.label3.Location = new System.Drawing.Point(259, 68);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(77, 12);
        this.label3.TabIndex = 20;
        this.label3.Text = "（单位：ms）";
        // 
        // rtfTerminal
        // 
        this.rtfTerminal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                    | System.Windows.Forms.AnchorStyles.Left)
                    | System.Windows.Forms.AnchorStyles.Right)));
        this.rtfTerminal.Location = new System.Drawing.Point(30, 386);
        this.rtfTerminal.Name = "rtfTerminal";
        this.rtfTerminal.Size = new System.Drawing.Size(905, 90);
        this.rtfTerminal.TabIndex = 27;
        this.rtfTerminal.Text = "";
        // 
        // textBox4
        // 
        this.textBox4.Location = new System.Drawing.Point(825, 503);
        this.textBox4.Name = "textBox4";
        this.textBox4.Size = new System.Drawing.Size(120, 21);
        this.textBox4.TabIndex = 30;
        // 
        // textBox5
        // 
        this.textBox5.Location = new System.Drawing.Point(644, 503);
        this.textBox5.Name = "textBox5";
        this.textBox5.Size = new System.Drawing.Size(120, 21);
        this.textBox5.TabIndex = 31;
        // 
        // label5
        // 
        this.label5.AutoSize = true;
        this.label5.Location = new System.Drawing.Point(573, 507);
        this.label5.Name = "label5";
        this.label5.Size = new System.Drawing.Size(65, 12);
        this.label5.TabIndex = 32;
        this.label5.Text = "字节总数：";
        // 
        // label6
        // 
        this.label6.AutoSize = true;
        this.label6.Location = new System.Drawing.Point(778, 507);
        this.label6.Name = "label6";
        this.label6.Size = new System.Drawing.Size(41, 12);
        this.label6.TabIndex = 33;
        this.label6.Text = "包数：";
        // 
        // label7
        // 
        this.label7.AutoSize = true;
        this.label7.Location = new System.Drawing.Point(261, 535);
        this.label7.Name = "label7";
        this.label7.Size = new System.Drawing.Size(41, 12);
        this.label7.TabIndex = 35;
        this.label7.Text = "耗时：";
        // 
        // textBox3
        // 
        this.textBox3.Location = new System.Drawing.Point(308, 532);
        this.textBox3.Name = "textBox3";
        this.textBox3.Size = new System.Drawing.Size(120, 21);
        this.textBox3.TabIndex = 34;
        // 
        // frmTerminal
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
        this.ClientSize = new System.Drawing.Size(966, 652);
        this.Controls.Add(this.label7);
        this.Controls.Add(this.textBox3);
        this.Controls.Add(this.label6);
        this.Controls.Add(this.label5);
        this.Controls.Add(this.textBox5);
        this.Controls.Add(this.textBox4);
        this.Controls.Add(this.rtfTerminal);
        this.Controls.Add(this.groupBox1);
        this.Controls.Add(this.pictureBox1);
        this.Controls.Add(this.pictureBox2);
        this.Controls.Add(this.label1);
        this.Controls.Add(this.progressBar1);
        this.Controls.Add(this.gbPortSettings);
        this.Controls.Add(this.btnOpenPort);
        this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        this.MinimumSize = new System.Drawing.Size(559, 268);
        this.Name = "frmTerminal";
        this.Text = "SerialPort Terminal";
        this.Load += new System.EventHandler(this.frmTerminal_Load);
        this.Shown += new System.EventHandler(this.frmTerminal_Shown);
        this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTerminal_FormClosing);
        this.gbPortSettings.ResumeLayout(false);
        this.gbPortSettings.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
        this.groupBox1.ResumeLayout(false);
        this.groupBox1.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnSend;
    private System.Windows.Forms.ComboBox cmbPortName;
    private System.Windows.Forms.ComboBox cmbBaudRate;
    private System.Windows.Forms.Label lblComPort;
    private System.Windows.Forms.Label lblBaudRate;
    private System.Windows.Forms.Button btnOpenPort;
    private System.Windows.Forms.GroupBox gbPortSettings;
      private System.Windows.Forms.ProgressBar progressBar1;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox textBox1;
      private System.Windows.Forms.PictureBox pictureBox2;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.PictureBox pictureBox1;
      private System.Windows.Forms.Button button1;
      private System.Windows.Forms.TextBox textBox2;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.OpenFileDialog openFileDialog1;
      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.RichTextBox rtfTerminal;
      private System.Windows.Forms.TextBox textBox4;
      private System.Windows.Forms.TextBox textBox5;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.Label label7;
      private System.Windows.Forms.TextBox textBox3;
  }
}

