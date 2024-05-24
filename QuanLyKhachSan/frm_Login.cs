using QuanLyKhachSan.BLL;
using System;
using System.Drawing;
using System.Windows.Forms;
namespace QuanLyKhachSan
{
    public partial class frm_Login : Form
    {
        BLL_DangNhap bll;
        public frm_Login()
        {
            InitializeComponent();
            bll = new BLL_DangNhap();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult Exit = MessageBox.Show("Bạn có muốn thoát không?","Thông báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (Exit == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
            if (bll.kiemtraluumk() == true)
            {
                chk_ghiNhoDangNhap.Checked = true;

            }
            else
            {
                chk_ghiNhoDangNhap.Checked = false;
            }
            loadNhomk();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            string username = txt_TaiKhoan.Text;
            string password = txt_MatKhau.Text;
            try
            {
                if (string.IsNullOrEmpty(username))
                {
                    lbl_chk_MatKhau.Text = "";
                    throw new Exception("Vui lòng nhập tên đăng nhập.");
                }
                else if (string.IsNullOrWhiteSpace(username))
                {
                    lbl_chk_MatKhau.Text = "";
                    throw new Exception("Vui lòng nhập tên đăng nhập.");
                }
                else if (username.Length < 5 || username.Length > 20)
                {
                    lbl_chk_MatKhau.Text = "";
                    throw new Exception("Tên đăng nhập không được nhỏ hơn 5 và lớn hơn 20 kí tự");
                }
                else if (string.IsNullOrWhiteSpace(password))
                {
                    lbl_chk_TenDangNhap.Text = "";
                    throw new Exception("Vui lòng nhập mật khẩu.");
                }
                else if (password.Length < 5 || password.Length > 20)
                {
                    lbl_chk_TenDangNhap.Text = "";
                    throw new Exception("Mật khẩu không được nhỏ hơn 5 và lớn hơn 20 kí tự");
                }
                else
                {

                    if (chk_ghiNhoDangNhap.Checked)
                    {


                        var savedLoginInfo = bll.LayThongTinDaLuu();
                        if (savedLoginInfo != null)
                        {
                            bll.CapNhapThongTin(username, password);
                        }
                        else
                        {
                            bll.LuuThongTinDangNhap(username, password);
                        }
                    }
                    else
                    {
                        bll.XoaThongTinDaLuu();
                    }


                    string tinhTrang = bll.KiemTraTinhTrang(username);
                    if (tinhTrang == "Thanh Cong")
                    {




                        bool dangnhap = bll.DangNhapTaiKhoan(username, password);
                        if (dangnhap)
                        {
                            this.Hide();
                            frm_Main frm = new frm_Main(username);
                            frm.ShowDialog();
                            this.Close();
                        }
                        else
                        {


                            lbl_chk_TenDangNhap.Text = "";
                            throw new Exception("Tên đăng nhập, mật khẩu không chính xác");
                        }
                    }
                    else if (tinhTrang == "That bai")
                    {
                        string lydo = bll.LayLyDo(username);
                        MessageBox.Show("Đăng nhập thất bại. Lý do: " + lydo, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    //else
                    //{
                    //    MessageBox.Show("Tài khoản của bạn đang đợi xác thực. Xin vui lòng đợi admin xác thực", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //}

                }
            }
            catch (Exception ex)
            {
                if (ex.Message == ("Vui lòng nhập tên đăng nhập."))
                {
                    lbl_chk_TenDangNhap.Visible = true;
                    lbl_chk_TenDangNhap.ForeColor = Color.Red;
                    lbl_chk_TenDangNhap.Text = ex.Message;
                }
                else if (ex.Message == ("Tên đăng nhập không được nhỏ hơn 5 và lớn hơn 20 kí tự"))
                {
                    lbl_chk_TenDangNhap.Visible = true;
                    lbl_chk_TenDangNhap.ForeColor = Color.Red;
                    lbl_chk_TenDangNhap.Text = ex.Message;
                }
                else if (ex.Message == ("Mật khẩu không được nhỏ hơn 5 và lớn hơn 20 kí tự"))
                {
                    lbl_chk_MatKhau.Visible = true;
                    lbl_chk_MatKhau.ForeColor = Color.Red;
                    lbl_chk_MatKhau.Text = ex.Message;
                }
                else if (ex.Message == ("Vui lòng nhập mật khẩu."))
                {
                    lbl_chk_MatKhau.Visible = true;
                    lbl_chk_MatKhau.ForeColor = Color.Red;
                    lbl_chk_MatKhau.Text = ex.Message;
                }
                else if (ex.Message == ("Tên đăng nhập, mật khẩu không chính xác"))
                {
                    lbl_chk_MatKhau.Visible = true;
                    lbl_chk_MatKhau.ForeColor = Color.Red;
                    lbl_chk_MatKhau.Text = ex.Message;
                }
            }
        }
        void loadNhomk()
        {
            var savedLoginInfo = bll.LayThongTinDaLuu();

            if (savedLoginInfo != null)
            {
                txt_TaiKhoan.Text = savedLoginInfo.TaiKhoan;
                txt_MatKhau.Text = savedLoginInfo.MatKhau;
            }
        }

        private void lkb_QuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_QuenMatKhau QuenMatKhau = new frm_QuenMatKhau();
            QuenMatKhau.ShowDialog();
        }

        private void lkb_DangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frm_DangKy DangKy = new frm_DangKy();
            DangKy.ShowDialog();
        }
    }
}
