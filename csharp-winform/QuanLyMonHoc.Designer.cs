
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
            this.grDanhSach = new System.Windows.Forms.GroupBox();
            this.dgvDSMonHoc = new System.Windows.Forms.DataGridView();
            this.dgvMaMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTCLT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTCTH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grThongTinChiTiet = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnNhap = new System.Windows.Forms.Button();
            this.txtTCTH = new System.Windows.Forms.TextBox();
            this.txtTCLT = new System.Windows.Forms.TextBox();
            this.txtTenMon = new System.Windows.Forms.TextBox();
            this.txtMaMon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSoDVHT = new System.Windows.Forms.Label();
            this.lblTenMon = new System.Windows.Forms.Label();
            this.lblMaMon = new System.Windows.Forms.Label();
            this.lblDanhSachMonHoc = new System.Windows.Forms.Label();
            this.grDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSMonHoc)).BeginInit();
            this.grThongTinChiTiet.SuspendLayout();
            this.SuspendLayout();
            // 
            // grDanhSach
            // 
            this.grDanhSach.Controls.Add(this.dgvDSMonHoc);
            this.grDanhSach.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grDanhSach.Location = new System.Drawing.Point(514, 64);
            this.grDanhSach.Margin = new System.Windows.Forms.Padding(4);
            this.grDanhSach.Name = "grDanhSach";
            this.grDanhSach.Padding = new System.Windows.Forms.Padding(4);
            this.grDanhSach.Size = new System.Drawing.Size(495, 440);
            this.grDanhSach.TabIndex = 11;
            this.grDanhSach.TabStop = false;
            this.grDanhSach.Text = "Danh sách";
            // 
            // dgvDSMonHoc
            // 
            this.dgvDSMonHoc.AllowUserToAddRows = false;
            this.dgvDSMonHoc.AllowUserToDeleteRows = false;
            this.dgvDSMonHoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSMonHoc.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvDSMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSMonHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvMaMon,
            this.dgvTenMon,
            this.dgvTCLT,
            this.dgvTCTH});
            this.dgvDSMonHoc.Location = new System.Drawing.Point(8, 33);
            this.dgvDSMonHoc.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDSMonHoc.Name = "dgvDSMonHoc";
            this.dgvDSMonHoc.ReadOnly = true;
            this.dgvDSMonHoc.RowHeadersWidth = 51;
            this.dgvDSMonHoc.RowTemplate.Height = 24;
            this.dgvDSMonHoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSMonHoc.Size = new System.Drawing.Size(479, 394);
            this.dgvDSMonHoc.TabIndex = 0;
            this.dgvDSMonHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSMonHoc_CellClick);
            // 
            // dgvMaMon
            // 
            this.dgvMaMon.HeaderText = "MaMon";
            this.dgvMaMon.MinimumWidth = 6;
            this.dgvMaMon.Name = "dgvMaMon";
            this.dgvMaMon.ReadOnly = true;
            // 
            // dgvTenMon
            // 
            this.dgvTenMon.HeaderText = "TenMon";
            this.dgvTenMon.MinimumWidth = 6;
            this.dgvTenMon.Name = "dgvTenMon";
            this.dgvTenMon.ReadOnly = true;
            // 
            // dgvTCLT
            // 
            this.dgvTCLT.HeaderText = "TCLT";
            this.dgvTCLT.MinimumWidth = 6;
            this.dgvTCLT.Name = "dgvTCLT";
            this.dgvTCLT.ReadOnly = true;
            // 
            // dgvTCTH
            // 
            this.dgvTCTH.HeaderText = "TCTH";
            this.dgvTCTH.MinimumWidth = 6;
            this.dgvTCTH.Name = "dgvTCTH";
            this.dgvTCTH.ReadOnly = true;
            // 
            // grThongTinChiTiet
            // 
            this.grThongTinChiTiet.Controls.Add(this.btnRefresh);
            this.grThongTinChiTiet.Controls.Add(this.btnThoat);
            this.grThongTinChiTiet.Controls.Add(this.btnXoa);
            this.grThongTinChiTiet.Controls.Add(this.btnNhap);
            this.grThongTinChiTiet.Controls.Add(this.txtTCTH);
            this.grThongTinChiTiet.Controls.Add(this.txtTCLT);
            this.grThongTinChiTiet.Controls.Add(this.txtTenMon);
            this.grThongTinChiTiet.Controls.Add(this.txtMaMon);
            this.grThongTinChiTiet.Controls.Add(this.label1);
            this.grThongTinChiTiet.Controls.Add(this.lblSoDVHT);
            this.grThongTinChiTiet.Controls.Add(this.lblTenMon);
            this.grThongTinChiTiet.Controls.Add(this.lblMaMon);
            this.grThongTinChiTiet.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grThongTinChiTiet.Location = new System.Drawing.Point(13, 64);
            this.grThongTinChiTiet.Margin = new System.Windows.Forms.Padding(4);
            this.grThongTinChiTiet.Name = "grThongTinChiTiet";
            this.grThongTinChiTiet.Padding = new System.Windows.Forms.Padding(4);
            this.grThongTinChiTiet.Size = new System.Drawing.Size(442, 367);
            this.grThongTinChiTiet.TabIndex = 10;
            this.grThongTinChiTiet.TabStop = false;
            this.grThongTinChiTiet.Text = "Thông tin chi tiết";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(23, 252);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 27);
            this.btnRefresh.TabIndex = 18;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.Location = new System.Drawing.Point(255, 305);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(88, 32);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.Location = new System.Drawing.Point(255, 251);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(88, 28);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnNhap
            // 
            this.btnNhap.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNhap.Location = new System.Drawing.Point(121, 251);
            this.btnNhap.Margin = new System.Windows.Forms.Padding(4);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(116, 28);
            this.btnNhap.TabIndex = 1;
            this.btnNhap.Text = "Thêm / Sửa";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // txtTCTH
            // 
            this.txtTCTH.Location = new System.Drawing.Point(159, 193);
            this.txtTCTH.Margin = new System.Windows.Forms.Padding(4);
            this.txtTCTH.Name = "txtTCTH";
            this.txtTCTH.Size = new System.Drawing.Size(205, 30);
            this.txtTCTH.TabIndex = 14;
            // 
            // txtTCLT
            // 
            this.txtTCLT.Location = new System.Drawing.Point(159, 139);
            this.txtTCLT.Margin = new System.Windows.Forms.Padding(4);
            this.txtTCLT.Name = "txtTCLT";
            this.txtTCLT.Size = new System.Drawing.Size(205, 30);
            this.txtTCLT.TabIndex = 14;
            // 
            // txtTenMon
            // 
            this.txtTenMon.Location = new System.Drawing.Point(159, 86);
            this.txtTenMon.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.Size = new System.Drawing.Size(205, 30);
            this.txtTenMon.TabIndex = 13;
            // 
            // txtMaMon
            // 
            this.txtMaMon.Location = new System.Drawing.Point(159, 33);
            this.txtMaMon.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaMon.Name = "txtMaMon";
            this.txtMaMon.Size = new System.Drawing.Size(205, 30);
            this.txtMaMon.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(2, 193);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Số tín chỉ thực hành:";
            // 
            // lblSoDVHT
            // 
            this.lblSoDVHT.AutoSize = true;
            this.lblSoDVHT.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSoDVHT.Location = new System.Drawing.Point(8, 144);
            this.lblSoDVHT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoDVHT.Name = "lblSoDVHT";
            this.lblSoDVHT.Size = new System.Drawing.Size(142, 19);
            this.lblSoDVHT.TabIndex = 3;
            this.lblSoDVHT.Text = "Số tín chỉ lý thuyết:";
            // 
            // lblTenMon
            // 
            this.lblTenMon.AutoSize = true;
            this.lblTenMon.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTenMon.Location = new System.Drawing.Point(48, 91);
            this.lblTenMon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenMon.Name = "lblTenMon";
            this.lblTenMon.Size = new System.Drawing.Size(102, 19);
            this.lblTenMon.TabIndex = 2;
            this.lblTenMon.Text = "Tên môn học:";
            // 
            // lblMaMon
            // 
            this.lblMaMon.AutoSize = true;
            this.lblMaMon.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaMon.Location = new System.Drawing.Point(51, 44);
            this.lblMaMon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaMon.Name = "lblMaMon";
            this.lblMaMon.Size = new System.Drawing.Size(99, 19);
            this.lblMaMon.TabIndex = 1;
            this.lblMaMon.Text = "Mã môn học:";
            // 
            // lblDanhSachMonHoc
            // 
            this.lblDanhSachMonHoc.AutoSize = true;
            this.lblDanhSachMonHoc.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDanhSachMonHoc.ForeColor = System.Drawing.Color.Red;
            this.lblDanhSachMonHoc.Location = new System.Drawing.Point(271, 21);
            this.lblDanhSachMonHoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDanhSachMonHoc.Name = "lblDanhSachMonHoc";
            this.lblDanhSachMonHoc.Size = new System.Drawing.Size(342, 34);
            this.lblDanhSachMonHoc.TabIndex = 9;
            this.lblDanhSachMonHoc.Text = "DANH SÁCH MÔN HỌC";
            // 
            // QuanLyMonHoc
            // 
            this.AcceptButton = this.btnNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 708);
            this.Controls.Add(this.grDanhSach);
            this.Controls.Add(this.grThongTinChiTiet);
            this.Controls.Add(this.lblDanhSachMonHoc);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QuanLyMonHoc";
            this.Text = "QuanLyMonHoc";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.QuanLyMonHoc_Load);
            this.grDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSMonHoc)).EndInit();
            this.grThongTinChiTiet.ResumeLayout(false);
            this.grThongTinChiTiet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grDanhSach;
        private System.Windows.Forms.DataGridView dgvDSMonHoc;
        private System.Windows.Forms.GroupBox grThongTinChiTiet;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.TextBox txtTCLT;
        private System.Windows.Forms.TextBox txtTenMon;
        private System.Windows.Forms.TextBox txtMaMon;
        private System.Windows.Forms.Label lblSoDVHT;
        private System.Windows.Forms.Label lblTenMon;
        private System.Windows.Forms.Label lblMaMon;
        private System.Windows.Forms.Label lblDanhSachMonHoc;
        private System.Windows.Forms.TextBox txtTCTH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMaMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTCLT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTCTH;
    }
}