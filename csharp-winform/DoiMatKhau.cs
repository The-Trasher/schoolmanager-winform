using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using csharp_winform.Model;

namespace csharp_winform
{
    public partial class DoiMatKhau : Form
    {
        StudentDBContext dBContext = new StudentDBContext();
        private QuanLyDiemSinhVien mainForm;

        public DoiMatKhau(QuanLyDiemSinhVien mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void DoiMatKhau_Load(object sender, EventArgs e)
        {
            txtTenTaiKhoan.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (CheckDataInput())
            {
                DANGNHAP findAccount = dBContext.DANGNHAPs.Where(p => p.TenDN == txtTenTaiKhoan.Text && p.MatKhau == txtMKCu.Text).FirstOrDefault();

                if (findAccount != null)
                {
                    if (txtMKMoi.Text == txtNhapLaiMK.Text)
                    {
                        DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn đổi mật khẩu không?", "Thông Báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (dr == DialogResult.Yes)
                        {
                            findAccount.MatKhau = txtNhapLaiMK.Text;

                            dBContext.DANGNHAPs.AddOrUpdate(findAccount);
                            dBContext.SaveChanges();

                            MessageBox.Show($"Đổi mật khẩu thành công. Vui lòng đăng nhập lại!", "Thông Báo!");
                            mainForm.dangNhapLai();
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Mật khẩu không trùng khớp!", "Thông Báo!");
                    }
                }
                else
                {
                    MessageBox.Show($"Sai ten dang nhap hoac mat khau!", "Thông Báo!");
                }
            }
        }

        private bool CheckDataInput()
        {
            if (txtTenTaiKhoan.Text == "" || txtMKCu.Text == "" || txtMKMoi.Text == "" || txtNhapLaiMK.Text == "")
            {
                MessageBox.Show("Vui long nhap day du thong tin!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}
