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
    public partial class QuanLyKhoa : Form
    {
        StudentDBContext dBContext = new StudentDBContext();

        public QuanLyKhoa()
        {
            InitializeComponent();
        }

        private void QuanLyKhoa_Load(object sender, EventArgs e)
        {
            List<KHOA> listKhoa = dBContext.KHOAs.ToList();
            FillDataDGV(listKhoa);
        }

        private void FillDataDGV(List<KHOA> listKhoa)
        {
            dgvDSKhoa.Rows.Clear();

            foreach (KHOA item in listKhoa)
            {
                int newRow = dgvDSKhoa.Rows.Add();
                dgvDSKhoa.Rows[newRow].Cells[0].Value = item.MAKHOA;
                dgvDSKhoa.Rows[newRow].Cells[1].Value = item.TENKHOA;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            if (CheckDataInput())
            {
                if (CheckIDFaculty(txtMaKhoa.Text) == -1)
                {
                    KHOA newFaculty = new KHOA();

                    newFaculty.MAKHOA = txtMaKhoa.Text;
                    newFaculty.TENKHOA = txtTenKhoa.Text;

                    dBContext.KHOAs.AddOrUpdate(newFaculty);
                    dBContext.SaveChanges();

                    LoadForm();
                    LoadDGV();

                    dgvDSKhoa.ClearSelection();
                    dgvDSKhoa.Rows[CheckIDFaculty(newFaculty.MAKHOA)].Selected = true;
                    MessageBox.Show($"Them khoa {newFaculty.MAKHOA} thanh cong!", "Thong bao");
                }
                else
                {
                    KHOA updateFaculty = dBContext.KHOAs.Where(p => p.MAKHOA == txtMaKhoa.Text).FirstOrDefault();

                    if (updateFaculty != null)
                    {
                        updateFaculty.TENKHOA = txtTenKhoa.Text;

                        dBContext.KHOAs.AddOrUpdate(updateFaculty);
                        dBContext.SaveChanges();

                        LoadForm();
                        LoadDGV();

                        dgvDSKhoa.ClearSelection();
                        dgvDSKhoa.Rows[CheckIDFaculty(updateFaculty.MAKHOA)].Selected = true;
                        MessageBox.Show($"Sua khoa {updateFaculty.MAKHOA} thanh cong!", "Thong bao");
                    }
                }
            }
        }

        private int CheckIDFaculty(string idFaculty)
        {
            for (int i = 0; i < dgvDSKhoa.Rows.Count; i++)
            {
                if (dgvDSKhoa.Rows[i].Cells[0].Value.ToString() == idFaculty)
                    return i;
            }
            return -1;
        }

        private bool CheckDataInput()
        {
            if (txtMaKhoa.Text == "")
            {
                MessageBox.Show("Vui long nhap ma khoa!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            var regexItem = new Regex("^[a-zA-Z0-9]*$");
            if (!regexItem.IsMatch(txtMaKhoa.Text))
            {
                MessageBox.Show("Mã khoa chỉ bao gồm số và chữ viết không dấu!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void LoadDGV()
        {
            List<KHOA> newFaculty = dBContext.KHOAs.ToList();
            FillDataDGV(newFaculty);
        }

        private void LoadForm()
        {
            txtMaKhoa.Clear();
            txtTenKhoa.Clear();
            txtMaKhoa.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            KHOA updateFaculty = dBContext.KHOAs.Where(p => p.MAKHOA == txtMaKhoa.Text).FirstOrDefault();

            if (updateFaculty != null)
            {
                DialogResult dr = MessageBox.Show("Ban co muon xoa khong?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    dBContext.KHOAs.Remove(updateFaculty);
                    dBContext.SaveChanges();

                    int i = CheckIDFaculty(updateFaculty.MAKHOA);

                    LoadForm();
                    LoadDGV();

                    dgvDSKhoa.ClearSelection();
                    if (i != 0)
                        dgvDSKhoa.Rows[i - 1].Selected = true;
                    MessageBox.Show($"Xoa khoa {updateFaculty.MAKHOA} thanh cong!", "Thong bao");
                }
            }
            else
            {
                MessageBox.Show($"Khong tim thay khoa {txtMaKhoa.Text}!", "Thong bao");
            }
        }

        private void dgvDSKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvDSKhoa.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvDSKhoa.CurrentRow.Selected = true;
                    txtMaKhoa.Text = dgvDSKhoa.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                    txtTenKhoa.Text = dgvDSKhoa.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Co loi xay ra!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            QuanLyKhoa_Load(sender, e);
            LoadForm();
        }
    }
}
