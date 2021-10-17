
namespace csharp_winform
{
    partial class DoiMatKhau
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
            this.lblThongTinTaiKhoan = new System.Windows.Forms.Label();
            this.grThongTin = new System.Windows.Forms.GroupBox();
            this.cmbQuyenAdmin = new System.Windows.Forms.ComboBox();
            this.txtNhapLaiMK = new System.Windows.Forms.TextBox();
            this.txtMKMoi = new System.Windows.Forms.TextBox();
            this.txtMKCu = new System.Windows.Forms.TextBox();
            this.txtTenTaiKhoan = new System.Windows.Forms.TextBox();
            this.lblNhapLaiMK = new System.Windows.Forms.Label();
            this.lblQuyenADMin = new System.Windows.Forms.Label();
            this.lblMKMoi = new System.Windows.Forms.Label();
            this.lblMkCu = new System.Windows.Forms.Label();
            this.lblTenTaiKhoan = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblThongTinTaiKhoan
            // 
            this.lblThongTinTaiKhoan.AutoSize = true;
            this.lblThongTinTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblThongTinTaiKhoan.ForeColor = System.Drawing.Color.Red;
            this.lblThongTinTaiKhoan.Location = new System.Drawing.Point(211, 29);
            this.lblThongTinTaiKhoan.Name = "lblThongTinTaiKhoan";
            this.lblThongTinTaiKhoan.Size = new System.Drawing.Size(369, 35);
            this.lblThongTinTaiKhoan.TabIndex = 0;
            this.lblThongTinTaiKhoan.Text = "THÔNG TIN TÀI KHOẢN";
            this.lblThongTinTaiKhoan.Click += new System.EventHandler(this.lblThongTinTaiKhoan_Click);
            // 
            // grThongTin
            // 
            this.grThongTin.Controls.Add(this.cmbQuyenAdmin);
            this.grThongTin.Controls.Add(this.txtNhapLaiMK);
            this.grThongTin.Controls.Add(this.txtMKMoi);
            this.grThongTin.Controls.Add(this.txtMKCu);
            this.grThongTin.Controls.Add(this.txtTenTaiKhoan);
            this.grThongTin.Controls.Add(this.lblNhapLaiMK);
            this.grThongTin.Controls.Add(this.lblQuyenADMin);
            this.grThongTin.Controls.Add(this.lblMKMoi);
            this.grThongTin.Controls.Add(this.lblMkCu);
            this.grThongTin.Controls.Add(this.lblTenTaiKhoan);
            this.grThongTin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grThongTin.Location = new System.Drawing.Point(91, 92);
            this.grThongTin.Name = "grThongTin";
            this.grThongTin.Size = new System.Drawing.Size(608, 293);
            this.grThongTin.TabIndex = 1;
            this.grThongTin.TabStop = false;
            this.grThongTin.Text = "Thông tin";
            // 
            // cmbQuyenAdmin
            // 
            this.cmbQuyenAdmin.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbQuyenAdmin.FormattingEnabled = true;
            this.cmbQuyenAdmin.Location = new System.Drawing.Point(218, 227);
            this.cmbQuyenAdmin.Name = "cmbQuyenAdmin";
            this.cmbQuyenAdmin.Size = new System.Drawing.Size(299, 27);
            this.cmbQuyenAdmin.TabIndex = 9;
            // 
            // txtNhapLaiMK
            // 
            this.txtNhapLaiMK.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtNhapLaiMK.Location = new System.Drawing.Point(218, 178);
            this.txtNhapLaiMK.Name = "txtNhapLaiMK";
            this.txtNhapLaiMK.Size = new System.Drawing.Size(299, 27);
            this.txtNhapLaiMK.TabIndex = 8;
            // 
            // txtMKMoi
            // 
            this.txtMKMoi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMKMoi.Location = new System.Drawing.Point(218, 126);
            this.txtMKMoi.Name = "txtMKMoi";
            this.txtMKMoi.Size = new System.Drawing.Size(299, 27);
            this.txtMKMoi.TabIndex = 7;
            // 
            // txtMKCu
            // 
            this.txtMKCu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMKCu.Location = new System.Drawing.Point(218, 82);
            this.txtMKCu.Name = "txtMKCu";
            this.txtMKCu.Size = new System.Drawing.Size(299, 27);
            this.txtMKCu.TabIndex = 6;
            // 
            // txtTenTaiKhoan
            // 
            this.txtTenTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenTaiKhoan.Location = new System.Drawing.Point(218, 35);
            this.txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            this.txtTenTaiKhoan.Size = new System.Drawing.Size(299, 27);
            this.txtTenTaiKhoan.TabIndex = 5;
            // 
            // lblNhapLaiMK
            // 
            this.lblNhapLaiMK.AutoSize = true;
            this.lblNhapLaiMK.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNhapLaiMK.Location = new System.Drawing.Point(56, 188);
            this.lblNhapLaiMK.Name = "lblNhapLaiMK";
            this.lblNhapLaiMK.Size = new System.Drawing.Size(129, 19);
            this.lblNhapLaiMK.TabIndex = 4;
            this.lblNhapLaiMK.Text = "Nhập lại mật khẩu";
            // 
            // lblQuyenADMin
            // 
            this.lblQuyenADMin.AutoSize = true;
            this.lblQuyenADMin.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblQuyenADMin.Location = new System.Drawing.Point(56, 234);
            this.lblQuyenADMin.Name = "lblQuyenADMin";
            this.lblQuyenADMin.Size = new System.Drawing.Size(98, 19);
            this.lblQuyenADMin.TabIndex = 3;
            this.lblQuyenADMin.Text = "Quyền admin";
            // 
            // lblMKMoi
            // 
            this.lblMKMoi.AutoSize = true;
            this.lblMKMoi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMKMoi.Location = new System.Drawing.Point(56, 133);
            this.lblMKMoi.Name = "lblMKMoi";
            this.lblMKMoi.Size = new System.Drawing.Size(102, 19);
            this.lblMKMoi.TabIndex = 2;
            this.lblMKMoi.Text = "Mật khẩu mới";
            // 
            // lblMkCu
            // 
            this.lblMkCu.AutoSize = true;
            this.lblMkCu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMkCu.Location = new System.Drawing.Point(56, 89);
            this.lblMkCu.Name = "lblMkCu";
            this.lblMkCu.Size = new System.Drawing.Size(91, 19);
            this.lblMkCu.TabIndex = 1;
            this.lblMkCu.Text = "Mật khẩu cũ";
            // 
            // lblTenTaiKhoan
            // 
            this.lblTenTaiKhoan.AutoSize = true;
            this.lblTenTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTenTaiKhoan.Location = new System.Drawing.Point(56, 42);
            this.lblTenTaiKhoan.Name = "lblTenTaiKhoan";
            this.lblTenTaiKhoan.Size = new System.Drawing.Size(99, 19);
            this.lblTenTaiKhoan.TabIndex = 0;
            this.lblTenTaiKhoan.Text = "Tên tài khoản";
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnOK.Location = new System.Drawing.Point(150, 409);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(136, 55);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "Ok";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.Location = new System.Drawing.Point(491, 409);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(136, 55);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // DoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 497);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.grThongTin);
            this.Controls.Add(this.lblThongTinTaiKhoan);
            this.Name = "DoiMatKhau";
            this.Text = "DoiMatKhau";
            this.grThongTin.ResumeLayout(false);
            this.grThongTin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblThongTinTaiKhoan;
        private System.Windows.Forms.GroupBox grThongTin;
        private System.Windows.Forms.ComboBox cmbQuyenAdmin;
        private System.Windows.Forms.TextBox txtNhapLaiMK;
        private System.Windows.Forms.TextBox txtMKMoi;
        private System.Windows.Forms.TextBox txtMKCu;
        private System.Windows.Forms.TextBox txtTenTaiKhoan;
        private System.Windows.Forms.Label lblNhapLaiMK;
        private System.Windows.Forms.Label lblQuyenADMin;
        private System.Windows.Forms.Label lblMKMoi;
        private System.Windows.Forms.Label lblMkCu;
        private System.Windows.Forms.Label lblTenTaiKhoan;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnThoat;
    }
}