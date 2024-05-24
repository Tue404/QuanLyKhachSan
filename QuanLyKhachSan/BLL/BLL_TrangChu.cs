using QuanLyKhachSan.DA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace QuanLyKhachSan.BLL
{
    public class BLL_TrangChu
    {
        DA_TrangChu da;
        public BLL_TrangChu()
        {
            da = new DA_TrangChu();
        }
        public dynamic LayTen(string tk)
        {
            string kq = da.LayTenTk(tk);

            return kq;

        }
        public string LayChucVu(string tk)
        {
            return da.LayChucVu(tk);
        }
    }
}
