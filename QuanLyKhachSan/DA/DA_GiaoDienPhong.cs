using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DA
{
    public class DA_GiaoDienPhong
    {
        QuanLyKhachSan2Entities db;
        public DA_GiaoDienPhong()
        {
            db = new QuanLyKhachSan2Entities();
        }

        public Phong LayTrangThai(string maphong)
        {
            return db.Phongs.FirstOrDefault(s => s.MaPhong == maphong);
        }

        public ThuePhong LayThongTinThuePhong(string maPhong)
        {
            return db.ThuePhongs.FirstOrDefault(tp => tp.MaPhong == maPhong);
        }
    }
}
