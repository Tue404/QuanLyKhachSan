﻿using QuanLyKhachSan.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QuanLyKhachSan
{
    public partial class frm_ThongKe : Form
    {
        BLL_ThongKe bll;
        public frm_ThongKe()
        {
            InitializeComponent();
            bll = new BLL_ThongKe();
        }

        private void lbl_ngaybatdau_Click(object sender, EventArgs e)
        {

        }

        private void frm_ThongKe_Load(object sender, EventArgs e)
        {
            UpdateChart();
        }

        private void UpdateChart()
        {
            chart_DoanhThu.Series.Clear();
            chart_DoanhThu.Titles.Clear();
            chart_DoanhThu.Titles.Add("Doanh Thu Theo Tháng");
            int nam = dateTimePicker1.Value.Year;
            var data = bll.ThongKeDoanhThuTheoThang(nam);
            chart_DoanhThu.DataSource = data;
            Series series = new Series();
            series.LegendText = "Doanh Thu";
            series.XValueMember = "Thang";
            series.YValueMembers = "DoanhThu";
            chart_DoanhThu.Series.Add(series);
        }

        public void doanhthungay()
        {
            int nam = dateTimePicker1.Value.Year;
            int thang = dateTimePicker1.Value.Month;
            var data = bll.ThongKeDoanhThuTheoNgay(nam, thang);

            chart_DoanhThu.Series.Clear();
            chart_DoanhThu.Titles.Clear();
            chart_DoanhThu.Titles.Add("Doanh Thu Theo Ngày");


            chart_DoanhThu.DataSource = data;

            Series series = new Series();
            series.Legend = null;
            series.LegendText = "Doanh Thu";
            series.XValueMember = "ngay";
            series.YValueMembers = "doanhthu";
            chart_DoanhThu.Series.Add(series);

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            doanhthungay();
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            UpdateChart();
        }
    }
}
