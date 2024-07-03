using QuanLyKhachSan.BLL;
using QuanLyKhachSan.DA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class frm_ThongTinPhong : Form   
    {
        private static frm_ThongTinPhong instance;
        public static frm_ThongTinPhong Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new frm_ThongTinPhong();
                }
                return instance;
            }
        }

        string maPhong;
        string maKhachHang;
        string TenKhachHang;
        BLL_ThongTinPhong bll;
        public frm_ThongTinPhong()
        {
            InitializeComponent();
            bll = new BLL_ThongTinPhong();
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
            label1.ForeColor = ThemeColor.SecondaryColor;
            label2.ForeColor = ThemeColor.PrimaryColor;
            label3.ForeColor = ThemeColor.SecondaryColor;
            label7.ForeColor = ThemeColor.PrimaryColor;

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

        private void GTListView()
        {
            lstv_DichVuDaSuDung.View = View.Details;
            lstv_DichVuDaSuDung.Columns.Add("Mã đăng ký DV", 110);
            lstv_DichVuDaSuDung.Columns.Add("Mã DV", 100);
            lstv_DichVuDaSuDung.Columns.Add("Tên DV", 130);
            lstv_DichVuDaSuDung.Columns.Add("Số Lượng", 100);
            lstv_DichVuDaSuDung.Columns.Add("Đơn Giá", 100);
            lstv_DichVuDaSuDung.Columns.Add("Tổng tiền", 100);
        }

        public frm_ThongTinPhong(string maPhong)
        {
            InitializeComponent();
            this.maPhong = maPhong;
            bll = new BLL_ThongTinPhong();
            GTListView();
        }

        public frm_ThongTinPhong(ThuePhong thuePhong)
        {
            InitializeComponent();
            GTListView();
            this.maPhong = thuePhong.MaPhong;
            this.maKhachHang = thuePhong.MaKhachHang;
            //  this.TenKhachHang = thuePhong.KhachHang.TenKhachHang;

            //lbl_Phong.Text = maPhong;
            lbl_KQ_NgayThue.Text = thuePhong.NgayThue?.ToShortDateString();
            lbl_KQTenKhachHang.Text = TenKhachHang;

            var thongtinkhachhang = bll.loadthongtinkhachhang(thuePhong.MaKhachHang);
            lbl_KQCMND.Text = thongtinkhachhang.CCCD;
            lbl_KQDiaChi.Text = thongtinkhachhang.DiaChi;
        }

   
        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_TraPhong quanLyTraPhong = new frm_TraPhong(maPhong, maKhachHang, TenKhachHang);
            frm_Main.ViDu.OpenChildForm(quanLyTraPhong);
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frm_ThongTinPhong_Load(object sender, EventArgs e)
        {
            lbl_Phong.Text = maPhong;
            var tt = bll.LoadThongTinPhong(maPhong);
            maKhachHang = tt.MaKhachHang;

            lbl_KQ_NgayThue.Text = tt.NgayThue?.ToShortDateString();
            var thongtinkhachhang = bll.loadthongtinkhachhang(tt.MaKhachHang);
            lbl_KQTenKhachHang.Text = thongtinkhachhang.TenKhachHang;
            TenKhachHang = thongtinkhachhang.TenKhachHang;
            lbl_KQCMND.Text = thongtinkhachhang.CCCD;
            lbl_KQDiaChi.Text = thongtinkhachhang.DiaChi;

            LoadDanhSachDichVuDaSuDung();
        }

        public void UpdateDichVuDaSuDung(ListViewItem newItem)
        {
            // Kiểm tra xem item đã tồn tại trong ListView chưa
            ListViewItem existingItem = lstv_DichVuDaSuDung.FindItemWithText(newItem.SubItems[0].Text);

            if (existingItem != null)
            {
                // Cập nhật dữ liệu cho item đã tồn tại
                existingItem.SubItems[1].Text = newItem.SubItems[1].Text;
                existingItem.SubItems[2].Text = newItem.SubItems[2].Text;
            }
            else
            {
                // Nếu chưa tồn tại, thêm item mới
                lstv_DichVuDaSuDung.Items.Add(newItem);
            }
        }

        public void LoadDanhSachDichVuDaSuDung()
        {
            lstv_DichVuDaSuDung.Items.Clear();

            // Truy vấn dữ liệu từ bảng DangKyDichVu
            List<DangKyDichVu> danhSachDangKyDichVu = bll.LoadDanhSachDangKyDichVu(maPhong);

            foreach (var dangKyDichVu in danhSachDangKyDichVu)
            {
                // Lấy tên dịch vụ từ mã dịch vụ
                string tenDichVu = bll.GetTenDichVuByMaDichVu(dangKyDichVu.MaDichVu);
                double tongTien = (int)dangKyDichVu.SoLuong * (double)dangKyDichVu.DonGia;


                ListViewItem item = new ListViewItem(new string[]
                {
                    dangKyDichVu.MaDangKyDV,
                    dangKyDichVu.MaDichVu,
                    tenDichVu,
                    dangKyDichVu.SoLuong.ToString(),
                    dangKyDichVu.DonGia.ToString(),
                    tongTien.ToString() // Thêm giá trị tổng tiền vào ListView
                });

                lstv_DichVuDaSuDung.Items.Add(item);
            }
        }

        private void btn_DangKyDV_Click(object sender, EventArgs e)
        {
            // Khởi tạo form frm_DichVu
            frm_DichVu dichVuForm = new frm_DichVu();

            // Lấy tham chiếu đến tabControl_DichVu_ADM trong frm_DichVu
            TabControl tabControl_DichVu_ADM = dichVuForm.TabControl_DichVu;

            if (tabControl_DichVu_ADM != null)
            {
                // Chuyển đổi sang tab tabPage_DangKyDichVu trong frm_DichVu
                tabControl_DichVu_ADM.SelectedTab = dichVuForm.TabPage_DichVu_;
            }
            else
            {
                MessageBox.Show("Không tìm thấy tabControl_DichVu_ADM trong frm_DichVu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
            string tk = "ViDu";
            frm_Main frm_TrangChu = new frm_Main(tk);
            frm_Main.ViDu.OpenChildForm(dichVuForm);
        }

        private void btn_DangKyDichVu_Click(object sender, EventArgs e)
        {

        }
    }
}
