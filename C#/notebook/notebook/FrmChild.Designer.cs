namespace notebook
{
    partial class FrmChild
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
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tscbox_Fonts = new System.Windows.Forms.ToolStripComboBox();
            this.tscbox_Size = new System.Windows.Forms.ToolStripComboBox();
            this.txtBox_Note = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.tsbtn_New = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_Open = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_Save = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_Bold = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_Italic = new System.Windows.Forms.ToolStripButton();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtn_New,
            this.tsbtn_Open,
            this.tsbtn_Save,
            this.tsbtn_Bold,
            this.tsbtn_Italic,
            this.tscbox_Fonts,
            this.tscbox_Size});
            this.toolStrip.Location = new System.Drawing.Point(2, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(526, 27);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip";
            // 
            // tscbox_Fonts
            // 
            this.tscbox_Fonts.DropDownWidth = 200;
            this.tscbox_Fonts.Name = "tscbox_Fonts";
            this.tscbox_Fonts.Size = new System.Drawing.Size(92, 27);
            this.tscbox_Fonts.Text = "字体";
            this.tscbox_Fonts.SelectedIndexChanged += new System.EventHandler(this.tscbox_Fonts_SelectedIndexChanged);
            // 
            // tscbox_Size
            // 
            this.tscbox_Size.Items.AddRange(new object[] {
            "2",
            "4",
            "6",
            "8",
            "10",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "30"});
            this.tscbox_Size.Name = "tscbox_Size";
            this.tscbox_Size.Size = new System.Drawing.Size(92, 27);
            this.tscbox_Size.Tag = "";
            this.tscbox_Size.Text = "字号";
            this.tscbox_Size.SelectedIndexChanged += new System.EventHandler(this.tscbox_Size_SelectedIndexChanged);
            this.tscbox_Size.TextChanged += new System.EventHandler(this.tscbox_Size_TextChanged);
            // 
            // txtBox_Note
            // 
            this.txtBox_Note.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBox_Note.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBox_Note.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBox_Note.Location = new System.Drawing.Point(2, 27);
            this.txtBox_Note.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBox_Note.Multiline = true;
            this.txtBox_Note.Name = "txtBox_Note";
            this.txtBox_Note.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBox_Note.Size = new System.Drawing.Size(526, 480);
            this.txtBox_Note.TabIndex = 2;
            this.txtBox_Note.TextChanged += new System.EventHandler(this.txtBox_Note_TextChanged);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // tsbtn_New
            // 
            this.tsbtn_New.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtn_New.Image = global::notebook.Properties.Resources.EditDocument_128px_1194764_easyicon_net;
            this.tsbtn_New.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_New.Name = "tsbtn_New";
            this.tsbtn_New.Size = new System.Drawing.Size(24, 24);
            this.tsbtn_New.Text = "新建";
            this.tsbtn_New.Click += new System.EventHandler(this.tsbtn_New_Click);
            // 
            // tsbtn_Open
            // 
            this.tsbtn_Open.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtn_Open.Image = global::notebook.Properties.Resources.open_48px_1134005_easyicon_net;
            this.tsbtn_Open.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_Open.Name = "tsbtn_Open";
            this.tsbtn_Open.Size = new System.Drawing.Size(24, 24);
            this.tsbtn_Open.Text = "打开";
            this.tsbtn_Open.Click += new System.EventHandler(this.tsbtn_Open_Click);
            // 
            // tsbtn_Save
            // 
            this.tsbtn_Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtn_Save.Image = global::notebook.Properties.Resources.Save_128px_1186318_easyicon_net;
            this.tsbtn_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_Save.Name = "tsbtn_Save";
            this.tsbtn_Save.Size = new System.Drawing.Size(24, 24);
            this.tsbtn_Save.Text = "保存";
            this.tsbtn_Save.Click += new System.EventHandler(this.tsbtn_Save_Click);
            // 
            // tsbtn_Bold
            // 
            this.tsbtn_Bold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtn_Bold.Image = global::notebook.Properties.Resources.B_Letter_128px_1121406_easyicon_net;
            this.tsbtn_Bold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_Bold.Name = "tsbtn_Bold";
            this.tsbtn_Bold.Size = new System.Drawing.Size(24, 24);
            this.tsbtn_Bold.Text = "加粗";
            this.tsbtn_Bold.Click += new System.EventHandler(this.tsbtn_Bold_Click);
            // 
            // tsbtn_Italic
            // 
            this.tsbtn_Italic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtn_Italic.Image = global::notebook.Properties.Resources.tipped_56px_527695_easyicon_net;
            this.tsbtn_Italic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_Italic.Name = "tsbtn_Italic";
            this.tsbtn_Italic.Size = new System.Drawing.Size(24, 24);
            this.tsbtn_Italic.Text = "倾斜";
            this.tsbtn_Italic.Click += new System.EventHandler(this.tsbtn_Italic_Click);
            // 
            // FrmChild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 509);
            this.Controls.Add(this.txtBox_Note);
            this.Controls.Add(this.toolStrip);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmChild";
            this.Padding = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmChild_FormClosing);
            this.Load += new System.EventHandler(this.FrmChild_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton tsbtn_Open;
        private System.Windows.Forms.ToolStripButton tsbtn_Save;
        private System.Windows.Forms.ToolStripButton tsbtn_Bold;
        private System.Windows.Forms.ToolStripButton tsbtn_Italic;
        private System.Windows.Forms.ToolStripComboBox tscbox_Fonts;
        private System.Windows.Forms.ToolStripComboBox tscbox_Size;
        private System.Windows.Forms.TextBox txtBox_Note;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripButton tsbtn_New;
    }
}