﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.DA
{
    public class DA_TraPhong
    {
        QuanLyKhachSan2Entities db;
        public DA_TraPhong()
        {
            db = new QuanLyKhachSan2Entities();
        }
        public ThuePhong layphong(string maphong)
        {
            return db.ThuePhongs.FirstOrDefault(s => s.MaPhong == maphong);
        }
        public double layTongTienDichVu(string maphong)
        {
            var dichVu = db.DangKyDichVus.Where(s => s.MaPhong == maphong);
            double tongTienDichVu = 0;
            foreach (var dv in dichVu)
            {
                tongTienDichVu += (double)(dv.SoLuong * dv.DonGia);
            }
            return tongTienDichVu;
        }
        public void LuuThongTinThanhToan(HoaDon hoaDon)
        {
            db.HoaDons.Add(hoaDon);
            db.SaveChanges();
        }
        public string layCCCD(string makhachhang)
        {
            var cccd = db.ThongTinKhachHangs.FirstOrDefault(x => x.MaKhachHang == makhachhang).CCCD;
            return cccd;
        }

        public string laySDT(string makhachhang)
        {
            var sdt = db.ThongTinKhachHangs.FirstOrDefault(x => x.MaKhachHang == makhachhang).SoDienThoai;
            return sdt;
        }
        public void XoaDichVuDaDangKyCuaPhong(string maPhong)
        {
            var danhSachDangKyDichVu = db.DangKyDichVus.Where(dk => dk.MaPhong == maPhong).ToList();

            foreach (var dangKyDichVu in danhSachDangKyDichVu)
            {
                db.DangKyDichVus.Remove(dangKyDichVu);
            }

            db.SaveChanges();
        }
        public void XoaThuePhong(string maPhong)
        {
            var thuePhong = db.ThuePhongs.FirstOrDefault(tp => tp.MaPhong == maPhong);
            if (thuePhong != null)
            {
                db.ThuePhongs.Remove(thuePhong);
                db.SaveChanges();
            }
        }
    }
}
