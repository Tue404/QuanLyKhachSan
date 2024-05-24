using QuanLyKhachSan.DA;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.BLL
{
    public class BLL_Phong
    {
        DA_Phong _DA;
        public BLL_Phong()
        {
            _DA = new DA_Phong();
        }

        public void LoadDsTk(DataGridView dgv)
        {
            dgv.DataSource = _DA.LayPhong();
        }

        public void ThemPhong(string maPhong, string loaiPhong, string tinhTrang, float donGia)
        {
            if (KiemTraMaPhongTonTai(maPhong))
            {
                MessageBox.Show("Mã phòng đã tồn tại trong cơ sở dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _DA.ThemPhong(maPhong, loaiPhong, tinhTrang, donGia);
        }

        public void SuaPhong(string maPhong, string loaiPhong, string tinhTrang, float donGia)
        {
            _DA.SuaPhong(maPhong, loaiPhong, tinhTrang, donGia);
        }

        public void XoaPhong(string maPhong)
        {
            if (KiemTraPhongDaCoKhachThue(maPhong))
            {
                MessageBox.Show("Phòng đang có khách thuê. Bạn không thể xóa phòng này.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _DA.XoaPhong(maPhong);
        }

        public Phong LayPhong(string id)
        {
            return _DA.LayPhong(id);
        }

        public IList timPhongBangMaPhong(string timkiem)
        {
            return _DA.TimPhongBangMaPhong(timkiem);
        }

        public IList timphongbangmatinhtrang(string tinhtrang)
        {
            return _DA.TimPhongBangTinhTrang(tinhtrang);
        }

        public IList TimPhongBangLoaiPhong(string LoaiPhong)
        {
            return _DA.TimPhongBangLoaiPhong(LoaiPhong);
        }

        private bool KiemTraMaPhongTonTai(string maPhong)
        {

            var phong = _DA.LayPhong(maPhong);
            return phong != null; // Nếu phòng tồn tại, trả về true; ngược lại trả về false.
        }

        public bool KiemTraPhongDaCoKhachThue(string maPhong)
        {
            return _DA.KiemTraPhongDaCoKhachThue(maPhong);
        }

        public void CapNhatTrangThaiPhong(string maPhong, string tinhTrang)
        {
            // Gọi phương thức CapNhatTrangThaiPhong trong DA_Phong để cập nhật trạng thái phòng
            _DA.CapNhatTrangThaiPhong(maPhong, tinhTrang);
        }
    }
}
