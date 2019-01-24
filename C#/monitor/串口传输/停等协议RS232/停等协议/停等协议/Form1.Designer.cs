namespace 停等协议
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.sendPanel = new System.Windows.Forms.Panel();
            this.text = new System.Windows.Forms.TextBox();
            this.receivePanel = new System.Windows.Forms.Panel();
            this.revtext = new System.Windows.Forms.TextBox();
            this.axMSComm1 = new AxMSCommLib.AxMSComm();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axMSComm1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(307, 427);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "浏览";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(388, 427);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "发送";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(469, 427);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "保存";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // sendPanel
            // 
            this.sendPanel.AutoScroll = true;
            this.sendPanel.Location = new System.Drawing.Point(13, 258);
            this.sendPanel.Name = "sendPanel";
            this.sendPanel.Size = new System.Drawing.Size(613, 146);
            this.sendPanel.TabIndex = 8;
            // 
            // text
            // 
            this.text.Location = new System.Drawing.Point(3, 0);
            this.text.Multiline = true;
            this.text.Name = "text";
            this.text.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.text.Size = new System.Drawing.Size(610, 146);
            this.text.TabIndex = 0;
            // 
            // receivePanel
            // 
            this.receivePanel.AutoScroll = true;
            this.receivePanel.Location = new System.Drawing.Point(13, 13);
            this.receivePanel.Name = "receivePanel";
            this.receivePanel.Size = new System.Drawing.Size(613, 201);
            this.receivePanel.TabIndex = 9;
            // 
            // revtext
            // 
            this.revtext.Location = new System.Drawing.Point(0, 0);
            this.revtext.Multiline = true;
            this.revtext.Name = "revtext";
            this.revtext.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.revtext.Size = new System.Drawing.Size(610, 201);
            this.revtext.TabIndex = 0;
            // 
            // axMSComm1
            // 
            this.axMSComm1.Enabled = true;
            this.axMSComm1.Location = new System.Drawing.Point(35, 214);
            this.axMSComm1.Name = "axMSComm1";
            this.axMSComm1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMSComm1.OcxState")));
            this.axMSComm1.Size = new System.Drawing.Size(38, 38);
            this.axMSComm1.TabIndex = 10;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(550, 427);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "接收";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(305, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "请选择发送或者接收";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 462);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.axMSComm1);
            this.Controls.Add(this.receivePanel);
            this.Controls.Add(this.sendPanel);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.axMSComm1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

      
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel sendPanel;
        private System.Windows.Forms.Panel receivePanel;
        private System.Windows.Forms.TextBox text;
        private System.Windows.Forms.TextBox revtext;
        private AxMSCommLib.AxMSComm axMSComm1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
    }
}

