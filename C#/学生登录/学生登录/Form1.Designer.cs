namespace 学生登录
{
    partial class Frm_Login
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
            this.lbl_User = new System.Windows.Forms.Label();
            this.lbl_Pwd = new System.Windows.Forms.Label();
            this.txtBox_User = new System.Windows.Forms.TextBox();
            this.txtBox_Pwd = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_User
            // 
            this.lbl_User.AutoSize = true;
            this.lbl_User.Location = new System.Drawing.Point(81, 72);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(67, 15);
            this.lbl_User.TabIndex = 0;
            this.lbl_User.Text = "用户名：";
            // 
            // lbl_Pwd
            // 
            this.lbl_Pwd.AutoSize = true;
            this.lbl_Pwd.Location = new System.Drawing.Point(81, 106);
            this.lbl_Pwd.Name = "lbl_Pwd";
            this.lbl_Pwd.Size = new System.Drawing.Size(68, 15);
            this.lbl_Pwd.TabIndex = 1;
            this.lbl_Pwd.Text = "密  码：";
            // 
            // txtBox_User
            // 
            this.txtBox_User.Location = new System.Drawing.Point(174, 62);
            this.txtBox_User.MaxLength = 12;
            this.txtBox_User.Name = "txtBox_User";
            this.txtBox_User.Size = new System.Drawing.Size(199, 25);
            this.txtBox_User.TabIndex = 1;
            // 
            // txtBox_Pwd
            // 
            this.txtBox_Pwd.Location = new System.Drawing.Point(174, 103);
            this.txtBox_Pwd.MaxLength = 12;
            this.txtBox_Pwd.Name = "txtBox_Pwd";
            this.txtBox_Pwd.PasswordChar = '*';
            this.txtBox_Pwd.Size = new System.Drawing.Size(199, 25);
            this.txtBox_Pwd.TabIndex = 2;
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(174, 154);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(91, 34);
            this.btn_Login.TabIndex = 3;
            this.btn_Login.Text = "登录";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(282, 154);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(91, 34);
            this.btn_Cancel.TabIndex = 4;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 291);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txtBox_Pwd);
            this.Controls.Add(this.txtBox_User);
            this.Controls.Add(this.lbl_Pwd);
            this.Controls.Add(this.lbl_User);
            this.MaximumSize = new System.Drawing.Size(516, 338);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(516, 338);
            this.Name = "Frm_Login";
            this.Text = "用户登录";
            this.Load += new System.EventHandler(this.Frm_Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_User;
        private System.Windows.Forms.Label lbl_Pwd;
        private System.Windows.Forms.TextBox txtBox_User;
        private System.Windows.Forms.TextBox txtBox_Pwd;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_Cancel;
    }
}

