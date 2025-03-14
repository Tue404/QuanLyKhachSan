﻿using QuanLyKhachSan.BLL;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class frm_XacThucTaiKhoan : Form
    {
        BLL_XacThucTaiKhoan bll;
        public frm_XacThucTaiKhoan()
        {
            InitializeComponent();
            bll = new BLL_XacThucTaiKhoan();
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            if (daChonDong)
            {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn hủy tài khoản này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string lyDo = "";
                    string reason = Microsoft.VisualBasic.Interaction.InputBox("Lý do", "Nhập lý do", lyDo);

                    if (reason != null)
                    {
                        if (!string.IsNullOrEmpty(reason))
                        {
                            string taiKhoan = dgv_tkChuaXacThuc.Rows[viTri].Cells[0].Value.ToString();
                            if (taiKhoan != null)
                            {
                                bll.CapNhatTinhTrangVaLyDoTaiKhoan(taiKhoan, "That bai", reason);
                                loadDuLieu();
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn giá trị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void loadDuLieu()
        {
            bll.LayTaiKhoanChuaXuLy(dgv_tkChuaXacThuc);
            bll.LayTaiKhoanThanhCong(dgv_TaiKhoanDaDuocXacThuc);

        }

        private void frm_XacThucTaiKhoan_Load(object sender, EventArgs e)
        {
            loadDuLieu();
        }

        private void btn_DongY_Click(object sender, EventArgs e)
        {
            if (daChonDong)
            {
                string taiKhoan = dgv_tkChuaXacThuc.Rows[viTri].Cells[0].Value.ToString();
                if (taiKhoan != null)
                {
                    bll.CapNhatTinhTrangTaiKhoan(taiKhoan, "Thanh Cong");


                    loadDuLieu();

                }

            }
            else
            {
                MessageBox.Show("Bạn chưa chọn giá trị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        int viTri;
        bool daChonDong = false;
        private void dgv_tkChuaXacThuc_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgv_TaiKhoanDaDuocXacThuc.ClearSelection();
            dgv_tkChuaXacThuc.ClearSelection();
        }

        private void dgv_tkChuaXacThuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            viTri = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                daChonDong = true;
            }
        }

        private void dgv_tkChuaXacThuc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                viTri = e.RowIndex;
                string tinhTrang = dgv_tkChuaXacThuc.Rows[viTri].Cells["TinhTrang"].Value.ToString();
                if (tinhTrang == "That bai")
                {
                    btn_Huy.BackColor = Color.Gray;
                    btn_Huy.Enabled = false;
                }
                else
                {
                    btn_Huy.BackColor = Color.Red;

                    btn_Huy.Enabled = true;
                }
            }
        }
    }



}
