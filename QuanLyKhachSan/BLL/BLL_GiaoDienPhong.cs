using QuanLyKhachSan.DA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.BLL
{
    public class BLL_GiaoDienPhong
    {
        DA_GiaoDienPhong da;

        public BLL_GiaoDienPhong()
        {
            da = new DA_GiaoDienPhong();
        }

        public Phong layTrangThai(string maPhong)
        {
            return da.LayTrangThai(maPhong);
        }

        public ThuePhong layThongTin(string maPhong)
        {
            return da.LayThongTinThuePhong(maPhong);
        }
    }
}
