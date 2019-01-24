namespace 皮带跑偏与撕裂检测监控界面
{
    partial class MainFrm
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
            this.btn_Tear = new System.Windows.Forms.Button();
            this.btn_Deviation = new System.Windows.Forms.Button();
            this.btn_Quit = new System.Windows.Forms.Button();
            this.tableLayoutPanel_Main = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.tableLayoutPanel_btn = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_Main.SuspendLayout();
            this.tableLayoutPanel_btn.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Tear
            // 
            this.btn_Tear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Tear.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Tear.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Tear.Location = new System.Drawing.Point(9, 16);
            this.btn_Tear.Name = "btn_Tear";
            this.btn_Tear.Size = new System.Drawing.Size(169, 33);
            this.btn_Tear.TabIndex = 2;
            this.btn_Tear.Text = "撕裂监测界面";
            this.btn_Tear.UseVisualStyleBackColor = true;
            this.btn_Tear.Click += new System.EventHandler(this.btn_Tear_Click);
            // 
            // btn_Deviation
            // 
            this.btn_Deviation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Deviation.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Deviation.Location = new System.Drawing.Point(197, 16);
            this.btn_Deviation.Name = "btn_Deviation";
            this.btn_Deviation.Size = new System.Drawing.Size(169, 33);
            this.btn_Deviation.TabIndex = 3;
            this.btn_Deviation.Text = "跑偏监测界面";
            this.btn_Deviation.UseVisualStyleBackColor = true;
            this.btn_Deviation.Click += new System.EventHandler(this.btn_Deviation_Click);
            // 
            // btn_Quit
            // 
            this.btn_Quit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Quit.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Quit.Location = new System.Drawing.Point(386, 16);
            this.btn_Quit.Name = "btn_Quit";
            this.btn_Quit.Size = new System.Drawing.Size(169, 33);
            this.btn_Quit.TabIndex = 4;
            this.btn_Quit.Text = "退出";
            this.btn_Quit.UseVisualStyleBackColor = true;
            this.btn_Quit.Click += new System.EventHandler(this.btn_Quit_Click);
            // 
            // tableLayoutPanel_Main
            // 
            this.tableLayoutPanel_Main.ColumnCount = 1;
            this.tableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_Main.Controls.Add(this.lbl_Title, 0, 0);
            this.tableLayoutPanel_Main.Controls.Add(this.tableLayoutPanel_btn, 0, 2);
            this.tableLayoutPanel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Main.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_Main.Name = "tableLayoutPanel_Main";
            this.tableLayoutPanel_Main.RowCount = 4;
            this.tableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_Main.Size = new System.Drawing.Size(575, 286);
            this.tableLayoutPanel_Main.TabIndex = 5;
            // 
            // lbl_Title
            // 
            this.lbl_Title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("宋体", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Title.Location = new System.Drawing.Point(15, 16);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(545, 38);
            this.lbl_Title.TabIndex = 1;
            this.lbl_Title.Text = "屯兰选煤厂708皮带监控主界面";
            // 
            // tableLayoutPanel_btn
            // 
            this.tableLayoutPanel_btn.ColumnCount = 3;
            this.tableLayoutPanel_btn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_btn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_btn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_btn.Controls.Add(this.btn_Tear, 0, 0);
            this.tableLayoutPanel_btn.Controls.Add(this.btn_Quit, 2, 0);
            this.tableLayoutPanel_btn.Controls.Add(this.btn_Deviation, 1, 0);
            this.tableLayoutPanel_btn.Location = new System.Drawing.Point(3, 145);
            this.tableLayoutPanel_btn.Name = "tableLayoutPanel_btn";
            this.tableLayoutPanel_btn.RowCount = 1;
            this.tableLayoutPanel_btn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_btn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_btn.Size = new System.Drawing.Size(566, 65);
            this.tableLayoutPanel_btn.TabIndex = 2;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 286);
            this.Controls.Add(this.tableLayoutPanel_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(591, 325);
            this.MinimumSize = new System.Drawing.Size(591, 325);
            this.Name = "MainFrm";
            this.Text = "监控主界面";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFrm_FormClosing);
            this.tableLayoutPanel_Main.ResumeLayout(false);
            this.tableLayoutPanel_Main.PerformLayout();
            this.tableLayoutPanel_btn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Tear;
        private System.Windows.Forms.Button btn_Deviation;
        private System.Windows.Forms.Button btn_Quit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Main;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_btn;
    }
}

