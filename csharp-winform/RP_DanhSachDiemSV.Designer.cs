
namespace csharp_winform
{
    partial class RP_DanhSachDiemSV
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
            this.rdbLop = new System.Windows.Forms.RadioButton();
            this.rdbMonHoc = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnXuat = new System.Windows.Forms.Button();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.cbbMonHoc = new System.Windows.Forms.ComboBox();
            this.cbbLop = new System.Windows.Forms.ComboBox();
            this.rdbMSSV = new System.Windows.Forms.RadioButton();
            this.RP_Diem = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdbLop
            // 
            this.rdbLop.AutoSize = true;
            this.rdbLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbLop.ForeColor = System.Drawing.Color.Black;
            this.rdbLop.Location = new System.Drawing.Point(26, 93);
            this.rdbLop.Name = "rdbLop";
            this.rdbLop.Size = new System.Drawing.Size(98, 21);
            this.rdbLop.TabIndex = 0;
            this.rdbLop.TabStop = true;
            this.rdbLop.Text = "Theo Lớp";
            this.rdbLop.UseVisualStyleBackColor = true;
            this.rdbLop.CheckedChanged += new System.EventHandler(this.rdbLop_CheckedChanged);
            // 
            // rdbMonHoc
            // 
            this.rdbMonHoc.AutoSize = true;
            this.rdbMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMonHoc.ForeColor = System.Drawing.Color.Black;
            this.rdbMonHoc.Location = new System.Drawing.Point(26, 136);
            this.rdbMonHoc.Name = "rdbMonHoc";
            this.rdbMonHoc.Size = new System.Drawing.Size(134, 21);
            this.rdbMonHoc.TabIndex = 1;
            this.rdbMonHoc.TabStop = true;
            this.rdbMonHoc.Text = "Theo Môn Học";
            this.rdbMonHoc.UseVisualStyleBackColor = true;
            this.rdbMonHoc.CheckedChanged += new System.EventHandler(this.rdbMonHoc_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnXuat);
            this.groupBox1.Controls.Add(this.txtMSSV);
            this.groupBox1.Controls.Add(this.cbbMonHoc);
            this.groupBox1.Controls.Add(this.cbbLop);
            this.groupBox1.Controls.Add(this.rdbMSSV);
            this.groupBox1.Controls.Add(this.rdbLop);
            this.groupBox1.Controls.Add(this.rdbMonHoc);
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(188, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(784, 199);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Các Lựa Chọn";
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.Location = new System.Drawing.Point(502, 119);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(106, 38);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnXuat
            // 
            this.btnXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuat.ForeColor = System.Drawing.Color.Blue;
            this.btnXuat.Location = new System.Drawing.Point(502, 47);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(106, 54);
            this.btnXuat.TabIndex = 4;
            this.btnXuat.Text = "Xuất / In";
            this.btnXuat.UseVisualStyleBackColor = true;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(171, 47);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(204, 22);
            this.txtMSSV.TabIndex = 3;
            // 
            // cbbMonHoc
            // 
            this.cbbMonHoc.FormattingEnabled = true;
            this.cbbMonHoc.Location = new System.Drawing.Point(171, 135);
            this.cbbMonHoc.Name = "cbbMonHoc";
            this.cbbMonHoc.Size = new System.Drawing.Size(205, 24);
            this.cbbMonHoc.TabIndex = 2;
            // 
            // cbbLop
            // 
            this.cbbLop.FormattingEnabled = true;
            this.cbbLop.Location = new System.Drawing.Point(171, 92);
            this.cbbLop.Name = "cbbLop";
            this.cbbLop.Size = new System.Drawing.Size(205, 24);
            this.cbbLop.TabIndex = 2;
            // 
            // rdbMSSV
            // 
            this.rdbMSSV.AutoSize = true;
            this.rdbMSSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMSSV.ForeColor = System.Drawing.Color.Black;
            this.rdbMSSV.Location = new System.Drawing.Point(26, 48);
            this.rdbMSSV.Name = "rdbMSSV";
            this.rdbMSSV.Size = new System.Drawing.Size(113, 21);
            this.rdbMSSV.TabIndex = 0;
            this.rdbMSSV.TabStop = true;
            this.rdbMSSV.Text = "Theo MSSV";
            this.rdbMSSV.UseVisualStyleBackColor = true;
            this.rdbMSSV.CheckedChanged += new System.EventHandler(this.rdbMSSV_CheckedChanged);
            // 
            // RP_Diem
            // 
            this.RP_Diem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RP_Diem.Location = new System.Drawing.Point(12, 245);
            this.RP_Diem.Name = "RP_Diem";
            this.RP_Diem.ServerReport.BearerToken = null;
            this.RP_Diem.Size = new System.Drawing.Size(1114, 488);
            this.RP_Diem.TabIndex = 3;
            // 
            // RP_DanhSachDiemSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1138, 745);
            this.Controls.Add(this.RP_Diem);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "RP_DanhSachDiemSV";
            this.Text = "Thống Kê Điểm Sinh viên";
            this.Load += new System.EventHandler(this.RP_DiemSV_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbLop;
        private System.Windows.Forms.RadioButton rdbMonHoc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbMSSV;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.ComboBox cbbMonHoc;
        private System.Windows.Forms.ComboBox cbbLop;
        private Microsoft.Reporting.WinForms.ReportViewer RP_Diem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnXuat;
    }
}