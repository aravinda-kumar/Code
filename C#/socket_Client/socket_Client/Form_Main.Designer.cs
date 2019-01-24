namespace socket_Client
{
    partial class Form_Main
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
            this.btn_New = new System.Windows.Forms.Button();
            this.btn_Quit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_New
            // 
            this.btn_New.Location = new System.Drawing.Point(128, 88);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(327, 37);
            this.btn_New.TabIndex = 0;
            this.btn_New.Text = "新建";
            this.btn_New.UseVisualStyleBackColor = true;
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // btn_Quit
            // 
            this.btn_Quit.Location = new System.Drawing.Point(128, 169);
            this.btn_Quit.Name = "btn_Quit";
            this.btn_Quit.Size = new System.Drawing.Size(327, 38);
            this.btn_Quit.TabIndex = 1;
            this.btn_Quit.Text = "退出";
            this.btn_Quit.UseVisualStyleBackColor = true;
            this.btn_Quit.Click += new System.EventHandler(this.btn_Quit_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 370);
            this.Controls.Add(this.btn_Quit);
            this.Controls.Add(this.btn_New);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(601, 409);
            this.MinimumSize = new System.Drawing.Size(601, 409);
            this.Name = "Form_Main";
            this.Text = "Form_Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_New;
        private System.Windows.Forms.Button btn_Quit;
    }
}