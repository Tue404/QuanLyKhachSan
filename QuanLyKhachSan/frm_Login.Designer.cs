namespace QuanLyKhachSan
{
    partial class frm_Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Button btn_Thoat;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_DangNhap = new System.Windows.Forms.Button();
            this.txt_TaiKhoan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_chk_MatKhau = new System.Windows.Forms.Label();
            this.lbl_chk_TenDangNhap = new System.Windows.Forms.Label();
            this.chk_ghiNhoDangNhap = new System.Windows.Forms.CheckBox();
            this.lkb_DangKy = new System.Windows.Forms.LinkLabel();
            this.lkb_QuenMatKhau = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_MatKhau = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.KiemLoi = new System.Windows.Forms.ErrorProvider(this.components);
            btn_Thoat = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KiemLoi)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Thoat
            // 
            btn_Thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(80)))));
            btn_Thoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Thoat.BackgroundImage")));
            btn_Thoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            btn_Thoat.Dock = System.Windows.Forms.DockStyle.Right;
            btn_Thoat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btn_Thoat.ForeColor = System.Drawing.SystemColors.ControlText;
            btn_Thoat.Location = new System.Drawing.Point(869, 0);
            btn_Thoat.Name = "btn_Thoat";
            btn_Thoat.Size = new System.Drawing.Size(36, 34);
            btn_Thoat.TabIndex = 0;
            btn_Thoat.UseVisualStyleBackColor = false;
            btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(btn_Thoat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(905, 34);
            this.panel1.TabIndex = 0;
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DangNhap.Location = new System.Drawing.Point(79, 211);
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.Size = new System.Drawing.Size(193, 49);
            this.btn_DangNhap.TabIndex = 1;
            this.btn_DangNhap.Text = "Đăng nhập";
            this.btn_DangNhap.UseVisualStyleBackColor = true;
            this.btn_DangNhap.Click += new System.EventHandler(this.btn_DangNhap_Click);
            // 
            // txt_TaiKhoan
            // 
            this.txt_TaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TaiKhoan.Location = new System.Drawing.Point(65, 79);
            this.txt_TaiKhoan.Name = "txt_TaiKhoan";
            this.txt_TaiKhoan.Size = new System.Drawing.Size(224, 23);
            this.txt_TaiKhoan.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(139, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Đăng nhập";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Controls.Add(this.lbl_chk_MatKhau);
            this.panel2.Controls.Add(this.lbl_chk_TenDangNhap);
            this.panel2.Controls.Add(this.chk_ghiNhoDangNhap);
            this.panel2.Controls.Add(this.lkb_DangKy);
            this.panel2.Controls.Add(this.lkb_QuenMatKhau);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btn_DangNhap);
            this.panel2.Controls.Add(this.txt_MatKhau);
            this.panel2.Controls.Add(this.txt_TaiKhoan);
            this.panel2.Location = new System.Drawing.Point(49, 142);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(347, 290);
            this.panel2.TabIndex = 4;
            // 
            // lbl_chk_MatKhau
            // 
            this.lbl_chk_MatKhau.AutoSize = true;
            this.lbl_chk_MatKhau.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_chk_MatKhau.ForeColor = System.Drawing.Color.Red;
            this.lbl_chk_MatKhau.Location = new System.Drawing.Point(62, 167);
            this.lbl_chk_MatKhau.Name = "lbl_chk_MatKhau";
            this.lbl_chk_MatKhau.Size = new System.Drawing.Size(13, 16);
            this.lbl_chk_MatKhau.TabIndex = 12;
            this.lbl_chk_MatKhau.Text = "*";
            this.lbl_chk_MatKhau.Visible = false;
            // 
            // lbl_chk_TenDangNhap
            // 
            this.lbl_chk_TenDangNhap.AutoSize = true;
            this.lbl_chk_TenDangNhap.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_chk_TenDangNhap.ForeColor = System.Drawing.Color.Red;
            this.lbl_chk_TenDangNhap.Location = new System.Drawing.Point(62, 108);
            this.lbl_chk_TenDangNhap.Name = "lbl_chk_TenDangNhap";
            this.lbl_chk_TenDangNhap.Size = new System.Drawing.Size(13, 16);
            this.lbl_chk_TenDangNhap.TabIndex = 11;
            this.lbl_chk_TenDangNhap.Text = "*";
            this.lbl_chk_TenDangNhap.Visible = false;
            // 
            // chk_ghiNhoDangNhap
            // 
            this.chk_ghiNhoDangNhap.AutoSize = true;
            this.chk_ghiNhoDangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chk_ghiNhoDangNhap.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_ghiNhoDangNhap.Location = new System.Drawing.Point(65, 183);
            this.chk_ghiNhoDangNhap.Name = "chk_ghiNhoDangNhap";
            this.chk_ghiNhoDangNhap.Size = new System.Drawing.Size(169, 22);
            this.chk_ghiNhoDangNhap.TabIndex = 9;
            this.chk_ghiNhoDangNhap.Text = "Ghi nhớ đăng nhập";
            this.chk_ghiNhoDangNhap.UseVisualStyleBackColor = true;
            // 
            // lkb_DangKy
            // 
            this.lkb_DangKy.AutoSize = true;
            this.lkb_DangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkb_DangKy.ForeColor = System.Drawing.Color.White;
            this.lkb_DangKy.LinkColor = System.Drawing.Color.WhiteSmoke;
            this.lkb_DangKy.Location = new System.Drawing.Point(76, 269);
            this.lkb_DangKy.Name = "lkb_DangKy";
            this.lkb_DangKy.Size = new System.Drawing.Size(59, 16);
            this.lkb_DangKy.TabIndex = 4;
            this.lkb_DangKy.TabStop = true;
            this.lkb_DangKy.Text = "Đăng ký ";
            this.lkb_DangKy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkb_DangKy_LinkClicked);
            // 
            // lkb_QuenMatKhau
            // 
            this.lkb_QuenMatKhau.AutoSize = true;
            this.lkb_QuenMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkb_QuenMatKhau.ForeColor = System.Drawing.Color.White;
            this.lkb_QuenMatKhau.LinkColor = System.Drawing.Color.WhiteSmoke;
            this.lkb_QuenMatKhau.Location = new System.Drawing.Point(193, 269);
            this.lkb_QuenMatKhau.Name = "lkb_QuenMatKhau";
            this.lkb_QuenMatKhau.Size = new System.Drawing.Size(96, 16);
            this.lkb_QuenMatKhau.TabIndex = 4;
            this.lkb_QuenMatKhau.TabStop = true;
            this.lkb_QuenMatKhau.Text = "Quên mật khẩu";
            this.lkb_QuenMatKhau.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkb_QuenMatKhau_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(62, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(62, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tài khoản";
            // 
            // txt_MatKhau
            // 
            this.txt_MatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MatKhau.Location = new System.Drawing.Point(65, 143);
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.Size = new System.Drawing.Size(224, 23);
            this.txt_MatKhau.TabIndex = 2;
            this.txt_MatKhau.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(906, 501);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // KiemLoi
            // 
            this.KiemLoi.ContainerControl = this;
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(905, 535);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Login";
            this.Load += new System.EventHandler(this.frm_Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KiemLoi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_DangNhap;
        private System.Windows.Forms.TextBox txt_TaiKhoan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_MatKhau;
        private System.Windows.Forms.LinkLabel lkb_DangKy;
        private System.Windows.Forms.LinkLabel lkb_QuenMatKhau;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox chk_ghiNhoDangNhap;
        private System.Windows.Forms.Label lbl_chk_TenDangNhap;
        private System.Windows.Forms.Label lbl_chk_MatKhau;
        private System.Windows.Forms.ErrorProvider KiemLoi;
    }
}