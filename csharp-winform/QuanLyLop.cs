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
    public partial class QuanLyLop : Form
    {
        StudentDBContext dBContext = new StudentDBContext();

        public QuanLyLop()
        {
            InitializeComponent();
        }

        private void QuanLyLop_Load(object sender, EventArgs e)
        {
            List<LOP> listLop = dBContext.LOPs.ToList();
            List<KHOA> listKhoa = dBContext.KHOAs.ToList();

            FillDataDGV(listLop);
            FillDataCBB(listKhoa);
        }

        private void FillDataDGV(List<LOP> listLop)
        {
            dgvDSLop.Rows.Clear();

            foreach (LOP item in listLop)
            {
                int newRow = dgvDSLop.Rows.Add();
                dgvDSLop.Rows[newRow].Cells[0].Value = item.MALOP;
                dgvDSLop.Rows[newRow].Cells[1].Value = item.TENLOP;
                dgvDSLop.Rows[newRow].Cells[2].Value = item.KHOA.MAKHOA;
                dgvDSLop.Rows[newRow].Cells[3].Value = item.SISO;
            }
        }

        private void FillDataCBB(List<KHOA> listKhoa)
        {
            cbbKhoa.DataSource = listKhoa;
            cbbKhoa.ValueMember = "MAKHOA";
            cbbKhoa.DisplayMember = "MAKHOA";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            if (CheckDataInput())
            {
                if (CheckIDClass(txtMaLop.Text) == -1)
                {
                    LOP newClass = new LOP();

                    newClass.MALOP = txtMaLop.Text;
                    newClass.TENLOP = txtTenLop.Text;
                    newClass.MAKHOA = cbbKhoa.SelectedValue.ToString();
                    newClass.SISO = 0;

                    dBContext.LOPs.AddOrUpdate(newClass);
                    dBContext.SaveChanges();

                    LoadForm();
                    LoadDGV();

                    dgvDSLop.ClearSelection();
                    dgvDSLop.Rows[CheckIDClass(newClass.MALOP)].Selected = true;
                    MessageBox.Show($"Thêm lớp {newClass.MALOP} thành công", "Thông Báo!");
                }
                else
                {
                    LOP updateClass = dBContext.LOPs.Where(p => p.MALOP == txtMaLop.Text).FirstOrDefault();

                    if (updateClass != null)
                    {
                        updateClass.TENLOP = txtTenLop.Text;
                        updateClass.MAKHOA = cbbKhoa.SelectedValue.ToString();

                        dBContext.LOPs.AddOrUpdate(updateClass);
                        dBContext.SaveChanges();

                        LoadForm();
                        LoadDGV();

                        dgvDSLop.ClearSelection();
                        dgvDSLop.Rows[CheckIDClass(updateClass.MALOP)].Selected = true;
                        MessageBox.Show($"Sửa lớp {updateClass.MALOP} thành công", "Thông Báo!");
                    }
                }
            }
        }

        private int CheckIDClass(string idClass)
        {
            for (int i = 0; i < dgvDSLop.Rows.Count; i++)
            {
                if (dgvDSLop.Rows[i].Cells[0].Value.ToString() == idClass)
                    return i;
            }
            return -1;
        }

        private bool CheckDataInput()
        {
            if (txtMaLop.Text == "" || txtTenLop.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã và tên lớp!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            var regexItem = new Regex("^[a-zA-Z0-9]*$");
            if (!regexItem.IsMatch(txtMaLop.Text))
            {
                MessageBox.Show("Mã lớp chỉ bao gồm số và chữ viết không dấu!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void LoadDGV()
        {
            List<LOP> newClass = dBContext.LOPs.ToList();
            FillDataDGV(newClass);
        }

        private void LoadForm()
        {
            txtMaLop.Clear();
            txtTenLop.Clear();
            txtSiSo.Clear();
            txtMaLop.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            LOP updateClass = dBContext.LOPs.Where(p => p.MALOP == txtMaLop.Text).FirstOrDefault();

            if (updateClass != null)
            {
                SINHVIEN checkExist = dBContext.SINHVIENs.Where(p => p.MALOP == updateClass.MALOP).FirstOrDefault();
                if (checkExist != null)
                {
                    MessageBox.Show($"Không thể xoá lớp: {txtTenLop.Text}, do tồn tại sinh viên trong lớp, hãy xóa sinh viên trong lớp trước!", "Thông báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    return;
                }
                DialogResult dr = MessageBox.Show("Bạn có muốn xóa không ?", "Thông Báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {

                    dBContext.LOPs.Remove(updateClass);
                    dBContext.SaveChanges();

                    int i = CheckIDClass(updateClass.MALOP);

                    LoadForm();
                    LoadDGV();

                    dgvDSLop.ClearSelection();
                    if (i != 0)
                        dgvDSLop.Rows[i - 1].Selected = true;
                    MessageBox.Show($"Xóa lớp {updateClass.MALOP} thành công", "Thông Báo!");
                }
            }
            else
            {
                MessageBox.Show($"Không tìm thấy lớp {txtMaLop.Text}!", "Thông Báo!");
            }
        }

        private void dgvDSLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvDSLop.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvDSLop.CurrentRow.Selected = true;
                    txtMaLop.Text = dgvDSLop.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                    txtTenLop.Text = dgvDSLop.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                    cbbKhoa.SelectedIndex = cbbKhoa.FindString(dgvDSLop.Rows[e.RowIndex].Cells[2].FormattedValue.ToString());
                    txtSiSo.Text = dgvDSLop.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            QuanLyLop_Load(sender, e);
            LoadForm();
        }
    }
}
