namespace Mine
{
    partial class FormDeviation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDeviation));
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lbl_IP1 = new System.Windows.Forms.Label();
            this.lbl_IP2 = new System.Windows.Forms.Label();
            this.cbBox_IP1 = new System.Windows.Forms.ComboBox();
            this.cbBox_IP2 = new System.Windows.Forms.ComboBox();
            this.lbl_PORT1 = new System.Windows.Forms.Label();
            this.lbl_PORT2 = new System.Windows.Forms.Label();
            this.cbBox_PORT1 = new System.Windows.Forms.ComboBox();
            this.cbBox_PORT2 = new System.Windows.Forms.ComboBox();
            this.lbl_SubTitle = new System.Windows.Forms.Label();
            this.pic_GUIDE = new System.Windows.Forms.PictureBox();
            this.lbl_GUIDE = new System.Windows.Forms.Label();
            this.pic_End = new System.Windows.Forms.PictureBox();
            this.pic_Head = new System.Windows.Forms.PictureBox();
            this.pic_Ham = new System.Windows.Forms.PictureBox();
            this.lbl_End = new System.Windows.Forms.Label();
            this.lbl_Ham = new System.Windows.Forms.Label();
            this.lbl_Head = new System.Windows.Forms.Label();
            this.lbl_End_n = new System.Windows.Forms.Label();
            this.lbl_Ham_n = new System.Windows.Forms.Label();
            this.lbl_Head_n = new System.Windows.Forms.Label();
            this.btn_ConnectedALL = new System.Windows.Forms.Button();
            this.txtBox_LogEnd = new System.Windows.Forms.TextBox();
            this.btn_DisConnectedALL = new System.Windows.Forms.Button();
            this.timer_pic_end = new System.Windows.Forms.Timer(this.components);
            this.imgList_Alarm = new System.Windows.Forms.ImageList(this.components);
            this.lbl_IP3 = new System.Windows.Forms.Label();
            this.cbBox_PORT3 = new System.Windows.Forms.ComboBox();
            this.lbl_PORT3 = new System.Windows.Forms.Label();
            this.cbBox_IP3 = new System.Windows.Forms.ComboBox();
            this.btn_ClearALL = new System.Windows.Forms.Button();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Nums_End = new System.Windows.Forms.Label();
            this.lbl_Nums_Ham = new System.Windows.Forms.Label();
            this.lbl_Nums_Head = new System.Windows.Forms.Label();
            this.lbl_End_Nums = new System.Windows.Forms.Label();
            this.lbl_Ham_Nums = new System.Windows.Forms.Label();
            this.lbl_Head_Nums = new System.Windows.Forms.Label();
            this.lbl_Nums = new System.Windows.Forms.Label();
            this.btn_EndConnect = new System.Windows.Forms.Button();
            this.btn_EndDisConnect = new System.Windows.Forms.Button();
            this.lbl_MsgEnd = new System.Windows.Forms.Label();
            this.lbl_EndNotice = new System.Windows.Forms.Label();
            this.lbl_HamNotice = new System.Windows.Forms.Label();
            this.lbl_MsgHam = new System.Windows.Forms.Label();
            this.btn_HamDisConnect = new System.Windows.Forms.Button();
            this.btn_HamConnect = new System.Windows.Forms.Button();
            this.txtBox_LogHam = new System.Windows.Forms.TextBox();
            this.lbl_HeadNotice = new System.Windows.Forms.Label();
            this.lbl_MsgHead = new System.Windows.Forms.Label();
            this.btn_HeadDisConnect = new System.Windows.Forms.Button();
            this.btn_HeadConnect = new System.Windows.Forms.Button();
            this.txtBox_LogHead = new System.Windows.Forms.TextBox();
            this.timer_pic_ham = new System.Windows.Forms.Timer(this.components);
            this.timer_pic_head = new System.Windows.Forms.Timer(this.components);
            this.btn_Reset = new System.Windows.Forms.Button();
            this.mediaPlayerAlarm = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.pic_GUIDE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_End)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Head)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Ham)).BeginInit();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayerAlarm)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTimePicker.Location = new System.Drawing.Point(20, 81);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker.TabIndex = 0;
            // 
            // lbl_IP1
            // 
            this.lbl_IP1.AutoSize = true;
            this.lbl_IP1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_IP1.Location = new System.Drawing.Point(19, 123);
            this.lbl_IP1.Name = "lbl_IP1";
            this.lbl_IP1.Size = new System.Drawing.Size(95, 16);
            this.lbl_IP1.TabIndex = 1;
            this.lbl_IP1.Text = "服务器IP1:";
            // 
            // lbl_IP2
            // 
            this.lbl_IP2.AutoSize = true;
            this.lbl_IP2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_IP2.Location = new System.Drawing.Point(20, 158);
            this.lbl_IP2.Name = "lbl_IP2";
            this.lbl_IP2.Size = new System.Drawing.Size(95, 16);
            this.lbl_IP2.TabIndex = 2;
            this.lbl_IP2.Text = "服务器IP2:";
            // 
            // cbBox_IP1
            // 
            this.cbBox_IP1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbBox_IP1.FormattingEnabled = true;
            this.cbBox_IP1.Location = new System.Drawing.Point(111, 119);
            this.cbBox_IP1.Name = "cbBox_IP1";
            this.cbBox_IP1.Size = new System.Drawing.Size(147, 24);
            this.cbBox_IP1.TabIndex = 3;
            this.cbBox_IP1.Text = "192.168.0.201";
            // 
            // cbBox_IP2
            // 
            this.cbBox_IP2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbBox_IP2.FormattingEnabled = true;
            this.cbBox_IP2.Location = new System.Drawing.Point(111, 154);
            this.cbBox_IP2.Name = "cbBox_IP2";
            this.cbBox_IP2.Size = new System.Drawing.Size(147, 24);
            this.cbBox_IP2.TabIndex = 4;
            this.cbBox_IP2.Text = "192.168.0.202";
            // 
            // lbl_PORT1
            // 
            this.lbl_PORT1.AutoSize = true;
            this.lbl_PORT1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_PORT1.Location = new System.Drawing.Point(264, 123);
            this.lbl_PORT1.Name = "lbl_PORT1";
            this.lbl_PORT1.Size = new System.Drawing.Size(60, 16);
            this.lbl_PORT1.TabIndex = 5;
            this.lbl_PORT1.Text = "端口1:";
            // 
            // lbl_PORT2
            // 
            this.lbl_PORT2.AutoSize = true;
            this.lbl_PORT2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_PORT2.Location = new System.Drawing.Point(264, 158);
            this.lbl_PORT2.Name = "lbl_PORT2";
            this.lbl_PORT2.Size = new System.Drawing.Size(60, 16);
            this.lbl_PORT2.TabIndex = 6;
            this.lbl_PORT2.Text = "端口2:";
            // 
            // cbBox_PORT1
            // 
            this.cbBox_PORT1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbBox_PORT1.FormattingEnabled = true;
            this.cbBox_PORT1.Location = new System.Drawing.Point(330, 119);
            this.cbBox_PORT1.Name = "cbBox_PORT1";
            this.cbBox_PORT1.Size = new System.Drawing.Size(65, 24);
            this.cbBox_PORT1.TabIndex = 7;
            this.cbBox_PORT1.Text = "8234";
            // 
            // cbBox_PORT2
            // 
            this.cbBox_PORT2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbBox_PORT2.FormattingEnabled = true;
            this.cbBox_PORT2.Location = new System.Drawing.Point(331, 154);
            this.cbBox_PORT2.Name = "cbBox_PORT2";
            this.cbBox_PORT2.Size = new System.Drawing.Size(64, 24);
            this.cbBox_PORT2.TabIndex = 8;
            this.cbBox_PORT2.Text = "8035";
            // 
            // lbl_SubTitle
            // 
            this.lbl_SubTitle.AutoSize = true;
            this.lbl_SubTitle.Font = new System.Drawing.Font("宋体", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_SubTitle.Location = new System.Drawing.Point(383, 4);
            this.lbl_SubTitle.Name = "lbl_SubTitle";
            this.lbl_SubTitle.Size = new System.Drawing.Size(408, 40);
            this.lbl_SubTitle.TabIndex = 9;
            this.lbl_SubTitle.Text = "708皮带跑偏监控界面";
            // 
            // pic_GUIDE
            // 
            this.pic_GUIDE.Image = ((System.Drawing.Image)(resources.GetObject("pic_GUIDE.Image")));
            this.pic_GUIDE.Location = new System.Drawing.Point(20, 217);
            this.pic_GUIDE.Name = "pic_GUIDE";
            this.pic_GUIDE.Size = new System.Drawing.Size(375, 223);
            this.pic_GUIDE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_GUIDE.TabIndex = 93;
            this.pic_GUIDE.TabStop = false;
            // 
            // lbl_GUIDE
            // 
            this.lbl_GUIDE.AutoSize = true;
            this.lbl_GUIDE.BackColor = System.Drawing.Color.Transparent;
            this.lbl_GUIDE.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_GUIDE.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_GUIDE.Location = new System.Drawing.Point(127, 230);
            this.lbl_GUIDE.Name = "lbl_GUIDE";
            this.lbl_GUIDE.Size = new System.Drawing.Size(161, 16);
            this.lbl_GUIDE.TabIndex = 94;
            this.lbl_GUIDE.Text = "相机安装位置示意图";
            this.lbl_GUIDE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pic_End
            // 
            this.pic_End.Image = global::Mine.Properties.Resources.绿灯;
            this.pic_End.Location = new System.Drawing.Point(130, 276);
            this.pic_End.Name = "pic_End";
            this.pic_End.Size = new System.Drawing.Size(42, 43);
            this.pic_End.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_End.TabIndex = 95;
            this.pic_End.TabStop = false;
            // 
            // pic_Head
            // 
            this.pic_Head.Image = global::Mine.Properties.Resources.绿灯;
            this.pic_Head.Location = new System.Drawing.Point(327, 276);
            this.pic_Head.Name = "pic_Head";
            this.pic_Head.Size = new System.Drawing.Size(42, 43);
            this.pic_Head.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Head.TabIndex = 96;
            this.pic_Head.TabStop = false;
            // 
            // pic_Ham
            // 
            this.pic_Ham.Image = global::Mine.Properties.Resources.绿灯;
            this.pic_Ham.Location = new System.Drawing.Point(226, 276);
            this.pic_Ham.Name = "pic_Ham";
            this.pic_Ham.Size = new System.Drawing.Size(42, 43);
            this.pic_Ham.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Ham.TabIndex = 97;
            this.pic_Ham.TabStop = false;
            // 
            // lbl_End
            // 
            this.lbl_End.AutoSize = true;
            this.lbl_End.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_End.Location = new System.Drawing.Point(120, 258);
            this.lbl_End.Name = "lbl_End";
            this.lbl_End.Size = new System.Drawing.Size(59, 16);
            this.lbl_End.TabIndex = 98;
            this.lbl_End.Text = "①机尾";
            // 
            // lbl_Ham
            // 
            this.lbl_Ham.AutoSize = true;
            this.lbl_Ham.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Ham.Location = new System.Drawing.Point(220, 258);
            this.lbl_Ham.Name = "lbl_Ham";
            this.lbl_Ham.Size = new System.Drawing.Size(59, 16);
            this.lbl_Ham.TabIndex = 99;
            this.lbl_Ham.Text = "②重锤";
            // 
            // lbl_Head
            // 
            this.lbl_Head.AutoSize = true;
            this.lbl_Head.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Head.Location = new System.Drawing.Point(316, 258);
            this.lbl_Head.Name = "lbl_Head";
            this.lbl_Head.Size = new System.Drawing.Size(59, 16);
            this.lbl_Head.TabIndex = 100;
            this.lbl_Head.Text = "③机头";
            // 
            // lbl_End_n
            // 
            this.lbl_End_n.AutoSize = true;
            this.lbl_End_n.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_End_n.Location = new System.Drawing.Point(137, 326);
            this.lbl_End_n.Name = "lbl_End_n";
            this.lbl_End_n.Size = new System.Drawing.Size(26, 16);
            this.lbl_End_n.TabIndex = 101;
            this.lbl_End_n.Text = "61";
            // 
            // lbl_Ham_n
            // 
            this.lbl_Ham_n.AutoSize = true;
            this.lbl_Ham_n.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Ham_n.Location = new System.Drawing.Point(233, 326);
            this.lbl_Ham_n.Name = "lbl_Ham_n";
            this.lbl_Ham_n.Size = new System.Drawing.Size(35, 16);
            this.lbl_Ham_n.TabIndex = 102;
            this.lbl_Ham_n.Text = "536";
            // 
            // lbl_Head_n
            // 
            this.lbl_Head_n.AutoSize = true;
            this.lbl_Head_n.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Head_n.Location = new System.Drawing.Point(329, 326);
            this.lbl_Head_n.Name = "lbl_Head_n";
            this.lbl_Head_n.Size = new System.Drawing.Size(35, 16);
            this.lbl_Head_n.TabIndex = 103;
            this.lbl_Head_n.Text = "738";
            // 
            // btn_ConnectedALL
            // 
            this.btn_ConnectedALL.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_ConnectedALL.Location = new System.Drawing.Point(20, 610);
            this.btn_ConnectedALL.Name = "btn_ConnectedALL";
            this.btn_ConnectedALL.Size = new System.Drawing.Size(375, 71);
            this.btn_ConnectedALL.TabIndex = 104;
            this.btn_ConnectedALL.Text = "全部连接";
            this.btn_ConnectedALL.UseVisualStyleBackColor = true;
            this.btn_ConnectedALL.Click += new System.EventHandler(this.btn_ConnectedALL_Click);
            // 
            // txtBox_LogEnd
            // 
            this.txtBox_LogEnd.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBox_LogEnd.ForeColor = System.Drawing.Color.Black;
            this.txtBox_LogEnd.Location = new System.Drawing.Point(558, 375);
            this.txtBox_LogEnd.Multiline = true;
            this.txtBox_LogEnd.Name = "txtBox_LogEnd";
            this.txtBox_LogEnd.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBox_LogEnd.Size = new System.Drawing.Size(605, 80);
            this.txtBox_LogEnd.TabIndex = 105;
            this.txtBox_LogEnd.TextChanged += new System.EventHandler(this.txtBox_LogEnd_TextChanged);
            // 
            // btn_DisConnectedALL
            // 
            this.btn_DisConnectedALL.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_DisConnectedALL.Location = new System.Drawing.Point(20, 567);
            this.btn_DisConnectedALL.Name = "btn_DisConnectedALL";
            this.btn_DisConnectedALL.Size = new System.Drawing.Size(111, 37);
            this.btn_DisConnectedALL.TabIndex = 106;
            this.btn_DisConnectedALL.Text = "全部断开";
            this.btn_DisConnectedALL.UseVisualStyleBackColor = true;
            this.btn_DisConnectedALL.Click += new System.EventHandler(this.btn_DisConnectedALL_Click);
            // 
            // timer_pic_end
            // 
            this.timer_pic_end.Interval = 1000;
            this.timer_pic_end.Tick += new System.EventHandler(this.timer_pic_end_Tick);
            // 
            // imgList_Alarm
            // 
            this.imgList_Alarm.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList_Alarm.ImageStream")));
            this.imgList_Alarm.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList_Alarm.Images.SetKeyName(0, "绿灯.jpg");
            this.imgList_Alarm.Images.SetKeyName(1, "红灯.jpg");
            // 
            // lbl_IP3
            // 
            this.lbl_IP3.AutoSize = true;
            this.lbl_IP3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_IP3.Location = new System.Drawing.Point(20, 190);
            this.lbl_IP3.Name = "lbl_IP3";
            this.lbl_IP3.Size = new System.Drawing.Size(95, 16);
            this.lbl_IP3.TabIndex = 108;
            this.lbl_IP3.Text = "服务器IP3:";
            // 
            // cbBox_PORT3
            // 
            this.cbBox_PORT3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbBox_PORT3.FormattingEnabled = true;
            this.cbBox_PORT3.Location = new System.Drawing.Point(331, 187);
            this.cbBox_PORT3.Name = "cbBox_PORT3";
            this.cbBox_PORT3.Size = new System.Drawing.Size(64, 24);
            this.cbBox_PORT3.TabIndex = 112;
            this.cbBox_PORT3.Text = "8036";
            // 
            // lbl_PORT3
            // 
            this.lbl_PORT3.AutoSize = true;
            this.lbl_PORT3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_PORT3.Location = new System.Drawing.Point(264, 191);
            this.lbl_PORT3.Name = "lbl_PORT3";
            this.lbl_PORT3.Size = new System.Drawing.Size(60, 16);
            this.lbl_PORT3.TabIndex = 111;
            this.lbl_PORT3.Text = "端口3:";
            // 
            // cbBox_IP3
            // 
            this.cbBox_IP3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbBox_IP3.FormattingEnabled = true;
            this.cbBox_IP3.Location = new System.Drawing.Point(111, 187);
            this.cbBox_IP3.Name = "cbBox_IP3";
            this.cbBox_IP3.Size = new System.Drawing.Size(147, 24);
            this.cbBox_IP3.TabIndex = 110;
            this.cbBox_IP3.Text = "192.168.0.203";
            // 
            // btn_ClearALL
            // 
            this.btn_ClearALL.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_ClearALL.Location = new System.Drawing.Point(152, 567);
            this.btn_ClearALL.Name = "btn_ClearALL";
            this.btn_ClearALL.Size = new System.Drawing.Size(111, 37);
            this.btn_ClearALL.TabIndex = 113;
            this.btn_ClearALL.Text = "全部清空";
            this.btn_ClearALL.UseVisualStyleBackColor = true;
            this.btn_ClearALL.Click += new System.EventHandler(this.btn_ClearALL_Click);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel.ColumnCount = 3;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel.Controls.Add(this.lbl_Nums_End, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.lbl_Nums_Ham, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.lbl_Nums_Head, 2, 0);
            this.tableLayoutPanel.Controls.Add(this.lbl_End_Nums, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.lbl_Ham_Nums, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.lbl_Head_Nums, 2, 1);
            this.tableLayoutPanel.Location = new System.Drawing.Point(20, 480);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(375, 81);
            this.tableLayoutPanel.TabIndex = 114;
            // 
            // lbl_Nums_End
            // 
            this.lbl_Nums_End.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Nums_End.AutoSize = true;
            this.lbl_Nums_End.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Nums_End.Location = new System.Drawing.Point(29, 7);
            this.lbl_Nums_End.Name = "lbl_Nums_End";
            this.lbl_Nums_End.Size = new System.Drawing.Size(68, 27);
            this.lbl_Nums_End.TabIndex = 0;
            this.lbl_Nums_End.Text = "机尾";
            // 
            // lbl_Nums_Ham
            // 
            this.lbl_Nums_Ham.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Nums_Ham.AutoSize = true;
            this.lbl_Nums_Ham.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Nums_Ham.Location = new System.Drawing.Point(153, 7);
            this.lbl_Nums_Ham.Name = "lbl_Nums_Ham";
            this.lbl_Nums_Ham.Size = new System.Drawing.Size(68, 27);
            this.lbl_Nums_Ham.TabIndex = 1;
            this.lbl_Nums_Ham.Text = "重锤";
            // 
            // lbl_Nums_Head
            // 
            this.lbl_Nums_Head.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Nums_Head.AutoSize = true;
            this.lbl_Nums_Head.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Nums_Head.Location = new System.Drawing.Point(277, 7);
            this.lbl_Nums_Head.Name = "lbl_Nums_Head";
            this.lbl_Nums_Head.Size = new System.Drawing.Size(68, 27);
            this.lbl_Nums_Head.TabIndex = 2;
            this.lbl_Nums_Head.Text = "机头";
            // 
            // lbl_End_Nums
            // 
            this.lbl_End_Nums.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_End_Nums.AutoSize = true;
            this.lbl_End_Nums.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_End_Nums.Location = new System.Drawing.Point(50, 46);
            this.lbl_End_Nums.Name = "lbl_End_Nums";
            this.lbl_End_Nums.Size = new System.Drawing.Size(27, 27);
            this.lbl_End_Nums.TabIndex = 3;
            this.lbl_End_Nums.Text = "0";
            // 
            // lbl_Ham_Nums
            // 
            this.lbl_Ham_Nums.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Ham_Nums.AutoSize = true;
            this.lbl_Ham_Nums.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Ham_Nums.Location = new System.Drawing.Point(174, 46);
            this.lbl_Ham_Nums.Name = "lbl_Ham_Nums";
            this.lbl_Ham_Nums.Size = new System.Drawing.Size(27, 27);
            this.lbl_Ham_Nums.TabIndex = 4;
            this.lbl_Ham_Nums.Text = "0";
            // 
            // lbl_Head_Nums
            // 
            this.lbl_Head_Nums.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Head_Nums.AutoSize = true;
            this.lbl_Head_Nums.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Head_Nums.Location = new System.Drawing.Point(298, 46);
            this.lbl_Head_Nums.Name = "lbl_Head_Nums";
            this.lbl_Head_Nums.Size = new System.Drawing.Size(27, 27);
            this.lbl_Head_Nums.TabIndex = 5;
            this.lbl_Head_Nums.Text = "0";
            // 
            // lbl_Nums
            // 
            this.lbl_Nums.AutoSize = true;
            this.lbl_Nums.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Nums.Location = new System.Drawing.Point(107, 453);
            this.lbl_Nums.Name = "lbl_Nums";
            this.lbl_Nums.Size = new System.Drawing.Size(210, 24);
            this.lbl_Nums.TabIndex = 115;
            this.lbl_Nums.Text = "今天跑偏次数统计";
            // 
            // btn_EndConnect
            // 
            this.btn_EndConnect.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_EndConnect.Location = new System.Drawing.Point(458, 379);
            this.btn_EndConnect.Name = "btn_EndConnect";
            this.btn_EndConnect.Size = new System.Drawing.Size(94, 31);
            this.btn_EndConnect.TabIndex = 116;
            this.btn_EndConnect.Text = "机尾连接";
            this.btn_EndConnect.UseVisualStyleBackColor = true;
            this.btn_EndConnect.Click += new System.EventHandler(this.btn_EndConnect_Click);
            // 
            // btn_EndDisConnect
            // 
            this.btn_EndDisConnect.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_EndDisConnect.Location = new System.Drawing.Point(458, 419);
            this.btn_EndDisConnect.Name = "btn_EndDisConnect";
            this.btn_EndDisConnect.Size = new System.Drawing.Size(94, 31);
            this.btn_EndDisConnect.TabIndex = 117;
            this.btn_EndDisConnect.Text = "机尾断开";
            this.btn_EndDisConnect.UseVisualStyleBackColor = true;
            this.btn_EndDisConnect.Click += new System.EventHandler(this.btn_EndDisConnect_Click);
            // 
            // lbl_MsgEnd
            // 
            this.lbl_MsgEnd.AutoSize = true;
            this.lbl_MsgEnd.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_MsgEnd.Location = new System.Drawing.Point(461, 357);
            this.lbl_MsgEnd.Name = "lbl_MsgEnd";
            this.lbl_MsgEnd.Size = new System.Drawing.Size(178, 16);
            this.lbl_MsgEnd.TabIndex = 118;
            this.lbl_MsgEnd.Text = "机尾处跑偏报警信息：";
            // 
            // lbl_EndNotice
            // 
            this.lbl_EndNotice.AutoSize = true;
            this.lbl_EndNotice.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_EndNotice.Location = new System.Drawing.Point(633, 357);
            this.lbl_EndNotice.Name = "lbl_EndNotice";
            this.lbl_EndNotice.Size = new System.Drawing.Size(93, 16);
            this.lbl_EndNotice.TabIndex = 119;
            this.lbl_EndNotice.Text = "机尾未连接";
            // 
            // lbl_HamNotice
            // 
            this.lbl_HamNotice.AutoSize = true;
            this.lbl_HamNotice.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_HamNotice.Location = new System.Drawing.Point(633, 474);
            this.lbl_HamNotice.Name = "lbl_HamNotice";
            this.lbl_HamNotice.Size = new System.Drawing.Size(93, 16);
            this.lbl_HamNotice.TabIndex = 124;
            this.lbl_HamNotice.Text = "重锤未连接";
            // 
            // lbl_MsgHam
            // 
            this.lbl_MsgHam.AutoSize = true;
            this.lbl_MsgHam.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_MsgHam.Location = new System.Drawing.Point(461, 474);
            this.lbl_MsgHam.Name = "lbl_MsgHam";
            this.lbl_MsgHam.Size = new System.Drawing.Size(178, 16);
            this.lbl_MsgHam.TabIndex = 123;
            this.lbl_MsgHam.Text = "重锤处跑偏报警信息：";
            // 
            // btn_HamDisConnect
            // 
            this.btn_HamDisConnect.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_HamDisConnect.Location = new System.Drawing.Point(458, 536);
            this.btn_HamDisConnect.Name = "btn_HamDisConnect";
            this.btn_HamDisConnect.Size = new System.Drawing.Size(94, 31);
            this.btn_HamDisConnect.TabIndex = 122;
            this.btn_HamDisConnect.Text = "重锤断开";
            this.btn_HamDisConnect.UseVisualStyleBackColor = true;
            this.btn_HamDisConnect.Click += new System.EventHandler(this.btn_HamDisConnect_Click);
            // 
            // btn_HamConnect
            // 
            this.btn_HamConnect.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_HamConnect.Location = new System.Drawing.Point(458, 496);
            this.btn_HamConnect.Name = "btn_HamConnect";
            this.btn_HamConnect.Size = new System.Drawing.Size(94, 31);
            this.btn_HamConnect.TabIndex = 121;
            this.btn_HamConnect.Text = "重锤连接";
            this.btn_HamConnect.UseVisualStyleBackColor = true;
            this.btn_HamConnect.Click += new System.EventHandler(this.btn_HamConnect_Click);
            // 
            // txtBox_LogHam
            // 
            this.txtBox_LogHam.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBox_LogHam.Location = new System.Drawing.Point(558, 492);
            this.txtBox_LogHam.Multiline = true;
            this.txtBox_LogHam.Name = "txtBox_LogHam";
            this.txtBox_LogHam.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBox_LogHam.Size = new System.Drawing.Size(605, 80);
            this.txtBox_LogHam.TabIndex = 120;
            this.txtBox_LogHam.TextChanged += new System.EventHandler(this.txtBox_LogHam_TextChanged);
            // 
            // lbl_HeadNotice
            // 
            this.lbl_HeadNotice.AutoSize = true;
            this.lbl_HeadNotice.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_HeadNotice.Location = new System.Drawing.Point(633, 588);
            this.lbl_HeadNotice.Name = "lbl_HeadNotice";
            this.lbl_HeadNotice.Size = new System.Drawing.Size(93, 16);
            this.lbl_HeadNotice.TabIndex = 129;
            this.lbl_HeadNotice.Text = "机头未连接";
            // 
            // lbl_MsgHead
            // 
            this.lbl_MsgHead.AutoSize = true;
            this.lbl_MsgHead.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_MsgHead.Location = new System.Drawing.Point(461, 588);
            this.lbl_MsgHead.Name = "lbl_MsgHead";
            this.lbl_MsgHead.Size = new System.Drawing.Size(178, 16);
            this.lbl_MsgHead.TabIndex = 128;
            this.lbl_MsgHead.Text = "机头处跑偏报警信息：";
            // 
            // btn_HeadDisConnect
            // 
            this.btn_HeadDisConnect.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_HeadDisConnect.Location = new System.Drawing.Point(458, 650);
            this.btn_HeadDisConnect.Name = "btn_HeadDisConnect";
            this.btn_HeadDisConnect.Size = new System.Drawing.Size(94, 31);
            this.btn_HeadDisConnect.TabIndex = 127;
            this.btn_HeadDisConnect.Text = "机头断开";
            this.btn_HeadDisConnect.UseVisualStyleBackColor = true;
            this.btn_HeadDisConnect.Click += new System.EventHandler(this.btn_HeadDisConnect_Click);
            // 
            // btn_HeadConnect
            // 
            this.btn_HeadConnect.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_HeadConnect.Location = new System.Drawing.Point(458, 610);
            this.btn_HeadConnect.Name = "btn_HeadConnect";
            this.btn_HeadConnect.Size = new System.Drawing.Size(94, 31);
            this.btn_HeadConnect.TabIndex = 126;
            this.btn_HeadConnect.Text = "机头连接";
            this.btn_HeadConnect.UseVisualStyleBackColor = true;
            this.btn_HeadConnect.Click += new System.EventHandler(this.btn_HeadConnect_Click);
            // 
            // txtBox_LogHead
            // 
            this.txtBox_LogHead.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBox_LogHead.Location = new System.Drawing.Point(558, 606);
            this.txtBox_LogHead.Multiline = true;
            this.txtBox_LogHead.Name = "txtBox_LogHead";
            this.txtBox_LogHead.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBox_LogHead.Size = new System.Drawing.Size(605, 80);
            this.txtBox_LogHead.TabIndex = 125;
            this.txtBox_LogHead.TextChanged += new System.EventHandler(this.txtBox_LogHead_TextChanged);
            // 
            // timer_pic_ham
            // 
            this.timer_pic_ham.Interval = 1000;
            this.timer_pic_ham.Tick += new System.EventHandler(this.timer_pic_ham_Tick);
            // 
            // timer_pic_head
            // 
            this.timer_pic_head.Tick += new System.EventHandler(this.timer_pic_head_Tick);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Reset.Location = new System.Drawing.Point(284, 567);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(111, 37);
            this.btn_Reset.TabIndex = 130;
            this.btn_Reset.Text = "状态复位";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // mediaPlayerAlarm
            // 
            this.mediaPlayerAlarm.Enabled = true;
            this.mediaPlayerAlarm.Location = new System.Drawing.Point(12, 12);
            this.mediaPlayerAlarm.Name = "mediaPlayerAlarm";
            this.mediaPlayerAlarm.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mediaPlayerAlarm.OcxState")));
            this.mediaPlayerAlarm.Size = new System.Drawing.Size(119, 63);
            this.mediaPlayerAlarm.TabIndex = 131;
            this.mediaPlayerAlarm.Visible = false;
            // 
            // FormDeviation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1181, 697);
            this.Controls.Add(this.mediaPlayerAlarm);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.lbl_HeadNotice);
            this.Controls.Add(this.lbl_MsgHead);
            this.Controls.Add(this.btn_HeadDisConnect);
            this.Controls.Add(this.btn_HeadConnect);
            this.Controls.Add(this.txtBox_LogHead);
            this.Controls.Add(this.lbl_HamNotice);
            this.Controls.Add(this.lbl_MsgHam);
            this.Controls.Add(this.btn_HamDisConnect);
            this.Controls.Add(this.btn_HamConnect);
            this.Controls.Add(this.txtBox_LogHam);
            this.Controls.Add(this.lbl_EndNotice);
            this.Controls.Add(this.lbl_MsgEnd);
            this.Controls.Add(this.btn_EndDisConnect);
            this.Controls.Add(this.btn_EndConnect);
            this.Controls.Add(this.lbl_Nums);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.btn_ClearALL);
            this.Controls.Add(this.cbBox_PORT3);
            this.Controls.Add(this.lbl_PORT3);
            this.Controls.Add(this.cbBox_IP3);
            this.Controls.Add(this.lbl_IP3);
            this.Controls.Add(this.btn_DisConnectedALL);
            this.Controls.Add(this.txtBox_LogEnd);
            this.Controls.Add(this.btn_ConnectedALL);
            this.Controls.Add(this.lbl_Head_n);
            this.Controls.Add(this.lbl_Ham_n);
            this.Controls.Add(this.lbl_End_n);
            this.Controls.Add(this.lbl_Head);
            this.Controls.Add(this.lbl_Ham);
            this.Controls.Add(this.lbl_End);
            this.Controls.Add(this.pic_Ham);
            this.Controls.Add(this.pic_Head);
            this.Controls.Add(this.pic_End);
            this.Controls.Add(this.lbl_GUIDE);
            this.Controls.Add(this.pic_GUIDE);
            this.Controls.Add(this.lbl_SubTitle);
            this.Controls.Add(this.cbBox_PORT2);
            this.Controls.Add(this.cbBox_PORT1);
            this.Controls.Add(this.lbl_PORT2);
            this.Controls.Add(this.lbl_PORT1);
            this.Controls.Add(this.cbBox_IP2);
            this.Controls.Add(this.cbBox_IP1);
            this.Controls.Add(this.lbl_IP2);
            this.Controls.Add(this.lbl_IP1);
            this.Controls.Add(this.dateTimePicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormDeviation";
            this.Text = "皮带跑偏监控";
            this.Load += new System.EventHandler(this.FormDeviation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_GUIDE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_End)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Head)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Ham)).EndInit();
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayerAlarm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label lbl_IP1;
        private System.Windows.Forms.Label lbl_IP2;
        private System.Windows.Forms.ComboBox cbBox_IP1;
        private System.Windows.Forms.ComboBox cbBox_IP2;
        private System.Windows.Forms.Label lbl_PORT1;
        private System.Windows.Forms.Label lbl_PORT2;
        private System.Windows.Forms.ComboBox cbBox_PORT1;
        private System.Windows.Forms.ComboBox cbBox_PORT2;
        private System.Windows.Forms.Label lbl_SubTitle;
        private System.Windows.Forms.PictureBox pic_GUIDE;
        private System.Windows.Forms.Label lbl_GUIDE;
        private System.Windows.Forms.PictureBox pic_End;
        private System.Windows.Forms.PictureBox pic_Head;
        private System.Windows.Forms.PictureBox pic_Ham;
        private System.Windows.Forms.Label lbl_End;
        private System.Windows.Forms.Label lbl_Ham;
        private System.Windows.Forms.Label lbl_Head;
        private System.Windows.Forms.Label lbl_End_n;
        private System.Windows.Forms.Label lbl_Ham_n;
        private System.Windows.Forms.Label lbl_Head_n;
        private System.Windows.Forms.Button btn_ConnectedALL;
        private System.Windows.Forms.TextBox txtBox_LogEnd;
        private System.Windows.Forms.Button btn_DisConnectedALL;
        private System.Windows.Forms.Timer timer_pic_end;
        private System.Windows.Forms.ImageList imgList_Alarm;
        private System.Windows.Forms.Label lbl_IP3;
        private System.Windows.Forms.ComboBox cbBox_PORT3;
        private System.Windows.Forms.Label lbl_PORT3;
        private System.Windows.Forms.ComboBox cbBox_IP3;
        private System.Windows.Forms.Button btn_ClearALL;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label lbl_Nums_End;
        private System.Windows.Forms.Label lbl_Nums_Ham;
        private System.Windows.Forms.Label lbl_Nums_Head;
        private System.Windows.Forms.Label lbl_End_Nums;
        private System.Windows.Forms.Label lbl_Ham_Nums;
        private System.Windows.Forms.Label lbl_Head_Nums;
        private System.Windows.Forms.Label lbl_Nums;
        private System.Windows.Forms.Button btn_EndConnect;
        private System.Windows.Forms.Button btn_EndDisConnect;
        private System.Windows.Forms.Label lbl_MsgEnd;
        private System.Windows.Forms.Label lbl_EndNotice;
        private System.Windows.Forms.Label lbl_HamNotice;
        private System.Windows.Forms.Label lbl_MsgHam;
        private System.Windows.Forms.Button btn_HamDisConnect;
        private System.Windows.Forms.Button btn_HamConnect;
        private System.Windows.Forms.TextBox txtBox_LogHam;
        private System.Windows.Forms.Label lbl_HeadNotice;
        private System.Windows.Forms.Label lbl_MsgHead;
        private System.Windows.Forms.Button btn_HeadDisConnect;
        private System.Windows.Forms.Button btn_HeadConnect;
        private System.Windows.Forms.TextBox txtBox_LogHead;
        private System.Windows.Forms.Timer timer_pic_ham;
        private System.Windows.Forms.Timer timer_pic_head;
        private System.Windows.Forms.Button btn_Reset;
        private AxWMPLib.AxWindowsMediaPlayer mediaPlayerAlarm;
    }
}