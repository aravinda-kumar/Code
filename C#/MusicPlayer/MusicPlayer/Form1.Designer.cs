namespace MusicPlayer
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_MusicName = new System.Windows.Forms.Label();
            this.btn_MusicAdd = new System.Windows.Forms.Button();
            this.tbr_Sch = new System.Windows.Forms.TrackBar();
            this.listBox_Musics = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Player = new System.Windows.Forms.Button();
            this.btn_Pause = new System.Windows.Forms.Button();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.btn_Previous = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.wmp_Music = new AxWMPLib.AxWindowsMediaPlayer();
            this.tim_Refresh = new System.Windows.Forms.Timer(this.components);
            this.tim_Play = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbr_Sch)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmp_Music)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.87654F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.12346F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_MusicName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_MusicAdd, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbr_Sch, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.listBox_Musics, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.wmp_Music, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 2);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.032967F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.373626F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.02198F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.571428F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(495, 586);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // lbl_MusicName
            // 
            this.lbl_MusicName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_MusicName.AutoSize = true;
            this.lbl_MusicName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_MusicName.Location = new System.Drawing.Point(147, 21);
            this.lbl_MusicName.Margin = new System.Windows.Forms.Padding(0, 8, 7, 6);
            this.lbl_MusicName.Name = "lbl_MusicName";
            this.lbl_MusicName.Padding = new System.Windows.Forms.Padding(1);
            this.lbl_MusicName.Size = new System.Drawing.Size(71, 22);
            this.lbl_MusicName.TabIndex = 0;
            this.lbl_MusicName.Text = "歌曲名";
            // 
            // btn_MusicAdd
            // 
            this.btn_MusicAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_MusicAdd.Location = new System.Drawing.Point(11, 55);
            this.btn_MusicAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_MusicAdd.Name = "btn_MusicAdd";
            this.btn_MusicAdd.Size = new System.Drawing.Size(125, 27);
            this.btn_MusicAdd.TabIndex = 1;
            this.btn_MusicAdd.Text = "添加歌曲";
            this.btn_MusicAdd.UseVisualStyleBackColor = true;
            this.btn_MusicAdd.Click += new System.EventHandler(this.btn_MusicAdd_Click);
            // 
            // tbr_Sch
            // 
            this.tbr_Sch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbr_Sch.Location = new System.Drawing.Point(151, 55);
            this.tbr_Sch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbr_Sch.Maximum = 1000;
            this.tbr_Sch.Name = "tbr_Sch";
            this.tbr_Sch.Size = new System.Drawing.Size(340, 27);
            this.tbr_Sch.TabIndex = 2;
            this.tbr_Sch.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbr_Sch_MouseDown);
            this.tbr_Sch.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tbr_Sch_MouseUp);
            // 
            // listBox_Musics
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.listBox_Musics, 2);
            this.listBox_Musics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_Musics.FormattingEnabled = true;
            this.listBox_Musics.ItemHeight = 15;
            this.listBox_Musics.Location = new System.Drawing.Point(4, 90);
            this.listBox_Musics.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox_Musics.Name = "listBox_Musics";
            this.listBox_Musics.Size = new System.Drawing.Size(487, 430);
            this.listBox_Musics.TabIndex = 3;
            this.listBox_Musics.SelectedIndexChanged += new System.EventHandler(this.listBox_Musics_SelectedIndexChanged);
            this.listBox_Musics.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox_Musics_MouseDoubleClick);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.btn_Player, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_Pause, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_Stop, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_Previous, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_Next, 4, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 528);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(487, 40);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // btn_Player
            // 
            this.btn_Player.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Player.Location = new System.Drawing.Point(4, 4);
            this.btn_Player.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Player.Name = "btn_Player";
            this.btn_Player.Size = new System.Drawing.Size(89, 32);
            this.btn_Player.TabIndex = 0;
            this.btn_Player.Text = "播放";
            this.btn_Player.UseVisualStyleBackColor = true;
            this.btn_Player.Click += new System.EventHandler(this.btn_Player_Click);
            // 
            // btn_Pause
            // 
            this.btn_Pause.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Pause.Location = new System.Drawing.Point(101, 4);
            this.btn_Pause.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Pause.Name = "btn_Pause";
            this.btn_Pause.Size = new System.Drawing.Size(89, 32);
            this.btn_Pause.TabIndex = 1;
            this.btn_Pause.Text = "暂停";
            this.btn_Pause.UseVisualStyleBackColor = true;
            this.btn_Pause.Click += new System.EventHandler(this.btn_Pause_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Stop.Location = new System.Drawing.Point(198, 4);
            this.btn_Stop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(89, 32);
            this.btn_Stop.TabIndex = 2;
            this.btn_Stop.Text = "停止";
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // btn_Previous
            // 
            this.btn_Previous.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Previous.Location = new System.Drawing.Point(295, 4);
            this.btn_Previous.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Previous.Name = "btn_Previous";
            this.btn_Previous.Size = new System.Drawing.Size(89, 32);
            this.btn_Previous.TabIndex = 3;
            this.btn_Previous.Text = "上一首";
            this.btn_Previous.UseVisualStyleBackColor = true;
            this.btn_Previous.Click += new System.EventHandler(this.btn_Previous_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Next.Location = new System.Drawing.Point(392, 4);
            this.btn_Next.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(91, 32);
            this.btn_Next.TabIndex = 4;
            this.btn_Next.Text = "下一首";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // wmp_Music
            // 
            this.wmp_Music.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wmp_Music.Enabled = true;
            this.wmp_Music.Location = new System.Drawing.Point(3, 15);
            this.wmp_Music.Name = "wmp_Music";
            this.wmp_Music.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmp_Music.OcxState")));
            this.wmp_Music.Size = new System.Drawing.Size(141, 33);
            this.wmp_Music.TabIndex = 5;
            this.wmp_Music.Visible = false;
            // 
            // tim_Refresh
            // 
            this.tim_Refresh.Enabled = true;
            this.tim_Refresh.Tick += new System.EventHandler(this.tim_Refresh_Tick);
            // 
            // tim_Play
            // 
            this.tim_Play.Interval = 1000;
            this.tim_Play.Tick += new System.EventHandler(this.tim_Play_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 590);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(519, 637);
            this.MinimumSize = new System.Drawing.Size(519, 637);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "音乐播放器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbr_Sch)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wmp_Music)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_MusicName;
        private System.Windows.Forms.Button btn_MusicAdd;
        private System.Windows.Forms.TrackBar tbr_Sch;
        private System.Windows.Forms.ListBox listBox_Musics;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btn_Player;
        private System.Windows.Forms.Button btn_Pause;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.Button btn_Previous;
        private System.Windows.Forms.Button btn_Next;
        private AxWMPLib.AxWindowsMediaPlayer wmp_Music;
        private System.Windows.Forms.Timer tim_Refresh;
        private System.Windows.Forms.Timer tim_Play;
    }
}

