namespace QuanLyKhachSan
{
    partial class frm_DichVu
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
            this.tabControl_DichVu = new System.Windows.Forms.TabControl();
            this.tabPage_TimDV = new System.Windows.Forms.TabPage();
            this.dgv_DanhSachDichVu1 = new System.Windows.Forms.DataGridView();
            this.txt_TimkiemTenDichVu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage_ThemDV = new System.Windows.Forms.TabPage();
            this.dgv_DanhSachDichVu = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_TenDichVu = new System.Windows.Forms.TextBox();
            this.txt_MaDichVu = new System.Windows.Forms.TextBox();
            this.txt_DonGia = new System.Windows.Forms.TextBox();
            this.txt_DonViTinh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage_SuaXoaDV = new System.Windows.Forms.TabPage();
            this.dgv_DanhSachDichVu2 = new System.Windows.Forms.DataGridView();
            this.btn_Xoa1 = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.txt_TenDichVusua = new System.Windows.Forms.TextBox();
            this.txt_MaDichVusua = new System.Windows.Forms.TextBox();
            this.txt_DonGiasua = new System.Windows.Forms.TextBox();
            this.txt_DonViTinhsua = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage_DangKyDichVu = new System.Windows.Forms.TabPage();
            this.lbl_DanhSachDichVuDat = new System.Windows.Forms.Label();
            this.cbo_MaDichVu = new System.Windows.Forms.ComboBox();
            this.cbo_MaPhong = new System.Windows.Forms.ComboBox();
            this.btn_XoaDangKyDV = new System.Windows.Forms.Button();
            this.btn_DangKyDV = new System.Windows.Forms.Button();
            this.btn_ThemDangKyDV = new System.Windows.Forms.Button();
            this.txt_SoLuong = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.listView_DichVuDaDat = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dgv_DanhSachDichVu3 = new System.Windows.Forms.DataGridView();
            this.tabControl_DichVu.SuspendLayout();
            this.tabPage_TimDV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachDichVu1)).BeginInit();
            this.tabPage_ThemDV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachDichVu)).BeginInit();
            this.tabPage_SuaXoaDV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachDichVu2)).BeginInit();
            this.tabPage_DangKyDichVu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachDichVu3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl_DichVu
            // 
            this.tabControl_DichVu.Controls.Add(this.tabPage_TimDV);
            this.tabControl_DichVu.Controls.Add(this.tabPage_ThemDV);
            this.tabControl_DichVu.Controls.Add(this.tabPage_SuaXoaDV);
            this.tabControl_DichVu.Controls.Add(this.tabPage_DangKyDichVu);
            this.tabControl_DichVu.Location = new System.Drawing.Point(3, 2);
            this.tabControl_DichVu.Name = "tabControl_DichVu";
            this.tabControl_DichVu.SelectedIndex = 0;
            this.tabControl_DichVu.Size = new System.Drawing.Size(1202, 576);
            this.tabControl_DichVu.TabIndex = 0;
            // 
            // tabPage_TimDV
            // 
            this.tabPage_TimDV.Controls.Add(this.dgv_DanhSachDichVu1);
            this.tabPage_TimDV.Controls.Add(this.txt_TimkiemTenDichVu);
            this.tabPage_TimDV.Controls.Add(this.label5);
            this.tabPage_TimDV.Location = new System.Drawing.Point(4, 22);
            this.tabPage_TimDV.Name = "tabPage_TimDV";
            this.tabPage_TimDV.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_TimDV.Size = new System.Drawing.Size(1194, 550);
            this.tabPage_TimDV.TabIndex = 0;
            this.tabPage_TimDV.Text = "Tìm dịch vụ";
            this.tabPage_TimDV.UseVisualStyleBackColor = true;
            // 
            // dgv_DanhSachDichVu1
            // 
            this.dgv_DanhSachDichVu1.AllowUserToAddRows = false;
            this.dgv_DanhSachDichVu1.AllowUserToDeleteRows = false;
            this.dgv_DanhSachDichVu1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_DanhSachDichVu1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DanhSachDichVu1.BackgroundColor = System.Drawing.Color.White;
            this.dgv_DanhSachDichVu1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_DanhSachDichVu1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachDichVu1.Location = new System.Drawing.Point(75, 222);
            this.dgv_DanhSachDichVu1.Name = "dgv_DanhSachDichVu1";
            this.dgv_DanhSachDichVu1.ReadOnly = true;
            this.dgv_DanhSachDichVu1.RowHeadersWidth = 51;
            this.dgv_DanhSachDichVu1.Size = new System.Drawing.Size(1044, 252);
            this.dgv_DanhSachDichVu1.TabIndex = 104;
            // 
            // txt_TimkiemTenDichVu
            // 
            this.txt_TimkiemTenDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TimkiemTenDichVu.Location = new System.Drawing.Point(446, 107);
            this.txt_TimkiemTenDichVu.Name = "txt_TimkiemTenDichVu";
            this.txt_TimkiemTenDichVu.Size = new System.Drawing.Size(151, 26);
            this.txt_TimkiemTenDichVu.TabIndex = 103;
            this.txt_TimkiemTenDichVu.TextChanged += new System.EventHandler(this.txt_TimkiemTenDichVu_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(335, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 102;
            this.label5.Text = "Tên dịch vụ";
            // 
            // tabPage_ThemDV
            // 
            this.tabPage_ThemDV.Controls.Add(this.dgv_DanhSachDichVu);
            this.tabPage_ThemDV.Controls.Add(this.button1);
            this.tabPage_ThemDV.Controls.Add(this.txt_TenDichVu);
            this.tabPage_ThemDV.Controls.Add(this.txt_MaDichVu);
            this.tabPage_ThemDV.Controls.Add(this.txt_DonGia);
            this.tabPage_ThemDV.Controls.Add(this.txt_DonViTinh);
            this.tabPage_ThemDV.Controls.Add(this.label1);
            this.tabPage_ThemDV.Controls.Add(this.label2);
            this.tabPage_ThemDV.Controls.Add(this.label3);
            this.tabPage_ThemDV.Controls.Add(this.label4);
            this.tabPage_ThemDV.Location = new System.Drawing.Point(4, 22);
            this.tabPage_ThemDV.Name = "tabPage_ThemDV";
            this.tabPage_ThemDV.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_ThemDV.Size = new System.Drawing.Size(1056, 550);
            this.tabPage_ThemDV.TabIndex = 1;
            this.tabPage_ThemDV.Text = "Thêm dịch vụ";
            this.tabPage_ThemDV.UseVisualStyleBackColor = true;
            // 
            // dgv_DanhSachDichVu
            // 
            this.dgv_DanhSachDichVu.AllowUserToAddRows = false;
            this.dgv_DanhSachDichVu.AllowUserToDeleteRows = false;
            this.dgv_DanhSachDichVu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_DanhSachDichVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DanhSachDichVu.BackgroundColor = System.Drawing.Color.White;
            this.dgv_DanhSachDichVu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_DanhSachDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachDichVu.Location = new System.Drawing.Point(-2, 256);
            this.dgv_DanhSachDichVu.Name = "dgv_DanhSachDichVu";
            this.dgv_DanhSachDichVu.ReadOnly = true;
            this.dgv_DanhSachDichVu.RowHeadersWidth = 51;
            this.dgv_DanhSachDichVu.Size = new System.Drawing.Size(1061, 252);
            this.dgv_DanhSachDichVu.TabIndex = 103;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(829, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 47);
            this.button1.TabIndex = 102;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_TenDichVu
            // 
            this.txt_TenDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenDichVu.Location = new System.Drawing.Point(172, 117);
            this.txt_TenDichVu.Name = "txt_TenDichVu";
            this.txt_TenDichVu.Size = new System.Drawing.Size(151, 23);
            this.txt_TenDichVu.TabIndex = 101;
            // 
            // txt_MaDichVu
            // 
            this.txt_MaDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaDichVu.Location = new System.Drawing.Point(172, 72);
            this.txt_MaDichVu.Name = "txt_MaDichVu";
            this.txt_MaDichVu.Size = new System.Drawing.Size(151, 23);
            this.txt_MaDichVu.TabIndex = 100;
            // 
            // txt_DonGia
            // 
            this.txt_DonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DonGia.Location = new System.Drawing.Point(563, 117);
            this.txt_DonGia.Name = "txt_DonGia";
            this.txt_DonGia.Size = new System.Drawing.Size(151, 23);
            this.txt_DonGia.TabIndex = 98;
            // 
            // txt_DonViTinh
            // 
            this.txt_DonViTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DonViTinh.Location = new System.Drawing.Point(563, 78);
            this.txt_DonViTinh.Name = "txt_DonViTinh";
            this.txt_DonViTinh.Size = new System.Drawing.Size(151, 23);
            this.txt_DonViTinh.TabIndex = 99;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 96;
            this.label1.Text = "Tên dịch vụ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 97;
            this.label2.Text = "Mã dịch vụ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(452, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 95;
            this.label3.Text = "Đơn giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(452, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 94;
            this.label4.Text = "Đơn vị tính";
            // 
            // tabPage_SuaXoaDV
            // 
            this.tabPage_SuaXoaDV.Controls.Add(this.dgv_DanhSachDichVu2);
            this.tabPage_SuaXoaDV.Controls.Add(this.btn_Xoa1);
            this.tabPage_SuaXoaDV.Controls.Add(this.btn_Sua);
            this.tabPage_SuaXoaDV.Controls.Add(this.txt_TenDichVusua);
            this.tabPage_SuaXoaDV.Controls.Add(this.txt_MaDichVusua);
            this.tabPage_SuaXoaDV.Controls.Add(this.txt_DonGiasua);
            this.tabPage_SuaXoaDV.Controls.Add(this.txt_DonViTinhsua);
            this.tabPage_SuaXoaDV.Controls.Add(this.label6);
            this.tabPage_SuaXoaDV.Controls.Add(this.label7);
            this.tabPage_SuaXoaDV.Controls.Add(this.label8);
            this.tabPage_SuaXoaDV.Controls.Add(this.label9);
            this.tabPage_SuaXoaDV.Location = new System.Drawing.Point(4, 22);
            this.tabPage_SuaXoaDV.Name = "tabPage_SuaXoaDV";
            this.tabPage_SuaXoaDV.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_SuaXoaDV.Size = new System.Drawing.Size(1056, 550);
            this.tabPage_SuaXoaDV.TabIndex = 2;
            this.tabPage_SuaXoaDV.Text = "Sửa xóa dịch vụ";
            this.tabPage_SuaXoaDV.UseVisualStyleBackColor = true;
            // 
            // dgv_DanhSachDichVu2
            // 
            this.dgv_DanhSachDichVu2.AllowUserToAddRows = false;
            this.dgv_DanhSachDichVu2.AllowUserToDeleteRows = false;
            this.dgv_DanhSachDichVu2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_DanhSachDichVu2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DanhSachDichVu2.BackgroundColor = System.Drawing.Color.White;
            this.dgv_DanhSachDichVu2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_DanhSachDichVu2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachDichVu2.Location = new System.Drawing.Point(9, 246);
            this.dgv_DanhSachDichVu2.Name = "dgv_DanhSachDichVu2";
            this.dgv_DanhSachDichVu2.ReadOnly = true;
            this.dgv_DanhSachDichVu2.RowHeadersWidth = 51;
            this.dgv_DanhSachDichVu2.Size = new System.Drawing.Size(1047, 252);
            this.dgv_DanhSachDichVu2.TabIndex = 112;
            this.dgv_DanhSachDichVu2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhSachDichVu2_CellClick);
            // 
            // btn_Xoa1
            // 
            this.btn_Xoa1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa1.Location = new System.Drawing.Point(827, 137);
            this.btn_Xoa1.Name = "btn_Xoa1";
            this.btn_Xoa1.Size = new System.Drawing.Size(143, 47);
            this.btn_Xoa1.TabIndex = 111;
            this.btn_Xoa1.Text = "Xóa";
            this.btn_Xoa1.UseVisualStyleBackColor = true;
            this.btn_Xoa1.Click += new System.EventHandler(this.btn_Xoa1_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.Location = new System.Drawing.Point(827, 49);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(143, 47);
            this.btn_Sua.TabIndex = 111;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // txt_TenDichVusua
            // 
            this.txt_TenDichVusua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenDichVusua.Location = new System.Drawing.Point(170, 118);
            this.txt_TenDichVusua.Name = "txt_TenDichVusua";
            this.txt_TenDichVusua.Size = new System.Drawing.Size(151, 23);
            this.txt_TenDichVusua.TabIndex = 110;
            // 
            // txt_MaDichVusua
            // 
            this.txt_MaDichVusua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaDichVusua.Location = new System.Drawing.Point(170, 73);
            this.txt_MaDichVusua.Name = "txt_MaDichVusua";
            this.txt_MaDichVusua.Size = new System.Drawing.Size(151, 23);
            this.txt_MaDichVusua.TabIndex = 109;
            // 
            // txt_DonGiasua
            // 
            this.txt_DonGiasua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DonGiasua.Location = new System.Drawing.Point(561, 118);
            this.txt_DonGiasua.Name = "txt_DonGiasua";
            this.txt_DonGiasua.Size = new System.Drawing.Size(151, 23);
            this.txt_DonGiasua.TabIndex = 107;
            // 
            // txt_DonViTinhsua
            // 
            this.txt_DonViTinhsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DonViTinhsua.Location = new System.Drawing.Point(561, 79);
            this.txt_DonViTinhsua.Name = "txt_DonViTinhsua";
            this.txt_DonViTinhsua.Size = new System.Drawing.Size(151, 23);
            this.txt_DonViTinhsua.TabIndex = 108;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(59, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 105;
            this.label6.Text = "Tên dịch vụ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(59, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 17);
            this.label7.TabIndex = 106;
            this.label7.Text = "Mã dịch vụ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(450, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 17);
            this.label8.TabIndex = 104;
            this.label8.Text = "Đơn giá";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(450, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 17);
            this.label9.TabIndex = 103;
            this.label9.Text = "Đơn vị tính";
            // 
            // tabPage_DangKyDichVu
            // 
            this.tabPage_DangKyDichVu.Controls.Add(this.lbl_DanhSachDichVuDat);
            this.tabPage_DangKyDichVu.Controls.Add(this.cbo_MaDichVu);
            this.tabPage_DangKyDichVu.Controls.Add(this.cbo_MaPhong);
            this.tabPage_DangKyDichVu.Controls.Add(this.btn_XoaDangKyDV);
            this.tabPage_DangKyDichVu.Controls.Add(this.btn_DangKyDV);
            this.tabPage_DangKyDichVu.Controls.Add(this.btn_ThemDangKyDV);
            this.tabPage_DangKyDichVu.Controls.Add(this.txt_SoLuong);
            this.tabPage_DangKyDichVu.Controls.Add(this.label12);
            this.tabPage_DangKyDichVu.Controls.Add(this.label13);
            this.tabPage_DangKyDichVu.Controls.Add(this.label15);
            this.tabPage_DangKyDichVu.Controls.Add(this.listView_DichVuDaDat);
            this.tabPage_DangKyDichVu.Controls.Add(this.groupBox1);
            this.tabPage_DangKyDichVu.Controls.Add(this.label10);
            this.tabPage_DangKyDichVu.Controls.Add(this.dgv_DanhSachDichVu3);
            this.tabPage_DangKyDichVu.Location = new System.Drawing.Point(4, 22);
            this.tabPage_DangKyDichVu.Name = "tabPage_DangKyDichVu";
            this.tabPage_DangKyDichVu.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_DangKyDichVu.Size = new System.Drawing.Size(1056, 550);
            this.tabPage_DangKyDichVu.TabIndex = 3;
            this.tabPage_DangKyDichVu.Text = "Đăng ký dịch vụ";
            this.tabPage_DangKyDichVu.UseVisualStyleBackColor = true;
            // 
            // lbl_DanhSachDichVuDat
            // 
            this.lbl_DanhSachDichVuDat.AutoSize = true;
            this.lbl_DanhSachDichVuDat.BackColor = System.Drawing.Color.Transparent;
            this.lbl_DanhSachDichVuDat.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DanhSachDichVuDat.ForeColor = System.Drawing.Color.Black;
            this.lbl_DanhSachDichVuDat.Location = new System.Drawing.Point(16, 231);
            this.lbl_DanhSachDichVuDat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_DanhSachDichVuDat.Name = "lbl_DanhSachDichVuDat";
            this.lbl_DanhSachDichVuDat.Size = new System.Drawing.Size(198, 20);
            this.lbl_DanhSachDichVuDat.TabIndex = 122;
            this.lbl_DanhSachDichVuDat.Text = "Danh sách dịch vụ đã chọn:";
            // 
            // cbo_MaDichVu
            // 
            this.cbo_MaDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_MaDichVu.FormattingEnabled = true;
            this.cbo_MaDichVu.Location = new System.Drawing.Point(167, 97);
            this.cbo_MaDichVu.Name = "cbo_MaDichVu";
            this.cbo_MaDichVu.Size = new System.Drawing.Size(151, 24);
            this.cbo_MaDichVu.TabIndex = 121;
            // 
            // cbo_MaPhong
            // 
            this.cbo_MaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_MaPhong.FormattingEnabled = true;
            this.cbo_MaPhong.Location = new System.Drawing.Point(167, 56);
            this.cbo_MaPhong.Name = "cbo_MaPhong";
            this.cbo_MaPhong.Size = new System.Drawing.Size(151, 24);
            this.cbo_MaPhong.TabIndex = 121;
            // 
            // btn_XoaDangKyDV
            // 
            this.btn_XoaDangKyDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaDangKyDV.Location = new System.Drawing.Point(218, 185);
            this.btn_XoaDangKyDV.Name = "btn_XoaDangKyDV";
            this.btn_XoaDangKyDV.Size = new System.Drawing.Size(100, 38);
            this.btn_XoaDangKyDV.TabIndex = 120;
            this.btn_XoaDangKyDV.Text = "Xóa";
            this.btn_XoaDangKyDV.UseVisualStyleBackColor = true;
            this.btn_XoaDangKyDV.Click += new System.EventHandler(this.btn_XoaDangKyDV_Click);
            // 
            // btn_DangKyDV
            // 
            this.btn_DangKyDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangKyDV.Location = new System.Drawing.Point(142, 437);
            this.btn_DangKyDV.Name = "btn_DangKyDV";
            this.btn_DangKyDV.Size = new System.Drawing.Size(122, 38);
            this.btn_DangKyDV.TabIndex = 120;
            this.btn_DangKyDV.Text = "Đăng ký";
            this.btn_DangKyDV.UseVisualStyleBackColor = true;
            this.btn_DangKyDV.Click += new System.EventHandler(this.btn_DangKyDV_Click);
            // 
            // btn_ThemDangKyDV
            // 
            this.btn_ThemDangKyDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemDangKyDV.Location = new System.Drawing.Point(59, 185);
            this.btn_ThemDangKyDV.Name = "btn_ThemDangKyDV";
            this.btn_ThemDangKyDV.Size = new System.Drawing.Size(100, 38);
            this.btn_ThemDangKyDV.TabIndex = 120;
            this.btn_ThemDangKyDV.Text = "Thêm";
            this.btn_ThemDangKyDV.UseVisualStyleBackColor = true;
            this.btn_ThemDangKyDV.Click += new System.EventHandler(this.btn_ThemDangKyDV_Click);
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SoLuong.Location = new System.Drawing.Point(167, 145);
            this.txt_SoLuong.Name = "txt_SoLuong";
            this.txt_SoLuong.Size = new System.Drawing.Size(151, 23);
            this.txt_SoLuong.TabIndex = 116;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(56, 101);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 17);
            this.label12.TabIndex = 113;
            this.label12.Text = "Mã dịch vụ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(56, 56);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 17);
            this.label13.TabIndex = 114;
            this.label13.Text = "Mã phòng";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(56, 145);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 17);
            this.label15.TabIndex = 111;
            this.label15.Text = "Số lượng";
            // 
            // listView_DichVuDaDat
            // 
            this.listView_DichVuDaDat.FullRowSelect = true;
            this.listView_DichVuDaDat.GridLines = true;
            this.listView_DichVuDaDat.HideSelection = false;
            this.listView_DichVuDaDat.Location = new System.Drawing.Point(20, 254);
            this.listView_DichVuDaDat.Name = "listView_DichVuDaDat";
            this.listView_DichVuDaDat.Size = new System.Drawing.Size(386, 148);
            this.listView_DichVuDaDat.TabIndex = 100;
            this.listView_DichVuDaDat.UseCompatibleStateImageBehavior = false;
            this.listView_DichVuDaDat.View = System.Windows.Forms.View.Details;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_TimKiem);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(606, 425);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 100);
            this.groupBox1.TabIndex = 99;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm dịch vụ";
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TimKiem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TimKiem.Location = new System.Drawing.Point(110, 42);
            this.txt_TimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(222, 25);
            this.txt_TimKiem.TabIndex = 98;
            this.txt_TimKiem.TextChanged += new System.EventHandler(this.txt_TimKiem_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(4, 42);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 20);
            this.label11.TabIndex = 97;
            this.label11.Text = "Tên dịch vụ:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(623, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(312, 31);
            this.label10.TabIndex = 96;
            this.label10.Text = "DANH SÁCH DỊCH VỤ";
            // 
            // dgv_DanhSachDichVu3
            // 
            this.dgv_DanhSachDichVu3.AllowUserToAddRows = false;
            this.dgv_DanhSachDichVu3.AllowUserToDeleteRows = false;
            this.dgv_DanhSachDichVu3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DanhSachDichVu3.BackgroundColor = System.Drawing.Color.White;
            this.dgv_DanhSachDichVu3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachDichVu3.Location = new System.Drawing.Point(557, 95);
            this.dgv_DanhSachDichVu3.Name = "dgv_DanhSachDichVu3";
            this.dgv_DanhSachDichVu3.ReadOnly = true;
            this.dgv_DanhSachDichVu3.RowHeadersWidth = 51;
            this.dgv_DanhSachDichVu3.Size = new System.Drawing.Size(461, 291);
            this.dgv_DanhSachDichVu3.TabIndex = 95;
            this.dgv_DanhSachDichVu3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhSachDichVu3_CellClick);
            // 
            // frm_DichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 579);
            this.Controls.Add(this.tabControl_DichVu);
            this.Name = "frm_DichVu";
            this.Text = "Dịch vụ";
            this.Load += new System.EventHandler(this.frm_DichVu_Load);
            this.tabControl_DichVu.ResumeLayout(false);
            this.tabPage_TimDV.ResumeLayout(false);
            this.tabPage_TimDV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachDichVu1)).EndInit();
            this.tabPage_ThemDV.ResumeLayout(false);
            this.tabPage_ThemDV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachDichVu)).EndInit();
            this.tabPage_SuaXoaDV.ResumeLayout(false);
            this.tabPage_SuaXoaDV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachDichVu2)).EndInit();
            this.tabPage_DangKyDichVu.ResumeLayout(false);
            this.tabPage_DangKyDichVu.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachDichVu3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_DichVu;
        private System.Windows.Forms.TabPage tabPage_TimDV;
        private System.Windows.Forms.DataGridView dgv_DanhSachDichVu1;
        private System.Windows.Forms.TextBox txt_TimkiemTenDichVu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage_ThemDV;
        private System.Windows.Forms.DataGridView dgv_DanhSachDichVu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_TenDichVu;
        private System.Windows.Forms.TextBox txt_MaDichVu;
        private System.Windows.Forms.TextBox txt_DonGia;
        private System.Windows.Forms.TextBox txt_DonViTinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage_SuaXoaDV;
        private System.Windows.Forms.TabPage tabPage_DangKyDichVu;
        private System.Windows.Forms.DataGridView dgv_DanhSachDichVu2;
        private System.Windows.Forms.Button btn_Xoa1;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.TextBox txt_TenDichVusua;
        private System.Windows.Forms.TextBox txt_MaDichVusua;
        private System.Windows.Forms.TextBox txt_DonGiasua;
        private System.Windows.Forms.TextBox txt_DonViTinhsua;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView listView_DichVuDaDat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgv_DanhSachDichVu3;
        private System.Windows.Forms.Label lbl_DanhSachDichVuDat;
        private System.Windows.Forms.ComboBox cbo_MaDichVu;
        private System.Windows.Forms.ComboBox cbo_MaPhong;
        private System.Windows.Forms.Button btn_XoaDangKyDV;
        private System.Windows.Forms.Button btn_DangKyDV;
        private System.Windows.Forms.Button btn_ThemDangKyDV;
        private System.Windows.Forms.TextBox txt_SoLuong;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
    }
}