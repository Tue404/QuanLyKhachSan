using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DA
{
    public class DA_QuenMatKhau
    {
        QuanLyKhachSan2Entities db;
        public DA_QuenMatKhau()
        {
            db = new QuanLyKhachSan2Entities();
        }
        public TaiKhoan layTaiKhoan(string tenDangNhap)
        {
            return db.TaiKhoans.FirstOrDefault(s => s.TenDangNhap == tenDangNhap);
        }
        public void capNhatMatKhau(string tenDangNhap, string matKhauMoi)
        {
            var taiKhoan = layTaiKhoan(tenDangNhap);
            if (taiKhoan != null)
            {
                taiKhoan.MatKhau = matKhauMoi;
                db.SaveChanges();
            }
        }
    }
}
