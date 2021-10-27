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

                var DIEMTB = dBContext.DIEMSVs
                                .Where(p => p.MSSV == item.MSSV)
                                .Select(p => new { DiemTB = p.DIEMTONGKET })
                                .Average(p => p.DiemTB);
                if (DIEMTB == null)
                    DIEMTB = 0;
                int newRow = dgvStudent.Rows.Add();
                dgvStudent.Rows[newRow].Cells[0].Value = item.MSSV;
                dgvStudent.Rows[newRow].Cells[1].Value = item.HOTEN;
                dgvStudent.Rows[newRow].Cells[2].Value = item.GIOITINH;
                dgvStudent.Rows[newRow].Cells[3].Value = item.NGAYSINH;
                dgvStudent.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvStudent.Rows[newRow].Cells[4].Value = item.KHOAHOC;
                dgvStudent.Rows[newRow].Cells[5].Value = item.MALOP;
                dgvStudent.Rows[newRow].Cells[6].Value = item.DIACHI;
                dgvStudent.Rows[newRow].Cells[7].Value = Math.Round((double)DIEMTB,2).ToString();
                SINHVIEN updateStudent = dBContext.SINHVIENs.Where(p => p.MSSV == item.MSSV).FirstOrDefault();
                if (updateStudent != null)
                {
                    updateStudent.DIEMTB = DIEMTB;
                    dBContext.SINHVIENs.AddOrUpdate(updateStudent); 
                    dBContext.SaveChanges();
                }

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
                    if (txtKhoaHoc.Text != "")
                        newStudent.KHOAHOC = int.Parse(txtKhoaHoc.Text);
                    else
                        newStudent.KHOAHOC = null;
                    newStudent.MALOP = cbbMaLop.SelectedValue.ToString();
                    newStudent.DIACHI = txtDiaChi.Text;


                    dBContext.SINHVIENs.AddOrUpdate(newStudent); //dua du lieu vo db va save
                    dBContext.SaveChanges();

                    LoadForm();
                    LoadDGV();

                    dgvStudent.ClearSelection();
                    dgvStudent.Rows[CheckIDStudent(newStudent.MSSV)].Selected = true;
                    MessageBox.Show($"Them sinh vien {newStudent.HOTEN} thành công!", "Thông Báo!");
                }
                else
                {
                    SINHVIEN updateStudent = dBContext.SINHVIENs.Where(p => p.MSSV == txtStudentID.Text).FirstOrDefault(); //lay sv dua vao mssv

                    if (updateStudent != null) //sv co ton tai trong db
                    {
                        updateStudent.HOTEN = txtFullName.Text;
                        updateStudent.GIOITINH = optFemale.Checked ? "Nữ" : "Nam";
                        updateStudent.NGAYSINH = dtpNgaySinh.Value;
                        if (txtKhoaHoc.Text != "")
                            updateStudent.KHOAHOC = int.Parse(txtKhoaHoc.Text);
                        else
                            updateStudent.KHOAHOC = null;
                        updateStudent.MALOP = cbbMaLop.SelectedValue.ToString();
                        updateStudent.DIACHI = txtDiaChi.Text;
                        updateStudent.DIEMTB = dBContext.DIEMSVs
                                                .Where(p => p.MSSV == updateStudent.MSSV)
                                                .Select(p => new { DiemTB = p.DIEMTONGKET })
                                                .Average(p => p.DiemTB);

                        dBContext.SINHVIENs.AddOrUpdate(updateStudent); //dua du lieu vo db va save
                        dBContext.SaveChanges();

                        LoadForm();
                        LoadDGV();

                        dgvStudent.ClearSelection();
                        dgvStudent.Rows[CheckIDStudent(updateStudent.MSSV)].Selected = true;
                        MessageBox.Show($"Sua sinh vien {updateStudent.HOTEN} thành công!", "Thông Báo!");
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
                MessageBox.Show("Vui long nhap ma so sinh vien!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (txtKhoaHoc.Text != "")
            {
                int kq = 0;
                bool ketQua = int.TryParse(txtKhoaHoc.Text, out kq);
                if (!ketQua)
                {
                    MessageBox.Show("Khoa hoc phai la so!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            SINHVIEN updateStudent = dBContext.SINHVIENs.Where(p => p.MSSV == txtStudentID.Text).FirstOrDefault(); //lay sv dua vao mssv
            var updateDiemSV = dBContext.DIEMSVs.Where(p => p.MSSV == txtStudentID.Text).ToList();
            if (updateStudent != null) //sv co ton tai trong dgv
            {
                DialogResult dr = MessageBox.Show($"Bạn thực sự muốn xoá thông tin sinh viên: {updateStudent.HOTEN}?" +
                    $"\n(Lưu ý toàn bộ điểm của sinh viên này sẽ đều bị xoá!)", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    foreach (var item in updateDiemSV)
                    {
                        dBContext.DIEMSVs.Remove(item); 
                        dBContext.SaveChanges();
                    }

                    dBContext.SINHVIENs.Remove(updateStudent); //xoa du lieu trong db va save
                    dBContext.SaveChanges();

                    int i = CheckIDStudent(updateStudent.MSSV);

                    LoadForm();
                    LoadDGV();

                    dgvStudent.ClearSelection();
                    if (i != 0)
                        dgvStudent.Rows[i - 1].Selected = true;
                    MessageBox.Show($"Xoa sinh vien {updateStudent.HOTEN} thành công!", "Thông Báo!");
                }
            }
            else
            {
                MessageBox.Show($"Khong tim thay sinh vien {txtStudentID.Text}!", "Thông Báo!");
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
                MessageBox.Show("Co loi xay ra!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            LoadForm();
        }
    }
}
