using QuanLyKhachSan.DA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.BLL
{
    internal class BLL_HoaDon
    {
        DA_HoaDon da;
        public BLL_HoaDon()
        {
            da = new DA_HoaDon();
        }

        public void loadHD(DataGridView dtgv)
        {
            da.LayHoaDon(dtgv);
        }
    }
}
