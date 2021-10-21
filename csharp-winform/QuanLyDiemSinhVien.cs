using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharp_winform
{
    public partial class QuanLyDiemSinhVien : Form
    {
        public QuanLyDiemSinhVien()
        {
            InitializeComponent();
        }

        private void QuanLyDiemSinhVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(1);
        }

        private void QuanLyDiemSinhVien_Load(object sender, EventArgs e)
        {
            sinhViênToolStripMenuItem_Click(sender, e);
        }

        private void khoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = QuanLyDiemSinhVien.ActiveForm;
            foreach (Form f in frm.MdiChildren)
            {
                if (f.Name == "QuanLyKhoa")
                {
                    f.Activate();
                    return;
                }
            }

            QuanLyKhoa quanLyKhoa = new QuanLyKhoa();
            quanLyKhoa.MdiParent = this;
            quanLyKhoa.Show();
        }

        private void sinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = QuanLyDiemSinhVien.ActiveForm;
            foreach (Form f in frm.MdiChildren)
            {
                if (f.Name == "NhapSinhVien")
                {
                    f.Activate();
                    return;
                }
            }

            NhapSinhVien nhapSinhVien = new NhapSinhVien();
            nhapSinhVien.MdiParent = this;
            nhapSinhVien.Show();
        }

        private void diemSinhVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = QuanLyDiemSinhVien.ActiveForm;
            foreach (Form f in frm.MdiChildren)
            {
                if (f.Name == "NhapDiemSinhVien")
                {
                    f.Activate();
                    return;
                }
            }

            NhapDiemSinhVien nhapDiemSinhVien = new NhapDiemSinhVien();
            nhapDiemSinhVien.MdiParent = this;
            nhapDiemSinhVien.Show();
        }
    }
}
