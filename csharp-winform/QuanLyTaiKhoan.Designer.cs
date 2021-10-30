
namespace csharp_winform
{
    partial class QuanLyTaiKhoan
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
            this.dgvDSTaiKhoan = new System.Windows.Forms.DataGridView();
            this.dgvUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grLuaChon = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbAdmin = new System.Windows.Forms.RadioButton();
            this.rbMember = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbNu = new System.Windows.Forms.RadioButton();
            this.rbNam = new System.Windows.Forms.RadioButton();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenDN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNhap = new System.Windows.Forms.Button();
            this.lblTenKhoa = new System.Windows.Forms.Label();
            this.lblMaKhoa = new System.Windows.Forms.Label();
            this.lblQuanLyKhoa = new System.Windows.Forms.Label();
            this.grDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSTaiKhoan)).BeginInit();
            this.grLuaChon.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grDanhSach
            // 
            this.grDanhSach.Controls.Add(this.dgvDSTaiKhoan);
            this.grDanhSach.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grDanhSach.ForeColor = System.Drawing.Color.Black;
            this.grDanhSach.Location = new System.Drawing.Point(283, 56);
            this.grDanhSach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grDanhSach.Name = "grDanhSach";
            this.grDanhSach.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grDanhSach.Size = new System.Drawing.Size(698, 456);
            this.grDanhSach.TabIndex = 13;
            this.grDanhSach.TabStop = false;
            this.grDanhSach.Text = "Danh sách";
            // 
            // dgvDSTaiKhoan
            // 
            this.dgvDSTaiKhoan.AllowUserToAddRows = false;
            this.dgvDSTaiKhoan.AllowUserToDeleteRows = false;
            this.dgvDSTaiKhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSTaiKhoan.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvDSTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSTaiKhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvUsername,
            this.dgvPassword,
            this.dgvFullName,
            this.dgvPhone,
            this.dgvEmail,
            this.dgvSex,
            this.dgvRole});
            this.dgvDSTaiKhoan.Location = new System.Drawing.Point(4, 25);
            this.dgvDSTaiKhoan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvDSTaiKhoan.Name = "dgvDSTaiKhoan";
            this.dgvDSTaiKhoan.ReadOnly = true;
            this.dgvDSTaiKhoan.RowHeadersWidth = 51;
            this.dgvDSTaiKhoan.RowTemplate.Height = 24;
            this.dgvDSTaiKhoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSTaiKhoan.Size = new System.Drawing.Size(690, 419);
            this.dgvDSTaiKhoan.TabIndex = 0;
            this.dgvDSTaiKhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSTaiKhoan_CellClick);
            // 
            // dgvUsername
            // 
            this.dgvUsername.HeaderText = "Tên Đăng Nhập";
            this.dgvUsername.MinimumWidth = 6;
            this.dgvUsername.Name = "dgvUsername";
            this.dgvUsername.ReadOnly = true;
            // 
            // dgvPassword
            // 
            this.dgvPassword.HeaderText = "Mật Khẩu";
            this.dgvPassword.MinimumWidth = 6;
            this.dgvPassword.Name = "dgvPassword";
            this.dgvPassword.ReadOnly = true;
            // 
            // dgvFullName
            // 
            this.dgvFullName.HeaderText = "Họ Tên";
            this.dgvFullName.MinimumWidth = 6;
            this.dgvFullName.Name = "dgvFullName";
            this.dgvFullName.ReadOnly = true;
            // 
            // dgvPhone
            // 
            this.dgvPhone.HeaderText = "Phone";
            this.dgvPhone.MinimumWidth = 6;
            this.dgvPhone.Name = "dgvPhone";
            this.dgvPhone.ReadOnly = true;
            // 
            // dgvEmail
            // 
            this.dgvEmail.HeaderText = "Email";
            this.dgvEmail.MinimumWidth = 6;
            this.dgvEmail.Name = "dgvEmail";
            this.dgvEmail.ReadOnly = true;
            // 
            // dgvSex
            // 
            this.dgvSex.HeaderText = "Giới Tính";
            this.dgvSex.MinimumWidth = 6;
            this.dgvSex.Name = "dgvSex";
            this.dgvSex.ReadOnly = true;
            // 
            // dgvRole
            // 
            this.dgvRole.HeaderText = "Quyền";
            this.dgvRole.MinimumWidth = 6;
            this.dgvRole.Name = "dgvRole";
            this.dgvRole.ReadOnly = true;
            // 
            // grLuaChon
            // 
            this.grLuaChon.Controls.Add(this.groupBox2);
            this.grLuaChon.Controls.Add(this.groupBox1);
            this.grLuaChon.Controls.Add(this.btnRefresh);
            this.grLuaChon.Controls.Add(this.btnThoat);
            this.grLuaChon.Controls.Add(this.txtEmail);
            this.grLuaChon.Controls.Add(this.txtPhone);
            this.grLuaChon.Controls.Add(this.txtHoTen);
            this.grLuaChon.Controls.Add(this.txtMK);
            this.grLuaChon.Controls.Add(this.label5);
            this.grLuaChon.Controls.Add(this.label4);
            this.grLuaChon.Controls.Add(this.label3);
            this.grLuaChon.Controls.Add(this.btnXoa);
            this.grLuaChon.Controls.Add(this.label2);
            this.grLuaChon.Controls.Add(this.txtTenDN);
            this.grLuaChon.Controls.Add(this.label1);
            this.grLuaChon.Controls.Add(this.btnNhap);
            this.grLuaChon.Controls.Add(this.lblTenKhoa);
            this.grLuaChon.Controls.Add(this.lblMaKhoa);
            this.grLuaChon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grLuaChon.ForeColor = System.Drawing.Color.Blue;
            this.grLuaChon.Location = new System.Drawing.Point(7, 56);
            this.grLuaChon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grLuaChon.Name = "grLuaChon";
            this.grLuaChon.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grLuaChon.Size = new System.Drawing.Size(272, 444);
            this.grLuaChon.TabIndex = 12;
            this.grLuaChon.TabStop = false;
            this.grLuaChon.Text = "Lựa chọn";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbAdmin);
            this.groupBox2.Controls.Add(this.rbMember);
            this.groupBox2.Location = new System.Drawing.Point(100, 292);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(161, 42);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // rbAdmin
            // 
            this.rbAdmin.AutoSize = true;
            this.rbAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAdmin.ForeColor = System.Drawing.Color.Black;
            this.rbAdmin.Location = new System.Drawing.Point(91, 13);
            this.rbAdmin.Name = "rbAdmin";
            this.rbAdmin.Size = new System.Drawing.Size(59, 17);
            this.rbAdmin.TabIndex = 0;
            this.rbAdmin.TabStop = true;
            this.rbAdmin.Text = "Admin";
            this.rbAdmin.UseVisualStyleBackColor = true;
            // 
            // rbMember
            // 
            this.rbMember.AutoSize = true;
            this.rbMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMember.ForeColor = System.Drawing.Color.Black;
            this.rbMember.Location = new System.Drawing.Point(6, 13);
            this.rbMember.Name = "rbMember";
            this.rbMember.Size = new System.Drawing.Size(69, 17);
            this.rbMember.TabIndex = 0;
            this.rbMember.TabStop = true;
            this.rbMember.Text = "Member";
            this.rbMember.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbNu);
            this.groupBox1.Controls.Add(this.rbNam);
            this.groupBox1.Location = new System.Drawing.Point(100, 246);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(161, 42);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // rbNu
            // 
            this.rbNu.AutoSize = true;
            this.rbNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNu.ForeColor = System.Drawing.Color.Black;
            this.rbNu.Location = new System.Drawing.Point(91, 14);
            this.rbNu.Name = "rbNu";
            this.rbNu.Size = new System.Drawing.Size(41, 17);
            this.rbNu.TabIndex = 1;
            this.rbNu.TabStop = true;
            this.rbNu.Text = "Nữ";
            this.rbNu.UseVisualStyleBackColor = true;
            // 
            // rbNam
            // 
            this.rbNam.AutoSize = true;
            this.rbNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNam.ForeColor = System.Drawing.Color.Black;
            this.rbNam.Location = new System.Drawing.Point(6, 14);
            this.rbNam.Name = "rbNam";
            this.rbNam.Size = new System.Drawing.Size(50, 17);
            this.rbNam.TabIndex = 0;
            this.rbNam.TabStop = true;
            this.rbNam.Text = "Nam";
            this.rbNam.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Location = new System.Drawing.Point(38, 411);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 27);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Black;
            this.btnThoat.Location = new System.Drawing.Point(181, 408);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(74, 33);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(100, 215);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(157, 26);
            this.txtEmail.TabIndex = 1;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(98, 171);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(157, 26);
            this.txtPhone.TabIndex = 1;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(100, 128);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(157, 26);
            this.txtHoTen.TabIndex = 1;
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(100, 81);
            this.txtMK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(157, 26);
            this.txtMK.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(35, 264);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Giới tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(47, 307);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Quyền";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(53, 220);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.Location = new System.Drawing.Point(181, 370);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(74, 33);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(51, 176);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Phone";
            // 
            // txtTenDN
            // 
            this.txtTenDN.Location = new System.Drawing.Point(100, 34);
            this.txtTenDN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenDN.Name = "txtTenDN";
            this.txtTenDN.Size = new System.Drawing.Size(155, 26);
            this.txtTenDN.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(51, 133);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Họ tên";
            // 
            // btnNhap
            // 
            this.btnNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhap.ForeColor = System.Drawing.Color.Black;
            this.btnNhap.Location = new System.Drawing.Point(20, 370);
            this.btnNhap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(121, 33);
            this.btnNhap.TabIndex = 2;
            this.btnNhap.Text = "Thêm / Sửa";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // lblTenKhoa
            // 
            this.lblTenKhoa.AutoSize = true;
            this.lblTenKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenKhoa.ForeColor = System.Drawing.Color.Black;
            this.lblTenKhoa.Location = new System.Drawing.Point(35, 86);
            this.lblTenKhoa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenKhoa.Name = "lblTenKhoa";
            this.lblTenKhoa.Size = new System.Drawing.Size(60, 13);
            this.lblTenKhoa.TabIndex = 2;
            this.lblTenKhoa.Text = "Mật khẩu";
            // 
            // lblMaKhoa
            // 
            this.lblMaKhoa.AutoSize = true;
            this.lblMaKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaKhoa.ForeColor = System.Drawing.Color.Black;
            this.lblMaKhoa.Location = new System.Drawing.Point(4, 39);
            this.lblMaKhoa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaKhoa.Name = "lblMaKhoa";
            this.lblMaKhoa.Size = new System.Drawing.Size(94, 13);
            this.lblMaKhoa.TabIndex = 1;
            this.lblMaKhoa.Text = "Tên đăng nhập";
            // 
            // lblQuanLyKhoa
            // 
            this.lblQuanLyKhoa.AutoSize = true;
            this.lblQuanLyKhoa.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblQuanLyKhoa.ForeColor = System.Drawing.Color.Red;
            this.lblQuanLyKhoa.Location = new System.Drawing.Point(320, 9);
            this.lblQuanLyKhoa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuanLyKhoa.Name = "lblQuanLyKhoa";
            this.lblQuanLyKhoa.Size = new System.Drawing.Size(265, 26);
            this.lblQuanLyKhoa.TabIndex = 11;
            this.lblQuanLyKhoa.Text = "QUẢN LÝ TÀI KHOẢN";
            // 
            // QuanLyTaiKhoan
            // 
            this.AcceptButton = this.btnNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(992, 511);
            this.Controls.Add(this.grDanhSach);
            this.Controls.Add(this.grLuaChon);
            this.Controls.Add(this.lblQuanLyKhoa);
            this.Name = "QuanLyTaiKhoan";
            this.Text = "Quản Lý Tài Khoản";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.QuanLyTaiKhoan_Load);
            this.grDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSTaiKhoan)).EndInit();
            this.grLuaChon.ResumeLayout(false);
            this.grLuaChon.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grDanhSach;
        private System.Windows.Forms.DataGridView dgvDSTaiKhoan;
        private System.Windows.Forms.GroupBox grLuaChon;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtTenDN;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.Label lblTenKhoa;
        private System.Windows.Forms.Label lblMaKhoa;
        private System.Windows.Forms.Label lblQuanLyKhoa;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbMember;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbNu;
        private System.Windows.Forms.RadioButton rbNam;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbAdmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvRole;
    }
}