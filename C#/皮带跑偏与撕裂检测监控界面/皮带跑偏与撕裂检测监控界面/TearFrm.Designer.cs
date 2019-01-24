﻿namespace 皮带跑偏与撕裂检测监控界面
{
    partial class TearFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TearFrm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_SubTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.MediaPlayerHead = new AxWMPLib.AxWindowsMediaPlayer();
            this.MediaPlayerHam = new AxWMPLib.AxWindowsMediaPlayer();
            this.MediaPlayerEnd = new AxWMPLib.AxWindowsMediaPlayer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picBox_Head = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.picBox_Ham = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.picBox_End = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listBox_Head = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.listBox_Ham = new System.Windows.Forms.ListBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.listBox_End = new System.Windows.Forms.ListBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtBox_Head = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.txtBox_Ham = new System.Windows.Forms.TextBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.txtBox_End = new System.Windows.Forms.TextBox();
            this.progressBar_Head = new System.Windows.Forms.ProgressBar();
            this.progressBar_Ham = new System.Windows.Forms.ProgressBar();
            this.progressBar_End = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Head_State_01 = new System.Windows.Forms.Label();
            this.lbl_Head_State_02 = new System.Windows.Forms.Label();
            this.lbl_Head_State_03 = new System.Windows.Forms.Label();
            this.picBox_Head_Light = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_Ham_State_01 = new System.Windows.Forms.Label();
            this.lbl_Ham_State_02 = new System.Windows.Forms.Label();
            this.lbl_Ham_State_03 = new System.Windows.Forms.Label();
            this.picBox_Ham_Light = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_End_State_01 = new System.Windows.Forms.Label();
            this.lbl_End_State_02 = new System.Windows.Forms.Label();
            this.lbl_End_State_03 = new System.Windows.Forms.Label();
            this.picBox_End_Light = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Head_Connect = new System.Windows.Forms.Button();
            this.btn_Head_Sound = new System.Windows.Forms.Button();
            this.btn_Head_StopFlicker = new System.Windows.Forms.Button();
            this.btn_Head_Reset = new System.Windows.Forms.Button();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Ham_Connect = new System.Windows.Forms.Button();
            this.btn_Ham_Sound = new System.Windows.Forms.Button();
            this.btn_Ham_StopFlicker = new System.Windows.Forms.Button();
            this.btn_Ham_Reset = new System.Windows.Forms.Button();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_End_Connect = new System.Windows.Forms.Button();
            this.btn_End_Sound = new System.Windows.Forms.Button();
            this.btn_End_StopFlicker = new System.Windows.Forms.Button();
            this.btn_End_Reset = new System.Windows.Forms.Button();
            this.menuStrip_Main = new System.Windows.Forms.MenuStrip();
            this.查看日志ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开日志文件夹ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.报警音设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.机头撕裂报警音设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重锤撕裂报警音设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.机尾撕裂报警音设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清空照片ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清空机头照片ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清空重锤照片ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清空机尾照片ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清空照片候选框ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清空机头照片候选框ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清空重锤照片候选框ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清空机尾照片候选框ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清空日志ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清空机头报警日志ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清空重锤报警日志ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清空机尾报警日志ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayerHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayerHam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayerEnd)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Head)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Ham)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_End)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Head_Light)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Ham_Light)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_End_Light)).BeginInit();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.menuStrip_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_SubTitle, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.groupBox5, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.groupBox6, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.groupBox7, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.groupBox8, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.groupBox9, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.progressBar_Head, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.progressBar_Ham, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.progressBar_End, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel6, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel7, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel8, 2, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.53435F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.72652F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 159F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.739125F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1924, 986);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lbl_SubTitle
            // 
            this.lbl_SubTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_SubTitle.AutoSize = true;
            this.lbl_SubTitle.Font = new System.Drawing.Font("宋体", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_SubTitle.Location = new System.Drawing.Point(707, 14);
            this.lbl_SubTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_SubTitle.Name = "lbl_SubTitle";
            this.lbl_SubTitle.Size = new System.Drawing.Size(508, 50);
            this.lbl_SubTitle.TabIndex = 11;
            this.lbl_SubTitle.Text = "708皮带撕裂监控界面";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.MediaPlayerHead, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.MediaPlayerHam, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.MediaPlayerEnd, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(630, 67);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // MediaPlayerHead
            // 
            this.MediaPlayerHead.Enabled = true;
            this.MediaPlayerHead.Location = new System.Drawing.Point(4, 4);
            this.MediaPlayerHead.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MediaPlayerHead.Name = "MediaPlayerHead";
            this.MediaPlayerHead.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MediaPlayerHead.OcxState")));
            this.MediaPlayerHead.Size = new System.Drawing.Size(202, 59);
            this.MediaPlayerHead.TabIndex = 0;
            this.MediaPlayerHead.Visible = false;
            // 
            // MediaPlayerHam
            // 
            this.MediaPlayerHam.Enabled = true;
            this.MediaPlayerHam.Location = new System.Drawing.Point(214, 4);
            this.MediaPlayerHam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MediaPlayerHam.Name = "MediaPlayerHam";
            this.MediaPlayerHam.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MediaPlayerHam.OcxState")));
            this.MediaPlayerHam.Size = new System.Drawing.Size(202, 59);
            this.MediaPlayerHam.TabIndex = 1;
            this.MediaPlayerHam.Visible = false;
            // 
            // MediaPlayerEnd
            // 
            this.MediaPlayerEnd.Enabled = true;
            this.MediaPlayerEnd.Location = new System.Drawing.Point(424, 4);
            this.MediaPlayerEnd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MediaPlayerEnd.Name = "MediaPlayerEnd";
            this.MediaPlayerEnd.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MediaPlayerEnd.OcxState")));
            this.MediaPlayerEnd.Size = new System.Drawing.Size(202, 59);
            this.MediaPlayerEnd.TabIndex = 2;
            this.MediaPlayerEnd.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picBox_Head);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(6, 83);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(630, 358);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "机头撕裂照片";
            // 
            // picBox_Head
            // 
            this.picBox_Head.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBox_Head.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBox_Head.Location = new System.Drawing.Point(4, 27);
            this.picBox_Head.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picBox_Head.Name = "picBox_Head";
            this.picBox_Head.Size = new System.Drawing.Size(622, 327);
            this.picBox_Head.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_Head.TabIndex = 0;
            this.picBox_Head.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.picBox_Ham);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(646, 83);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(630, 358);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "重锤撕裂照片";
            // 
            // picBox_Ham
            // 
            this.picBox_Ham.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBox_Ham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBox_Ham.Location = new System.Drawing.Point(4, 27);
            this.picBox_Ham.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picBox_Ham.Name = "picBox_Ham";
            this.picBox_Ham.Size = new System.Drawing.Size(622, 327);
            this.picBox_Ham.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_Ham.TabIndex = 0;
            this.picBox_Ham.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.picBox_End);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(1286, 83);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(632, 358);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "机尾撕裂照片";
            // 
            // picBox_End
            // 
            this.picBox_End.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBox_End.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBox_End.Location = new System.Drawing.Point(4, 27);
            this.picBox_End.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picBox_End.Name = "picBox_End";
            this.picBox_End.Size = new System.Drawing.Size(624, 327);
            this.picBox_End.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_End.TabIndex = 0;
            this.picBox_End.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listBox_Head);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox4.Location = new System.Drawing.Point(6, 543);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(630, 217);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "机头照片候选框";
            // 
            // listBox_Head
            // 
            this.listBox_Head.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_Head.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBox_Head.FormattingEnabled = true;
            this.listBox_Head.ItemHeight = 27;
            this.listBox_Head.Location = new System.Drawing.Point(4, 27);
            this.listBox_Head.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox_Head.Name = "listBox_Head";
            this.listBox_Head.ScrollAlwaysVisible = true;
            this.listBox_Head.Size = new System.Drawing.Size(622, 186);
            this.listBox_Head.TabIndex = 0;
            this.listBox_Head.SelectedIndexChanged += new System.EventHandler(this.listBox_Head_SelectedIndexChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.listBox_Ham);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox5.Location = new System.Drawing.Point(646, 543);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Size = new System.Drawing.Size(630, 217);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "重锤照片候选框";
            // 
            // listBox_Ham
            // 
            this.listBox_Ham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_Ham.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBox_Ham.FormattingEnabled = true;
            this.listBox_Ham.ItemHeight = 27;
            this.listBox_Ham.Location = new System.Drawing.Point(4, 27);
            this.listBox_Ham.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox_Ham.Name = "listBox_Ham";
            this.listBox_Ham.ScrollAlwaysVisible = true;
            this.listBox_Ham.Size = new System.Drawing.Size(622, 186);
            this.listBox_Ham.TabIndex = 0;
            this.listBox_Ham.SelectedIndexChanged += new System.EventHandler(this.listBox_Ham_SelectedIndexChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.listBox_End);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox6.Location = new System.Drawing.Point(1286, 543);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox6.Size = new System.Drawing.Size(632, 217);
            this.groupBox6.TabIndex = 18;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "机尾照片候选框";
            // 
            // listBox_End
            // 
            this.listBox_End.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_End.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBox_End.FormattingEnabled = true;
            this.listBox_End.ItemHeight = 27;
            this.listBox_End.Location = new System.Drawing.Point(4, 27);
            this.listBox_End.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox_End.Name = "listBox_End";
            this.listBox_End.ScrollAlwaysVisible = true;
            this.listBox_End.Size = new System.Drawing.Size(624, 186);
            this.listBox_End.TabIndex = 0;
            this.listBox_End.SelectedIndexChanged += new System.EventHandler(this.listBox_End_SelectedIndexChanged);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txtBox_Head);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox7.Location = new System.Drawing.Point(6, 770);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox7.Size = new System.Drawing.Size(630, 151);
            this.groupBox7.TabIndex = 19;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "机头报警日志";
            // 
            // txtBox_Head
            // 
            this.txtBox_Head.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBox_Head.Location = new System.Drawing.Point(4, 27);
            this.txtBox_Head.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBox_Head.Multiline = true;
            this.txtBox_Head.Name = "txtBox_Head";
            this.txtBox_Head.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBox_Head.Size = new System.Drawing.Size(622, 120);
            this.txtBox_Head.TabIndex = 0;
            this.txtBox_Head.TextChanged += new System.EventHandler(this.txtBox_Head_TextChanged);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.txtBox_Ham);
            this.groupBox8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox8.Location = new System.Drawing.Point(646, 770);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox8.Size = new System.Drawing.Size(630, 151);
            this.groupBox8.TabIndex = 20;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "重锤报警日志";
            // 
            // txtBox_Ham
            // 
            this.txtBox_Ham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBox_Ham.Location = new System.Drawing.Point(4, 27);
            this.txtBox_Ham.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBox_Ham.Multiline = true;
            this.txtBox_Ham.Name = "txtBox_Ham";
            this.txtBox_Ham.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBox_Ham.Size = new System.Drawing.Size(622, 120);
            this.txtBox_Ham.TabIndex = 0;
            this.txtBox_Ham.TextChanged += new System.EventHandler(this.txtBox_Ham_TextChanged);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.txtBox_End);
            this.groupBox9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox9.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox9.Location = new System.Drawing.Point(1286, 770);
            this.groupBox9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox9.Size = new System.Drawing.Size(632, 151);
            this.groupBox9.TabIndex = 21;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "机尾报警日志";
            // 
            // txtBox_End
            // 
            this.txtBox_End.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBox_End.Location = new System.Drawing.Point(4, 27);
            this.txtBox_End.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBox_End.Multiline = true;
            this.txtBox_End.Name = "txtBox_End";
            this.txtBox_End.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBox_End.Size = new System.Drawing.Size(624, 120);
            this.txtBox_End.TabIndex = 0;
            this.txtBox_End.TextChanged += new System.EventHandler(this.txtBox_End_TextChanged);
            // 
            // progressBar_Head
            // 
            this.progressBar_Head.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar_Head.Location = new System.Drawing.Point(6, 451);
            this.progressBar_Head.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBar_Head.Name = "progressBar_Head";
            this.progressBar_Head.Size = new System.Drawing.Size(630, 30);
            this.progressBar_Head.TabIndex = 22;
            // 
            // progressBar_Ham
            // 
            this.progressBar_Ham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar_Ham.Location = new System.Drawing.Point(646, 451);
            this.progressBar_Ham.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBar_Ham.Name = "progressBar_Ham";
            this.progressBar_Ham.Size = new System.Drawing.Size(630, 30);
            this.progressBar_Ham.TabIndex = 23;
            // 
            // progressBar_End
            // 
            this.progressBar_End.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar_End.Location = new System.Drawing.Point(1286, 451);
            this.progressBar_End.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBar_End.Name = "progressBar_End";
            this.progressBar_End.Size = new System.Drawing.Size(632, 30);
            this.progressBar_End.TabIndex = 24;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.52204F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.36195F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lbl_Head_State_01, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.lbl_Head_State_02, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.lbl_Head_State_03, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.picBox_Head_Light, 4, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 491);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(630, 42);
            this.tableLayoutPanel3.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(4, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "相机状态:";
            // 
            // lbl_Head_State_01
            // 
            this.lbl_Head_State_01.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_Head_State_01.AutoSize = true;
            this.lbl_Head_State_01.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Head_State_01.Location = new System.Drawing.Point(149, 8);
            this.lbl_Head_State_01.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Head_State_01.Name = "lbl_Head_State_01";
            this.lbl_Head_State_01.Size = new System.Drawing.Size(116, 25);
            this.lbl_Head_State_01.TabIndex = 1;
            this.lbl_Head_State_01.Text = "一号断开";
            // 
            // lbl_Head_State_02
            // 
            this.lbl_Head_State_02.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_Head_State_02.AutoSize = true;
            this.lbl_Head_State_02.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Head_State_02.Location = new System.Drawing.Point(288, 8);
            this.lbl_Head_State_02.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Head_State_02.Name = "lbl_Head_State_02";
            this.lbl_Head_State_02.Size = new System.Drawing.Size(116, 25);
            this.lbl_Head_State_02.TabIndex = 2;
            this.lbl_Head_State_02.Text = "二号断开";
            // 
            // lbl_Head_State_03
            // 
            this.lbl_Head_State_03.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_Head_State_03.AutoSize = true;
            this.lbl_Head_State_03.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Head_State_03.Location = new System.Drawing.Point(430, 8);
            this.lbl_Head_State_03.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Head_State_03.Name = "lbl_Head_State_03";
            this.lbl_Head_State_03.Size = new System.Drawing.Size(116, 25);
            this.lbl_Head_State_03.TabIndex = 3;
            this.lbl_Head_State_03.Text = "三号断开";
            // 
            // picBox_Head_Light
            // 
            this.picBox_Head_Light.Image = global::皮带跑偏与撕裂检测监控界面.Properties.Resources.g_1;
            this.picBox_Head_Light.Location = new System.Drawing.Point(572, 4);
            this.picBox_Head_Light.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picBox_Head_Light.Name = "picBox_Head_Light";
            this.picBox_Head_Light.Size = new System.Drawing.Size(48, 34);
            this.picBox_Head_Light.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_Head_Light.TabIndex = 4;
            this.picBox_Head_Light.TabStop = false;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 5;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.51724F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.36782F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel4.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.lbl_Ham_State_01, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.lbl_Ham_State_02, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.lbl_Ham_State_03, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.picBox_Ham_Light, 4, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(646, 491);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(630, 42);
            this.tableLayoutPanel4.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(4, 8);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "相机状态:";
            // 
            // lbl_Ham_State_01
            // 
            this.lbl_Ham_State_01.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_Ham_State_01.AutoSize = true;
            this.lbl_Ham_State_01.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Ham_State_01.Location = new System.Drawing.Point(149, 8);
            this.lbl_Ham_State_01.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Ham_State_01.Name = "lbl_Ham_State_01";
            this.lbl_Ham_State_01.Size = new System.Drawing.Size(116, 25);
            this.lbl_Ham_State_01.TabIndex = 1;
            this.lbl_Ham_State_01.Text = "一号断开";
            // 
            // lbl_Ham_State_02
            // 
            this.lbl_Ham_State_02.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_Ham_State_02.AutoSize = true;
            this.lbl_Ham_State_02.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Ham_State_02.Location = new System.Drawing.Point(288, 8);
            this.lbl_Ham_State_02.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Ham_State_02.Name = "lbl_Ham_State_02";
            this.lbl_Ham_State_02.Size = new System.Drawing.Size(116, 25);
            this.lbl_Ham_State_02.TabIndex = 2;
            this.lbl_Ham_State_02.Text = "二号断开";
            // 
            // lbl_Ham_State_03
            // 
            this.lbl_Ham_State_03.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_Ham_State_03.AutoSize = true;
            this.lbl_Ham_State_03.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Ham_State_03.Location = new System.Drawing.Point(430, 8);
            this.lbl_Ham_State_03.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Ham_State_03.Name = "lbl_Ham_State_03";
            this.lbl_Ham_State_03.Size = new System.Drawing.Size(116, 25);
            this.lbl_Ham_State_03.TabIndex = 3;
            this.lbl_Ham_State_03.Text = "三号断开";
            // 
            // picBox_Ham_Light
            // 
            this.picBox_Ham_Light.Image = global::皮带跑偏与撕裂检测监控界面.Properties.Resources.g_1;
            this.picBox_Ham_Light.Location = new System.Drawing.Point(572, 4);
            this.picBox_Ham_Light.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picBox_Ham_Light.Name = "picBox_Ham_Light";
            this.picBox_Ham_Light.Size = new System.Drawing.Size(48, 34);
            this.picBox_Ham_Light.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_Ham_Light.TabIndex = 4;
            this.picBox_Ham_Light.TabStop = false;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 5;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.45872F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.54128F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel5.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.lbl_End_State_01, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.lbl_End_State_02, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.lbl_End_State_03, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.picBox_End_Light, 4, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(1286, 491);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(632, 42);
            this.tableLayoutPanel5.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(4, 8);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "相机状态:";
            // 
            // lbl_End_State_01
            // 
            this.lbl_End_State_01.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_End_State_01.AutoSize = true;
            this.lbl_End_State_01.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_End_State_01.Location = new System.Drawing.Point(149, 8);
            this.lbl_End_State_01.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_End_State_01.Name = "lbl_End_State_01";
            this.lbl_End_State_01.Size = new System.Drawing.Size(116, 25);
            this.lbl_End_State_01.TabIndex = 1;
            this.lbl_End_State_01.Text = "一号断开";
            // 
            // lbl_End_State_02
            // 
            this.lbl_End_State_02.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_End_State_02.AutoSize = true;
            this.lbl_End_State_02.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_End_State_02.Location = new System.Drawing.Point(289, 8);
            this.lbl_End_State_02.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_End_State_02.Name = "lbl_End_State_02";
            this.lbl_End_State_02.Size = new System.Drawing.Size(116, 25);
            this.lbl_End_State_02.TabIndex = 2;
            this.lbl_End_State_02.Text = "二号断开";
            // 
            // lbl_End_State_03
            // 
            this.lbl_End_State_03.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_End_State_03.AutoSize = true;
            this.lbl_End_State_03.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_End_State_03.Location = new System.Drawing.Point(432, 8);
            this.lbl_End_State_03.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_End_State_03.Name = "lbl_End_State_03";
            this.lbl_End_State_03.Size = new System.Drawing.Size(116, 25);
            this.lbl_End_State_03.TabIndex = 3;
            this.lbl_End_State_03.Text = "三号断开";
            // 
            // picBox_End_Light
            // 
            this.picBox_End_Light.Image = global::皮带跑偏与撕裂检测监控界面.Properties.Resources.g_1;
            this.picBox_End_Light.Location = new System.Drawing.Point(575, 4);
            this.picBox_End_Light.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picBox_End_Light.Name = "picBox_End_Light";
            this.picBox_End_Light.Size = new System.Drawing.Size(49, 34);
            this.picBox_End_Light.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_End_Light.TabIndex = 4;
            this.picBox_End_Light.TabStop = false;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 4;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.Controls.Add(this.btn_Head_Connect, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.btn_Head_Sound, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.btn_Head_StopFlicker, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.btn_Head_Reset, 3, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(6, 931);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(630, 49);
            this.tableLayoutPanel6.TabIndex = 28;
            // 
            // btn_Head_Connect
            // 
            this.btn_Head_Connect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Head_Connect.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Head_Connect.Location = new System.Drawing.Point(4, 4);
            this.btn_Head_Connect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Head_Connect.Name = "btn_Head_Connect";
            this.btn_Head_Connect.Size = new System.Drawing.Size(149, 41);
            this.btn_Head_Connect.TabIndex = 0;
            this.btn_Head_Connect.Text = "连接";
            this.btn_Head_Connect.UseVisualStyleBackColor = true;
            this.btn_Head_Connect.Click += new System.EventHandler(this.btn_Head_Connect_Click);
            // 
            // btn_Head_Sound
            // 
            this.btn_Head_Sound.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Head_Sound.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Head_Sound.Location = new System.Drawing.Point(161, 4);
            this.btn_Head_Sound.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Head_Sound.Name = "btn_Head_Sound";
            this.btn_Head_Sound.Size = new System.Drawing.Size(149, 41);
            this.btn_Head_Sound.TabIndex = 1;
            this.btn_Head_Sound.Text = "静音";
            this.btn_Head_Sound.UseVisualStyleBackColor = true;
            this.btn_Head_Sound.Click += new System.EventHandler(this.btn_Head_Sound_Click);
            // 
            // btn_Head_StopFlicker
            // 
            this.btn_Head_StopFlicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Head_StopFlicker.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Head_StopFlicker.Location = new System.Drawing.Point(318, 4);
            this.btn_Head_StopFlicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Head_StopFlicker.Name = "btn_Head_StopFlicker";
            this.btn_Head_StopFlicker.Size = new System.Drawing.Size(149, 41);
            this.btn_Head_StopFlicker.TabIndex = 2;
            this.btn_Head_StopFlicker.Text = "停闪";
            this.btn_Head_StopFlicker.UseVisualStyleBackColor = true;
            this.btn_Head_StopFlicker.Click += new System.EventHandler(this.btn_Head_StopFlicker_Click);
            // 
            // btn_Head_Reset
            // 
            this.btn_Head_Reset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Head_Reset.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Head_Reset.Location = new System.Drawing.Point(475, 4);
            this.btn_Head_Reset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Head_Reset.Name = "btn_Head_Reset";
            this.btn_Head_Reset.Size = new System.Drawing.Size(151, 41);
            this.btn_Head_Reset.TabIndex = 3;
            this.btn_Head_Reset.Text = "复位";
            this.btn_Head_Reset.UseVisualStyleBackColor = true;
            this.btn_Head_Reset.Click += new System.EventHandler(this.btn_Head_Reset_Click);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 4;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel7.Controls.Add(this.btn_Ham_Connect, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.btn_Ham_Sound, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.btn_Ham_StopFlicker, 2, 0);
            this.tableLayoutPanel7.Controls.Add(this.btn_Ham_Reset, 3, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(646, 931);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(630, 49);
            this.tableLayoutPanel7.TabIndex = 29;
            // 
            // btn_Ham_Connect
            // 
            this.btn_Ham_Connect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Ham_Connect.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Ham_Connect.Location = new System.Drawing.Point(4, 4);
            this.btn_Ham_Connect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Ham_Connect.Name = "btn_Ham_Connect";
            this.btn_Ham_Connect.Size = new System.Drawing.Size(149, 41);
            this.btn_Ham_Connect.TabIndex = 0;
            this.btn_Ham_Connect.Text = "连接";
            this.btn_Ham_Connect.UseVisualStyleBackColor = true;
            this.btn_Ham_Connect.Click += new System.EventHandler(this.btn_Ham_Connect_Click);
            // 
            // btn_Ham_Sound
            // 
            this.btn_Ham_Sound.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Ham_Sound.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Ham_Sound.Location = new System.Drawing.Point(161, 4);
            this.btn_Ham_Sound.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Ham_Sound.Name = "btn_Ham_Sound";
            this.btn_Ham_Sound.Size = new System.Drawing.Size(149, 41);
            this.btn_Ham_Sound.TabIndex = 1;
            this.btn_Ham_Sound.Text = "静音";
            this.btn_Ham_Sound.UseVisualStyleBackColor = true;
            this.btn_Ham_Sound.Click += new System.EventHandler(this.btn_Ham_Sound_Click);
            // 
            // btn_Ham_StopFlicker
            // 
            this.btn_Ham_StopFlicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Ham_StopFlicker.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Ham_StopFlicker.Location = new System.Drawing.Point(318, 4);
            this.btn_Ham_StopFlicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Ham_StopFlicker.Name = "btn_Ham_StopFlicker";
            this.btn_Ham_StopFlicker.Size = new System.Drawing.Size(149, 41);
            this.btn_Ham_StopFlicker.TabIndex = 2;
            this.btn_Ham_StopFlicker.Text = "停闪";
            this.btn_Ham_StopFlicker.UseVisualStyleBackColor = true;
            this.btn_Ham_StopFlicker.Click += new System.EventHandler(this.btn_Ham_StopFlicker_Click);
            // 
            // btn_Ham_Reset
            // 
            this.btn_Ham_Reset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Ham_Reset.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Ham_Reset.Location = new System.Drawing.Point(475, 4);
            this.btn_Ham_Reset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Ham_Reset.Name = "btn_Ham_Reset";
            this.btn_Ham_Reset.Size = new System.Drawing.Size(151, 41);
            this.btn_Ham_Reset.TabIndex = 3;
            this.btn_Ham_Reset.Text = "复位";
            this.btn_Ham_Reset.UseVisualStyleBackColor = true;
            this.btn_Ham_Reset.Click += new System.EventHandler(this.btn_Ham_Reset_Click);
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 4;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel8.Controls.Add(this.btn_End_Connect, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.btn_End_Sound, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.btn_End_StopFlicker, 2, 0);
            this.tableLayoutPanel8.Controls.Add(this.btn_End_Reset, 3, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(1286, 931);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(632, 49);
            this.tableLayoutPanel8.TabIndex = 30;
            // 
            // btn_End_Connect
            // 
            this.btn_End_Connect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_End_Connect.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_End_Connect.Location = new System.Drawing.Point(4, 4);
            this.btn_End_Connect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_End_Connect.Name = "btn_End_Connect";
            this.btn_End_Connect.Size = new System.Drawing.Size(150, 41);
            this.btn_End_Connect.TabIndex = 0;
            this.btn_End_Connect.Text = "连接";
            this.btn_End_Connect.UseVisualStyleBackColor = true;
            this.btn_End_Connect.Click += new System.EventHandler(this.btn_End_Connect_Click);
            // 
            // btn_End_Sound
            // 
            this.btn_End_Sound.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_End_Sound.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_End_Sound.Location = new System.Drawing.Point(162, 4);
            this.btn_End_Sound.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_End_Sound.Name = "btn_End_Sound";
            this.btn_End_Sound.Size = new System.Drawing.Size(150, 41);
            this.btn_End_Sound.TabIndex = 1;
            this.btn_End_Sound.Text = "静音";
            this.btn_End_Sound.UseVisualStyleBackColor = true;
            this.btn_End_Sound.Click += new System.EventHandler(this.btn_End_Sound_Click);
            // 
            // btn_End_StopFlicker
            // 
            this.btn_End_StopFlicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_End_StopFlicker.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_End_StopFlicker.Location = new System.Drawing.Point(320, 4);
            this.btn_End_StopFlicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_End_StopFlicker.Name = "btn_End_StopFlicker";
            this.btn_End_StopFlicker.Size = new System.Drawing.Size(150, 41);
            this.btn_End_StopFlicker.TabIndex = 2;
            this.btn_End_StopFlicker.Text = "停闪";
            this.btn_End_StopFlicker.UseVisualStyleBackColor = true;
            this.btn_End_StopFlicker.Click += new System.EventHandler(this.btn_End_StopFlicker_Click);
            // 
            // btn_End_Reset
            // 
            this.btn_End_Reset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_End_Reset.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_End_Reset.Location = new System.Drawing.Point(478, 4);
            this.btn_End_Reset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_End_Reset.Name = "btn_End_Reset";
            this.btn_End_Reset.Size = new System.Drawing.Size(150, 41);
            this.btn_End_Reset.TabIndex = 3;
            this.btn_End_Reset.Text = "复位";
            this.btn_End_Reset.UseVisualStyleBackColor = true;
            this.btn_End_Reset.Click += new System.EventHandler(this.btn_End_Reset_Click);
            // 
            // menuStrip_Main
            // 
            this.menuStrip_Main.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看日志ToolStripMenuItem,
            this.报警音设置ToolStripMenuItem,
            this.清空照片ToolStripMenuItem,
            this.清空照片候选框ToolStripMenuItem,
            this.清空日志ToolStripMenuItem});
            this.menuStrip_Main.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_Main.Name = "menuStrip_Main";
            this.menuStrip_Main.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip_Main.Size = new System.Drawing.Size(1924, 28);
            this.menuStrip_Main.TabIndex = 1;
            this.menuStrip_Main.Text = "menuStrip1";
            // 
            // 查看日志ToolStripMenuItem
            // 
            this.查看日志ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开日志文件夹ToolStripMenuItem});
            this.查看日志ToolStripMenuItem.Name = "查看日志ToolStripMenuItem";
            this.查看日志ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.查看日志ToolStripMenuItem.Text = "查看日志";
            // 
            // 打开日志文件夹ToolStripMenuItem
            // 
            this.打开日志文件夹ToolStripMenuItem.Name = "打开日志文件夹ToolStripMenuItem";
            this.打开日志文件夹ToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.打开日志文件夹ToolStripMenuItem.Text = "打开日志文件夹";
            this.打开日志文件夹ToolStripMenuItem.Click += new System.EventHandler(this.打开日志文件夹ToolStripMenuItem_Click);
            // 
            // 报警音设置ToolStripMenuItem
            // 
            this.报警音设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.机头撕裂报警音设置ToolStripMenuItem,
            this.重锤撕裂报警音设置ToolStripMenuItem,
            this.机尾撕裂报警音设置ToolStripMenuItem});
            this.报警音设置ToolStripMenuItem.Name = "报警音设置ToolStripMenuItem";
            this.报警音设置ToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.报警音设置ToolStripMenuItem.Text = "报警音设置";
            // 
            // 机头撕裂报警音设置ToolStripMenuItem
            // 
            this.机头撕裂报警音设置ToolStripMenuItem.Name = "机头撕裂报警音设置ToolStripMenuItem";
            this.机头撕裂报警音设置ToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.机头撕裂报警音设置ToolStripMenuItem.Text = "机头撕裂报警音设置";
            this.机头撕裂报警音设置ToolStripMenuItem.Click += new System.EventHandler(this.机头撕裂报警音设置ToolStripMenuItem_Click);
            // 
            // 重锤撕裂报警音设置ToolStripMenuItem
            // 
            this.重锤撕裂报警音设置ToolStripMenuItem.Name = "重锤撕裂报警音设置ToolStripMenuItem";
            this.重锤撕裂报警音设置ToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.重锤撕裂报警音设置ToolStripMenuItem.Text = "重锤撕裂报警音设置";
            this.重锤撕裂报警音设置ToolStripMenuItem.Click += new System.EventHandler(this.重锤撕裂报警音设置ToolStripMenuItem_Click);
            // 
            // 机尾撕裂报警音设置ToolStripMenuItem
            // 
            this.机尾撕裂报警音设置ToolStripMenuItem.Name = "机尾撕裂报警音设置ToolStripMenuItem";
            this.机尾撕裂报警音设置ToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.机尾撕裂报警音设置ToolStripMenuItem.Text = "机尾撕裂报警音设置";
            this.机尾撕裂报警音设置ToolStripMenuItem.Click += new System.EventHandler(this.机尾撕裂报警音设置ToolStripMenuItem_Click);
            // 
            // 清空照片ToolStripMenuItem
            // 
            this.清空照片ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.清空机头照片ToolStripMenuItem,
            this.清空重锤照片ToolStripMenuItem,
            this.清空机尾照片ToolStripMenuItem});
            this.清空照片ToolStripMenuItem.Name = "清空照片ToolStripMenuItem";
            this.清空照片ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.清空照片ToolStripMenuItem.Text = "清空照片";
            // 
            // 清空机头照片ToolStripMenuItem
            // 
            this.清空机头照片ToolStripMenuItem.Name = "清空机头照片ToolStripMenuItem";
            this.清空机头照片ToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.清空机头照片ToolStripMenuItem.Text = "清空机头照片";
            this.清空机头照片ToolStripMenuItem.Click += new System.EventHandler(this.清空机头照片ToolStripMenuItem_Click);
            // 
            // 清空重锤照片ToolStripMenuItem
            // 
            this.清空重锤照片ToolStripMenuItem.Name = "清空重锤照片ToolStripMenuItem";
            this.清空重锤照片ToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.清空重锤照片ToolStripMenuItem.Text = "清空重锤照片";
            this.清空重锤照片ToolStripMenuItem.Click += new System.EventHandler(this.清空重锤照片ToolStripMenuItem_Click);
            // 
            // 清空机尾照片ToolStripMenuItem
            // 
            this.清空机尾照片ToolStripMenuItem.Name = "清空机尾照片ToolStripMenuItem";
            this.清空机尾照片ToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.清空机尾照片ToolStripMenuItem.Text = "清空机尾照片";
            this.清空机尾照片ToolStripMenuItem.Click += new System.EventHandler(this.清空机尾照片ToolStripMenuItem_Click);
            // 
            // 清空照片候选框ToolStripMenuItem
            // 
            this.清空照片候选框ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.清空机头照片候选框ToolStripMenuItem,
            this.清空重锤照片候选框ToolStripMenuItem,
            this.清空机尾照片候选框ToolStripMenuItem});
            this.清空照片候选框ToolStripMenuItem.Name = "清空照片候选框ToolStripMenuItem";
            this.清空照片候选框ToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.清空照片候选框ToolStripMenuItem.Text = "清空照片候选框";
            // 
            // 清空机头照片候选框ToolStripMenuItem
            // 
            this.清空机头照片候选框ToolStripMenuItem.Name = "清空机头照片候选框ToolStripMenuItem";
            this.清空机头照片候选框ToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.清空机头照片候选框ToolStripMenuItem.Text = "清空机头照片候选框";
            this.清空机头照片候选框ToolStripMenuItem.Click += new System.EventHandler(this.清空机头照片候选框ToolStripMenuItem_Click);
            // 
            // 清空重锤照片候选框ToolStripMenuItem
            // 
            this.清空重锤照片候选框ToolStripMenuItem.Name = "清空重锤照片候选框ToolStripMenuItem";
            this.清空重锤照片候选框ToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.清空重锤照片候选框ToolStripMenuItem.Text = "清空重锤照片候选框";
            this.清空重锤照片候选框ToolStripMenuItem.Click += new System.EventHandler(this.清空重锤照片候选框ToolStripMenuItem_Click);
            // 
            // 清空机尾照片候选框ToolStripMenuItem
            // 
            this.清空机尾照片候选框ToolStripMenuItem.Name = "清空机尾照片候选框ToolStripMenuItem";
            this.清空机尾照片候选框ToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.清空机尾照片候选框ToolStripMenuItem.Text = "清空机尾照片候选框";
            this.清空机尾照片候选框ToolStripMenuItem.Click += new System.EventHandler(this.清空机尾照片候选框ToolStripMenuItem_Click);
            // 
            // 清空日志ToolStripMenuItem
            // 
            this.清空日志ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.清空机头报警日志ToolStripMenuItem,
            this.清空重锤报警日志ToolStripMenuItem,
            this.清空机尾报警日志ToolStripMenuItem});
            this.清空日志ToolStripMenuItem.Name = "清空日志ToolStripMenuItem";
            this.清空日志ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.清空日志ToolStripMenuItem.Text = "清空日志";
            // 
            // 清空机头报警日志ToolStripMenuItem
            // 
            this.清空机头报警日志ToolStripMenuItem.Name = "清空机头报警日志ToolStripMenuItem";
            this.清空机头报警日志ToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.清空机头报警日志ToolStripMenuItem.Text = "清空机头报警日志";
            this.清空机头报警日志ToolStripMenuItem.Click += new System.EventHandler(this.清空机头报警日志ToolStripMenuItem_Click);
            // 
            // 清空重锤报警日志ToolStripMenuItem
            // 
            this.清空重锤报警日志ToolStripMenuItem.Name = "清空重锤报警日志ToolStripMenuItem";
            this.清空重锤报警日志ToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.清空重锤报警日志ToolStripMenuItem.Text = "清空重锤报警日志";
            this.清空重锤报警日志ToolStripMenuItem.Click += new System.EventHandler(this.清空重锤报警日志ToolStripMenuItem_Click);
            // 
            // 清空机尾报警日志ToolStripMenuItem
            // 
            this.清空机尾报警日志ToolStripMenuItem.Name = "清空机尾报警日志ToolStripMenuItem";
            this.清空机尾报警日志ToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.清空机尾报警日志ToolStripMenuItem.Text = "清空机尾报警日志";
            this.清空机尾报警日志ToolStripMenuItem.Click += new System.EventHandler(this.清空机尾报警日志ToolStripMenuItem_Click);
            // 
            // TearFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1014);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip_Main);
            this.MainMenuStrip = this.menuStrip_Main;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TearFrm";
            this.Text = "皮带撕裂监测界面";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TearFrm_FormClosing);
            this.Load += new System.EventHandler(this.TearFrm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayerHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayerHam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayerEnd)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Head)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Ham)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_End)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Head_Light)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Ham_Light)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_End_Light)).EndInit();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.menuStrip_Main.ResumeLayout(false);
            this.menuStrip_Main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.MenuStrip menuStrip_Main;
        private System.Windows.Forms.PictureBox picBox_Head;
        private System.Windows.Forms.PictureBox picBox_Ham;
        private System.Windows.Forms.PictureBox picBox_End;
        private System.Windows.Forms.Label lbl_SubTitle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private AxWMPLib.AxWindowsMediaPlayer MediaPlayerHead;
        private AxWMPLib.AxWindowsMediaPlayer MediaPlayerHam;
        private AxWMPLib.AxWindowsMediaPlayer MediaPlayerEnd;
        private System.Windows.Forms.ProgressBar progressBar_Head;
        private System.Windows.Forms.ProgressBar progressBar_Ham;
        private System.Windows.Forms.ProgressBar progressBar_End;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.ListBox listBox_Head;
        private System.Windows.Forms.ListBox listBox_Ham;
        private System.Windows.Forms.ListBox listBox_End;
        private System.Windows.Forms.TextBox txtBox_Head;
        private System.Windows.Forms.TextBox txtBox_Ham;
        private System.Windows.Forms.TextBox txtBox_End;
        private System.Windows.Forms.Button btn_Head_Connect;
        private System.Windows.Forms.Button btn_Head_Sound;
        private System.Windows.Forms.Button btn_Head_StopFlicker;
        private System.Windows.Forms.Button btn_Head_Reset;
        private System.Windows.Forms.Button btn_Ham_Connect;
        private System.Windows.Forms.Button btn_Ham_Sound;
        private System.Windows.Forms.Button btn_Ham_StopFlicker;
        private System.Windows.Forms.Button btn_Ham_Reset;
        private System.Windows.Forms.Button btn_End_Connect;
        private System.Windows.Forms.Button btn_End_Sound;
        private System.Windows.Forms.Button btn_End_StopFlicker;
        private System.Windows.Forms.Button btn_End_Reset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Head_State_01;
        private System.Windows.Forms.Label lbl_Head_State_02;
        private System.Windows.Forms.Label lbl_Head_State_03;
        private System.Windows.Forms.PictureBox picBox_Head_Light;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_Ham_State_01;
        private System.Windows.Forms.Label lbl_Ham_State_02;
        private System.Windows.Forms.Label lbl_Ham_State_03;
        private System.Windows.Forms.PictureBox picBox_Ham_Light;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_End_State_01;
        private System.Windows.Forms.Label lbl_End_State_02;
        private System.Windows.Forms.Label lbl_End_State_03;
        private System.Windows.Forms.PictureBox picBox_End_Light;
        private System.Windows.Forms.ToolStripMenuItem 查看日志ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开日志文件夹ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 报警音设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 机头撕裂报警音设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 重锤撕裂报警音设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 机尾撕裂报警音设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 清空照片ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 清空机头照片ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 清空重锤照片ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 清空机尾照片ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 清空照片候选框ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 清空机头照片候选框ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 清空重锤照片候选框ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 清空机尾照片候选框ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 清空日志ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 清空机头报警日志ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 清空重锤报警日志ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 清空机尾报警日志ToolStripMenuItem;
    }
}