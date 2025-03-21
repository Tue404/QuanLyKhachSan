﻿using QuanLyKhachSan.BLL;
using QuanLyKhachSan.DA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class frm_GiaoDienPhong : Form
    {
        BLL_GiaoDienPhong bll;
        public frm_GiaoDienPhong()
        {
            InitializeComponent();
            bll = new BLL_GiaoDienPhong();
        }

        private void pic_101_Click(object sender, EventArgs e)
        {
            string maPhong = lbl_101.Text;
            var phong = bll.layTrangThai(maPhong);

            if (phong.TinhTrang == "Trống")
            {
                // Open the frm_DatPhong form if the room is available
                frm_ThuePhong quanLyTraPhong = new frm_ThuePhong();
                frm_Main.ViDu.OpenChildForm(quanLyTraPhong);
            }
            else
            {
                // Open the frm_ThongTinPhong form if the room is already rented
                frm_ThongTinPhong frm_ThongTinPhong = new frm_ThongTinPhong(maPhong);
                frm_ThongTinPhong.ShowDialog();
            }
        }

        private void pic_102_Click(object sender, EventArgs e)
        {
            string maPhong = lbl_102.Text;
            var phong = bll.layTrangThai(maPhong);

            if (phong.TinhTrang == "Trống")
            {
                // Open the frm_DatPhong form if the room is available
                frm_ThuePhong quanLyTraPhong = new frm_ThuePhong();
                frm_Main.ViDu.OpenChildForm(quanLyTraPhong);
            }
            else
            {
                // Open the frm_ThongTinPhong form if the room is already rented
                frm_ThongTinPhong frm_ThongTinPhong = new frm_ThongTinPhong(maPhong);
                frm_ThongTinPhong.ShowDialog();
            }
        }

        private void pic_103_Click(object sender, EventArgs e)
        {
            string maPhong = lbl_103.Text;
            var phong = bll.layTrangThai(maPhong);

            if (phong.TinhTrang == "Trống")
            {
                // Open the frm_DatPhong form if the room is available
                frm_ThuePhong quanLyTraPhong = new frm_ThuePhong();
                frm_Main.ViDu.OpenChildForm(quanLyTraPhong);
            }
            else
            {
                // Open the frm_ThongTinPhong form if the room is already rented
                frm_ThongTinPhong frm_ThongTinPhong = new frm_ThongTinPhong(maPhong);
                frm_ThongTinPhong.ShowDialog();
            }
        }

        private void pic_104_Click(object sender, EventArgs e)
        {

            string maPhong = lbl_104.Text;
            var phong = bll.layTrangThai(maPhong);

            if (phong.TinhTrang == "Trống")
            {
                // Open the frm_DatPhong form if the room is available
                frm_ThuePhong quanLyTraPhong = new frm_ThuePhong();
                frm_Main.ViDu.OpenChildForm(quanLyTraPhong);
            }
            else
            {
                // Open the frm_ThongTinPhong form if the room is already rented
                frm_ThongTinPhong frm_ThongTinPhong = new frm_ThongTinPhong(maPhong);
                frm_ThongTinPhong.ShowDialog();
            }
        }

        private void pic_105_Click(object sender, EventArgs e)
        {
            string maPhong = lbl_105.Text;
            var phong = bll.layTrangThai(maPhong);

            if (phong.TinhTrang == "Trống")
            {
                // Open the frm_DatPhong form if the room is available
                frm_ThuePhong quanLyTraPhong = new frm_ThuePhong();
                frm_Main.ViDu.OpenChildForm(quanLyTraPhong);
            }
            else
            {
                // Open the frm_ThongTinPhong form if the room is already rented
                frm_ThongTinPhong frm_ThongTinPhong = new frm_ThongTinPhong(maPhong);
                frm_ThongTinPhong.ShowDialog();
            }
        }

        private void pic_201_Click(object sender, EventArgs e)
        {
            string maPhong = lbl_201.Text;
            var phong = bll.layTrangThai(maPhong);

            if (phong.TinhTrang == "Trống")
            {
                // Open the frm_DatPhong form if the room is available
                frm_ThuePhong quanLyTraPhong = new frm_ThuePhong();
                frm_Main.ViDu.OpenChildForm(quanLyTraPhong);
            }
            else
            {
                // Open the frm_ThongTinPhong form if the room is already rented
                frm_ThongTinPhong frm_ThongTinPhong = new frm_ThongTinPhong(maPhong);
                frm_ThongTinPhong.ShowDialog();
            }
        }

        private void pic_202_Click(object sender, EventArgs e)
        {
            string maPhong = lbl_202.Text;
            var phong = bll.layTrangThai(maPhong);

            if (phong.TinhTrang == "Trống")
            {
                // Open the frm_DatPhong form if the room is available
                frm_ThuePhong quanLyTraPhong = new frm_ThuePhong();
                frm_Main.ViDu.OpenChildForm(quanLyTraPhong);
            }
            else
            {
                // Open the frm_ThongTinPhong form if the room is already rented
                frm_ThongTinPhong frm_ThongTinPhong = new frm_ThongTinPhong(maPhong);
                frm_ThongTinPhong.ShowDialog();
            }
        }

        private void pic_203_Click(object sender, EventArgs e)
        {
            string maPhong = lbl_203.Text;
            var phong = bll.layTrangThai(maPhong);

            if (phong.TinhTrang == "Trống")
            {
                // Open the frm_DatPhong form if the room is available
                frm_ThuePhong quanLyTraPhong = new frm_ThuePhong();
                frm_Main.ViDu.OpenChildForm(quanLyTraPhong);
            }
            else
            {
                // Open the frm_ThongTinPhong form if the room is already rented
                frm_ThongTinPhong frm_ThongTinPhong = new frm_ThongTinPhong(maPhong);
                frm_ThongTinPhong.ShowDialog();
            }
        }

        private void pic_204_Click(object sender, EventArgs e)
        {
            string maPhong = lbl_204.Text;
            var phong = bll.layTrangThai(maPhong);

            if (phong.TinhTrang == "Trống")
            {
                // Open the frm_DatPhong form if the room is available
                frm_ThuePhong quanLyTraPhong = new frm_ThuePhong();
                frm_Main.ViDu.OpenChildForm(quanLyTraPhong);
            }
            else
            {
                // Open the frm_ThongTinPhong form if the room is already rented
                frm_ThongTinPhong frm_ThongTinPhong = new frm_ThongTinPhong(maPhong);
                frm_ThongTinPhong.ShowDialog();
            }
        }

        private void pic_205_Click(object sender, EventArgs e)
        {
            string maPhong = lbl_205.Text;
            var phong = bll.layTrangThai(maPhong);

            if (phong.TinhTrang == "Trống")
            {
                // Open the frm_DatPhong form if the room is available
                frm_ThuePhong quanLyTraPhong = new frm_ThuePhong();
                frm_Main.ViDu.OpenChildForm(quanLyTraPhong);
            }
            else
            {
                // Open the frm_ThongTinPhong form if the room is already rented
                frm_ThongTinPhong frm_ThongTinPhong = new frm_ThongTinPhong(maPhong);
                frm_ThongTinPhong.ShowDialog();
            }
        }

        private void pic_301_Click(object sender, EventArgs e)
        {
            string maPhong = lbl_301.Text;
            var phong = bll.layTrangThai(maPhong);

            if (phong.TinhTrang == "Trống")
            {
                // Open the frm_DatPhong form if the room is available
                frm_ThuePhong quanLyTraPhong = new frm_ThuePhong();
                frm_Main.ViDu.OpenChildForm(quanLyTraPhong);
            }
            else
            {
                // Open the frm_ThongTinPhong form if the room is already rented
                frm_ThongTinPhong frm_ThongTinPhong = new frm_ThongTinPhong(maPhong);
                frm_ThongTinPhong.ShowDialog();
            }
        }

        private void pic_302_Click(object sender, EventArgs e)
        {
            string maPhong = lbl_302.Text;
            var phong = bll.layTrangThai(maPhong);

            if (phong.TinhTrang == "Trống")
            {
                // Open the frm_DatPhong form if the room is available
                frm_ThuePhong quanLyTraPhong = new frm_ThuePhong();
                frm_Main.ViDu.OpenChildForm(quanLyTraPhong);
            }
            else
            {
                // Open the frm_ThongTinPhong form if the room is already rented
                frm_ThongTinPhong frm_ThongTinPhong = new frm_ThongTinPhong(maPhong);
                frm_ThongTinPhong.ShowDialog();
            }
        }

        private void pic_303_Click(object sender, EventArgs e)
        {
            string maPhong = lbl_303.Text;
            var phong = bll.layTrangThai(maPhong);

            if (phong.TinhTrang == "Trống")
            {
                // Open the frm_DatPhong form if the room is available
                frm_ThuePhong quanLyTraPhong = new frm_ThuePhong();
                frm_Main.ViDu.OpenChildForm(quanLyTraPhong);
            }
            else
            {
                // Open the frm_ThongTinPhong form if the room is already rented
                frm_ThongTinPhong frm_ThongTinPhong = new frm_ThongTinPhong(maPhong);
                frm_ThongTinPhong.ShowDialog();
            }
        }

        private void pic_304_Click(object sender, EventArgs e)
        {
            string maPhong = lbl_304.Text;
            var phong = bll.layTrangThai(maPhong);

            if (phong.TinhTrang == "Trống")
            {
                // Open the frm_DatPhong form if the room is available
                frm_ThuePhong quanLyTraPhong = new frm_ThuePhong();
                frm_Main.ViDu.OpenChildForm(quanLyTraPhong);
            }
            else
            {
                // Open the frm_ThongTinPhong form if the room is already rented
                frm_ThongTinPhong frm_ThongTinPhong = new frm_ThongTinPhong(maPhong);
                frm_ThongTinPhong.ShowDialog();
            }
        }

        private void pic_305_Click(object sender, EventArgs e)
        {
            string maPhong = lbl_305.Text;
            var phong = bll.layTrangThai(maPhong);

            if (phong.TinhTrang == "Trống")
            {
                // Open the frm_DatPhong form if the room is available
                frm_ThuePhong quanLyTraPhong = new frm_ThuePhong();
                frm_Main.ViDu.OpenChildForm(quanLyTraPhong);
            }
            else
            {
                // Open the frm_ThongTinPhong form if the room is already rented
                frm_ThongTinPhong frm_ThongTinPhong = new frm_ThongTinPhong(maPhong);
                frm_ThongTinPhong.ShowDialog();
            }

        }

        private void pic_401_Click(object sender, EventArgs e)
        {
            string maPhong = lbl_401.Text;
            var phong = bll.layTrangThai(maPhong);

            if (phong.TinhTrang == "Trống")
            {
                // Open the frm_DatPhong form if the room is available
                frm_ThuePhong quanLyTraPhong = new frm_ThuePhong();
                frm_Main.ViDu.OpenChildForm(quanLyTraPhong);
            }
            else
            {
                // Open the frm_ThongTinPhong form if the room is already rented
                frm_ThongTinPhong frm_ThongTinPhong = new frm_ThongTinPhong(maPhong);
                frm_ThongTinPhong.ShowDialog();
            }
        }

        private void pic_402_Click(object sender, EventArgs e)
        {
            string maPhong = lbl_402.Text;
            var phong = bll.layTrangThai(maPhong);

            if (phong.TinhTrang == "Trống")
            {
                // Open the frm_DatPhong form if the room is available
                frm_ThuePhong quanLyTraPhong = new frm_ThuePhong();
                frm_Main.ViDu.OpenChildForm(quanLyTraPhong);
            }
            else
            {
                // Open the frm_ThongTinPhong form if the room is already rented
                frm_ThongTinPhong frm_ThongTinPhong = new frm_ThongTinPhong(maPhong);
                frm_ThongTinPhong.ShowDialog();
            }
        }

        private void pic_403_Click(object sender, EventArgs e)
        {
            string maPhong = lbl_403.Text;
            var phong = bll.layTrangThai(maPhong);

            if (phong.TinhTrang == "Trống")
            {
                // Open the frm_DatPhong form if the room is available
                frm_ThuePhong quanLyTraPhong = new frm_ThuePhong();
                frm_Main.ViDu.OpenChildForm(quanLyTraPhong);
            }
            else
            {
                // Open the frm_ThongTinPhong form if the room is already rented
                frm_ThongTinPhong frm_ThongTinPhong = new frm_ThongTinPhong(maPhong);
                frm_ThongTinPhong.ShowDialog();
            }
        }

        private void pic_404_Click(object sender, EventArgs e)
        {
            string maPhong = lbl_404.Text;
            var phong = bll.layTrangThai(maPhong);

            if (phong.TinhTrang == "Trống")
            {
                // Open the frm_DatPhong form if the room is available
                frm_ThuePhong quanLyTraPhong = new frm_ThuePhong();
                frm_Main.ViDu.OpenChildForm(quanLyTraPhong);
            }
            else
            {
                // Open the frm_ThongTinPhong form if the room is already rented
                frm_ThongTinPhong frm_ThongTinPhong = new frm_ThongTinPhong(maPhong);
                frm_ThongTinPhong.ShowDialog();
            }
        }

        private void pic_405_Click(object sender, EventArgs e)
        {
            string maPhong = lbl_405.Text;
            var phong = bll.layTrangThai(maPhong);

            if (phong.TinhTrang == "Trống")
            {
                // Open the frm_DatPhong form if the room is available
                frm_ThuePhong quanLyTraPhong = new frm_ThuePhong();
                frm_Main.ViDu.OpenChildForm(quanLyTraPhong);
            }
            else
            {
                // Open the frm_ThongTinPhong form if the room is already rented
                frm_ThongTinPhong frm_ThongTinPhong = new frm_ThongTinPhong(maPhong);
                frm_ThongTinPhong.ShowDialog();
            }
        }

        private void OpenFormThuePhong(string maPhong)
        {
            frm_ThuePhong frmThuePhong = new frm_ThuePhong(maPhong);
            frm_Main.ViDu.OpenChildForm(frmThuePhong);
        }

        public void OpenFormThongTinPhong(string maPhong)
        {
            ThuePhong thuePhong = bll.layThongTin(maPhong);
            if (thuePhong != null)
            {
                frm_ThongTinPhong frmThongTinPhong = new frm_ThongTinPhong(thuePhong);
                frmThongTinPhong.ShowDialog();
            }
            else
            {
                MessageBox.Show("Phòng chưa có khách thuê!");
            }
        }

        void DoiAnh()
        {
            //101
            var phong101 = bll.layTrangThai(lbl_101.Text);

            if (phong101.TinhTrang == "Trống")
            {
                pic_101.Image = Properties.Resources.bedroom__2_;
            }
            else
            {
                pic_101.Image = Properties.Resources.icons8_house_key_64;
            }
            //102

            var phong102 = bll.layTrangThai(lbl_102.Text);

            if (phong102.TinhTrang == "Trống")
            {
                pic_102.Image = Properties.Resources.bedroom__2_;
            }
            else
            {
                pic_102.Image = Properties.Resources.icons8_house_key_64;
            }
            //103
            var phong103 = bll.layTrangThai(lbl_103.Text);

            if (phong103.TinhTrang == "Trống")
            {
                pic_103.Image = Properties.Resources.bedroom__2_;
            }
            else
            {
                pic_103.Image = Properties.Resources.icons8_house_key_64;
            }
            //104
            var phong104 = bll.layTrangThai(lbl_104.Text);

            if (phong104.TinhTrang == "Trống")
            {
                pic_104.Image = Properties.Resources.bedroom__2_;
            }
            else
            {
                pic_104.Image = Properties.Resources.icons8_house_key_64;
            }
            //105
            var phong105 = bll.layTrangThai(lbl_105.Text);

            if (phong105.TinhTrang == "Trống")
            {
                pic_105.Image = Properties.Resources.bedroom__2_;
            }
            else
            {
                pic_105.Image = Properties.Resources.icons8_house_key_64;
            }
            //201
            var phong201 = bll.layTrangThai(lbl_201.Text);

            if (phong201.TinhTrang == "Trống")
            {
                pic_201.Image = Properties.Resources.bedroom__2_;
            }
            else
            {
                pic_201.Image = Properties.Resources.icons8_house_key_64;
            }
            //202
            var phong202 = bll.layTrangThai(lbl_202.Text);

            if (phong202.TinhTrang == "Trống")
            {
                pic_202.Image = Properties.Resources.bedroom__2_;
            }
            else
            {
                pic_202.Image = Properties.Resources.icons8_house_key_64;
            }
            //203
            var phong203 = bll.layTrangThai(lbl_203.Text);

            if (phong203.TinhTrang == "Trống")
            {
                pic_203.Image = Properties.Resources.bedroom__2_;
            }
            else
            {
                pic_203.Image = Properties.Resources.icons8_house_key_64;
            }
            //204
            var phong204 = bll.layTrangThai(lbl_204.Text);

            if (phong204.TinhTrang == "Trống")
            {
                pic_204.Image = Properties.Resources.bedroom__2_;
            }
            else
            {
                pic_204.Image = Properties.Resources.icons8_house_key_64;
            }
            //205
            var phong205 = bll.layTrangThai(lbl_205.Text);

            if (phong205.TinhTrang == "Trống")
            {
                pic_205.Image = Properties.Resources.bedroom__2_;
            }
            else
            {
                pic_205.Image = Properties.Resources.icons8_house_key_64;
            }
            //301
            var phong301 = bll.layTrangThai(lbl_301.Text);

            if (phong301.TinhTrang == "Trống")
            {
                pic_301.Image = Properties.Resources.bedroom__2_;
            }
            else
            {
                pic_301.Image = Properties.Resources.icons8_house_key_64;
            }
            //302
            var phong302 = bll.layTrangThai(lbl_302.Text);

            if (phong302.TinhTrang == "Trống")
            {
                pic_302.Image = Properties.Resources.bedroom__2_;
            }
            else
            {
                pic_302.Image = Properties.Resources.icons8_house_key_64;
            }
            //303
            var phong303 = bll.layTrangThai(lbl_303.Text);

            if (phong303.TinhTrang == "Trống")
            {
                pic_303.Image = Properties.Resources.bedroom__2_;
            }
            else
            {
                pic_303.Image = Properties.Resources.icons8_house_key_64;
            }
            //304
            var phong304 = bll.layTrangThai(lbl_304.Text);

            if (phong304.TinhTrang == "Trống")
            {
                pic_304.Image = Properties.Resources.bedroom__2_;
            }
            else
            {
                pic_304.Image = Properties.Resources.icons8_house_key_64;
            }
            //305
            var phong305 = bll.layTrangThai(lbl_305.Text);

            if (phong305.TinhTrang == "Trống")
            {
                pic_305.Image = Properties.Resources.bedroom__2_;
            }
            else
            {
                pic_305.Image = Properties.Resources.icons8_house_key_64;
            }
            //401
            var phong401 = bll.layTrangThai(lbl_401.Text);

            if (phong401.TinhTrang == "Trống")
            {
                pic_401.Image = Properties.Resources.bedroom__2_;
            }
            else
            {
                pic_401.Image = Properties.Resources.icons8_house_key_64;
            }
            //402
            var phong402 = bll.layTrangThai(lbl_402.Text);

            if (phong402.TinhTrang == "Trống")
            {
                pic_402.Image = Properties.Resources.bedroom__2_;
            }
            else
            {
                pic_402.Image = Properties.Resources.icons8_house_key_64;
            }
            //403
            var phong403 = bll.layTrangThai(lbl_403.Text);

            if (phong403.TinhTrang == "Trống")
            {
                pic_403.Image = Properties.Resources.bedroom__2_;
            }
            else
            {
                pic_403.Image = Properties.Resources.icons8_house_key_64;
            }
            //404
            var phong404 = bll.layTrangThai(lbl_404.Text);

            if (phong404.TinhTrang == "Trống")
            {
                pic_404.Image = Properties.Resources.bedroom__2_;
            }
            else
            {
                pic_404.Image = Properties.Resources.icons8_house_key_64;
            }
            //405
            var phong405 = bll.layTrangThai(lbl_405.Text);

            if (phong405.TinhTrang == "Trống")
            {
                pic_405.Image = Properties.Resources.bedroom__2_;
            }

            else
            {
                pic_405.Image = Properties.Resources.icons8_house_key_64;
            }
        }

        private void frm_GiaoDienPhong_Load(object sender, EventArgs e)
        {
            DoiAnh();

        }

    }
}
