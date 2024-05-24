namespace QuanLyKhachSan
{
    partial class frm_Phong
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgv_phong2 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_TimPhong = new System.Windows.Forms.TextBox();
            this.txt_TimLoaiPhong = new System.Windows.Forms.TextBox();
            this.txt_TimTinhTrang = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgv_phong3 = new System.Windows.Forms.DataGridView();
            this.lbl_KQTinhTrang = new System.Windows.Forms.Label();
            this.lbl_KQPhong = new System.Windows.Forms.Label();
            this.cbo_LoaiPhongSua = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_DonGiaSua = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phong2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phong3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1137, 578);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgv_phong2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1129, 550);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tìm phòng";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgv_phong2
            // 
            this.dgv_phong2.AllowUserToAddRows = false;
            this.dgv_phong2.AllowUserToDeleteRows = false;
            this.dgv_phong2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_phong2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_phong2.BackgroundColor = System.Drawing.Color.White;
            this.dgv_phong2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_phong2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_phong2.Location = new System.Drawing.Point(398, 55);
            this.dgv_phong2.Name = "dgv_phong2";
            this.dgv_phong2.Size = new System.Drawing.Size(681, 252);
            this.dgv_phong2.TabIndex = 105;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_TimPhong);
            this.groupBox1.Controls.Add(this.txt_TimLoaiPhong);
            this.groupBox1.Controls.Add(this.txt_TimTinhTrang);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(28, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 182);
            this.groupBox1.TabIndex = 104;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Loại phòng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Mã phòng";
            // 
            // txt_TimPhong
            // 
            this.txt_TimPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TimPhong.Location = new System.Drawing.Point(130, 43);
            this.txt_TimPhong.Name = "txt_TimPhong";
            this.txt_TimPhong.Size = new System.Drawing.Size(151, 23);
            this.txt_TimPhong.TabIndex = 21;
            // 
            // txt_TimLoaiPhong
            // 
            this.txt_TimLoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TimLoaiPhong.Location = new System.Drawing.Point(130, 82);
            this.txt_TimLoaiPhong.Name = "txt_TimLoaiPhong";
            this.txt_TimLoaiPhong.Size = new System.Drawing.Size(151, 23);
            this.txt_TimLoaiPhong.TabIndex = 25;
            // 
            // txt_TimTinhTrang
            // 
            this.txt_TimTinhTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TimTinhTrang.Location = new System.Drawing.Point(130, 122);
            this.txt_TimTinhTrang.Name = "txt_TimTinhTrang";
            this.txt_TimTinhTrang.Size = new System.Drawing.Size(151, 23);
            this.txt_TimTinhTrang.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Tình trạng";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgv_phong3);
            this.tabPage2.Controls.Add(this.lbl_KQTinhTrang);
            this.tabPage2.Controls.Add(this.lbl_KQPhong);
            this.tabPage2.Controls.Add(this.cbo_LoaiPhongSua);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txt_DonGiaSua);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.btn_Sua);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1129, 550);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sửa phòng";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgv_phong3
            // 
            this.dgv_phong3.AllowUserToAddRows = false;
            this.dgv_phong3.AllowUserToDeleteRows = false;
            this.dgv_phong3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_phong3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_phong3.BackgroundColor = System.Drawing.Color.White;
            this.dgv_phong3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_phong3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_phong3.Location = new System.Drawing.Point(342, 51);
            this.dgv_phong3.Name = "dgv_phong3";
            this.dgv_phong3.ReadOnly = true;
            this.dgv_phong3.Size = new System.Drawing.Size(762, 267);
            this.dgv_phong3.TabIndex = 121;
            this.dgv_phong3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_phong3_CellClick);
            // 
            // lbl_KQTinhTrang
            // 
            this.lbl_KQTinhTrang.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_KQTinhTrang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_KQTinhTrang.Location = new System.Drawing.Point(146, 184);
            this.lbl_KQTinhTrang.Name = "lbl_KQTinhTrang";
            this.lbl_KQTinhTrang.Size = new System.Drawing.Size(150, 25);
            this.lbl_KQTinhTrang.TabIndex = 120;
            this.lbl_KQTinhTrang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_KQPhong
            // 
            this.lbl_KQPhong.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_KQPhong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_KQPhong.Location = new System.Drawing.Point(145, 100);
            this.lbl_KQPhong.Name = "lbl_KQPhong";
            this.lbl_KQPhong.Size = new System.Drawing.Size(151, 27);
            this.lbl_KQPhong.TabIndex = 119;
            this.lbl_KQPhong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbo_LoaiPhongSua
            // 
            this.cbo_LoaiPhongSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_LoaiPhongSua.FormattingEnabled = true;
            this.cbo_LoaiPhongSua.Location = new System.Drawing.Point(145, 144);
            this.cbo_LoaiPhongSua.Name = "cbo_LoaiPhongSua";
            this.cbo_LoaiPhongSua.Size = new System.Drawing.Size(151, 24);
            this.cbo_LoaiPhongSua.TabIndex = 118;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(35, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 17);
            this.label8.TabIndex = 116;
            this.label8.Text = "Loại phòng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 113;
            this.label6.Text = "Mã phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 114;
            this.label3.Text = "Tình trạng";
            // 
            // txt_DonGiaSua
            // 
            this.txt_DonGiaSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DonGiaSua.Location = new System.Drawing.Point(146, 223);
            this.txt_DonGiaSua.Name = "txt_DonGiaSua";
            this.txt_DonGiaSua.Size = new System.Drawing.Size(151, 23);
            this.txt_DonGiaSua.TabIndex = 117;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(35, 223);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 17);
            this.label9.TabIndex = 115;
            this.label9.Text = "Đơn giá";
            // 
            // btn_Sua
            // 
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.Location = new System.Drawing.Point(623, 373);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(114, 42);
            this.btn_Sua.TabIndex = 111;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click_1);
            // 
            // frm_Phong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 577);
            this.Controls.Add(this.tabControl1);
            this.Name = "frm_Phong";
            this.Text = "Phòng";
            this.Load += new System.EventHandler(this.frm_Phong_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phong2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phong3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgv_phong2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_TimPhong;
        private System.Windows.Forms.TextBox txt_TimLoaiPhong;
        private System.Windows.Forms.TextBox txt_TimTinhTrang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgv_phong3;
        private System.Windows.Forms.Label lbl_KQTinhTrang;
        private System.Windows.Forms.Label lbl_KQPhong;
        private System.Windows.Forms.ComboBox cbo_LoaiPhongSua;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_DonGiaSua;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_Sua;
    }
}