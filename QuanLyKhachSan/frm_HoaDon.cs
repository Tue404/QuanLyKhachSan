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
    public partial class frm_HoaDon : Form
    {
        BLL_HoaDon bll;
        public frm_HoaDon()
        {
            InitializeComponent();
            LoadTheme();
            bll = new BLL_HoaDon();
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

        public void hienthi()
        {
            bll.loadHD(dgv_DanhSachHoaDon);
        }

        private void frm_HoaDon_Load(object sender, EventArgs e)
        {
            hienthi();
        }

        private void dgv_DanhSachHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbl_KetQuaMaHD.Text = dgv_DanhSachHoaDon.Rows[e.RowIndex].Cells[0].Value.ToString();
            lbl_KqMaKhachHang.Text = dgv_DanhSachHoaDon.Rows[e.RowIndex].Cells[1].Value.ToString();
            lbl_KqCCCD.Text = dgv_DanhSachHoaDon.Rows[e.RowIndex].Cells[2].Value.ToString();
            lbl_KqSDT.Text = dgv_DanhSachHoaDon.Rows[e.RowIndex].Cells[3].Value.ToString();
            lbl_KqMaPhong.Text = dgv_DanhSachHoaDon.Rows[e.RowIndex].Cells[4].Value.ToString();
            lbl_KqNgayThue.Text = dgv_DanhSachHoaDon.Rows[e.RowIndex].Cells[5].Value.ToString();
            lbl_KqNgayTra.Text = dgv_DanhSachHoaDon.Rows[e.RowIndex].Cells[6].Value.ToString();
            lbl_KqTienDichVu.Text = dgv_DanhSachHoaDon.Rows[e.RowIndex].Cells[7].Value.ToString();
            lbl_thanhtoan.Text = dgv_DanhSachHoaDon.Rows[e.RowIndex].Cells[8].Value.ToString();
        }
    }
}
