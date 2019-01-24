namespace notebook
{
    partial class FrmParent
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsm_File = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_NewItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Close = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_CloseAll = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Quit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_File});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(581, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsm_File
            // 
            this.tsm_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_NewItem,
            this.tsm_Close,
            this.tsm_CloseAll,
            this.tsm_Quit});
            this.tsm_File.Name = "tsm_File";
            this.tsm_File.Size = new System.Drawing.Size(44, 21);
            this.tsm_File.Text = "文件";
            // 
            // tsm_NewItem
            // 
            this.tsm_NewItem.Name = "tsm_NewItem";
            this.tsm_NewItem.Size = new System.Drawing.Size(152, 22);
            this.tsm_NewItem.Text = "新建";
            this.tsm_NewItem.Click += new System.EventHandler(this.tsm_NewItem_Click);
            // 
            // tsm_Close
            // 
            this.tsm_Close.Name = "tsm_Close";
            this.tsm_Close.Size = new System.Drawing.Size(152, 22);
            this.tsm_Close.Text = "关闭";
            this.tsm_Close.Click += new System.EventHandler(this.tsm_Close_Click);
            // 
            // tsm_CloseAll
            // 
            this.tsm_CloseAll.Name = "tsm_CloseAll";
            this.tsm_CloseAll.Size = new System.Drawing.Size(152, 22);
            this.tsm_CloseAll.Text = "关闭全部";
            this.tsm_CloseAll.Click += new System.EventHandler(this.tsm_CloseAll_Click);
            // 
            // tsm_Quit
            // 
            this.tsm_Quit.Name = "tsm_Quit";
            this.tsm_Quit.Size = new System.Drawing.Size(152, 22);
            this.tsm_Quit.Text = "退出";
            this.tsm_Quit.Click += new System.EventHandler(this.tsm_Quit_Click);
            // 
            // FrmParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 403);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmParent";
            this.Text = "FrmParent";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsm_File;
        private System.Windows.Forms.ToolStripMenuItem tsm_NewItem;
        private System.Windows.Forms.ToolStripMenuItem tsm_Close;
        private System.Windows.Forms.ToolStripMenuItem tsm_CloseAll;
        private System.Windows.Forms.ToolStripMenuItem tsm_Quit;
    }
}