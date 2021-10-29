
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnNhap = new System.Windows.Forms.Button();
            this.grDanhSach = new System.Windows.Forms.GroupBox();
            this.dgvDSKhoa = new System.Windows.Forms.DataGridView();
            this.grLuaChon = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtTenKhoa = new System.Windows.Forms.TextBox();
            this.txtMaKhoa = new System.Windows.Forms.TextBox();
            this.lblTenKhoa = new System.Windows.Forms.Label();
            this.lblMaKhoa = new System.Windows.Forms.Label();
            this.lblQuanLyKhoa = new System.Windows.Forms.Label();
            this.MaKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSKhoa)).BeginInit();
            this.grLuaChon.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.Location = new System.Drawing.Point(228, 391);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(99, 41);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.Location = new System.Drawing.Point(228, 180);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(99, 41);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnNhap
            // 
            this.btnNhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNhap.Location = new System.Drawing.Point(33, 180);
            this.btnNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(161, 41);
            this.btnNhap.TabIndex = 2;
            this.btnNhap.Text = "Thêm / Sửa";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // grDanhSach
            // 
            this.grDanhSach.Controls.Add(this.dgvDSKhoa);
            this.grDanhSach.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grDanhSach.Location = new System.Drawing.Point(383, 70);
            this.grDanhSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grDanhSach.Name = "grDanhSach";
            this.grDanhSach.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grDanhSach.Size = new System.Drawing.Size(612, 460);
            this.grDanhSach.TabIndex = 10;
            this.grDanhSach.TabStop = false;
            this.grDanhSach.Text = "Danh sách";
            // 
            // dgvDSKhoa
            // 
            this.dgvDSKhoa.AllowUserToAddRows = false;
            this.dgvDSKhoa.AllowUserToDeleteRows = false;
            this.dgvDSKhoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSKhoa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDSKhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSKhoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKhoa,
            this.TenKhoa});
            this.dgvDSKhoa.Location = new System.Drawing.Point(5, 31);
            this.dgvDSKhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDSKhoa.Name = "dgvDSKhoa";
            this.dgvDSKhoa.ReadOnly = true;
            this.dgvDSKhoa.RowHeadersWidth = 51;
            this.dgvDSKhoa.RowTemplate.Height = 24;
            this.dgvDSKhoa.Size = new System.Drawing.Size(601, 425);
            this.dgvDSKhoa.TabIndex = 0;
            this.dgvDSKhoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSKhoa_CellClick);
            // 
            // grLuaChon
            // 
            this.grLuaChon.Controls.Add(this.btnRefresh);
            this.grLuaChon.Controls.Add(this.btnThoat);
            this.grLuaChon.Controls.Add(this.txtTenKhoa);
            this.grLuaChon.Controls.Add(this.btnXoa);
            this.grLuaChon.Controls.Add(this.txtMaKhoa);
            this.grLuaChon.Controls.Add(this.btnNhap);
            this.grLuaChon.Controls.Add(this.lblTenKhoa);
            this.grLuaChon.Controls.Add(this.lblMaKhoa);
            this.grLuaChon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grLuaChon.Location = new System.Drawing.Point(15, 70);
            this.grLuaChon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grLuaChon.Name = "grLuaChon";
            this.grLuaChon.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grLuaChon.Size = new System.Drawing.Size(348, 460);
            this.grLuaChon.TabIndex = 9;
            this.grLuaChon.TabStop = false;
            this.grLuaChon.Text = "Lựa chọn";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(33, 399);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 33);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtTenKhoa
            // 
            this.txtTenKhoa.Location = new System.Drawing.Point(120, 117);
            this.txtTenKhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenKhoa.Name = "txtTenKhoa";
            this.txtTenKhoa.Size = new System.Drawing.Size(208, 30);
            this.txtTenKhoa.TabIndex = 1;
            // 
            // txtMaKhoa
            // 
            this.txtMaKhoa.Location = new System.Drawing.Point(120, 59);
            this.txtMaKhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Size = new System.Drawing.Size(205, 30);
            this.txtMaKhoa.TabIndex = 0;
            // 
            // lblTenKhoa
            // 
            this.lblTenKhoa.AutoSize = true;
            this.lblTenKhoa.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTenKhoa.Location = new System.Drawing.Point(27, 117);
            this.lblTenKhoa.Name = "lblTenKhoa";
            this.lblTenKhoa.Size = new System.Drawing.Size(74, 19);
            this.lblTenKhoa.TabIndex = 2;
            this.lblTenKhoa.Text = "Tên Khoa";
            // 
            // lblMaKhoa
            // 
            this.lblMaKhoa.AutoSize = true;
            this.lblMaKhoa.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaKhoa.Location = new System.Drawing.Point(29, 59);
            this.lblMaKhoa.Name = "lblMaKhoa";
            this.lblMaKhoa.Size = new System.Drawing.Size(71, 19);
            this.lblMaKhoa.TabIndex = 1;
            this.lblMaKhoa.Text = "Mã Khoa";
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
            // MaKhoa
            // 
            this.MaKhoa.HeaderText = "Mã Khoa";
            this.MaKhoa.MinimumWidth = 6;
            this.MaKhoa.Name = "MaKhoa";
            this.MaKhoa.ReadOnly = true;
            // 
            // TenKhoa
            // 
            this.TenKhoa.HeaderText = "Tên Khoa";
            this.TenKhoa.MinimumWidth = 6;
            this.TenKhoa.Name = "TenKhoa";
            this.TenKhoa.ReadOnly = true;
            // 
            // QuanLyKhoa
            // 
            this.AcceptButton = this.btnNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 569);
            this.Controls.Add(this.grDanhSach);
            this.Controls.Add(this.grLuaChon);
            this.Controls.Add(this.lblQuanLyKhoa);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "QuanLyKhoa";
            this.Text = "QuanLyKhoa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.QuanLyKhoa_Load);
            this.grDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSKhoa)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvDSKhoa;
        private System.Windows.Forms.GroupBox grLuaChon;
        private System.Windows.Forms.TextBox txtTenKhoa;
        private System.Windows.Forms.TextBox txtMaKhoa;
        private System.Windows.Forms.Label lblTenKhoa;
        private System.Windows.Forms.Label lblMaKhoa;
        private System.Windows.Forms.Label lblQuanLyKhoa;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhoa;
    }
}