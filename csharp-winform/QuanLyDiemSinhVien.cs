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
        int flag = 0;

        public QuanLyDiemSinhVien()
        {
            InitializeComponent();
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
                    f.Close();
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
                    f.Close();
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
                    f.Close();
            }

            NhapDiemSinhVien nhapDiemSinhVien = new NhapDiemSinhVien();
            nhapDiemSinhVien.NhapDiemSinhVien_Load(sender, e);
            nhapDiemSinhVien.MdiParent = this;
            nhapDiemSinhVien.Show();
        }

        private void lớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = QuanLyDiemSinhVien.ActiveForm;
            foreach (Form f in frm.MdiChildren)
            {
                if (f.Name == "QuanLyLop")
                    f.Close();
            }

            QuanLyLop quanLyLop = new QuanLyLop();
            quanLyLop.MdiParent = this;
            quanLyLop.Show();
        }

        private void mônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = QuanLyDiemSinhVien.ActiveForm;
            foreach (Form f in frm.MdiChildren)
            {
                if (f.Name == "QuanLyMonHoc")
                    f.Close();
            }

            QuanLyMonHoc quanLyMonHoc = new QuanLyMonHoc();
            quanLyMonHoc.MdiParent = this;
            quanLyMonHoc.Show();
        }

        private void thôngTinPhầnMềmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = QuanLyDiemSinhVien.ActiveForm;
            foreach (Form f in frm.MdiChildren)
            {
                if (f.Name == "About")
                    f.Close();
            }

            About about = new About();
            about.MdiParent = this;
            about.Show();
        }

        private void btlQLSV_Click(object sender, EventArgs e)
        {
            sinhViênToolStripMenuItem_Click(sender, e);
        }

        private void btlQLMH_Click(object sender, EventArgs e)
        {
            mônHọcToolStripMenuItem_Click(sender, e);
        }

        private void btlQLL_Click(object sender, EventArgs e)
        {
            lớpToolStripMenuItem_Click(sender, e);
        }

        private void btlQLK_Click(object sender, EventArgs e)
        {
            khoaToolStripMenuItem_Click(sender, e);
        }

        private void btlQLDSV_Click(object sender, EventArgs e)
        {
            diemSinhVienToolStripMenuItem_Click(sender, e);
        }

        private void btnCloseSideBar_Click(object sender, EventArgs e)
        {
            sideBarToolStripMenuItem.Checked = false;
            sideBar.Hide();
            btnCloseSideBar.Hide();
            btlQLSV.Hide();
            btlQLDSV.Hide();
            btlQLMH.Hide();
            btlQLL.Hide();
            btlQLK.Hide();
            btnTimKiem.Hide();
            btnQLTK.Hide();
        }

        private void sideBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sideBar.Visible = sideBarToolStripMenuItem.Checked;
            btnCloseSideBar.Visible = sideBarToolStripMenuItem.Checked;
            btlQLSV.Visible = sideBarToolStripMenuItem.Checked;
            btlQLDSV.Visible = sideBarToolStripMenuItem.Checked;
            btlQLMH.Visible = sideBarToolStripMenuItem.Checked;
            btlQLL.Visible = sideBarToolStripMenuItem.Checked;
            btlQLK.Visible = sideBarToolStripMenuItem.Checked;
            btnTimKiem.Visible = sideBarToolStripMenuItem.Checked;
            btnQLTK.Visible = sideBarToolStripMenuItem.Checked;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát không ?", "Thông Báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                try
                {
                    Environment.Exit(1);
                }
                catch (Exception)
                {
                    Environment.Exit(1);
                }
            }
        }

        public void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không ?", "Thông Báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                DangNhapHeThong dangNhapHeThong = new DangNhapHeThong();
                dangNhapHeThong.Show();
                flag = 1;
                this.Close();
            }
        }

        public void dangNhapLai()
        {
            DangNhapHeThong dangNhapHeThong = new DangNhapHeThong();
            dangNhapHeThong.Show();
            flag = 1;
            this.Close();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = QuanLyDiemSinhVien.ActiveForm;
            foreach (Form f in frm.MdiChildren)
            {
                if (f.Name == "DoiMatKhau")
                    f.Close();
            }

            DoiMatKhau doiMatKhau = new DoiMatKhau(this);
            doiMatKhau.MdiParent = this;
            doiMatKhau.Show();
        }

        private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyDiemSinhVien_Load(sender, e);
        }

        private void dSTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = QuanLyDiemSinhVien.ActiveForm;
            foreach (Form f in frm.MdiChildren)
            {
                if (f.Name == "QuanLyTaiKhoan")
                    f.Close();
            }

            QuanLyTaiKhoan quanLyTaiKhoan = new QuanLyTaiKhoan();
            quanLyTaiKhoan.MdiParent = this;
            quanLyTaiKhoan.Show();
        }

        private void btnQLTK_Click(object sender, EventArgs e)
        {
            dSTàiKhoảnToolStripMenuItem_Click(sender, e);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            Form frm = QuanLyDiemSinhVien.ActiveForm;
            foreach (Form f in frm.MdiChildren)
            {
                if (f.Name == "TimKiemSinhVien")
                    f.Close();
            }

            TimKiemSinhVien timKiemSinhVien = new TimKiemSinhVien();
            timKiemSinhVien.MdiParent = this;
            timKiemSinhVien.Show();
        }

        private void tìmKiếmSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnTimKiem_Click(sender, e);
        }

        private void dSSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = QuanLyDiemSinhVien.ActiveForm;
            foreach (Form f in frm.MdiChildren)
            {
                if (f.Name == "RP_DanhSachSV")
                    f.Close();
            }
            RP_DanhSachSV rP_DanhSachSV = new RP_DanhSachSV();
            rP_DanhSachSV.MdiParent = this;
            rP_DanhSachSV.Show();
        }

        private void dSDiemSinhVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = QuanLyDiemSinhVien.ActiveForm;
            foreach (Form f in frm.MdiChildren)
            {
                if (f.Name == "RP_DiemSV")
                    f.Close();
            }
            RP_DanhSachDiemSV rP_DiemSV = new RP_DanhSachDiemSV();
            rP_DiemSV.MdiParent = this;
            rP_DiemSV.Show();
        }

        private void QuanLyDiemSinhVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (flag == 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát không ?", "Thông Báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        Environment.Exit(1);
                    }
                    catch (Exception)
                    {
                        Environment.Exit(1);
                    }
                }
                else
                    e.Cancel = true;
            }
        }
    }
}
