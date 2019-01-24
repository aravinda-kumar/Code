namespace Pic_to_Bin
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
            this.btn_Load = new System.Windows.Forms.Button();
            this.txtBox_Path = new System.Windows.Forms.TextBox();
            this.btn_ToBin = new System.Windows.Forms.Button();
            this.btn_ToPic = new System.Windows.Forms.Button();
            this.pic_Oringin = new System.Windows.Forms.PictureBox();
            this.richTextBox_Bin = new System.Windows.Forms.RichTextBox();
            this.pic_Convert = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Oringin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Convert)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Load
            // 
            this.btn_Load.Location = new System.Drawing.Point(12, 22);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(111, 36);
            this.btn_Load.TabIndex = 0;
            this.btn_Load.Text = "加载图片";
            this.btn_Load.UseVisualStyleBackColor = true;
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // txtBox_Path
            // 
            this.txtBox_Path.Location = new System.Drawing.Point(12, 64);
            this.txtBox_Path.Name = "txtBox_Path";
            this.txtBox_Path.Size = new System.Drawing.Size(345, 21);
            this.txtBox_Path.TabIndex = 1;
            // 
            // btn_ToBin
            // 
            this.btn_ToBin.Location = new System.Drawing.Point(129, 22);
            this.btn_ToBin.Name = "btn_ToBin";
            this.btn_ToBin.Size = new System.Drawing.Size(111, 36);
            this.btn_ToBin.TabIndex = 2;
            this.btn_ToBin.Text = "转二进制";
            this.btn_ToBin.UseVisualStyleBackColor = true;
            this.btn_ToBin.Click += new System.EventHandler(this.btn_ToBin_Click);
            // 
            // btn_ToPic
            // 
            this.btn_ToPic.Location = new System.Drawing.Point(246, 22);
            this.btn_ToPic.Name = "btn_ToPic";
            this.btn_ToPic.Size = new System.Drawing.Size(111, 36);
            this.btn_ToPic.TabIndex = 3;
            this.btn_ToPic.Text = "生成图片";
            this.btn_ToPic.UseVisualStyleBackColor = true;
            this.btn_ToPic.Click += new System.EventHandler(this.btn_ToPic_Click);
            // 
            // pic_Oringin
            // 
            this.pic_Oringin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic_Oringin.Location = new System.Drawing.Point(12, 91);
            this.pic_Oringin.Name = "pic_Oringin";
            this.pic_Oringin.Size = new System.Drawing.Size(270, 270);
            this.pic_Oringin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Oringin.TabIndex = 4;
            this.pic_Oringin.TabStop = false;
            // 
            // richTextBox_Bin
            // 
            this.richTextBox_Bin.Location = new System.Drawing.Point(288, 91);
            this.richTextBox_Bin.Name = "richTextBox_Bin";
            this.richTextBox_Bin.Size = new System.Drawing.Size(270, 270);
            this.richTextBox_Bin.TabIndex = 5;
            this.richTextBox_Bin.Text = "";
            // 
            // pic_Convert
            // 
            this.pic_Convert.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic_Convert.Location = new System.Drawing.Point(564, 91);
            this.pic_Convert.Name = "pic_Convert";
            this.pic_Convert.Size = new System.Drawing.Size(320, 240);
            this.pic_Convert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Convert.TabIndex = 6;
            this.pic_Convert.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 373);
            this.Controls.Add(this.pic_Convert);
            this.Controls.Add(this.richTextBox_Bin);
            this.Controls.Add(this.pic_Oringin);
            this.Controls.Add(this.btn_ToPic);
            this.Controls.Add(this.btn_ToBin);
            this.Controls.Add(this.txtBox_Path);
            this.Controls.Add(this.btn_Load);
            this.Name = "Form1";
            this.Text = "图片转换";
            ((System.ComponentModel.ISupportInitialize)(this.pic_Oringin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Convert)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Load;
        private System.Windows.Forms.TextBox txtBox_Path;
        private System.Windows.Forms.Button btn_ToBin;
        private System.Windows.Forms.Button btn_ToPic;
        private System.Windows.Forms.PictureBox pic_Oringin;
        private System.Windows.Forms.RichTextBox richTextBox_Bin;
        private System.Windows.Forms.PictureBox pic_Convert;
    }
}

