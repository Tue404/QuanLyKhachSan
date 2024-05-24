using QuanLyKhachSan.BLL;
using QuanLyKhachSan.DA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class frm_TraPhong : Form
    {
        BLL_Phong bllPhong;
        BLL_TraPhong bll;

        string phong;
        string mkh;
        string tkh;
        string cccd;
        string sdt;
        public frm_TraPhong(string phong, string makhachhang, string tenkhachhang)
        {
            InitializeComponent();
            LoadTheme();
            this.phong = phong;
            this.mkh = makhachhang;
            this.tkh = tenkhachhang;
            bll = new BLL_TraPhong();
            bllPhong = new BLL_Phong();
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
            label1.ForeColor = ThemeColor.SecondaryColor;
            label2.ForeColor = ThemeColor.PrimaryColor;
            label3.ForeColor = ThemeColor.SecondaryColor;
            label5.ForeColor = ThemeColor.PrimaryColor;
            label6.ForeColor = ThemeColor.SecondaryColor;
            label7.ForeColor = ThemeColor.PrimaryColor;
            label8.ForeColor = ThemeColor.SecondaryColor;
            label9.ForeColor = ThemeColor.PrimaryColor;
            label10.ForeColor = ThemeColor.SecondaryColor;

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

        private void frm_TraPhong_Load(object sender, EventArgs e)
        {
            lbl_KQPhong.Text = phong;
            lbl_KQMaKhachHang.Text = mkh;
            lbl_KQTenKhachHang.Text = tkh;
            cccd = bll.laycccd(lbl_KQMaKhachHang.Text);
            sdt = bll.LaySDT(lbl_KQMaKhachHang.Text);
            Random random = new Random();
            int randomNumber = random.Next(1000, 9999);
            string maHoaDon = "HD" + randomNumber.ToString();
            lbl_kqmahoadon.Text = maHoaDon;

            var datPhong = bll.layttDatphong(phong);
            lbl_KQNgayDatPhong.Text = datPhong.NgayThue.Value.ToString("dd/MM/yyyy");


            lbl_KQNgayThanhToan.Text = DateTime.Now.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);

            TimeSpan soNgayO = DateTime.Now.Date - datPhong.NgayThue.Value;
            lbl_KQSoNgayO.Text = soNgayO.TotalDays.ToString();

            lbl_KQGiaPhong.Text = datPhong.Phong.DonGia.ToString();
            var busTongTienDichvu = bll.layTongTienDichVu(phong);
            lbl_KQTongTienDichVu.Text = busTongTienDichvu.ToString();

            double soNgay = double.Parse(lbl_KQSoNgayO.Text);
            double giaPhong = double.Parse(lbl_KQGiaPhong.Text);
            double tongTienDichVu = double.Parse(lbl_KQTongTienDichVu.Text);
            lbl_KQTongTien.Text = (soNgay * giaPhong + tongTienDichVu).ToString();
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                string maHoaDon = lbl_kqmahoadon.Text;
                string maKhachHang = lbl_KQMaKhachHang.Text;
                string tenKhachHang = lbl_KQTenKhachHang.Text;
                string maPhong = lbl_KQPhong.Text;

                DateTime ngayDatPhong;
                if (!DateTime.TryParseExact(lbl_KQNgayDatPhong.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ngayDatPhong))
                {
                    MessageBox.Show("Ngày đặt phòng không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DateTime ngayTra = DateTime.Now.Date;
                double tongTien = double.Parse(lbl_KQTongTien.Text);

                // Hiển thị thông báo xác nhận thanh toán
                string message = $"Bạn có muốn thanh toán Phòng:{maPhong} - Khách hàng: {tenKhachHang} - tổng tiền: {tongTien:C} không?";
                DialogResult result = MessageBox.Show(message, "Xác nhận thanh toán", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    HoaDon thanhToan = new HoaDon
                    {
                        MaHoaDon = maHoaDon,
                        TenKhachHang = tenKhachHang,
                        CCCD = cccd,
                        SoDienThoai = sdt,
                        MaPhong = maPhong,
                        NgayThue = ngayDatPhong,
                        NgayTra = ngayTra,
                        TongTienDichVu = double.Parse(lbl_KQTongTienDichVu.Text),
                        TongTienThanhToan = tongTien
                    };

                    // Lưu thông tin thanh toán vào CSDL
                    bll.LuuThongTinThanhToan(thanhToan);
                    bllPhong.CapNhatTrangThaiPhong(maPhong, "Trống"); 

                    // Xóa các dịch vụ đã đăng ký cho phòng
                    bll.XoaDichVuDaDangKyCuaPhong(maPhong);

                    // Xóa thông tin đặt phòng trong bảng ThuePhong
                    bll.XoaThuePhong(maPhong);

                    MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    string tk = "ViDu";
                    frm_Main frm_TrangChu = new frm_Main(tk);
                    frm_Main.ViDu.OpenChildForm(new frm_GiaoDienPhong());
                }
                else
                {
                    // Người dùng không muốn thanh toán, không cần thực hiện gì thêm
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
