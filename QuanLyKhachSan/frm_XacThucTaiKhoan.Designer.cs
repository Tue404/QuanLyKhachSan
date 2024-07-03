namespace QuanLyKhachSan
{
    partial class frm_XacThucTaiKhoan
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
            this.dgv_TaiKhoanDaDuocXacThuc = new System.Windows.Forms.DataGridView();
            this.dgv_tkChuaXacThuc = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.btn_DongY = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TaiKhoanDaDuocXacThuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tkChuaXacThuc)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_TaiKhoanDaDuocXacThuc
            // 
            this.dgv_TaiKhoanDaDuocXacThuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TaiKhoanDaDuocXacThuc.Enabled = false;
            this.dgv_TaiKhoanDaDuocXacThuc.Location = new System.Drawing.Point(580, 191);
            this.dgv_TaiKhoanDaDuocXacThuc.Name = "dgv_TaiKhoanDaDuocXacThuc";
            this.dgv_TaiKhoanDaDuocXacThuc.ReadOnly = true;
            this.dgv_TaiKhoanDaDuocXacThuc.Size = new System.Drawing.Size(332, 215);
            this.dgv_TaiKhoanDaDuocXacThuc.TabIndex = 30;
            // 
            // dgv_tkChuaXacThuc
            // 
            this.dgv_tkChuaXacThuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tkChuaXacThuc.Location = new System.Drawing.Point(103, 191);
            this.dgv_tkChuaXacThuc.Name = "dgv_tkChuaXacThuc";
            this.dgv_tkChuaXacThuc.ReadOnly = true;
            this.dgv_tkChuaXacThuc.Size = new System.Drawing.Size(335, 215);
            this.dgv_tkChuaXacThuc.TabIndex = 29;
            this.dgv_tkChuaXacThuc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_tkChuaXacThuc_CellClick);
            this.dgv_tkChuaXacThuc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_tkChuaXacThuc_CellContentClick);
            this.dgv_tkChuaXacThuc.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_tkChuaXacThuc_DataBindingComplete);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(393, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 29);
            this.label4.TabIndex = 46;
            this.label4.Text = "Xác thực tài khoản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(600, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 29);
            this.label1.TabIndex = 46;
            this.label1.Text = "Tài khoản đã xác thực";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(121, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 29);
            this.label2.TabIndex = 46;
            this.label2.Text = "Tài khoản chưa xác thực";
            // 
            // btn_Huy
            // 
            this.btn_Huy.BackColor = System.Drawing.Color.White;
            this.btn_Huy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Huy.Location = new System.Drawing.Point(453, 310);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(102, 85);
            this.btn_Huy.TabIndex = 32;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.UseVisualStyleBackColor = false;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // btn_DongY
            // 
            this.btn_DongY.BackColor = System.Drawing.Color.White;
            this.btn_DongY.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DongY.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_DongY.Location = new System.Drawing.Point(453, 191);
            this.btn_DongY.Name = "btn_DongY";
            this.btn_DongY.Size = new System.Drawing.Size(102, 85);
            this.btn_DongY.TabIndex = 31;
            this.btn_DongY.Text = "Đồng Ý";
            this.btn_DongY.UseVisualStyleBackColor = false;
            this.btn_DongY.Click += new System.EventHandler(this.btn_DongY_Click);
            // 
            // frm_XacThucTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 486);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.btn_DongY);
            this.Controls.Add(this.dgv_TaiKhoanDaDuocXacThuc);
            this.Controls.Add(this.dgv_tkChuaXacThuc);
            this.Name = "frm_XacThucTaiKhoan";
            this.Text = "frm_XacThucTaiKhoan";
            this.Load += new System.EventHandler(this.frm_XacThucTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TaiKhoanDaDuocXacThuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tkChuaXacThuc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_TaiKhoanDaDuocXacThuc;
        private System.Windows.Forms.DataGridView dgv_tkChuaXacThuc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.Button btn_DongY;
    }
}