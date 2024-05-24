using QuanLyKhachSan.BLL;
using System;
using System.Drawing;
using System.Windows.Forms;


namespace QuanLyKhachSan
{
    public partial class frm_DangKy : Form
    {
        BLL_DangKy DK;
        string PhanQuyen;
        string MaNhanVien;
        public frm_DangKy()
        {
            InitializeComponent();
            DK = new BLL_DangKy();
        }


        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Login dangNhap = new frm_Login();
            dangNhap.ShowDialog();
            this.Close();
        }

        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            try
            {
                string tk = txt_TaiKhoan.Text;
                string mk = txt_MatKhau.Text;
                var tt = DK.KiemTraTTNS(txt_CCCD.Text);
                bool ktTaiKhoan = DK.kiemTraTk(tk);

                if (txt_CCCD.Text == "")
                {
                    lbl_KiemTraTK.Text = "";
                    lbl_KiemTraMK.Text = "";
                    throw new Exception("*Lỗi. Bạn chưa nhập căn cước công dân");
                }
                else if (string.IsNullOrWhiteSpace(txt_CCCD.Text))
                {
                    lbl_KiemTraTK.Text = "";
                    lbl_KiemTraMK.Text = "";
                    throw new Exception("*Lỗi. Bạn chưa nhập căn cước công dân");
                }
                else if (tt == null)
                {
                    lbl_KiemTraTK.Text = "";
                    lbl_KiemTraMK.Text = "";
                    throw new Exception("*Lỗi. Không có nhân sự nào có mã căn cước công dân như này");
                }

                else if (tk == "")
                {
                    lbl_KiemTraCCCD.Text = "";
                    lbl_KiemTraMK.Text = "";
                    throw new Exception("*Lỗi. Bạn chưa nhập thông tin tài khoản");
                }
                else if (string.IsNullOrWhiteSpace(tk))
                {
                    lbl_KiemTraCCCD.Text = "";
                    lbl_KiemTraMK.Text = "";
                    throw new Exception("*Lỗi. Bạn chưa nhập thông tin tài khoản");
                }
                else if (tk.Length < 5 || tk.Length > 20)
                {
                    lbl_KiemTraCCCD.Text = "";
                    lbl_KiemTraMK.Text = "";

                    throw new Exception("Tên đăng nhập không được nhỏ hơn 5 và lớn hơn 20 kí tự");
                }
                else if (ktTaiKhoan)
                {
                    lbl_KiemTraCCCD.Text = "";
                    lbl_KiemTraMK.Text = "";
                    throw new Exception("*Lỗi. Trùng tài khoản");
                }
                else if (mk == "")
                {
                    lbl_KiemTraCCCD.Text = "";
                    lbl_KiemTraTK.Text = "";
                    throw new Exception("*Lỗi. Bạn chưa nhập mật khẩu");

                }
                else if (string.IsNullOrWhiteSpace(mk))
                {
                    lbl_KiemTraCCCD.Text = "";
                    lbl_KiemTraTK.Text = "";
                    throw new Exception("*Lỗi. Bạn chưa nhập mật khẩu");
                }
                else if (mk.Length < 5 || mk.Length > 20)
                {
                    lbl_KiemTraCCCD.Text = "";
                    lbl_KiemTraTK.Text = "";

                    throw new Exception("Mật khẩu không được nhỏ hơn 5 và lớn hơn 20 kí tự");
                }
                else
                {
                    lbl_KiemTraCCCD.Text = "";
                    lbl_KiemTraTK.Text = "";
                    lbl_KiemTraMK.Text = "";
                    DialogResult result = MessageBox.Show("Bạn có muốn đăng ký với những thông tin bạn đã nhập chưa ?", "Thông báo xác nhận", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {


                        PhanQuyen = tt.ChucVu;
                        MaNhanVien = tt.MaNhanVien;

                        DK.ThemTK(tk, mk, PhanQuyen, MaNhanVien);
                        txt_CCCD.Enabled = false;
                        txt_TaiKhoan.Enabled = false;
                        txt_MatKhau.Enabled = false;
                        MessageBox.Show("Đăng kí thành công");
                    }
                }

            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("căn cước công dân"))
                {
                    lbl_KiemTraCCCD.Visible = true;
                    lbl_KiemTraCCCD.ForeColor = Color.Red;
                    lbl_KiemTraCCCD.Text = ex.Message;
                }
                else if (ex.Message.Contains("tài khoản"))
                {
                    lbl_KiemTraTK.Visible = true;
                    lbl_KiemTraTK.ForeColor = Color.Red;
                    lbl_KiemTraTK.Text = ex.Message;
                }
                else if (ex.Message.Contains("Tên đăng nhập không được nhỏ hơn 5 và lớn hơn 20 kí tự"))
                {
                    lbl_KiemTraTK.Visible = true;
                    lbl_KiemTraTK.ForeColor = Color.Red;
                    lbl_KiemTraTK.Text = ex.Message;
                }
                else if (ex.Message.Contains("mật khẩu"))
                {
                    lbl_KiemTraMK.Visible = true;
                    lbl_KiemTraMK.ForeColor = Color.Red;
                    lbl_KiemTraMK.Text = ex.Message;
                }
                else if (ex.Message.Contains("Mật khẩu không được nhỏ hơn 5 và lớn hơn 20 kí tự"))
                {
                    lbl_KiemTraMK.Visible = true;
                    lbl_KiemTraMK.ForeColor = Color.Red;
                    lbl_KiemTraMK.Text = ex.Message;
                }
            }
        }
    }
}
