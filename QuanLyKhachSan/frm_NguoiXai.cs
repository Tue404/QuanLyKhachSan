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
    public partial class frm_NguoiXai : Form
    {
        BLL_QuanLyTaiKhoan dstk;
        public frm_NguoiXai()
        {
            InitializeComponent();
            dstk = new BLL_QuanLyTaiKhoan();
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

        private void lbl_mksua_Chk_Click(object sender, EventArgs e)
        {

        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            string timKiem = txt_TimKiem.Text;
            var ketqua = dstk.TimTaiKhoan(timKiem);
            dgv_DanhSachNguoiDung1.DataSource = ketqua;
        }



        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                string tenDangNhap = txt_TenDangNhap.Text;
                string matKhau = txt_MatKhau.Text;
                string manhansu = txt_manhanvien_them.Text;
                if (string.IsNullOrWhiteSpace(tenDangNhap))
                {
                    lbl_mkthem_chk.Text = "";
                    lbl_pqthem_chk.Text = "";
                    lbl_mnsthem_chk.Text = "";
                    throw new Exception("Lỗi. Chưa nhập tên đăng nhập!");
                }
                else if (dstk.KiemTraTenDangNhap(tenDangNhap))
                {
                    lbl_mkthem_chk.Text = "";
                    lbl_pqthem_chk.Text = "";
                    lbl_mnsthem_chk.Text = "";
                    throw new Exception("Lỗi. Tên đăng nhập đã tồn tại!");
                }
                else if (tenDangNhap.Length < 5 || tenDangNhap.Length > 20)
                {
                    lbl_mkthem_chk.Text = "";
                    lbl_pqthem_chk.Text = "";
                    lbl_mnsthem_chk.Text = "";
                    throw new Exception("Tên đăng nhập không được nhỏ hơn 5 và lớn hơn 20 kí tự");
                }
                else if (string.IsNullOrWhiteSpace(matKhau))
                {
                    lbl_tdnthem_chk.Text = "";
                    lbl_pqthem_chk.Text = "";
                    lbl_mnsthem_chk.Text = "";
                    throw new Exception("Lỗi. Chưa nhập mật khẩu!");
                }
                else if (matKhau.Length < 5 || matKhau.Length > 20)
                {
                    lbl_tdnthem_chk.Text = "";
                    lbl_pqthem_chk.Text = "";
                    lbl_mnsthem_chk.Text = "";
                    throw new Exception("Mật khẩu không được nhỏ hơn 5 và lớn hơn 20 kí tự");
                }
                else if (string.IsNullOrWhiteSpace(manhansu))
                {
                    lbl_tdnthem_chk.Text = "";
                    lbl_mkthem_chk.Text = "";
                    lbl_pqthem_chk.Text = "";

                    throw new Exception("Lỗi. Bạn chưa nhập Mã nhân viên");
                }
                else if (!dstk.KiemTraMaNhanSu(manhansu))
                {
                    lbl_tdnthem_chk.Text = "";
                    lbl_mkthem_chk.Text = "";
                    lbl_pqthem_chk.Text = "";
                    throw new Exception("Lỗi. Mã nhân viên không hợp lệ!");
                }
                if (cbo_phanquen_them.SelectedItem == null)
                {
                    lbl_tdnthem_chk.Text = "";
                    lbl_mkthem_chk.Text = "";
                    lbl_mnsthem_chk.Text = "";
                    throw new Exception("Lỗi. Bạn chưa chọn Phân quyền");
                }
                else
                {
                    lbl_tdnthem_chk.Text = "";
                    lbl_mkthem_chk.Text = "";
                    lbl_mnsthem_chk.Text = "";
                    string phanQuyen = cbo_phanquen_them.SelectedItem.ToString();
                    bool ktpq = dstk.KiemTraPhanQuyen(manhansu, phanQuyen);
                    if (!ktpq)
                    {
                        throw new Exception("Lỗi. Phân quyền không hợp lệ. Thử kiểm tra lại ở phần nhân viên");
                    }
                    else
                    {

                        lbl_tdnthem_chk.Text = "";
                        lbl_mkthem_chk.Text = "";
                        lbl_pqthem_chk.Text = "";
                        lbl_mnsthem_chk.Text = "";
                        dstk.ThemTaiKhoan(tenDangNhap, matKhau, phanQuyen, manhansu);
                        loadThongTin();

                    }
                }

            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("đăng nhập"))
                {
                    lbl_tdnthem_chk.Visible = true;
                    lbl_tdnthem_chk.ForeColor = Color.Red;
                    lbl_tdnthem_chk.Text = ex.Message;
                }
                if (ex.Message == ("Tên đăng nhập không được nhỏ hơn 5 và lớn hơn 20 kí tự"))
                {
                    lbl_tdnthem_chk.Visible = true;
                    lbl_tdnthem_chk.ForeColor = Color.Red;
                    lbl_tdnthem_chk.Text = ex.Message;
                }
                else if (ex.Message.Contains("mật khẩu"))
                {
                    lbl_mkthem_chk.Visible = true;
                    lbl_mkthem_chk.ForeColor = Color.Red;
                    lbl_mkthem_chk.Text = ex.Message;
                }
                else if (ex.Message.Contains("Mật khẩu không được nhỏ hơn 5 và lớn hơn 20 kí tự"))
                {
                    lbl_mkthem_chk.Visible = true;
                    lbl_mkthem_chk.ForeColor = Color.Red;
                    lbl_mkthem_chk.Text = ex.Message;
                }
                else if (ex.Message.Contains("Phân quyền"))
                {
                    lbl_pqthem_chk.Visible = true;
                    lbl_pqthem_chk.ForeColor = Color.Red;
                    lbl_pqthem_chk.Text = ex.Message;
                }
                else if (ex.Message.Contains("Mã nhân viên"))
                {
                    lbl_mnsthem_chk.Visible = true;
                    lbl_mnsthem_chk.ForeColor = Color.Red;
                    lbl_mnsthem_chk.Text = ex.Message;
                }
            }
        }

        void loadThongTin()
        {
            var data = dstk.LoadDsTkData();
            dgv_DanhSachNguoiDung.DataSource = data;
            dgv_DanhSachNguoiDung1.DataSource = data;
            dgv_DanhSachNguoiDung2.DataSource = data;

            cbo_phanquen_them.Items.Clear();
            cbo_phanquyen_sua.Items.Clear();

            cbo_phanquen_them.Items.Add("Nhân viên");
            cbo_phanquen_them.Items.Add("Quản lý");
            cbo_phanquyen_sua.Items.Add("Nhân viên");
            cbo_phanquyen_sua.Items.Add("Quản lý");

            dgv_DanhSachNguoiDung.Columns[0].HeaderCell.Value = "Tên đăng nhập";
            dgv_DanhSachNguoiDung.Columns[1].HeaderCell.Value = "Mật khẩu";
            dgv_DanhSachNguoiDung.Columns[3].HeaderCell.Value = "Phân quyền";
            dgv_DanhSachNguoiDung.Columns[2].HeaderCell.Value = "Mã nhân viên";
            dgv_DanhSachNguoiDung1.Columns[0].HeaderCell.Value = "Tên đăng nhập";
            dgv_DanhSachNguoiDung1.Columns[1].HeaderCell.Value = "Mật khẩu";
            dgv_DanhSachNguoiDung1.Columns[3].HeaderCell.Value = "Phân quyền";
            dgv_DanhSachNguoiDung1.Columns[2].HeaderCell.Value = "Mã nhân viên";
            dgv_DanhSachNguoiDung2.Columns[0].HeaderCell.Value = "Tên đăng nhập";
            dgv_DanhSachNguoiDung2.Columns[1].HeaderCell.Value = "Mật khẩu";
            dgv_DanhSachNguoiDung2.Columns[2].HeaderCell.Value = "Mã nhân viên";
            dgv_DanhSachNguoiDung2.Columns[3].HeaderCell.Value = "Phân quyền";
            dgv_DanhSachNguoiDung2.Columns["TenDangNhap"].ReadOnly = true;
            dgv_DanhSachNguoiDung2.Columns["Phanquyen"].ReadOnly = true;
        }

        private void frm_NguoiXai_Load(object sender, EventArgs e)
        {
          
            loadThongTin();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                string tenDangNhap = txt_tk_Sua.Text;
                string matKhau = txt_mk_Sua.Text;
                string manhansu = txt_manhansu_sua.Text;
                if (string.IsNullOrWhiteSpace(tenDangNhap))
                {
                    lbl_mksua_Chk.Text = "";
                    lbl_mnssua_chk.Text = "";
                    lbl_pqsua_chk.Text = "";
                    throw new Exception("Lỗi. Chưa nhập tên đăng nhập!");
                }
                else if (!dstk.KiemTraTenDangNhap(tenDangNhap))
                {
                    lbl_mksua_Chk.Text = "";
                    lbl_mnssua_chk.Text = "";
                    lbl_pqsua_chk.Text = "";
                    throw new Exception("Lỗi. Tên đăng nhập không tồn tại!");
                }
                else if (tenDangNhap.Length < 5 || tenDangNhap.Length > 20)
                {
                    lbl_mksua_Chk.Text = "";
                    lbl_mnssua_chk.Text = "";
                    lbl_pqsua_chk.Text = "";
                    throw new Exception("Tên đăng nhập không được nhỏ hơn 5 và lớn hơn 20 kí tự");
                }
                else if (string.IsNullOrWhiteSpace(matKhau))
                {
                    lbl_tksua_chk.Text = "";
                    lbl_mnssua_chk.Text = "";
                    lbl_pqsua_chk.Text = "";
                    throw new Exception("Lỗi. Chưa nhập mật khẩu!");
                }
                else if (matKhau.Length < 5 || matKhau.Length > 20)
                {
                    lbl_tksua_chk.Text = "";
                    lbl_mnssua_chk.Text = "";
                    lbl_pqsua_chk.Text = "";
                    throw new Exception("Mật khẩu không được nhỏ hơn 5 và lớn hơn 20 kí tự");
                }
                else if (string.IsNullOrWhiteSpace(manhansu))
                {
                    lbl_mksua_Chk.Text = "";
                    lbl_tksua_chk.Text = "";
                    lbl_pqsua_chk.Text = "";

                    throw new Exception("Lỗi. Bạn chưa nhập Mã nhân viên");
                }
                else if (!dstk.KiemTraMaNhanSu(manhansu))
                {
                    lbl_tksua_chk.Text = "";
                    lbl_pqsua_chk.Text = "";
                    lbl_mksua_Chk.Text = "";
                    throw new Exception("Lỗi. Mã nhân viên không hợp lệ!");
                }
                if (cbo_phanquyen_sua.SelectedItem == null)
                {
                    lbl_mksua_Chk.Text = "";
                    lbl_tksua_chk.Text = "";
                    lbl_mnssua_chk.Text = "";
                    throw new Exception("Lỗi. Bạn chưa chọn Phân quyền");
                }
                else
                {
                    lbl_mksua_Chk.Text = "";
                    lbl_tksua_chk.Text = "";
                    lbl_mnssua_chk.Text = "";
                    string phanQuyen = cbo_phanquyen_sua.SelectedItem.ToString();
                    bool ktpq = dstk.KiemTraPhanQuyen(manhansu, phanQuyen);
                    if (!ktpq)
                    {
                        throw new Exception("Lỗi. Phân quyền không hợp lệ. Thử kiểm tra lại ở phần nhân viên");
                    }
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show("Bạn hãy xác nhận chắc chắn bạn muốn sửa hay không?",
                                                          "Xác nhận sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialogResult == DialogResult.Yes)
                        {
                            lbl_mksua_Chk.Text = "";
                            lbl_tksua_chk.Text = "";
                            lbl_mnssua_chk.Text = "";
                            lbl_pqsua_chk.Text = "";
                            dstk.SuaTaiKhoan(tenDangNhap, matKhau, phanQuyen, manhansu);
                            loadThongTin();

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("đăng nhập"))
                {
                    lbl_tksua_chk.Visible = true;
                    lbl_tksua_chk.ForeColor = Color.Red;
                    lbl_tksua_chk.Text = ex.Message;
                }
                if (ex.Message == ("Tên đăng nhập không được nhỏ hơn 5 và lớn hơn 20 kí tự"))
                {
                    lbl_tksua_chk.Visible = true;
                    lbl_tksua_chk.ForeColor = Color.Red;
                    lbl_tksua_chk.Text = ex.Message;
                }
                else if (ex.Message == ("Mật khẩu không được nhỏ hơn 5 và lớn hơn 20 kí tự"))
                {
                    lbl_mksua_Chk.Visible = true;
                    lbl_mksua_Chk.ForeColor = Color.Red;
                    lbl_mksua_Chk.Text = ex.Message;
                }
                else if (ex.Message == ("Lỗi. Chưa nhập mật khẩu!"))
                {
                    lbl_mksua_Chk.Visible = true;
                    lbl_mksua_Chk.ForeColor = Color.Red;
                    lbl_mksua_Chk.Text = ex.Message;
                }
                else if (ex.Message.Contains("Phân quyền"))
                {
                    lbl_pqsua_chk.Visible = true;
                    lbl_pqsua_chk.ForeColor = Color.Red;
                    lbl_pqsua_chk.Text = ex.Message;
                }
                else if (ex.Message.Contains("Mã nhân viên"))
                {
                    lbl_mnssua_chk.Visible = true;
                    lbl_mnssua_chk.ForeColor = Color.Red;
                    lbl_mnssua_chk.Text = ex.Message;
                }

            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn hãy xác nhận chắc chắn bạn muốn xóa hay không?",
                                                        "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                string tenDangNhap = txt_tk_Sua.Text;

                dstk.XoaTaiKhoan(tenDangNhap);
                loadThongTin();

            }
        }

        private void dgv_DanhSachNguoiDung2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
                if (e.ColumnIndex == dgv_DanhSachNguoiDung.Columns["MaNhanVien"].Index)
            {
                string maNhanSu = dgv_DanhSachNguoiDung.Rows[e.RowIndex].Cells["MaNhanVien"].Value.ToString();

                BLL_QuanLyTaiKhoan bus = new BLL_QuanLyTaiKhoan();


                if (bus.KiemTraMaNhanSu(maNhanSu))
                {
                    string phanQuyen = bus.LayPhanQuyen(maNhanSu);

                    dgv_DanhSachNguoiDung.Rows[e.RowIndex].Cells["PhanQuyen"].Value = phanQuyen;
                }

            }
        }

        private void dgv_DanhSachNguoiDung2_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txt_tk_Sua.Enabled = false;

            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < dgv_DanhSachNguoiDung2.Rows.Count)
                {
                    DataGridViewRow selectedRow = dgv_DanhSachNguoiDung2.Rows[e.RowIndex];

                    // Kiểm tra null và giá trị của các ô trước khi truy xuất dữ liệu
                    var cellTenDangNhap = selectedRow.Cells["TenDangNhap"];
                    var cellMatkhau = selectedRow.Cells["Matkhau"];
                    var cellManhansu = selectedRow.Cells["Manhanvien"];
                    var cellPhanquyen = selectedRow.Cells["Phanquyen"];

                    if (cellTenDangNhap != null && cellTenDangNhap.Value != null &&
                        cellMatkhau != null && cellMatkhau.Value != null &&
                        cellManhansu != null && cellManhansu.Value != null &&
                        cellPhanquyen != null && cellPhanquyen.Value != null)
                    {
                        string tdn = cellTenDangNhap.Value.ToString();
                        string mk = cellMatkhau.Value.ToString();
                        string mns = cellManhansu.Value.ToString();
                        string pq = cellPhanquyen.Value.ToString();

                        txt_tk_Sua.Text = tdn;
                        txt_mk_Sua.Text = mk;
                        cbo_phanquyen_sua.SelectedItem = pq;
                        txt_manhansu_sua.Text = mns;
                    }
                    else
                    {
                        MessageBox.Show("Có ô chứa giá trị null.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            foreach (DataGridViewColumn column in dgv_DanhSachNguoiDung2.Columns)
            {
                Console.WriteLine(column.Name);
            }
        }

    }
}
