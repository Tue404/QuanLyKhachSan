namespace QuanLyKhachSan
{
    partial class frm_ThongTinPhong
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
            this.lbl_KQTenKhachHang = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_KQCMND = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_KQDiaChi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_KQ_NgayThue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.quanLyKhachSanDataSe41 = new QuanLyKhachSan.QuanLyKhachSanDataSe4();
            this.lstv_DichVuDaSuDung = new System.Windows.Forms.ListView();
            this.grp_DichVuDaThue = new System.Windows.Forms.GroupBox();
            this.btn_ThanhToan = new System.Windows.Forms.Button();
            this.btn_DangKyDichVu = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.lbl_Phong = new System.Windows.Forms.Label();
            this.lbl_TieuDeQLThuePhong = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKhachSanDataSe41)).BeginInit();
            this.grp_DichVuDaThue.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_KQTenKhachHang
            // 
            this.lbl_KQTenKhachHang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_KQTenKhachHang.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_KQTenKhachHang.Location = new System.Drawing.Point(308, 24);
            this.lbl_KQTenKhachHang.Name = "lbl_KQTenKhachHang";
            this.lbl_KQTenKhachHang.Size = new System.Drawing.Size(192, 25);
            this.lbl_KQTenKhachHang.TabIndex = 40;
            this.lbl_KQTenKhachHang.Text = "---";
            this.lbl_KQTenKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "CMND/CCCD";
            // 
            // lbl_KQCMND
            // 
            this.lbl_KQCMND.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_KQCMND.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_KQCMND.Location = new System.Drawing.Point(308, 59);
            this.lbl_KQCMND.Name = "lbl_KQCMND";
            this.lbl_KQCMND.Size = new System.Drawing.Size(192, 25);
            this.lbl_KQCMND.TabIndex = 41;
            this.lbl_KQCMND.Text = "---";
            this.lbl_KQCMND.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(62, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Ngày thuê";
            // 
            // lbl_KQDiaChi
            // 
            this.lbl_KQDiaChi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_KQDiaChi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_KQDiaChi.Location = new System.Drawing.Point(308, 102);
            this.lbl_KQDiaChi.Name = "lbl_KQDiaChi";
            this.lbl_KQDiaChi.Size = new System.Drawing.Size(192, 25);
            this.lbl_KQDiaChi.TabIndex = 42;
            this.lbl_KQDiaChi.Text = "---";
            this.lbl_KQDiaChi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tên Khách Hàng";
            // 
            // lbl_KQ_NgayThue
            // 
            this.lbl_KQ_NgayThue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_KQ_NgayThue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_KQ_NgayThue.Location = new System.Drawing.Point(308, 146);
            this.lbl_KQ_NgayThue.Name = "lbl_KQ_NgayThue";
            this.lbl_KQ_NgayThue.Size = new System.Drawing.Size(192, 25);
            this.lbl_KQ_NgayThue.TabIndex = 43;
            this.lbl_KQ_NgayThue.Text = "---";
            this.lbl_KQ_NgayThue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Địa chỉ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbl_KQ_NgayThue);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbl_KQDiaChi);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lbl_KQCMND);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbl_KQTenKhachHang);
            this.groupBox1.Location = new System.Drawing.Point(31, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(646, 186);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // quanLyKhachSanDataSe41
            // 
            this.quanLyKhachSanDataSe41.DataSetName = "QuanLyKhachSanDataSe4";
            this.quanLyKhachSanDataSe41.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lstv_DichVuDaSuDung
            // 
            this.lstv_DichVuDaSuDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstv_DichVuDaSuDung.GridLines = true;
            this.lstv_DichVuDaSuDung.HideSelection = false;
            this.lstv_DichVuDaSuDung.Location = new System.Drawing.Point(2, 20);
            this.lstv_DichVuDaSuDung.Margin = new System.Windows.Forms.Padding(2);
            this.lstv_DichVuDaSuDung.Name = "lstv_DichVuDaSuDung";
            this.lstv_DichVuDaSuDung.Size = new System.Drawing.Size(646, 301);
            this.lstv_DichVuDaSuDung.TabIndex = 0;
            this.lstv_DichVuDaSuDung.UseCompatibleStateImageBehavior = false;
            this.lstv_DichVuDaSuDung.View = System.Windows.Forms.View.Details;
            // 
            // grp_DichVuDaThue
            // 
            this.grp_DichVuDaThue.Controls.Add(this.lstv_DichVuDaSuDung);
            this.grp_DichVuDaThue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_DichVuDaThue.Location = new System.Drawing.Point(27, 291);
            this.grp_DichVuDaThue.Margin = new System.Windows.Forms.Padding(2);
            this.grp_DichVuDaThue.Name = "grp_DichVuDaThue";
            this.grp_DichVuDaThue.Padding = new System.Windows.Forms.Padding(2);
            this.grp_DichVuDaThue.Size = new System.Drawing.Size(650, 323);
            this.grp_DichVuDaThue.TabIndex = 54;
            this.grp_DichVuDaThue.TabStop = false;
            this.grp_DichVuDaThue.Text = "Dịch vụ đã sử dụng";
            // 
            // btn_ThanhToan
            // 
            this.btn_ThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThanhToan.Location = new System.Drawing.Point(179, 642);
            this.btn_ThanhToan.Name = "btn_ThanhToan";
            this.btn_ThanhToan.Size = new System.Drawing.Size(129, 50);
            this.btn_ThanhToan.TabIndex = 55;
            this.btn_ThanhToan.Text = "Xem hóa đơn";
            this.btn_ThanhToan.UseVisualStyleBackColor = true;
            this.btn_ThanhToan.Click += new System.EventHandler(this.btn_ThanhToan_Click);
            // 
            // btn_DangKyDichVu
            // 
            this.btn_DangKyDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangKyDichVu.Location = new System.Drawing.Point(29, 642);
            this.btn_DangKyDichVu.Name = "btn_DangKyDichVu";
            this.btn_DangKyDichVu.Size = new System.Drawing.Size(129, 50);
            this.btn_DangKyDichVu.TabIndex = 56;
            this.btn_DangKyDichVu.Text = "Đăng ký dịch vụ";
            this.btn_DangKyDichVu.UseVisualStyleBackColor = true;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.Location = new System.Drawing.Point(564, 642);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(129, 50);
            this.btn_Thoat.TabIndex = 57;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // lbl_Phong
            // 
            this.lbl_Phong.AutoSize = true;
            this.lbl_Phong.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Phong.ForeColor = System.Drawing.Color.Black;
            this.lbl_Phong.Location = new System.Drawing.Point(422, 20);
            this.lbl_Phong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Phong.Name = "lbl_Phong";
            this.lbl_Phong.Size = new System.Drawing.Size(28, 30);
            this.lbl_Phong.TabIndex = 59;
            this.lbl_Phong.Text = "...";
            // 
            // lbl_TieuDeQLThuePhong
            // 
            this.lbl_TieuDeQLThuePhong.AutoSize = true;
            this.lbl_TieuDeQLThuePhong.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TieuDeQLThuePhong.ForeColor = System.Drawing.Color.Black;
            this.lbl_TieuDeQLThuePhong.Location = new System.Drawing.Point(208, 20);
            this.lbl_TieuDeQLThuePhong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_TieuDeQLThuePhong.Name = "lbl_TieuDeQLThuePhong";
            this.lbl_TieuDeQLThuePhong.Size = new System.Drawing.Size(208, 30);
            this.lbl_TieuDeQLThuePhong.TabIndex = 58;
            this.lbl_TieuDeQLThuePhong.Text = "THÔNG TIN PHÒNG:";
            // 
            // frm_ThongTinPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 714);
            this.Controls.Add(this.lbl_Phong);
            this.Controls.Add(this.lbl_TieuDeQLThuePhong);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_DangKyDichVu);
            this.Controls.Add(this.btn_ThanhToan);
            this.Controls.Add(this.grp_DichVuDaThue);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_ThongTinPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin phòng";
            this.Load += new System.EventHandler(this.frm_ThongTinPhong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKhachSanDataSe41)).EndInit();
            this.grp_DichVuDaThue.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_KQTenKhachHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_KQCMND;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_KQDiaChi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_KQ_NgayThue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private QuanLyKhachSanDataSe4 quanLyKhachSanDataSe41;
        private System.Windows.Forms.ListView lstv_DichVuDaSuDung;
        private System.Windows.Forms.GroupBox grp_DichVuDaThue;
        private System.Windows.Forms.Button btn_ThanhToan;
        private System.Windows.Forms.Button btn_DangKyDichVu;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Label lbl_Phong;
        private System.Windows.Forms.Label lbl_TieuDeQLThuePhong;
    }
}