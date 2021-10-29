
namespace csharp_winform
{
    partial class RP_DanhSachSV
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grbDiemTB = new System.Windows.Forms.GroupBox();
            this.rdbPass = new System.Windows.Forms.RadioButton();
            this.rdbMiss = new System.Windows.Forms.RadioButton();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnXuat = new System.Windows.Forms.Button();
            this.cbbKhoa = new System.Windows.Forms.ComboBox();
            this.cbbLop = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbDiem = new System.Windows.Forms.RadioButton();
            this.rdbKhoa = new System.Windows.Forms.RadioButton();
            this.rdbLop = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.RP_DSSV = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1.SuspendLayout();
            this.grbDiemTB.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grbDiemTB);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnXuat);
            this.groupBox1.Controls.Add(this.cbbKhoa);
            this.groupBox1.Controls.Add(this.cbbLop);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rdbDiem);
            this.groupBox1.Controls.Add(this.rdbKhoa);
            this.groupBox1.Controls.Add(this.rdbLop);
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(145, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(960, 265);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Các Lựa Chọn";
            // 
            // grbDiemTB
            // 
            this.grbDiemTB.Controls.Add(this.rdbPass);
            this.grbDiemTB.Controls.Add(this.rdbMiss);
            this.grbDiemTB.Location = new System.Drawing.Point(230, 160);
            this.grbDiemTB.Name = "grbDiemTB";
            this.grbDiemTB.Size = new System.Drawing.Size(246, 82);
            this.grbDiemTB.TabIndex = 3;
            this.grbDiemTB.TabStop = false;
            // 
            // rdbPass
            // 
            this.rdbPass.AutoSize = true;
            this.rdbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPass.ForeColor = System.Drawing.Color.Black;
            this.rdbPass.Location = new System.Drawing.Point(18, 49);
            this.rdbPass.Name = "rdbPass";
            this.rdbPass.Size = new System.Drawing.Size(168, 21);
            this.rdbPass.TabIndex = 0;
            this.rdbPass.TabStop = true;
            this.rdbPass.Text = "4 <= Điểm TB <=10";
            this.rdbPass.UseVisualStyleBackColor = true;
            // 
            // rdbMiss
            // 
            this.rdbMiss.AutoSize = true;
            this.rdbMiss.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMiss.ForeColor = System.Drawing.Color.Black;
            this.rdbMiss.Location = new System.Drawing.Point(18, 15);
            this.rdbMiss.Name = "rdbMiss";
            this.rdbMiss.Size = new System.Drawing.Size(155, 21);
            this.rdbMiss.TabIndex = 0;
            this.rdbMiss.TabStop = true;
            this.rdbMiss.Text = "0 <= Điểm TB  <4";
            this.rdbMiss.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.Location = new System.Drawing.Point(746, 193);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(123, 49);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnXuat
            // 
            this.btnXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuat.ForeColor = System.Drawing.Color.Blue;
            this.btnXuat.Location = new System.Drawing.Point(602, 193);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(123, 49);
            this.btnXuat.TabIndex = 1;
            this.btnXuat.Text = "Xuất / In";
            this.btnXuat.UseVisualStyleBackColor = true;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // cbbKhoa
            // 
            this.cbbKhoa.FormattingEnabled = true;
            this.cbbKhoa.Location = new System.Drawing.Point(230, 130);
            this.cbbKhoa.Name = "cbbKhoa";
            this.cbbKhoa.Size = new System.Drawing.Size(246, 24);
            this.cbbKhoa.TabIndex = 2;
            // 
            // cbbLop
            // 
            this.cbbLop.FormattingEnabled = true;
            this.cbbLop.Location = new System.Drawing.Point(230, 85);
            this.cbbLop.Name = "cbbLop";
            this.cbbLop.Size = new System.Drawing.Size(246, 24);
            this.cbbLop.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(954, 53);
            this.label1.TabIndex = 1;
            this.label1.Text = "Xuất Thống Kê Danh Sách SInh Viên";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rdbDiem
            // 
            this.rdbDiem.AutoSize = true;
            this.rdbDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDiem.ForeColor = System.Drawing.Color.Black;
            this.rdbDiem.Location = new System.Drawing.Point(87, 181);
            this.rdbDiem.Name = "rdbDiem";
            this.rdbDiem.Size = new System.Drawing.Size(132, 21);
            this.rdbDiem.TabIndex = 0;
            this.rdbDiem.TabStop = true;
            this.rdbDiem.Text = "Theo Điểm TB";
            this.rdbDiem.UseVisualStyleBackColor = true;
            this.rdbDiem.CheckedChanged += new System.EventHandler(this.rdbDiem_CheckedChanged);
            // 
            // rdbKhoa
            // 
            this.rdbKhoa.AutoSize = true;
            this.rdbKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbKhoa.ForeColor = System.Drawing.Color.Black;
            this.rdbKhoa.Location = new System.Drawing.Point(87, 130);
            this.rdbKhoa.Name = "rdbKhoa";
            this.rdbKhoa.Size = new System.Drawing.Size(108, 21);
            this.rdbKhoa.TabIndex = 0;
            this.rdbKhoa.TabStop = true;
            this.rdbKhoa.Text = "Theo Khoa";
            this.rdbKhoa.UseVisualStyleBackColor = true;
            this.rdbKhoa.CheckedChanged += new System.EventHandler(this.rdbKhoa_CheckedChanged);
            // 
            // rdbLop
            // 
            this.rdbLop.AutoSize = true;
            this.rdbLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbLop.ForeColor = System.Drawing.Color.Black;
            this.rdbLop.Location = new System.Drawing.Point(87, 85);
            this.rdbLop.Name = "rdbLop";
            this.rdbLop.Size = new System.Drawing.Size(93, 21);
            this.rdbLop.TabIndex = 0;
            this.rdbLop.TabStop = true;
            this.rdbLop.Text = "Theo lớp";
            this.rdbLop.UseVisualStyleBackColor = true;
            this.rdbLop.CheckedChanged += new System.EventHandler(this.rdbLop_CheckedChanged);
            // 
            // RP_DSSV
            // 
            this.RP_DSSV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RP_DSSV.Location = new System.Drawing.Point(14, 301);
            this.RP_DSSV.Name = "RP_DSSV";
            this.RP_DSSV.ServerReport.BearerToken = null;
            this.RP_DSSV.Size = new System.Drawing.Size(1212, 367);
            this.RP_DSSV.TabIndex = 1;
            // 
            // RP_DanhSachSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1246, 681);
            this.Controls.Add(this.RP_DSSV);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "RP_DanhSachSV";
            this.Text = "Thống Kê Danh Sách Sinh Viên";
            this.Load += new System.EventHandler(this.RP_DanhSachSV_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbDiemTB.ResumeLayout(false);
            this.grbDiemTB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbDiem;
        private System.Windows.Forms.RadioButton rdbKhoa;
        private System.Windows.Forms.RadioButton rdbLop;
        private System.Windows.Forms.ComboBox cbbKhoa;
        private System.Windows.Forms.ComboBox cbbLop;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnXuat;
        private Microsoft.Reporting.WinForms.ReportViewer RP_DSSV;
        private System.Windows.Forms.GroupBox grbDiemTB;
        private System.Windows.Forms.RadioButton rdbPass;
        private System.Windows.Forms.RadioButton rdbMiss;
    }
}