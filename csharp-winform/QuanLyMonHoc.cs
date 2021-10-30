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
    public partial class QuanLyMonHoc : Form
    {
        StudentDBContext dBContext = new StudentDBContext();

        public QuanLyMonHoc()
        {
            InitializeComponent();
        }

        private void QuanLyMonHoc_Load(object sender, EventArgs e)
        {
            List<MONHOC> listMonHoc = dBContext.MONHOCs.ToList();
            FillDataDGV(listMonHoc);

            txtMaMon.Focus();
        }

        private void FillDataDGV(List<MONHOC> listMonHoc)
        {
            dgvDSMonHoc.Rows.Clear();

            foreach (MONHOC item in listMonHoc)
            {
                int newRow = dgvDSMonHoc.Rows.Add();
                dgvDSMonHoc.Rows[newRow].Cells[0].Value = item.MAMH;
                dgvDSMonHoc.Rows[newRow].Cells[1].Value = item.TENMH;
                dgvDSMonHoc.Rows[newRow].Cells[2].Value = item.TCLT;
                dgvDSMonHoc.Rows[newRow].Cells[3].Value = item.TCTH;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            QuanLyMonHoc_Load(sender, e);
            LoadForm();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            if (CheckDataInput())
            {
                if (CheckIDSubject(txtMaMon.Text) == -1)
                {
                    MONHOC newSubject = new MONHOC();

                    newSubject.MAMH = txtMaMon.Text;
                    newSubject.TENMH = txtTenMon.Text;
                    if (txtTCLT.Text != "")
                        newSubject.TCLT = int.Parse(txtTCLT.Text);
                    else
                        newSubject.TCLT = null;
                    if (txtTCTH.Text != "")
                        newSubject.TCTH = int.Parse(txtTCTH.Text);
                    else
                        newSubject.TCTH = null;

                    dBContext.MONHOCs.AddOrUpdate(newSubject);
                    dBContext.SaveChanges();

                    LoadForm();
                    LoadDGV();

                    dgvDSMonHoc.ClearSelection();
                    dgvDSMonHoc.Rows[CheckIDSubject(newSubject.MAMH)].Selected = true;
                    MessageBox.Show($"Thêm môn {newSubject.MAMH} thành công!", "Thông Báo!");
                }
                else
                {
                    MONHOC updateSubject = dBContext.MONHOCs.Where(p => p.MAMH == txtMaMon.Text).FirstOrDefault();

                    if (updateSubject != null)
                    {
                        updateSubject.TENMH = txtTenMon.Text;
                        if (txtTCLT.Text != "")
                            updateSubject.TCLT = int.Parse(txtTCLT.Text);
                        else
                            updateSubject.TCLT = null;
                        if (txtTCTH.Text != "")
                            updateSubject.TCTH = int.Parse(txtTCTH.Text);
                        else
                            updateSubject.TCTH = null;

                        dBContext.MONHOCs.AddOrUpdate(updateSubject);
                        dBContext.SaveChanges();

                        LoadForm();
                        LoadDGV();

                        dgvDSMonHoc.ClearSelection();
                        dgvDSMonHoc.Rows[CheckIDSubject(updateSubject.MAMH)].Selected = true;
                        MessageBox.Show($"Sửa môn {updateSubject.MAMH} thành công!", "Thông Báo!");
                    }
                }
            }
        }

        private int CheckIDSubject(string idSubject)
        {
            for (int i = 0; i < dgvDSMonHoc.Rows.Count; i++)
            {
                if (dgvDSMonHoc.Rows[i].Cells[0].Value.ToString() == idSubject)
                    return i;
            }
            return -1;
        }

        private bool CheckDataInput()
        {
            if (txtMaMon.Text == "" || txtTenMon.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ mã và tên môn học!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (txtTCLT.Text != "")
            {
                int kq = 0;
                bool ketQua = int.TryParse(txtTCLT.Text, out kq);
                if (!ketQua)
                {
                    MessageBox.Show("Số tín chỉ lý thuyết phải là số !", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            else if (txtTCTH.Text != "")
            {
                int kq2 = 0;
                bool ketQua2 = int.TryParse(txtTCTH.Text, out kq2);
                if (!ketQua2)
                {
                    MessageBox.Show("Số tín chỉ thực hành phải là số !", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            var regexItem = new Regex("^[a-zA-Z0-9]*$");
            if (!regexItem.IsMatch(txtMaMon.Text))
            {
                MessageBox.Show("Mã môn học chỉ bao gồm số và chữ viết không dấu!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void LoadDGV()
        {
            List<MONHOC> newSubject = dBContext.MONHOCs.ToList();
            FillDataDGV(newSubject);
        }

        private void LoadForm()
        {
            txtMaMon.Clear();
            txtTenMon.Clear();
            txtTCLT.Clear();
            txtTCTH.Clear();
            txtMaMon.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var checkExist = dBContext.DIEMSVs.Where(p => p.MAMH == txtMaMon.Text).ToList();
            if (checkExist.Count > 0)
            {
                MessageBox.Show($"Không thể xoá môn học: {txtTenMon.Text}", "Thông báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                return;
            }

            MONHOC updateSubject = dBContext.MONHOCs.Where(p => p.MAMH == txtMaMon.Text).FirstOrDefault();
            if (updateSubject != null)
            {
                DialogResult dr = MessageBox.Show("Bạn có muốn xóa không ?", "Thông Báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    StudentDBContext dBContext = new StudentDBContext();
                    dBContext.MONHOCs.Remove(updateSubject);
                    dBContext.SaveChanges();

                    int i = CheckIDSubject(updateSubject.MAMH);

                    LoadForm();
                    LoadDGV();

                    dgvDSMonHoc.ClearSelection();
                    if (i != 0)
                        dgvDSMonHoc.Rows[i - 1].Selected = true;
                    MessageBox.Show($"Xóa môn {updateSubject.MAMH} thành công!", "Thông Báo!");
                }
            }
            else
            {
                MessageBox.Show($"Không tìm thấy môn {txtMaMon.Text}!", "Thông Báo!");
            }
        }

        private void dgvDSMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvDSMonHoc.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvDSMonHoc.CurrentRow.Selected = true;
                    txtMaMon.Text = dgvDSMonHoc.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                    txtTenMon.Text = dgvDSMonHoc.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                    txtTCLT.Text = dgvDSMonHoc.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                    txtTCTH.Text = dgvDSMonHoc.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                }
            }
            catch (Exception)
            {
                return;
            }
        }
    }
}
