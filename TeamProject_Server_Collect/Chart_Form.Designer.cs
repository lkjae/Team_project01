namespace TeamProject_Server_Collect
{
    partial class Chart_Form
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.책별조회하기 = new System.Windows.Forms.Button();
            this.뒤로가기 = new System.Windows.Forms.Button();
            this.지역별조회하기 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "통계";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(10, 40);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(660, 360);
            this.chart1.TabIndex = 21;
            this.chart1.Text = "chart1";
            // 
            // 책별조회하기
            // 
            this.책별조회하기.Location = new System.Drawing.Point(680, 120);
            this.책별조회하기.Name = "책별조회하기";
            this.책별조회하기.Size = new System.Drawing.Size(91, 76);
            this.책별조회하기.TabIndex = 24;
            this.책별조회하기.Text = "책별조회하기";
            this.책별조회하기.UseVisualStyleBackColor = true;
            this.책별조회하기.Click += new System.EventHandler(this.조회하기_Click);
            // 
            // 뒤로가기
            // 
            this.뒤로가기.Location = new System.Drawing.Point(680, 330);
            this.뒤로가기.Name = "뒤로가기";
            this.뒤로가기.Size = new System.Drawing.Size(91, 76);
            this.뒤로가기.TabIndex = 25;
            this.뒤로가기.Text = "뒤로가기";
            this.뒤로가기.UseVisualStyleBackColor = true;
            this.뒤로가기.Click += new System.EventHandler(this.뒤로가기_Click);
            // 
            // 지역별조회하기
            // 
            this.지역별조회하기.Location = new System.Drawing.Point(680, 40);
            this.지역별조회하기.Name = "지역별조회하기";
            this.지역별조회하기.Size = new System.Drawing.Size(91, 76);
            this.지역별조회하기.TabIndex = 26;
            this.지역별조회하기.Text = "지역별조회하기";
            this.지역별조회하기.UseVisualStyleBackColor = true;
            this.지역별조회하기.Click += new System.EventHandler(this.지역별조회하기_Click);
            // 
            // Chart_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.지역별조회하기);
            this.Controls.Add(this.뒤로가기);
            this.Controls.Add(this.책별조회하기);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Chart_Form";
            this.Text = "Chart_Form";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button 책별조회하기;
        private System.Windows.Forms.Button 뒤로가기;
        private System.Windows.Forms.Button 지역별조회하기;
    }
}