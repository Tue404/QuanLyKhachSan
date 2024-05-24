namespace QuanLyKhachSan
{
    partial class frm_DoiMatKhau
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
            this.lbl_DoiMatKhau = new System.Windows.Forms.Label();
            this.lbl_TK = new System.Windows.Forms.Label();
            this.txt_TenTaiKhoan = new System.Windows.Forms.TextBox();
            this.lbl_MK = new System.Windows.Forms.Label();
            this.txt_MatKhauMoi = new System.Windows.Forms.TextBox();
            this.lbl_Matkhaucu = new System.Windows.Forms.Label();
            this.txt_MatKhauCu = new System.Windows.Forms.TextBox();
            this.pnl_DoiMK = new System.Windows.Forms.Panel();
            this.btn_DMK = new System.Windows.Forms.Button();
            this.txt_NhapLaiMK = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_MKC = new System.Windows.Forms.Label();
            this.lbl_MKM = new System.Windows.Forms.Label();
            this.LBL_NLMKM = new System.Windows.Forms.Label();
            this.pnl_DoiMK.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_DoiMatKhau
            // 
            this.lbl_DoiMatKhau.AutoSize = true;
            this.lbl_DoiMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DoiMatKhau.Location = new System.Drawing.Point(99, 24);
            this.lbl_DoiMatKhau.Name = "lbl_DoiMatKhau";
            this.lbl_DoiMatKhau.Size = new System.Drawing.Size(185, 31);
            this.lbl_DoiMatKhau.TabIndex = 0;
            this.lbl_DoiMatKhau.Text = "Đổi mật khẩu";
            this.lbl_DoiMatKhau.Click += new System.EventHandler(this.lbl_DoiMatKhau_Click);
            // 
            // lbl_TK
            // 
            this.lbl_TK.AutoSize = true;
            this.lbl_TK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TK.Location = new System.Drawing.Point(27, 27);
            this.lbl_TK.Name = "lbl_TK";
            this.lbl_TK.Size = new System.Drawing.Size(78, 20);
            this.lbl_TK.TabIndex = 0;
            this.lbl_TK.Text = "Tài khoản";
            this.lbl_TK.Click += new System.EventHandler(this.lbl_TK_Click);
            // 
            // txt_TenTaiKhoan
            // 
            this.txt_TenTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenTaiKhoan.Location = new System.Drawing.Point(169, 27);
            this.txt_TenTaiKhoan.Name = "txt_TenTaiKhoan";
            this.txt_TenTaiKhoan.Size = new System.Drawing.Size(172, 26);
            this.txt_TenTaiKhoan.TabIndex = 1;
            this.txt_TenTaiKhoan.TextChanged += new System.EventHandler(this.txt_TenTaiKhoan_TextChanged);
            // 
            // lbl_MK
            // 
            this.lbl_MK.AutoSize = true;
            this.lbl_MK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MK.Location = new System.Drawing.Point(27, 134);
            this.lbl_MK.Name = "lbl_MK";
            this.lbl_MK.Size = new System.Drawing.Size(104, 20);
            this.lbl_MK.TabIndex = 0;
            this.lbl_MK.Text = "Mật khẩu mới";
            this.lbl_MK.Click += new System.EventHandler(this.lbl_MK_Click);
            // 
            // txt_MatKhauMoi
            // 
            this.txt_MatKhauMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MatKhauMoi.Location = new System.Drawing.Point(169, 134);
            this.txt_MatKhauMoi.Name = "txt_MatKhauMoi";
            this.txt_MatKhauMoi.Size = new System.Drawing.Size(172, 26);
            this.txt_MatKhauMoi.TabIndex = 1;
            this.txt_MatKhauMoi.TextChanged += new System.EventHandler(this.txt_MatKhauMoi_TextChanged);
            // 
            // lbl_Matkhaucu
            // 
            this.lbl_Matkhaucu.AutoSize = true;
            this.lbl_Matkhaucu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Matkhaucu.Location = new System.Drawing.Point(27, 82);
            this.lbl_Matkhaucu.Name = "lbl_Matkhaucu";
            this.lbl_Matkhaucu.Size = new System.Drawing.Size(96, 20);
            this.lbl_Matkhaucu.TabIndex = 0;
            this.lbl_Matkhaucu.Text = "Mật khẩu cũ";
            this.lbl_Matkhaucu.Click += new System.EventHandler(this.lbl_Matkhaucu_Click);
            // 
            // txt_MatKhauCu
            // 
            this.txt_MatKhauCu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MatKhauCu.Location = new System.Drawing.Point(169, 82);
            this.txt_MatKhauCu.Name = "txt_MatKhauCu";
            this.txt_MatKhauCu.Size = new System.Drawing.Size(172, 26);
            this.txt_MatKhauCu.TabIndex = 1;
            this.txt_MatKhauCu.TextChanged += new System.EventHandler(this.txt_MatKhauCu_TextChanged);
            // 
            // pnl_DoiMK
            // 
            this.pnl_DoiMK.Controls.Add(this.LBL_NLMKM);
            this.pnl_DoiMK.Controls.Add(this.lbl_MKM);
            this.pnl_DoiMK.Controls.Add(this.lbl_MKC);
            this.pnl_DoiMK.Controls.Add(this.btn_DMK);
            this.pnl_DoiMK.Controls.Add(this.txt_MatKhauCu);
            this.pnl_DoiMK.Controls.Add(this.lbl_Matkhaucu);
            this.pnl_DoiMK.Controls.Add(this.txt_NhapLaiMK);
            this.pnl_DoiMK.Controls.Add(this.label1);
            this.pnl_DoiMK.Controls.Add(this.txt_MatKhauMoi);
            this.pnl_DoiMK.Controls.Add(this.lbl_MK);
            this.pnl_DoiMK.Controls.Add(this.txt_TenTaiKhoan);
            this.pnl_DoiMK.Controls.Add(this.lbl_TK);
            this.pnl_DoiMK.Location = new System.Drawing.Point(12, 71);
            this.pnl_DoiMK.Name = "pnl_DoiMK";
            this.pnl_DoiMK.Size = new System.Drawing.Size(361, 354);
            this.pnl_DoiMK.TabIndex = 1;
            this.pnl_DoiMK.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_DoiMK_Paint);
            // 
            // btn_DMK
            // 
            this.btn_DMK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_DMK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.btn_DMK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DMK.FlatAppearance.BorderSize = 0;
            this.btn_DMK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DMK.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DMK.ForeColor = System.Drawing.Color.White;
            this.btn_DMK.Location = new System.Drawing.Point(93, 255);
            this.btn_DMK.Name = "btn_DMK";
            this.btn_DMK.Size = new System.Drawing.Size(147, 43);
            this.btn_DMK.TabIndex = 42;
            this.btn_DMK.Text = "Đổi mật khẩu";
            this.btn_DMK.UseVisualStyleBackColor = false;
            this.btn_DMK.Click += new System.EventHandler(this.btn_DMK_Click);
            // 
            // txt_NhapLaiMK
            // 
            this.txt_NhapLaiMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NhapLaiMK.Location = new System.Drawing.Point(169, 188);
            this.txt_NhapLaiMK.Name = "txt_NhapLaiMK";
            this.txt_NhapLaiMK.Size = new System.Drawing.Size(172, 26);
            this.txt_NhapLaiMK.TabIndex = 1;
            this.txt_NhapLaiMK.TextChanged += new System.EventHandler(this.txt_MatKhauMoi_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập lại mật khẩu";
            this.label1.Click += new System.EventHandler(this.lbl_MK_Click);
            // 
            // lbl_MKC
            // 
            this.lbl_MKC.AutoSize = true;
            this.lbl_MKC.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MKC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_MKC.Location = new System.Drawing.Point(166, 114);
            this.lbl_MKC.Name = "lbl_MKC";
            this.lbl_MKC.Size = new System.Drawing.Size(13, 17);
            this.lbl_MKC.TabIndex = 46;
            this.lbl_MKC.Text = "*";
            this.lbl_MKC.Visible = false;
            // 
            // lbl_MKM
            // 
            this.lbl_MKM.AutoSize = true;
            this.lbl_MKM.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MKM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_MKM.Location = new System.Drawing.Point(166, 163);
            this.lbl_MKM.Name = "lbl_MKM";
            this.lbl_MKM.Size = new System.Drawing.Size(13, 17);
            this.lbl_MKM.TabIndex = 46;
            this.lbl_MKM.Text = "*";
            this.lbl_MKM.Visible = false;
            // 
            // LBL_NLMKM
            // 
            this.LBL_NLMKM.AutoSize = true;
            this.LBL_NLMKM.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_NLMKM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LBL_NLMKM.Location = new System.Drawing.Point(166, 217);
            this.LBL_NLMKM.Name = "LBL_NLMKM";
            this.LBL_NLMKM.Size = new System.Drawing.Size(13, 17);
            this.LBL_NLMKM.TabIndex = 46;
            this.LBL_NLMKM.Text = "*";
            this.LBL_NLMKM.Visible = false;
            // 
            // frm_DoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 455);
            this.Controls.Add(this.pnl_DoiMK);
            this.Controls.Add(this.lbl_DoiMatKhau);
            this.Name = "frm_DoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            this.Load += new System.EventHandler(this.frm_DoiMatKhau_Load);
            this.pnl_DoiMK.ResumeLayout(false);
            this.pnl_DoiMK.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_DoiMatKhau;
        private System.Windows.Forms.Label lbl_TK;
        private System.Windows.Forms.TextBox txt_TenTaiKhoan;
        private System.Windows.Forms.Label lbl_MK;
        private System.Windows.Forms.TextBox txt_MatKhauMoi;
        private System.Windows.Forms.Label lbl_Matkhaucu;
        private System.Windows.Forms.TextBox txt_MatKhauCu;
        private System.Windows.Forms.Panel pnl_DoiMK;
        private System.Windows.Forms.Button btn_DMK;
        private System.Windows.Forms.TextBox txt_NhapLaiMK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LBL_NLMKM;
        private System.Windows.Forms.Label lbl_MKM;
        private System.Windows.Forms.Label lbl_MKC;
    }
}