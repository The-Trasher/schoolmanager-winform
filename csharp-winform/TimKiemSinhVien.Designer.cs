
namespace csharp_winform
{
    partial class TimKiemSinhVien
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
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.grThongTinChiTiet = new System.Windows.Forms.GroupBox();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.dvgMSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvKhoaHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDSSVThiLai = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.rbKhoa = new System.Windows.Forms.RadioButton();
            this.rbMSSV = new System.Windows.Forms.RadioButton();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.cbbKhoa = new System.Windows.Forms.ComboBox();
            this.cbbLop = new System.Windows.Forms.ComboBox();
            this.cbbMonHoc = new System.Windows.Forms.ComboBox();
            this.rbLop = new System.Windows.Forms.RadioButton();
            this.rbMonHoc = new System.Windows.Forms.RadioButton();
            this.rbKhoaHoc = new System.Windows.Forms.RadioButton();
            this.txtKhoaHoc = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grThongTinChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTimKiem.Location = new System.Drawing.Point(473, 137);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(100, 38);
            this.btnTimKiem.TabIndex = 13;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // grThongTinChiTiet
            // 
            this.grThongTinChiTiet.Controls.Add(this.dgvStudent);
            this.grThongTinChiTiet.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grThongTinChiTiet.Location = new System.Drawing.Point(11, 192);
            this.grThongTinChiTiet.Margin = new System.Windows.Forms.Padding(2);
            this.grThongTinChiTiet.Name = "grThongTinChiTiet";
            this.grThongTinChiTiet.Padding = new System.Windows.Forms.Padding(2);
            this.grThongTinChiTiet.Size = new System.Drawing.Size(867, 365);
            this.grThongTinChiTiet.TabIndex = 12;
            this.grThongTinChiTiet.TabStop = false;
            this.grThongTinChiTiet.Text = "Thông tin chi tiết";
            // 
            // dgvStudent
            // 
            this.dgvStudent.AllowUserToAddRows = false;
            this.dgvStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dvgMSSV,
            this.dgvHoTen,
            this.dgvGioiTinh,
            this.dgvNgaySinh,
            this.dgvKhoaHoc,
            this.dgvMaLop,
            this.dgvDiaChi});
            this.dgvStudent.Location = new System.Drawing.Point(5, 24);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudent.Size = new System.Drawing.Size(857, 336);
            this.dgvStudent.TabIndex = 4;
            // 
            // dvgMSSV
            // 
            this.dvgMSSV.HeaderText = "MSSV";
            this.dvgMSSV.Name = "dvgMSSV";
            // 
            // dgvHoTen
            // 
            this.dgvHoTen.HeaderText = "Ho Ten";
            this.dgvHoTen.Name = "dgvHoTen";
            // 
            // dgvGioiTinh
            // 
            this.dgvGioiTinh.HeaderText = "Gioi Tinh";
            this.dgvGioiTinh.Name = "dgvGioiTinh";
            // 
            // dgvNgaySinh
            // 
            this.dgvNgaySinh.HeaderText = "Ngay Sinh";
            this.dgvNgaySinh.Name = "dgvNgaySinh";
            // 
            // dgvKhoaHoc
            // 
            this.dgvKhoaHoc.HeaderText = "Khoa Hoc";
            this.dgvKhoaHoc.Name = "dgvKhoaHoc";
            // 
            // dgvMaLop
            // 
            this.dgvMaLop.HeaderText = "Ma Lop";
            this.dgvMaLop.Name = "dgvMaLop";
            // 
            // dgvDiaChi
            // 
            this.dgvDiaChi.HeaderText = "Dia Chi";
            this.dgvDiaChi.Name = "dgvDiaChi";
            // 
            // lblDSSVThiLai
            // 
            this.lblDSSVThiLai.AutoSize = true;
            this.lblDSSVThiLai.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDSSVThiLai.ForeColor = System.Drawing.Color.Red;
            this.lblDSSVThiLai.Location = new System.Drawing.Point(281, 9);
            this.lblDSSVThiLai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDSSVThiLai.Name = "lblDSSVThiLai";
            this.lblDSSVThiLai.Size = new System.Drawing.Size(261, 26);
            this.lblDSSVThiLai.TabIndex = 9;
            this.lblDSSVThiLai.Text = "TÌM KIẾM SINH VIÊN";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnRefresh.Location = new System.Drawing.Point(605, 137);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 38);
            this.btnRefresh.TabIndex = 13;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // rbKhoa
            // 
            this.rbKhoa.AutoSize = true;
            this.rbKhoa.Location = new System.Drawing.Point(129, 101);
            this.rbKhoa.Name = "rbKhoa";
            this.rbKhoa.Size = new System.Drawing.Size(94, 17);
            this.rbKhoa.TabIndex = 14;
            this.rbKhoa.TabStop = true;
            this.rbKhoa.Text = "Tìm theo Khoa";
            this.rbKhoa.UseVisualStyleBackColor = true;
            this.rbKhoa.CheckedChanged += new System.EventHandler(this.rbKhoa_CheckedChanged);
            // 
            // rbMSSV
            // 
            this.rbMSSV.AutoSize = true;
            this.rbMSSV.Location = new System.Drawing.Point(129, 65);
            this.rbMSSV.Name = "rbMSSV";
            this.rbMSSV.Size = new System.Drawing.Size(99, 17);
            this.rbMSSV.TabIndex = 14;
            this.rbMSSV.TabStop = true;
            this.rbMSSV.Text = "Tìm theo MSSV";
            this.rbMSSV.UseVisualStyleBackColor = true;
            this.rbMSSV.CheckedChanged += new System.EventHandler(this.rbMSSV_CheckedChanged);
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(256, 62);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(152, 20);
            this.txtMSSV.TabIndex = 1;
            // 
            // cbbKhoa
            // 
            this.cbbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbKhoa.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbKhoa.FormattingEnabled = true;
            this.cbbKhoa.Location = new System.Drawing.Point(256, 98);
            this.cbbKhoa.Margin = new System.Windows.Forms.Padding(2);
            this.cbbKhoa.Name = "cbbKhoa";
            this.cbbKhoa.Size = new System.Drawing.Size(152, 24);
            this.cbbKhoa.TabIndex = 4;
            // 
            // cbbLop
            // 
            this.cbbLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLop.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbLop.FormattingEnabled = true;
            this.cbbLop.Location = new System.Drawing.Point(256, 137);
            this.cbbLop.Margin = new System.Windows.Forms.Padding(2);
            this.cbbLop.Name = "cbbLop";
            this.cbbLop.Size = new System.Drawing.Size(152, 24);
            this.cbbLop.TabIndex = 5;
            // 
            // cbbMonHoc
            // 
            this.cbbMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMonHoc.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbMonHoc.FormattingEnabled = true;
            this.cbbMonHoc.Location = new System.Drawing.Point(553, 62);
            this.cbbMonHoc.Margin = new System.Windows.Forms.Padding(2);
            this.cbbMonHoc.Name = "cbbMonHoc";
            this.cbbMonHoc.Size = new System.Drawing.Size(152, 24);
            this.cbbMonHoc.TabIndex = 7;
            // 
            // rbLop
            // 
            this.rbLop.AutoSize = true;
            this.rbLop.Location = new System.Drawing.Point(129, 140);
            this.rbLop.Name = "rbLop";
            this.rbLop.Size = new System.Drawing.Size(87, 17);
            this.rbLop.TabIndex = 14;
            this.rbLop.TabStop = true;
            this.rbLop.Text = "Tìm theo Lớp";
            this.rbLop.UseVisualStyleBackColor = true;
            this.rbLop.CheckedChanged += new System.EventHandler(this.rbLop_CheckedChanged);
            // 
            // rbMonHoc
            // 
            this.rbMonHoc.AutoSize = true;
            this.rbMonHoc.Location = new System.Drawing.Point(431, 65);
            this.rbMonHoc.Name = "rbMonHoc";
            this.rbMonHoc.Size = new System.Drawing.Size(111, 17);
            this.rbMonHoc.TabIndex = 14;
            this.rbMonHoc.TabStop = true;
            this.rbMonHoc.Text = "Tìm theo Môn học";
            this.rbMonHoc.UseVisualStyleBackColor = true;
            this.rbMonHoc.CheckedChanged += new System.EventHandler(this.rbMonHoc_CheckedChanged);
            // 
            // rbKhoaHoc
            // 
            this.rbKhoaHoc.AutoSize = true;
            this.rbKhoaHoc.Location = new System.Drawing.Point(431, 98);
            this.rbKhoaHoc.Name = "rbKhoaHoc";
            this.rbKhoaHoc.Size = new System.Drawing.Size(115, 17);
            this.rbKhoaHoc.TabIndex = 14;
            this.rbKhoaHoc.TabStop = true;
            this.rbKhoaHoc.Text = "Tìm theo Khóa học";
            this.rbKhoaHoc.UseVisualStyleBackColor = true;
            this.rbKhoaHoc.CheckedChanged += new System.EventHandler(this.rbKhoaHoc_CheckedChanged);
            // 
            // txtKhoaHoc
            // 
            this.txtKhoaHoc.Location = new System.Drawing.Point(553, 97);
            this.txtKhoaHoc.Name = "txtKhoaHoc";
            this.txtKhoaHoc.Size = new System.Drawing.Size(152, 20);
            this.txtKhoaHoc.TabIndex = 1;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.Location = new System.Drawing.Point(734, 137);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 38);
            this.btnThoat.TabIndex = 13;
            this.btnThoat.Text = "Thoat";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // TimKiemSinhVien
            // 
            this.AcceptButton = this.btnTimKiem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 568);
            this.Controls.Add(this.txtKhoaHoc);
            this.Controls.Add(this.txtMSSV);
            this.Controls.Add(this.rbMSSV);
            this.Controls.Add(this.cbbMonHoc);
            this.Controls.Add(this.rbKhoaHoc);
            this.Controls.Add(this.rbMonHoc);
            this.Controls.Add(this.rbLop);
            this.Controls.Add(this.rbKhoa);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.cbbLop);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.grThongTinChiTiet);
            this.Controls.Add(this.lblDSSVThiLai);
            this.Controls.Add(this.cbbKhoa);
            this.Name = "TimKiemSinhVien";
            this.Text = "TimKiemSinhVien";
            this.Load += new System.EventHandler(this.TimKiemSinhVien_Load);
            this.grThongTinChiTiet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.GroupBox grThongTinChiTiet;
        private System.Windows.Forms.Label lblDSSVThiLai;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.RadioButton rbKhoa;
        private System.Windows.Forms.RadioButton rbMSSV;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.ComboBox cbbKhoa;
        private System.Windows.Forms.ComboBox cbbLop;
        private System.Windows.Forms.ComboBox cbbMonHoc;
        private System.Windows.Forms.RadioButton rbLop;
        private System.Windows.Forms.RadioButton rbMonHoc;
        private System.Windows.Forms.RadioButton rbKhoaHoc;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgMSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvKhoaHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDiaChi;
        private System.Windows.Forms.TextBox txtKhoaHoc;
        private System.Windows.Forms.Button btnThoat;
    }
}