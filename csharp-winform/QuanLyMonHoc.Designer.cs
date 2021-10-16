
namespace csharp_winform
{
    partial class QuanLyMonHoc
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
            this.lblDanhSachMonHoc = new System.Windows.Forms.Label();
            this.lblMaMon = new System.Windows.Forms.Label();
            this.lblTenMon = new System.Windows.Forms.Label();
            this.lblSoDVHT = new System.Windows.Forms.Label();
            this.lblGiangVien = new System.Windows.Forms.Label();
            this.lblHocKy = new System.Windows.Forms.Label();
            this.lblMaKhoa = new System.Windows.Forms.Label();
            this.grThongTinChiTiet = new System.Windows.Forms.GroupBox();
            this.grDanhSach = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnNhap = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtMaMon = new System.Windows.Forms.TextBox();
            this.txtTenMon = new System.Windows.Forms.TextBox();
            this.txtSoDVHT = new System.Windows.Forms.TextBox();
            this.txtGiangVien = new System.Windows.Forms.TextBox();
            this.txtHocKy = new System.Windows.Forms.TextBox();
            this.cmbMaKhoa = new System.Windows.Forms.ComboBox();
            this.MaMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDVHT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiangVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HocKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grThongTinChiTiet.SuspendLayout();
            this.grDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDanhSachMonHoc
            // 
            this.lblDanhSachMonHoc.AutoSize = true;
            this.lblDanhSachMonHoc.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDanhSachMonHoc.ForeColor = System.Drawing.Color.Red;
            this.lblDanhSachMonHoc.Location = new System.Drawing.Point(338, 34);
            this.lblDanhSachMonHoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDanhSachMonHoc.Name = "lblDanhSachMonHoc";
            this.lblDanhSachMonHoc.Size = new System.Drawing.Size(342, 34);
            this.lblDanhSachMonHoc.TabIndex = 0;
            this.lblDanhSachMonHoc.Text = "DANH SÁCH MÔN HỌC";
            // 
            // lblMaMon
            // 
            this.lblMaMon.AutoSize = true;
            this.lblMaMon.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaMon.Location = new System.Drawing.Point(28, 38);
            this.lblMaMon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaMon.Name = "lblMaMon";
            this.lblMaMon.Size = new System.Drawing.Size(65, 19);
            this.lblMaMon.TabIndex = 1;
            this.lblMaMon.Text = "Mã môn";
            // 
            // lblTenMon
            // 
            this.lblTenMon.AutoSize = true;
            this.lblTenMon.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTenMon.Location = new System.Drawing.Point(28, 93);
            this.lblTenMon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenMon.Name = "lblTenMon";
            this.lblTenMon.Size = new System.Drawing.Size(68, 19);
            this.lblTenMon.TabIndex = 2;
            this.lblTenMon.Text = "Tên môn";
            // 
            // lblSoDVHT
            // 
            this.lblSoDVHT.AutoSize = true;
            this.lblSoDVHT.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSoDVHT.Location = new System.Drawing.Point(28, 147);
            this.lblSoDVHT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoDVHT.Name = "lblSoDVHT";
            this.lblSoDVHT.Size = new System.Drawing.Size(75, 19);
            this.lblSoDVHT.TabIndex = 3;
            this.lblSoDVHT.Text = "Số ĐVHT";
            // 
            // lblGiangVien
            // 
            this.lblGiangVien.AutoSize = true;
            this.lblGiangVien.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblGiangVien.Location = new System.Drawing.Point(28, 202);
            this.lblGiangVien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGiangVien.Name = "lblGiangVien";
            this.lblGiangVien.Size = new System.Drawing.Size(81, 19);
            this.lblGiangVien.TabIndex = 4;
            this.lblGiangVien.Text = "Giảng viên";
            // 
            // lblHocKy
            // 
            this.lblHocKy.AutoSize = true;
            this.lblHocKy.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblHocKy.Location = new System.Drawing.Point(28, 256);
            this.lblHocKy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHocKy.Name = "lblHocKy";
            this.lblHocKy.Size = new System.Drawing.Size(58, 19);
            this.lblHocKy.TabIndex = 5;
            this.lblHocKy.Text = "Học kỳ";
            // 
            // lblMaKhoa
            // 
            this.lblMaKhoa.AutoSize = true;
            this.lblMaKhoa.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaKhoa.Location = new System.Drawing.Point(28, 311);
            this.lblMaKhoa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaKhoa.Name = "lblMaKhoa";
            this.lblMaKhoa.Size = new System.Drawing.Size(67, 19);
            this.lblMaKhoa.TabIndex = 6;
            this.lblMaKhoa.Text = "Mã khoa";
            // 
            // grThongTinChiTiet
            // 
            this.grThongTinChiTiet.Controls.Add(this.cmbMaKhoa);
            this.grThongTinChiTiet.Controls.Add(this.txtHocKy);
            this.grThongTinChiTiet.Controls.Add(this.txtGiangVien);
            this.grThongTinChiTiet.Controls.Add(this.txtSoDVHT);
            this.grThongTinChiTiet.Controls.Add(this.txtTenMon);
            this.grThongTinChiTiet.Controls.Add(this.txtMaMon);
            this.grThongTinChiTiet.Controls.Add(this.lblMaKhoa);
            this.grThongTinChiTiet.Controls.Add(this.lblHocKy);
            this.grThongTinChiTiet.Controls.Add(this.lblGiangVien);
            this.grThongTinChiTiet.Controls.Add(this.lblSoDVHT);
            this.grThongTinChiTiet.Controls.Add(this.lblTenMon);
            this.grThongTinChiTiet.Controls.Add(this.lblMaMon);
            this.grThongTinChiTiet.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grThongTinChiTiet.Location = new System.Drawing.Point(80, 100);
            this.grThongTinChiTiet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grThongTinChiTiet.Name = "grThongTinChiTiet";
            this.grThongTinChiTiet.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grThongTinChiTiet.Size = new System.Drawing.Size(372, 463);
            this.grThongTinChiTiet.TabIndex = 7;
            this.grThongTinChiTiet.TabStop = false;
            this.grThongTinChiTiet.Text = "Thông tin chi tiết";
            // 
            // grDanhSach
            // 
            this.grDanhSach.Controls.Add(this.dataGridView1);
            this.grDanhSach.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grDanhSach.Location = new System.Drawing.Point(522, 100);
            this.grDanhSach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grDanhSach.Name = "grDanhSach";
            this.grDanhSach.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grDanhSach.Size = new System.Drawing.Size(437, 463);
            this.grDanhSach.TabIndex = 8;
            this.grDanhSach.TabStop = false;
            this.grDanhSach.Text = "Danh sách";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaMon,
            this.TenMon,
            this.SoDVHT,
            this.GiangVien,
            this.HocKy,
            this.MaKhoa});
            this.dataGridView1.Location = new System.Drawing.Point(8, 38);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(421, 417);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnNhap
            // 
            this.btnNhap.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNhap.Location = new System.Drawing.Point(1003, 138);
            this.btnNhap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(122, 55);
            this.btnNhap.TabIndex = 1;
            this.btnNhap.Text = "Nhập";
            this.btnNhap.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.Location = new System.Drawing.Point(1003, 245);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(122, 55);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.Location = new System.Drawing.Point(1003, 346);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(122, 55);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.Location = new System.Drawing.Point(1003, 445);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(122, 55);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // txtMaMon
            // 
            this.txtMaMon.Location = new System.Drawing.Point(124, 33);
            this.txtMaMon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaMon.Name = "txtMaMon";
            this.txtMaMon.Size = new System.Drawing.Size(219, 30);
            this.txtMaMon.TabIndex = 12;
            // 
            // txtTenMon
            // 
            this.txtTenMon.Location = new System.Drawing.Point(124, 86);
            this.txtTenMon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.Size = new System.Drawing.Size(219, 30);
            this.txtTenMon.TabIndex = 13;
            // 
            // txtSoDVHT
            // 
            this.txtSoDVHT.Location = new System.Drawing.Point(124, 139);
            this.txtSoDVHT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSoDVHT.Name = "txtSoDVHT";
            this.txtSoDVHT.Size = new System.Drawing.Size(219, 30);
            this.txtSoDVHT.TabIndex = 14;
            // 
            // txtGiangVien
            // 
            this.txtGiangVien.Location = new System.Drawing.Point(124, 192);
            this.txtGiangVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGiangVien.Name = "txtGiangVien";
            this.txtGiangVien.Size = new System.Drawing.Size(219, 30);
            this.txtGiangVien.TabIndex = 15;
            // 
            // txtHocKy
            // 
            this.txtHocKy.Location = new System.Drawing.Point(124, 245);
            this.txtHocKy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHocKy.Name = "txtHocKy";
            this.txtHocKy.Size = new System.Drawing.Size(219, 30);
            this.txtHocKy.TabIndex = 16;
            // 
            // cmbMaKhoa
            // 
            this.cmbMaKhoa.FormattingEnabled = true;
            this.cmbMaKhoa.Location = new System.Drawing.Point(124, 298);
            this.cmbMaKhoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbMaKhoa.Name = "cmbMaKhoa";
            this.cmbMaKhoa.Size = new System.Drawing.Size(219, 30);
            this.cmbMaKhoa.TabIndex = 17;
            // 
            // MaMon
            // 
            this.MaMon.HeaderText = "MaMon";
            this.MaMon.MinimumWidth = 6;
            this.MaMon.Name = "MaMon";
            this.MaMon.ReadOnly = true;
            this.MaMon.Width = 125;
            // 
            // TenMon
            // 
            this.TenMon.HeaderText = "TenMon";
            this.TenMon.MinimumWidth = 6;
            this.TenMon.Name = "TenMon";
            this.TenMon.ReadOnly = true;
            this.TenMon.Width = 125;
            // 
            // SoDVHT
            // 
            this.SoDVHT.HeaderText = "SoDVHT";
            this.SoDVHT.MinimumWidth = 6;
            this.SoDVHT.Name = "SoDVHT";
            this.SoDVHT.ReadOnly = true;
            this.SoDVHT.Width = 125;
            // 
            // GiangVien
            // 
            this.GiangVien.HeaderText = "GiangVien";
            this.GiangVien.MinimumWidth = 6;
            this.GiangVien.Name = "GiangVien";
            this.GiangVien.ReadOnly = true;
            this.GiangVien.Width = 125;
            // 
            // HocKy
            // 
            this.HocKy.HeaderText = "HocKy";
            this.HocKy.MinimumWidth = 6;
            this.HocKy.Name = "HocKy";
            this.HocKy.ReadOnly = true;
            this.HocKy.Width = 125;
            // 
            // MaKhoa
            // 
            this.MaKhoa.HeaderText = "MaKhoa";
            this.MaKhoa.MinimumWidth = 6;
            this.MaKhoa.Name = "MaKhoa";
            this.MaKhoa.ReadOnly = true;
            this.MaKhoa.Width = 125;
            // 
            // QuanLyMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 591);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.grDanhSach);
            this.Controls.Add(this.grThongTinChiTiet);
            this.Controls.Add(this.lblDanhSachMonHoc);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "QuanLyMonHoc";
            this.Text = "QuanLyMonHoc";
            this.grThongTinChiTiet.ResumeLayout(false);
            this.grThongTinChiTiet.PerformLayout();
            this.grDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDanhSachMonHoc;
        private System.Windows.Forms.Label lblMaMon;
        private System.Windows.Forms.Label lblTenMon;
        private System.Windows.Forms.Label lblSoDVHT;
        private System.Windows.Forms.Label lblGiangVien;
        private System.Windows.Forms.Label lblHocKy;
        private System.Windows.Forms.Label lblMaKhoa;
        private System.Windows.Forms.GroupBox grThongTinChiTiet;
        private System.Windows.Forms.ComboBox cmbMaKhoa;
        private System.Windows.Forms.TextBox txtHocKy;
        private System.Windows.Forms.TextBox txtGiangVien;
        private System.Windows.Forms.TextBox txtSoDVHT;
        private System.Windows.Forms.TextBox txtTenMon;
        private System.Windows.Forms.TextBox txtMaMon;
        private System.Windows.Forms.GroupBox grDanhSach;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDVHT;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiangVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn HocKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhoa;
    }
}