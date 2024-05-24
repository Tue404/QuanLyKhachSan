using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DA
{
    public class DA_DoiMatKhau
    {
        QuanLyKhachSan2Entities db;
        public DA_DoiMatKhau()
        {
            db = new QuanLyKhachSan2Entities();
        }
        public TaiKhoan LayMatKhau(string tk)
        {
            return db.TaiKhoans.FirstOrDefault(s => s.TenDangNhap == tk);
        }
        public bool DoiMatKhau(string tk, string mk, string mkmoi)
        {
            bool frag = false;
            var dmk = db.TaiKhoans.FirstOrDefault(t => t.TenDangNhap == tk && t.MatKhau == mk);
            if (dmk != null)
            {
                dmk.MatKhau = mkmoi;
                frag = true;
                db.SaveChanges();
            }
            else
            {
                frag = false;
            }
            return frag;
        }
    }
}
