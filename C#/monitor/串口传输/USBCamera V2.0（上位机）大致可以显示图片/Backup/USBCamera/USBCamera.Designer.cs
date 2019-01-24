namespace USBCamera
{
    partial class USBCamera
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
            System.Windows.Forms.Button 打开usb;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(USBCamera));
            this.关闭usb = new System.Windows.Forms.Button();
            this.usb连续传输图像 = new System.Windows.Forms.Button();
            this.usb传图 = new System.Windows.Forms.Button();
            this.comboBox_Device = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label_Device = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            打开usb = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // 打开usb
            // 
            打开usb.Location = new System.Drawing.Point(153, 16);
            打开usb.Name = "打开usb";
            打开usb.Size = new System.Drawing.Size(64, 21);
            打开usb.TabIndex = 25;
            打开usb.Text = "&打开USB";
            打开usb.UseVisualStyleBackColor = true;
            打开usb.Click += new System.EventHandler(this.打开usb_Click);
            // 
            // 关闭usb
            // 
            this.关闭usb.Location = new System.Drawing.Point(223, 17);
            this.关闭usb.Name = "关闭usb";
            this.关闭usb.Size = new System.Drawing.Size(64, 20);
            this.关闭usb.TabIndex = 31;
            this.关闭usb.Text = "关闭usb";
            this.关闭usb.UseVisualStyleBackColor = true;
            this.关闭usb.Click += new System.EventHandler(this.关闭usb_Click);
            // 
            // usb连续传输图像
            // 
            this.usb连续传输图像.Enabled = false;
            this.usb连续传输图像.Location = new System.Drawing.Point(293, 16);
            this.usb连续传输图像.Name = "usb连续传输图像";
            this.usb连续传输图像.Size = new System.Drawing.Size(83, 21);
            this.usb连续传输图像.TabIndex = 30;
            this.usb连续传输图像.Text = "usb连续采集";
            this.usb连续传输图像.UseVisualStyleBackColor = true;
            this.usb连续传输图像.Click += new System.EventHandler(this.usb连续传输图像_Click);
            // 
            // usb传图
            // 
            this.usb传图.Enabled = false;
            this.usb传图.Location = new System.Drawing.Point(382, 16);
            this.usb传图.Name = "usb传图";
            this.usb传图.Size = new System.Drawing.Size(84, 21);
            this.usb传图.TabIndex = 26;
            this.usb传图.Text = "usb单幅采集";
            this.usb传图.UseVisualStyleBackColor = true;
            this.usb传图.Click += new System.EventHandler(this.usb传图_Click);
            // 
            // comboBox_Device
            // 
            this.comboBox_Device.FormattingEnabled = true;
            this.comboBox_Device.Location = new System.Drawing.Point(64, 17);
            this.comboBox_Device.Name = "comboBox_Device";
            this.comboBox_Device.Size = new System.Drawing.Size(83, 20);
            this.comboBox_Device.TabIndex = 23;
            this.comboBox_Device.Text = "None Available";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox4.Controls.Add(this.关闭usb);
            this.groupBox4.Controls.Add(this.usb连续传输图像);
            this.groupBox4.Controls.Add(this.usb传图);
            this.groupBox4.Controls.Add(this.comboBox_Device);
            this.groupBox4.Controls.Add(this.label_Device);
            this.groupBox4.Controls.Add(打开usb);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox4.Location = new System.Drawing.Point(9, 357);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(473, 50);
            this.groupBox4.TabIndex = 32;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "usb控制";
            // 
            // label_Device
            // 
            this.label_Device.AutoSize = true;
            this.label_Device.Location = new System.Drawing.Point(11, 25);
            this.label_Device.Name = "label_Device";
            this.label_Device.Size = new System.Drawing.Size(47, 12);
            this.label_Device.TabIndex = 24;
            this.label_Device.Text = "Device:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.编辑ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(484, 24);
            this.menuStrip1.TabIndex = 34;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 编辑ToolStripMenuItem
            // 
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.编辑ToolStripMenuItem.Text = "编辑";
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(73, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(324, 244);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // 骑飞USBCamera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 419);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "骑飞USBCamera";
            this.Text = "骑飞USBCamera2.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button 关闭usb;
        private System.Windows.Forms.Button usb连续传输图像;
        private System.Windows.Forms.Button usb传图;
        private System.Windows.Forms.ComboBox comboBox_Device;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label_Device;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑ToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

