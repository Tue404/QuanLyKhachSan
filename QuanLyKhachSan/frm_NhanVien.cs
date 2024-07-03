using QuanLyKhachSan.BLL;
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
    public partial class frm_NhanVien : Form
    {
        BLL_NhanVien bll;
        public frm_NhanVien()
        {
            InitializeComponent();
            bll = new BLL_NhanVien();
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

        private void frm_NhanVien_Load(object sender, EventArgs e)
        {
            bll.LoadDsNv(dgv_nhansu);
            bll.LoadDsNv(dgv2_NhanSu);
            bll.LoadDsNv(dgv1_NhanSu);
        }

        public bool batloi(string mans, string tennv, string diachi, string sdt, string chucvu, string gioitinh, string cccd)
        {
            try
            {
                if (string.IsNullOrEmpty(mans))
                    throw new Exception("Chưa nhập mã nhân sự");
                if (string.IsNullOrEmpty(tennv))
                    throw new Exception("Chưa nhập tên nhân viên");
                if (string.IsNullOrEmpty(diachi))
                    throw new Exception("Chưa nhập địa chỉ");
                if (string.IsNullOrEmpty(sdt))
                    throw new Exception("Chưa nhập số điện thoại");
                if (string.IsNullOrEmpty(chucvu))
                    throw new Exception("Chưa nhập chức vụ");
                if (string.IsNullOrEmpty(gioitinh))
                    throw new Exception("Chưa nhập giới tính");
                if (string.IsNullOrEmpty(cccd))
                    throw new Exception("Chưa nhập căn cước công dân");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            return true;
        }

        private void btn_Them_Click_1(object sender, EventArgs e)
        {
            try
            {
                string gioitinh;
                if (rdo_Nam.Checked)
                {
                    gioitinh = "Nam";
                }
                else if (rdo_Nu.Checked)
                {
                    gioitinh = "Nữ";
                }
                else
                {
                    gioitinh = null;
                }
                bool isValid = batloi(txt_manv_them.Text, txt_TenNhanVien.Text, txt_DiaChi.Text, txt_SoDienThoai.Text, txt_chucvu1.Text, gioitinh, txt_cccd.Text);
                if (!isValid)
                    return;
                bool khoaching = bll.KiemTraKhoa(txt_manv_them.Text);
                if (!khoaching)
                    return;
                bool leSdt = bll.dodaisdt(txt_SoDienThoai.Text);
                if (!leSdt) return;
                bool lecccd = bll.dodaiccd(txt_cccd.Text);
                if (!lecccd) return;
                bool ktsdt = bll.KiemTraSDT(txt_SoDienThoai.Text);
                if (!ktsdt)
                    return;
                bool ktcccd = bll.KiemTraCCCD(txt_cccd.Text);
                if (!ktcccd)
                    return;
                bll.ThemNhanVien(txt_manv_them.Text, txt_TenNhanVien.Text, gioitinh, txt_DiaChi.Text, txt_SoDienThoai.Text, dtp_NgaySinh.Value.Date, dtp_NgayVaoLam.Value.Date, txt_chucvu1.Text, txt_cccd.Text);

                bll.LoadDsNv(dgv_nhansu);
                bll.LoadDsNv(dgv1_NhanSu);
                bll.LoadDsNv(dgv2_NhanSu);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Đã thêm thông tin nhân viên " + txt_TenNhanVien.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string gioitinh;
            if (rdo_NamSua.Checked)
            {
                gioitinh = "Nam";
            }
            else
            {
                gioitinh = "Nữ";
            }
            bool isValid = batloi(txt_MaNVsua.Text, txt_TenNVsua.Text, txt_DiaChisua.Text, txt_SDTsua.Text, txt_ChucVusua.Text, gioitinh, txt_CCCDsua.Text);
            if (!isValid)
                return;
            try
            {
                DialogResult result = MessageBox.Show("Bạn có muốn sủa nhân viên này không?", "Sửa", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)

                    bll.SuaNhanVien(txt_MaNVsua.Text, txt_TenNVsua.Text, gioitinh, txt_DiaChisua.Text, txt_SDTsua.Text, dtp_NgaySinhsua.Value.Date, dtp_NgayVaoLamsua.Value.Date, txt_ChucVusua.Text, txt_CCCDsua.Text);

            }
            catch (Exception ex)
            {
                //File.AppendAllText("error.log", ex.ToString() + Environment.NewLine);
                //return;
            }
            MessageBox.Show("Đã sửa thông tin nhân viên " + txt_TenNVsua.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txt_MaNVsua.Enabled = true;
            bll.LoadDsNv(dgv_nhansu);
            bll.LoadDsNv(dgv1_NhanSu);
            bll.LoadDsNv(dgv2_NhanSu);
        }


        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa nhân sự này không?", "Xoát", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                    bll.XoaNhanVien(txt_MaNVsua.Text);
                bll.LoadDsNv(dgv_nhansu);
                bll.LoadDsNv(dgv2_NhanSu);
                bll.LoadDsNv(dgv1_NhanSu);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Đã xóa thông tin nhân viên " + txt_TenNVsua.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txt_MaNVsua.Enabled = true;
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txt_TimTenNhanVien_TextChanged(object sender, EventArgs e)
        {
            bll.TimNhanVienTheoTen(txt_TimTenNhanVien.Text, dgv1_NhanSu);
        }

        private void dgv2_NhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaNVsua.Enabled = false;
            try
            {
                txt_MaNVsua.Text = dgv2_NhanSu.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_TenNVsua.Text = dgv2_NhanSu.Rows[e.RowIndex].Cells[1].Value.ToString();
                string gioitinh = dgv2_NhanSu.Rows[e.RowIndex].Cells[2].Value.ToString();
                txt_ChucVusua.Text = dgv2_NhanSu.Rows[e.RowIndex].Cells[3].Value.ToString();
                string ngaysinh2 = dgv2_NhanSu.Rows[e.RowIndex].Cells[4].Value.ToString();
                string ngayvaolam2 = dgv2_NhanSu.Rows[e.RowIndex].Cells[5].Value.ToString();
                dtp_NgaySinhsua.Value = DateTime.Parse(ngaysinh2);
                dtp_NgayVaoLamsua.Value = DateTime.Parse(ngayvaolam2);
                txt_DiaChisua.Text = dgv2_NhanSu.Rows[e.RowIndex].Cells[6].Value.ToString();
                txt_SDTsua.Text = dgv2_NhanSu.Rows[e.RowIndex].Cells[7].Value.ToString();
                if (gioitinh == "Nam")
                {
                    rdo_NamSua.Checked = true;
                }
                else
                {
                    rdo_NuSua.Checked = true;
                }
                //bll.layanhNV(txt_manv_sua.Text, pic_anh);
                txt_CCCDsua.Text = dgv2_NhanSu.Rows[e.RowIndex].Cells[7].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tabPage_TimNhanVien_Click(object sender, EventArgs e)
        {
            bll.TimNhanSuTheoChucVu(txt_TimChucVu.Text, dgv1_NhanSu);
            if (txt_TimChucVu.Text == null)
            {
                bll.LoadDsNv(dgv2_NhanSu);
            }
        }

        private void rdo_TimNam_CheckedChanged(object sender, EventArgs e)
        {
            bll.TimNhanVienTheoGioiTinh("Nam", dgv1_NhanSu);
        }

        private void rdo_TImNu_CheckedChanged(object sender, EventArgs e)
        {
            bll.TimNhanVienTheoGioiTinh("Nữ", dgv1_NhanSu);
        }

        private void txt_TimSDT_TextChanged(object sender, EventArgs e)
        {
            bll.TimNhanVienTheosdt(txt_TimSDT.Text, dgv1_NhanSu);
            if (txt_TimSDT.Text == null)
            {
                bll.LoadDsNv(dgv2_NhanSu);
            }
        }
 

        private void btn_Load_Click(object sender, EventArgs e)
        {
            bll.LoadDsNv(dgv1_NhanSu);
        }

        private void txt_TimTenNhanVien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_TimChucVu_TextChanged(object sender, EventArgs e)
        {

            //bll.TimNhanSuTheoChucVu(txt_TimChucVu.Text, dgv2_NhanVien);
            //if (string.IsNullOrEmpty(txt_TimChucVu.Text))
            //{
            //    bll.LoadDsNv(dgv2_NhanVien); // Load toàn bộ danh sách nếu textbox rỗng
            //}

            if (!string.IsNullOrEmpty(txt_TimChucVu.Text))
            {
                bll.TimNhanSuTheoChucVu(txt_TimChucVu.Text, dgv2_NhanSu);
            }
            else
            {
                bll.LoadDsNv(dgv2_NhanSu); // Tải lại danh sách nếu text box trống
            }
        }

        private void txt_TimChucVu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_ChucVusua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_ChucVu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_SDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt_TimSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt_SDTsua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt_CCCD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt_CCCDsua_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt_TenNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            
                e.Handled = true;
        }
    }
}
