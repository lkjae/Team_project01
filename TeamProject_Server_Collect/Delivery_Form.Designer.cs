namespace TeamProject_Server_Collect
{
    partial class Delivery_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Delivery_Form));
            this.status_label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.배송지목록 = new System.Windows.Forms.ListBox();
            this.예상대기시간버튼 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.예상대기시간 = new System.Windows.Forms.TextBox();
            this.종료 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // status_label
            // 
            this.status_label.AutoSize = true;
            this.status_label.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.status_label.Location = new System.Drawing.Point(20, 10);
            this.status_label.Name = "status_label";
            this.status_label.Size = new System.Drawing.Size(253, 32);
            this.status_label.TabIndex = 11;
            this.status_label.Text = "배송 대기 중 입니다 ...";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(610, 290);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // 배송지목록
            // 
            this.배송지목록.Font = new System.Drawing.Font("나눔고딕코딩", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.배송지목록.FormattingEnabled = true;
            this.배송지목록.ItemHeight = 16;
            this.배송지목록.Location = new System.Drawing.Point(640, 50);
            this.배송지목록.Name = "배송지목록";
            this.배송지목록.Size = new System.Drawing.Size(130, 228);
            this.배송지목록.TabIndex = 18;
            this.배송지목록.Click += new System.EventHandler(this.배송지목록_Click);
            // 
            // 예상대기시간버튼
            // 
            this.예상대기시간버튼.Location = new System.Drawing.Point(640, 300);
            this.예상대기시간버튼.Name = "예상대기시간버튼";
            this.예상대기시간버튼.Size = new System.Drawing.Size(128, 50);
            this.예상대기시간버튼.TabIndex = 14;
            this.예상대기시간버튼.Text = "배송 시작";
            this.예상대기시간버튼.UseVisualStyleBackColor = true;
            this.예상대기시간버튼.Click += new System.EventHandler(this.예상대기시간버튼_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔고딕코딩", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(180, 370);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "예상 대기 시간";
            // 
            // 예상대기시간
            // 
            this.예상대기시간.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.예상대기시간.Location = new System.Drawing.Point(340, 360);
            this.예상대기시간.Multiline = true;
            this.예상대기시간.Name = "예상대기시간";
            this.예상대기시간.ReadOnly = true;
            this.예상대기시간.Size = new System.Drawing.Size(167, 40);
            this.예상대기시간.TabIndex = 12;
            this.예상대기시간.TabStop = false;
            // 
            // 종료
            // 
            this.종료.Location = new System.Drawing.Point(640, 350);
            this.종료.Name = "종료";
            this.종료.Size = new System.Drawing.Size(128, 50);
            this.종료.TabIndex = 14;
            this.종료.Text = "종료";
            this.종료.UseVisualStyleBackColor = true;
            this.종료.Click += new System.EventHandler(this.종료_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕코딩", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(650, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "목표 배송지";
            // 
            // Delivery_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.status_label);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.배송지목록);
            this.Controls.Add(this.종료);
            this.Controls.Add(this.예상대기시간버튼);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.예상대기시간);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Delivery_Form";
            this.Text = "Delivery_Form";
            this.Load += new System.EventHandler(this.Delivery_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label status_label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox 배송지목록;
        private System.Windows.Forms.Button 예상대기시간버튼;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox 예상대기시간;
        private System.Windows.Forms.Button 종료;
        private System.Windows.Forms.Label label1;
    }
}