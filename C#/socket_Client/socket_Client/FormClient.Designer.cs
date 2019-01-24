namespace socket_Client
{
    partial class FormClient
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
            this.lbl_IP = new System.Windows.Forms.Label();
            this.txtBox_IP = new System.Windows.Forms.TextBox();
            this.lbl_PORT = new System.Windows.Forms.Label();
            this.txtBox_Port = new System.Windows.Forms.TextBox();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.btn_Disconnect = new System.Windows.Forms.Button();
            this.txtBox_Log = new System.Windows.Forms.TextBox();
            this.txtBox_Msg = new System.Windows.Forms.TextBox();
            this.btn_Send = new System.Windows.Forms.Button();
            this.pic_Receive = new System.Windows.Forms.PictureBox();
            this.txtBox_Path = new System.Windows.Forms.TextBox();
            this.btn_Path = new System.Windows.Forms.Button();
            this.btn_SendFile = new System.Windows.Forms.Button();
            this.btn_SendBigFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Receive)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_IP
            // 
            this.lbl_IP.AutoSize = true;
            this.lbl_IP.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_IP.Location = new System.Drawing.Point(40, 30);
            this.lbl_IP.Name = "lbl_IP";
            this.lbl_IP.Size = new System.Drawing.Size(39, 19);
            this.lbl_IP.TabIndex = 0;
            this.lbl_IP.Text = "IP:";
            // 
            // txtBox_IP
            // 
            this.txtBox_IP.Location = new System.Drawing.Point(76, 29);
            this.txtBox_IP.Name = "txtBox_IP";
            this.txtBox_IP.Size = new System.Drawing.Size(138, 21);
            this.txtBox_IP.TabIndex = 1;
            this.txtBox_IP.Text = "192.168.0.201";
            // 
            // lbl_PORT
            // 
            this.lbl_PORT.AutoSize = true;
            this.lbl_PORT.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_PORT.Location = new System.Drawing.Point(234, 28);
            this.lbl_PORT.Name = "lbl_PORT";
            this.lbl_PORT.Size = new System.Drawing.Size(59, 19);
            this.lbl_PORT.TabIndex = 2;
            this.lbl_PORT.Text = "Port:";
            // 
            // txtBox_Port
            // 
            this.txtBox_Port.Location = new System.Drawing.Point(299, 28);
            this.txtBox_Port.Name = "txtBox_Port";
            this.txtBox_Port.Size = new System.Drawing.Size(61, 21);
            this.txtBox_Port.TabIndex = 3;
            this.txtBox_Port.Text = "8234";
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(420, 24);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(91, 23);
            this.btn_Connect.TabIndex = 4;
            this.btn_Connect.Text = "连接";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // btn_Disconnect
            // 
            this.btn_Disconnect.Location = new System.Drawing.Point(544, 24);
            this.btn_Disconnect.Name = "btn_Disconnect";
            this.btn_Disconnect.Size = new System.Drawing.Size(94, 23);
            this.btn_Disconnect.TabIndex = 5;
            this.btn_Disconnect.Text = "断开连接";
            this.btn_Disconnect.UseVisualStyleBackColor = true;
            this.btn_Disconnect.Click += new System.EventHandler(this.btn_Disconnect_Click);
            // 
            // txtBox_Log
            // 
            this.txtBox_Log.Location = new System.Drawing.Point(42, 70);
            this.txtBox_Log.Multiline = true;
            this.txtBox_Log.Name = "txtBox_Log";
            this.txtBox_Log.Size = new System.Drawing.Size(318, 115);
            this.txtBox_Log.TabIndex = 6;
            // 
            // txtBox_Msg
            // 
            this.txtBox_Msg.Location = new System.Drawing.Point(42, 206);
            this.txtBox_Msg.Multiline = true;
            this.txtBox_Msg.Name = "txtBox_Msg";
            this.txtBox_Msg.Size = new System.Drawing.Size(318, 117);
            this.txtBox_Msg.TabIndex = 7;
            // 
            // btn_Send
            // 
            this.btn_Send.Location = new System.Drawing.Point(581, 341);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(75, 23);
            this.btn_Send.TabIndex = 8;
            this.btn_Send.Text = "发送消息";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // pic_Receive
            // 
            this.pic_Receive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_Receive.ErrorImage = null;
            this.pic_Receive.InitialImage = null;
            this.pic_Receive.Location = new System.Drawing.Point(379, 70);
            this.pic_Receive.Name = "pic_Receive";
            this.pic_Receive.Size = new System.Drawing.Size(277, 253);
            this.pic_Receive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Receive.TabIndex = 9;
            this.pic_Receive.TabStop = false;
            // 
            // txtBox_Path
            // 
            this.txtBox_Path.Location = new System.Drawing.Point(42, 344);
            this.txtBox_Path.Name = "txtBox_Path";
            this.txtBox_Path.Size = new System.Drawing.Size(318, 21);
            this.txtBox_Path.TabIndex = 10;
            // 
            // btn_Path
            // 
            this.btn_Path.Location = new System.Drawing.Point(379, 341);
            this.btn_Path.Name = "btn_Path";
            this.btn_Path.Size = new System.Drawing.Size(75, 23);
            this.btn_Path.TabIndex = 11;
            this.btn_Path.Text = "选择文件";
            this.btn_Path.UseVisualStyleBackColor = true;
            this.btn_Path.Click += new System.EventHandler(this.btn_Path_Click);
            // 
            // btn_SendFile
            // 
            this.btn_SendFile.Location = new System.Drawing.Point(480, 342);
            this.btn_SendFile.Name = "btn_SendFile";
            this.btn_SendFile.Size = new System.Drawing.Size(75, 23);
            this.btn_SendFile.TabIndex = 12;
            this.btn_SendFile.Text = "发送文件";
            this.btn_SendFile.UseVisualStyleBackColor = true;
            this.btn_SendFile.Click += new System.EventHandler(this.btn_SendFile_Click);
            // 
            // btn_SendBigFile
            // 
            this.btn_SendBigFile.Location = new System.Drawing.Point(379, 371);
            this.btn_SendBigFile.Name = "btn_SendBigFile";
            this.btn_SendBigFile.Size = new System.Drawing.Size(176, 23);
            this.btn_SendBigFile.TabIndex = 13;
            this.btn_SendBigFile.Text = "大文件发送";
            this.btn_SendBigFile.UseVisualStyleBackColor = true;
            this.btn_SendBigFile.Click += new System.EventHandler(this.btn_SendBigFile_Click);
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 410);
            this.Controls.Add(this.btn_SendBigFile);
            this.Controls.Add(this.btn_SendFile);
            this.Controls.Add(this.btn_Path);
            this.Controls.Add(this.txtBox_Path);
            this.Controls.Add(this.pic_Receive);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.txtBox_Msg);
            this.Controls.Add(this.txtBox_Log);
            this.Controls.Add(this.btn_Disconnect);
            this.Controls.Add(this.btn_Connect);
            this.Controls.Add(this.txtBox_Port);
            this.Controls.Add(this.lbl_PORT);
            this.Controls.Add(this.txtBox_IP);
            this.Controls.Add(this.lbl_IP);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(707, 449);
            this.MinimumSize = new System.Drawing.Size(707, 449);
            this.Name = "FormClient";
            this.Text = "客户端";
            this.Load += new System.EventHandler(this.FormClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Receive)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_IP;
        private System.Windows.Forms.TextBox txtBox_IP;
        private System.Windows.Forms.Label lbl_PORT;
        private System.Windows.Forms.TextBox txtBox_Port;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.Button btn_Disconnect;
        private System.Windows.Forms.TextBox txtBox_Log;
        private System.Windows.Forms.TextBox txtBox_Msg;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.PictureBox pic_Receive;
        private System.Windows.Forms.TextBox txtBox_Path;
        private System.Windows.Forms.Button btn_Path;
        private System.Windows.Forms.Button btn_SendFile;
        private System.Windows.Forms.Button btn_SendBigFile;
    }
}

