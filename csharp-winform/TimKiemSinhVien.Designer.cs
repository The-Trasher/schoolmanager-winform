
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
            this.btnTimKiem.Location = new System.Drawing.Point(631, 169);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(133, 47);
            this.btnTimKiem.TabIndex = 13;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // grThongTinChiTiet
            // 
            this.grThongTinChiTiet.Controls.Add(this.dgvStudent);
            this.grThongTinChiTiet.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grThongTinChiTiet.Location = new System.Drawing.Point(15, 236);
            this.grThongTinChiTiet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grThongTinChiTiet.Name = "grThongTinChiTiet";
            this.grThongTinChiTiet.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grThongTinChiTiet.Size = new System.Drawing.Size(1156, 449);
            this.grThongTinChiTiet.TabIndex = 12;
            this.grThongTinChiTiet.TabStop = false;
            this.grThongTinChiTiet.Text = "Thông tin chi tiết";
            // 
            // dgvStudent
            // 
            this.dgvStudent.AllowUserToAddRows = false;
            this.dgvStudent.AllowUserToResizeRows = false;
            this.dgvStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudent.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dvgMSSV,
            this.dgvHoTen,
            this.dgvGioiTinh,
            this.dgvNgaySinh,
            this.dgvKhoaHoc,
            this.dgvMaLop,
            this.dgvDiaChi});
            this.dgvStudent.Location = new System.Drawing.Point(7, 30);
            this.dgvStudent.Margin = new System.Windows.Forms.Padding(4);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.RowHeadersWidth = 51;
            this.dgvStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudent.Size = new System.Drawing.Size(1143, 414);
            this.dgvStudent.TabIndex = 4;
            // 
            // dvgMSSV
            // 
            this.dvgMSSV.HeaderText = "MSSV";
            this.dvgMSSV.MinimumWidth = 6;
            this.dvgMSSV.Name = "dvgMSSV";
            // 
            // dgvHoTen
            // 
            this.dgvHoTen.HeaderText = "Họ Tên";
            this.dgvHoTen.MinimumWidth = 6;
            this.dgvHoTen.Name = "dgvHoTen";
            // 
            // dgvGioiTinh
            // 
            this.dgvGioiTinh.HeaderText = "Giới Tính";
            this.dgvGioiTinh.MinimumWidth = 6;
            this.dgvGioiTinh.Name = "dgvGioiTinh";
            // 
            // dgvNgaySinh
            // 
            this.dgvNgaySinh.HeaderText = "Ngày Sinh";
            this.dgvNgaySinh.MinimumWidth = 6;
            this.dgvNgaySinh.Name = "dgvNgaySinh";
            // 
            // dgvKhoaHoc
            // 
            this.dgvKhoaHoc.HeaderText = "Khóa Học";
            this.dgvKhoaHoc.MinimumWidth = 6;
            this.dgvKhoaHoc.Name = "dgvKhoaHoc";
            // 
            // dgvMaLop
            // 
            this.dgvMaLop.HeaderText = "Mã Lớp";
            this.dgvMaLop.MinimumWidth = 6;
            this.dgvMaLop.Name = "dgvMaLop";
            // 
            // dgvDiaChi
            // 
            this.dgvDiaChi.HeaderText = "Địa Chỉ";
            this.dgvDiaChi.MinimumWidth = 6;
            this.dgvDiaChi.Name = "dgvDiaChi";
            // 
            // lblDSSVThiLai
            // 
            this.lblDSSVThiLai.AutoSize = true;
            this.lblDSSVThiLai.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDSSVThiLai.ForeColor = System.Drawing.Color.Red;
            this.lblDSSVThiLai.Location = new System.Drawing.Point(375, 11);
            this.lblDSSVThiLai.Name = "lblDSSVThiLai";
            this.lblDSSVThiLai.Size = new System.Drawing.Size(331, 35);
            this.lblDSSVThiLai.TabIndex = 9;
            this.lblDSSVThiLai.Text = "TÌM KIẾM SINH VIÊN";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnRefresh.Location = new System.Drawing.Point(807, 169);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(133, 47);
            this.btnRefresh.TabIndex = 13;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // rbKhoa
            // 
            this.rbKhoa.AutoSize = true;
            this.rbKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbKhoa.Location = new System.Drawing.Point(172, 124);
            this.rbKhoa.Margin = new System.Windows.Forms.Padding(4);
            this.rbKhoa.Name = "rbKhoa";
            this.rbKhoa.Size = new System.Drawing.Size(134, 21);
            this.rbKhoa.TabIndex = 14;
            this.rbKhoa.TabStop = true;
            this.rbKhoa.Text = "Tìm theo Khoa";
            this.rbKhoa.UseVisualStyleBackColor = true;
            this.rbKhoa.CheckedChanged += new System.EventHandler(this.rbKhoa_CheckedChanged);
            // 
            // rbMSSV
            // 
            this.rbMSSV.AutoSize = true;
            this.rbMSSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMSSV.Location = new System.Drawing.Point(172, 80);
            this.rbMSSV.Margin = new System.Windows.Forms.Padding(4);
            this.rbMSSV.Name = "rbMSSV";
            this.rbMSSV.Size = new System.Drawing.Size(139, 21);
            this.rbMSSV.TabIndex = 14;
            this.rbMSSV.TabStop = true;
            this.rbMSSV.Text = "Tìm theo MSSV";
            this.rbMSSV.UseVisualStyleBackColor = true;
            this.rbMSSV.CheckedChanged += new System.EventHandler(this.rbMSSV_CheckedChanged);
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(341, 76);
            this.txtMSSV.Margin = new System.Windows.Forms.Padding(4);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(201, 22);
            this.txtMSSV.TabIndex = 1;
            // 
            // cbbKhoa
            // 
            this.cbbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbKhoa.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbKhoa.FormattingEnabled = true;
            this.cbbKhoa.Location = new System.Drawing.Point(341, 121);
            this.cbbKhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbKhoa.Name = "cbbKhoa";
            this.cbbKhoa.Size = new System.Drawing.Size(201, 27);
            this.cbbKhoa.TabIndex = 4;
            // 
            // cbbLop
            // 
            this.cbbLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLop.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbLop.FormattingEnabled = true;
            this.cbbLop.Location = new System.Drawing.Point(341, 169);
            this.cbbLop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbLop.Name = "cbbLop";
            this.cbbLop.Size = new System.Drawing.Size(201, 27);
            this.cbbLop.TabIndex = 5;
            // 
            // cbbMonHoc
            // 
            this.cbbMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMonHoc.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbMonHoc.FormattingEnabled = true;
            this.cbbMonHoc.Location = new System.Drawing.Point(737, 76);
            this.cbbMonHoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbMonHoc.Name = "cbbMonHoc";
            this.cbbMonHoc.Size = new System.Drawing.Size(201, 27);
            this.cbbMonHoc.TabIndex = 7;
            // 
            // rbLop
            // 
            this.rbLop.AutoSize = true;
            this.rbLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLop.Location = new System.Drawing.Point(172, 172);
            this.rbLop.Margin = new System.Windows.Forms.Padding(4);
            this.rbLop.Name = "rbLop";
            this.rbLop.Size = new System.Drawing.Size(124, 21);
            this.rbLop.TabIndex = 14;
            this.rbLop.TabStop = true;
            this.rbLop.Text = "Tìm theo Lớp";
            this.rbLop.UseVisualStyleBackColor = true;
            this.rbLop.CheckedChanged += new System.EventHandler(this.rbLop_CheckedChanged);
            // 
            // rbMonHoc
            // 
            this.rbMonHoc.AutoSize = true;
            this.rbMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMonHoc.Location = new System.Drawing.Point(575, 80);
            this.rbMonHoc.Margin = new System.Windows.Forms.Padding(4);
            this.rbMonHoc.Name = "rbMonHoc";
            this.rbMonHoc.Size = new System.Drawing.Size(158, 21);
            this.rbMonHoc.TabIndex = 14;
            this.rbMonHoc.TabStop = true;
            this.rbMonHoc.Text = "Tìm theo Môn học";
            this.rbMonHoc.UseVisualStyleBackColor = true;
            this.rbMonHoc.CheckedChanged += new System.EventHandler(this.rbMonHoc_CheckedChanged);
            // 
            // rbKhoaHoc
            // 
            this.rbKhoaHoc.AutoSize = true;
            this.rbKhoaHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbKhoaHoc.Location = new System.Drawing.Point(575, 121);
            this.rbKhoaHoc.Margin = new System.Windows.Forms.Padding(4);
            this.rbKhoaHoc.Name = "rbKhoaHoc";
            this.rbKhoaHoc.Size = new System.Drawing.Size(165, 21);
            this.rbKhoaHoc.TabIndex = 14;
            this.rbKhoaHoc.TabStop = true;
            this.rbKhoaHoc.Text = "Tìm theo Khóa học";
            this.rbKhoaHoc.UseVisualStyleBackColor = true;
            this.rbKhoaHoc.CheckedChanged += new System.EventHandler(this.rbKhoaHoc_CheckedChanged);
            // 
            // txtKhoaHoc
            // 
            this.txtKhoaHoc.Location = new System.Drawing.Point(737, 119);
            this.txtKhoaHoc.Margin = new System.Windows.Forms.Padding(4);
            this.txtKhoaHoc.Name = "txtKhoaHoc";
            this.txtKhoaHoc.Size = new System.Drawing.Size(201, 22);
            this.txtKhoaHoc.TabIndex = 1;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.Location = new System.Drawing.Point(979, 169);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(133, 47);
            this.btnThoat.TabIndex = 13;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // TimKiemSinhVien
            // 
            this.AcceptButton = this.btnTimKiem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1185, 699);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TimKiemSinhVien";
            this.Text = "Tìm Kiếm Sinh Viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private System.Windows.Forms.TextBox txtKhoaHoc;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgMSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvKhoaHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDiaChi;
    }
}