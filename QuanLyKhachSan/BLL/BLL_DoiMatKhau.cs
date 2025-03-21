﻿using QuanLyKhachSan.DA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.BLL
{
    public class BLL_DoiMatKhau
    {
        DA_DoiMatKhau da;
        public BLL_DoiMatKhau()
        {
            da = new DA_DoiMatKhau();
        }
        public TaiKhoan Laymk(string tk)
        {
            return da.LayMatKhau(tk);
        }
        public bool DoiMatKhau(string tk, string mk, string mkmoi)
        {
            bool kt = da.DoiMatKhau(tk, mk, mkmoi);
            if (kt)
            {
                MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Sai mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return kt;
        }
    }
}
