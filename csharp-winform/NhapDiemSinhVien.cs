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

        private void NhapDiemSinhVien_Load(object sender, EventArgs e)
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
                dgvDanhSach.Rows[newRow].Cells[2].Value = item.DIEMKTLAN1;
                dgvDanhSach.Rows[newRow].Cells[3].Value = item.DIEMKTLAN2;
                dgvDanhSach.Rows[newRow].Cells[4].Value = item.DIEMTHI;
                dgvDanhSach.Rows[newRow].Cells[5].Value = item.DIEMTONGKET;
            }
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            if (CheckDataInput())
            {
                if (CheckID(txtMaSV.Text, txtMaMH.Text) == -1)
                {
                    DIEMSV newScore = new DIEMSV();

                    newScore.MAMH = txtMaMH.Text;
                    newScore.MSSV = txtMaSV.Text;
                    if (txtKTL1.Text != "")
                        newScore.DIEMKTLAN1 = float.Parse(txtKTL1.Text);
                    else
                        newScore.DIEMKTLAN1 = 0;
                    if (txtKTL2.Text != "")
                        newScore.DIEMKTLAN2 = float.Parse(txtKTL2.Text);
                    else
                        newScore.DIEMKTLAN2 = 0;
                    if (txtDiemThi.Text != "")
                        newScore.DIEMTHI = float.Parse(txtDiemThi.Text);
                    else
                        newScore.DIEMTHI = 0;
                    newScore.DIEMTONGKET = ((newScore.DIEMKTLAN1 + newScore.DIEMKTLAN2) / 2 + newScore.DIEMTHI) / 2;

                    dBContext.DIEMSVs.AddOrUpdate(newScore);
                    dBContext.SaveChanges();

                    LoadForm();
                    LoadDGV();

                    dgvDanhSach.ClearSelection();
                    dgvDanhSach.Rows[CheckID(newScore.MSSV, newScore.MAMH)].Selected = true;
                    MessageBox.Show($"Them diem {newScore.MAMH} - {newScore.MSSV} thanh cong!", "Thong bao");
                }
                else
                {
                    DIEMSV updateScore = dBContext.DIEMSVs.Where(p => p.MSSV == txtMaSV.Text && p.MSSV == txtMaSV.Text).FirstOrDefault();

                    if (updateScore != null)
                    {
                        if (txtKTL1.Text != "")
                            updateScore.DIEMKTLAN1 = float.Parse(txtKTL1.Text);
                        else
                            updateScore.DIEMKTLAN1 = 0;
                        if (txtKTL2.Text != "")
                            updateScore.DIEMKTLAN2 = float.Parse(txtKTL2.Text);
                        else
                            updateScore.DIEMKTLAN2 = 0;
                        if (txtDiemThi.Text != "")
                            updateScore.DIEMTHI = float.Parse(txtDiemThi.Text);
                        else
                            updateScore.DIEMTHI = 0;
                        updateScore.DIEMTONGKET = ((updateScore.DIEMKTLAN1 + updateScore.DIEMKTLAN2) / 2 + updateScore.DIEMTHI) / 2;

                        dBContext.DIEMSVs.AddOrUpdate(updateScore);
                        dBContext.SaveChanges();

                        LoadForm();
                        LoadDGV();

                        dgvDanhSach.ClearSelection();
                        dgvDanhSach.Rows[CheckID(updateScore.MSSV, updateScore.MAMH)].Selected = true;
                        MessageBox.Show($"Sua diem {updateScore.MAMH} - {updateScore.MSSV} thanh cong!", "Thong bao");
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
            if (txtMaMH.Text == "" || txtMaSV.Text == "")
            {
                MessageBox.Show("Vui long nhap day du ma mon hoc va ma sinh vien!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (txtKTL1.Text != "")
            {
                float kq = 0;
                bool ketQua = float.TryParse(txtKTL1.Text, out kq);
                if (!ketQua)
                {
                    MessageBox.Show("Diem KT lan 1 phai la so!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            else if (txtKTL2.Text != "")
            {
                float kq = 0;
                bool ketQua = float.TryParse(txtKTL2.Text, out kq);
                if (!ketQua)
                {
                    MessageBox.Show("Diem KT lan 2 phai la so!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            else if (txtDiemThi.Text != "")
            {
                float kq = 0;
                bool ketQua = float.TryParse(txtDiemThi.Text, out kq);
                if (!ketQua)
                {
                    MessageBox.Show("Diem Thi phai la so!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            else if (txtDiemThi.Text != "")
            {
                float kq = 0;
                bool ketQua = float.TryParse(txtDiemThi.Text, out kq);
                if (!ketQua)
                {
                    MessageBox.Show("Diem Tong ket phai la so!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            var regexItem = new Regex("^[a-zA-Z0-9]*$");
            if (!regexItem.IsMatch(txtMaMH.Text) || !regexItem.IsMatch(txtMaSV.Text))
            {
                MessageBox.Show("Mã chỉ bao gồm số và chữ viết không dấu!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            DIEMSV updateScore = dBContext.DIEMSVs.Where(p => p.MSSV == txtMaSV.Text && p.MSSV == txtMaSV.Text).FirstOrDefault();

            if (updateScore != null)
            {
                DialogResult dr = MessageBox.Show("Ban co muon xoa khong?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    dBContext.DIEMSVs.Remove(updateScore);
                    dBContext.SaveChanges();

                    int i = CheckID(updateScore.MSSV, updateScore.MAMH);

                    LoadForm();
                    LoadDGV();

                    dgvDanhSach.ClearSelection();
                    if (i != 0)
                        dgvDanhSach.Rows[i - 1].Selected = true;
                    MessageBox.Show($"Xoa diem {updateScore.MAMH} - {updateScore.MSSV} thanh cong!", "Thong bao");
                }
            }
            else
            {
                MessageBox.Show($"Khong tim thay diem {txtMaSV.Text} - {txtMaMH.Text}!", "Thong bao");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            NhapDiemSinhVien_Load(sender, e);
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
                    txtKTL1.Text = dgvDanhSach.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                    txtKTL2.Text = dgvDanhSach.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                    txtDiemThi.Text = dgvDanhSach.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Co loi xay ra!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
