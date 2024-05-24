using QuanLyKhachSan.DA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.BLL
{
    public class BLL_KhachHang
    {
        DA_KhachHang da;
        private DA_KhachHang dataAccess;

        public BLL_KhachHang()
        {
            da = new DA_KhachHang();
            dataAccess = new DA_KhachHang();
        }

        public ThongTinKhachHang GetCustomerByMaKH(string maKhachHang)
        {
            return dataAccess.GetCustomerByMaKH(maKhachHang);
        }
        public void LoadDsKh(DataGridView dgv)
        {
            da.KhachHang(dgv);
        }
        public void ThemKH(string MaKH, string TenKH, string GT, DateTime NS, string DC, string SDT, string cccd)
        {
            da.AddKhachHang(MaKH, TenKH, GT, NS, DC, SDT, cccd);
        }
        public void SuaKH(string MaKH, string TenKH, string GT, DateTime NS, string DC, string SDT, string cccd)
        {
            da.EditKH(MaKH, TenKH, GT, NS, DC, SDT, cccd);
        }
        public void XoaKH(string MaKH)
        {
            da.DeleteKH(MaKH);
        }
        public void TimKHTheoTen(string hoten, DataGridView dgv)
        {
            da.TimTheoTenKh(hoten, dgv);
        }
        public void TimKHTheoGioiTinh(string gioitinh, DataGridView dgv)
        {
            da.TimTheoGioiTinhKH(gioitinh, dgv);
        }
        public void TimTheocccdKH(string cccd, DataGridView dgv)
        {
            da.TimTheocccdKH(cccd, dgv);
        }
        public List<string> laykhachhang()
        {
            return da.laytenkh();
        }
        public bool ktkhoa(string makh)
        {
            return da.CheckMa(makh);
        }
        public bool ktsdt(string sdt)
        {
            return da.CheckSDT(sdt);
        }
        public bool ktcccd(string cccd)
        {
            return da.CheckCCCD(cccd);
        }
        public bool dodaiccd(string cccd)
        {
            return da.DoDaiCCD(cccd);
        }
        public bool dodaisdt(string sdt)
        {
            return da.CheckSDT(sdt);
        }
    }
}
