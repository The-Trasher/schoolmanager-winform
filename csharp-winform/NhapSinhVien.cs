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
            txtStudentID.Focus();
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
                dgvStudent.Rows[newRow].Cells[7].Value = Math.Round((double)item.DIEMTB, 2).ToString();
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
                int idStudent = CheckIDStudent(txtStudentID.Text);
                if (idStudent == -1)
                {
                    SINHVIEN newStudent = new SINHVIEN();

                    newStudent.MSSV = txtStudentID.Text;
                    newStudent.HOTEN = txtFullName.Text;
                    newStudent.GIOITINH = optFemale.Checked ? "Nữ" : "Nam";
                    newStudent.NGAYSINH = dtpNgaySinh.Value;
                    newStudent.KHOAHOC = int.Parse(txtKhoaHoc.Text);
                    newStudent.MALOP = cbbMaLop.SelectedValue.ToString();
                    newStudent.DIACHI = txtDiaChi.Text;
                    newStudent.DIEMTB = 0;

                    dBContext.SINHVIENs.AddOrUpdate(newStudent);
                    dBContext.SaveChanges();
                    updateSiSoLop(newStudent.MALOP, 1);

                    LoadForm();
                    LoadDGV();

                    dgvStudent.ClearSelection();
                    dgvStudent.Rows[CheckIDStudent(newStudent.MSSV)].Selected = true;
                    MessageBox.Show($"Thêm sinh viên {newStudent.HOTEN} thành công!", "Thông Báo!");
                }
                else
                {
                    SINHVIEN updateStudent = dBContext.SINHVIENs.Where(p => p.MSSV == txtStudentID.Text).FirstOrDefault();

                    if (updateStudent != null)
                    {
                        updateStudent.HOTEN = txtFullName.Text;
                        updateStudent.GIOITINH = optFemale.Checked ? "Nữ" : "Nam";
                        updateStudent.NGAYSINH = dtpNgaySinh.Value;
                        updateStudent.KHOAHOC = int.Parse(txtKhoaHoc.Text);
                        updateStudent.MALOP = cbbMaLop.SelectedValue.ToString();
                        updateStudent.DIACHI = txtDiaChi.Text;

                        dBContext.SINHVIENs.AddOrUpdate(updateStudent);
                        dBContext.SaveChanges();
                        updateSiSoLop(updateStudent.MALOP, 1);
                        updateSiSoLop(dgvStudent.Rows[idStudent].Cells[5].FormattedValue.ToString(), -1);

                        LoadForm();
                        LoadDGV();

                        dgvStudent.ClearSelection();
                        dgvStudent.Rows[CheckIDStudent(updateStudent.MSSV)].Selected = true;
                        MessageBox.Show($"Sửa sinh viên {updateStudent.HOTEN} thành công!", "Thông Báo!");
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
            return -1;
        }

        private bool CheckDataInput()
        {
            if (txtStudentID.Text == "" || txtFullName.Text == "" || txtKhoaHoc.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ mã số, họ tên và khóa học của sinh viên!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (txtKhoaHoc.Text != "")
            {
                int kq = 0;
                bool ketQua = int.TryParse(txtKhoaHoc.Text, out kq);
                if (!ketQua)
                {
                    MessageBox.Show("Khóa học phải là số!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            var regexItem = new Regex("^[a-zA-Z0-9]*$");
            if (!regexItem.IsMatch(txtStudentID.Text))
            {
                MessageBox.Show("Mã sinh viên chỉ bao gồm số và chữ viết không dấu!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            SINHVIEN updateStudent = dBContext.SINHVIENs.Where(p => p.MSSV == txtStudentID.Text).FirstOrDefault();
            if (updateStudent != null)
            {
                DialogResult dr = MessageBox.Show($"Bạn thực sự muốn xoá thông tin sinh viên: {updateStudent.HOTEN}?" +
                    $"\n(Lưu ý toàn bộ điểm của sinh viên này sẽ đều bị xoá!)", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    var updateDiemSV = dBContext.DIEMSVs.Where(p => p.MSSV == txtStudentID.Text).ToList();
                    foreach (var item in updateDiemSV)
                    {
                        dBContext.DIEMSVs.Remove(item);
                        dBContext.SaveChanges();
                    }

                    updateSiSoLop(updateStudent.MALOP, -1);
                    dBContext.SINHVIENs.Remove(updateStudent);
                    dBContext.SaveChanges();

                    int i = CheckIDStudent(updateStudent.MSSV);

                    LoadForm();
                    LoadDGV();

                    dgvStudent.ClearSelection();
                    if (i != 0)
                        dgvStudent.Rows[i - 1].Selected = true;
                    MessageBox.Show($"Xóa sinh viên {updateStudent.HOTEN} thành công!", "Thông Báo!");
                }
            }
            else
            {
                MessageBox.Show($"Không tìm thấy sinh viên {txtStudentID.Text}!", "Thông Báo!");
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
                return;
            }
        }

        private void updateSiSoLop(string maLop, int type)
        {
            LOP checkExist = dBContext.LOPs.Where(p => p.MALOP == maLop).FirstOrDefault();
            checkExist.SISO = checkExist.SISO + type;
            dBContext.LOPs.AddOrUpdate(checkExist);
            dBContext.SaveChanges();
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
            LoadForm();
        }
    }
}
