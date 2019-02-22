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
            this.txtBox_Log = new System.Windows.Forms.TextBox();
            this.txtBox_Msg = new System.Windows.Forms.TextBox();
            this.btn_Send = new System.Windows.Forms.Button();
            this.pic_Receive = new System.Windows.Forms.PictureBox();
            this.txtBox_Path = new System.Windows.Forms.TextBox();
            this.btn_Path = new System.Windows.Forms.Button();
            this.btn_SendFile = new System.Windows.Forms.Button();
            this.btn_SendBigFile = new System.Windows.Forms.Button();
            this.txtBox_IP_2 = new System.Windows.Forms.TextBox();
            this.txtBox_Port_2 = new System.Windows.Forms.TextBox();
            this.btn_Connect_2 = new System.Windows.Forms.Button();
            this.txtBox_Path_2 = new System.Windows.Forms.TextBox();
            this.txtBox_Path_3 = new System.Windows.Forms.TextBox();
            this.txtBox_IP_3 = new System.Windows.Forms.TextBox();
            this.txtBox_Port_3 = new System.Windows.Forms.TextBox();
            this.btn_Connect_3 = new System.Windows.Forms.Button();
            this.btn_Connect_All = new System.Windows.Forms.Button();
            this.btn_Path_2 = new System.Windows.Forms.Button();
            this.btn_Path_3 = new System.Windows.Forms.Button();
            this.btn_SendBigFile_2 = new System.Windows.Forms.Button();
            this.btn_SendBigFile_3 = new System.Windows.Forms.Button();
            this.btn_Send_All = new System.Windows.Forms.Button();
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
            this.txtBox_IP.Location = new System.Drawing.Point(73, 12);
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
            this.txtBox_Port.Location = new System.Drawing.Point(299, 12);
            this.txtBox_Port.Name = "txtBox_Port";
            this.txtBox_Port.Size = new System.Drawing.Size(61, 21);
            this.txtBox_Port.TabIndex = 3;
            this.txtBox_Port.Text = "8234";
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(425, 10);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(91, 23);
            this.btn_Connect.TabIndex = 4;
            this.btn_Connect.Text = "连接";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // txtBox_Log
            // 
            this.txtBox_Log.Location = new System.Drawing.Point(42, 93);
            this.txtBox_Log.Multiline = true;
            this.txtBox_Log.Name = "txtBox_Log";
            this.txtBox_Log.Size = new System.Drawing.Size(318, 92);
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
            this.btn_Send.Location = new System.Drawing.Point(563, 40);
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
            this.pic_Receive.Location = new System.Drawing.Point(379, 93);
            this.pic_Receive.Name = "pic_Receive";
            this.pic_Receive.Size = new System.Drawing.Size(277, 230);
            this.pic_Receive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Receive.TabIndex = 9;
            this.pic_Receive.TabStop = false;
            // 
            // txtBox_Path
            // 
            this.txtBox_Path.Location = new System.Drawing.Point(42, 329);
            this.txtBox_Path.Name = "txtBox_Path";
            this.txtBox_Path.Size = new System.Drawing.Size(318, 21);
            this.txtBox_Path.TabIndex = 10;
            // 
            // btn_Path
            // 
            this.btn_Path.Location = new System.Drawing.Point(379, 329);
            this.btn_Path.Name = "btn_Path";
            this.btn_Path.Size = new System.Drawing.Size(75, 23);
            this.btn_Path.TabIndex = 11;
            this.btn_Path.Text = "选择文件";
            this.btn_Path.UseVisualStyleBackColor = true;
            this.btn_Path.Click += new System.EventHandler(this.btn_Path_Click);
            // 
            // btn_SendFile
            // 
            this.btn_SendFile.Location = new System.Drawing.Point(563, 10);
            this.btn_SendFile.Name = "btn_SendFile";
            this.btn_SendFile.Size = new System.Drawing.Size(75, 23);
            this.btn_SendFile.TabIndex = 12;
            this.btn_SendFile.Text = "发送文件";
            this.btn_SendFile.UseVisualStyleBackColor = true;
            this.btn_SendFile.Click += new System.EventHandler(this.btn_SendFile_Click);
            // 
            // btn_SendBigFile
            // 
            this.btn_SendBigFile.Location = new System.Drawing.Point(470, 329);
            this.btn_SendBigFile.Name = "btn_SendBigFile";
            this.btn_SendBigFile.Size = new System.Drawing.Size(75, 23);
            this.btn_SendBigFile.TabIndex = 13;
            this.btn_SendBigFile.Text = "大文件发送";
            this.btn_SendBigFile.UseVisualStyleBackColor = true;
            this.btn_SendBigFile.Click += new System.EventHandler(this.btn_SendBigFile_Click);
            // 
            // txtBox_IP_2
            // 
            this.txtBox_IP_2.Location = new System.Drawing.Point(73, 40);
            this.txtBox_IP_2.Name = "txtBox_IP_2";
            this.txtBox_IP_2.Size = new System.Drawing.Size(138, 21);
            this.txtBox_IP_2.TabIndex = 14;
            this.txtBox_IP_2.Text = "192.168.0.201";
            // 
            // txtBox_Port_2
            // 
            this.txtBox_Port_2.Location = new System.Drawing.Point(299, 40);
            this.txtBox_Port_2.Name = "txtBox_Port_2";
            this.txtBox_Port_2.Size = new System.Drawing.Size(61, 21);
            this.txtBox_Port_2.TabIndex = 15;
            this.txtBox_Port_2.Text = "8235";
            // 
            // btn_Connect_2
            // 
            this.btn_Connect_2.Location = new System.Drawing.Point(425, 40);
            this.btn_Connect_2.Name = "btn_Connect_2";
            this.btn_Connect_2.Size = new System.Drawing.Size(91, 23);
            this.btn_Connect_2.TabIndex = 16;
            this.btn_Connect_2.Text = "连接";
            this.btn_Connect_2.UseVisualStyleBackColor = true;
            this.btn_Connect_2.Click += new System.EventHandler(this.btn_Connect_2_Click);
            // 
            // txtBox_Path_2
            // 
            this.txtBox_Path_2.Location = new System.Drawing.Point(42, 358);
            this.txtBox_Path_2.Name = "txtBox_Path_2";
            this.txtBox_Path_2.Size = new System.Drawing.Size(318, 21);
            this.txtBox_Path_2.TabIndex = 17;
            // 
            // txtBox_Path_3
            // 
            this.txtBox_Path_3.Location = new System.Drawing.Point(42, 385);
            this.txtBox_Path_3.Name = "txtBox_Path_3";
            this.txtBox_Path_3.Size = new System.Drawing.Size(318, 21);
            this.txtBox_Path_3.TabIndex = 18;
            // 
            // txtBox_IP_3
            // 
            this.txtBox_IP_3.Location = new System.Drawing.Point(73, 68);
            this.txtBox_IP_3.Name = "txtBox_IP_3";
            this.txtBox_IP_3.Size = new System.Drawing.Size(138, 21);
            this.txtBox_IP_3.TabIndex = 19;
            this.txtBox_IP_3.Text = "192.168.0.201";
            // 
            // txtBox_Port_3
            // 
            this.txtBox_Port_3.Location = new System.Drawing.Point(299, 68);
            this.txtBox_Port_3.Name = "txtBox_Port_3";
            this.txtBox_Port_3.Size = new System.Drawing.Size(61, 21);
            this.txtBox_Port_3.TabIndex = 20;
            this.txtBox_Port_3.Text = "8236";
            // 
            // btn_Connect_3
            // 
            this.btn_Connect_3.Location = new System.Drawing.Point(425, 68);
            this.btn_Connect_3.Name = "btn_Connect_3";
            this.btn_Connect_3.Size = new System.Drawing.Size(91, 23);
            this.btn_Connect_3.TabIndex = 21;
            this.btn_Connect_3.Text = "连接";
            this.btn_Connect_3.UseVisualStyleBackColor = true;
            this.btn_Connect_3.Click += new System.EventHandler(this.btn_Connect_3_Click);
            // 
            // btn_Connect_All
            // 
            this.btn_Connect_All.Location = new System.Drawing.Point(563, 68);
            this.btn_Connect_All.Name = "btn_Connect_All";
            this.btn_Connect_All.Size = new System.Drawing.Size(75, 23);
            this.btn_Connect_All.TabIndex = 22;
            this.btn_Connect_All.Text = "全部连接";
            this.btn_Connect_All.UseVisualStyleBackColor = true;
            this.btn_Connect_All.Click += new System.EventHandler(this.btn_Connect_All_Click);
            // 
            // btn_Path_2
            // 
            this.btn_Path_2.Location = new System.Drawing.Point(379, 358);
            this.btn_Path_2.Name = "btn_Path_2";
            this.btn_Path_2.Size = new System.Drawing.Size(75, 23);
            this.btn_Path_2.TabIndex = 23;
            this.btn_Path_2.Text = "选择文件";
            this.btn_Path_2.UseVisualStyleBackColor = true;
            this.btn_Path_2.Click += new System.EventHandler(this.btn_Path_2_Click);
            // 
            // btn_Path_3
            // 
            this.btn_Path_3.Location = new System.Drawing.Point(379, 383);
            this.btn_Path_3.Name = "btn_Path_3";
            this.btn_Path_3.Size = new System.Drawing.Size(75, 23);
            this.btn_Path_3.TabIndex = 24;
            this.btn_Path_3.Text = "选择文件";
            this.btn_Path_3.UseVisualStyleBackColor = true;
            this.btn_Path_3.Click += new System.EventHandler(this.btn_Path_3_Click);
            // 
            // btn_SendBigFile_2
            // 
            this.btn_SendBigFile_2.Location = new System.Drawing.Point(470, 356);
            this.btn_SendBigFile_2.Name = "btn_SendBigFile_2";
            this.btn_SendBigFile_2.Size = new System.Drawing.Size(75, 23);
            this.btn_SendBigFile_2.TabIndex = 25;
            this.btn_SendBigFile_2.Text = "大文件发送";
            this.btn_SendBigFile_2.UseVisualStyleBackColor = true;
            this.btn_SendBigFile_2.Click += new System.EventHandler(this.btn_SendBigFile_2_Click);
            // 
            // btn_SendBigFile_3
            // 
            this.btn_SendBigFile_3.Location = new System.Drawing.Point(470, 383);
            this.btn_SendBigFile_3.Name = "btn_SendBigFile_3";
            this.btn_SendBigFile_3.Size = new System.Drawing.Size(75, 23);
            this.btn_SendBigFile_3.TabIndex = 26;
            this.btn_SendBigFile_3.Text = "大文件发送";
            this.btn_SendBigFile_3.UseVisualStyleBackColor = true;
            this.btn_SendBigFile_3.Click += new System.EventHandler(this.btn_SendBigFile_3_Click);
            // 
            // btn_Send_All
            // 
            this.btn_Send_All.Location = new System.Drawing.Point(563, 329);
            this.btn_Send_All.Name = "btn_Send_All";
            this.btn_Send_All.Size = new System.Drawing.Size(75, 23);
            this.btn_Send_All.TabIndex = 27;
            this.btn_Send_All.Text = "全部发送";
            this.btn_Send_All.UseVisualStyleBackColor = true;
            this.btn_Send_All.Click += new System.EventHandler(this.btn_Send_All_Click);
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 410);
            this.Controls.Add(this.btn_Send_All);
            this.Controls.Add(this.btn_SendBigFile_3);
            this.Controls.Add(this.btn_SendBigFile_2);
            this.Controls.Add(this.btn_Path_3);
            this.Controls.Add(this.btn_Path_2);
            this.Controls.Add(this.btn_Connect_All);
            this.Controls.Add(this.btn_Connect_3);
            this.Controls.Add(this.txtBox_Port_3);
            this.Controls.Add(this.txtBox_IP_3);
            this.Controls.Add(this.txtBox_Path_3);
            this.Controls.Add(this.txtBox_Path_2);
            this.Controls.Add(this.btn_Connect_2);
            this.Controls.Add(this.txtBox_Port_2);
            this.Controls.Add(this.txtBox_IP_2);
            this.Controls.Add(this.btn_SendBigFile);
            this.Controls.Add(this.btn_SendFile);
            this.Controls.Add(this.btn_Path);
            this.Controls.Add(this.txtBox_Path);
            this.Controls.Add(this.pic_Receive);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.txtBox_Msg);
            this.Controls.Add(this.txtBox_Log);
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
        private System.Windows.Forms.TextBox txtBox_Log;
        private System.Windows.Forms.TextBox txtBox_Msg;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.PictureBox pic_Receive;
        private System.Windows.Forms.TextBox txtBox_Path;
        private System.Windows.Forms.Button btn_Path;
        private System.Windows.Forms.Button btn_SendFile;
        private System.Windows.Forms.Button btn_SendBigFile;
        private System.Windows.Forms.TextBox txtBox_IP_2;
        private System.Windows.Forms.TextBox txtBox_Port_2;
        private System.Windows.Forms.Button btn_Connect_2;
        private System.Windows.Forms.TextBox txtBox_Path_2;
        private System.Windows.Forms.TextBox txtBox_Path_3;
        private System.Windows.Forms.TextBox txtBox_IP_3;
        private System.Windows.Forms.TextBox txtBox_Port_3;
        private System.Windows.Forms.Button btn_Connect_3;
        private System.Windows.Forms.Button btn_Connect_All;
        private System.Windows.Forms.Button btn_Path_2;
        private System.Windows.Forms.Button btn_Path_3;
        private System.Windows.Forms.Button btn_SendBigFile_2;
        private System.Windows.Forms.Button btn_SendBigFile_3;
        private System.Windows.Forms.Button btn_Send_All;
    }
}

