using QuanLyKhachSan.BLL;
using System;
using System.Drawing;
using System.Windows.Forms;


namespace QuanLyKhachSan
{
    public partial class frm_QuenMatKhau : Form
    {
        BLL_QuenMatKhau bll;
        public frm_QuenMatKhau()
        {
            InitializeComponent();
            bll = new BLL_QuenMatKhau();
            pnl_DoiMatKhau.Visible = false;
        }



        private void btn_KiemTra_Click(object sender, EventArgs e)
        {
            try
            {
                string tenDangNhap = txt_TenTK.Text;
                if (string.IsNullOrEmpty(tenDangNhap))
                {

                    throw new Exception("Bạn chưa nhập tên đăng nhập");
                }
                else if (string.IsNullOrWhiteSpace(tenDangNhap))
                {

                    throw new Exception("Bạn chưa nhập tên đăng nhập");
                }
                else if (tenDangNhap.Length < 5 || tenDangNhap.Length > 20)
                {

                    throw new Exception("Tên đăng nhập không được nhỏ hơn 5 và lớn hơn 20 kí tự");
                }
                else if (!bll.kiemTraTenDangNhap(tenDangNhap))
                {

                    throw new Exception("Tên đăng nhập không tồn tại!");
                }
                else
                {
                    lbl_KiemTraTK.Text = "";
                    pnl_DoiMatKhau.Visible = true;
                    txt_TenTK.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                if (ex.Message == ("Bạn chưa nhập tên đăng nhập"))
                {
                    lbl_KiemTraTK.Visible = true;
                    lbl_KiemTraTK.ForeColor = Color.Red;
                    lbl_KiemTraTK.Text = ex.Message;
                }
                else if (ex.Message == ("Tên đăng nhập không tồn tại!"))
                {
                    lbl_KiemTraTK.Visible = true;
                    lbl_KiemTraTK.ForeColor = Color.Red;
                    lbl_KiemTraTK.Text = ex.Message;
                }
                else if (ex.Message == ("Tên đăng nhập không được nhỏ hơn 5 và lớn hơn 20 kí tự"))
                {
                    lbl_KiemTraTK.Visible = true;
                    lbl_KiemTraTK.ForeColor = Color.Red;
                    lbl_KiemTraTK.Text = ex.Message;
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_LayLaiMatKhau_Click(object sender, EventArgs e)
        {
            try
            {
                string tenDangNhap = txt_TenTK.Text;
                string matKhauMoi = txt_MKM.Text;
                string nhapLaiMK = txt_NLMKM.Text;
                if (txt_MKM.Text == "")
                {
                    lbl_KiemTraNLMK.Text = "";
                    throw new Exception("Bạn chưa nhập mật khẩu");
                }
                else if (string.IsNullOrWhiteSpace(matKhauMoi))
                {
                    lbl_KiemTraNLMK.Text = "";
                    throw new Exception("Bạn chưa nhập mật khẩu");
                }
                else if (txt_MKM.Text.Length < 5 || txt_MKM.Text.Length > 20)
                {
                    lbl_KiemTraNLMK.Text = "";

                    throw new Exception("Mật khẩu không được nhỏ hơn 5 và lớn hơn 20 kí tự");
                }


                else if (txt_NLMKM.Text == "")
                {
                    lbl_KiemTraMKM.Text = "";
                    throw new Exception("Bạn chưa nhập xác nhận lại mật khẩu");
                }
                else if (string.IsNullOrWhiteSpace(nhapLaiMK))
                {
                    lbl_KiemTraMKM.Text = "";
                    throw new Exception("Bạn chưa nhập xác nhận lại mật khẩu");
                }
                else if (txt_NLMKM.Text.Length < 5 || txt_NLMKM.Text.Length > 20)
                {
                    lbl_KiemTraMKM.Text = "";

                    throw new Exception("Mật khẩu nhập lại không được nhỏ hơn 5 và lớn hơn 20 kí tự");
                }
                else if (matKhauMoi != nhapLaiMK)
                {
                    lbl_KiemTraMKM.Text = "";
                    throw new Exception("Lỗi. Mật khẩu không trùng nhau");
                }

                else
                {
                    lbl_KiemTraMKM.Text = "";
                    lbl_KiemTraNLMK.Text = "";
                    bll.doiMatKhau(tenDangNhap, matKhauMoi);
                    //lbl_notice_successfull.Visible = true;
                    MessageBox.Show("Đổi mật khẩu thành công!","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                if (ex.Message == ("Bạn chưa nhập mật khẩu"))
                {
                    lbl_KiemTraMKM.Visible = true;
                    lbl_KiemTraMKM.ForeColor = Color.Red;
                    lbl_KiemTraMKM.Text = ex.Message;
                }
                else if (ex.Message == ("Mật khẩu không được nhỏ hơn 5 và lớn hơn 20 kí tự"))
                {
                    lbl_KiemTraMKM.Visible = true;
                    lbl_KiemTraMKM.ForeColor = Color.Red;
                    lbl_KiemTraMKM.Text = ex.Message;
                }
                else if (ex.Message == ("Lỗi. Mật khẩu không trùng nhau"))
                {
                    lbl_KiemTraNLMK.Visible = true;
                    lbl_KiemTraNLMK.ForeColor = Color.Red;
                    lbl_KiemTraNLMK.Text = ex.Message;
                }
                else if (ex.Message == ("Mật khẩu nhập lại không được nhỏ hơn 5 và lớn hơn 20 kí tự"))
                {
                    lbl_KiemTraNLMK.Visible = true;
                    lbl_KiemTraNLMK.ForeColor = Color.Red;
                    lbl_KiemTraNLMK.Text = ex.Message;
                }
                else if (ex.Message == ("Bạn chưa nhập xác nhận lại mật khẩu"))
                {
                    lbl_KiemTraNLMK.Visible = true;
                    lbl_KiemTraNLMK.ForeColor = Color.Red;
                    lbl_KiemTraNLMK.Text = ex.Message;
                }
            }
        }
    }
}
