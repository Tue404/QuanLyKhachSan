using QuanLyKhachSan.DA;
using QuanLyKhachSan.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class frm_DichVu : Form
    {
        BLL_DichVu bll;
        public TabControl TabControl_DichVu
        {
            get { return tabControl_DichVu; }

        }
        public TabPage TabPage_DichVu_
        {
            get { return tabPage_DangKyDichVu; }
        }

        public TabPage TabPage_DichVu_ADM2
        {
            get { return tabPage_ThemDV; }
        }

        public frm_DichVu()
        {
            InitializeComponent();
            bll = new BLL_DichVu();
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

        private void LoadDichVu()
        {
            bll.LoadDichVu(dgv_DanhSachDichVu);
            bll.LoadDichVu(dgv_DanhSachDichVu1);
            bll.LoadDichVu(dgv_DanhSachDichVu2);
            bll.LoadDichVu(dgv_DanhSachDichVu3);

        }

        private void frm_DichVu_Load(object sender, EventArgs e)
        {
            bll.LoadDichVu(dgv_DanhSachDichVu);
            LoadDichVu();
            bll.LoadRentedRoomIDs(cbo_MaPhong);

            listView_DichVuDaDat.Columns.Add("TenDichVu", "Tên dịch vụ", 160);
            listView_DichVuDaDat.Columns.Add("SoLuong", "Số lượng", 100);
            listView_DichVuDaDat.Columns.Add("MaPhong", "Mã phòng", 100);
            bll.hienthongtincbo_b(cbo_MaDichVu);
            loadTenDGV();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string maDichVu = txt_MaDichVu.Text;
            string tenDichVu = txt_TenDichVu.Text;
            float donGia = float.Parse(txt_DonGia.Text);
            string donViTinh = txt_DonViTinh.Text;
            bll.ThemDichVu_b(maDichVu, tenDichVu, donGia, donViTinh);
            LoadDichVu();
            bll.hienthongtincbo_b(cbo_MaDichVu);
        }

        private void txt_TimkiemTenDichVu_TextChanged(object sender, EventArgs e)
        {
            if (txt_TimkiemTenDichVu.Text != "")
            {
                bll.timtendichvu_b(txt_TimkiemTenDichVu.Text, dgv_DanhSachDichVu1);
            }
            else
            {
                bll.LoadDichVu(dgv_DanhSachDichVu1);
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
          
            bll.SuaDichVu_b(txt_MaDichVusua.Text, txt_TenDichVusua.Text, float.Parse(txt_DonGiasua.Text), txt_DonViTinhsua.Text);
            LoadDichVu();
            bll.hienthongtincbo_b(cbo_MaDichVu);
            txt_MaDichVusua.Enabled = true;
        }

        private void btn_Xoa1_Click(object sender, EventArgs e)
        {
            bll.XoaDichVu_b(txt_MaDichVusua.Text);
            LoadDichVu();
            bll.hienthongtincbo_b(cbo_MaDichVu);
        }

        private void dgv_DanhSachDichVu2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string madv = dgv_DanhSachDichVu2.Rows[e.RowIndex].Cells["MaDichVu"].Value.ToString();
                var dv = bll.xuatdichvu(madv);
                txt_MaDichVusua.Text = dv.MaDichVu;
                txt_TenDichVusua.Text = dv.TenDichVu;
                txt_DonGiasua.Text = dv.DonGia.ToString();
                txt_DonViTinhsua.Text = dv.DonViTinh.ToString();
            }
        }

        private void btn_ThemDangKyDV_Click(object sender, EventArgs e)
        {
            try
            {
                bool hasError = false;
                string errorMessage = "";
                int soLuong = 0;

                if (string.IsNullOrWhiteSpace(txt_SoLuong.Text))
                {
                    hasError = true;
                    errorMessage = "Vui lòng nhập số lượng.";
                }
                else if (!int.TryParse(txt_SoLuong.Text, out soLuong) || soLuong <= 0)
                {
                    hasError = true;
                    errorMessage = "Số lượng không hợp lệ. Vui lòng nhập số lượng là một số nguyên dương.";
                }
                else if (cbo_MaPhong.SelectedItem == null)
                {
                    hasError = true;
                    errorMessage = "Vui lòng chọn mã phòng.";
                }
                else if (cbo_MaDichVu.SelectedItem == null)
                {
                    hasError = true;
                    errorMessage = "Vui lòng chọn mã dịch vụ.";
                }

                if (hasError)
                {
                    MessageBox.Show(errorMessage, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string maPhong = cbo_MaPhong.SelectedItem.ToString();
                string maDichVu = cbo_MaDichVu.SelectedValue.ToString();

                bool daTonTai = false;
                foreach (ListViewItem existingItem in listView_DichVuDaDat.Items)
                {
                    if (existingItem.SubItems[0].Text == maDichVu && existingItem.SubItems[2].Text == maPhong)
                    {
                        existingItem.SubItems[1].Text = (int.Parse(existingItem.SubItems[1].Text) + soLuong).ToString();
                        daTonTai = true;
                        break;
                    }
                }

                if (!daTonTai)
                {
                    ListViewItem item = new ListViewItem(new string[] { maDichVu, soLuong.ToString(), maPhong });
                    listView_DichVuDaDat.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_XoaDangKyDV_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView_DichVuDaDat.SelectedItems.Count > 0)
                {
                    var selectedItem = listView_DichVuDaDat.SelectedItems[0];
                    string maDichVu = selectedItem.SubItems[0].Text;
                    string maPhong = selectedItem.SubItems[2].Text;
                    string tenDichVu = GetTenDichVuByMaDichVu(maDichVu);

                    DialogResult dialogResult = MessageBox.Show($"Bạn có muốn xóa dịch vụ '{tenDichVu}' của phòng '{maPhong}' không?",
                                                              "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        listView_DichVuDaDat.Items.Remove(selectedItem);
                        MessageBox.Show("Xóa dịch vụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn dịch vụ cần xóa từ danh sách dịch vụ đã chọn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }       
        }

        private string GetTenDichVuByMaDichVu(string tenDichVu)
        {
            return bll.GetTenDichVuByMaDichVu(tenDichVu);
        }

        private void btn_DangKyDV_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView_DichVuDaDat.Items.Count == 0)
                {
                    MessageBox.Show("Vui lòng thêm dịch vụ vào danh sách dịch vụ trước khi đăng ký!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                foreach (ListViewItem item in listView_DichVuDaDat.Items)
                {
                    string tenDichVu = item.SubItems[0].Text;
                    string maPhong = item.SubItems[2].Text;
                    int soLuong = int.Parse(item.SubItems[1].Text);

                    string maDichVu = bll.GetMaDichVuByTenDichVu(tenDichVu);
                    double donGia = bll.GetDonGiaByMaDichVu(maDichVu);


                    if (bll.CheckDichVuDaTonTai(maDichVu, maPhong))
                    {

                        bll.UpdateDangKyDichVu(maDichVu, maPhong, soLuong);
                    }
                    else
                    {

                        Random random = new Random();
                        string maDangKyDV = "DDV" + random.Next(100, 999).ToString();

                        while (bll.CheckMaDangKyDVTonTai(maDangKyDV))
                        {
                            maDangKyDV = "DDV" + random.Next(100, 999).ToString();
                        }

                        bll.InsertDangKyDichVu(maDangKyDV, maDichVu, maPhong, soLuong, donGia);
                    }

                    frm_ThongTinPhong.Instance.UpdateDichVuDaSuDung(item.Clone() as ListViewItem); // Tạo bản sao của item và thêm vào ListView khác
                }
                MessageBox.Show("Đăng ký dịch vụ thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listView_DichVuDaDat.Items.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetMaDichVuByTenDichVu(string tenDichVu)
        {
            return bll.GetMaDichVuByTenDichVu(tenDichVu);
        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {

            string tenDV = txt_TimKiem.Text;
            var kq = bll.timDV(tenDV);
            dgv_DanhSachDichVu3.DataSource = kq;
        }

        private void dgv_DanhSachDichVu3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string maDichVu = dgv_DanhSachDichVu3.Rows[e.RowIndex].Cells["MaDichVu"].Value.ToString();

                for (int i = 0; i < cbo_MaDichVu.Items.Count; i++)
                {
                    if (cbo_MaDichVu.GetItemText(cbo_MaDichVu.Items[i]) == maDichVu)
                    {
                        cbo_MaDichVu.SelectedIndex = i;
                        break;
                    }
                }
            }
        }

        public void loadTenDGV()
        {
            dgv_DanhSachDichVu.Columns["MaDichVu"].HeaderText = "Mã dịch vụ";
            dgv_DanhSachDichVu.Columns["TenDichVu"].HeaderText = "Tên dịch vụ";
            dgv_DanhSachDichVu.Columns["DonGia"].HeaderText = "Đơn giá";
            dgv_DanhSachDichVu.Columns["DonViTinh"].HeaderText = "Đơn vị tính";

            dgv_DanhSachDichVu1.Columns["MaDichVu"].HeaderText = "Mã dịch vụ";
            dgv_DanhSachDichVu1.Columns["TenDichVu"].HeaderText = "Tên dịch vụ";
            dgv_DanhSachDichVu1.Columns["DonGia"].HeaderText = "Đơn giá";
            dgv_DanhSachDichVu1.Columns["DonViTinh"].HeaderText = "Đơn vị tính";

            dgv_DanhSachDichVu2.Columns["MaDichVu"].HeaderText = "Mã dịch vụ";
            dgv_DanhSachDichVu2.Columns["TenDichVu"].HeaderText = "Tên dịch vụ";
            dgv_DanhSachDichVu2.Columns["DonGia"].HeaderText = "Đơn giá";
            dgv_DanhSachDichVu2.Columns["DonViTinh"].HeaderText = "Đơn vị tính";

            dgv_DanhSachDichVu3.Columns["MaDichVu"].HeaderText = "Mã dịch vụ";
            dgv_DanhSachDichVu3.Columns["TenDichVu"].HeaderText = "Tên dịch vụ";
            dgv_DanhSachDichVu3.Columns["DonGia"].HeaderText = "Đơn giá";
            dgv_DanhSachDichVu3.Columns["DonViTinh"].HeaderText = "Đơn vị tính";
        }


    }
}
