using QuanLyKhachSan.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class frm_KhachHang : Form
    {
        BLL_KhachHang bll;
        public frm_KhachHang()
        {
            InitializeComponent();
            bll = new BLL_KhachHang();
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
            label5.ForeColor = ThemeColor.PrimaryColor;
            label6.ForeColor = ThemeColor.SecondaryColor;
            label7.ForeColor = ThemeColor.PrimaryColor;
            label8.ForeColor = ThemeColor.SecondaryColor;
            label9.ForeColor = ThemeColor.PrimaryColor;
            label10.ForeColor = ThemeColor.SecondaryColor;
            label11.ForeColor = ThemeColor.SecondaryColor;
            label12.ForeColor = ThemeColor.PrimaryColor;
            label14.ForeColor = ThemeColor.SecondaryColor;
            label13.ForeColor = ThemeColor.SecondaryColor;
            label15.ForeColor = ThemeColor.PrimaryColor;
            label16.ForeColor = ThemeColor.SecondaryColor;
            label17.ForeColor = ThemeColor.PrimaryColor;
            label18.ForeColor = ThemeColor.SecondaryColor;
            label19.ForeColor = ThemeColor.PrimaryColor;
            label20.ForeColor = ThemeColor.SecondaryColor;

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

        private void frm_KhachHang_Load(object sender, EventArgs e)
        {
            bll.LoadDsKh(dgv_DanhSachKhachHang2);
            bll.LoadDsKh(dgv_DanhSachKhachHang);
            bll.LoadDsKh(dgv_DanhSachKhachHang1);
            var data2 = bll.laykhachhang();
        }

        private void dgv_DanhSachKhachHang2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_makh_sua.Enabled = false;
            txt_makh_sua.Text = dgv_DanhSachKhachHang2.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_tenkh_sua.Text = dgv_DanhSachKhachHang2.Rows[e.RowIndex].Cells[1].Value.ToString();
            string gioitinh = dgv_DanhSachKhachHang2.Rows[e.RowIndex].Cells[2].Value.ToString();
            string ngaysinh = dgv_DanhSachKhachHang2.Rows[e.RowIndex].Cells[3].Value.ToString();
            dtp_ngaysinh_sua.Value = DateTime.Parse(ngaysinh);
            txt_diachi_sua.Text = dgv_DanhSachKhachHang2.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_sdt_sua.Text = dgv_DanhSachKhachHang2.Rows[e.RowIndex].Cells[5].Value.ToString();
            txt_cccd_sua.Text = dgv_DanhSachKhachHang2.Rows[e.RowIndex].Cells[6].Value.ToString();

            if (gioitinh == "Nam")
            {
                rdb_nam_sua.Checked = true;
            }
            else
            {
                rdb_nu_sua.Checked = true;
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string gioitinh;
            if (rda_Nam.Checked)
            {
                gioitinh = "Nam";
            }
            else if (rda_Nu.Checked)
            {
                gioitinh = "Nữ";
            }
            else
            {
                gioitinh = null;
            }

            bool isValid = batloi(txt_makh.Text, txt_TenKhachHang.Text, txt_DiaChi.Text, txt_SoDienThoai.Text, txt_CMND.Text, gioitinh);
            if (!isValid)
                return;
            try
            {
                var data = bll.ktkhoa(txt_makh.Text);
                if (!data)
                    return;
                bool leSdt = bll.dodaisdt(txt_SoDienThoai.Text);
                if (!leSdt) return;
                bool lecccd = bll.dodaiccd(txt_CMND.Text);
                if (!lecccd) return;
                var ckhSdt = bll.ktsdt(txt_SoDienThoai.Text);
                if (!ckhSdt)
                    return;
                var chkCccd = bll.ktcccd(txt_CMND.Text);
                if (!chkCccd)
                    return;
                bll.ThemKH(txt_makh.Text, txt_TenKhachHang.Text, gioitinh, dtp_NgaySinh.Value.Date, txt_DiaChi.Text, txt_SoDienThoai.Text, txt_CMND.Text);
                MessageBox.Show("Đã thêm thông tin khách hàng " + txt_TenKhachHang.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bll.LoadDsKh(dgv_DanhSachKhachHang2);
                bll.LoadDsKh(dgv_DanhSachKhachHang);
                bll.LoadDsKh(dgv_DanhSachKhachHang1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string gioitinh;
            if (rda_Nam.Checked)
            {
                gioitinh = "Nam";
            }
            else
            {
                gioitinh = "Nữ";
            }
            bool isValid = batloi(txt_makh_sua.Text, txt_tenkh_sua.Text, gioitinh, txt_diachi_sua.Text, txt_sdt_sua.Text, txt_cccd_sua.Text);
            if (!isValid)
                return;
            try
            {
                DialogResult result = MessageBox.Show("Bạn có muốn sủa thông tin khách hàng này không?", "Sửa", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                    bll.SuaKH(txt_makh_sua.Text, txt_tenkh_sua.Text, gioitinh, dtp_NgaySinh.Value.Date, txt_diachi_sua.Text, txt_sdt_sua.Text, txt_cccd_sua.Text);
                MessageBox.Show("Đã sửa thông tin khách hàng " + txt_tenkh_sua.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bll.LoadDsKh(dgv_DanhSachKhachHang2);
                bll.LoadDsKh(dgv_DanhSachKhachHang);
                bll.LoadDsKh(dgv_DanhSachKhachHang1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa khách hàng này không này không?", "Sửa", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {

                bll.XoaKH(txt_makh_sua.Text);
            }
            MessageBox.Show("Đã xóa thông tin khách hàng " + txt_tenkh_sua.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bll.LoadDsKh(dgv_DanhSachKhachHang2);
            bll.LoadDsKh(dgv_DanhSachKhachHang);
            bll.LoadDsKh(dgv_DanhSachKhachHang1);

        }

        public bool batloi(string makh, string tenkh, string diachi, string sdt, string cccd, string gioitinh)
        {
            try
            {
                if (string.IsNullOrEmpty(makh))
                    throw new Exception("Chưa nhập mã khách hàng");
                if (string.IsNullOrEmpty(tenkh))
                    throw new Exception("Chưa nhập tên khách hàng");
                if (string.IsNullOrEmpty(diachi))
                    throw new Exception("Chưa nhập địa chỉ");
                if (string.IsNullOrEmpty(sdt))
                    throw new Exception("Chưa nhập số điện thoại");
                if (string.IsNullOrEmpty(cccd))
                    throw new Exception("Chưa nhập căn cước công dân");
                if (string.IsNullOrEmpty(gioitinh))
                    throw new Exception("Chưa chọn giới tính");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            return true;
        }

        private void txt_CMND1_TextChanged(object sender, EventArgs e)
        {
            bll.TimTheocccdKH(txt_CMND1.Text, dgv_DanhSachKhachHang1);
            if (txt_CMND1.Text == null)
            {
                bll.LoadDsKh(dgv_DanhSachKhachHang1);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            bll.TimKHTheoGioiTinh("Nam", dgv_DanhSachKhachHang1);

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            bll.TimKHTheoGioiTinh("Nữ", dgv_DanhSachKhachHang1);
        }

        private void txt_CMND1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt_tenkh_sua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_sdt_sua_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt_TenKhachHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_SoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt_CMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt_cccd_sua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt_tenkh_tim_TextChanged(object sender, EventArgs e)
        {
            bll.TimKHTheoTen(txt_tenkh_tim.Text, dgv_DanhSachKhachHang1);
            if (txt_tenkh_tim.Text == null)
            {
                bll.LoadDsKh(dgv_DanhSachKhachHang1);
            }
        }

        private void tabPage_ThemKhachHang_Click(object sender, EventArgs e)
        {

        }
    }
}
