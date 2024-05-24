using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;


namespace QuanLyKhachSan.DA
{
    public class DA_NhanVien
    {
        QuanLyKhachSan2Entities db;

        public DA_NhanVien()
        {
            db = new QuanLyKhachSan2Entities();
        }

        public void LayNhanVien(DataGridView dtgv)
        {
            dtgv.Rows.Clear();
            var ds = db.NhanViens.Select(s => new
            {
                s.MaNhanVien,
                s.TenNhanVien,
                s.GioiTinh,
                s.DiaChi,
                s.SoDienThoai,
                s.NgaySinh,
                s.NgayVaoLam,
                s.ChucVu,
                s.CCCD

            }).ToList();
            foreach (var ns in ds)
            {
                DataGridViewColumn column = new DataGridViewTextBoxColumn();

                int ViTri = dtgv.Rows.Add();
                DataGridViewRow row = dtgv.Rows[ViTri];
                row.Cells[0].Value = ns.MaNhanVien;
                row.Cells[1].Value = ns.TenNhanVien;
                row.Cells[2].Value = ns.GioiTinh;
                row.Cells[3].Value = ns.ChucVu;
                row.Cells[4].Value = ns.NgaySinh.Value.ToShortDateString();
                row.Cells[5].Value = ns.NgayVaoLam.Value.ToShortDateString();
                row.Cells[6].Value = ns.DiaChi;
                row.Cells[7].Value = ns.SoDienThoai;
                row.Cells[8].Value = ns.CCCD;

            }
        }


        public void ThemNhanVien(string mans, string tenvn, string gioitinh, string diachi, string sdt, DateTime ngaysinh, DateTime ngayvaolam, string chucvu, string cccd)
        {
            using (MemoryStream steam = new MemoryStream())
            {
                var nhansu = new NhanVien
                {
                    MaNhanVien = mans,
                    TenNhanVien = tenvn,
                    GioiTinh = gioitinh,
                    DiaChi = diachi,
                    SoDienThoai = sdt,
                    NgaySinh = ngaysinh,
                    NgayVaoLam = ngayvaolam,
                    ChucVu = chucvu,
                    CCCD = cccd

                };
                db.NhanViens.Add(nhansu);
                db.SaveChanges();
            }
        }

        public void SuaNhanVien(string mans, string tenvn, string gioitinh, string diachi, string sdt, DateTime ngaysinh, DateTime ngayvaolam, string chucvu, string cccd)
        {
            var nhanSu = db.NhanViens.FirstOrDefault(ns => ns.MaNhanVien == mans);
            if (nhanSu != null)
            {
                nhanSu.TenNhanVien = tenvn;
                nhanSu.GioiTinh = gioitinh;
                nhanSu.DiaChi = diachi;
                nhanSu.SoDienThoai = sdt;
                nhanSu.NgaySinh = ngaysinh;
                nhanSu.NgayVaoLam = ngayvaolam;
                nhanSu.ChucVu = chucvu;
                nhanSu.CCCD = cccd;
                db.SaveChanges();
            }
        }

        public void XoaNhanVien(string mans)
        {
            var nhansu = db.NhanViens.FirstOrDefault(ns => ns.MaNhanVien == mans);
            if (nhansu != null)
            {
                db.NhanViens.Remove(nhansu);
                db.SaveChanges();
            }
        }

        public void TimTheoTenNhanVien(string hoten, DataGridView dtgv)
        {
            var ds = db.NhanViens.Where(ns => ns.TenNhanVien.Contains(hoten)).ToList();
            dtgv.Rows.Clear();
            foreach (var ns in ds)
            {
                DataGridViewColumn column = new DataGridViewTextBoxColumn();

                int ViTri = dtgv.Rows.Add();
                DataGridViewRow row = dtgv.Rows[ViTri];
                row.Cells[0].Value = ns.MaNhanVien;
                row.Cells[1].Value = ns.TenNhanVien;
                row.Cells[2].Value = ns.GioiTinh;
                row.Cells[3].Value = ns.ChucVu;
                row.Cells[4].Value = ns.NgaySinh.Value.ToShortDateString();
                row.Cells[5].Value = ns.NgayVaoLam.Value.ToShortDateString();
                row.Cells[6].Value = ns.DiaChi;
                row.Cells[7].Value = ns.SoDienThoai;
                row.Cells[8].Value = ns.CCCD;

            }

        }
        public void TimTheoChucVuNhanVien(string chucvu, DataGridView dtgv)
        {
            var ds = db.NhanViens.Where(ns => ns.ChucVu.Contains(chucvu)).ToList();
            dtgv.Rows.Clear();
            foreach (var ns in ds)
            {
                DataGridViewColumn column = new DataGridViewTextBoxColumn();

                int ViTri = dtgv.Rows.Add();
                DataGridViewRow row = dtgv.Rows[ViTri];
                row.Cells[0].Value = ns.MaNhanVien;
                row.Cells[1].Value = ns.TenNhanVien;
                row.Cells[2].Value = ns.GioiTinh;
                row.Cells[3].Value = ns.ChucVu;
                row.Cells[4].Value = ns.NgaySinh.Value.ToShortDateString();
                row.Cells[5].Value = ns.NgayVaoLam.Value.ToShortDateString();
                row.Cells[6].Value = ns.DiaChi;
                row.Cells[7].Value = ns.SoDienThoai;
                row.Cells[8].Value = ns.CCCD;

            }
        }

        public void TimTheoGioiTinhNhanVien(string gioitinh, DataGridView dtgv)
        {
            var ds = db.NhanViens.Where(ns => ns.GioiTinh == gioitinh).ToList();
            dtgv.Rows.Clear();
            foreach (var ns in ds)
            {
                DataGridViewColumn column = new DataGridViewTextBoxColumn();

                int ViTri = dtgv.Rows.Add();
                DataGridViewRow row = dtgv.Rows[ViTri];
                row.Cells[0].Value = ns.MaNhanVien;
                row.Cells[1].Value = ns.TenNhanVien;
                row.Cells[2].Value = ns.GioiTinh;
                row.Cells[3].Value = ns.ChucVu;
                row.Cells[4].Value = ns.NgaySinh.Value.ToShortDateString();
                row.Cells[5].Value = ns.NgayVaoLam.Value.ToShortDateString();
                row.Cells[6].Value = ns.DiaChi;
                row.Cells[7].Value = ns.SoDienThoai;
                row.Cells[8].Value = ns.CCCD;

            }
        }

        public void TimTheosdtNhanVien(string sdt, DataGridView dtgv)
        {
            var ds = db.NhanViens.Where(ns => ns.SoDienThoai.Contains(sdt)).ToList();
            dtgv.Rows.Clear();
            foreach (var ns in ds)
            {
                DataGridViewColumn column = new DataGridViewTextBoxColumn();

                int ViTri = dtgv.Rows.Add();
                DataGridViewRow row = dtgv.Rows[ViTri];
                row.Cells[0].Value = ns.MaNhanVien;
                row.Cells[1].Value = ns.TenNhanVien;
                row.Cells[2].Value = ns.GioiTinh;
                row.Cells[3].Value = ns.ChucVu;
                row.Cells[4].Value = ns.NgaySinh.Value.ToShortDateString();
                row.Cells[5].Value = ns.NgayVaoLam.Value.ToShortDateString();
                row.Cells[6].Value = ns.DiaChi;
                row.Cells[7].Value = ns.SoDienThoai;
                row.Cells[8].Value = ns.CCCD;

            }
        }
        public bool KiemTraKhoa(string manhanvien)
        {
            var nhansu = db.NhanViens.Any(ns => ns.MaNhanVien == manhanvien);
            if (nhansu)
            {
                MessageBox.Show("Trùng mã nhân sự!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public bool checksdt(string sdt)
        {
            var data = db.NhanViens.Any(ns => ns.SoDienThoai == sdt);
            if (data)
            {
                MessageBox.Show("Số điện thoại này đã được sử dụng!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool checkcccd(string cccd)
        {
            var data = db.NhanViens.Any(ns => ns.CCCD == cccd);
            if (data)
            {
                MessageBox.Show("Số căn cước công dân đã được sử dụng", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool dodaicccd(string cccd)
        {
            if (cccd.Length != 12)
            {
                MessageBox.Show("Căn cước công dân không hợp lệ", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool dodaisdt(string cccd)
        {
            if (cccd.Length < 10 || cccd.Length > 11)
            {
                MessageBox.Show("Số điện thoại không hợp lệ", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
