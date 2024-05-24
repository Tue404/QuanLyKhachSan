using QuanLyKhachSan.DA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.BLL
{
    public class BLL_NhanVien
    {
        DA_NhanVien da_nhanvien;

        public BLL_NhanVien()
        {
            da_nhanvien = new DA_NhanVien();
        }

        public void LoadDsNv(DataGridView dgv)
        {
            da_nhanvien.LayNhanVien(dgv);
        }

        public void ThemNhanVien(string mans, string tenvn, string gioitinh, string diachi, string sdt, DateTime ngaysinh, DateTime ngayvaolam, string chucvu,  string cccd)
        {
            da_nhanvien.ThemNhanVien(mans, tenvn, gioitinh, diachi, sdt, ngaysinh, ngayvaolam, chucvu, cccd);
        }

        public void SuaNhanVien(string mans, string tenvn, string gioitinh, string diachi, string sdt, DateTime ngaysinh, DateTime ngayvaolam, string chucvu, string cccd)
        {
            da_nhanvien.SuaNhanVien(mans, tenvn, gioitinh, diachi, sdt, ngaysinh, ngayvaolam, chucvu, cccd);
        }

        public void XoaNhanVien(string mans)
        {
            da_nhanvien.XoaNhanVien(mans);
        }

        public void TimNhanVienTheoTen(string hoten, DataGridView dtgv)
        {
            da_nhanvien.TimTheoTenNhanVien(hoten, dtgv);
        }

        public void TimNhanSuTheoChucVu(string chucvu, DataGridView dtgv)
        {
            da_nhanvien.TimTheoChucVuNhanVien(chucvu, dtgv);
        }

        public void TimNhanVienTheoGioiTinh(string gioitinh, DataGridView dtgv)
        {
            da_nhanvien.TimTheoGioiTinhNhanVien(gioitinh, dtgv);
        }

        public void TimNhanVienTheosdt(string sdt, DataGridView dtgv)
        {
            da_nhanvien.TimTheosdtNhanVien(sdt, dtgv);
        }

        public bool KiemTraKhoa(string manhansu)
        {
            return da_nhanvien.KiemTraKhoa(manhansu);
        }

        public bool KiemTraSDT(string sdt)
        {
            return da_nhanvien.checksdt(sdt);
        }

        public bool KiemTraCCCD(string cccd)
        {
            return da_nhanvien.checkcccd(cccd);
        }

        public bool dodaiccd(string cccd)
        {
            return da_nhanvien.dodaicccd(cccd);
        }

        public bool dodaisdt(string sdt)
        {
            return da_nhanvien.checkcccd(sdt);
        }

    }
}
