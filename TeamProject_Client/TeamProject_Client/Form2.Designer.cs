namespace TeamProject_Client
{
    partial class Form2
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pn_txt = new System.Windows.Forms.TextBox();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.send2server_btn = new System.Windows.Forms.Button();
            this.quit_btn = new System.Windows.Forms.Button();
            this.addressCombo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 14F);
            this.label5.Location = new System.Drawing.Point(10, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "주소";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 14F);
            this.label4.Location = new System.Drawing.Point(10, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 19);
            this.label4.TabIndex = 17;
            this.label4.Text = "휴대폰번호";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 14F);
            this.label3.Location = new System.Drawing.Point(10, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "이름";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 15F);
            this.label2.Location = new System.Drawing.Point(10, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "주문 정보 입력";
            // 
            // pn_txt
            // 
            this.pn_txt.Font = new System.Drawing.Font("굴림", 11F);
            this.pn_txt.Location = new System.Drawing.Point(120, 110);
            this.pn_txt.Name = "pn_txt";
            this.pn_txt.Size = new System.Drawing.Size(210, 24);
            this.pn_txt.TabIndex = 13;
            // 
            // name_txt
            // 
            this.name_txt.Font = new System.Drawing.Font("굴림", 11F);
            this.name_txt.Location = new System.Drawing.Point(120, 80);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(210, 24);
            this.name_txt.TabIndex = 15;
            // 
            // send2server_btn
            // 
            this.send2server_btn.Location = new System.Drawing.Point(130, 210);
            this.send2server_btn.Name = "send2server_btn";
            this.send2server_btn.Size = new System.Drawing.Size(110, 48);
            this.send2server_btn.TabIndex = 20;
            this.send2server_btn.Text = "주문하기";
            this.send2server_btn.UseVisualStyleBackColor = true;
            this.send2server_btn.Click += new System.EventHandler(this.send2server_btn_Click);
            // 
            // quit_btn
            // 
            this.quit_btn.Location = new System.Drawing.Point(240, 210);
            this.quit_btn.Name = "quit_btn";
            this.quit_btn.Size = new System.Drawing.Size(102, 46);
            this.quit_btn.TabIndex = 20;
            this.quit_btn.Text = "취소";
            this.quit_btn.UseVisualStyleBackColor = true;
            this.quit_btn.Click += new System.EventHandler(this.quit_btn_Click);
            // 
            // addressCombo
            // 
            this.addressCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addressCombo.Font = new System.Drawing.Font("굴림", 11F);
            this.addressCombo.FormattingEnabled = true;
            this.addressCombo.Location = new System.Drawing.Point(120, 140);
            this.addressCombo.Name = "addressCombo";
            this.addressCombo.Size = new System.Drawing.Size(210, 23);
            this.addressCombo.TabIndex = 21;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 261);
            this.Controls.Add(this.addressCombo);
            this.Controls.Add(this.quit_btn);
            this.Controls.Add(this.send2server_btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pn_txt);
            this.Controls.Add(this.name_txt);
            this.Name = "Form2";
            this.Text = "주문 정보 입력";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pn_txt;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.Button send2server_btn;
        private System.Windows.Forms.Button quit_btn;
        private System.Windows.Forms.ComboBox addressCombo;
    }
}