namespace TeamProject_Client
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.bookImage = new System.Windows.Forms.PictureBox();
            this.CallForm2 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.all_gen_btn = new System.Windows.Forms.Button();
            this.lit_gen_btn = new System.Windows.Forms.Button();
            this.sf_gen_btn = new System.Windows.Forms.Button();
            this.cham_gen_btn = new System.Windows.Forms.Button();
            this.jagi_gen_btn = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.shoplist_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.del_shoplist_btn = new System.Windows.Forms.Button();
            this.buy_mount_txt = new System.Windows.Forms.TextBox();
            this.buy_mount = new System.Windows.Forms.Label();
            this.shoplist_amount = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.bookImage)).BeginInit();
            this.SuspendLayout();
            // 
            // bookImage
            // 
            this.bookImage.Location = new System.Drawing.Point(400, 150);
            this.bookImage.Name = "bookImage";
            this.bookImage.Size = new System.Drawing.Size(370, 390);
            this.bookImage.TabIndex = 5;
            this.bookImage.TabStop = false;
            // 
            // CallForm2
            // 
            this.CallForm2.Location = new System.Drawing.Point(780, 480);
            this.CallForm2.Name = "CallForm2";
            this.CallForm2.Size = new System.Drawing.Size(140, 60);
            this.CallForm2.TabIndex = 6;
            this.CallForm2.Text = "주문하기";
            this.CallForm2.UseVisualStyleBackColor = true;
            this.CallForm2.Click += new System.EventHandler(this.CallForm2_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(930, 480);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(140, 60);
            this.button6.TabIndex = 7;
            this.button6.Text = "종료";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Quit_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("굴림", 15F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(170, 150);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(220, 384);
            this.listBox1.TabIndex = 9;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            // 
            // all_gen_btn
            // 
            this.all_gen_btn.Location = new System.Drawing.Point(20, 150);
            this.all_gen_btn.Name = "all_gen_btn";
            this.all_gen_btn.Size = new System.Drawing.Size(140, 70);
            this.all_gen_btn.TabIndex = 10;
            this.all_gen_btn.Text = "전체";
            this.all_gen_btn.UseVisualStyleBackColor = true;
            this.all_gen_btn.Click += new System.EventHandler(this.all_gen_btn_Click);
            // 
            // lit_gen_btn
            // 
            this.lit_gen_btn.Location = new System.Drawing.Point(20, 230);
            this.lit_gen_btn.Name = "lit_gen_btn";
            this.lit_gen_btn.Size = new System.Drawing.Size(140, 70);
            this.lit_gen_btn.TabIndex = 10;
            this.lit_gen_btn.Text = "문학";
            this.lit_gen_btn.UseVisualStyleBackColor = true;
            this.lit_gen_btn.Click += new System.EventHandler(this.lit_gen_btn_Click);
            // 
            // sf_gen_btn
            // 
            this.sf_gen_btn.Location = new System.Drawing.Point(20, 310);
            this.sf_gen_btn.Name = "sf_gen_btn";
            this.sf_gen_btn.Size = new System.Drawing.Size(140, 70);
            this.sf_gen_btn.TabIndex = 10;
            this.sf_gen_btn.Text = "SF";
            this.sf_gen_btn.UseVisualStyleBackColor = true;
            this.sf_gen_btn.Click += new System.EventHandler(this.sf_gen_btn_Click);
            // 
            // cham_gen_btn
            // 
            this.cham_gen_btn.Location = new System.Drawing.Point(20, 390);
            this.cham_gen_btn.Name = "cham_gen_btn";
            this.cham_gen_btn.Size = new System.Drawing.Size(140, 70);
            this.cham_gen_btn.TabIndex = 10;
            this.cham_gen_btn.Text = "참고서";
            this.cham_gen_btn.UseVisualStyleBackColor = true;
            this.cham_gen_btn.Click += new System.EventHandler(this.cham_gen_btn_Click);
            // 
            // jagi_gen_btn
            // 
            this.jagi_gen_btn.Location = new System.Drawing.Point(20, 470);
            this.jagi_gen_btn.Name = "jagi_gen_btn";
            this.jagi_gen_btn.Size = new System.Drawing.Size(140, 70);
            this.jagi_gen_btn.TabIndex = 10;
            this.jagi_gen_btn.Text = "자기개발서";
            this.jagi_gen_btn.UseVisualStyleBackColor = true;
            this.jagi_gen_btn.Click += new System.EventHandler(this.jagi_gen_btn_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(170, 100);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(110, 40);
            this.button8.TabIndex = 13;
            this.button8.Text = "문의하기";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("굴림", 15F);
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(780, 150);
            this.listBox2.Name = "listBox2";
            this.listBox2.ScrollAlwaysVisible = true;
            this.listBox2.Size = new System.Drawing.Size(210, 244);
            this.listBox2.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 15F);
            this.label6.Location = new System.Drawing.Point(780, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "장바구니";
            // 
            // shoplist_btn
            // 
            this.shoplist_btn.Location = new System.Drawing.Point(780, 420);
            this.shoplist_btn.Name = "shoplist_btn";
            this.shoplist_btn.Size = new System.Drawing.Size(140, 50);
            this.shoplist_btn.TabIndex = 7;
            this.shoplist_btn.Text = "장바구니 담기";
            this.shoplist_btn.UseVisualStyleBackColor = true;
            this.shoplist_btn.Click += new System.EventHandler(this.shoplist_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 15F);
            this.label2.Location = new System.Drawing.Point(290, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "남은 재고 :";
            // 
            // del_shoplist_btn
            // 
            this.del_shoplist_btn.Location = new System.Drawing.Point(931, 420);
            this.del_shoplist_btn.Name = "del_shoplist_btn";
            this.del_shoplist_btn.Size = new System.Drawing.Size(140, 50);
            this.del_shoplist_btn.TabIndex = 7;
            this.del_shoplist_btn.Text = "장바구니 빼기";
            this.del_shoplist_btn.UseVisualStyleBackColor = true;
            this.del_shoplist_btn.Click += new System.EventHandler(this.del_shoplist_btn_Click);
            // 
            // buy_mount_txt
            // 
            this.buy_mount_txt.Font = new System.Drawing.Font("굴림", 15F);
            this.buy_mount_txt.Location = new System.Drawing.Point(671, 110);
            this.buy_mount_txt.Name = "buy_mount_txt";
            this.buy_mount_txt.Size = new System.Drawing.Size(100, 30);
            this.buy_mount_txt.TabIndex = 16;
            this.buy_mount_txt.Text = "1";
            // 
            // buy_mount
            // 
            this.buy_mount.AutoSize = true;
            this.buy_mount.Font = new System.Drawing.Font("굴림", 15F);
            this.buy_mount.Location = new System.Drawing.Point(551, 120);
            this.buy_mount.Name = "buy_mount";
            this.buy_mount.Size = new System.Drawing.Size(110, 20);
            this.buy_mount.TabIndex = 17;
            this.buy_mount.Text = "구매 수량 :";
            // 
            // shoplist_amount
            // 
            this.shoplist_amount.Font = new System.Drawing.Font("굴림", 15F);
            this.shoplist_amount.FormattingEnabled = true;
            this.shoplist_amount.ItemHeight = 20;
            this.shoplist_amount.Location = new System.Drawing.Point(1000, 150);
            this.shoplist_amount.Name = "shoplist_amount";
            this.shoplist_amount.ScrollAlwaysVisible = true;
            this.shoplist_amount.Size = new System.Drawing.Size(70, 244);
            this.shoplist_amount.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 546);
            this.Controls.Add(this.shoplist_amount);
            this.Controls.Add(this.buy_mount);
            this.Controls.Add(this.buy_mount_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.jagi_gen_btn);
            this.Controls.Add(this.cham_gen_btn);
            this.Controls.Add(this.sf_gen_btn);
            this.Controls.Add(this.lit_gen_btn);
            this.Controls.Add(this.all_gen_btn);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.del_shoplist_btn);
            this.Controls.Add(this.shoplist_btn);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.CallForm2);
            this.Controls.Add(this.bookImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "책 주문 클라이언트";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox bookImage;
        private System.Windows.Forms.Button CallForm2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button all_gen_btn;
        private System.Windows.Forms.Button lit_gen_btn;
        private System.Windows.Forms.Button sf_gen_btn;
        private System.Windows.Forms.Button cham_gen_btn;
        private System.Windows.Forms.Button jagi_gen_btn;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button shoplist_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button del_shoplist_btn;
        private System.Windows.Forms.TextBox buy_mount_txt;
        private System.Windows.Forms.Label buy_mount;
        public System.Windows.Forms.ListBox listBox2;
        public System.Windows.Forms.ListBox shoplist_amount;
    }
}

