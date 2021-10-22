using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using csharp_winform.Model;

namespace csharp_winform
{
    public partial class NhapSinhVien : Form
    {
        StudentDBContext dBContext = new StudentDBContext();

        public NhapSinhVien()
        {
            InitializeComponent();
        }

        private void NhapSinhVien_Load(object sender, EventArgs e)
        {
            List<SINHVIEN> listSinhVien = dBContext.SINHVIENs.ToList();
            List<LOP> listLop = dBContext.LOPs.ToList();

            FillDataDGV(listSinhVien);
            FillDataCBB(listLop);
        }

        private void FillDataDGV(List<SINHVIEN> listSinhVien)
        {
            dgvStudent.Rows.Clear();

            foreach (SINHVIEN item in listSinhVien)
            {
                int newRow = dgvStudent.Rows.Add();
                dgvStudent.Rows[newRow].Cells[0].Value = item.MSSV;
                dgvStudent.Rows[newRow].Cells[1].Value = item.HOTEN;
                dgvStudent.Rows[newRow].Cells[2].Value = item.GIOITINH;
                dgvStudent.Rows[newRow].Cells[3].Value = item.NGAYSINH;
                dgvStudent.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvStudent.Rows[newRow].Cells[4].Value = item.KHOAHOC;
                dgvStudent.Rows[newRow].Cells[5].Value = item.MALOP;
                dgvStudent.Rows[newRow].Cells[6].Value = item.DIACHI;
            }
        }

        private void FillDataCBB(List<LOP> listLop)
        {
            cbbMaLop.DataSource = listLop;
            cbbMaLop.ValueMember = "MALOP";
            cbbMaLop.DisplayMember = "MALOP";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (CheckDataInput())
            {
                if (CheckIDStudent(txtStudentID.Text) == -1) //sv chua ton tai trong dgv
                {
                    SINHVIEN newStudent = new SINHVIEN();

                    newStudent.MSSV = txtStudentID.Text;
                    newStudent.HOTEN = txtFullName.Text;
                    newStudent.GIOITINH = optFemale.Checked ? "Nữ" : "Nam";
                    newStudent.NGAYSINH = dtpNgaySinh.Value;
                    newStudent.KHOAHOC = int.Parse(txtKhoaHoc.Text);
                    newStudent.MALOP = cbbMaLop.SelectedValue.ToString();
                    newStudent.DIACHI = txtDiaChi.Text;

                    dBContext.SINHVIENs.AddOrUpdate(newStudent); //dua du lieu vo db va save
                    dBContext.SaveChanges();

                    LoadForm();
                    LoadDGV();

                    dgvStudent.ClearSelection();
                    dgvStudent.Rows[CheckIDStudent(newStudent.MSSV)].Selected = true;
                    MessageBox.Show($"Them sinh vien {newStudent.HOTEN} thanh cong!", "Thong bao");
                }
                else
                {
                    SINHVIEN updateStudent = dBContext.SINHVIENs.Where(p => p.MSSV == txtStudentID.Text).FirstOrDefault(); //lay sv dua vao mssv

                    if (updateStudent != null) //sv co ton tai trong db
                    {
                        updateStudent.HOTEN = txtFullName.Text;
                        updateStudent.GIOITINH = optFemale.Checked ? "Nữ" : "Nam";
                        updateStudent.NGAYSINH = dtpNgaySinh.Value;
                        updateStudent.KHOAHOC = int.Parse(txtKhoaHoc.Text);
                        updateStudent.MALOP = cbbMaLop.SelectedValue.ToString();
                        updateStudent.DIACHI = txtDiaChi.Text;

                        dBContext.SINHVIENs.AddOrUpdate(updateStudent); //dua du lieu vo db va save
                        dBContext.SaveChanges();

                        LoadForm();
                        LoadDGV();

                        dgvStudent.ClearSelection();
                        dgvStudent.Rows[CheckIDStudent(updateStudent.MSSV)].Selected = true;
                        MessageBox.Show($"Sua sinh vien {updateStudent.HOTEN} thanh cong!", "Thong bao");
                    }
                }
            }
        }

        private int CheckIDStudent(string idStudent)
        {
            for (int i = 0; i < dgvStudent.Rows.Count; i++)
            {
                if (dgvStudent.Rows[i].Cells[0].Value.ToString() == idStudent)
                    return i;
            }
            return -1; //sv chua ton tai trong dgv
        }

        private bool CheckDataInput()
        {
            if (txtStudentID.Text == "")
            {
                MessageBox.Show("Vui long nhap ma so sinh vien!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (txtKhoaHoc.Text != null)
            {
                int kq = 0;
                bool ketQua = int.TryParse(txtKhoaHoc.Text, out kq);
                if (!ketQua)
                {
                    MessageBox.Show("Khoa hoc phai la so!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            var regexItem = new Regex("^[a-zA-Z0-9]*$");
            if (!regexItem.IsMatch(txtStudentID.Text))
            {
                MessageBox.Show("Mã sinh viên chỉ bao gồm số và chữ viết không dấu!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void LoadDGV()
        {
            List<SINHVIEN> newStudents = dBContext.SINHVIENs.ToList();
            FillDataDGV(newStudents);
        }

        private void LoadForm()
        {
            txtStudentID.Clear();
            txtFullName.Clear();
            txtKhoaHoc.Clear();
            txtDiaChi.Clear();
            txtStudentID.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SINHVIEN updateStudent = dBContext.SINHVIENs.Where(p => p.MSSV == txtStudentID.Text).FirstOrDefault(); //lay sv dua vao mssv

            if (updateStudent != null) //sv co ton tai trong dgv
            {
                DialogResult dr = MessageBox.Show("Ban co muon xoa khong?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    dBContext.SINHVIENs.Remove(updateStudent); //xoa du lieu trong db va save
                    dBContext.SaveChanges();

                    int i = CheckIDStudent(updateStudent.MSSV);

                    LoadForm();
                    LoadDGV();

                    dgvStudent.ClearSelection();
                    if (i != 0)
                        dgvStudent.Rows[i - 1].Selected = true;
                    MessageBox.Show($"Xoa sinh vien {updateStudent.HOTEN} thanh cong!", "Thong bao");
                }
            }
            else
            {
                MessageBox.Show($"Khong tim thay sinh vien {txtStudentID.Text}!", "Thong bao");
            }
        }

        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvStudent.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvStudent.CurrentRow.Selected = true; // cho phep chon 1 dong
                    txtStudentID.Text = dgvStudent.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                    txtFullName.Text = dgvStudent.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                    if (dgvStudent.Rows[e.RowIndex].Cells[2].FormattedValue.ToString() == "Nam")
                        optMale.Checked = true;
                    else
                        optFemale.Checked = true;
                    dtpNgaySinh.Value = DateTime.ParseExact(dgvStudent.Rows[e.RowIndex].Cells[3].FormattedValue.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    txtKhoaHoc.Text = dgvStudent.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                    cbbMaLop.SelectedIndex = cbbMaLop.FindString(dgvStudent.Rows[e.RowIndex].Cells[5].FormattedValue.ToString());
                    txtDiaChi.Text = dgvStudent.Rows[e.RowIndex].Cells[6].FormattedValue.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Co loi xay ra!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sumMaleFemale()
        {
            int sumMale = 0;
            int sumFemale = 0;
            for (int i = 0; i < dgvStudent.Rows.Count; ++i)
            {
                if (dgvStudent.Rows[i].Cells[2].Value != null)
                {
                    if (dgvStudent.Rows[i].Cells[2].FormattedValue.ToString() == "Nam")
                    {
                        sumMale++;
                    }
                    else
                    {
                        sumFemale++;
                    }
                }
            }
            txtMale.Text = sumMale.ToString();
            txtFemale.Text = sumFemale.ToString();
        }

        private void dgvStudent_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            sumMaleFemale();
        }

        private void dgvStudent_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            sumMaleFemale();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            NhapSinhVien_Load(sender, e);
        }
    }
}
