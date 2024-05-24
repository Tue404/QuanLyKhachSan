using QuanLyKhachSan.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class frm_ThongTinKhachHang : Form
    {

        BLL_KhachHang bll;
        public frm_ThongTinKhachHang()
        {
            InitializeComponent();
            bll = new BLL_KhachHang();

            LoadTheme();    

        }
        private void LoadTheme()
        {
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
            label6.ForeColor = ThemeColor.SecondaryColor;
            label7.ForeColor = ThemeColor.PrimaryColor;
            label8.ForeColor = ThemeColor.SecondaryColor;
            label9.ForeColor = ThemeColor.PrimaryColor;

        }

        private void frm_ThongTinKhachHang_Load(object sender, EventArgs e)
        {
            bll.LoadDsKh(dgv_danhSachKhachHang);
            bll.LoadDsKh(dgv_danhSachKhachHang);
            bll.LoadDsKh(dgv_danhSachKhachHang);
            var data2 = bll.laykhachhang();
        }


        private void dgv_danhSachKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txt_MaKH.Text = dgv_danhSachKhachHang.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_TenKH.Text = dgv_danhSachKhachHang.Rows[e.RowIndex].Cells[1].Value.ToString();
                string gioitinh = dgv_danhSachKhachHang.Rows[e.RowIndex].Cells[2].Value.ToString();
                string ngaysinh = dgv_danhSachKhachHang.Rows[e.RowIndex].Cells[3].Value.ToString();
                dpt_NgaySinh.Value = DateTime.Parse(ngaysinh);
                txt_DiaChi.Text = dgv_danhSachKhachHang.Rows[e.RowIndex].Cells[4].Value.ToString();
                txt_SDT.Text = dgv_danhSachKhachHang.Rows[e.RowIndex].Cells[5].Value.ToString();
                txt_CCCD.Text = dgv_danhSachKhachHang.Rows[e.RowIndex].Cells[6].Value.ToString();

                if (gioitinh == "Nam")
                {
                    rdo_Nam.Checked = true;
                }
                else
                {
                    rdo_Nu.Checked = true;
                }
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txt_MaKH.Text = "";
            txt_TenKH.Text = "";
            txt_SDT.Text = "";
            txt_DiaChi.Text = "";
            txt_CCCD.Text = "";
        }

        private void btn_Them_Click(object sender, EventArgs e)
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

            bool isValid = batloi(txt_MaKH.Text, txt_TenKH.Text, txt_DiaChi.Text, txt_SDT.Text, txt_CCCD.Text, gioitinh);
            if (!isValid)
                return;
            try
            {
                var data = bll.ktkhoa(txt_MaKH.Text);
                if (!data)
                    return;
                bool leSdt = bll.dodaisdt(txt_SDT.Text);
                if (!leSdt) return;
                bool lecccd = bll.dodaiccd(txt_CCCD.Text);
                if (!lecccd) return;
                var ckhSdt = bll.ktsdt(txt_SDT.Text);
                if (!ckhSdt)
                    return;
                var chkCccd = bll.ktcccd(txt_CCCD.Text);
                if (!chkCccd)
                    return;
                bll.ThemKH(txt_MaKH.Text, txt_TenKH.Text, gioitinh, dpt_NgaySinh.Value.Date, txt_DiaChi.Text, txt_SDT.Text, txt_CCCD.Text);
                MessageBox.Show("Đã thêm thông tin khách hàng " + txt_TenKH.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bll.LoadDsKh(dgv_danhSachKhachHang);
                bll.LoadDsKh(dgv_danhSachKhachHang);
                bll.LoadDsKh(dgv_danhSachKhachHang);
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
            if (rdo_Nam.Checked)
            {
                gioitinh = "Nam";
            }
            else
            {
                gioitinh = "Nữ";
            }
            bool isValid = batloi(txt_MaKH.Text, txt_TenKH.Text, gioitinh, txt_DiaChi.Text, txt_SDT.Text, txt_CCCD.Text);
            if (!isValid)
                return;

            try
            {
                DialogResult result = MessageBox.Show("Bạn có muốn sửa thông tin khách hàng này không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    bll.SuaKH(txt_MaKH.Text, txt_TenKH.Text, gioitinh, dpt_NgaySinh.Value.Date, txt_DiaChi.Text, txt_SDT.Text, txt_CCCD.Text);
                    MessageBox.Show("Đã sửa thông tin khách hàng " + txt_TenKH.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bll.LoadDsKh(dgv_danhSachKhachHang);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void btn_Xoa_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Bạn có muốn xóa khách hàng này không này không?", "Thông báo", MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                bll.XoaKH(txt_MaKH.Text);
            }
            MessageBox.Show("Đã xóa thông tin khách hàng " + txt_TenKH.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bll.LoadDsKh(dgv_danhSachKhachHang);
            bll.LoadDsKh(dgv_danhSachKhachHang);
            bll.LoadDsKh(dgv_danhSachKhachHang);
        }

        private void txt_CCCD_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt_TenKH_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
