namespace QuanLyKhachSan
{
    partial class frm_ThongKe
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btn_load = new System.Windows.Forms.Button();
            this.lbl_ngaybatdau = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.chart_DoanhThu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart_DoanhThu)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(609, 31);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(75, 23);
            this.btn_load.TabIndex = 16;
            this.btn_load.Text = "Load";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // lbl_ngaybatdau
            // 
            this.lbl_ngaybatdau.AutoSize = true;
            this.lbl_ngaybatdau.Location = new System.Drawing.Point(238, 37);
            this.lbl_ngaybatdau.Name = "lbl_ngaybatdau";
            this.lbl_ngaybatdau.Size = new System.Drawing.Size(49, 13);
            this.lbl_ngaybatdau.TabIndex = 15;
            this.lbl_ngaybatdau.Text = "Bắt Đầu:";
            this.lbl_ngaybatdau.Click += new System.EventHandler(this.lbl_ngaybatdau_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(331, 31);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(233, 20);
            this.dateTimePicker1.TabIndex = 14;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // chart_DoanhThu
            // 
            chartArea3.Name = "ChartArea1";
            this.chart_DoanhThu.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart_DoanhThu.Legends.Add(legend3);
            this.chart_DoanhThu.Location = new System.Drawing.Point(12, 76);
            this.chart_DoanhThu.Name = "chart_DoanhThu";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart_DoanhThu.Series.Add(series3);
            this.chart_DoanhThu.Size = new System.Drawing.Size(971, 418);
            this.chart_DoanhThu.TabIndex = 17;
            this.chart_DoanhThu.Text = "chart1";
            // 
            // frm_ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 537);
            this.Controls.Add(this.chart_DoanhThu);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.lbl_ngaybatdau);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "frm_ThongKe";
            this.Text = "frm_ThongKe";
            this.Load += new System.EventHandler(this.frm_ThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_DoanhThu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Label lbl_ngaybatdau;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_DoanhThu;
    }
}