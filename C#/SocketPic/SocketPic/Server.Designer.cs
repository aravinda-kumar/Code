namespace SocketPic
{
    partial class Server
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtBox_IP = new System.Windows.Forms.TextBox();
            this.txtBox_Port = new System.Windows.Forms.TextBox();
            this.btn_Watch = new System.Windows.Forms.Button();
            this.pic_Load = new System.Windows.Forms.PictureBox();
            this.txtBox_Log = new System.Windows.Forms.TextBox();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.list_Pics = new System.Windows.Forms.ListBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btn_Fresh = new System.Windows.Forms.Button();
            this.progressBar_PicLoad = new System.Windows.Forms.ProgressBar();
            this.txtBox_Msg = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Load)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBox_IP
            // 
            this.txtBox_IP.Location = new System.Drawing.Point(34, 34);
            this.txtBox_IP.Name = "txtBox_IP";
            this.txtBox_IP.Size = new System.Drawing.Size(128, 21);
            this.txtBox_IP.TabIndex = 0;
            this.txtBox_IP.Text = "192.168.0.201";
            // 
            // txtBox_Port
            // 
            this.txtBox_Port.Location = new System.Drawing.Point(188, 34);
            this.txtBox_Port.Name = "txtBox_Port";
            this.txtBox_Port.Size = new System.Drawing.Size(66, 21);
            this.txtBox_Port.TabIndex = 1;
            this.txtBox_Port.Text = "8234";
            // 
            // btn_Watch
            // 
            this.btn_Watch.Location = new System.Drawing.Point(279, 34);
            this.btn_Watch.Name = "btn_Watch";
            this.btn_Watch.Size = new System.Drawing.Size(75, 23);
            this.btn_Watch.TabIndex = 2;
            this.btn_Watch.Text = "开始监听";
            this.btn_Watch.UseVisualStyleBackColor = true;
            this.btn_Watch.Click += new System.EventHandler(this.btn_Watch_Click);
            // 
            // pic_Load
            // 
            this.pic_Load.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic_Load.Location = new System.Drawing.Point(398, 74);
            this.pic_Load.Name = "pic_Load";
            this.pic_Load.Size = new System.Drawing.Size(433, 293);
            this.pic_Load.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Load.TabIndex = 3;
            this.pic_Load.TabStop = false;
            // 
            // txtBox_Log
            // 
            this.txtBox_Log.Location = new System.Drawing.Point(34, 74);
            this.txtBox_Log.Multiline = true;
            this.txtBox_Log.Name = "txtBox_Log";
            this.txtBox_Log.Size = new System.Drawing.Size(358, 67);
            this.txtBox_Log.TabIndex = 4;
            // 
            // btn_Stop
            // 
            this.btn_Stop.Location = new System.Drawing.Point(392, 34);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(75, 23);
            this.btn_Stop.TabIndex = 5;
            this.btn_Stop.Text = "停止监听";
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // list_Pics
            // 
            this.list_Pics.FormattingEnabled = true;
            this.list_Pics.ItemHeight = 12;
            this.list_Pics.Location = new System.Drawing.Point(34, 147);
            this.list_Pics.Name = "list_Pics";
            this.list_Pics.ScrollAlwaysVisible = true;
            this.list_Pics.Size = new System.Drawing.Size(358, 160);
            this.list_Pics.TabIndex = 6;
            this.list_Pics.SelectedIndexChanged += new System.EventHandler(this.list_Pics_SelectedIndexChanged);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 60000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btn_Fresh
            // 
            this.btn_Fresh.Location = new System.Drawing.Point(506, 32);
            this.btn_Fresh.Name = "btn_Fresh";
            this.btn_Fresh.Size = new System.Drawing.Size(75, 23);
            this.btn_Fresh.TabIndex = 7;
            this.btn_Fresh.Text = "刷新";
            this.btn_Fresh.UseVisualStyleBackColor = true;
            this.btn_Fresh.Click += new System.EventHandler(this.btn_Fresh_Click);
            // 
            // progressBar_PicLoad
            // 
            this.progressBar_PicLoad.Location = new System.Drawing.Point(399, 373);
            this.progressBar_PicLoad.Name = "progressBar_PicLoad";
            this.progressBar_PicLoad.Size = new System.Drawing.Size(432, 23);
            this.progressBar_PicLoad.Step = 1;
            this.progressBar_PicLoad.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar_PicLoad.TabIndex = 8;
            // 
            // txtBox_Msg
            // 
            this.txtBox_Msg.Location = new System.Drawing.Point(34, 314);
            this.txtBox_Msg.Multiline = true;
            this.txtBox_Msg.Name = "txtBox_Msg";
            this.txtBox_Msg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBox_Msg.Size = new System.Drawing.Size(358, 82);
            this.txtBox_Msg.TabIndex = 9;
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 425);
            this.Controls.Add(this.txtBox_Msg);
            this.Controls.Add(this.progressBar_PicLoad);
            this.Controls.Add(this.btn_Fresh);
            this.Controls.Add(this.list_Pics);
            this.Controls.Add(this.btn_Stop);
            this.Controls.Add(this.txtBox_Log);
            this.Controls.Add(this.pic_Load);
            this.Controls.Add(this.btn_Watch);
            this.Controls.Add(this.txtBox_Port);
            this.Controls.Add(this.txtBox_IP);
            this.Name = "Server";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Load)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_IP;
        private System.Windows.Forms.TextBox txtBox_Port;
        private System.Windows.Forms.Button btn_Watch;
        private System.Windows.Forms.PictureBox pic_Load;
        private System.Windows.Forms.TextBox txtBox_Log;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.ListBox list_Pics;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btn_Fresh;
        private System.Windows.Forms.ProgressBar progressBar_PicLoad;
        private System.Windows.Forms.TextBox txtBox_Msg;
    }
}

