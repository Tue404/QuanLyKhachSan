using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DA
{
    public class DA_TrangChu
    {
        QuanLyKhachSan2Entities db;
        public DA_TrangChu()
        {
            db = new QuanLyKhachSan2Entities();
        }
        public string LayTenTk(string tk)
        {
            var qr = db.TaiKhoans.FirstOrDefault(x => x.TenDangNhap == tk);
            var qrnhasu = db.NhanViens.FirstOrDefault(y => y.MaNhanVien == qr.MaNhanVien);
            return qrnhasu.TenNhanVien;
        }
        public string LayChucVu(string tk)
        {
            var qr = db.TaiKhoans.FirstOrDefault(x => x.TenDangNhap == tk);
            var qrnhasu = db.NhanViens.FirstOrDefault(y => y.MaNhanVien == qr.MaNhanVien);
            return qrnhasu.ChucVu;
        }
    }
}
