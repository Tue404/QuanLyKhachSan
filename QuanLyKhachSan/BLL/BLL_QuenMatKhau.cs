using QuanLyKhachSan.DA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.BLL
{
    public class BLL_QuenMatKhau
    {
        DA_QuenMatKhau da;
        public BLL_QuenMatKhau()
        {
            da = new DA_QuenMatKhau();
        }
        public bool kiemTraTenDangNhap(string tenDangNhap)
        {
            return da.layTaiKhoan(tenDangNhap) != null;
        }
        public void doiMatKhau(string tenDangNhap, string matKhauMoi)
        {
            da.capNhatMatKhau(tenDangNhap, matKhauMoi);
        }
    }
}
