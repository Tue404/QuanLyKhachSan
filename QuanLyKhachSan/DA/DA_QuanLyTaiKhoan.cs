using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyKhachSan.DA
{
    public class DA_QuanLyTaiKhoan
    {
        QuanLyKhachSan2Entities db;
        public DA_QuanLyTaiKhoan()
        {
            db = new QuanLyKhachSan2Entities();
        }

        public dynamic LayDsTk()
        {
            var ds = db.TaiKhoans.Select(s =>
            new
            {

                s.TenDangNhap,
                s.MatKhau,
                s.PhanQuyen,
                s.MaNhanVien
            }
            ).ToList();
            return ds;
        }
        public void ThemTaiKhoan(string tenDangNhap, string matKhau, string phanQuyen, string manhansu)
        {
            var taiKhoan = new TaiKhoan
            {

                TenDangNhap = tenDangNhap,
                MatKhau = matKhau,
                PhanQuyen = phanQuyen,
                MaNhanVien = manhansu

            };
            db.TaiKhoans.Add(taiKhoan);
            db.SaveChanges();
        }
        public void SuaTaiKhoan(string tenDangNhap, string matKhau, string phanQuyen, string manhansu)
        {
            var taiKhoan = db.TaiKhoans.FirstOrDefault(t => t.TenDangNhap == tenDangNhap);
            if (taiKhoan != null)
            {
                taiKhoan.TenDangNhap = tenDangNhap;
                taiKhoan.MatKhau = matKhau;
                taiKhoan.PhanQuyen = phanQuyen;
                taiKhoan.MaNhanVien = manhansu;
                db.SaveChanges();
            }
        }

        public void XoaTaiKhoan(string tendangnhap)
        {
            var taiKhoan = db.TaiKhoans.FirstOrDefault(t => t.TenDangNhap == tendangnhap);
            if (taiKhoan != null)
            {
                db.TaiKhoans.Remove(taiKhoan);
                db.SaveChanges();
            }
        }


        public IList TimTaiKhoan(string timKiem)
        {
            var qr = db.TaiKhoans
                .Where(t => t.TenDangNhap.Contains(timKiem) || t.MaNhanVien.Contains(timKiem) || t.PhanQuyen.Contains(timKiem))
                .Select(t => new
                {
                    TenDangNhap = t.TenDangNhap,
                    MatKhau = t.MatKhau,
                    PhanQuyen = t.PhanQuyen,
                    MaNhanSu = t.MaNhanVien
                })
                .ToList();
            return qr;
        }

        public bool KiemTraPhanQuyen(string MaNhanSu, string PhanQuyen)
        {
            bool kiemTra = false;
            var PQ = db.NhanViens.FirstOrDefault(s => s.MaNhanVien == MaNhanSu);
            if (PhanQuyen == PQ.ChucVu)
            {
                kiemTra = true;

            }
            else
            {
                kiemTra = false;
            }
            return kiemTra;
        }

        public TaiKhoan LayTaiKhoan(string tendangnhap)
        {
            return db.TaiKhoans.FirstOrDefault(t => t.TenDangNhap == tendangnhap);
        }

        public bool KiemTraTenDangNhap(string tenDangNhap)
        {
            var taiKhoan = db.TaiKhoans.FirstOrDefault(t => t.TenDangNhap == tenDangNhap);
            return taiKhoan != null;
        }

        public bool KiemTraMaNhanSu(string maNhanSu)
        {
            var nhanSu = db.NhanViens.FirstOrDefault(n => n.MaNhanVien == maNhanSu);
            return nhanSu != null;
        }

        public DataTable LayDsTkData()
        {
            using (var context = new QuanLyKhachSan2Entities())
            {
                var data = from tk in context.TaiKhoans
                           select new
                           {
                               tk.TenDangNhap,
                               tk.MatKhau,
                               tk.PhanQuyen,
                               tk.MaNhanVien
                           };

                var dataTable = new DataTable();
                dataTable.Columns.Add("TenDangNhap");
                dataTable.Columns.Add("MatKhau");
                dataTable.Columns.Add("MaNhanVien");
                dataTable.Columns.Add("PhanQuyen");


                foreach (var item in data)
                {
                    var row = dataTable.NewRow();
                    row["TenDangNhap"] = item.TenDangNhap;
                    row["MatKhau"] = item.MatKhau;
                    row["MaNhanVien"] = item.MaNhanVien;
                    row["PhanQuyen"] = item.PhanQuyen;

                    dataTable.Rows.Add(row);
                }

                return dataTable;
            }

        }

        public void CapNhatDsTk(DataTable dataTable)
        {
            foreach (DataRow row in dataTable.Rows)
            {
                string tenDangNhap = row["TenDangNhap"].ToString();
                string matKhau = row["MatKhau"].ToString();
                string maNhanSu = row["MaNhanVien"].ToString();

                if (matKhau == "")
                {
                    MessageBox.Show("Bạn chưa nhập mật khẩu cho tài khoản: " + tenDangNhap, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (matKhau.Length < 5 || matKhau.Length > 20)
                {
                    MessageBox.Show("Mật khẩu phải có độ dài từ 5 đến 20 ký tự! Tài khoản: " + tenDangNhap, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (maNhanSu == "")
                {
                    MessageBox.Show("Bạn chưa nhập mã nhân viên cho tài khoản: " + tenDangNhap, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var nhanSu = db.NhanViens.FirstOrDefault(n => n.MaNhanVien == maNhanSu);
                if (nhanSu == null)
                {
                    MessageBox.Show("Mã nhân viên không tồn tại: " + maNhanSu, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string phanQuyen = nhanSu.ChucVu;

                var taiKhoan = db.TaiKhoans.FirstOrDefault(t => t.TenDangNhap == tenDangNhap);
                if (taiKhoan != null)
                {
                    taiKhoan.MatKhau = matKhau;
                    taiKhoan.PhanQuyen = phanQuyen;
                    taiKhoan.MaNhanVien = maNhanSu;
                }
                else
                {
                    taiKhoan = new TaiKhoan
                    {
                        TenDangNhap = tenDangNhap,
                        MatKhau = matKhau,
                        PhanQuyen = phanQuyen,
                        MaNhanVien = maNhanSu
                    };
                    db.TaiKhoans.Add(taiKhoan);
                }
            }

            db.SaveChanges();
            MessageBox.Show("Lưu thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public List<TaiKhoan> LayDsTk_Data()
        {
            return db.TaiKhoans.ToList();
        }

        public void ThemTaiKhoan_Data(TaiKhoan taiKhoan)
        {

            var existingTaiKhoan = db.TaiKhoans.Find(taiKhoan.TenDangNhap);
            if (existingTaiKhoan == null)
            {
                db.TaiKhoans.Add(taiKhoan);
                db.SaveChanges();
            }
            else
            {

            }
        }

        public string LayPhanQuyen(string maNhanSu)
        {
            var nhanSu = db.NhanViens.FirstOrDefault(n => n.MaNhanVien == maNhanSu);
            if (nhanSu == null)
                return null;
            string phanQuyen = nhanSu.ChucVu;
            return phanQuyen;
        }

        public void SaveData(List<TaiKhoan> taiKhoans)
        {
            using (QuanLyKhachSan2Entities db = new QuanLyKhachSan2Entities())
            {
                foreach (TaiKhoan taiKhoan in taiKhoans)
                {
                    TaiKhoan existingTaiKhoan = db.TaiKhoans.Find(taiKhoan.TenDangNhap);
                    if (existingTaiKhoan == null)
                    {
                        db.TaiKhoans.Add(taiKhoan);
                    }
                }
                db.SaveChanges();
            }
        }

        public bool CheckTenDangNhap(string tenDangNhap)
        {
            using (QuanLyKhachSan2Entities db = new QuanLyKhachSan2Entities())
            {
                TaiKhoan existingTaiKhoan = db.TaiKhoans.Find(tenDangNhap);
                if (existingTaiKhoan != null)
                {
                    return true;
                }
            }
            return false;
        }

        public bool CheckMaNhanSu(string maNhanSu)
        {
            using (QuanLyKhachSan2Entities db = new QuanLyKhachSan2Entities())
            {
                NhanVien existingNhanSu = db.NhanViens.Find(maNhanSu);
                if (existingNhanSu == null)
                {
                    return false;
                }
            }
            return true;
        }

    }
}
