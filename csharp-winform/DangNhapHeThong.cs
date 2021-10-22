using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using csharp_winform.Model;

namespace csharp_winform
{
    public partial class DangNhapHeThong : Form
    {
        StudentDBContext dBContext = new StudentDBContext();

        public DangNhapHeThong()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (CheckDataInput())
            {
                DANGNHAP dn = dBContext.DANGNHAPs.Where(p => p.TenDN == txtTenDN.Text && p.MatKhau == txtMatKhau.Text).FirstOrDefault();

                if (dn != null)
                {
                    if (dn.Quyen == "admin")
                    {
                        this.Hide();
                        QuanLyDiemSinhVien frmMain = new QuanLyDiemSinhVien();
                        frmMain.Show();
                    }
                    else
                    {
                        this.Hide();
                        QuanLyDiemSinhVien frmMain = new QuanLyDiemSinhVien();
                        frmMain.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Sai ten dang nhap hoac mat khau");
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool CheckDataInput()
        {
            if (txtTenDN.Text == "" || txtMatKhau.Text == "")
            {
                MessageBox.Show("Vui long nhap day du thong tin!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            var regexItem = new Regex("^[a-zA-Z0-9]*$");
            if (!regexItem.IsMatch(txtTenDN.Text))
            {
                MessageBox.Show("Tên đăng nhập chỉ bao gồm số và chữ viết không dấu!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }
}
