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
    public partial class frm_QuanLyVatTu : Form
    {
        BLL_VatTu bll;
        public frm_QuanLyVatTu()
        {
            InitializeComponent();
            bll = new BLL_VatTu();
        }


        private void frm_QuanLyVatTu_Load(object sender, EventArgs e)
        {
            bll.LoadNhanSu(cbo_NguoiQuanLy);
            bll.LoadDsTk(dgv_DanhSachVatTu);
            bll.LoadDsTk(dgv_DanhSachVatTu1);
            bll.LoadDsTk(dgv_DanhSachVatTu2);
            dgv_DanhSachVatTu1.Enabled = false;
            bll.LoadNhanSu(cbo_NguoiQuanLy1);
            bll.LoadNhanSu(cbo_NguoiQuanLy2);
            bll.LoadVatTu(cbo_MaVatTu1);

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string maVatTu = txt_MaVatTu.Text;
            string tenVatTu = txt_TenVatTu.Text;
            string nhaCungCap = txt_NhaCungCap.Text;
            string nguoiQuanLy = cbo_NguoiQuanLy.SelectedValue.ToString();
            string ghiChu = txt_GhiChu.Text;

            if (string.IsNullOrEmpty(maVatTu) || string.IsNullOrEmpty(tenVatTu) || string.IsNullOrEmpty(nhaCungCap) || string.IsNullOrEmpty(nguoiQuanLy))
            {
                MessageBox.Show("Error: Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                bll.ThemVatTu(maVatTu, tenVatTu, nhaCungCap, nguoiQuanLy, ghiChu);
                frm_QuanLyVatTu_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btn_sua_Click(object sender, EventArgs e)
        {
            txt_MaVatTu2.Enabled = false;
            string maVatTu = txt_MaVatTu2.Text;
            string tenVatTu = txt_TenVatTu2.Text;
            string nhaCungCap = txt_NhaCungCap2.Text;
            string nguoiQuanLy = cbo_NguoiQuanLy2.Text;
            string ghiChu = txt_GhiChu.Text;


            if (string.IsNullOrEmpty(maVatTu) || string.IsNullOrEmpty(tenVatTu) || string.IsNullOrEmpty(nhaCungCap) || string.IsNullOrEmpty(nguoiQuanLy))
            {
                MessageBox.Show("Error: Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            try
            {
                bll.SuaVatTu(maVatTu, tenVatTu, nhaCungCap, nguoiQuanLy, ghiChu);
                frm_QuanLyVatTu_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            txt_MaVatTu2.Enabled = false;

            string maVatTu = txt_MaVatTu2.Text;
            if (string.IsNullOrEmpty(maVatTu))
            {
                MessageBox.Show("Error: Vui lòng nhập mã vật tư.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            try
            {
                bll.XoaVatTu(maVatTu);
                frm_QuanLyVatTu_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbo_MaVatTu1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maVatTu = cbo_MaVatTu1.Text;
            dgv_DanhSachVatTu1.DataSource = bll.TimVatTuTheoMa(maVatTu);
        }

        private void txt_TenVatTu1_TextChanged(object sender, EventArgs e)
        {

            string tenVatTu = txt_TenVatTu1.Text;
            dgv_DanhSachVatTu1.DataSource = bll.TimVatTuTheoTen(tenVatTu);
        }

        private void cbo_NguoiQuanLy1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nguoiQuanLy = cbo_NguoiQuanLy1.SelectedValue.ToString();
            dgv_DanhSachVatTu1.DataSource = bll.TimVatTuTheoNguoiQuanLy(nguoiQuanLy);
        }

        private void dgv_DanhSachVatTu2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string mavattu = dgv_DanhSachVatTu2.Rows[e.RowIndex].Cells[0].Value.ToString();
            string tenvattu = dgv_DanhSachVatTu2.Rows[e.RowIndex].Cells[1].Value.ToString();
            string nhacungcap = dgv_DanhSachVatTu2.Rows[e.RowIndex].Cells[2].Value.ToString();
            string nguoiquanly = dgv_DanhSachVatTu2.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_MaVatTu2.Text = mavattu;
            txt_TenVatTu2.Text = tenvattu;
            txt_NhaCungCap2.Text = nhacungcap;
            cbo_NguoiQuanLy2.Text = nguoiquanly;
        }
    }
}
