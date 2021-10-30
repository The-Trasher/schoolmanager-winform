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
    public partial class NhapDiemSinhVien : Form
    {
        StudentDBContext dBContext = new StudentDBContext();

        public NhapDiemSinhVien()
        {
            InitializeComponent();
        }

        public void NhapDiemSinhVien_Load(object sender, EventArgs e)
        {
            List<DIEMSV> listScore = dBContext.DIEMSVs.ToList();
            FillDataDGV(listScore);

            txtMaSV.Focus();
        }

        private void FillDataDGV(List<DIEMSV> listScore)
        {
            dgvDanhSach.Rows.Clear();

            foreach (DIEMSV item in listScore)
            {
                int newRow = dgvDanhSach.Rows.Add();
                dgvDanhSach.Rows[newRow].Cells[0].Value = item.MSSV;
                dgvDanhSach.Rows[newRow].Cells[1].Value = item.MAMH;
                dgvDanhSach.Rows[newRow].Cells[2].Value = item.MONHOC.TENMH;
                dgvDanhSach.Rows[newRow].Cells[3].Value = Math.Round((double)item.DIEMKTLAN1, 1);
                dgvDanhSach.Rows[newRow].Cells[4].Value = Math.Round((double)item.DIEMKTLAN2, 1);
                dgvDanhSach.Rows[newRow].Cells[5].Value = Math.Round((double)item.DIEMTHI, 1);
                dgvDanhSach.Rows[newRow].Cells[6].Value = Math.Round((double)item.DIEMTONGKET, 1);
            }
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            if (CheckDataInput())
            {
                SINHVIEN checkExist = dBContext.SINHVIENs.Where(p => p.MSSV == txtMaSV.Text).FirstOrDefault();
                if (checkExist == null)
                {
                    MessageBox.Show($"Không tồn tại sinh viên có MSSV: {txtMaSV.Text}", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    return;
                }

                MONHOC checkMH = dBContext.MONHOCs.Where(p => p.MAMH == txtMaMH.Text).FirstOrDefault();
                if (checkMH == null)
                {
                    MessageBox.Show($"Không tồn tại môn học có Mã MH: {txtMaMH.Text}", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    return;
                }

                if (CheckID(txtMaSV.Text, txtMaMH.Text) == -1)
                {
                    DIEMSV newScore = new DIEMSV();

                    newScore.MAMH = txtMaMH.Text;
                    newScore.MSSV = txtMaSV.Text;
                    newScore.DIEMKTLAN1 = float.Parse(txtKTL1.Text);
                    newScore.DIEMKTLAN2 = float.Parse(txtKTL2.Text);
                    newScore.DIEMTHI = float.Parse(txtDiemThi.Text);
                    newScore.DIEMTONGKET = ((newScore.DIEMKTLAN1 + newScore.DIEMKTLAN2) / 2 + newScore.DIEMTHI) / 2;

                    dBContext.DIEMSVs.AddOrUpdate(newScore);
                    dBContext.SaveChanges();
                    updateDiemTBSinhVien(checkExist);

                    LoadForm();
                    LoadDGV();

                    dgvDanhSach.ClearSelection();
                    dgvDanhSach.Rows[CheckID(newScore.MSSV, newScore.MAMH)].Selected = true;
                    MessageBox.Show($"Thêm điểm {newScore.MAMH} - {newScore.MSSV} thành công!", "Thông Báo!");
                }
                else
                {
                    DIEMSV updateScore = dBContext.DIEMSVs.Where(p => p.MSSV == txtMaSV.Text && p.MAMH == txtMaMH.Text).FirstOrDefault();

                    if (updateScore != null)
                    {
                        updateScore.DIEMKTLAN1 = float.Parse(txtKTL1.Text);
                        updateScore.DIEMKTLAN2 = float.Parse(txtKTL2.Text);
                        updateScore.DIEMTHI = float.Parse(txtDiemThi.Text);
                        updateScore.DIEMTONGKET = ((updateScore.DIEMKTLAN1 + updateScore.DIEMKTLAN2) / 2 + updateScore.DIEMTHI) / 2;

                        dBContext.DIEMSVs.AddOrUpdate(updateScore);
                        dBContext.SaveChanges();
                        updateDiemTBSinhVien(checkExist);

                        LoadForm();
                        LoadDGV();

                        dgvDanhSach.ClearSelection();
                        dgvDanhSach.Rows[CheckID(updateScore.MSSV, updateScore.MAMH)].Selected = true;
                        MessageBox.Show($"Sửa điểm {updateScore.MAMH} - {updateScore.MSSV} thành công!", "Thông Báo!");
                    }
                }
            }
        }

        private int CheckID(string studentID, string subjectID)
        {
            for (int i = 0; i < dgvDanhSach.Rows.Count; i++)
            {
                if (dgvDanhSach.Rows[i].Cells[0].Value.ToString() == studentID && dgvDanhSach.Rows[i].Cells[1].Value.ToString() == subjectID)
                    return i;
            }
            return -1;
        }

        private bool CheckDataInput()
        {
            if (txtMaMH.Text == "" || txtMaSV.Text == "" || txtKTL1.Text == "" || txtKTL2.Text == "" || txtDiemThi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtKTL1.Text != "")
            {
                bool ketQua = float.TryParse(txtKTL1.Text, out float kq1);
                if (!ketQua)
                {
                    MessageBox.Show("Điểm kiểm tra lần 1 phải là số!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            if (txtKTL2.Text != "")
            {
                bool ketQua = float.TryParse(txtKTL2.Text, out float kq2);
                if (!ketQua)
                {
                    MessageBox.Show("Điểm kiểm tra lần 2 phải là số!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            if (txtDiemThi.Text != "")
            {
                bool ketQua = float.TryParse(txtDiemThi.Text, out float kq3);
                if (!ketQua)
                {
                    MessageBox.Show("Điểm Thi phải là số!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            if (float.Parse(txtKTL1.Text) < 0 || float.Parse(txtKTL1.Text) > 10)
            {
                MessageBox.Show("0<= Điểm kiểm tra lần 1 <= 10!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (float.Parse(txtKTL2.Text) < 0 || float.Parse(txtKTL2.Text) > 10)
            {
                MessageBox.Show("0<= Điểm kiểm tra lần 2 <= 10!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (float.Parse(txtDiemThi.Text) < 0 || float.Parse(txtDiemThi.Text) > 10)
            {
                MessageBox.Show("0<= Điểm thi <= 10!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }


            var regexItem = new Regex("^[a-zA-Z0-9]*$");
            if (!regexItem.IsMatch(txtMaMH.Text) || !regexItem.IsMatch(txtMaSV.Text))
            {
                MessageBox.Show("Mã chỉ bao gồm số và chữ viết không dấu!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void LoadDGV()
        {
            List<DIEMSV> newScore = dBContext.DIEMSVs.ToList();
            FillDataDGV(newScore);
        }

        private void LoadForm()
        {
            txtMaMH.Clear();
            txtMaSV.Clear();
            txtKTL1.Clear();
            txtKTL2.Clear();
            txtDiemThi.Clear();
            txtMaSV.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DIEMSV updateScore = dBContext.DIEMSVs.Where(p => p.MSSV == txtMaSV.Text && p.MAMH == txtMaMH.Text).FirstOrDefault();

            if (updateScore != null)
            {
                DialogResult dr = MessageBox.Show($"Bạn thực sự muốn xoá điểm môn {updateScore.MONHOC.TENMH} " +
                    $"\ncủa sinh viên: {updateScore.SINHVIEN.HOTEN}?", "Thông Báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    dBContext.DIEMSVs.Remove(updateScore);
                    dBContext.SaveChanges();
                    SINHVIEN checkExist = dBContext.SINHVIENs.Where(p => p.MSSV == updateScore.MSSV).FirstOrDefault();
                    updateDiemTBSinhVien(checkExist);

                    int i = CheckID(updateScore.MSSV, updateScore.MAMH);

                    LoadForm();
                    LoadDGV();

                    dgvDanhSach.ClearSelection();
                    if (i != 0)
                        dgvDanhSach.Rows[i - 1].Selected = true;
                    MessageBox.Show($"Xóa điểm {updateScore.MAMH} - {updateScore.MSSV} thành công!", "Thông Báo!");
                }
            }
            else
            {
                MessageBox.Show($"Không tìm thấy điểm {txtMaSV.Text} - {txtMaMH.Text}!", "Thông Báo!");
            }
        }

        private void updateDiemTBSinhVien(SINHVIEN checkExist)
        {
            var DIEMTB = dBContext.DIEMSVs
                                .Where(p => p.MSSV == checkExist.MSSV)
                                .Select(p => new { DiemTB = p.DIEMTONGKET })
                                .Average(p => p.DiemTB);
            if (DIEMTB == null)
                DIEMTB = 0;
            checkExist.DIEMTB = DIEMTB;
            dBContext.SINHVIENs.AddOrUpdate(checkExist);
            dBContext.SaveChanges();
        }

        public void btnRefresh_Click(object sender, EventArgs e)
        {

            LoadDGV();
            LoadForm();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvDanhSach.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvDanhSach.CurrentRow.Selected = true;
                    txtMaSV.Text = dgvDanhSach.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                    txtMaMH.Text = dgvDanhSach.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                    txtKTL1.Text = dgvDanhSach.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                    txtKTL2.Text = dgvDanhSach.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                    txtDiemThi.Text = dgvDanhSach.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
                }
            }
            catch (Exception)
            {
                return;
            }
        }
    }
}
