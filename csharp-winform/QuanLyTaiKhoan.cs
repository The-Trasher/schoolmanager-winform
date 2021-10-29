using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using csharp_winform.Model;

namespace csharp_winform
{
    public partial class QuanLyTaiKhoan : Form
    {
        StudentDBContext dBContext = new StudentDBContext();

        public QuanLyTaiKhoan()
        {
            InitializeComponent();
        }

        private void QuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            List<DANGNHAP> listAccount = dBContext.DANGNHAPs.ToList();

            FillDataDGV(listAccount);
            txtTenDN.Focus();
            rbNam.Checked = true;
            rbMember.Checked = true;
        }

        private void FillDataDGV(List<DANGNHAP> listAccount)
        {
            dgvDSTaiKhoan.Rows.Clear();

            foreach (DANGNHAP item in listAccount)
            {
                int newRow = dgvDSTaiKhoan.Rows.Add();
                dgvDSTaiKhoan.Rows[newRow].Cells[0].Value = item.TenDN;
                dgvDSTaiKhoan.Rows[newRow].Cells[1].Value = item.MatKhau;
                dgvDSTaiKhoan.Rows[newRow].Cells[2].Value = item.HoTen;
                dgvDSTaiKhoan.Rows[newRow].Cells[3].Value = item.Phone;
                dgvDSTaiKhoan.Rows[newRow].Cells[4].Value = item.Email;
                dgvDSTaiKhoan.Rows[newRow].Cells[5].Value = item.GioiTinh;
                dgvDSTaiKhoan.Rows[newRow].Cells[6].Value = item.Quyen;
            }
        }

        private void dgvDSTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvDSTaiKhoan.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvDSTaiKhoan.CurrentRow.Selected = true; // cho phep chon 1 dong
                    txtTenDN.Text = dgvDSTaiKhoan.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                    txtMK.Text = dgvDSTaiKhoan.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                    txtHoTen.Text = dgvDSTaiKhoan.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                    txtPhone.Text = dgvDSTaiKhoan.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                    txtEmail.Text = dgvDSTaiKhoan.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                    if (dgvDSTaiKhoan.Rows[e.RowIndex].Cells[5].FormattedValue.ToString() == "Nam")
                        rbNam.Checked = true;
                    else
                        rbNu.Checked = true;
                    if (dgvDSTaiKhoan.Rows[e.RowIndex].Cells[6].FormattedValue.ToString() == "member")
                        rbMember.Checked = true;
                    else
                        rbAdmin.Checked = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            QuanLyTaiKhoan_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            if (CheckDataInput())
            {
                if (CheckID(txtTenDN.Text) == -1)
                {
                    DANGNHAP newAccount = new DANGNHAP();

                    newAccount.TenDN = txtTenDN.Text;
                    newAccount.MatKhau = txtMK.Text;
                    newAccount.HoTen = txtHoTen.Text;
                    newAccount.Phone = txtPhone.Text;
                    newAccount.Email = txtEmail.Text;
                    newAccount.GioiTinh = rbNu.Checked ? "Nữ" : "Nam";
                    newAccount.Quyen = rbAdmin.Checked ? "admin" : "member";

                    dBContext.DANGNHAPs.AddOrUpdate(newAccount);
                    dBContext.SaveChanges();

                    LoadForm();
                    LoadDGV();

                    dgvDSTaiKhoan.ClearSelection();
                    dgvDSTaiKhoan.Rows[CheckID(newAccount.TenDN)].Selected = true;
                    MessageBox.Show($"Thêm tài khoản {newAccount.TenDN} thành công!", "Thông Báo!");
                }
                else
                {
                    DANGNHAP updateAccount = dBContext.DANGNHAPs.Where(p => p.TenDN == txtTenDN.Text).FirstOrDefault();

                    if (updateAccount != null)
                    {
                        updateAccount.MatKhau = txtMK.Text;
                        updateAccount.HoTen = txtHoTen.Text;
                        updateAccount.Phone = txtPhone.Text;
                        updateAccount.Email = txtEmail.Text;
                        updateAccount.GioiTinh = rbNu.Checked ? "Nữ" : "Nam";
                        updateAccount.Quyen = rbAdmin.Checked ? "admin" : "member";

                        dBContext.DANGNHAPs.AddOrUpdate(updateAccount);
                        dBContext.SaveChanges();

                        LoadForm();
                        LoadDGV();

                        dgvDSTaiKhoan.ClearSelection();
                        dgvDSTaiKhoan.Rows[CheckID(updateAccount.TenDN)].Selected = true;
                        MessageBox.Show($"Sửa tài khoản {updateAccount.TenDN} thành công!", "Thông Báo!");
                    }
                }
            }
        }

        private int CheckID(string id)
        {
            for (int i = 0; i < dgvDSTaiKhoan.Rows.Count; i++)
            {
                if (dgvDSTaiKhoan.Rows[i].Cells[0].Value.ToString() == id)
                    return i;
            }
            return -1;
        }

        private bool CheckDataInput()
        {
            if (txtTenDN.Text == "" || txtMK.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu !", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            var regexItem = new Regex("^[a-zA-Z0-9]*$");
            if (!regexItem.IsMatch(txtTenDN.Text))
            {
                MessageBox.Show("Tên đăng nhập chỉ bao gồm số và chữ viết không dấu!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void LoadDGV()
        {
            List<DANGNHAP> listAccount = dBContext.DANGNHAPs.ToList();
            FillDataDGV(listAccount);
        }

        private void LoadForm()
        {
            txtTenDN.Clear();
            txtMK.Clear();
            txtHoTen.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtTenDN.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DANGNHAP deleteAccount = dBContext.DANGNHAPs.Where(p => p.TenDN == txtTenDN.Text).FirstOrDefault();

            if (deleteAccount != null)
            {
                DialogResult dr = MessageBox.Show("Bạn có muốn xóa không ?", "Thông Báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    dBContext.DANGNHAPs.Remove(deleteAccount);
                    dBContext.SaveChanges();

                    int i = CheckID(deleteAccount.TenDN);

                    LoadForm();
                    LoadDGV();

                    dgvDSTaiKhoan.ClearSelection();
                    if (i != 0)
                        dgvDSTaiKhoan.Rows[i - 1].Selected = true;
                    MessageBox.Show($"Xóa tài khoản {deleteAccount.TenDN} thành công!", "Thông Báo!");
                }
            }
            else
            {
                MessageBox.Show($"Không tìm thấy tài khoản {txtTenDN.Text}!", "Thông Báo!");
            }
        }
    }
}
