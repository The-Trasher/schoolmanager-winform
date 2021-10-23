
namespace csharp_winform
{
    partial class NhapDiemSinhVien
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
            this.lblThongTinDiemSinhVien = new System.Windows.Forms.Label();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.lblDiemTB = new System.Windows.Forms.Label();
            this.lblHoVaTen = new System.Windows.Forms.Label();
            this.lblDiemThiLan1 = new System.Windows.Forms.Label();
            this.grThongTinChiTiet = new System.Windows.Forms.GroupBox();
            this.txtKTL2 = new System.Windows.Forms.TextBox();
            this.txtDiemThi = new System.Windows.Forms.TextBox();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.btnNhap = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnInBangDiem = new System.Windows.Forms.Button();
            this.grDanhSach = new System.Windows.Forms.GroupBox();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtMaMH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKTL1 = new System.Windows.Forms.TextBox();
            this.dgvMaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMaMonHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDiemKTL1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDiemKTL2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDiemThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDiemTongKet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grThongTinChiTiet.SuspendLayout();
            this.grDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // lblThongTinDiemSinhVien
            // 
            this.lblThongTinDiemSinhVien.AutoSize = true;
            this.lblThongTinDiemSinhVien.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblThongTinDiemSinhVien.ForeColor = System.Drawing.Color.Red;
            this.lblThongTinDiemSinhVien.Location = new System.Drawing.Point(284, 9);
            this.lblThongTinDiemSinhVien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblThongTinDiemSinhVien.Name = "lblThongTinDiemSinhVien";
            this.lblThongTinDiemSinhVien.Size = new System.Drawing.Size(347, 26);
            this.lblThongTinDiemSinhVien.TabIndex = 0;
            this.lblThongTinDiemSinhVien.Text = "THÔNG TIN ĐIỂM SINH VIÊN";
            // 
            // lblMaSV
            // 
            this.lblMaSV.AutoSize = true;
            this.lblMaSV.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaSV.Location = new System.Drawing.Point(5, 37);
            this.lblMaSV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(80, 16);
            this.lblMaSV.TabIndex = 5;
            this.lblMaSV.Text = "Mã sinh viên";
            // 
            // lblDiemTB
            // 
            this.lblDiemTB.AutoSize = true;
            this.lblDiemTB.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDiemTB.Location = new System.Drawing.Point(458, 84);
            this.lblDiemTB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDiemTB.Name = "lblDiemTB";
            this.lblDiemTB.Size = new System.Drawing.Size(61, 16);
            this.lblDiemTB.TabIndex = 6;
            this.lblDiemTB.Text = "Điểm Thi";
            // 
            // lblHoVaTen
            // 
            this.lblHoVaTen.AutoSize = true;
            this.lblHoVaTen.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblHoVaTen.Location = new System.Drawing.Point(226, 37);
            this.lblHoVaTen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHoVaTen.Name = "lblHoVaTen";
            this.lblHoVaTen.Size = new System.Drawing.Size(80, 16);
            this.lblHoVaTen.TabIndex = 7;
            this.lblHoVaTen.Text = "Mã môn học";
            // 
            // lblDiemThiLan1
            // 
            this.lblDiemThiLan1.AutoSize = true;
            this.lblDiemThiLan1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDiemThiLan1.Location = new System.Drawing.Point(226, 85);
            this.lblDiemThiLan1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDiemThiLan1.Name = "lblDiemThiLan1";
            this.lblDiemThiLan1.Size = new System.Drawing.Size(91, 16);
            this.lblDiemThiLan1.TabIndex = 8;
            this.lblDiemThiLan1.Text = "Điểm KT lần 2";
            // 
            // grThongTinChiTiet
            // 
            this.grThongTinChiTiet.Controls.Add(this.txtKTL1);
            this.grThongTinChiTiet.Controls.Add(this.txtKTL2);
            this.grThongTinChiTiet.Controls.Add(this.txtDiemThi);
            this.grThongTinChiTiet.Controls.Add(this.txtMaMH);
            this.grThongTinChiTiet.Controls.Add(this.txtMaSV);
            this.grThongTinChiTiet.Controls.Add(this.label1);
            this.grThongTinChiTiet.Controls.Add(this.lblDiemThiLan1);
            this.grThongTinChiTiet.Controls.Add(this.lblHoVaTen);
            this.grThongTinChiTiet.Controls.Add(this.lblDiemTB);
            this.grThongTinChiTiet.Controls.Add(this.lblMaSV);
            this.grThongTinChiTiet.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grThongTinChiTiet.Location = new System.Drawing.Point(9, 48);
            this.grThongTinChiTiet.Margin = new System.Windows.Forms.Padding(2);
            this.grThongTinChiTiet.Name = "grThongTinChiTiet";
            this.grThongTinChiTiet.Padding = new System.Windows.Forms.Padding(2);
            this.grThongTinChiTiet.Size = new System.Drawing.Size(642, 132);
            this.grThongTinChiTiet.TabIndex = 19;
            this.grThongTinChiTiet.TabStop = false;
            this.grThongTinChiTiet.Text = "Thông tin chi tiết";
            // 
            // txtKTL2
            // 
            this.txtKTL2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtKTL2.Location = new System.Drawing.Point(350, 82);
            this.txtKTL2.Margin = new System.Windows.Forms.Padding(2);
            this.txtKTL2.Name = "txtKTL2";
            this.txtKTL2.Size = new System.Drawing.Size(76, 23);
            this.txtKTL2.TabIndex = 3;
            // 
            // txtDiemThi
            // 
            this.txtDiemThi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDiemThi.Location = new System.Drawing.Point(534, 81);
            this.txtDiemThi.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiemThi.Name = "txtDiemThi";
            this.txtDiemThi.Size = new System.Drawing.Size(76, 23);
            this.txtDiemThi.TabIndex = 4;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaSV.Location = new System.Drawing.Point(89, 34);
            this.txtMaSV.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(116, 23);
            this.txtMaSV.TabIndex = 0;
            // 
            // btnNhap
            // 
            this.btnNhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNhap.Location = new System.Drawing.Point(675, 62);
            this.btnNhap.Margin = new System.Windows.Forms.Padding(2);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(76, 82);
            this.btnNhap.TabIndex = 0;
            this.btnNhap.Text = "Nhập / Sửa";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.Location = new System.Drawing.Point(675, 148);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(76, 39);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.Location = new System.Drawing.Point(765, 148);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(76, 39);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnInBangDiem
            // 
            this.btnInBangDiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnInBangDiem.Location = new System.Drawing.Point(765, 62);
            this.btnInBangDiem.Margin = new System.Windows.Forms.Padding(2);
            this.btnInBangDiem.Name = "btnInBangDiem";
            this.btnInBangDiem.Size = new System.Drawing.Size(76, 39);
            this.btnInBangDiem.TabIndex = 2;
            this.btnInBangDiem.Text = "In / Xem";
            this.btnInBangDiem.UseVisualStyleBackColor = true;
            // 
            // grDanhSach
            // 
            this.grDanhSach.Controls.Add(this.dgvDanhSach);
            this.grDanhSach.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grDanhSach.Location = new System.Drawing.Point(11, 191);
            this.grDanhSach.Margin = new System.Windows.Forms.Padding(2);
            this.grDanhSach.Name = "grDanhSach";
            this.grDanhSach.Padding = new System.Windows.Forms.Padding(2);
            this.grDanhSach.Size = new System.Drawing.Size(830, 403);
            this.grDanhSach.TabIndex = 26;
            this.grDanhSach.TabStop = false;
            this.grDanhSach.Text = "Danh Sách";
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.AllowUserToAddRows = false;
            this.dgvDanhSach.AllowUserToDeleteRows = false;
            this.dgvDanhSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvMaSV,
            this.dgvMaMonHoc,
            this.dgvDiemKTL1,
            this.dgvDiemKTL2,
            this.dgvDiemThi,
            this.dgvDiemTongKet});
            this.dgvDanhSach.Location = new System.Drawing.Point(4, 20);
            this.dgvDanhSach.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.ReadOnly = true;
            this.dgvDanhSach.RowHeadersWidth = 51;
            this.dgvDanhSach.RowTemplate.Height = 24;
            this.dgvDanhSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSach.Size = new System.Drawing.Size(822, 379);
            this.dgvDanhSach.TabIndex = 0;
            this.dgvDanhSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSach_CellClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnRefresh.Location = new System.Drawing.Point(765, 105);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(76, 39);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtMaMH
            // 
            this.txtMaMH.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaMH.Location = new System.Drawing.Point(310, 34);
            this.txtMaMH.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.Size = new System.Drawing.Size(116, 23);
            this.txtMaMH.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(5, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Điểm KT lần 1";
            // 
            // txtKTL1
            // 
            this.txtKTL1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtKTL1.Location = new System.Drawing.Point(129, 81);
            this.txtKTL1.Margin = new System.Windows.Forms.Padding(2);
            this.txtKTL1.Name = "txtKTL1";
            this.txtKTL1.Size = new System.Drawing.Size(76, 23);
            this.txtKTL1.TabIndex = 2;
            // 
            // dgvMaSV
            // 
            this.dgvMaSV.HeaderText = "MaSV";
            this.dgvMaSV.MinimumWidth = 6;
            this.dgvMaSV.Name = "dgvMaSV";
            this.dgvMaSV.ReadOnly = true;
            // 
            // dgvMaMonHoc
            // 
            this.dgvMaMonHoc.HeaderText = "MaMonHoc";
            this.dgvMaMonHoc.MinimumWidth = 6;
            this.dgvMaMonHoc.Name = "dgvMaMonHoc";
            this.dgvMaMonHoc.ReadOnly = true;
            // 
            // dgvDiemKTL1
            // 
            this.dgvDiemKTL1.HeaderText = "DiemKTLan1";
            this.dgvDiemKTL1.MinimumWidth = 6;
            this.dgvDiemKTL1.Name = "dgvDiemKTL1";
            this.dgvDiemKTL1.ReadOnly = true;
            // 
            // dgvDiemKTL2
            // 
            this.dgvDiemKTL2.HeaderText = "DiemKTLan2";
            this.dgvDiemKTL2.MinimumWidth = 6;
            this.dgvDiemKTL2.Name = "dgvDiemKTL2";
            this.dgvDiemKTL2.ReadOnly = true;
            // 
            // dgvDiemThi
            // 
            this.dgvDiemThi.HeaderText = "DiemThi";
            this.dgvDiemThi.MinimumWidth = 6;
            this.dgvDiemThi.Name = "dgvDiemThi";
            this.dgvDiemThi.ReadOnly = true;
            // 
            // dgvDiemTongKet
            // 
            this.dgvDiemTongKet.HeaderText = "DiemTongKet";
            this.dgvDiemTongKet.MinimumWidth = 6;
            this.dgvDiemTongKet.Name = "dgvDiemTongKet";
            this.dgvDiemTongKet.ReadOnly = true;
            // 
            // NhapDiemSinhVien
            // 
            this.AcceptButton = this.btnNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 605);
            this.Controls.Add(this.grDanhSach);
            this.Controls.Add(this.btnInBangDiem);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.grThongTinChiTiet);
            this.Controls.Add(this.lblThongTinDiemSinhVien);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NhapDiemSinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NhapDiemSinhVien";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.NhapDiemSinhVien_Load);
            this.grThongTinChiTiet.ResumeLayout(false);
            this.grThongTinChiTiet.PerformLayout();
            this.grDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblThongTinDiemSinhVien;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.Label lblDiemTB;
        private System.Windows.Forms.Label lblHoVaTen;
        private System.Windows.Forms.Label lblDiemThiLan1;
        private System.Windows.Forms.GroupBox grThongTinChiTiet;
        private System.Windows.Forms.TextBox txtKTL2;
        private System.Windows.Forms.TextBox txtDiemThi;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnInBangDiem;
        private System.Windows.Forms.GroupBox grDanhSach;
        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.TextBox txtKTL1;
        private System.Windows.Forms.TextBox txtMaMH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMaMonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDiemKTL1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDiemKTL2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDiemThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDiemTongKet;
    }
}