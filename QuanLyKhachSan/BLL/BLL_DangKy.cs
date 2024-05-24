using QuanLyKhachSan.DA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.BLL
{
    public class BLL_DangKy
    {
        DA_DangKy da;
        public BLL_DangKy()
        {
            da = new DA_DangKy();
        }
        public NhanVien KiemTraTTNS(string cccd)
        {
            return da.KiemTraThongTinNhanVien(cccd);
        }
        public void ThemTK(string tk, string mk, string kq, string mns)
        {
            da.themaccount(tk, mk, kq, mns);
        }
        public bool kiemTraTk(string tk)
        {
            return da.KiemTraTaiKhoan(tk);
        }
    }
}
