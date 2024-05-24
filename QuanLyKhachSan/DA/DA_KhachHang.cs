using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.DA
{
    public class DA_KhachHang
    {
        QuanLyKhachSan2Entities db;
        public DA_KhachHang()
        {
            db = new QuanLyKhachSan2Entities();
        }
        public ThongTinKhachHang GetCustomerByMaKH(string maKhachHang)
        {
            return db.ThongTinKhachHangs.FirstOrDefault(c => c.MaKhachHang == maKhachHang);
        }

        public void KhachHang(DataGridView dgv)
        {
            dgv.Columns.Clear();
            dgv.Rows.Clear();

            if (dgv.Columns.Count == 0)
            {
                dgv.Columns.Add("MaKhachHang", "Mã Khách Hàng");
                dgv.Columns.Add("TenKhachHang", "Tên Khách Hàng");
                dgv.Columns.Add("GioiTinh", "Giới Tính");
                dgv.Columns.Add("NgaySinh", "Ngày Sinh");
                dgv.Columns.Add("DiaChi", "Địa Chỉ");
                dgv.Columns.Add("SoDienThoai", "Số Điện Thoại");
                dgv.Columns.Add("CCCD", "CCCD");
            }

            var ds = db.ThongTinKhachHangs.Select(s => new
            {
                s.MaKhachHang,
                s.TenKhachHang,
                s.GioiTinh,
                s.NgaySinh,
                s.DiaChi,
                s.SoDienThoai,
                s.CCCD
            }).ToList();
            foreach (var d in ds)
            {
                DataGridViewColumn column = new DataGridViewColumn();

                int Vitri = dgv.Rows.Add();
                DataGridViewRow row = dgv.Rows[Vitri];
                row.Cells[0].Value = d.MaKhachHang;
                row.Cells[1].Value = d.TenKhachHang;
                row.Cells[2].Value = d.GioiTinh;
                row.Cells[3].Value = d.NgaySinh;
                row.Cells[4].Value = d.DiaChi;
                row.Cells[5].Value = d.SoDienThoai;
                row.Cells[6].Value = d.CCCD;
            }
        }
        public void AddKhachHang(string MaKH, string TenKH, string GT, DateTime NS, string DC, string SDT, string cccd)
        {
            var KH = new ThongTinKhachHang
            {
                MaKhachHang = MaKH,
                TenKhachHang = TenKH,
                GioiTinh = GT,
                NgaySinh = NS,
                DiaChi = DC,
                SoDienThoai = SDT,
                CCCD = cccd,
            };
            db.ThongTinKhachHangs.Add(KH);
            db.SaveChanges();
        }

        public void EditKH(string MaKH, string TenKH, string GT, DateTime NS, string DC, string SDT, string cccd)
        {
            var KH = db.ThongTinKhachHangs.FirstOrDefault(c => c.MaKhachHang == MaKH);
            if (KH != null)
            {
                KH.TenKhachHang = TenKH;
                KH.GioiTinh = GT;
                KH.NgaySinh = NS;
                KH.DiaChi = DC;
                KH.SoDienThoai = SDT;
                KH.CCCD = cccd;

                db.SaveChanges();
            }
        }
        public void DeleteKH(string MaKH)
        {
            var KH = db.ThongTinKhachHangs.FirstOrDefault(c => c.MaKhachHang == MaKH);
            if(KH != null)
            {
                db.ThongTinKhachHangs.Remove(KH);
                db.SaveChanges();
            }
        }
        public List<string> laytenkh()
        {
            var data = db.ThongTinKhachHangs.Select(x => x.TenKhachHang).ToList();
            return data;
        }

        public void TimTheoTenKh(string hoten, DataGridView dgv)
        {
            var ds = db.ThongTinKhachHangs.Where(c => c.TenKhachHang.Contains(hoten)).ToList();
            dgv.Columns.Clear();
            dgv.Rows.Clear();
            if (dgv.Columns.Count == 0)
            {
                dgv.Columns.Add("MaKhachHang", "Mã Khách Hàng");
                dgv.Columns.Add("TenKhachHang", "Tên Khách Hàng");
                dgv.Columns.Add("GioiTinh", "Giới Tính");
                dgv.Columns.Add("NgaySinh", "Ngày Sinh");
                dgv.Columns.Add("DiaChi", "Địa Chỉ");
                dgv.Columns.Add("SoDienThoai", "Số Điện Thoại");
                dgv.Columns.Add("CCCD", "CCCD");
            }
            foreach (var KH in ds)
            {
                DataGridViewColumn column = new DataGridViewTextBoxColumn();

                int ViTri = dgv.Rows.Add();
                DataGridViewRow row = dgv.Rows[ViTri];
                row.Cells[0].Value = KH.MaKhachHang;
                row.Cells[1].Value = KH.TenKhachHang;
                row.Cells[2].Value = KH.GioiTinh;
                row.Cells[3].Value = KH.NgaySinh;
                row.Cells[4].Value = KH.DiaChi;
                row.Cells[5].Value = KH.SoDienThoai;
                row.Cells[6].Value = KH.CCCD;

            }
        }

        public void TimTheoGioiTinhKH(string gioitinh, DataGridView dgv)
        {
            var ds = db.ThongTinKhachHangs.Where(c => c.GioiTinh == gioitinh).ToList();
            dgv.Columns.Clear();
            dgv.Rows.Clear();

            if (dgv.Columns.Count == 0)
            {
                dgv.Columns.Add("MaKhachHang", "Mã Khách Hàng");
                dgv.Columns.Add("TenKhachHang", "Tên Khách Hàng");
                dgv.Columns.Add("GioiTinh", "Giới Tính");
                dgv.Columns.Add("NgaySinh", "Ngày Sinh");
                dgv.Columns.Add("DiaChi", "Địa Chỉ");
                dgv.Columns.Add("SoDienThoai", "Số Điện Thoại");
                dgv.Columns.Add("CCCD", "CCCD");
            }
            foreach (var KH in ds)
            {
                DataGridViewColumn column = new DataGridViewTextBoxColumn();

                int ViTri = dgv.Rows.Add();
                DataGridViewRow row = dgv.Rows[ViTri];
                row.Cells[0].Value = KH.MaKhachHang;
                row.Cells[1].Value = KH.TenKhachHang;
                row.Cells[2].Value = KH.GioiTinh;
                row.Cells[3].Value = KH.NgaySinh;
                row.Cells[4].Value = KH.DiaChi;
                row.Cells[5].Value = KH.SoDienThoai;
                row.Cells[6].Value = KH.CCCD;
            }
        }

        public void TimTheocccdKH(string cccd, DataGridView dgv)
        {
            var ds = db.ThongTinKhachHangs.Where(c => c.CCCD.Contains(cccd)).ToList();
            dgv.Columns.Clear();
            dgv.Rows.Clear();

            if (dgv.Columns.Count == 0)
            {
                dgv.Columns.Add("MaKhachHang", "Mã Khách Hàng");
                dgv.Columns.Add("TenKhachHang", "Tên Khách Hàng");
                dgv.Columns.Add("GioiTinh", "Giới Tính");
                dgv.Columns.Add("NgaySinh", "Ngày Sinh");
                dgv.Columns.Add("DiaChi", "Địa Chỉ");
                dgv.Columns.Add("SoDienThoai", "Số Điện Thoại");
                dgv.Columns.Add("CCCD", "CCCD");
            }
            foreach (var kh in ds)
            {
                DataGridViewColumn column = new DataGridViewTextBoxColumn();

                int ViTri = dgv.Rows.Add();
                DataGridViewRow row = dgv.Rows[ViTri];
                row.Cells[0].Value = kh.MaKhachHang;
                row.Cells[1].Value = kh.TenKhachHang;
                row.Cells[2].Value = kh.GioiTinh;
                row.Cells[3].Value = kh.NgaySinh;
                row.Cells[4].Value = kh.DiaChi;
                row.Cells[5].Value = kh.SoDienThoai;
                row.Cells[6].Value = kh.CCCD;
            }
        }

        public bool CheckMa(string makh)
        {
            var data = db.ThongTinKhachHangs.Any(ns => ns.MaKhachHang == makh);
            if (data)
            {
                MessageBox.Show("Trùng mã khách hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool CheckSDT(string sdt)
        {
            var data = db.ThongTinKhachHangs.Any(ns => ns.SoDienThoai == sdt);
            if (data)
            {
                MessageBox.Show("Số điện thoại này đã được sử dụng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool CheckCCCD(string cccd)
        {
            var data = db.ThongTinKhachHangs.Any(ns => ns.CCCD == cccd);
            if (data)
            {
                MessageBox.Show("Khách hàng đã đăng ký căn cước công dân", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool DoDaiCCD(string cccd)
        {

            if (cccd.Length != 12)
            {
                MessageBox.Show("Căn cước công dân không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool DoDaiSDT(string sdt)
        {

            if (sdt.Length < 10 || sdt.Length > 11)
            {
                MessageBox.Show("Số điện thoại không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
