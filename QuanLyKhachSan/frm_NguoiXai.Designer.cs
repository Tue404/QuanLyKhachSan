namespace QuanLyKhachSan
{
    partial class frm_NguoiXai
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
            this.lbl_timkiem = new System.Windows.Forms.Label();
            this.cbo_phanquen_them = new System.Windows.Forms.ComboBox();
            this.btn_Them = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_manhanvien_them = new System.Windows.Forms.TextBox();
            this.txt_MatKhau = new System.Windows.Forms.TextBox();
            this.lbl_mnsthem_chk = new System.Windows.Forms.Label();
            this.lbl_pqthem_chk = new System.Windows.Forms.Label();
            this.lbl_mkthem_chk = new System.Windows.Forms.Label();
            this.lbl_tdnthem_chk = new System.Windows.Forms.Label();
            this.tabControl_NguoiDung = new System.Windows.Forms.TabControl();
            this.tabPage_ThemNguoiDung = new System.Windows.Forms.TabPage();
            this.txt_TenDangNhap = new System.Windows.Forms.TextBox();
            this.dgv_DanhSachNguoiDung = new System.Windows.Forms.DataGridView();
            this.tabPage_DanhSachNguoiDung = new System.Windows.Forms.TabPage();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_DanhSachNguoiDung1 = new System.Windows.Forms.DataGridView();
            this.tabPage_CapNhat_Xoa = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.cbo_phanquyen_sua = new System.Windows.Forms.ComboBox();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.txt_manhansu_sua = new System.Windows.Forms.TextBox();
            this.txt_mk_Sua = new System.Windows.Forms.TextBox();
            this.txt_tk_Sua = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_mnssua_chk = new System.Windows.Forms.Label();
            this.lbl_pqsua_chk = new System.Windows.Forms.Label();
            this.lbl_mksua_Chk = new System.Windows.Forms.Label();
            this.lbl_tksua_chk = new System.Windows.Forms.Label();
            this.dgv_DanhSachNguoiDung2 = new System.Windows.Forms.DataGridView();
            this.tabControl_NguoiDung.SuspendLayout();
            this.tabPage_ThemNguoiDung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachNguoiDung)).BeginInit();
            this.tabPage_DanhSachNguoiDung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachNguoiDung1)).BeginInit();
            this.tabPage_CapNhat_Xoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachNguoiDung2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_timkiem
            // 
            this.lbl_timkiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_timkiem.AutoSize = true;
            this.lbl_timkiem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_timkiem.Location = new System.Drawing.Point(186, 110);
            this.lbl_timkiem.Name = "lbl_timkiem";
            this.lbl_timkiem.Size = new System.Drawing.Size(176, 20);
            this.lbl_timkiem.TabIndex = 17;
            this.lbl_timkiem.Text = "Nhập thông tin cần tìm:";
            // 
            // cbo_phanquen_them
            // 
            this.cbo_phanquen_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_phanquen_them.FormattingEnabled = true;
            this.cbo_phanquen_them.Location = new System.Drawing.Point(638, 151);
            this.cbo_phanquen_them.Name = "cbo_phanquen_them";
            this.cbo_phanquen_them.Size = new System.Drawing.Size(155, 28);
            this.cbo_phanquen_them.TabIndex = 77;
            // 
            // btn_Them
            // 
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Location = new System.Drawing.Point(901, 116);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(94, 37);
            this.btn_Them.TabIndex = 76;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 74;
            this.label1.Text = "Tên đăng nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(505, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 75;
            this.label3.Text = "Phân quyền";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(505, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 75;
            this.label2.Text = "Mã nhân viên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(55, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 75;
            this.label6.Text = "Mật khẩu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 25);
            this.label5.TabIndex = 72;
            this.label5.Text = "Thêm tài khoản";
            // 
            // txt_manhanvien_them
            // 
            this.txt_manhanvien_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_manhanvien_them.Location = new System.Drawing.Point(638, 95);
            this.txt_manhanvien_them.Name = "txt_manhanvien_them";
            this.txt_manhanvien_them.Size = new System.Drawing.Size(155, 26);
            this.txt_manhanvien_them.TabIndex = 48;
            // 
            // txt_MatKhau
            // 
            this.txt_MatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MatKhau.Location = new System.Drawing.Point(190, 142);
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.Size = new System.Drawing.Size(155, 26);
            this.txt_MatKhau.TabIndex = 48;
            // 
            // lbl_mnsthem_chk
            // 
            this.lbl_mnsthem_chk.AutoSize = true;
            this.lbl_mnsthem_chk.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mnsthem_chk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_mnsthem_chk.Location = new System.Drawing.Point(636, 119);
            this.lbl_mnsthem_chk.Name = "lbl_mnsthem_chk";
            this.lbl_mnsthem_chk.Size = new System.Drawing.Size(13, 17);
            this.lbl_mnsthem_chk.TabIndex = 47;
            this.lbl_mnsthem_chk.Text = "*";
            this.lbl_mnsthem_chk.Visible = false;
            // 
            // lbl_pqthem_chk
            // 
            this.lbl_pqthem_chk.AutoSize = true;
            this.lbl_pqthem_chk.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pqthem_chk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_pqthem_chk.Location = new System.Drawing.Point(636, 177);
            this.lbl_pqthem_chk.Name = "lbl_pqthem_chk";
            this.lbl_pqthem_chk.Size = new System.Drawing.Size(13, 17);
            this.lbl_pqthem_chk.TabIndex = 46;
            this.lbl_pqthem_chk.Text = "*";
            this.lbl_pqthem_chk.Visible = false;
            // 
            // lbl_mkthem_chk
            // 
            this.lbl_mkthem_chk.AutoSize = true;
            this.lbl_mkthem_chk.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mkthem_chk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_mkthem_chk.Location = new System.Drawing.Point(188, 174);
            this.lbl_mkthem_chk.Name = "lbl_mkthem_chk";
            this.lbl_mkthem_chk.Size = new System.Drawing.Size(13, 17);
            this.lbl_mkthem_chk.TabIndex = 45;
            this.lbl_mkthem_chk.Text = "*";
            this.lbl_mkthem_chk.Visible = false;
            // 
            // lbl_tdnthem_chk
            // 
            this.lbl_tdnthem_chk.AutoSize = true;
            this.lbl_tdnthem_chk.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tdnthem_chk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_tdnthem_chk.Location = new System.Drawing.Point(188, 125);
            this.lbl_tdnthem_chk.Name = "lbl_tdnthem_chk";
            this.lbl_tdnthem_chk.Size = new System.Drawing.Size(13, 17);
            this.lbl_tdnthem_chk.TabIndex = 44;
            this.lbl_tdnthem_chk.Text = "*";
            this.lbl_tdnthem_chk.Visible = false;
            // 
            // tabControl_NguoiDung
            // 
            this.tabControl_NguoiDung.Controls.Add(this.tabPage_ThemNguoiDung);
            this.tabControl_NguoiDung.Controls.Add(this.tabPage_DanhSachNguoiDung);
            this.tabControl_NguoiDung.Controls.Add(this.tabPage_CapNhat_Xoa);
            this.tabControl_NguoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_NguoiDung.Location = new System.Drawing.Point(0, 0);
            this.tabControl_NguoiDung.Multiline = true;
            this.tabControl_NguoiDung.Name = "tabControl_NguoiDung";
            this.tabControl_NguoiDung.SelectedIndex = 0;
            this.tabControl_NguoiDung.Size = new System.Drawing.Size(1012, 511);
            this.tabControl_NguoiDung.TabIndex = 3;
            // 
            // tabPage_ThemNguoiDung
            // 
            this.tabPage_ThemNguoiDung.BackColor = System.Drawing.Color.White;
            this.tabPage_ThemNguoiDung.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage_ThemNguoiDung.Controls.Add(this.cbo_phanquen_them);
            this.tabPage_ThemNguoiDung.Controls.Add(this.btn_Them);
            this.tabPage_ThemNguoiDung.Controls.Add(this.label1);
            this.tabPage_ThemNguoiDung.Controls.Add(this.label3);
            this.tabPage_ThemNguoiDung.Controls.Add(this.label2);
            this.tabPage_ThemNguoiDung.Controls.Add(this.label6);
            this.tabPage_ThemNguoiDung.Controls.Add(this.label5);
            this.tabPage_ThemNguoiDung.Controls.Add(this.txt_manhanvien_them);
            this.tabPage_ThemNguoiDung.Controls.Add(this.txt_MatKhau);
            this.tabPage_ThemNguoiDung.Controls.Add(this.txt_TenDangNhap);
            this.tabPage_ThemNguoiDung.Controls.Add(this.lbl_mnsthem_chk);
            this.tabPage_ThemNguoiDung.Controls.Add(this.lbl_pqthem_chk);
            this.tabPage_ThemNguoiDung.Controls.Add(this.lbl_mkthem_chk);
            this.tabPage_ThemNguoiDung.Controls.Add(this.lbl_tdnthem_chk);
            this.tabPage_ThemNguoiDung.Controls.Add(this.dgv_DanhSachNguoiDung);
            this.tabPage_ThemNguoiDung.ForeColor = System.Drawing.Color.Black;
            this.tabPage_ThemNguoiDung.Location = new System.Drawing.Point(4, 22);
            this.tabPage_ThemNguoiDung.Name = "tabPage_ThemNguoiDung";
            this.tabPage_ThemNguoiDung.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_ThemNguoiDung.Size = new System.Drawing.Size(1004, 485);
            this.tabPage_ThemNguoiDung.TabIndex = 0;
            this.tabPage_ThemNguoiDung.Text = "Thêm tài khoản";
            // 
            // txt_TenDangNhap
            // 
            this.txt_TenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenDangNhap.Location = new System.Drawing.Point(190, 90);
            this.txt_TenDangNhap.Name = "txt_TenDangNhap";
            this.txt_TenDangNhap.Size = new System.Drawing.Size(155, 26);
            this.txt_TenDangNhap.TabIndex = 48;
            // 
            // dgv_DanhSachNguoiDung
            // 
            this.dgv_DanhSachNguoiDung.AllowUserToDeleteRows = false;
            this.dgv_DanhSachNguoiDung.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_DanhSachNguoiDung.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DanhSachNguoiDung.BackgroundColor = System.Drawing.Color.White;
            this.dgv_DanhSachNguoiDung.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_DanhSachNguoiDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachNguoiDung.Location = new System.Drawing.Point(-1, 224);
            this.dgv_DanhSachNguoiDung.Name = "dgv_DanhSachNguoiDung";
            this.dgv_DanhSachNguoiDung.RowHeadersWidth = 51;
            this.dgv_DanhSachNguoiDung.Size = new System.Drawing.Size(1004, 252);
            this.dgv_DanhSachNguoiDung.TabIndex = 38;
            // 
            // tabPage_DanhSachNguoiDung
            // 
            this.tabPage_DanhSachNguoiDung.BackColor = System.Drawing.Color.White;
            this.tabPage_DanhSachNguoiDung.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage_DanhSachNguoiDung.Controls.Add(this.txt_TimKiem);
            this.tabPage_DanhSachNguoiDung.Controls.Add(this.label4);
            this.tabPage_DanhSachNguoiDung.Controls.Add(this.lbl_timkiem);
            this.tabPage_DanhSachNguoiDung.Controls.Add(this.dgv_DanhSachNguoiDung1);
            this.tabPage_DanhSachNguoiDung.Location = new System.Drawing.Point(4, 22);
            this.tabPage_DanhSachNguoiDung.Name = "tabPage_DanhSachNguoiDung";
            this.tabPage_DanhSachNguoiDung.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_DanhSachNguoiDung.Size = new System.Drawing.Size(1004, 485);
            this.tabPage_DanhSachNguoiDung.TabIndex = 1;
            this.tabPage_DanhSachNguoiDung.Text = "Danh sách tài khoản";
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TimKiem.Location = new System.Drawing.Point(495, 135);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(191, 26);
            this.txt_TimKiem.TabIndex = 74;
            this.txt_TimKiem.TextChanged += new System.EventHandler(this.txt_TimKiem_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(93, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 25);
            this.label4.TabIndex = 73;
            this.label4.Text = "Danh sách tài khoản";
            // 
            // dgv_DanhSachNguoiDung1
            // 
            this.dgv_DanhSachNguoiDung1.AllowUserToAddRows = false;
            this.dgv_DanhSachNguoiDung1.AllowUserToDeleteRows = false;
            this.dgv_DanhSachNguoiDung1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_DanhSachNguoiDung1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DanhSachNguoiDung1.BackgroundColor = System.Drawing.Color.White;
            this.dgv_DanhSachNguoiDung1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_DanhSachNguoiDung1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachNguoiDung1.Location = new System.Drawing.Point(-1, 218);
            this.dgv_DanhSachNguoiDung1.Name = "dgv_DanhSachNguoiDung1";
            this.dgv_DanhSachNguoiDung1.ReadOnly = true;
            this.dgv_DanhSachNguoiDung1.RowHeadersWidth = 51;
            this.dgv_DanhSachNguoiDung1.Size = new System.Drawing.Size(1004, 252);
            this.dgv_DanhSachNguoiDung1.TabIndex = 16;
            // 
            // tabPage_CapNhat_Xoa
            // 
            this.tabPage_CapNhat_Xoa.BackColor = System.Drawing.Color.White;
            this.tabPage_CapNhat_Xoa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage_CapNhat_Xoa.Controls.Add(this.label12);
            this.tabPage_CapNhat_Xoa.Controls.Add(this.cbo_phanquyen_sua);
            this.tabPage_CapNhat_Xoa.Controls.Add(this.btn_Xoa);
            this.tabPage_CapNhat_Xoa.Controls.Add(this.btn_Sua);
            this.tabPage_CapNhat_Xoa.Controls.Add(this.txt_manhansu_sua);
            this.tabPage_CapNhat_Xoa.Controls.Add(this.txt_mk_Sua);
            this.tabPage_CapNhat_Xoa.Controls.Add(this.txt_tk_Sua);
            this.tabPage_CapNhat_Xoa.Controls.Add(this.label11);
            this.tabPage_CapNhat_Xoa.Controls.Add(this.label10);
            this.tabPage_CapNhat_Xoa.Controls.Add(this.label9);
            this.tabPage_CapNhat_Xoa.Controls.Add(this.label8);
            this.tabPage_CapNhat_Xoa.Controls.Add(this.label7);
            this.tabPage_CapNhat_Xoa.Controls.Add(this.lbl_mnssua_chk);
            this.tabPage_CapNhat_Xoa.Controls.Add(this.lbl_pqsua_chk);
            this.tabPage_CapNhat_Xoa.Controls.Add(this.lbl_mksua_Chk);
            this.tabPage_CapNhat_Xoa.Controls.Add(this.lbl_tksua_chk);
            this.tabPage_CapNhat_Xoa.Controls.Add(this.dgv_DanhSachNguoiDung2);
            this.tabPage_CapNhat_Xoa.Location = new System.Drawing.Point(4, 22);
            this.tabPage_CapNhat_Xoa.Name = "tabPage_CapNhat_Xoa";
            this.tabPage_CapNhat_Xoa.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_CapNhat_Xoa.Size = new System.Drawing.Size(1004, 485);
            this.tabPage_CapNhat_Xoa.TabIndex = 2;
            this.tabPage_CapNhat_Xoa.Text = "Sửa, Xóa tài khoản";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(182, 119);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 17);
            this.label12.TabIndex = 86;
            this.label12.Text = "*";
            this.label12.Visible = false;
            // 
            // cbo_phanquyen_sua
            // 
            this.cbo_phanquyen_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_phanquyen_sua.FormattingEnabled = true;
            this.cbo_phanquyen_sua.Location = new System.Drawing.Point(670, 148);
            this.cbo_phanquyen_sua.Margin = new System.Windows.Forms.Padding(2);
            this.cbo_phanquyen_sua.Name = "cbo_phanquyen_sua";
            this.cbo_phanquyen_sua.Size = new System.Drawing.Size(155, 28);
            this.cbo_phanquyen_sua.TabIndex = 85;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Location = new System.Drawing.Point(909, 144);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(110, 37);
            this.btn_Xoa.TabIndex = 84;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.Location = new System.Drawing.Point(909, 77);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(110, 36);
            this.btn_Sua.TabIndex = 83;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // txt_manhansu_sua
            // 
            this.txt_manhansu_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_manhansu_sua.Location = new System.Drawing.Point(670, 81);
            this.txt_manhansu_sua.Name = "txt_manhansu_sua";
            this.txt_manhansu_sua.Size = new System.Drawing.Size(155, 26);
            this.txt_manhansu_sua.TabIndex = 81;
            // 
            // txt_mk_Sua
            // 
            this.txt_mk_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mk_Sua.Location = new System.Drawing.Point(185, 145);
            this.txt_mk_Sua.Name = "txt_mk_Sua";
            this.txt_mk_Sua.Size = new System.Drawing.Size(155, 26);
            this.txt_mk_Sua.TabIndex = 79;
            // 
            // txt_tk_Sua
            // 
            this.txt_tk_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tk_Sua.Location = new System.Drawing.Point(185, 84);
            this.txt_tk_Sua.Name = "txt_tk_Sua";
            this.txt_tk_Sua.Size = new System.Drawing.Size(155, 26);
            this.txt_tk_Sua.TabIndex = 80;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(528, 149);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 20);
            this.label11.TabIndex = 78;
            this.label11.Text = "Phân quyền";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(528, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 20);
            this.label10.TabIndex = 77;
            this.label10.Text = "Mã nhân viên";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(53, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 20);
            this.label9.TabIndex = 76;
            this.label9.Text = "Mật khẩu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(53, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 20);
            this.label8.TabIndex = 75;
            this.label8.Text = "Tên đăng nhập";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(52, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(264, 25);
            this.label7.TabIndex = 74;
            this.label7.Text = "Chỉnh sửa thông tin tài khoản";
            // 
            // lbl_mnssua_chk
            // 
            this.lbl_mnssua_chk.AutoSize = true;
            this.lbl_mnssua_chk.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mnssua_chk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_mnssua_chk.Location = new System.Drawing.Point(667, 119);
            this.lbl_mnssua_chk.Name = "lbl_mnssua_chk";
            this.lbl_mnssua_chk.Size = new System.Drawing.Size(13, 17);
            this.lbl_mnssua_chk.TabIndex = 61;
            this.lbl_mnssua_chk.Text = "*";
            this.lbl_mnssua_chk.Visible = false;
            // 
            // lbl_pqsua_chk
            // 
            this.lbl_pqsua_chk.AutoSize = true;
            this.lbl_pqsua_chk.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pqsua_chk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_pqsua_chk.Location = new System.Drawing.Point(667, 189);
            this.lbl_pqsua_chk.Name = "lbl_pqsua_chk";
            this.lbl_pqsua_chk.Size = new System.Drawing.Size(13, 17);
            this.lbl_pqsua_chk.TabIndex = 60;
            this.lbl_pqsua_chk.Text = "*";
            this.lbl_pqsua_chk.Visible = false;
            // 
            // lbl_mksua_Chk
            // 
            this.lbl_mksua_Chk.AutoSize = true;
            this.lbl_mksua_Chk.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mksua_Chk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_mksua_Chk.Location = new System.Drawing.Point(182, 189);
            this.lbl_mksua_Chk.Name = "lbl_mksua_Chk";
            this.lbl_mksua_Chk.Size = new System.Drawing.Size(13, 17);
            this.lbl_mksua_Chk.TabIndex = 59;
            this.lbl_mksua_Chk.Text = "*";
            this.lbl_mksua_Chk.Visible = false;
            this.lbl_mksua_Chk.Click += new System.EventHandler(this.lbl_mksua_Chk_Click);
            // 
            // lbl_tksua_chk
            // 
            this.lbl_tksua_chk.AutoSize = true;
            this.lbl_tksua_chk.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tksua_chk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_tksua_chk.Location = new System.Drawing.Point(146, 87);
            this.lbl_tksua_chk.Name = "lbl_tksua_chk";
            this.lbl_tksua_chk.Size = new System.Drawing.Size(13, 17);
            this.lbl_tksua_chk.TabIndex = 58;
            this.lbl_tksua_chk.Text = "*";
            this.lbl_tksua_chk.Visible = false;
            // 
            // dgv_DanhSachNguoiDung2
            // 
            this.dgv_DanhSachNguoiDung2.AllowUserToAddRows = false;
            this.dgv_DanhSachNguoiDung2.AllowUserToDeleteRows = false;
            this.dgv_DanhSachNguoiDung2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_DanhSachNguoiDung2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DanhSachNguoiDung2.BackgroundColor = System.Drawing.Color.White;
            this.dgv_DanhSachNguoiDung2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_DanhSachNguoiDung2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachNguoiDung2.Location = new System.Drawing.Point(6, 209);
            this.dgv_DanhSachNguoiDung2.Name = "dgv_DanhSachNguoiDung2";
            this.dgv_DanhSachNguoiDung2.RowHeadersWidth = 51;
            this.dgv_DanhSachNguoiDung2.Size = new System.Drawing.Size(994, 257);
            this.dgv_DanhSachNguoiDung2.TabIndex = 48;
            this.dgv_DanhSachNguoiDung2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhSachNguoiDung2_CellClick_1);
            this.dgv_DanhSachNguoiDung2.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhSachNguoiDung2_CellEndEdit);
            // 
            // frm_NguoiXai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 511);
            this.Controls.Add(this.tabControl_NguoiDung);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_NguoiXai";
            this.Text = "Tài Khoản";
            this.Load += new System.EventHandler(this.frm_NguoiXai_Load);
            this.tabControl_NguoiDung.ResumeLayout(false);
            this.tabPage_ThemNguoiDung.ResumeLayout(false);
            this.tabPage_ThemNguoiDung.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachNguoiDung)).EndInit();
            this.tabPage_DanhSachNguoiDung.ResumeLayout(false);
            this.tabPage_DanhSachNguoiDung.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachNguoiDung1)).EndInit();
            this.tabPage_CapNhat_Xoa.ResumeLayout(false);
            this.tabPage_CapNhat_Xoa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachNguoiDung2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_timkiem;
        private System.Windows.Forms.ComboBox cbo_phanquen_them;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_manhanvien_them;
        private System.Windows.Forms.TextBox txt_MatKhau;
        private System.Windows.Forms.Label lbl_mnsthem_chk;
        private System.Windows.Forms.Label lbl_pqthem_chk;
        private System.Windows.Forms.Label lbl_mkthem_chk;
        private System.Windows.Forms.Label lbl_tdnthem_chk;
        private System.Windows.Forms.TabControl tabControl_NguoiDung;
        private System.Windows.Forms.TabPage tabPage_ThemNguoiDung;
        private System.Windows.Forms.TextBox txt_TenDangNhap;
        private System.Windows.Forms.DataGridView dgv_DanhSachNguoiDung;
        private System.Windows.Forms.TabPage tabPage_DanhSachNguoiDung;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_DanhSachNguoiDung1;
        private System.Windows.Forms.TabPage tabPage_CapNhat_Xoa;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.TextBox txt_manhansu_sua;
        private System.Windows.Forms.TextBox txt_mk_Sua;
        private System.Windows.Forms.TextBox txt_tk_Sua;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_mnssua_chk;
        private System.Windows.Forms.Label lbl_pqsua_chk;
        private System.Windows.Forms.Label lbl_mksua_Chk;
        private System.Windows.Forms.Label lbl_tksua_chk;
        private System.Windows.Forms.DataGridView dgv_DanhSachNguoiDung2;
        private System.Windows.Forms.ComboBox cbo_phanquyen_sua;
        private System.Windows.Forms.Label label12;
    }
}