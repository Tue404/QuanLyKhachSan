﻿using QuanLyKhachSan.DA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.BLL
{

    public class BLL_TraPhong
    {
        DA_TraPhong da;
        public BLL_TraPhong()
        {
            da = new DA_TraPhong();
        }
        public ThuePhong layttDatphong(string maphong)
        {
            return da.layphong(maphong);
        }
        public double layTongTienDichVu(string maphong)
        {
            return da.layTongTienDichVu(maphong);
        }
        public void LuuThongTinThanhToan(HoaDon hoaDon)
        {
            // Lưu thông tin thanh toán vào CSDL
            da.LuuThongTinThanhToan(hoaDon);
        }
        public string laycccd(string makhachhang)
        {
            return da.layCCCD(makhachhang);

        }
        public string LaySDT(string makhachhang)
        {
            return da.laySDT(makhachhang);

        }
        public void XoaDichVuDaDangKyCuaPhong(string maPhong)
        {
            da.XoaDichVuDaDangKyCuaPhong(maPhong);
        }
        public void XoaThuePhong(string maPhong)
        {
            da.XoaThuePhong(maPhong);
        }
    }
}
