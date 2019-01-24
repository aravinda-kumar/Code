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
        this.rtfTerminal = new System.Windows.Forms.RichTextBox();
        this.txtSendData = new System.Windows.Forms.TextBox();
        this.lblSend = new System.Windows.Forms.Label();
        this.btnSend = new System.Windows.Forms.Button();
        this.cmbPortName = new System.Windows.Forms.ComboBox();
        this.cmbBaudRate = new System.Windows.Forms.ComboBox();
        this.rbHex = new System.Windows.Forms.RadioButton();
        this.rbText = new System.Windows.Forms.RadioButton();
        this.gbMode = new System.Windows.Forms.GroupBox();
        this.lblComPort = new System.Windows.Forms.Label();
        this.lblBaudRate = new System.Windows.Forms.Label();
        this.label1 = new System.Windows.Forms.Label();
        this.cmbParity = new System.Windows.Forms.ComboBox();
        this.lblDataBits = new System.Windows.Forms.Label();
        this.cmbDataBits = new System.Windows.Forms.ComboBox();
        this.lblStopBits = new System.Windows.Forms.Label();
        this.cmbStopBits = new System.Windows.Forms.ComboBox();
        this.btnOpenPort = new System.Windows.Forms.Button();
        this.gbPortSettings = new System.Windows.Forms.GroupBox();
        this.button1_left = new System.Windows.Forms.Button();
        this.button_head = new System.Windows.Forms.Button();
        this.button_right = new System.Windows.Forms.Button();
        this.button_back = new System.Windows.Forms.Button();
        this.button_stop = new System.Windows.Forms.Button();
        this.groupBox1 = new System.Windows.Forms.GroupBox();
        this.button1 = new System.Windows.Forms.Button();
        this.gbMode.SuspendLayout();
        this.gbPortSettings.SuspendLayout();
        this.SuspendLayout();
        // 
        // rtfTerminal
        // 
        this.rtfTerminal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                    | System.Windows.Forms.AnchorStyles.Left)
                    | System.Windows.Forms.AnchorStyles.Right)));
        this.rtfTerminal.Location = new System.Drawing.Point(12, 8);
        this.rtfTerminal.Name = "rtfTerminal";
        this.rtfTerminal.Size = new System.Drawing.Size(588, 266);
        this.rtfTerminal.TabIndex = 0;
        this.rtfTerminal.Text = "";
        // 
        // txtSendData
        // 
        this.txtSendData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                    | System.Windows.Forms.AnchorStyles.Right)));
        this.txtSendData.Location = new System.Drawing.Point(87, 293);
        this.txtSendData.Name = "txtSendData";
        this.txtSendData.Size = new System.Drawing.Size(344, 21);
        this.txtSendData.TabIndex = 2;
        this.txtSendData.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSendData_KeyDown);
        this.txtSendData.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSendData_KeyPress);
        // 
        // lblSend
        // 
        this.lblSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
        this.lblSend.AutoSize = true;
        this.lblSend.Location = new System.Drawing.Point(16, 296);
        this.lblSend.Name = "lblSend";
        this.lblSend.Size = new System.Drawing.Size(65, 12);
        this.lblSend.TabIndex = 1;
        this.lblSend.Text = "Send &Data:";
        // 
        // btnSend
        // 
        this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        this.btnSend.Location = new System.Drawing.Point(437, 291);
        this.btnSend.Name = "btnSend";
        this.btnSend.Size = new System.Drawing.Size(75, 23);
        this.btnSend.TabIndex = 3;
        this.btnSend.Text = "Send";
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
        this.cmbPortName.Location = new System.Drawing.Point(13, 32);
        this.cmbPortName.Name = "cmbPortName";
        this.cmbPortName.Size = new System.Drawing.Size(67, 20);
        this.cmbPortName.TabIndex = 1;
        // 
        // cmbBaudRate
        // 
        this.cmbBaudRate.FormattingEnabled = true;
        this.cmbBaudRate.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "28800",
            "36000",
            "115000"});
        this.cmbBaudRate.Location = new System.Drawing.Point(11, 76);
        this.cmbBaudRate.Name = "cmbBaudRate";
        this.cmbBaudRate.Size = new System.Drawing.Size(69, 20);
        this.cmbBaudRate.TabIndex = 3;
        this.cmbBaudRate.Validating += new System.ComponentModel.CancelEventHandler(this.cmbBaudRate_Validating);
        // 
        // rbHex
        // 
        this.rbHex.AutoSize = true;
        this.rbHex.Location = new System.Drawing.Point(12, 36);
        this.rbHex.Name = "rbHex";
        this.rbHex.Size = new System.Drawing.Size(41, 16);
        this.rbHex.TabIndex = 1;
        this.rbHex.Text = "Hex";
        this.rbHex.CheckedChanged += new System.EventHandler(this.rbHex_CheckedChanged);
        // 
        // rbText
        // 
        this.rbText.AutoSize = true;
        this.rbText.Location = new System.Drawing.Point(12, 20);
        this.rbText.Name = "rbText";
        this.rbText.Size = new System.Drawing.Size(47, 16);
        this.rbText.TabIndex = 0;
        this.rbText.Text = "Text";
        this.rbText.CheckedChanged += new System.EventHandler(this.rbText_CheckedChanged);
        // 
        // gbMode
        // 
        this.gbMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
        this.gbMode.Controls.Add(this.rbText);
        this.gbMode.Controls.Add(this.rbHex);
        this.gbMode.Location = new System.Drawing.Point(518, 321);
        this.gbMode.Name = "gbMode";
        this.gbMode.Size = new System.Drawing.Size(82, 59);
        this.gbMode.TabIndex = 5;
        this.gbMode.TabStop = false;
        this.gbMode.Text = "Data &Mode";
        // 
        // lblComPort
        // 
        this.lblComPort.AutoSize = true;
        this.lblComPort.Location = new System.Drawing.Point(12, 18);
        this.lblComPort.Name = "lblComPort";
        this.lblComPort.Size = new System.Drawing.Size(59, 12);
        this.lblComPort.TabIndex = 0;
        this.lblComPort.Text = "COM Port:";
        // 
        // lblBaudRate
        // 
        this.lblBaudRate.AutoSize = true;
        this.lblBaudRate.Location = new System.Drawing.Point(15, 56);
        this.lblBaudRate.Name = "lblBaudRate";
        this.lblBaudRate.Size = new System.Drawing.Size(65, 12);
        this.lblBaudRate.TabIndex = 2;
        this.lblBaudRate.Text = "Baud Rate:";
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Location = new System.Drawing.Point(99, 17);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(47, 12);
        this.label1.TabIndex = 4;
        this.label1.Text = "Parity:";
        // 
        // cmbParity
        // 
        this.cmbParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cmbParity.FormattingEnabled = true;
        this.cmbParity.Items.AddRange(new object[] {
            "None",
            "Even",
            "Odd"});
        this.cmbParity.Location = new System.Drawing.Point(101, 32);
        this.cmbParity.Name = "cmbParity";
        this.cmbParity.Size = new System.Drawing.Size(60, 20);
        this.cmbParity.TabIndex = 5;
        // 
        // lblDataBits
        // 
        this.lblDataBits.AutoSize = true;
        this.lblDataBits.Location = new System.Drawing.Point(99, 56);
        this.lblDataBits.Name = "lblDataBits";
        this.lblDataBits.Size = new System.Drawing.Size(65, 12);
        this.lblDataBits.TabIndex = 6;
        this.lblDataBits.Text = "Data Bits:";
        // 
        // cmbDataBits
        // 
        this.cmbDataBits.FormattingEnabled = true;
        this.cmbDataBits.Items.AddRange(new object[] {
            "7",
            "8",
            "9"});
        this.cmbDataBits.Location = new System.Drawing.Point(101, 75);
        this.cmbDataBits.Name = "cmbDataBits";
        this.cmbDataBits.Size = new System.Drawing.Size(60, 20);
        this.cmbDataBits.TabIndex = 7;
        this.cmbDataBits.Validating += new System.ComponentModel.CancelEventHandler(this.cmbDataBits_Validating);
        // 
        // lblStopBits
        // 
        this.lblStopBits.AutoSize = true;
        this.lblStopBits.Location = new System.Drawing.Point(178, 17);
        this.lblStopBits.Name = "lblStopBits";
        this.lblStopBits.Size = new System.Drawing.Size(65, 12);
        this.lblStopBits.TabIndex = 8;
        this.lblStopBits.Text = "Stop Bits:";
        // 
        // cmbStopBits
        // 
        this.cmbStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cmbStopBits.FormattingEnabled = true;
        this.cmbStopBits.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
        this.cmbStopBits.Location = new System.Drawing.Point(178, 32);
        this.cmbStopBits.Name = "cmbStopBits";
        this.cmbStopBits.Size = new System.Drawing.Size(65, 20);
        this.cmbStopBits.TabIndex = 9;
        // 
        // btnOpenPort
        // 
        this.btnOpenPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        this.btnOpenPort.Location = new System.Drawing.Point(518, 386);
        this.btnOpenPort.Name = "btnOpenPort";
        this.btnOpenPort.Size = new System.Drawing.Size(82, 36);
        this.btnOpenPort.TabIndex = 6;
        this.btnOpenPort.Text = "&Open Port";
        this.btnOpenPort.Click += new System.EventHandler(this.btnOpenPort_Click);
        // 
        // gbPortSettings
        // 
        this.gbPortSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
        this.gbPortSettings.Controls.Add(this.lblComPort);
        this.gbPortSettings.Controls.Add(this.cmbPortName);
        this.gbPortSettings.Controls.Add(this.lblStopBits);
        this.gbPortSettings.Controls.Add(this.cmbBaudRate);
        this.gbPortSettings.Controls.Add(this.cmbStopBits);
        this.gbPortSettings.Controls.Add(this.lblBaudRate);
        this.gbPortSettings.Controls.Add(this.lblDataBits);
        this.gbPortSettings.Controls.Add(this.cmbParity);
        this.gbPortSettings.Controls.Add(this.cmbDataBits);
        this.gbPortSettings.Controls.Add(this.label1);
        this.gbPortSettings.Location = new System.Drawing.Point(12, 320);
        this.gbPortSettings.Name = "gbPortSettings";
        this.gbPortSettings.Size = new System.Drawing.Size(260, 102);
        this.gbPortSettings.TabIndex = 4;
        this.gbPortSettings.TabStop = false;
        this.gbPortSettings.Text = "Serial Port &Settings";
        // 
        // button1_left
        // 
        this.button1_left.Location = new System.Drawing.Point(275, 356);
        this.button1_left.Name = "button1_left";
        this.button1_left.Size = new System.Drawing.Size(67, 23);
        this.button1_left.TabIndex = 7;
        this.button1_left.Text = "左转";
        this.button1_left.UseVisualStyleBackColor = true;
        this.button1_left.Click += new System.EventHandler(this.button1_left_Click);
        // 
        // button_head
        // 
        this.button_head.Location = new System.Drawing.Point(344, 327);
        this.button_head.Name = "button_head";
        this.button_head.Size = new System.Drawing.Size(67, 23);
        this.button_head.TabIndex = 8;
        this.button_head.Text = "直冲";
        this.button_head.UseVisualStyleBackColor = true;
        this.button_head.Click += new System.EventHandler(this.button_head_Click);
        // 
        // button_right
        // 
        this.button_right.Location = new System.Drawing.Point(413, 356);
        this.button_right.Name = "button_right";
        this.button_right.Size = new System.Drawing.Size(67, 23);
        this.button_right.TabIndex = 9;
        this.button_right.Text = "右转";
        this.button_right.UseVisualStyleBackColor = true;
        this.button_right.Click += new System.EventHandler(this.button_right_Click);
        // 
        // button_back
        // 
        this.button_back.Location = new System.Drawing.Point(344, 392);
        this.button_back.Name = "button_back";
        this.button_back.Size = new System.Drawing.Size(67, 23);
        this.button_back.TabIndex = 10;
        this.button_back.Text = "后退";
        this.button_back.UseVisualStyleBackColor = true;
        this.button_back.Click += new System.EventHandler(this.button_back_Click);
        // 
        // button_stop
        // 
        this.button_stop.Location = new System.Drawing.Point(344, 356);
        this.button_stop.Name = "button_stop";
        this.button_stop.Size = new System.Drawing.Size(67, 23);
        this.button_stop.TabIndex = 11;
        this.button_stop.Text = "停止";
        this.button_stop.UseVisualStyleBackColor = true;
        this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
        // 
        // groupBox1
        // 
        this.groupBox1.Location = new System.Drawing.Point(275, 320);
        this.groupBox1.Name = "groupBox1";
        this.groupBox1.Size = new System.Drawing.Size(204, 100);
        this.groupBox1.TabIndex = 12;
        this.groupBox1.TabStop = false;
        this.groupBox1.Text = "smartcar";
        // 
        // button1
        // 
        this.button1.Location = new System.Drawing.Point(518, 290);
        this.button1.Name = "button1";
        this.button1.Size = new System.Drawing.Size(82, 23);
        this.button1.TabIndex = 13;
        this.button1.Text = "清空";
        this.button1.UseVisualStyleBackColor = true;
        this.button1.Click += new System.EventHandler(this.button1_Click);
        // 
        // frmTerminal
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(612, 431);
        this.Controls.Add(this.button1);
        this.Controls.Add(this.button_stop);
        this.Controls.Add(this.button_back);
        this.Controls.Add(this.button_right);
        this.Controls.Add(this.button_head);
        this.Controls.Add(this.button1_left);
        this.Controls.Add(this.gbPortSettings);
        this.Controls.Add(this.btnOpenPort);
        this.Controls.Add(this.gbMode);
        this.Controls.Add(this.btnSend);
        this.Controls.Add(this.lblSend);
        this.Controls.Add(this.txtSendData);
        this.Controls.Add(this.rtfTerminal);
        this.Controls.Add(this.groupBox1);
        this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        this.MinimumSize = new System.Drawing.Size(559, 268);
        this.Name = "frmTerminal";
        this.Text = "SerialPort Terminal";
        this.Shown += new System.EventHandler(this.frmTerminal_Shown);
        this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTerminal_FormClosing);
        this.gbMode.ResumeLayout(false);
        this.gbMode.PerformLayout();
        this.gbPortSettings.ResumeLayout(false);
        this.gbPortSettings.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.RichTextBox rtfTerminal;
    private System.Windows.Forms.TextBox txtSendData;
    private System.Windows.Forms.Label lblSend;
    private System.Windows.Forms.Button btnSend;
    private System.Windows.Forms.ComboBox cmbPortName;
    private System.Windows.Forms.ComboBox cmbBaudRate;
    private System.Windows.Forms.RadioButton rbHex;
    private System.Windows.Forms.RadioButton rbText;
    private System.Windows.Forms.GroupBox gbMode;
    private System.Windows.Forms.Label lblComPort;
    private System.Windows.Forms.Label lblBaudRate;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ComboBox cmbParity;
    private System.Windows.Forms.Label lblDataBits;
    private System.Windows.Forms.ComboBox cmbDataBits;
    private System.Windows.Forms.Label lblStopBits;
    private System.Windows.Forms.ComboBox cmbStopBits;
    private System.Windows.Forms.Button btnOpenPort;
      private System.Windows.Forms.GroupBox gbPortSettings;
      private System.Windows.Forms.Button button1_left;
      private System.Windows.Forms.Button button_head;
      private System.Windows.Forms.Button button_right;
      private System.Windows.Forms.Button button_back;
      private System.Windows.Forms.Button button_stop;
      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.Button button1;
  }
}

