namespace QuanLyKhachSan
{
    partial class frm_QuenMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_QuenMatKhau));
            this.pct_Anh = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_KiemTraTK = new System.Windows.Forms.Label();
            this.btn_KiemTra = new System.Windows.Forms.Button();
            this.btn_LayLaiMatKhau = new System.Windows.Forms.Button();
            this.pnl_DoiMatKhau = new System.Windows.Forms.Panel();
            this.lbl_KiemTraNLMK = new System.Windows.Forms.Label();
            this.lbl_KiemTraMKM = new System.Windows.Forms.Label();
            this.txt_NLMKM = new System.Windows.Forms.TextBox();
            this.LBL_NLMK = new System.Windows.Forms.Label();
            this.txt_MKM = new System.Windows.Forms.TextBox();
            this.lbl_MKM = new System.Windows.Forms.Label();
            this.txt_TenTK = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.KiemLoi = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pct_Anh)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.pnl_DoiMatKhau.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KiemLoi)).BeginInit();
            this.SuspendLayout();
            // 
            // pct_Anh
            // 
            this.pct_Anh.ErrorImage = null;
            this.pct_Anh.Image = ((System.Drawing.Image)(resources.GetObject("pct_Anh.Image")));
            this.pct_Anh.InitialImage = null;
            this.pct_Anh.Location = new System.Drawing.Point(119, 24);
            this.pct_Anh.Name = "pct_Anh";
            this.pct_Anh.Size = new System.Drawing.Size(249, 175);
            this.pct_Anh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pct_Anh.TabIndex = 4;
            this.pct_Anh.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_KiemTraTK);
            this.groupBox1.Controls.Add(this.btn_KiemTra);
            this.groupBox1.Controls.Add(this.btn_LayLaiMatKhau);
            this.groupBox1.Controls.Add(this.pnl_DoiMatKhau);
            this.groupBox1.Controls.Add(this.txt_TenTK);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(39, 205);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 372);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quên mật khẩu";
            // 
            // lbl_KiemTraTK
            // 
            this.lbl_KiemTraTK.AutoSize = true;
            this.lbl_KiemTraTK.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_KiemTraTK.ForeColor = System.Drawing.Color.Red;
            this.lbl_KiemTraTK.Location = new System.Drawing.Point(170, 57);
            this.lbl_KiemTraTK.Name = "lbl_KiemTraTK";
            this.lbl_KiemTraTK.Size = new System.Drawing.Size(14, 17);
            this.lbl_KiemTraTK.TabIndex = 23;
            this.lbl_KiemTraTK.Text = "*";
            this.lbl_KiemTraTK.Visible = false;
            // 
            // btn_KiemTra
            // 
            this.btn_KiemTra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_KiemTra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.btn_KiemTra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_KiemTra.FlatAppearance.BorderSize = 0;
            this.btn_KiemTra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_KiemTra.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_KiemTra.ForeColor = System.Drawing.Color.White;
            this.btn_KiemTra.Location = new System.Drawing.Point(50, 77);
            this.btn_KiemTra.Name = "btn_KiemTra";
            this.btn_KiemTra.Size = new System.Drawing.Size(303, 47);
            this.btn_KiemTra.TabIndex = 16;
            this.btn_KiemTra.Text = "Kiểm tra";
            this.btn_KiemTra.UseVisualStyleBackColor = false;
            this.btn_KiemTra.Click += new System.EventHandler(this.btn_KiemTra_Click);
            // 
            // btn_LayLaiMatKhau
            // 
            this.btn_LayLaiMatKhau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_LayLaiMatKhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.btn_LayLaiMatKhau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_LayLaiMatKhau.FlatAppearance.BorderSize = 0;
            this.btn_LayLaiMatKhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LayLaiMatKhau.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LayLaiMatKhau.ForeColor = System.Drawing.Color.White;
            this.btn_LayLaiMatKhau.Location = new System.Drawing.Point(50, 290);
            this.btn_LayLaiMatKhau.Name = "btn_LayLaiMatKhau";
            this.btn_LayLaiMatKhau.Size = new System.Drawing.Size(303, 47);
            this.btn_LayLaiMatKhau.TabIndex = 16;
            this.btn_LayLaiMatKhau.Text = "Lấy lại mật khẩu";
            this.btn_LayLaiMatKhau.UseVisualStyleBackColor = false;
            this.btn_LayLaiMatKhau.Click += new System.EventHandler(this.btn_LayLaiMatKhau_Click);
            // 
            // pnl_DoiMatKhau
            // 
            this.pnl_DoiMatKhau.Controls.Add(this.lbl_KiemTraNLMK);
            this.pnl_DoiMatKhau.Controls.Add(this.lbl_KiemTraMKM);
            this.pnl_DoiMatKhau.Controls.Add(this.txt_NLMKM);
            this.pnl_DoiMatKhau.Controls.Add(this.LBL_NLMK);
            this.pnl_DoiMatKhau.Controls.Add(this.txt_MKM);
            this.pnl_DoiMatKhau.Controls.Add(this.lbl_MKM);
            this.pnl_DoiMatKhau.Location = new System.Drawing.Point(35, 155);
            this.pnl_DoiMatKhau.Name = "pnl_DoiMatKhau";
            this.pnl_DoiMatKhau.Size = new System.Drawing.Size(355, 119);
            this.pnl_DoiMatKhau.TabIndex = 15;
            // 
            // lbl_KiemTraNLMK
            // 
            this.lbl_KiemTraNLMK.AutoSize = true;
            this.lbl_KiemTraNLMK.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_KiemTraNLMK.ForeColor = System.Drawing.Color.Red;
            this.lbl_KiemTraNLMK.Location = new System.Drawing.Point(135, 94);
            this.lbl_KiemTraNLMK.Name = "lbl_KiemTraNLMK";
            this.lbl_KiemTraNLMK.Size = new System.Drawing.Size(14, 17);
            this.lbl_KiemTraNLMK.TabIndex = 23;
            this.lbl_KiemTraNLMK.Text = "*";
            this.lbl_KiemTraNLMK.Visible = false;
            this.lbl_KiemTraNLMK.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbl_KiemTraMKM
            // 
            this.lbl_KiemTraMKM.AutoSize = true;
            this.lbl_KiemTraMKM.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_KiemTraMKM.ForeColor = System.Drawing.Color.Red;
            this.lbl_KiemTraMKM.Location = new System.Drawing.Point(135, 45);
            this.lbl_KiemTraMKM.Name = "lbl_KiemTraMKM";
            this.lbl_KiemTraMKM.Size = new System.Drawing.Size(14, 17);
            this.lbl_KiemTraMKM.TabIndex = 23;
            this.lbl_KiemTraMKM.Text = "*";
            this.lbl_KiemTraMKM.Visible = false;
            // 
            // txt_NLMKM
            // 
            this.txt_NLMKM.Location = new System.Drawing.Point(138, 74);
            this.txt_NLMKM.Name = "txt_NLMKM";
            this.txt_NLMKM.Size = new System.Drawing.Size(180, 20);
            this.txt_NLMKM.TabIndex = 17;
            // 
            // LBL_NLMK
            // 
            this.LBL_NLMK.AutoSize = true;
            this.LBL_NLMK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_NLMK.ForeColor = System.Drawing.Color.Blue;
            this.LBL_NLMK.Location = new System.Drawing.Point(13, 73);
            this.LBL_NLMK.Name = "LBL_NLMK";
            this.LBL_NLMK.Size = new System.Drawing.Size(119, 19);
            this.LBL_NLMK.TabIndex = 15;
            this.LBL_NLMK.Text = "Nhập lại mật khẩu";
            // 
            // txt_MKM
            // 
            this.txt_MKM.Location = new System.Drawing.Point(138, 22);
            this.txt_MKM.Name = "txt_MKM";
            this.txt_MKM.Size = new System.Drawing.Size(180, 20);
            this.txt_MKM.TabIndex = 18;
            // 
            // lbl_MKM
            // 
            this.lbl_MKM.AutoSize = true;
            this.lbl_MKM.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MKM.ForeColor = System.Drawing.Color.Blue;
            this.lbl_MKM.Location = new System.Drawing.Point(13, 21);
            this.lbl_MKM.Name = "lbl_MKM";
            this.lbl_MKM.Size = new System.Drawing.Size(93, 19);
            this.lbl_MKM.TabIndex = 16;
            this.lbl_MKM.Text = "Mật khẩu mới";
            // 
            // txt_TenTK
            // 
            this.txt_TenTK.Location = new System.Drawing.Point(173, 34);
            this.txt_TenTK.Name = "txt_TenTK";
            this.txt_TenTK.Size = new System.Drawing.Size(180, 20);
            this.txt_TenTK.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(48, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tên tài khoản";
            // 
            // KiemLoi
            // 
            this.KiemLoi.ContainerControl = this;
            // 
            // frm_QuenMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 647);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pct_Anh);
            this.Name = "frm_QuenMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quên Mât Khẩu";
            ((System.ComponentModel.ISupportInitialize)(this.pct_Anh)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnl_DoiMatKhau.ResumeLayout(false);
            this.pnl_DoiMatKhau.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KiemLoi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pct_Anh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_TenTK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_KiemTra;
        private System.Windows.Forms.Button btn_LayLaiMatKhau;
        private System.Windows.Forms.Panel pnl_DoiMatKhau;
        private System.Windows.Forms.TextBox txt_NLMKM;
        private System.Windows.Forms.Label LBL_NLMK;
        private System.Windows.Forms.TextBox txt_MKM;
        private System.Windows.Forms.Label lbl_MKM;
        private System.Windows.Forms.Label lbl_KiemTraTK;
        private System.Windows.Forms.ErrorProvider KiemLoi;
        private System.Windows.Forms.Label lbl_KiemTraNLMK;
        private System.Windows.Forms.Label lbl_KiemTraMKM;
    }
}