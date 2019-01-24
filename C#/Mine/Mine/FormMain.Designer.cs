namespace Mine
{
    partial class Form_Main
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
            this.lbl_Title = new System.Windows.Forms.Label();
            this.btn_Deviation = new System.Windows.Forms.Button();
            this.btn_Tear = new System.Windows.Forms.Button();
            this.btn_Quit = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lbl_Time = new System.Windows.Forms.Label();
            this.timer_SysTime = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("宋体", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Title.Location = new System.Drawing.Point(22, 43);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(530, 38);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "屯兰选煤厂708皮带监控主界面";
            // 
            // btn_Deviation
            // 
            this.btn_Deviation.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Deviation.Location = new System.Drawing.Point(12, 163);
            this.btn_Deviation.Name = "btn_Deviation";
            this.btn_Deviation.Size = new System.Drawing.Size(169, 33);
            this.btn_Deviation.TabIndex = 1;
            this.btn_Deviation.Text = "皮带跑偏监控界面";
            this.btn_Deviation.UseVisualStyleBackColor = true;
            this.btn_Deviation.Click += new System.EventHandler(this.btn_Deviation_Click);
            // 
            // btn_Tear
            // 
            this.btn_Tear.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Tear.Location = new System.Drawing.Point(201, 163);
            this.btn_Tear.Name = "btn_Tear";
            this.btn_Tear.Size = new System.Drawing.Size(169, 33);
            this.btn_Tear.TabIndex = 2;
            this.btn_Tear.Text = "皮带撕裂监控界面";
            this.btn_Tear.UseVisualStyleBackColor = true;
            this.btn_Tear.Click += new System.EventHandler(this.btn_Tear_Click);
            // 
            // btn_Quit
            // 
            this.btn_Quit.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Quit.Location = new System.Drawing.Point(394, 163);
            this.btn_Quit.Name = "btn_Quit";
            this.btn_Quit.Size = new System.Drawing.Size(169, 33);
            this.btn_Quit.TabIndex = 3;
            this.btn_Quit.Text = "退出";
            this.btn_Quit.UseVisualStyleBackColor = true;
            this.btn_Quit.Click += new System.EventHandler(this.btn_Quit_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTimePicker.Location = new System.Drawing.Point(12, 228);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(142, 26);
            this.dateTimePicker.TabIndex = 4;
            // 
            // lbl_Time
            // 
            this.lbl_Time.AutoSize = true;
            this.lbl_Time.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Time.Location = new System.Drawing.Point(171, 228);
            this.lbl_Time.Name = "lbl_Time";
            this.lbl_Time.Size = new System.Drawing.Size(0, 22);
            this.lbl_Time.TabIndex = 5;
            // 
            // timer_SysTime
            // 
            this.timer_SysTime.Interval = 1000;
            this.timer_SysTime.Tick += new System.EventHandler(this.timer_SysTime_Tick);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 286);
            this.Controls.Add(this.lbl_Time);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.btn_Quit);
            this.Controls.Add(this.btn_Tear);
            this.Controls.Add(this.btn_Deviation);
            this.Controls.Add(this.lbl_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(591, 325);
            this.MinimumSize = new System.Drawing.Size(591, 325);
            this.Name = "Form_Main";
            this.Text = "皮带监控界面";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Main_FormClosing);
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Button btn_Deviation;
        private System.Windows.Forms.Button btn_Tear;
        private System.Windows.Forms.Button btn_Quit;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label lbl_Time;
        private System.Windows.Forms.Timer timer_SysTime;
    }
}

