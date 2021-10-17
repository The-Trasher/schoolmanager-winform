
namespace csharp_winform
{
    partial class QuanLyKhoa
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnNhap = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.grDanhSach = new System.Windows.Forms.GroupBox();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.MaKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grLuaChon = new System.Windows.Forms.GroupBox();
            this.txtTenKhoa = new System.Windows.Forms.TextBox();
            this.txtMaKhoa = new System.Windows.Forms.TextBox();
            this.lblTenKhoa = new System.Windows.Forms.Label();
            this.lblMaKhoa = new System.Windows.Forms.Label();
            this.lblQuanLyKhoa = new System.Windows.Forms.Label();
            this.grDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.grLuaChon.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.Location = new System.Drawing.Point(885, 313);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(98, 41);
            this.btnThoat.TabIndex = 14;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.Location = new System.Drawing.Point(885, 245);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(98, 41);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnNhap
            // 
            this.btnNhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNhap.Location = new System.Drawing.Point(885, 109);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(98, 41);
            this.btnNhap.TabIndex = 11;
            this.btnNhap.Text = "Nhập";
            this.btnNhap.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.Location = new System.Drawing.Point(885, 177);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(98, 41);
            this.btnSua.TabIndex = 12;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // grDanhSach
            // 
            this.grDanhSach.Controls.Add(this.dgvDanhSach);
            this.grDanhSach.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grDanhSach.Location = new System.Drawing.Point(440, 88);
            this.grDanhSach.Name = "grDanhSach";
            this.grDanhSach.Size = new System.Drawing.Size(429, 460);
            this.grDanhSach.TabIndex = 10;
            this.grDanhSach.TabStop = false;
            this.grDanhSach.Text = "Danh sách";
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.AllowUserToAddRows = false;
            this.dgvDanhSach.AllowUserToDeleteRows = false;
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKhoa,
            this.TenKhoa});
            this.dgvDanhSach.Location = new System.Drawing.Point(28, 29);
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.ReadOnly = true;
            this.dgvDanhSach.RowHeadersWidth = 51;
            this.dgvDanhSach.RowTemplate.Height = 24;
            this.dgvDanhSach.Size = new System.Drawing.Size(378, 425);
            this.dgvDanhSach.TabIndex = 0;
            // 
            // MaKhoa
            // 
            this.MaKhoa.HeaderText = "MaKhoa";
            this.MaKhoa.MinimumWidth = 6;
            this.MaKhoa.Name = "MaKhoa";
            this.MaKhoa.ReadOnly = true;
            this.MaKhoa.Width = 125;
            // 
            // TenKhoa
            // 
            this.TenKhoa.HeaderText = "TenKhoa";
            this.TenKhoa.MinimumWidth = 6;
            this.TenKhoa.Name = "TenKhoa";
            this.TenKhoa.ReadOnly = true;
            this.TenKhoa.Width = 200;
            // 
            // grLuaChon
            // 
            this.grLuaChon.Controls.Add(this.txtTenKhoa);
            this.grLuaChon.Controls.Add(this.txtMaKhoa);
            this.grLuaChon.Controls.Add(this.lblTenKhoa);
            this.grLuaChon.Controls.Add(this.lblMaKhoa);
            this.grLuaChon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grLuaChon.Location = new System.Drawing.Point(77, 88);
            this.grLuaChon.Name = "grLuaChon";
            this.grLuaChon.Size = new System.Drawing.Size(348, 460);
            this.grLuaChon.TabIndex = 9;
            this.grLuaChon.TabStop = false;
            this.grLuaChon.Text = "Lực chọn";
            // 
            // txtTenKhoa
            // 
            this.txtTenKhoa.Location = new System.Drawing.Point(120, 117);
            this.txtTenKhoa.Name = "txtTenKhoa";
            this.txtTenKhoa.Size = new System.Drawing.Size(208, 30);
            this.txtTenKhoa.TabIndex = 4;
            // 
            // txtMaKhoa
            // 
            this.txtMaKhoa.Location = new System.Drawing.Point(120, 59);
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Size = new System.Drawing.Size(205, 30);
            this.txtMaKhoa.TabIndex = 3;
            // 
            // lblTenKhoa
            // 
            this.lblTenKhoa.AutoSize = true;
            this.lblTenKhoa.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTenKhoa.Location = new System.Drawing.Point(27, 117);
            this.lblTenKhoa.Name = "lblTenKhoa";
            this.lblTenKhoa.Size = new System.Drawing.Size(70, 19);
            this.lblTenKhoa.TabIndex = 2;
            this.lblTenKhoa.Text = "Tên khoa";
            this.lblTenKhoa.Click += new System.EventHandler(this.lblTenKhoa_Click);
            // 
            // lblMaKhoa
            // 
            this.lblMaKhoa.AutoSize = true;
            this.lblMaKhoa.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaKhoa.Location = new System.Drawing.Point(30, 59);
            this.lblMaKhoa.Name = "lblMaKhoa";
            this.lblMaKhoa.Size = new System.Drawing.Size(67, 19);
            this.lblMaKhoa.TabIndex = 1;
            this.lblMaKhoa.Text = "Mã khoa";
            // 
            // lblQuanLyKhoa
            // 
            this.lblQuanLyKhoa.AutoSize = true;
            this.lblQuanLyKhoa.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblQuanLyKhoa.ForeColor = System.Drawing.Color.Red;
            this.lblQuanLyKhoa.Location = new System.Drawing.Point(359, 25);
            this.lblQuanLyKhoa.Name = "lblQuanLyKhoa";
            this.lblQuanLyKhoa.Size = new System.Drawing.Size(252, 35);
            this.lblQuanLyKhoa.TabIndex = 8;
            this.lblQuanLyKhoa.Text = "QUẢN LÝ KHOA";
            // 
            // QuanLyKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 569);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.grDanhSach);
            this.Controls.Add(this.grLuaChon);
            this.Controls.Add(this.lblQuanLyKhoa);
            this.Name = "QuanLyKhoa";
            this.Text = "QuanLyKhoa";
            this.Load += new System.EventHandler(this.QuanLyKhoa_Load);
            this.grDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.grLuaChon.ResumeLayout(false);
            this.grLuaChon.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.GroupBox grDanhSach;
        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhoa;
        private System.Windows.Forms.GroupBox grLuaChon;
        private System.Windows.Forms.TextBox txtTenKhoa;
        private System.Windows.Forms.TextBox txtMaKhoa;
        private System.Windows.Forms.Label lblTenKhoa;
        private System.Windows.Forms.Label lblMaKhoa;
        private System.Windows.Forms.Label lblQuanLyKhoa;
    }
}