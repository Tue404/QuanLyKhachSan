using QuanLyKhachSan;
using QuanLyKhachSan.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class frm_Main : Form
    {
        public static frm_Main ViDu { get; private set; }
        BLL_TrangChu bus;
        public Form frm_HienTai;
        public string TenDangNhap;
        string _tk;
        public string ChucVu;

        //Biến màu
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        public frm_Main(string tk)      
        {
            InitializeComponent();
            ViDu = this;
            _tk = tk;
            bus = new BLL_TrangChu();
            ChucVu = bus.LayChucVu(tk);

            random = new Random();
            btn_CloseChildForm.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public void OpenChildForm(Form frm_Con)
        {
            if (frm_HienTai != null)
            {
                frm_HienTai.Close();
            }

            frm_HienTai = frm_Con;
            frm_Con.TopLevel = false;
            frm_Con.FormBorderStyle = FormBorderStyle.None;
            frm_Con.Dock = DockStyle.Fill;
            pnl_Desktop.Controls.Add(frm_Con);
            frm_Con.Show();

        }

        //private void DiChuyenPanel(Control btn)
        //{
        //    pnl_Slide.Top = btn.Top;
        //    pnl_Slide.Height = btn.Height;

        //}

        void PhanQuyen()
        {
            if (ChucVu == "Nhân viên")
            {
                //Khởi tạo form frm_DichVu
                // Lấy tham chiếu đến tabControl_DichVu_ADM trong frm_DichVu

                //xácThựcTàiKhoảnToolStripMenuItem.Enabled = false;
                btn_Phong.Visible = false;
                btn_NhanVien.Visible = false;
                btn_TaiKhoan.Visible = false;
                quảnLýToolStripMenuItem.Enabled = false;

            }
            else if (ChucVu == "Quản lý")
            {

            }
        }

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
               index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string Color = ThemeColor.ColorList[tempIndex];
            return ColorTranslator.FromHtml(Color);
        }

        private void ActiveButton(object btnsender)
        {
            if(btnsender != null)
            {
                if(currentButton != (Button)btnsender) 
                { 
                    Color color = SelectThemeColor();  
                    currentButton = (Button)btnsender;  
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    pnl_titlebar.BackColor = color;
                    pnl_Logo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btn_CloseChildForm.Visible = true;
                }
            }
        }
        private void DisbaleButton()
        {
            foreach(Control previousBtn in pnl_Menu.Controls)
            {
                if(previousBtn.GetType()==typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51,51,76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }

            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            ActiveButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;    
            this.pnl_Desktop.Controls.Add(childForm);
            this.pnl_Desktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lbl_Title.Text = childForm.Text;
        }

        private void btn_TrangChu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_GiaoDienPhong());
        }

        private void btn_ThuePhong_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLyKhachSan.frm_ThuePhong(), sender); ActiveButton(sender);
        }

        private void btn_DichVu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLyKhachSan.frm_DichVu(), sender); ActiveButton(sender);
        }

        private void btn_VatTu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLyKhachSan.frm_ThongTinKhachHang(), sender);
        }

        private void btn_Phong_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLyKhachSan.frm_Phong(), sender); ActiveButton(sender);
        }

        private void btn_HoaDon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLyKhachSan.frm_HoaDon(), sender);
        }

        private void btn_NhanVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLyKhachSan.frm_NhanVien(), sender);
        }

        private void btn_TaiKhoan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLyKhachSan.frm_ThongTinKhachHang(), sender);
        }

        private void btn_KhachHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLyKhachSan.frm_ThongTinKhachHang(), sender);
        }

        private void btn_CloseChildForm_Click(object sender, EventArgs e)
        {
            if(activeForm != null)
            {
                activeForm.Close();
                Reset();
            }
        }
        
        private void Reset()
        {
            DisbaleButton();
            lbl_Title.Text = "HONE";
            pnl_titlebar.BackColor = Color.FromArgb(0, 150, 136);
            pnl_Logo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            btn_CloseChildForm.Visible = false;   
        }

        private void pnl_titlebar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_Tat_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void btn_kichthuoc_Click(object sender, EventArgs e)
        {
            if(WindowState  == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btn_ThuNho_Click(object sender, EventArgs e)
        {
            this.WindowState=FormWindowState.Minimized;
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            PhanQuyen();
            //timer1.Start();
            //lbl_TenDangNhap.Text = _tk;
            OpenChildForm(new frm_GiaoDienPhong());

            //ThongTinTaiKoan();
        }

    
    }
}
