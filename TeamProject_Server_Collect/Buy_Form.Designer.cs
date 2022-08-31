namespace TeamProject_Server_Collect
{
    partial class Buy_Form
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
            this.components = new System.ComponentModel.Container();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.주문하기 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.모든책주문 = new System.Windows.Forms.Button();
            this.조회하기 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.종료 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.progressBar5 = new System.Windows.Forms.ProgressBar();
            this.progressBar6 = new System.Windows.Forms.ProgressBar();
            this.progressBar7 = new System.Windows.Forms.ProgressBar();
            this.progressBar8 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(10, 10);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(150, 232);
            this.listBox1.TabIndex = 18;
            // 
            // 주문하기
            // 
            this.주문하기.Location = new System.Drawing.Point(650, 140);
            this.주문하기.Name = "주문하기";
            this.주문하기.Size = new System.Drawing.Size(120, 43);
            this.주문하기.TabIndex = 17;
            this.주문하기.Text = "주문하기";
            this.주문하기.UseVisualStyleBackColor = true;
            this.주문하기.Click += new System.EventHandler(this.주문하기_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("나눔고딕코딩", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.numericUpDown1.Location = new System.Drawing.Point(650, 60);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown1.TabIndex = 16;
            // 
            // 모든책주문
            // 
            this.모든책주문.Location = new System.Drawing.Point(650, 90);
            this.모든책주문.Name = "모든책주문";
            this.모든책주문.Size = new System.Drawing.Size(120, 43);
            this.모든책주문.TabIndex = 15;
            this.모든책주문.Text = "모든 책 주문하기";
            this.모든책주문.UseVisualStyleBackColor = true;
            this.모든책주문.Click += new System.EventHandler(this.모든책주문_Click);
            // 
            // 조회하기
            // 
            this.조회하기.Location = new System.Drawing.Point(650, 190);
            this.조회하기.Name = "조회하기";
            this.조회하기.Size = new System.Drawing.Size(120, 43);
            this.조회하기.TabIndex = 14;
            this.조회하기.Text = "조회하기";
            this.조회하기.UseVisualStyleBackColor = true;
            this.조회하기.Click += new System.EventHandler(this.조회하기_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(170, 10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(460, 230);
            this.dataGridView1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕코딩", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(670, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "주문 수량";
            // 
            // 종료
            // 
            this.종료.Location = new System.Drawing.Point(650, 360);
            this.종료.Name = "종료";
            this.종료.Size = new System.Drawing.Size(120, 43);
            this.종료.TabIndex = 14;
            this.종료.Text = "종료";
            this.종료.UseVisualStyleBackColor = true;
            this.종료.Click += new System.EventHandler(this.종료_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(160, 280);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(140, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 20;
            this.progressBar1.MouseHover += new System.EventHandler(this.progressBar1_MouseHover);
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(160, 310);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(140, 23);
            this.progressBar2.Step = 1;
            this.progressBar2.TabIndex = 20;
            this.progressBar2.MouseHover += new System.EventHandler(this.progressBar2_MouseHover);
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(160, 340);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(140, 23);
            this.progressBar3.Step = 1;
            this.progressBar3.TabIndex = 20;
            this.progressBar3.MouseHover += new System.EventHandler(this.progressBar3_MouseHover);
            // 
            // progressBar4
            // 
            this.progressBar4.Location = new System.Drawing.Point(160, 370);
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(140, 23);
            this.progressBar4.Step = 1;
            this.progressBar4.TabIndex = 20;
            this.progressBar4.MouseHover += new System.EventHandler(this.progressBar4_MouseHover);
            // 
            // progressBar5
            // 
            this.progressBar5.Location = new System.Drawing.Point(490, 280);
            this.progressBar5.Name = "progressBar5";
            this.progressBar5.Size = new System.Drawing.Size(140, 23);
            this.progressBar5.Step = 1;
            this.progressBar5.TabIndex = 20;
            this.progressBar5.MouseHover += new System.EventHandler(this.progressBar5_MouseHover);
            // 
            // progressBar6
            // 
            this.progressBar6.Location = new System.Drawing.Point(490, 310);
            this.progressBar6.Name = "progressBar6";
            this.progressBar6.Size = new System.Drawing.Size(140, 23);
            this.progressBar6.Step = 1;
            this.progressBar6.TabIndex = 20;
            this.progressBar6.MouseHover += new System.EventHandler(this.progressBar6_MouseHover);
            // 
            // progressBar7
            // 
            this.progressBar7.Location = new System.Drawing.Point(490, 340);
            this.progressBar7.Name = "progressBar7";
            this.progressBar7.Size = new System.Drawing.Size(140, 23);
            this.progressBar7.Step = 1;
            this.progressBar7.TabIndex = 20;
            this.progressBar7.MouseHover += new System.EventHandler(this.progressBar7_MouseHover);
            // 
            // progressBar8
            // 
            this.progressBar8.Location = new System.Drawing.Point(490, 370);
            this.progressBar8.Name = "progressBar8";
            this.progressBar8.Size = new System.Drawing.Size(140, 23);
            this.progressBar8.Step = 1;
            this.progressBar8.TabIndex = 20;
            this.progressBar8.MouseHover += new System.EventHandler(this.progressBar8_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F);
            this.label2.Location = new System.Drawing.Point(80, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "어린왕자";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 12F);
            this.label3.Location = new System.Drawing.Point(90, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "소나기";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 12F);
            this.label4.Location = new System.Drawing.Point(110, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "마션";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 12F);
            this.label5.Location = new System.Drawing.Point(20, 370);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "스타십 트루퍼스";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 12F);
            this.label6.Location = new System.Drawing.Point(400, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "C# 교과서";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 12F);
            this.label7.Location = new System.Drawing.Point(310, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "Visual C# Programming";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 12F);
            this.label8.Location = new System.Drawing.Point(360, 340);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "최강의 멘탈 관리";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("굴림", 12F);
            this.label9.Location = new System.Drawing.Point(450, 370);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 16);
            this.label9.TabIndex = 21;
            this.label9.Text = "위닝";
            // 
            // Buy_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar8);
            this.Controls.Add(this.progressBar7);
            this.Controls.Add(this.progressBar4);
            this.Controls.Add(this.progressBar6);
            this.Controls.Add(this.progressBar3);
            this.Controls.Add(this.progressBar5);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.주문하기);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.모든책주문);
            this.Controls.Add(this.종료);
            this.Controls.Add(this.조회하기);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Buy_Form";
            this.Text = "Buy_Form";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button 주문하기;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button 모든책주문;
        private System.Windows.Forms.Button 조회하기;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button 종료;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.ProgressBar progressBar4;
        private System.Windows.Forms.ProgressBar progressBar5;
        private System.Windows.Forms.ProgressBar progressBar6;
        private System.Windows.Forms.ProgressBar progressBar7;
        private System.Windows.Forms.ProgressBar progressBar8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}