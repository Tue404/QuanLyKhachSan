﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DA
{
    public class DA_XacThucTaiKhoan
    {
        QuanLyKhachSan2Entities db;
        public DA_XacThucTaiKhoan()
        {
            db = new QuanLyKhachSan2Entities();
        }
        public dynamic LayTaiKhoanCoTinhTrangDangXuLy()
        {
            var qr = db.TaiKhoans.Select(s => new
            {
                s.TenDangNhap,
                s.MatKhau,
                s.TinhTrang,
                s.LyDo
            }).Where(a => a.TinhTrang == "DangXuLy" || a.TinhTrang == "That bai").ToList();
            return qr;
        }
        public dynamic LayTaiKhoanCoTinhTrangThanhCong()
        {
            var qr = db.TaiKhoans.Select(s => new
            {
                s.TenDangNhap,
                s.MatKhau,
                s.TinhTrang,
            }).Where(a => a.TinhTrang == "Thanh Cong").ToList();
            return qr;
        }
        public void CapNhatTinhTrangTaiKhoan(string tenDangNhap, string tinhTrang)
        {
            TaiKhoan taiKhoan = db.TaiKhoans.FirstOrDefault(tk => tk.TenDangNhap == tenDangNhap);
            if (taiKhoan != null)
            {
                taiKhoan.TinhTrang = tinhTrang;
                db.SaveChanges();
            }
        }
        public void CapNhatTinhTrangVaLyDoTaiKhoan(string tenDangNhap, string tinhTrang, string lyDo)
        {
            TaiKhoan taiKhoan = db.TaiKhoans.FirstOrDefault(tk => tk.TenDangNhap == tenDangNhap);
            if (taiKhoan != null)
            {
                taiKhoan.TinhTrang = tinhTrang;
                taiKhoan.LyDo = lyDo;
                db.SaveChanges();
            }
        }
    }
}
