namespace Question2
{
    partial class Frm_Client
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
            this.components = new System.ComponentModel.Container();
            this.txtbox_Port = new System.Windows.Forms.TextBox();
            this.lbl_Port = new System.Windows.Forms.Label();
            this.txtbox_IP = new System.Windows.Forms.TextBox();
            this.lbl_IP = new System.Windows.Forms.Label();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.btn_Cut = new System.Windows.Forms.Button();
            this.lbl_Data = new System.Windows.Forms.Label();
            this.listView_Msg = new System.Windows.Forms.ListView();
            this.btn_Send = new System.Windows.Forms.Button();
            this.txtbox_c4a4 = new System.Windows.Forms.TextBox();
            this.txtbox_c3a4 = new System.Windows.Forms.TextBox();
            this.txtbox_c2a4 = new System.Windows.Forms.TextBox();
            this.txtbox_c1a4 = new System.Windows.Forms.TextBox();
            this.txtbox_c4a3 = new System.Windows.Forms.TextBox();
            this.txtbox_c3a3 = new System.Windows.Forms.TextBox();
            this.txtbox_c2a3 = new System.Windows.Forms.TextBox();
            this.txtbox_c1a3 = new System.Windows.Forms.TextBox();
            this.txtbox_c4a2 = new System.Windows.Forms.TextBox();
            this.txtbox_c3a2 = new System.Windows.Forms.TextBox();
            this.txtbox_c2a2 = new System.Windows.Forms.TextBox();
            this.txtbox_c1a2 = new System.Windows.Forms.TextBox();
            this.txtbox_c4a1 = new System.Windows.Forms.TextBox();
            this.txtbox_c3a1 = new System.Windows.Forms.TextBox();
            this.txtbox_c2a1 = new System.Windows.Forms.TextBox();
            this.txtbox_c1a1 = new System.Windows.Forms.TextBox();
            this.cbbox_c4s2 = new System.Windows.Forms.ComboBox();
            this.cbbox_c3s2 = new System.Windows.Forms.ComboBox();
            this.cbbox_c2s2 = new System.Windows.Forms.ComboBox();
            this.cbbox_c4s1 = new System.Windows.Forms.ComboBox();
            this.cbbox_c3s1 = new System.Windows.Forms.ComboBox();
            this.cbbox_c2s1 = new System.Windows.Forms.ComboBox();
            this.cbbox_c1s2 = new System.Windows.Forms.ComboBox();
            this.cbbox_c1s1 = new System.Windows.Forms.ComboBox();
            this.lbl_Analog4 = new System.Windows.Forms.Label();
            this.lbl_Analog3 = new System.Windows.Forms.Label();
            this.lbl_Analog2 = new System.Windows.Forms.Label();
            this.lbl_Analog1 = new System.Windows.Forms.Label();
            this.lbl_Swtich2 = new System.Windows.Forms.Label();
            this.lbl_Swtich1 = new System.Windows.Forms.Label();
            this.lbl_Cat4 = new System.Windows.Forms.Label();
            this.lbl_Cat3 = new System.Windows.Forms.Label();
            this.lbl_Cat2 = new System.Windows.Forms.Label();
            this.lbl_Cat1 = new System.Windows.Forms.Label();
            this.lbl_State = new System.Windows.Forms.Label();
            this.timer_Socket = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txtbox_Port
            // 
            this.txtbox_Port.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtbox_Port.Location = new System.Drawing.Point(356, 13);
            this.txtbox_Port.Name = "txtbox_Port";
            this.txtbox_Port.Size = new System.Drawing.Size(71, 26);
            this.txtbox_Port.TabIndex = 7;
            this.txtbox_Port.Text = "50000";
            // 
            // lbl_Port
            // 
            this.lbl_Port.AutoSize = true;
            this.lbl_Port.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Port.Location = new System.Drawing.Point(252, 14);
            this.lbl_Port.Name = "lbl_Port";
            this.lbl_Port.Size = new System.Drawing.Size(83, 20);
            this.lbl_Port.TabIndex = 6;
            this.lbl_Port.Text = "端口号:";
            // 
            // txtbox_IP
            // 
            this.txtbox_IP.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtbox_IP.Location = new System.Drawing.Point(60, 12);
            this.txtbox_IP.Name = "txtbox_IP";
            this.txtbox_IP.Size = new System.Drawing.Size(151, 26);
            this.txtbox_IP.TabIndex = 5;
            this.txtbox_IP.Text = "127.0.0.1";
            // 
            // lbl_IP
            // 
            this.lbl_IP.AutoSize = true;
            this.lbl_IP.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_IP.Location = new System.Drawing.Point(12, 15);
            this.lbl_IP.Name = "lbl_IP";
            this.lbl_IP.Size = new System.Drawing.Size(42, 20);
            this.lbl_IP.TabIndex = 4;
            this.lbl_IP.Text = "IP:";
            // 
            // btn_Connect
            // 
            this.btn_Connect.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Connect.Location = new System.Drawing.Point(451, 12);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(93, 27);
            this.btn_Connect.TabIndex = 8;
            this.btn_Connect.Text = "请求连接";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // btn_Cut
            // 
            this.btn_Cut.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Cut.Location = new System.Drawing.Point(570, 11);
            this.btn_Cut.Name = "btn_Cut";
            this.btn_Cut.Size = new System.Drawing.Size(93, 27);
            this.btn_Cut.TabIndex = 9;
            this.btn_Cut.Text = "断开连接";
            this.btn_Cut.UseVisualStyleBackColor = true;
            this.btn_Cut.Click += new System.EventHandler(this.btn_Cut_Click);
            // 
            // lbl_Data
            // 
            this.lbl_Data.AutoSize = true;
            this.lbl_Data.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Data.Location = new System.Drawing.Point(12, 60);
            this.lbl_Data.Name = "lbl_Data";
            this.lbl_Data.Size = new System.Drawing.Size(114, 20);
            this.lbl_Data.TabIndex = 10;
            this.lbl_Data.Text = "数据信息：";
            // 
            // listView_Msg
            // 
            this.listView_Msg.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listView_Msg.Location = new System.Drawing.Point(12, 83);
            this.listView_Msg.Name = "listView_Msg";
            this.listView_Msg.Size = new System.Drawing.Size(1045, 343);
            this.listView_Msg.TabIndex = 11;
            this.listView_Msg.UseCompatibleStateImageBehavior = false;
            // 
            // btn_Send
            // 
            this.btn_Send.Font = new System.Drawing.Font("宋体", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Send.Location = new System.Drawing.Point(906, 469);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(151, 136);
            this.btn_Send.TabIndex = 80;
            this.btn_Send.Text = "发送数据";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // txtbox_c4a4
            // 
            this.txtbox_c4a4.Location = new System.Drawing.Point(800, 584);
            this.txtbox_c4a4.Name = "txtbox_c4a4";
            this.txtbox_c4a4.Size = new System.Drawing.Size(100, 21);
            this.txtbox_c4a4.TabIndex = 79;
            this.txtbox_c4a4.Text = "0";
            // 
            // txtbox_c3a4
            // 
            this.txtbox_c3a4.Location = new System.Drawing.Point(800, 545);
            this.txtbox_c3a4.Name = "txtbox_c3a4";
            this.txtbox_c3a4.Size = new System.Drawing.Size(100, 21);
            this.txtbox_c3a4.TabIndex = 78;
            this.txtbox_c3a4.Text = "0";
            // 
            // txtbox_c2a4
            // 
            this.txtbox_c2a4.Location = new System.Drawing.Point(800, 508);
            this.txtbox_c2a4.Name = "txtbox_c2a4";
            this.txtbox_c2a4.Size = new System.Drawing.Size(100, 21);
            this.txtbox_c2a4.TabIndex = 77;
            this.txtbox_c2a4.Text = "0";
            // 
            // txtbox_c1a4
            // 
            this.txtbox_c1a4.Location = new System.Drawing.Point(800, 474);
            this.txtbox_c1a4.Name = "txtbox_c1a4";
            this.txtbox_c1a4.Size = new System.Drawing.Size(100, 21);
            this.txtbox_c1a4.TabIndex = 76;
            this.txtbox_c1a4.Text = "0";
            // 
            // txtbox_c4a3
            // 
            this.txtbox_c4a3.Location = new System.Drawing.Point(664, 584);
            this.txtbox_c4a3.Name = "txtbox_c4a3";
            this.txtbox_c4a3.Size = new System.Drawing.Size(100, 21);
            this.txtbox_c4a3.TabIndex = 75;
            this.txtbox_c4a3.Text = "0";
            // 
            // txtbox_c3a3
            // 
            this.txtbox_c3a3.Location = new System.Drawing.Point(664, 545);
            this.txtbox_c3a3.Name = "txtbox_c3a3";
            this.txtbox_c3a3.Size = new System.Drawing.Size(100, 21);
            this.txtbox_c3a3.TabIndex = 74;
            this.txtbox_c3a3.Text = "0";
            // 
            // txtbox_c2a3
            // 
            this.txtbox_c2a3.Location = new System.Drawing.Point(664, 508);
            this.txtbox_c2a3.Name = "txtbox_c2a3";
            this.txtbox_c2a3.Size = new System.Drawing.Size(100, 21);
            this.txtbox_c2a3.TabIndex = 73;
            this.txtbox_c2a3.Text = "0";
            // 
            // txtbox_c1a3
            // 
            this.txtbox_c1a3.Location = new System.Drawing.Point(664, 474);
            this.txtbox_c1a3.Name = "txtbox_c1a3";
            this.txtbox_c1a3.Size = new System.Drawing.Size(100, 21);
            this.txtbox_c1a3.TabIndex = 72;
            this.txtbox_c1a3.Text = "0";
            // 
            // txtbox_c4a2
            // 
            this.txtbox_c4a2.Location = new System.Drawing.Point(528, 584);
            this.txtbox_c4a2.Name = "txtbox_c4a2";
            this.txtbox_c4a2.Size = new System.Drawing.Size(100, 21);
            this.txtbox_c4a2.TabIndex = 71;
            this.txtbox_c4a2.Text = "0";
            // 
            // txtbox_c3a2
            // 
            this.txtbox_c3a2.Location = new System.Drawing.Point(528, 545);
            this.txtbox_c3a2.Name = "txtbox_c3a2";
            this.txtbox_c3a2.Size = new System.Drawing.Size(100, 21);
            this.txtbox_c3a2.TabIndex = 70;
            this.txtbox_c3a2.Text = "0";
            // 
            // txtbox_c2a2
            // 
            this.txtbox_c2a2.Location = new System.Drawing.Point(528, 508);
            this.txtbox_c2a2.Name = "txtbox_c2a2";
            this.txtbox_c2a2.Size = new System.Drawing.Size(100, 21);
            this.txtbox_c2a2.TabIndex = 69;
            this.txtbox_c2a2.Text = "0";
            // 
            // txtbox_c1a2
            // 
            this.txtbox_c1a2.Location = new System.Drawing.Point(528, 474);
            this.txtbox_c1a2.Name = "txtbox_c1a2";
            this.txtbox_c1a2.Size = new System.Drawing.Size(100, 21);
            this.txtbox_c1a2.TabIndex = 68;
            this.txtbox_c1a2.Text = "0";
            // 
            // txtbox_c4a1
            // 
            this.txtbox_c4a1.Location = new System.Drawing.Point(392, 584);
            this.txtbox_c4a1.Name = "txtbox_c4a1";
            this.txtbox_c4a1.Size = new System.Drawing.Size(100, 21);
            this.txtbox_c4a1.TabIndex = 67;
            this.txtbox_c4a1.Text = "0";
            // 
            // txtbox_c3a1
            // 
            this.txtbox_c3a1.Location = new System.Drawing.Point(392, 545);
            this.txtbox_c3a1.Name = "txtbox_c3a1";
            this.txtbox_c3a1.Size = new System.Drawing.Size(100, 21);
            this.txtbox_c3a1.TabIndex = 66;
            this.txtbox_c3a1.Text = "0";
            // 
            // txtbox_c2a1
            // 
            this.txtbox_c2a1.Location = new System.Drawing.Point(392, 508);
            this.txtbox_c2a1.Name = "txtbox_c2a1";
            this.txtbox_c2a1.Size = new System.Drawing.Size(100, 21);
            this.txtbox_c2a1.TabIndex = 65;
            this.txtbox_c2a1.Text = "0";
            // 
            // txtbox_c1a1
            // 
            this.txtbox_c1a1.Location = new System.Drawing.Point(392, 474);
            this.txtbox_c1a1.Name = "txtbox_c1a1";
            this.txtbox_c1a1.Size = new System.Drawing.Size(100, 21);
            this.txtbox_c1a1.TabIndex = 64;
            this.txtbox_c1a1.Text = "0";
            // 
            // cbbox_c4s2
            // 
            this.cbbox_c4s2.FormattingEnabled = true;
            this.cbbox_c4s2.Location = new System.Drawing.Point(242, 584);
            this.cbbox_c4s2.Name = "cbbox_c4s2";
            this.cbbox_c4s2.Size = new System.Drawing.Size(121, 20);
            this.cbbox_c4s2.TabIndex = 63;
            // 
            // cbbox_c3s2
            // 
            this.cbbox_c3s2.FormattingEnabled = true;
            this.cbbox_c3s2.Location = new System.Drawing.Point(242, 545);
            this.cbbox_c3s2.Name = "cbbox_c3s2";
            this.cbbox_c3s2.Size = new System.Drawing.Size(121, 20);
            this.cbbox_c3s2.TabIndex = 62;
            // 
            // cbbox_c2s2
            // 
            this.cbbox_c2s2.FormattingEnabled = true;
            this.cbbox_c2s2.Location = new System.Drawing.Point(242, 508);
            this.cbbox_c2s2.Name = "cbbox_c2s2";
            this.cbbox_c2s2.Size = new System.Drawing.Size(121, 20);
            this.cbbox_c2s2.TabIndex = 61;
            // 
            // cbbox_c4s1
            // 
            this.cbbox_c4s1.FormattingEnabled = true;
            this.cbbox_c4s1.Location = new System.Drawing.Point(106, 584);
            this.cbbox_c4s1.Name = "cbbox_c4s1";
            this.cbbox_c4s1.Size = new System.Drawing.Size(121, 20);
            this.cbbox_c4s1.TabIndex = 60;
            // 
            // cbbox_c3s1
            // 
            this.cbbox_c3s1.FormattingEnabled = true;
            this.cbbox_c3s1.Location = new System.Drawing.Point(106, 545);
            this.cbbox_c3s1.Name = "cbbox_c3s1";
            this.cbbox_c3s1.Size = new System.Drawing.Size(121, 20);
            this.cbbox_c3s1.TabIndex = 59;
            // 
            // cbbox_c2s1
            // 
            this.cbbox_c2s1.FormattingEnabled = true;
            this.cbbox_c2s1.Location = new System.Drawing.Point(106, 508);
            this.cbbox_c2s1.Name = "cbbox_c2s1";
            this.cbbox_c2s1.Size = new System.Drawing.Size(121, 20);
            this.cbbox_c2s1.TabIndex = 58;
            // 
            // cbbox_c1s2
            // 
            this.cbbox_c1s2.FormattingEnabled = true;
            this.cbbox_c1s2.Location = new System.Drawing.Point(242, 474);
            this.cbbox_c1s2.Name = "cbbox_c1s2";
            this.cbbox_c1s2.Size = new System.Drawing.Size(121, 20);
            this.cbbox_c1s2.TabIndex = 57;
            // 
            // cbbox_c1s1
            // 
            this.cbbox_c1s1.FormattingEnabled = true;
            this.cbbox_c1s1.Location = new System.Drawing.Point(106, 474);
            this.cbbox_c1s1.Name = "cbbox_c1s1";
            this.cbbox_c1s1.Size = new System.Drawing.Size(121, 20);
            this.cbbox_c1s1.TabIndex = 56;
            // 
            // lbl_Analog4
            // 
            this.lbl_Analog4.AutoSize = true;
            this.lbl_Analog4.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Analog4.Location = new System.Drawing.Point(796, 433);
            this.lbl_Analog4.Name = "lbl_Analog4";
            this.lbl_Analog4.Size = new System.Drawing.Size(111, 24);
            this.lbl_Analog4.TabIndex = 55;
            this.lbl_Analog4.Text = "模拟量4:";
            // 
            // lbl_Analog3
            // 
            this.lbl_Analog3.AutoSize = true;
            this.lbl_Analog3.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Analog3.Location = new System.Drawing.Point(660, 433);
            this.lbl_Analog3.Name = "lbl_Analog3";
            this.lbl_Analog3.Size = new System.Drawing.Size(111, 24);
            this.lbl_Analog3.TabIndex = 54;
            this.lbl_Analog3.Text = "模拟量3:";
            // 
            // lbl_Analog2
            // 
            this.lbl_Analog2.AutoSize = true;
            this.lbl_Analog2.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Analog2.Location = new System.Drawing.Point(524, 433);
            this.lbl_Analog2.Name = "lbl_Analog2";
            this.lbl_Analog2.Size = new System.Drawing.Size(111, 24);
            this.lbl_Analog2.TabIndex = 53;
            this.lbl_Analog2.Text = "模拟量2:";
            // 
            // lbl_Analog1
            // 
            this.lbl_Analog1.AutoSize = true;
            this.lbl_Analog1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Analog1.Location = new System.Drawing.Point(388, 433);
            this.lbl_Analog1.Name = "lbl_Analog1";
            this.lbl_Analog1.Size = new System.Drawing.Size(111, 24);
            this.lbl_Analog1.TabIndex = 52;
            this.lbl_Analog1.Text = "模拟量1:";
            // 
            // lbl_Swtich2
            // 
            this.lbl_Swtich2.AutoSize = true;
            this.lbl_Swtich2.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Swtich2.Location = new System.Drawing.Point(252, 433);
            this.lbl_Swtich2.Name = "lbl_Swtich2";
            this.lbl_Swtich2.Size = new System.Drawing.Size(111, 24);
            this.lbl_Swtich2.TabIndex = 51;
            this.lbl_Swtich2.Text = "开关量2:";
            // 
            // lbl_Swtich1
            // 
            this.lbl_Swtich1.AutoSize = true;
            this.lbl_Swtich1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Swtich1.Location = new System.Drawing.Point(116, 433);
            this.lbl_Swtich1.Name = "lbl_Swtich1";
            this.lbl_Swtich1.Size = new System.Drawing.Size(111, 24);
            this.lbl_Swtich1.TabIndex = 50;
            this.lbl_Swtich1.Text = "开关量1:";
            // 
            // lbl_Cat4
            // 
            this.lbl_Cat4.AutoSize = true;
            this.lbl_Cat4.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Cat4.Location = new System.Drawing.Point(13, 582);
            this.lbl_Cat4.Name = "lbl_Cat4";
            this.lbl_Cat4.Size = new System.Drawing.Size(86, 24);
            this.lbl_Cat4.TabIndex = 49;
            this.lbl_Cat4.Text = "门类4:";
            // 
            // lbl_Cat3
            // 
            this.lbl_Cat3.AutoSize = true;
            this.lbl_Cat3.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Cat3.Location = new System.Drawing.Point(13, 545);
            this.lbl_Cat3.Name = "lbl_Cat3";
            this.lbl_Cat3.Size = new System.Drawing.Size(86, 24);
            this.lbl_Cat3.TabIndex = 48;
            this.lbl_Cat3.Text = "门类3:";
            // 
            // lbl_Cat2
            // 
            this.lbl_Cat2.AutoSize = true;
            this.lbl_Cat2.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Cat2.Location = new System.Drawing.Point(13, 508);
            this.lbl_Cat2.Name = "lbl_Cat2";
            this.lbl_Cat2.Size = new System.Drawing.Size(86, 24);
            this.lbl_Cat2.TabIndex = 47;
            this.lbl_Cat2.Text = "门类2:";
            // 
            // lbl_Cat1
            // 
            this.lbl_Cat1.AutoSize = true;
            this.lbl_Cat1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Cat1.Location = new System.Drawing.Point(13, 471);
            this.lbl_Cat1.Name = "lbl_Cat1";
            this.lbl_Cat1.Size = new System.Drawing.Size(86, 24);
            this.lbl_Cat1.TabIndex = 46;
            this.lbl_Cat1.Text = "门类1:";
            // 
            // lbl_State
            // 
            this.lbl_State.AutoSize = true;
            this.lbl_State.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_State.Location = new System.Drawing.Point(116, 60);
            this.lbl_State.Name = "lbl_State";
            this.lbl_State.Size = new System.Drawing.Size(168, 20);
            this.lbl_State.TabIndex = 81;
            this.lbl_State.Text = "服务器未连接...";
            // 
            // timer_Socket
            // 
            this.timer_Socket.Tick += new System.EventHandler(this.timer_Socket_Tick);
            // 
            // Frm_Client
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1069, 625);
            this.Controls.Add(this.lbl_State);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.txtbox_c4a4);
            this.Controls.Add(this.txtbox_c3a4);
            this.Controls.Add(this.txtbox_c2a4);
            this.Controls.Add(this.txtbox_c1a4);
            this.Controls.Add(this.txtbox_c4a3);
            this.Controls.Add(this.txtbox_c3a3);
            this.Controls.Add(this.txtbox_c2a3);
            this.Controls.Add(this.txtbox_c1a3);
            this.Controls.Add(this.txtbox_c4a2);
            this.Controls.Add(this.txtbox_c3a2);
            this.Controls.Add(this.txtbox_c2a2);
            this.Controls.Add(this.txtbox_c1a2);
            this.Controls.Add(this.txtbox_c4a1);
            this.Controls.Add(this.txtbox_c3a1);
            this.Controls.Add(this.txtbox_c2a1);
            this.Controls.Add(this.txtbox_c1a1);
            this.Controls.Add(this.cbbox_c4s2);
            this.Controls.Add(this.cbbox_c3s2);
            this.Controls.Add(this.cbbox_c2s2);
            this.Controls.Add(this.cbbox_c4s1);
            this.Controls.Add(this.cbbox_c3s1);
            this.Controls.Add(this.cbbox_c2s1);
            this.Controls.Add(this.cbbox_c1s2);
            this.Controls.Add(this.cbbox_c1s1);
            this.Controls.Add(this.lbl_Analog4);
            this.Controls.Add(this.lbl_Analog3);
            this.Controls.Add(this.lbl_Analog2);
            this.Controls.Add(this.lbl_Analog1);
            this.Controls.Add(this.lbl_Swtich2);
            this.Controls.Add(this.lbl_Swtich1);
            this.Controls.Add(this.lbl_Cat4);
            this.Controls.Add(this.lbl_Cat3);
            this.Controls.Add(this.lbl_Cat2);
            this.Controls.Add(this.lbl_Cat1);
            this.Controls.Add(this.listView_Msg);
            this.Controls.Add(this.lbl_Data);
            this.Controls.Add(this.btn_Cut);
            this.Controls.Add(this.btn_Connect);
            this.Controls.Add(this.txtbox_Port);
            this.Controls.Add(this.lbl_Port);
            this.Controls.Add(this.txtbox_IP);
            this.Controls.Add(this.lbl_IP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1085, 664);
            this.MinimumSize = new System.Drawing.Size(1085, 664);
            this.Name = "Frm_Client";
            this.Text = "Frm_Client";
            this.Load += new System.EventHandler(this.Frm_Client_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbox_Port;
        private System.Windows.Forms.Label lbl_Port;
        private System.Windows.Forms.TextBox txtbox_IP;
        private System.Windows.Forms.Label lbl_IP;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.Button btn_Cut;
        private System.Windows.Forms.Label lbl_Data;
        private System.Windows.Forms.ListView listView_Msg;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.TextBox txtbox_c4a4;
        private System.Windows.Forms.TextBox txtbox_c3a4;
        private System.Windows.Forms.TextBox txtbox_c2a4;
        private System.Windows.Forms.TextBox txtbox_c1a4;
        private System.Windows.Forms.TextBox txtbox_c4a3;
        private System.Windows.Forms.TextBox txtbox_c3a3;
        private System.Windows.Forms.TextBox txtbox_c2a3;
        private System.Windows.Forms.TextBox txtbox_c1a3;
        private System.Windows.Forms.TextBox txtbox_c4a2;
        private System.Windows.Forms.TextBox txtbox_c3a2;
        private System.Windows.Forms.TextBox txtbox_c2a2;
        private System.Windows.Forms.TextBox txtbox_c1a2;
        private System.Windows.Forms.TextBox txtbox_c4a1;
        private System.Windows.Forms.TextBox txtbox_c3a1;
        private System.Windows.Forms.TextBox txtbox_c2a1;
        private System.Windows.Forms.TextBox txtbox_c1a1;
        private System.Windows.Forms.ComboBox cbbox_c4s2;
        private System.Windows.Forms.ComboBox cbbox_c3s2;
        private System.Windows.Forms.ComboBox cbbox_c2s2;
        private System.Windows.Forms.ComboBox cbbox_c4s1;
        private System.Windows.Forms.ComboBox cbbox_c3s1;
        private System.Windows.Forms.ComboBox cbbox_c2s1;
        private System.Windows.Forms.ComboBox cbbox_c1s2;
        private System.Windows.Forms.ComboBox cbbox_c1s1;
        private System.Windows.Forms.Label lbl_Analog4;
        private System.Windows.Forms.Label lbl_Analog3;
        private System.Windows.Forms.Label lbl_Analog2;
        private System.Windows.Forms.Label lbl_Analog1;
        private System.Windows.Forms.Label lbl_Swtich2;
        private System.Windows.Forms.Label lbl_Swtich1;
        private System.Windows.Forms.Label lbl_Cat4;
        private System.Windows.Forms.Label lbl_Cat3;
        private System.Windows.Forms.Label lbl_Cat2;
        private System.Windows.Forms.Label lbl_Cat1;
        private System.Windows.Forms.Label lbl_State;
        private System.Windows.Forms.Timer timer_Socket;
    }
}