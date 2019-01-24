namespace socket
{
    partial class 服务器端
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
            this.btn_Listen = new System.Windows.Forms.Button();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.txtBox_Log = new System.Windows.Forms.TextBox();
            this.txtBox_Msg = new System.Windows.Forms.TextBox();
            this.txtBox_Path = new System.Windows.Forms.TextBox();
            this.btn_Path = new System.Windows.Forms.Button();
            this.btn_SendFile = new System.Windows.Forms.Button();
            this.btn_SendMsg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_IP
            // 
            this.lbl_IP.AutoSize = true;
            this.lbl_IP.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_IP.Location = new System.Drawing.Point(21, 34);
            this.lbl_IP.Name = "lbl_IP";
            this.lbl_IP.Size = new System.Drawing.Size(39, 19);
            this.lbl_IP.TabIndex = 0;
            this.lbl_IP.Text = "IP:";
            // 
            // txtBox_IP
            // 
            this.txtBox_IP.Location = new System.Drawing.Point(58, 32);
            this.txtBox_IP.Name = "txtBox_IP";
            this.txtBox_IP.Size = new System.Drawing.Size(134, 21);
            this.txtBox_IP.TabIndex = 1;
            // 
            // lbl_PORT
            // 
            this.lbl_PORT.AutoSize = true;
            this.lbl_PORT.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_PORT.Location = new System.Drawing.Point(198, 34);
            this.lbl_PORT.Name = "lbl_PORT";
            this.lbl_PORT.Size = new System.Drawing.Size(59, 19);
            this.lbl_PORT.TabIndex = 2;
            this.lbl_PORT.Text = "Port:";
            // 
            // txtBox_Port
            // 
            this.txtBox_Port.Location = new System.Drawing.Point(253, 32);
            this.txtBox_Port.Name = "txtBox_Port";
            this.txtBox_Port.Size = new System.Drawing.Size(53, 21);
            this.txtBox_Port.TabIndex = 3;
            // 
            // btn_Listen
            // 
            this.btn_Listen.Location = new System.Drawing.Point(376, 30);
            this.btn_Listen.Name = "btn_Listen";
            this.btn_Listen.Size = new System.Drawing.Size(105, 23);
            this.btn_Listen.TabIndex = 4;
            this.btn_Listen.Text = "开始监听";
            this.btn_Listen.UseVisualStyleBackColor = true;
            this.btn_Listen.Click += new System.EventHandler(this.btn_Listen_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.Location = new System.Drawing.Point(520, 30);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(105, 23);
            this.btn_Stop.TabIndex = 5;
            this.btn_Stop.Text = "停止监听";
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // txtBox_Log
            // 
            this.txtBox_Log.Location = new System.Drawing.Point(25, 59);
            this.txtBox_Log.Multiline = true;
            this.txtBox_Log.Name = "txtBox_Log";
            this.txtBox_Log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBox_Log.Size = new System.Drawing.Size(600, 147);
            this.txtBox_Log.TabIndex = 7;
            // 
            // txtBox_Msg
            // 
            this.txtBox_Msg.Location = new System.Drawing.Point(25, 212);
            this.txtBox_Msg.Multiline = true;
            this.txtBox_Msg.Name = "txtBox_Msg";
            this.txtBox_Msg.Size = new System.Drawing.Size(600, 112);
            this.txtBox_Msg.TabIndex = 8;
            this.txtBox_Msg.TextChanged += new System.EventHandler(this.txtBox_Msg_TextChanged);
            // 
            // txtBox_Path
            // 
            this.txtBox_Path.Location = new System.Drawing.Point(25, 364);
            this.txtBox_Path.Name = "txtBox_Path";
            this.txtBox_Path.Size = new System.Drawing.Size(376, 21);
            this.txtBox_Path.TabIndex = 9;
            // 
            // btn_Path
            // 
            this.btn_Path.Location = new System.Drawing.Point(440, 362);
            this.btn_Path.Name = "btn_Path";
            this.btn_Path.Size = new System.Drawing.Size(75, 23);
            this.btn_Path.TabIndex = 10;
            this.btn_Path.Text = "选择文件";
            this.btn_Path.UseVisualStyleBackColor = true;
            this.btn_Path.Click += new System.EventHandler(this.btn_Path_Click);
            // 
            // btn_SendFile
            // 
            this.btn_SendFile.Location = new System.Drawing.Point(550, 364);
            this.btn_SendFile.Name = "btn_SendFile";
            this.btn_SendFile.Size = new System.Drawing.Size(75, 23);
            this.btn_SendFile.TabIndex = 11;
            this.btn_SendFile.Text = "发送文件";
            this.btn_SendFile.UseVisualStyleBackColor = true;
            this.btn_SendFile.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_SendMsg
            // 
            this.btn_SendMsg.Location = new System.Drawing.Point(550, 330);
            this.btn_SendMsg.Name = "btn_SendMsg";
            this.btn_SendMsg.Size = new System.Drawing.Size(75, 23);
            this.btn_SendMsg.TabIndex = 12;
            this.btn_SendMsg.Text = "发送消息";
            this.btn_SendMsg.UseVisualStyleBackColor = true;
            this.btn_SendMsg.Click += new System.EventHandler(this.btn_SendMsg_Click);
            // 
            // 服务器端
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 410);
            this.Controls.Add(this.btn_SendMsg);
            this.Controls.Add(this.btn_SendFile);
            this.Controls.Add(this.btn_Path);
            this.Controls.Add(this.txtBox_Path);
            this.Controls.Add(this.txtBox_Msg);
            this.Controls.Add(this.txtBox_Log);
            this.Controls.Add(this.btn_Stop);
            this.Controls.Add(this.btn_Listen);
            this.Controls.Add(this.txtBox_Port);
            this.Controls.Add(this.lbl_PORT);
            this.Controls.Add(this.txtBox_IP);
            this.Controls.Add(this.lbl_IP);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(707, 449);
            this.MinimumSize = new System.Drawing.Size(707, 449);
            this.Name = "服务器端";
            this.Text = "服务器端";
            this.Load += new System.EventHandler(this.服务器端_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_IP;
        private System.Windows.Forms.TextBox txtBox_IP;
        private System.Windows.Forms.Label lbl_PORT;
        private System.Windows.Forms.TextBox txtBox_Port;
        private System.Windows.Forms.Button btn_Listen;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.TextBox txtBox_Log;
        private System.Windows.Forms.TextBox txtBox_Msg;
        private System.Windows.Forms.TextBox txtBox_Path;
        private System.Windows.Forms.Button btn_Path;
        private System.Windows.Forms.Button btn_SendFile;
        private System.Windows.Forms.Button btn_SendMsg;
    }
}

