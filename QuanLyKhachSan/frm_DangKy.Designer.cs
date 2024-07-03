namespace QuanLyKhachSan
{
    partial class frm_DangKy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DangKy));
            this.txt_MatKhau = new System.Windows.Forms.TextBox();
            this.txt_TaiKhoan = new System.Windows.Forms.TextBox();
            this.lbl_mk = new System.Windows.Forms.Label();
            this.lbl_TenTk = new System.Windows.Forms.Label();
            this.lbl_CCCD = new System.Windows.Forms.Label();
            this.txt_CCCD = new System.Windows.Forms.TextBox();
            this.CheckError = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbl_KiemTraCCCD = new System.Windows.Forms.Label();
            this.lbl_KiemTraTK = new System.Windows.Forms.Label();
            this.lbl_KiemTraMK = new System.Windows.Forms.Label();
            this.btn_DangKy = new System.Windows.Forms.Button();
            this.btn_DangNhap = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CheckError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_MatKhau
            // 
            this.txt_MatKhau.Location = new System.Drawing.Point(210, 383);
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.Size = new System.Drawing.Size(180, 20);
            this.txt_MatKhau.TabIndex = 9;
            this.txt_MatKhau.UseSystemPasswordChar = true;
            // 
            // txt_TaiKhoan
            // 
            this.txt_TaiKhoan.Location = new System.Drawing.Point(210, 323);
            this.txt_TaiKhoan.Name = "txt_TaiKhoan";
            this.txt_TaiKhoan.Size = new System.Drawing.Size(180, 20);
            this.txt_TaiKhoan.TabIndex = 10;
            // 
            // lbl_mk
            // 
            this.lbl_mk.AutoSize = true;
            this.lbl_mk.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mk.ForeColor = System.Drawing.Color.Blue;
            this.lbl_mk.Location = new System.Drawing.Point(85, 382);
            this.lbl_mk.Name = "lbl_mk";
            this.lbl_mk.Size = new System.Drawing.Size(67, 19);
            this.lbl_mk.TabIndex = 6;
            this.lbl_mk.Text = "Mật khẩu";
            // 
            // lbl_TenTk
            // 
            this.lbl_TenTk.AutoSize = true;
            this.lbl_TenTk.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenTk.ForeColor = System.Drawing.Color.Blue;
            this.lbl_TenTk.Location = new System.Drawing.Point(85, 322);
            this.lbl_TenTk.Name = "lbl_TenTk";
            this.lbl_TenTk.Size = new System.Drawing.Size(91, 19);
            this.lbl_TenTk.TabIndex = 7;
            this.lbl_TenTk.Text = "Tên tài khoản";
            // 
            // lbl_CCCD
            // 
            this.lbl_CCCD.AutoSize = true;
            this.lbl_CCCD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CCCD.ForeColor = System.Drawing.Color.Blue;
            this.lbl_CCCD.Location = new System.Drawing.Point(85, 262);
            this.lbl_CCCD.Name = "lbl_CCCD";
            this.lbl_CCCD.Size = new System.Drawing.Size(53, 19);
            this.lbl_CCCD.TabIndex = 5;
            this.lbl_CCCD.Text = "CCCD";
            // 
            // txt_CCCD
            // 
            this.txt_CCCD.Location = new System.Drawing.Point(210, 261);
            this.txt_CCCD.Name = "txt_CCCD";
            this.txt_CCCD.Size = new System.Drawing.Size(180, 20);
            this.txt_CCCD.TabIndex = 8;
            // 
            // CheckError
            // 
            this.CheckError.ContainerControl = this;
            // 
            // lbl_KiemTraCCCD
            // 
            this.lbl_KiemTraCCCD.AutoSize = true;
            this.lbl_KiemTraCCCD.ForeColor = System.Drawing.Color.Red;
            this.lbl_KiemTraCCCD.Location = new System.Drawing.Point(210, 288);
            this.lbl_KiemTraCCCD.Name = "lbl_KiemTraCCCD";
            this.lbl_KiemTraCCCD.Size = new System.Drawing.Size(11, 13);
            this.lbl_KiemTraCCCD.TabIndex = 12;
            this.lbl_KiemTraCCCD.Text = "*";
            // 
            // lbl_KiemTraTK
            // 
            this.lbl_KiemTraTK.AutoSize = true;
            this.lbl_KiemTraTK.ForeColor = System.Drawing.Color.Red;
            this.lbl_KiemTraTK.Location = new System.Drawing.Point(210, 346);
            this.lbl_KiemTraTK.Name = "lbl_KiemTraTK";
            this.lbl_KiemTraTK.Size = new System.Drawing.Size(11, 13);
            this.lbl_KiemTraTK.TabIndex = 12;
            this.lbl_KiemTraTK.Text = "*";
            // 
            // lbl_KiemTraMK
            // 
            this.lbl_KiemTraMK.AutoSize = true;
            this.lbl_KiemTraMK.ForeColor = System.Drawing.Color.Red;
            this.lbl_KiemTraMK.Location = new System.Drawing.Point(210, 406);
            this.lbl_KiemTraMK.Name = "lbl_KiemTraMK";
            this.lbl_KiemTraMK.Size = new System.Drawing.Size(11, 13);
            this.lbl_KiemTraMK.TabIndex = 12;
            this.lbl_KiemTraMK.Text = "*";
            // 
            // btn_DangKy
            // 
            this.btn_DangKy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_DangKy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.btn_DangKy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DangKy.FlatAppearance.BorderSize = 0;
            this.btn_DangKy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DangKy.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangKy.ForeColor = System.Drawing.Color.White;
            this.btn_DangKy.Location = new System.Drawing.Point(94, 450);
            this.btn_DangKy.Name = "btn_DangKy";
            this.btn_DangKy.Size = new System.Drawing.Size(296, 47);
            this.btn_DangKy.TabIndex = 13;
            this.btn_DangKy.Text = "Đăng Ký";
            this.btn_DangKy.UseVisualStyleBackColor = false;
            this.btn_DangKy.Click += new System.EventHandler(this.btn_DangKy_Click);
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_DangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DangNhap.FlatAppearance.BorderSize = 0;
            this.btn_DangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DangNhap.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangNhap.ForeColor = System.Drawing.Color.White;
            this.btn_DangNhap.Location = new System.Drawing.Point(94, 530);
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.Size = new System.Drawing.Size(296, 47);
            this.btn_DangNhap.TabIndex = 13;
            this.btn_DangNhap.Text = "Đăng nhập";
            this.btn_DangNhap.UseVisualStyleBackColor = false;
            this.btn_DangNhap.Click += new System.EventHandler(this.btn_DangNhap_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(107, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 185);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // frm_DangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 608);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_DangNhap);
            this.Controls.Add(this.btn_DangKy);
            this.Controls.Add(this.lbl_KiemTraMK);
            this.Controls.Add(this.lbl_KiemTraTK);
            this.Controls.Add(this.lbl_KiemTraCCCD);
            this.Controls.Add(this.txt_CCCD);
            this.Controls.Add(this.lbl_CCCD);
            this.Controls.Add(this.txt_MatKhau);
            this.Controls.Add(this.txt_TaiKhoan);
            this.Controls.Add(this.lbl_mk);
            this.Controls.Add(this.lbl_TenTk);
            this.Name = "frm_DangKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Ký";
            ((System.ComponentModel.ISupportInitialize)(this.CheckError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_MatKhau;
        private System.Windows.Forms.TextBox txt_TaiKhoan;
        private System.Windows.Forms.Label lbl_mk;
        private System.Windows.Forms.Label lbl_TenTk;
        private System.Windows.Forms.Label lbl_CCCD;
        private System.Windows.Forms.TextBox txt_CCCD;
        private System.Windows.Forms.ErrorProvider CheckError;
        private System.Windows.Forms.Label lbl_KiemTraMK;
        private System.Windows.Forms.Label lbl_KiemTraTK;
        private System.Windows.Forms.Label lbl_KiemTraCCCD;
        private System.Windows.Forms.Button btn_DangKy;
        private System.Windows.Forms.Button btn_DangNhap;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}