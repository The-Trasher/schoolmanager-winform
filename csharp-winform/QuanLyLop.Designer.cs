﻿
namespace csharp_winform
{
    partial class QuanLyLop
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnNhap = new System.Windows.Forms.Button();
            this.grDanhSach = new System.Windows.Forms.GroupBox();
            this.dgvDSLop = new System.Windows.Forms.DataGridView();
            this.grLuaChon = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.cbbKhoa = new System.Windows.Forms.ComboBox();
            this.lblMaKhoa = new System.Windows.Forms.Label();
            this.txtSiSo = new System.Windows.Forms.TextBox();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.lblTenLop = new System.Windows.Forms.Label();
            this.lblMaLop = new System.Windows.Forms.Label();
            this.lblQuanLyLop = new System.Windows.Forms.Label();
            this.MaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSiSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSLop)).BeginInit();
            this.grLuaChon.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.Location = new System.Drawing.Point(228, 401);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(99, 41);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.Location = new System.Drawing.Point(228, 276);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(99, 41);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnNhap
            // 
            this.btnNhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNhap.Location = new System.Drawing.Point(33, 276);
            this.btnNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(159, 41);
            this.btnNhap.TabIndex = 4;
            this.btnNhap.Text = "Thêm / Sửa";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // grDanhSach
            // 
            this.grDanhSach.Controls.Add(this.dgvDSLop);
            this.grDanhSach.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grDanhSach.Location = new System.Drawing.Point(395, 98);
            this.grDanhSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grDanhSach.Name = "grDanhSach";
            this.grDanhSach.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grDanhSach.Size = new System.Drawing.Size(656, 460);
            this.grDanhSach.TabIndex = 17;
            this.grDanhSach.TabStop = false;
            this.grDanhSach.Text = "Danh sách";
            // 
            // dgvDSLop
            // 
            this.dgvDSLop.AllowUserToAddRows = false;
            this.dgvDSLop.AllowUserToDeleteRows = false;
            this.dgvDSLop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSLop.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDSLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSLop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLop,
            this.TenLop,
            this.MaKhoa,
            this.dgvSiSo});
            this.dgvDSLop.Location = new System.Drawing.Point(28, 30);
            this.dgvDSLop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDSLop.Name = "dgvDSLop";
            this.dgvDSLop.ReadOnly = true;
            this.dgvDSLop.RowHeadersWidth = 51;
            this.dgvDSLop.RowTemplate.Height = 24;
            this.dgvDSLop.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSLop.Size = new System.Drawing.Size(607, 425);
            this.dgvDSLop.TabIndex = 0;
            this.dgvDSLop.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSLop_CellClick);
            // 
            // grLuaChon
            // 
            this.grLuaChon.Controls.Add(this.btnRefresh);
            this.grLuaChon.Controls.Add(this.btnThoat);
            this.grLuaChon.Controls.Add(this.cbbKhoa);
            this.grLuaChon.Controls.Add(this.btnXoa);
            this.grLuaChon.Controls.Add(this.lblMaKhoa);
            this.grLuaChon.Controls.Add(this.btnNhap);
            this.grLuaChon.Controls.Add(this.txtSiSo);
            this.grLuaChon.Controls.Add(this.txtTenLop);
            this.grLuaChon.Controls.Add(this.label1);
            this.grLuaChon.Controls.Add(this.txtMaLop);
            this.grLuaChon.Controls.Add(this.lblTenLop);
            this.grLuaChon.Controls.Add(this.lblMaLop);
            this.grLuaChon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grLuaChon.Location = new System.Drawing.Point(31, 98);
            this.grLuaChon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grLuaChon.Name = "grLuaChon";
            this.grLuaChon.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grLuaChon.Size = new System.Drawing.Size(348, 460);
            this.grLuaChon.TabIndex = 16;
            this.grLuaChon.TabStop = false;
            this.grLuaChon.Text = "Lựa chọn";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(31, 409);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 33);
            this.btnRefresh.TabIndex = 18;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // cbbKhoa
            // 
            this.cbbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbKhoa.FormattingEnabled = true;
            this.cbbKhoa.Location = new System.Drawing.Point(120, 224);
            this.cbbKhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbKhoa.Name = "cbbKhoa";
            this.cbbKhoa.Size = new System.Drawing.Size(205, 30);
            this.cbbKhoa.TabIndex = 3;
            // 
            // lblMaKhoa
            // 
            this.lblMaKhoa.AutoSize = true;
            this.lblMaKhoa.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaKhoa.Location = new System.Drawing.Point(27, 229);
            this.lblMaKhoa.Name = "lblMaKhoa";
            this.lblMaKhoa.Size = new System.Drawing.Size(67, 19);
            this.lblMaKhoa.TabIndex = 5;
            this.lblMaKhoa.Text = "Mã khoa";
            // 
            // txtSiSo
            // 
            this.txtSiSo.Location = new System.Drawing.Point(120, 167);
            this.txtSiSo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSiSo.Name = "txtSiSo";
            this.txtSiSo.Size = new System.Drawing.Size(205, 30);
            this.txtSiSo.TabIndex = 2;
            // 
            // txtTenLop
            // 
            this.txtTenLop.Location = new System.Drawing.Point(120, 116);
            this.txtTenLop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(205, 30);
            this.txtTenLop.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(27, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sĩ số";
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(120, 59);
            this.txtMaLop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(205, 30);
            this.txtMaLop.TabIndex = 0;
            // 
            // lblTenLop
            // 
            this.lblTenLop.AutoSize = true;
            this.lblTenLop.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTenLop.Location = new System.Drawing.Point(27, 119);
            this.lblTenLop.Name = "lblTenLop";
            this.lblTenLop.Size = new System.Drawing.Size(60, 19);
            this.lblTenLop.TabIndex = 2;
            this.lblTenLop.Text = "Tên lớp";
            // 
            // lblMaLop
            // 
            this.lblMaLop.AutoSize = true;
            this.lblMaLop.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaLop.Location = new System.Drawing.Point(29, 59);
            this.lblMaLop.Name = "lblMaLop";
            this.lblMaLop.Size = new System.Drawing.Size(57, 19);
            this.lblMaLop.TabIndex = 1;
            this.lblMaLop.Text = "Mã lớp";
            // 
            // lblQuanLyLop
            // 
            this.lblQuanLyLop.AutoSize = true;
            this.lblQuanLyLop.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblQuanLyLop.ForeColor = System.Drawing.Color.Red;
            this.lblQuanLyLop.Location = new System.Drawing.Point(416, 36);
            this.lblQuanLyLop.Name = "lblQuanLyLop";
            this.lblQuanLyLop.Size = new System.Drawing.Size(223, 35);
            this.lblQuanLyLop.TabIndex = 15;
            this.lblQuanLyLop.Text = "QUẢN LÝ LỚP";
            // 
            // MaLop
            // 
            this.MaLop.HeaderText = "Mã Lớp";
            this.MaLop.MinimumWidth = 6;
            this.MaLop.Name = "MaLop";
            this.MaLop.ReadOnly = true;
            // 
            // TenLop
            // 
            this.TenLop.HeaderText = "Tên Lớp";
            this.TenLop.MinimumWidth = 6;
            this.TenLop.Name = "TenLop";
            this.TenLop.ReadOnly = true;
            // 
            // MaKhoa
            // 
            this.MaKhoa.HeaderText = "Mã Khoa";
            this.MaKhoa.MinimumWidth = 6;
            this.MaKhoa.Name = "MaKhoa";
            this.MaKhoa.ReadOnly = true;
            // 
            // dgvSiSo
            // 
            this.dgvSiSo.HeaderText = "Sĩ Số";
            this.dgvSiSo.MinimumWidth = 6;
            this.dgvSiSo.Name = "dgvSiSo";
            this.dgvSiSo.ReadOnly = true;
            // 
            // QuanLyLop
            // 
            this.AcceptButton = this.btnNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 594);
            this.Controls.Add(this.grDanhSach);
            this.Controls.Add(this.grLuaChon);
            this.Controls.Add(this.lblQuanLyLop);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "QuanLyLop";
            this.Text = "QuanLyLop";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.QuanLyLop_Load);
            this.grDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSLop)).EndInit();
            this.grLuaChon.ResumeLayout(false);
            this.grLuaChon.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.GroupBox grDanhSach;
        private System.Windows.Forms.DataGridView dgvDSLop;
        private System.Windows.Forms.GroupBox grLuaChon;
        private System.Windows.Forms.ComboBox cbbKhoa;
        private System.Windows.Forms.Label lblMaKhoa;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.Label lblTenLop;
        private System.Windows.Forms.Label lblMaLop;
        private System.Windows.Forms.Label lblQuanLyLop;
        private System.Windows.Forms.TextBox txtSiSo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSiSo;
    }
}