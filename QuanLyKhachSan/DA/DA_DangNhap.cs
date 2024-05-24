using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.DA
{
    public class DA_DangNhap
    {
        QuanLyKhachSan2Entities db;
        public DA_DangNhap()
        {
            db = new QuanLyKhachSan2Entities();
        }
        public bool DangNhap(string tk, string mk)
        {

            bool frag = false;
            var qr = db.TaiKhoans.Where(s => s.TenDangNhap == tk && s.MatKhau == mk);
            if (qr.Count() > 0)
            {
                frag = true;
            }
            else
            {
                frag = false;
            }
            return frag;
        }
        public void da_LuuThongTinDangNhap(string username, string password)
        {
            if (DangNhap(username, password))
            {
                var luuMatKhau = new LuuMatKhau
                {
                    TaiKhoan = username,
                    MatKhau = password
                };

                db.LuuMatKhaus.Add(luuMatKhau);
                db.SaveChanges();
            }
        }

        public LuuMatKhau da_LayThongTinDaLuu()
        {
            var luuthongtin = db.LuuMatKhaus.FirstOrDefault();

            return luuthongtin;
        }
        public void da_CapNhapThongTin(string username, string password)
        {
            if (DangNhap(username, password))
            {
                var luuthongtin = db.LuuMatKhaus.FirstOrDefault();

                if (luuthongtin != null)
                {
                    db.LuuMatKhaus.Remove(luuthongtin);
                }

                var luuthongtinmoi = new LuuMatKhau
                {
                    TaiKhoan = username,
                    MatKhau = password
                };
                db.LuuMatKhaus.Add(luuthongtinmoi);
                db.SaveChanges();
            }
        }

        public void da_XoaThongTinDaLuu()
        {
            db.Database.ExecuteSqlCommand("DELETE FROM LuuMatKhau");
        }
        public bool kiemtraluumk()
        {
            var qr = db.LuuMatKhaus.Select(s => new { s.TaiKhoan });
            return qr.Any();
        }
        public string KiemTraTinhTrang(string tk)
        {

            var qr = db.TaiKhoans.FirstOrDefault(s => s.TenDangNhap == tk);
            if (qr != null)
            {
                return qr.TinhTrang;
            }
            else
            {
                // Trả về một giá trị mặc định hoặc thông báo lỗi tùy thuộc vào logic của bạn
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác","Lỗi",MessageBoxButtons.OK, MessageBoxIcon.Error);    
                return "Tài khoản không tồn tại";
            }
        }
        public string LayLyDo(string tk)
        {
            var qr = db.TaiKhoans.FirstOrDefault(s => s.TenDangNhap == tk);
            return qr.LyDo;
        }
    }
}
