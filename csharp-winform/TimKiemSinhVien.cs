using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using csharp_winform.Model;

namespace csharp_winform
{
    public partial class TimKiemSinhVien : Form
    {
        StudentDBContext dBContext = new StudentDBContext();

        public TimKiemSinhVien()
        {
            InitializeComponent();
        }

        private void TimKiemSinhVien_Load(object sender, EventArgs e)
        {
            List<KHOA> listKhoa = dBContext.KHOAs.ToList();
            List<LOP> listLop = dBContext.LOPs.ToList();
            List<MONHOC> listMon = dBContext.MONHOCs.ToList();

            FillDataCBBKhoa(listKhoa);
            FillDataCBBLop(listLop);
            FillDataCBBMon(listMon);
            LoadForm();
        }

        private void FillDataCBBKhoa(List<KHOA> listKhoa)
        {
            cbbKhoa.DataSource = listKhoa;
            cbbKhoa.ValueMember = "MAKHOA";
            cbbKhoa.DisplayMember = "MAKHOA";
        }

        private void FillDataCBBLop(List<LOP> listLop)
        {
            cbbLop.DataSource = listLop;
            cbbLop.ValueMember = "MALOP";
            cbbLop.DisplayMember = "MALOP";
        }

        private void FillDataCBBMon(List<MONHOC> listMon)
        {
            cbbMonHoc.DataSource = listMon;
            cbbMonHoc.ValueMember = "MAMH";
            cbbMonHoc.DisplayMember = "MAMH";
        }

        private void LoadForm()
        {
            rbMSSV.Checked = true;
            txtMSSV.Clear();
            txtKhoaHoc.Clear();
            txtMSSV.Focus();
            RadioButtonCheck();
        }

        private string RadioButtonCheck()
        {
            if (rbMSSV.Checked)
            {
                txtMSSV.Enabled = true;
                cbbKhoa.Enabled = false;
                cbbLop.Enabled = false;
                cbbMonHoc.Enabled = false;
                txtKhoaHoc.Enabled = false;
                return "rbMSSV";
            }
            else if (rbKhoa.Checked)
            {
                txtMSSV.Enabled = false;
                cbbKhoa.Enabled = true;
                cbbLop.Enabled = false;
                cbbMonHoc.Enabled = false;
                txtKhoaHoc.Enabled = false;
                return "rbKhoa";
            }
            else if (rbLop.Checked)
            {
                txtMSSV.Enabled = false;
                cbbKhoa.Enabled = false;
                cbbLop.Enabled = true;
                cbbMonHoc.Enabled = false;
                txtKhoaHoc.Enabled = false;
                return "rbLop";
            }
            else if (rbMonHoc.Checked)
            {
                txtMSSV.Enabled = false;
                cbbKhoa.Enabled = false;
                cbbLop.Enabled = false;
                cbbMonHoc.Enabled = true;
                txtKhoaHoc.Enabled = false;
                return "rbMonHoc";
            }
            else if (rbKhoaHoc.Checked)
            {
                txtMSSV.Enabled = false;
                cbbKhoa.Enabled = false;
                cbbLop.Enabled = false;
                cbbMonHoc.Enabled = false;
                txtKhoaHoc.Enabled = true;
                return "rbKhoaHoc";
            }

            return "error";
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvStudent.Rows.Clear();
            TimKiemSinhVien_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string radioButton = RadioButtonCheck();
            if (radioButton == "rbMSSV")
            {
                List<SINHVIEN> listSinhVien = dBContext.SINHVIENs.Where(p => p.MSSV == txtMSSV.Text).ToList();
                FillDataDGV(listSinhVien);
            }
            else if (radioButton == "rbKhoa")
            {
                List<SINHVIEN> listSinhVien = dBContext.SINHVIENs.Where(p => p.LOP.MAKHOA == cbbKhoa.SelectedValue.ToString()).ToList();
                FillDataDGV(listSinhVien);
            }
            else if (radioButton == "rbLop")
            {
                List<SINHVIEN> listSinhVien = dBContext.SINHVIENs.Where(p => p.MALOP == cbbLop.SelectedValue.ToString()).ToList();
                FillDataDGV(listSinhVien);
            }
            else if (radioButton == "rbMonHoc")
            {
                List<DIEMSV> listDiemSinhVien = dBContext.DIEMSVs.Where(p => p.MAMH == cbbMonHoc.SelectedValue.ToString()).Distinct().ToList();
                List<SINHVIEN> listSinhVien = new List<SINHVIEN>();
                foreach (var item in listDiemSinhVien)
                {
                    listSinhVien.Add(dBContext.SINHVIENs.Where(p => p.MSSV == item.MSSV).FirstOrDefault());
                }
                FillDataDGV(listSinhVien);
            }
            else if (radioButton == "rbKhoaHoc")
            {
                int kq = 0;
                bool ketqua = int.TryParse(txtKhoaHoc.Text, out kq);
                if (ketqua)
                {
                    int khoaHoc = int.Parse(txtKhoaHoc.Text);
                    List<SINHVIEN> listSinhVien = dBContext.SINHVIENs.Where(p => p.KHOAHOC == khoaHoc).ToList();
                    FillDataDGV(listSinhVien);
                }
                else
                {
                    MessageBox.Show("Khoá học phải là 1 số nguyên. ( VD: 19 )");
                }
            }
        }

        private void rbMSSV_CheckedChanged(object sender, EventArgs e)
        {
            RadioButtonCheck();
        }

        private void rbKhoa_CheckedChanged(object sender, EventArgs e)
        {
            RadioButtonCheck();
        }

        private void rbLop_CheckedChanged(object sender, EventArgs e)
        {
            RadioButtonCheck();
        }

        private void rbMonHoc_CheckedChanged(object sender, EventArgs e)
        {
            RadioButtonCheck();
        }

        private void rbKhoaHoc_CheckedChanged(object sender, EventArgs e)
        {
            RadioButtonCheck();
        }
    }
}
