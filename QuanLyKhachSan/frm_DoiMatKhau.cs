using QuanLyKhachSan.BLL;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class frm_DoiMatKhau : Form
    {
        string _tk;
        BLL_DoiMatKhau bll;
        public frm_DoiMatKhau(string tk)
        {
            InitializeComponent();
            _tk = tk;
            bll = new BLL_DoiMatKhau();
        }


        private void btn_DoiMatKhau_Click(object sender, EventArgs e)
        {

        }


        void doimk()
        {
            try
            {
                string matKhauCu = txt_MatKhauCu.Text;
                string matKhauMoi = txt_MatKhauMoi.Text;
                string nhapLaiMK = txt_NhapLaiMK.Text;
                if (string.IsNullOrEmpty(matKhauCu))
                {
                    lbl_MKM.Text = "";
                    LBL_NLMKM.Text = "";
                    throw new Exception("Bạn chưa nhập mật khẩu cũ");
                }
                else if (string.IsNullOrWhiteSpace(matKhauCu))
                {
                    lbl_MKM.Text = "";
                    LBL_NLMKM.Text = "";
                    throw new Exception("Bạn chưa nhập mật khẩu cũ");
                }
                if (matKhauCu.Length < 5 || matKhauCu.Length > 20)
                {
                    lbl_MKM.Text = "";
                    LBL_NLMKM.Text = "";
                    throw new Exception("Mật khẩu cũ không được ít hơn 5 kí tự và nhiều hơn 20 kí tự");
                }
                var laymk = bll.Laymk(_tk);


                if (matKhauCu != laymk.MatKhau)
                {
                    lbl_MKM.Text = "";
                    LBL_NLMKM.Text = "";
                    throw new Exception("Lỗi. Bạn nhập sai mật khẩu cũ");
                }
                else if (string.IsNullOrEmpty(matKhauMoi))
                {
                    lbl_MKC.Text = "";
                    LBL_NLMKM.Text = "";
                    throw new Exception("Bạn chưa nhập mật khẩu mới");
                }
                else if (string.IsNullOrWhiteSpace(matKhauMoi))
                {
                    lbl_MKC.Text = "";
                    LBL_NLMKM.Text = "";
                    throw new Exception("Bạn chưa nhập mật khẩu mới");
                }
                if (matKhauMoi.Length < 5 || matKhauMoi.Length > 20)
                {
                    lbl_MKC.Text = "";
                    LBL_NLMKM.Text = "";
                    throw new Exception("Mật khẩu mới không được ít hơn 5 kí tự và nhiều hơn 20 kí tự");
                }
                else if (string.IsNullOrEmpty(nhapLaiMK))
                {
                    lbl_MKC.Text = "";
                    LBL_NLMKM.Text = "";
                    throw new Exception("Bạn chưa nhập xác nhận mật khẩu mới");
                }
                else if (string.IsNullOrWhiteSpace(nhapLaiMK))
                {
                    lbl_MKC.Text = "";
                    LBL_NLMKM.Text = "";
                    throw new Exception("Bạn chưa nhập xác nhận mật khẩu mới");
                }
                if (nhapLaiMK.Length < 5 || nhapLaiMK.Length > 20)
                {
                    lbl_MKC.Text = "";
                    LBL_NLMKM.Text = "";
                    throw new Exception("Mật khẩu nhập lại không được ít hơn 5 kí tự và nhiều hơn 20 kí tự");
                }
                else if (matKhauMoi != nhapLaiMK)
                {
                    lbl_MKC.Text = "";
                    LBL_NLMKM.Text = "";
                    throw new Exception("Mật khẩu nhập lại không trùng khớp!");
                }
                else
                {
                    lbl_MKC.Text = "";
                    lbl_MKM.Text = "";
                    LBL_NLMKM.Text = "";
                    bool doimk = bll.DoiMatKhau(_tk, matKhauCu, matKhauMoi);

                    frm_Main.ViDu.Hide();
                    frm_Login frm = new frm_Login();
                    frm.ShowDialog();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                if (ex.Message == ("Bạn chưa nhập mật khẩu cũ"))
                {
                    lbl_MKC.Visible = true;
                    lbl_MKC.ForeColor = Color.Red;
                    lbl_MKC.Text = ex.Message;
                }
                else if (ex.Message == ("Mật khẩu cũ không được ít hơn 5 kí tự và nhiều hơn 20 kí tự"))
                {
                    lbl_MKC.Visible = true;
                    lbl_MKC.ForeColor = Color.Red;
                    lbl_MKC.Text = ex.Message;
                }
                else if (ex.Message == ("Bạn chưa nhập mật khẩu mới"))
                {
                    lbl_MKM.Visible = true;
                    lbl_MKM.ForeColor = Color.Red;
                    lbl_MKM.Text = ex.Message;
                }
                else if (ex.Message == ("Mật khẩu mới không được ít hơn 5 kí tự và nhiều hơn 20 kí tự"))
                {
                    lbl_MKM.Visible = true;
                    lbl_MKM.ForeColor = Color.Red;
                    lbl_MKM.Text = ex.Message;
                }
                else if (ex.Message == ("Mật khẩu nhập lại không được ít hơn 5 kí tự và nhiều hơn 20 kí tự"))
                {
                    LBL_NLMKM.Visible = true;
                    LBL_NLMKM.ForeColor = Color.Red;
                    LBL_NLMKM.Text = ex.Message;
                }
                else if (ex.Message == ("Bạn chưa nhập xác nhận mật khẩu mới"))
                {
                    LBL_NLMKM.Visible = true;
                    LBL_NLMKM.ForeColor = Color.Red;
                    LBL_NLMKM.Text = ex.Message;
                }
                else if (ex.Message == ("Mật khẩu nhập lại không trùng khớp!"))
                {
                    LBL_NLMKM.Visible = true;
                    LBL_NLMKM.ForeColor = Color.Red;
                    LBL_NLMKM.Text = ex.Message;
                }
                else if (ex.Message == ("Lỗi. Bạn nhập sai mật khẩu cũ"))
                {
                    lbl_MKC.Visible = true;
                    lbl_MKC.ForeColor = Color.Red;
                    lbl_MKC.Text = ex.Message;
                }
            }
        }

        private void btn_DMK_Click(object sender, EventArgs e)
        {
            doimk();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_DoiMatKhau_Click(object sender, EventArgs e)
        {

        }

        private void lbl_TK_Click(object sender, EventArgs e)
        {

        }

        private void txt_TenTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_MK_Click(object sender, EventArgs e)
        {

        }

        private void txt_MatKhauMoi_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Matkhaucu_Click(object sender, EventArgs e)
        {

        }

        private void txt_MatKhauCu_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnl_DoiMK_Paint(object sender, PaintEventArgs e)
        {
            txt_TenTaiKhoan.Text = _tk;
        }

        private void frm_DoiMatKhau_Load(object sender, EventArgs e)
        {
            txt_TenTaiKhoan.Enabled = false;
        }
    }
}
