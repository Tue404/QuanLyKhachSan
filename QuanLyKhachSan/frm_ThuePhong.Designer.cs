namespace QuanLyKhachSan
{
    partial class frm_ThuePhong
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
            this.tabControl_ThuePhong = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl_ThongTin = new System.Windows.Forms.TabControl();
            this.tabPage_ChiTiet = new System.Windows.Forms.TabPage();
            this.lsv_phongchon = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.lstv_ChiTiet = new System.Windows.Forms.ListView();
            this.ThongTin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GiaTri = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbo_MaKhachHang = new System.Windows.Forms.ComboBox();
            this.dtp_NgayThue = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_ThuePhong = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_PhongTrong = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgv_DanhSachKhachDaThue = new System.Windows.Forms.DataGridView();
            this.tabControl_ThuePhong.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl_ThongTin.SuspendLayout();
            this.tabPage_ChiTiet.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PhongTrong)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachKhachDaThue)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl_ThuePhong
            // 
            this.tabControl_ThuePhong.Controls.Add(this.tabPage1);
            this.tabControl_ThuePhong.Controls.Add(this.tabPage2);
            this.tabControl_ThuePhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl_ThuePhong.Location = new System.Drawing.Point(1, 4);
            this.tabControl_ThuePhong.Name = "tabControl_ThuePhong";
            this.tabControl_ThuePhong.SelectedIndex = 0;
            this.tabControl_ThuePhong.Size = new System.Drawing.Size(1261, 596);
            this.tabControl_ThuePhong.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tabControl_ThongTin);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btn_ThuePhong);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1253, 567);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thuê Phòng";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl_ThongTin
            // 
            this.tabControl_ThongTin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControl_ThongTin.Controls.Add(this.tabPage_ChiTiet);
            this.tabControl_ThongTin.Location = new System.Drawing.Point(530, 51);
            this.tabControl_ThongTin.Name = "tabControl_ThongTin";
            this.tabControl_ThongTin.SelectedIndex = 0;
            this.tabControl_ThongTin.Size = new System.Drawing.Size(557, 462);
            this.tabControl_ThongTin.TabIndex = 40;
            // 
            // tabPage_ChiTiet
            // 
            this.tabPage_ChiTiet.BackColor = System.Drawing.Color.White;
            this.tabPage_ChiTiet.Controls.Add(this.lsv_phongchon);
            this.tabPage_ChiTiet.Controls.Add(this.label2);
            this.tabPage_ChiTiet.Controls.Add(this.lstv_ChiTiet);
            this.tabPage_ChiTiet.Location = new System.Drawing.Point(4, 25);
            this.tabPage_ChiTiet.Name = "tabPage_ChiTiet";
            this.tabPage_ChiTiet.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_ChiTiet.Size = new System.Drawing.Size(549, 433);
            this.tabPage_ChiTiet.TabIndex = 0;
            this.tabPage_ChiTiet.Text = "Chi tiết";
            // 
            // lsv_phongchon
            // 
            this.lsv_phongchon.BackColor = System.Drawing.Color.White;
            this.lsv_phongchon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lsv_phongchon.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsv_phongchon.FullRowSelect = true;
            this.lsv_phongchon.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lsv_phongchon.HideSelection = false;
            this.lsv_phongchon.Location = new System.Drawing.Point(6, 295);
            this.lsv_phongchon.MultiSelect = false;
            this.lsv_phongchon.Name = "lsv_phongchon";
            this.lsv_phongchon.Scrollable = false;
            this.lsv_phongchon.Size = new System.Drawing.Size(537, 135);
            this.lsv_phongchon.TabIndex = 3;
            this.lsv_phongchon.UseCompatibleStateImageBehavior = false;
            this.lsv_phongchon.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Thông tin";
            this.columnHeader1.Width = 180;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Giá trị";
            this.columnHeader2.Width = 464;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Phòng đã chọn";
            // 
            // lstv_ChiTiet
            // 
            this.lstv_ChiTiet.BackColor = System.Drawing.Color.White;
            this.lstv_ChiTiet.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ThongTin,
            this.GiaTri});
            this.lstv_ChiTiet.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstv_ChiTiet.FullRowSelect = true;
            this.lstv_ChiTiet.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lstv_ChiTiet.HideSelection = false;
            this.lstv_ChiTiet.Location = new System.Drawing.Point(6, 6);
            this.lstv_ChiTiet.MultiSelect = false;
            this.lstv_ChiTiet.Name = "lstv_ChiTiet";
            this.lstv_ChiTiet.Scrollable = false;
            this.lstv_ChiTiet.Size = new System.Drawing.Size(537, 266);
            this.lstv_ChiTiet.TabIndex = 0;
            this.lstv_ChiTiet.UseCompatibleStateImageBehavior = false;
            this.lstv_ChiTiet.View = System.Windows.Forms.View.Details;
            this.lstv_ChiTiet.SelectedIndexChanged += new System.EventHandler(this.lstv_ChiTiet_SelectedIndexChanged);
            // 
            // ThongTin
            // 
            this.ThongTin.Text = "Thông tin";
            this.ThongTin.Width = 500;
            // 
            // GiaTri
            // 
            this.GiaTri.Text = "Giá trị";
            this.GiaTri.Width = 464;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbo_MaKhachHang);
            this.groupBox1.Controls.Add(this.dtp_NgayThue);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(20, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 171);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thuê phòng";
            // 
            // cbo_MaKhachHang
            // 
            this.cbo_MaKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_MaKhachHang.FormattingEnabled = true;
            this.cbo_MaKhachHang.Location = new System.Drawing.Point(145, 55);
            this.cbo_MaKhachHang.Name = "cbo_MaKhachHang";
            this.cbo_MaKhachHang.Size = new System.Drawing.Size(205, 24);
            this.cbo_MaKhachHang.TabIndex = 32;
            this.cbo_MaKhachHang.SelectedIndexChanged += new System.EventHandler(this.cbo_MaKhachHang_SelectedIndexChanged);
            // 
            // dtp_NgayThue
            // 
            this.dtp_NgayThue.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_NgayThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_NgayThue.Location = new System.Drawing.Point(145, 112);
            this.dtp_NgayThue.Name = "dtp_NgayThue";
            this.dtp_NgayThue.Size = new System.Drawing.Size(205, 23);
            this.dtp_NgayThue.TabIndex = 31;
            this.dtp_NgayThue.VisibleChanged += new System.EventHandler(this.dpt_NgayThue_VisibleChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Ngày Thuê";
            // 
            // btn_ThuePhong
            // 
            this.btn_ThuePhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThuePhong.Location = new System.Drawing.Point(1106, 217);
            this.btn_ThuePhong.Name = "btn_ThuePhong";
            this.btn_ThuePhong.Size = new System.Drawing.Size(129, 50);
            this.btn_ThuePhong.TabIndex = 35;
            this.btn_ThuePhong.Text = "Thuê Phòng";
            this.btn_ThuePhong.UseVisualStyleBackColor = true;
            this.btn_ThuePhong.Click += new System.EventHandler(this.btn_ThuePhong_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(464, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 29);
            this.label4.TabIndex = 36;
            this.label4.Text = "Thuê phòng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_PhongTrong);
            this.groupBox2.Location = new System.Drawing.Point(20, 217);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(417, 253);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách phòng trống";
            // 
            // dgv_PhongTrong
            // 
            this.dgv_PhongTrong.AllowUserToAddRows = false;
            this.dgv_PhongTrong.AllowUserToDeleteRows = false;
            this.dgv_PhongTrong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_PhongTrong.BackgroundColor = System.Drawing.Color.White;
            this.dgv_PhongTrong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PhongTrong.Location = new System.Drawing.Point(0, 22);
            this.dgv_PhongTrong.Name = "dgv_PhongTrong";
            this.dgv_PhongTrong.ReadOnly = true;
            this.dgv_PhongTrong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_PhongTrong.Size = new System.Drawing.Size(411, 225);
            this.dgv_PhongTrong.TabIndex = 1;
            this.dgv_PhongTrong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_PhongTrong_CellClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgv_DanhSachKhachDaThue);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1253, 567);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Danh sách phòng đã thuê";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgv_DanhSachKhachDaThue
            // 
            this.dgv_DanhSachKhachDaThue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DanhSachKhachDaThue.BackgroundColor = System.Drawing.Color.White;
            this.dgv_DanhSachKhachDaThue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachKhachDaThue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_DanhSachKhachDaThue.Location = new System.Drawing.Point(3, 3);
            this.dgv_DanhSachKhachDaThue.Name = "dgv_DanhSachKhachDaThue";
            this.dgv_DanhSachKhachDaThue.Size = new System.Drawing.Size(1247, 561);
            this.dgv_DanhSachKhachDaThue.TabIndex = 1;
            // 
            // frm_ThuePhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 596);
            this.Controls.Add(this.tabControl_ThuePhong);
            this.Name = "frm_ThuePhong";
            this.Text = "Thuê phòng";
            this.Load += new System.EventHandler(this.frm_ThuePhong_Load);
            this.tabControl_ThuePhong.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl_ThongTin.ResumeLayout(false);
            this.tabPage_ChiTiet.ResumeLayout(false);
            this.tabPage_ChiTiet.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PhongTrong)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachKhachDaThue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_ThuePhong;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl_ThongTin;
        private System.Windows.Forms.TabPage tabPage_ChiTiet;
        private System.Windows.Forms.ListView lsv_phongchon;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lstv_ChiTiet;
        private System.Windows.Forms.ColumnHeader ThongTin;
        private System.Windows.Forms.ColumnHeader GiaTri;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbo_MaKhachHang;
        private System.Windows.Forms.DateTimePicker dtp_NgayThue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_PhongTrong;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgv_DanhSachKhachDaThue;
        private System.Windows.Forms.Button btn_ThuePhong;
    }
}