
namespace csharp_winform
{
    partial class QuanLyDiemHocLai
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
            this.grDanhSach = new System.Windows.Forms.GroupBox();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.btnInBangDiem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnNhap = new System.Windows.Forms.Button();
            this.grThongTinChiTiet = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblDiemHocLai = new System.Windows.Forms.Label();
            this.lblHoVaTen = new System.Windows.Forms.Label();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.grLuaChon = new System.Windows.Forms.GroupBox();
            this.cmbMonHoc = new System.Windows.Forms.ComboBox();
            this.cmbHocKy = new System.Windows.Forms.ComboBox();
            this.cmbLop = new System.Windows.Forms.ComboBox();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.lblMonHoc = new System.Windows.Forms.Label();
            this.lblHocKy = new System.Windows.Forms.Label();
            this.lblLop = new System.Windows.Forms.Label();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.lblQuanLyDiemHocLai = new System.Windows.Forms.Label();
            this.txtDiemHocLai = new System.Windows.Forms.TextBox();
            this.MaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemThiLai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HocKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.grThongTinChiTiet.SuspendLayout();
            this.grLuaChon.SuspendLayout();
            this.SuspendLayout();
            // 
            // grDanhSach
            // 
            this.grDanhSach.Controls.Add(this.dgvDanhSach);
            this.grDanhSach.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grDanhSach.Location = new System.Drawing.Point(45, 524);
            this.grDanhSach.Name = "grDanhSach";
            this.grDanhSach.Size = new System.Drawing.Size(966, 220);
            this.grDanhSach.TabIndex = 36;
            this.grDanhSach.TabStop = false;
            this.grDanhSach.Text = "Danh Sách";
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.AllowUserToAddRows = false;
            this.dgvDanhSach.AllowUserToDeleteRows = false;
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSV,
            this.HoTen,
            this.MaLop,
            this.MaMon,
            this.DiemThiLai,
            this.HocKy});
            this.dgvDanhSach.Location = new System.Drawing.Point(6, 25);
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.ReadOnly = true;
            this.dgvDanhSach.RowHeadersWidth = 51;
            this.dgvDanhSach.RowTemplate.Height = 24;
            this.dgvDanhSach.Size = new System.Drawing.Size(954, 189);
            this.dgvDanhSach.TabIndex = 0;
            // 
            // btnInBangDiem
            // 
            this.btnInBangDiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnInBangDiem.Location = new System.Drawing.Point(1046, 603);
            this.btnInBangDiem.Name = "btnInBangDiem";
            this.btnInBangDiem.Size = new System.Drawing.Size(122, 60);
            this.btnInBangDiem.TabIndex = 35;
            this.btnInBangDiem.Text = "In bảng điểm";
            this.btnInBangDiem.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.Location = new System.Drawing.Point(1066, 403);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(102, 48);
            this.btnThoat.TabIndex = 34;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.Location = new System.Drawing.Point(1066, 342);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(102, 48);
            this.btnXoa.TabIndex = 33;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.Location = new System.Drawing.Point(1066, 281);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(102, 48);
            this.btnSua.TabIndex = 32;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnNhap
            // 
            this.btnNhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNhap.Location = new System.Drawing.Point(1066, 220);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(102, 48);
            this.btnNhap.TabIndex = 31;
            this.btnNhap.Text = "Nhập";
            this.btnNhap.UseVisualStyleBackColor = true;
            // 
            // grThongTinChiTiet
            // 
            this.grThongTinChiTiet.Controls.Add(this.textBox3);
            this.grThongTinChiTiet.Controls.Add(this.textBox1);
            this.grThongTinChiTiet.Controls.Add(this.lblDiemHocLai);
            this.grThongTinChiTiet.Controls.Add(this.lblHoVaTen);
            this.grThongTinChiTiet.Controls.Add(this.lblMaSV);
            this.grThongTinChiTiet.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grThongTinChiTiet.Location = new System.Drawing.Point(45, 343);
            this.grThongTinChiTiet.Name = "grThongTinChiTiet";
            this.grThongTinChiTiet.Size = new System.Drawing.Size(966, 162);
            this.grThongTinChiTiet.TabIndex = 30;
            this.grThongTinChiTiet.TabStop = false;
            this.grThongTinChiTiet.Text = "Thông tin chi tiết";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox3.Location = new System.Drawing.Point(394, 43);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(276, 27);
            this.textBox3.TabIndex = 18;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox1.Location = new System.Drawing.Point(136, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(154, 27);
            this.textBox1.TabIndex = 16;
            // 
            // lblDiemHocLai
            // 
            this.lblDiemHocLai.AutoSize = true;
            this.lblDiemHocLai.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDiemHocLai.Location = new System.Drawing.Point(688, 46);
            this.lblDiemHocLai.Name = "lblDiemHocLai";
            this.lblDiemHocLai.Size = new System.Drawing.Size(97, 19);
            this.lblDiemHocLai.TabIndex = 9;
            this.lblDiemHocLai.Text = "Điểm học lại";
            // 
            // lblHoVaTen
            // 
            this.lblHoVaTen.AutoSize = true;
            this.lblHoVaTen.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblHoVaTen.Location = new System.Drawing.Point(315, 46);
            this.lblHoVaTen.Name = "lblHoVaTen";
            this.lblHoVaTen.Size = new System.Drawing.Size(73, 19);
            this.lblHoVaTen.TabIndex = 7;
            this.lblHoVaTen.Text = "Họ và tên";
            // 
            // lblMaSV
            // 
            this.lblMaSV.AutoSize = true;
            this.lblMaSV.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaSV.Location = new System.Drawing.Point(35, 46);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(95, 19);
            this.lblMaSV.TabIndex = 5;
            this.lblMaSV.Text = "Mã sinh viên";
            // 
            // grLuaChon
            // 
            this.grLuaChon.Controls.Add(this.cmbMonHoc);
            this.grLuaChon.Controls.Add(this.cmbHocKy);
            this.grLuaChon.Controls.Add(this.cmbLop);
            this.grLuaChon.Controls.Add(this.cmbKhoa);
            this.grLuaChon.Controls.Add(this.lblMonHoc);
            this.grLuaChon.Controls.Add(this.lblHocKy);
            this.grLuaChon.Controls.Add(this.lblLop);
            this.grLuaChon.Controls.Add(this.lblKhoa);
            this.grLuaChon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grLuaChon.Location = new System.Drawing.Point(45, 80);
            this.grLuaChon.Name = "grLuaChon";
            this.grLuaChon.Size = new System.Drawing.Size(569, 246);
            this.grLuaChon.TabIndex = 29;
            this.grLuaChon.TabStop = false;
            this.grLuaChon.Text = "Lựa chọn";
            // 
            // cmbMonHoc
            // 
            this.cmbMonHoc.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbMonHoc.FormattingEnabled = true;
            this.cmbMonHoc.Location = new System.Drawing.Point(125, 152);
            this.cmbMonHoc.Name = "cmbMonHoc";
            this.cmbMonHoc.Size = new System.Drawing.Size(414, 27);
            this.cmbMonHoc.TabIndex = 14;
            // 
            // cmbHocKy
            // 
            this.cmbHocKy.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbHocKy.FormattingEnabled = true;
            this.cmbHocKy.Location = new System.Drawing.Point(387, 101);
            this.cmbHocKy.Name = "cmbHocKy";
            this.cmbHocKy.Size = new System.Drawing.Size(152, 27);
            this.cmbHocKy.TabIndex = 13;
            // 
            // cmbLop
            // 
            this.cmbLop.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbLop.FormattingEnabled = true;
            this.cmbLop.Location = new System.Drawing.Point(125, 101);
            this.cmbLop.Name = "cmbLop";
            this.cmbLop.Size = new System.Drawing.Size(147, 27);
            this.cmbLop.TabIndex = 12;
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(125, 50);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(414, 27);
            this.cmbKhoa.TabIndex = 11;
            // 
            // lblMonHoc
            // 
            this.lblMonHoc.AutoSize = true;
            this.lblMonHoc.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMonHoc.Location = new System.Drawing.Point(35, 155);
            this.lblMonHoc.Name = "lblMonHoc";
            this.lblMonHoc.Size = new System.Drawing.Size(70, 19);
            this.lblMonHoc.TabIndex = 4;
            this.lblMonHoc.Text = "Môn học";
            // 
            // lblHocKy
            // 
            this.lblHocKy.AutoSize = true;
            this.lblHocKy.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblHocKy.Location = new System.Drawing.Point(304, 104);
            this.lblHocKy.Name = "lblHocKy";
            this.lblHocKy.Size = new System.Drawing.Size(58, 19);
            this.lblHocKy.TabIndex = 3;
            this.lblHocKy.Text = "Học kỳ";
            // 
            // lblLop
            // 
            this.lblLop.AutoSize = true;
            this.lblLop.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblLop.Location = new System.Drawing.Point(35, 104);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(36, 19);
            this.lblLop.TabIndex = 2;
            this.lblLop.Text = "Lớp";
            // 
            // lblKhoa
            // 
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblKhoa.Location = new System.Drawing.Point(35, 53);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(45, 19);
            this.lblKhoa.TabIndex = 1;
            this.lblKhoa.Text = "Khoa";
            // 
            // lblQuanLyDiemHocLai
            // 
            this.lblQuanLyDiemHocLai.AutoSize = true;
            this.lblQuanLyDiemHocLai.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblQuanLyDiemHocLai.ForeColor = System.Drawing.Color.Red;
            this.lblQuanLyDiemHocLai.Location = new System.Drawing.Point(406, 34);
            this.lblQuanLyDiemHocLai.Name = "lblQuanLyDiemHocLai";
            this.lblQuanLyDiemHocLai.Size = new System.Drawing.Size(380, 35);
            this.lblQuanLyDiemHocLai.TabIndex = 27;
            this.lblQuanLyDiemHocLai.Text = "QUẢN LÝ ĐIỂM HỌC LẠI";
            // 
            // txtDiemHocLai
            // 
            this.txtDiemHocLai.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDiemHocLai.Location = new System.Drawing.Point(860, 386);
            this.txtDiemHocLai.Name = "txtDiemHocLai";
            this.txtDiemHocLai.Size = new System.Drawing.Size(127, 27);
            this.txtDiemHocLai.TabIndex = 19;
            // 
            // MaSV
            // 
            this.MaSV.HeaderText = "MaSV";
            this.MaSV.MinimumWidth = 6;
            this.MaSV.Name = "MaSV";
            this.MaSV.ReadOnly = true;
            this.MaSV.Width = 125;
            // 
            // HoTen
            // 
            this.HoTen.HeaderText = "HoTen";
            this.HoTen.MinimumWidth = 6;
            this.HoTen.Name = "HoTen";
            this.HoTen.ReadOnly = true;
            this.HoTen.Width = 125;
            // 
            // MaLop
            // 
            this.MaLop.HeaderText = "MaLop";
            this.MaLop.MinimumWidth = 6;
            this.MaLop.Name = "MaLop";
            this.MaLop.ReadOnly = true;
            this.MaLop.Width = 125;
            // 
            // MaMon
            // 
            this.MaMon.HeaderText = "MaMon";
            this.MaMon.MinimumWidth = 6;
            this.MaMon.Name = "MaMon";
            this.MaMon.ReadOnly = true;
            this.MaMon.Width = 125;
            // 
            // DiemThiLai
            // 
            this.DiemThiLai.HeaderText = "DiemThiLai";
            this.DiemThiLai.MinimumWidth = 6;
            this.DiemThiLai.Name = "DiemThiLai";
            this.DiemThiLai.ReadOnly = true;
            this.DiemThiLai.Width = 125;
            // 
            // HocKy
            // 
            this.HocKy.HeaderText = "Học kỳ ";
            this.HocKy.MinimumWidth = 6;
            this.HocKy.Name = "HocKy";
            this.HocKy.ReadOnly = true;
            this.HocKy.Width = 125;
            // 
            // QuanLyDiemHocLai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 704);
            this.Controls.Add(this.txtDiemHocLai);
            this.Controls.Add(this.grDanhSach);
            this.Controls.Add(this.btnInBangDiem);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.grThongTinChiTiet);
            this.Controls.Add(this.grLuaChon);
            this.Controls.Add(this.lblQuanLyDiemHocLai);
            this.Name = "QuanLyDiemHocLai";
            this.Text = "QuanLyDiemHocLai";
            this.grDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.grThongTinChiTiet.ResumeLayout(false);
            this.grThongTinChiTiet.PerformLayout();
            this.grLuaChon.ResumeLayout(false);
            this.grLuaChon.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grDanhSach;
        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.Button btnInBangDiem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.GroupBox grThongTinChiTiet;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblDiemHocLai;
        private System.Windows.Forms.Label lblHoVaTen;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.GroupBox grLuaChon;
        private System.Windows.Forms.ComboBox cmbMonHoc;
        private System.Windows.Forms.ComboBox cmbHocKy;
        private System.Windows.Forms.ComboBox cmbLop;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.Label lblMonHoc;
        private System.Windows.Forms.Label lblHocKy;
        private System.Windows.Forms.Label lblLop;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.Label lblQuanLyDiemHocLai;
        private System.Windows.Forms.TextBox txtDiemHocLai;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemThiLai;
        private System.Windows.Forms.DataGridViewTextBoxColumn HocKy;
    }
}