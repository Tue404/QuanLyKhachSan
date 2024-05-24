namespace QuanLyKhachSan
{
    partial class frm_HoaDon
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.TongTienThanhToan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_KqSDT = new System.Windows.Forms.Label();
            this.lbl_KetQuaMaHD = new System.Windows.Forms.Label();
            this.MaHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_DanhSachHoaDon = new System.Windows.Forms.DataGridView();
            this.TongTienDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_KqMaKhachHang = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_KqCCCD = new System.Windows.Forms.Label();
            this.lbl_KqNgayThue = new System.Windows.Forms.Label();
            this.lbl_KqMaPhong = new System.Windows.Forms.Label();
            this.lbl_KqNgayTra = new System.Windows.Forms.Label();
            this.lbl_KqTienDichVu = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.lbl_thanhtoan = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachHoaDon)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1271, 567);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.lbl_KqCCCD);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.lbl_KqTienDichVu);
            this.tabPage2.Controls.Add(this.lbl_KqSDT);
            this.tabPage2.Controls.Add(this.lbl_KqNgayTra);
            this.tabPage2.Controls.Add(this.lbl_KqMaPhong);
            this.tabPage2.Controls.Add(this.lbl_KetQuaMaHD);
            this.tabPage2.Controls.Add(this.lbl_KqNgayThue);
            this.tabPage2.Controls.Add(this.dgv_DanhSachHoaDon);
            this.tabPage2.Controls.Add(this.lbl_KqMaKhachHang);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1263, 541);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Hóa đơn";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // TongTienThanhToan
            // 
            this.TongTienThanhToan.HeaderText = "Thanh Toán";
            this.TongTienThanhToan.Name = "TongTienThanhToan";
            this.TongTienThanhToan.ReadOnly = true;
            // 
            // NgayTra
            // 
            this.NgayTra.HeaderText = "Ngày Trả";
            this.NgayTra.Name = "NgayTra";
            this.NgayTra.ReadOnly = true;
            // 
            // NgayThue
            // 
            this.NgayThue.HeaderText = "Ngày Thuê";
            this.NgayThue.Name = "NgayThue";
            this.NgayThue.ReadOnly = true;
            // 
            // MaPhong
            // 
            this.MaPhong.HeaderText = "Mã Phòng";
            this.MaPhong.Name = "MaPhong";
            this.MaPhong.ReadOnly = true;
            // 
            // SoDienThoai
            // 
            this.SoDienThoai.HeaderText = "Số Điện Thoại";
            this.SoDienThoai.Name = "SoDienThoai";
            this.SoDienThoai.ReadOnly = true;
            // 
            // CMND
            // 
            this.CMND.HeaderText = "CMND/CCCD";
            this.CMND.Name = "CMND";
            this.CMND.ReadOnly = true;
            // 
            // TenKhachHang
            // 
            this.TenKhachHang.HeaderText = "Tên Khách Hàng";
            this.TenKhachHang.Name = "TenKhachHang";
            this.TenKhachHang.ReadOnly = true;
            // 
            // lbl_KqSDT
            // 
            this.lbl_KqSDT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_KqSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_KqSDT.Location = new System.Drawing.Point(240, 135);
            this.lbl_KqSDT.Name = "lbl_KqSDT";
            this.lbl_KqSDT.Size = new System.Drawing.Size(197, 22);
            this.lbl_KqSDT.TabIndex = 44;
            this.lbl_KqSDT.Text = "---";
            this.lbl_KqSDT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_KetQuaMaHD
            // 
            this.lbl_KetQuaMaHD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_KetQuaMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_KetQuaMaHD.Location = new System.Drawing.Point(240, 52);
            this.lbl_KetQuaMaHD.Name = "lbl_KetQuaMaHD";
            this.lbl_KetQuaMaHD.Size = new System.Drawing.Size(197, 22);
            this.lbl_KetQuaMaHD.TabIndex = 42;
            this.lbl_KetQuaMaHD.Text = "---";
            this.lbl_KetQuaMaHD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MaHoaDon
            // 
            this.MaHoaDon.HeaderText = "Mã Hóa Đơn";
            this.MaHoaDon.Name = "MaHoaDon";
            this.MaHoaDon.ReadOnly = true;
            // 
            // dgv_DanhSachHoaDon
            // 
            this.dgv_DanhSachHoaDon.AllowUserToAddRows = false;
            this.dgv_DanhSachHoaDon.AllowUserToDeleteRows = false;
            this.dgv_DanhSachHoaDon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_DanhSachHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DanhSachHoaDon.BackgroundColor = System.Drawing.Color.White;
            this.dgv_DanhSachHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_DanhSachHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHoaDon,
            this.TenKhachHang,
            this.CMND,
            this.SoDienThoai,
            this.MaPhong,
            this.NgayThue,
            this.NgayTra,
            this.TongTienDichVu,
            this.TongTienThanhToan});
            this.dgv_DanhSachHoaDon.Location = new System.Drawing.Point(25, 279);
            this.dgv_DanhSachHoaDon.Name = "dgv_DanhSachHoaDon";
            this.dgv_DanhSachHoaDon.ReadOnly = true;
            this.dgv_DanhSachHoaDon.Size = new System.Drawing.Size(1148, 252);
            this.dgv_DanhSachHoaDon.TabIndex = 45;
            this.dgv_DanhSachHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhSachHoaDon_CellClick);
            // 
            // TongTienDichVu
            // 
            this.TongTienDichVu.HeaderText = "Tiền Dịch Vụ";
            this.TongTienDichVu.Name = "TongTienDichVu";
            this.TongTienDichVu.ReadOnly = true;
            // 
            // lbl_KqMaKhachHang
            // 
            this.lbl_KqMaKhachHang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_KqMaKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_KqMaKhachHang.Location = new System.Drawing.Point(240, 91);
            this.lbl_KqMaKhachHang.Name = "lbl_KqMaKhachHang";
            this.lbl_KqMaKhachHang.Size = new System.Drawing.Size(197, 22);
            this.lbl_KqMaKhachHang.TabIndex = 41;
            this.lbl_KqMaKhachHang.Text = "---";
            this.lbl_KqMaKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(69, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 17);
            this.label8.TabIndex = 37;
            this.label8.Text = "CMND/CCCD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 36;
            this.label2.Text = "Tên khách hàng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(69, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 17);
            this.label7.TabIndex = 35;
            this.label7.Text = "Số điện thoại";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "Mã hóa đơn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(524, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 50;
            this.label4.Text = "Ngày trả";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(524, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 48;
            this.label6.Text = "Ngày thuê";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(524, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 17);
            this.label9.TabIndex = 47;
            this.label9.Text = "Tiền dịch vụ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(524, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 17);
            this.label10.TabIndex = 46;
            this.label10.Text = "Mã phòng";
            // 
            // lbl_KqCCCD
            // 
            this.lbl_KqCCCD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_KqCCCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_KqCCCD.Location = new System.Drawing.Point(240, 184);
            this.lbl_KqCCCD.Name = "lbl_KqCCCD";
            this.lbl_KqCCCD.Size = new System.Drawing.Size(197, 22);
            this.lbl_KqCCCD.TabIndex = 51;
            this.lbl_KqCCCD.Text = "---";
            this.lbl_KqCCCD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_KqNgayThue
            // 
            this.lbl_KqNgayThue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_KqNgayThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_KqNgayThue.Location = new System.Drawing.Point(680, 96);
            this.lbl_KqNgayThue.Name = "lbl_KqNgayThue";
            this.lbl_KqNgayThue.Size = new System.Drawing.Size(197, 22);
            this.lbl_KqNgayThue.TabIndex = 41;
            this.lbl_KqNgayThue.Text = "---";
            this.lbl_KqNgayThue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_KqMaPhong
            // 
            this.lbl_KqMaPhong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_KqMaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_KqMaPhong.Location = new System.Drawing.Point(680, 57);
            this.lbl_KqMaPhong.Name = "lbl_KqMaPhong";
            this.lbl_KqMaPhong.Size = new System.Drawing.Size(197, 22);
            this.lbl_KqMaPhong.TabIndex = 42;
            this.lbl_KqMaPhong.Text = "---";
            this.lbl_KqMaPhong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_KqNgayTra
            // 
            this.lbl_KqNgayTra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_KqNgayTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_KqNgayTra.Location = new System.Drawing.Point(680, 140);
            this.lbl_KqNgayTra.Name = "lbl_KqNgayTra";
            this.lbl_KqNgayTra.Size = new System.Drawing.Size(197, 22);
            this.lbl_KqNgayTra.TabIndex = 43;
            this.lbl_KqNgayTra.Text = "---";
            this.lbl_KqNgayTra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_KqTienDichVu
            // 
            this.lbl_KqTienDichVu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_KqTienDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_KqTienDichVu.Location = new System.Drawing.Point(680, 186);
            this.lbl_KqTienDichVu.Name = "lbl_KqTienDichVu";
            this.lbl_KqTienDichVu.Size = new System.Drawing.Size(197, 22);
            this.lbl_KqTienDichVu.TabIndex = 44;
            this.lbl_KqTienDichVu.Text = "---";
            this.lbl_KqTienDichVu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.lbl_thanhtoan);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(955, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 138);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tổng tiền";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(74, 40);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(91, 20);
            this.label17.TabIndex = 29;
            this.label17.Text = "Thanh Toán";
            // 
            // lbl_thanhtoan
            // 
            this.lbl_thanhtoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_thanhtoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_thanhtoan.Location = new System.Drawing.Point(26, 80);
            this.lbl_thanhtoan.Name = "lbl_thanhtoan";
            this.lbl_thanhtoan.Size = new System.Drawing.Size(197, 22);
            this.lbl_thanhtoan.TabIndex = 31;
            this.lbl_thanhtoan.Text = "---";
            this.lbl_thanhtoan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 567);
            this.Controls.Add(this.tabControl1);
            this.Name = "frm_HoaDon";
            this.Text = "Hóa đơn";
            this.Load += new System.EventHandler(this.frm_HoaDon_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachHoaDon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lbl_KqSDT;
        private System.Windows.Forms.Label lbl_KetQuaMaHD;
        private System.Windows.Forms.DataGridView dgv_DanhSachHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTienDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTienThanhToan;
        private System.Windows.Forms.Label lbl_KqMaKhachHang;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lbl_thanhtoan;
        private System.Windows.Forms.Label lbl_KqCCCD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_KqTienDichVu;
        private System.Windows.Forms.Label lbl_KqNgayTra;
        private System.Windows.Forms.Label lbl_KqMaPhong;
        private System.Windows.Forms.Label lbl_KqNgayThue;
    }
}