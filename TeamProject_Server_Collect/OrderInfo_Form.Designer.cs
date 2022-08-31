namespace TeamProject_Server_Collect
{
    partial class OrderInfo_Form
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.title = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.재고관리 = new System.Windows.Forms.ToolStripMenuItem();
            this.선별하기 = new System.Windows.Forms.ToolStripMenuItem();
            this.배송 = new System.Windows.Forms.ToolStripMenuItem();
            this.통계보기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.조회하기 = new System.Windows.Forms.Button();
            this.server_status = new System.Windows.Forms.Label();
            this.종료버튼 = new System.Windows.Forms.Button();
            this.shipping_status = new System.Windows.Forms.Label();
            this.car_status = new System.Windows.Forms.Label();
            this.shipping_destination = new System.Windows.Forms.Label();
            this.arrival_time = new System.Windows.Forms.Label();
            this.갱신 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(930, 540);
            this.dataGridView1.TabIndex = 20;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.title.Location = new System.Drawing.Point(370, 30);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(181, 37);
            this.title.TabIndex = 19;
            this.title.Text = "< 주문현황 >";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(970, 70);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(192, 124);
            this.richTextBox1.TabIndex = 18;
            this.richTextBox1.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.재고관리,
            this.선별하기,
            this.배송,
            this.통계보기ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 재고관리
            // 
            this.재고관리.Name = "재고관리";
            this.재고관리.Size = new System.Drawing.Size(71, 20);
            this.재고관리.Text = "재고 관리";
            this.재고관리.Click += new System.EventHandler(this.재고관리_Click);
            // 
            // 선별하기
            // 
            this.선별하기.Name = "선별하기";
            this.선별하기.Size = new System.Drawing.Size(67, 20);
            this.선별하기.Text = "선별하기";
            this.선별하기.Click += new System.EventHandler(this.선별하기_Click);
            // 
            // 배송
            // 
            this.배송.Name = "배송";
            this.배송.Size = new System.Drawing.Size(67, 20);
            this.배송.Text = "배송하기";
            this.배송.Click += new System.EventHandler(this.배송_Click);
            // 
            // 통계보기ToolStripMenuItem
            // 
            this.통계보기ToolStripMenuItem.Name = "통계보기ToolStripMenuItem";
            this.통계보기ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.통계보기ToolStripMenuItem.Text = "통계보기";
            this.통계보기ToolStripMenuItem.Click += new System.EventHandler(this.통계보기ToolStripMenuItem_Click);
            // 
            // 조회하기
            // 
            this.조회하기.Location = new System.Drawing.Point(970, 450);
            this.조회하기.Name = "조회하기";
            this.조회하기.Size = new System.Drawing.Size(190, 76);
            this.조회하기.TabIndex = 23;
            this.조회하기.Text = "조회하기";
            this.조회하기.UseVisualStyleBackColor = true;
            this.조회하기.Click += new System.EventHandler(this.조회하기_Click);
            // 
            // server_status
            // 
            this.server_status.AutoSize = true;
            this.server_status.Font = new System.Drawing.Font("나눔고딕코딩", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.server_status.Location = new System.Drawing.Point(970, 50);
            this.server_status.Name = "server_status";
            this.server_status.Size = new System.Drawing.Size(79, 16);
            this.server_status.TabIndex = 24;
            this.server_status.Text = "서버 상태";
            // 
            // 종료버튼
            // 
            this.종료버튼.Location = new System.Drawing.Point(970, 530);
            this.종료버튼.Name = "종료버튼";
            this.종료버튼.Size = new System.Drawing.Size(190, 76);
            this.종료버튼.TabIndex = 23;
            this.종료버튼.Text = "프로그램 종료";
            this.종료버튼.UseVisualStyleBackColor = true;
            this.종료버튼.Click += new System.EventHandler(this.종료버튼_Click);
            // 
            // shipping_status
            // 
            this.shipping_status.AutoSize = true;
            this.shipping_status.Font = new System.Drawing.Font("나눔고딕코딩", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.shipping_status.Location = new System.Drawing.Point(970, 210);
            this.shipping_status.Name = "shipping_status";
            this.shipping_status.Size = new System.Drawing.Size(79, 16);
            this.shipping_status.TabIndex = 24;
            this.shipping_status.Text = "배송 상태";
            // 
            // car_status
            // 
            this.car_status.AutoSize = true;
            this.car_status.Font = new System.Drawing.Font("굴림", 11F);
            this.car_status.Location = new System.Drawing.Point(980, 240);
            this.car_status.Name = "car_status";
            this.car_status.Size = new System.Drawing.Size(92, 15);
            this.car_status.TabIndex = 25;
            this.car_status.Text = "배송 대기 중";
            // 
            // shipping_destination
            // 
            this.shipping_destination.AutoSize = true;
            this.shipping_destination.Font = new System.Drawing.Font("굴림", 11F);
            this.shipping_destination.Location = new System.Drawing.Point(980, 270);
            this.shipping_destination.Name = "shipping_destination";
            this.shipping_destination.Size = new System.Drawing.Size(15, 15);
            this.shipping_destination.TabIndex = 25;
            this.shipping_destination.Text = "-";
            // 
            // arrival_time
            // 
            this.arrival_time.AutoSize = true;
            this.arrival_time.Font = new System.Drawing.Font("굴림", 11F);
            this.arrival_time.Location = new System.Drawing.Point(980, 300);
            this.arrival_time.Name = "arrival_time";
            this.arrival_time.Size = new System.Drawing.Size(15, 15);
            this.arrival_time.TabIndex = 25;
            this.arrival_time.Text = "-";
            // 
            // 갱신
            // 
            this.갱신.Location = new System.Drawing.Point(970, 370);
            this.갱신.Name = "갱신";
            this.갱신.Size = new System.Drawing.Size(190, 76);
            this.갱신.TabIndex = 23;
            this.갱신.Text = "갱신";
            this.갱신.UseVisualStyleBackColor = true;
            this.갱신.Click += new System.EventHandler(this.갱신_Click);
            // 
            // OrderInfo_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1184, 636);
            this.Controls.Add(this.arrival_time);
            this.Controls.Add(this.shipping_destination);
            this.Controls.Add(this.car_status);
            this.Controls.Add(this.shipping_status);
            this.Controls.Add(this.server_status);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.title);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.종료버튼);
            this.Controls.Add(this.갱신);
            this.Controls.Add(this.조회하기);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OrderInfo_Form";
            this.Text = "주문 현황";
            this.Load += new System.EventHandler(this.OrderInfo_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 재고관리;
        private System.Windows.Forms.ToolStripMenuItem 선별하기;
        private System.Windows.Forms.Button 조회하기;
        private System.Windows.Forms.ToolStripMenuItem 배송;
        private System.Windows.Forms.ToolStripMenuItem 통계보기ToolStripMenuItem;
        private System.Windows.Forms.Label server_status;
        private System.Windows.Forms.Button 종료버튼;
        private System.Windows.Forms.Label shipping_status;
        public System.Windows.Forms.Label car_status;
        public System.Windows.Forms.Label shipping_destination;
        public System.Windows.Forms.Label arrival_time;
        private System.Windows.Forms.Button 갱신;
    }
}

