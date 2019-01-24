namespace Question2
{
    partial class Main_Frm
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
            this.btn_Server = new System.Windows.Forms.Button();
            this.btn_Client = new System.Windows.Forms.Button();
            this.lbl_Group = new System.Windows.Forms.Label();
            this.lbl_Member1 = new System.Windows.Forms.Label();
            this.lbl_Member2 = new System.Windows.Forms.Label();
            this.lbl_Member3 = new System.Windows.Forms.Label();
            this.lbl_Member4 = new System.Windows.Forms.Label();
            this.lbl_Time = new System.Windows.Forms.Label();
            this.lbl_TimeNow = new System.Windows.Forms.Label();
            this.timer_Now = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btn_Server
            // 
            this.btn_Server.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Server.Location = new System.Drawing.Point(63, 177);
            this.btn_Server.Name = "btn_Server";
            this.btn_Server.Size = new System.Drawing.Size(154, 57);
            this.btn_Server.TabIndex = 0;
            this.btn_Server.Text = "服务器端";
            this.btn_Server.UseVisualStyleBackColor = true;
            this.btn_Server.Click += new System.EventHandler(this.btn_Server_Click);
            // 
            // btn_Client
            // 
            this.btn_Client.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Client.Location = new System.Drawing.Point(280, 177);
            this.btn_Client.Name = "btn_Client";
            this.btn_Client.Size = new System.Drawing.Size(154, 57);
            this.btn_Client.TabIndex = 1;
            this.btn_Client.Text = "客户端";
            this.btn_Client.UseVisualStyleBackColor = true;
            this.btn_Client.Click += new System.EventHandler(this.btn_Client_Click);
            // 
            // lbl_Group
            // 
            this.lbl_Group.AutoSize = true;
            this.lbl_Group.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Group.Location = new System.Drawing.Point(104, 28);
            this.lbl_Group.Name = "lbl_Group";
            this.lbl_Group.Size = new System.Drawing.Size(85, 24);
            this.lbl_Group.TabIndex = 2;
            this.lbl_Group.Text = "组员：";
            // 
            // lbl_Member1
            // 
            this.lbl_Member1.AutoSize = true;
            this.lbl_Member1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Member1.Location = new System.Drawing.Point(177, 28);
            this.lbl_Member1.Name = "lbl_Member1";
            this.lbl_Member1.Size = new System.Drawing.Size(215, 24);
            this.lbl_Member1.TabIndex = 3;
            this.lbl_Member1.Text = "刘  权：18722189";
            // 
            // lbl_Member2
            // 
            this.lbl_Member2.AutoSize = true;
            this.lbl_Member2.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Member2.Location = new System.Drawing.Point(177, 58);
            this.lbl_Member2.Name = "lbl_Member2";
            this.lbl_Member2.Size = new System.Drawing.Size(215, 24);
            this.lbl_Member2.TabIndex = 4;
            this.lbl_Member2.Text = "朱  帅：18722191";
            // 
            // lbl_Member3
            // 
            this.lbl_Member3.AutoSize = true;
            this.lbl_Member3.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Member3.Location = new System.Drawing.Point(177, 88);
            this.lbl_Member3.Name = "lbl_Member3";
            this.lbl_Member3.Size = new System.Drawing.Size(215, 24);
            this.lbl_Member3.TabIndex = 5;
            this.lbl_Member3.Text = "陆  伟：18722192";
            // 
            // lbl_Member4
            // 
            this.lbl_Member4.AutoSize = true;
            this.lbl_Member4.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Member4.Location = new System.Drawing.Point(177, 118);
            this.lbl_Member4.Name = "lbl_Member4";
            this.lbl_Member4.Size = new System.Drawing.Size(214, 24);
            this.lbl_Member4.TabIndex = 6;
            this.lbl_Member4.Text = "邵明贺：18722193";
            // 
            // lbl_Time
            // 
            this.lbl_Time.AutoSize = true;
            this.lbl_Time.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Time.Location = new System.Drawing.Point(154, 255);
            this.lbl_Time.Name = "lbl_Time";
            this.lbl_Time.Size = new System.Drawing.Size(73, 24);
            this.lbl_Time.TabIndex = 7;
            this.lbl_Time.Text = "时间:";
            // 
            // lbl_TimeNow
            // 
            this.lbl_TimeNow.AutoSize = true;
            this.lbl_TimeNow.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_TimeNow.Location = new System.Drawing.Point(237, 255);
            this.lbl_TimeNow.Name = "lbl_TimeNow";
            this.lbl_TimeNow.Size = new System.Drawing.Size(0, 24);
            this.lbl_TimeNow.TabIndex = 8;
            // 
            // timer_Now
            // 
            this.timer_Now.Interval = 1000;
            this.timer_Now.Tick += new System.EventHandler(this.timer_Now_Tick);
            // 
            // Main_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 313);
            this.Controls.Add(this.lbl_TimeNow);
            this.Controls.Add(this.lbl_Time);
            this.Controls.Add(this.lbl_Member4);
            this.Controls.Add(this.lbl_Member3);
            this.Controls.Add(this.lbl_Member2);
            this.Controls.Add(this.lbl_Member1);
            this.Controls.Add(this.lbl_Group);
            this.Controls.Add(this.btn_Client);
            this.Controls.Add(this.btn_Server);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(524, 352);
            this.MinimumSize = new System.Drawing.Size(524, 352);
            this.Name = "Main_Frm";
            this.Text = "主控制台";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_Frm_FormClosing);
            this.Load += new System.EventHandler(this.Main_Frm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Server;
        private System.Windows.Forms.Button btn_Client;
        private System.Windows.Forms.Label lbl_Group;
        private System.Windows.Forms.Label lbl_Member1;
        private System.Windows.Forms.Label lbl_Member2;
        private System.Windows.Forms.Label lbl_Member3;
        private System.Windows.Forms.Label lbl_Member4;
        private System.Windows.Forms.Label lbl_Time;
        private System.Windows.Forms.Label lbl_TimeNow;
        private System.Windows.Forms.Timer timer_Now;
    }
}

