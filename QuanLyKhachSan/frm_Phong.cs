using QuanLyKhachSan.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class frm_Phong : Form
    {
        BLL_Phong dsp;
        public frm_Phong()
        {
            InitializeComponent();
            LoadTheme();

            dsp = new BLL_Phong();
            cbo_LoaiPhongSua.Items.Add("Phòng đơn");
            cbo_LoaiPhongSua.Items.Add("Phòng đôi");
            cbo_LoaiPhongSua.Items.Add("Phòng ba");
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
            label6.ForeColor = ThemeColor.SecondaryColor;
            label7.ForeColor = ThemeColor.PrimaryColor;
            label8.ForeColor = ThemeColor.SecondaryColor;
            label9.ForeColor = ThemeColor.PrimaryColor;

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

        private void txt_TimPhong_TextChanged(object sender, EventArgs e)
        {
            txt_TimLoaiPhong.Text = string.Empty;
            txt_TimTinhTrang.Text = string.Empty;

            string timphong = txt_TimPhong.Text;
            var kq = dsp.timPhongBangMaPhong(timphong);
            dgv_phong2.DataSource = kq;
        }

        private void txt_TimLoaiPhong_TextChanged(object sender, EventArgs e)
        {
            txt_TimPhong.Text = string.Empty;
            txt_TimTinhTrang.Text = string.Empty;

            string loaiPhong = txt_TimLoaiPhong.Text;
            var kq = dsp.TimPhongBangLoaiPhong(loaiPhong);
            dgv_phong2.DataSource = kq;
        }

        private void txt_TimTinhTrang_TextChanged(object sender, EventArgs e)
        {
            txt_TimPhong.Text = string.Empty;
            txt_TimLoaiPhong.Text = string.Empty;

            string timtinhtrang = txt_TimTinhTrang.Text;
            var kq = dsp.timphongbangmatinhtrang(timtinhtrang);
            dgv_phong2.DataSource = kq;
        }

        private void frm_Phong_Load(object sender, EventArgs e)
        {
            dsp.LoadDsTk(dgv_phong2);
            dsp.LoadDsTk(dgv_phong3);

            txt_TimPhong.TextChanged += txt_TimPhong_TextChanged;
            txt_TimLoaiPhong.TextChanged += txt_TimLoaiPhong_TextChanged;
            txt_TimTinhTrang.TextChanged += txt_TimTinhTrang_TextChanged;

            dgv_phong2.Columns["MaPhong"].HeaderText = "Mã phòng";
            dgv_phong2.Columns["LoaiPhong"].HeaderText = "Loại phòng";
            dgv_phong2.Columns["TinhTrang"].HeaderText = "Tình trạng";
            dgv_phong2.Columns["DonGia"].HeaderText = "Đơn giá";

            dgv_phong3.Columns["MaPhong"].HeaderText = "Mã phòng";
            dgv_phong3.Columns["LoaiPhong"].HeaderText = "Loại phòng";
            dgv_phong3.Columns["TinhTrang"].HeaderText = "Tình trạng";
            dgv_phong3.Columns["DonGia"].HeaderText = "Đơn giá";
        }
     

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dgv_phong3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string id = dgv_phong2.Rows[e.RowIndex].Cells["MaPhong"].Value.ToString();
                var taiKhoan = dsp.LayPhong(id);
                lbl_KQPhong.Text = taiKhoan.MaPhong;
                cbo_LoaiPhongSua.Text = taiKhoan.LoaiPhong;
                lbl_KQTinhTrang.Text = taiKhoan.TinhTrang;
                txt_DonGiaSua.Text = taiKhoan.DonGia.ToString();
            }
        }

        private void btn_Sua_Click_1(object sender, EventArgs e)
        {
            try
            {
                string maPhong = lbl_KQPhong.Text;
                string tinhTrang = lbl_KQTinhTrang.Text;

                // Kiểm tra nếu lbl_KQPhong rỗng, yêu cầu chọn phòng từ dgv_phong3
                if (string.IsNullOrEmpty(maPhong))
                {
                    if (dgv_phong3.SelectedRows.Count == 1)
                    {
                        DataGridViewRow selectedRow = dgv_phong3.SelectedRows[0];
                        maPhong = selectedRow.Cells["MaPhongColumnName"].Value.ToString();
                        lbl_KQPhong.Text = maPhong;
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn một phòng từ danh sách phòng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Kiểm tra ComboBox loại phòng đã chọn hay chưa
                string loaiPhong = cbo_LoaiPhongSua.Text;
                if (string.IsNullOrEmpty(loaiPhong))
                {
                    MessageBox.Show("Vui lòng chọn loại phòng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Kiểm tra và chuyển đổi giá trị từ txt_dongia_sua thành số thực (float)
                if (!float.TryParse(txt_DonGiaSua.Text, out float donGia) || donGia < 0)
                {
                    MessageBox.Show("Đơn giá không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Dừng xử lý nếu đơn giá không hợp lệ
                }

                // Xác nhận trước khi thực hiện sửa
                DialogResult result = MessageBox.Show("Bạn có muốn sửa thông tin phòng " + maPhong + " không?", "Xác nhận sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Tiến hành cập nhật thông tin phòng
                    BLL_Phong busPhong = new BLL_Phong();
                    busPhong.SuaPhong(maPhong, loaiPhong, tinhTrang, donGia);

                    MessageBox.Show("Sửa thông tin phòng " + maPhong + " thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Cập nhật danh sách phòng trên DataGridViews
                    dsp.LoadDsTk(dgv_phong2);
                    dsp.LoadDsTk(dgv_phong3);

                    // Xóa các thông tin sau khi sửa xong
                    lbl_KQPhong.Text = string.Empty;
                    cbo_LoaiPhongSua.Text = string.Empty;
                    lbl_KQTinhTrang.Text = string.Empty;
                    txt_DonGiaSua.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
