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
using QuanLyKhachSan.DA;

namespace QuanLyKhachSan
{
    public partial class frm_ThuePhong : Form
    {
        BLL_ThuePhong bll;
        string _maphong;
        public frm_ThuePhong()
        {
            InitializeComponent();
            bll = new BLL_ThuePhong();

            LoadTheme();
        }

        private void LoadTheme()
        {
            ApplyTheme(this.Controls);
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }

            }
            label4.ForeColor = ThemeColor.SecondaryColor;
        }

        private void ApplyTheme(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is Button btn)
                {
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }

                // Nếu điều khiển là một container, đệ quy lặp qua các điều khiển con
                if (control.HasChildren)
                {
                    ApplyTheme(control.Controls);
                }
            }
        }

        public frm_ThuePhong(string maphong)
        {
            _maphong = maphong;
        }
    
        private void frm_ThuePhong_Load(object sender, EventArgs e)
        {
            var tt = bll.laytt();
            foreach (var makhachhang in tt)
            {
                cbo_MaKhachHang.Items.Add(makhachhang.MaKhachHang);
            }
            var phongs = bll.LayThongTinPhongTrong();
            dgv_PhongTrong.DataSource = phongs;

            dgv_DanhSachKhachDaThue.Columns.Clear();

            // Điền dữ liệu vào DataGridView
            var danhSachKhachDaThue = bll.LayDanhSachKhachDaThue();
            dgv_DanhSachKhachDaThue.DataSource = danhSachKhachDaThue;
            TenDGV();
        }

        private void cbo_MaKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_MaKhachHang.SelectedItem != null)
            {
                string maKhachHang = cbo_MaKhachHang.SelectedItem.ToString();

                var kh = bll.LayThongTinKhachHangVaDatPhong(maKhachHang);

                if (kh != null)
                {
                    lstv_ChiTiet.Items.Clear();
                    lstv_ChiTiet.Items.Add(new ListViewItem("Mã khách hàng: " + maKhachHang));
                    lstv_ChiTiet.Items.Add(new ListViewItem("Tên khách hàng: " + kh.TenKhachHang));
                    lstv_ChiTiet.Items.Add(new ListViewItem("Giới tính: " + kh.GioiTinh));
                    lstv_ChiTiet.Items.Add(new ListViewItem("Địa chỉ: " + kh.DiaChi));
                    lstv_ChiTiet.Items.Add(new ListViewItem("Số điện thoại: " + kh.SoDienThoai));
                    lstv_ChiTiet.Items.Add(new ListViewItem("Ngày sinh: " + kh.NgaySinh.ToString("dd/MM/yyyy")));
                }
            }
        }

        private void dpt_NgayThue_VisibleChanged(object sender, EventArgs e)
        {
            var item = lstv_ChiTiet.FindItemWithText("Ngày thuê");
            if (item != null)
            {
                item.Text = "Ngày thuê: " + dtp_NgayThue.Value.ToString("dd/MM/yyyy");
            }
            else
            {
                lstv_ChiTiet.Items.Add(new ListViewItem("Ngày thuê: " + dtp_NgayThue.Value.ToString("dd/MM/yyyy")));
            }
        }

        private void btn_ThuePhong_Click(object sender, EventArgs e)
        {

        }

        public void TenDGV()
        {
            if (dgv_DanhSachKhachDaThue.Columns.Contains("MaKhachHang") &&
                dgv_DanhSachKhachDaThue.Columns.Contains("TenKhachHang") &&
                dgv_DanhSachKhachDaThue.Columns.Contains("NgaySinh") &&
                dgv_DanhSachKhachDaThue.Columns.Contains("GioiTinh") &&
                dgv_DanhSachKhachDaThue.Columns.Contains("CMND") &&
                dgv_DanhSachKhachDaThue.Columns.Contains("DiaChi") &&
                dgv_DanhSachKhachDaThue.Columns.Contains("SoDienThoai") &&
                dgv_DanhSachKhachDaThue.Columns.Contains("MaPhong"))
            {
                dgv_DanhSachKhachDaThue.Columns["MaKhachHang"].HeaderText = "Mã khách hàng";
                dgv_DanhSachKhachDaThue.Columns["TenKhachHang"].HeaderText = "Tên khách hàng";
                dgv_DanhSachKhachDaThue.Columns["NgaySinh"].HeaderText = "Ngày sinh";
                dgv_DanhSachKhachDaThue.Columns["GioiTinh"].HeaderText = "Giới tính";
                dgv_DanhSachKhachDaThue.Columns["CMND"].HeaderText = "CMND/CCCD";
                dgv_DanhSachKhachDaThue.Columns["DiaChi"].HeaderText = "Địa chỉ";
                dgv_DanhSachKhachDaThue.Columns["SoDienThoai"].HeaderText = "Số điện thoại";
                dgv_DanhSachKhachDaThue.Columns["MaPhong"].HeaderText = "Mã phòng";

                dgv_PhongTrong.Columns["MaPhong"].HeaderText = "Mã phòng";
                dgv_PhongTrong.Columns["LoaiPhong"].HeaderText = "Loại phòng";
                dgv_PhongTrong.Columns["TinhTrang"].HeaderText = "Tình trạng";
                dgv_PhongTrong.Columns["DonGia"].HeaderText = "Đơn giá";

            }
        }

        private void lstv_ChiTiet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgv_PhongTrong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0)
            {
                string maPhong = dgv_PhongTrong.Rows[rowIndex].Cells["MaPhong"].Value.ToString();
                string loaiPhong = dgv_PhongTrong.Rows[rowIndex].Cells["LoaiPhong"].Value.ToString();
                string tinhTrang = dgv_PhongTrong.Rows[rowIndex].Cells["TinhTrang"].Value.ToString();
                string donGia = dgv_PhongTrong.Rows[rowIndex].Cells["DonGia"].Value.ToString();


                if (lsv_phongchon.Items.Count == 0)
                {
                    lsv_phongchon.Items.Add(new ListViewItem("Mã phòng: " + maPhong));
                    lsv_phongchon.Items.Add(new ListViewItem("Loại phòng: " + loaiPhong));
                    lsv_phongchon.Items.Add(new ListViewItem("Tình trạng: " + tinhTrang));
                    lsv_phongchon.Items.Add(new ListViewItem("Đơn giá: " + donGia));
                }
                else
                {
                    lsv_phongchon.Items[0].Text = "Mã phòng: " + maPhong;
                    lsv_phongchon.Items[1].Text = "Loại phòng: " + loaiPhong;
                    lsv_phongchon.Items[2].Text = "Tình trạng: " + tinhTrang;
                    lsv_phongchon.Items[3].Text = "Đơn giá: " + donGia;
                }
            }
        }

        private void btn_ThuePhong_Click_1(object sender, EventArgs e)
        {

            // Kiểm tra xem đã chọn khách hàng
            if (cbo_MaKhachHang.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn khách hàng trước khi thuê.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra xem đã chọn phòng trống từ danh sách dgv_PhongTrong
            if (dgv_PhongTrong.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một phòng trống từ danh sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy thông tin khách hàng
            string maKhachHang = cbo_MaKhachHang.SelectedItem.ToString();

            // Lấy thông tin phòng trống từ DataGridView
            DataGridViewRow selectedRow = dgv_PhongTrong.SelectedRows[0];
            string maPhong = selectedRow.Cells["MaPhong"].Value.ToString();

            // Kiểm tra ngày thuê không lớn hơn ngày hiện tại
            DateTime ngayThue = dtp_NgayThue.Value.Date;
            if (ngayThue > DateTime.Now.Date)
            {
                MessageBox.Show("Ngày thuê không được lớn hơn ngày hiện tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra đã chọn phòng từ dgv_PhongTrong và đã hiển thị trong lsv_phongchon
            bool isPhongChon = lsv_phongchon.Items.Cast<ListViewItem>().Any(item => item.Text.Equals("Mã phòng: " + maPhong));
            if (!isPhongChon)
            {
                MessageBox.Show("Vui lòng chọn phòng từ danh sách trước khi thuê.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            // Thêm thông tin thuê phòng vào cơ sở dữ liệu
            try
            {
                // Thêm thông tin thuê phòng
                int nextId = bll.LayThuePhongCount() + 1;
                string maThuePhong = "TP" + nextId.ToString().PadLeft(4, '0');

                bll.ThemThuePhong(maThuePhong, maKhachHang, maPhong, ngayThue);

                // Cập nhật trạng thái của phòng từ "Trống" sang "Đã thuê"
                bll.CapNhatTrangThaiPhong(maPhong, "Đã thuê");

                // Hiển thị thông báo thành công
                MessageBox.Show("Thuê phòng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Cập nhật lại danh sách phòng trống sau khi đã thuê phòng
                var phongs = bll.LayThongTinPhongTrong();
                dgv_PhongTrong.DataSource = phongs;

                // Xóa thông tin khách hàng đã chọn sau khi đã thuê phòng thành công
                cbo_MaKhachHang.SelectedIndex = -1;
                lstv_ChiTiet.Items.Clear();
                lsv_phongchon.Items.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thuê phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
