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
using Microsoft.Reporting.WinForms;

namespace csharp_winform
{
    public partial class RP_DanhSachSV : Form
    {
        StudentDBContext dBContext = new StudentDBContext();
        public RP_DanhSachSV()
        {
            InitializeComponent();
        }

        private void RP_DanhSachSV_Load(object sender, EventArgs e)
        {
            List<KHOA> listKhoa = dBContext.KHOAs.ToList();
            List<LOP> listLop = dBContext.LOPs.ToList();
            FillDataCBBKhoa(listKhoa);
            FillDataCBBLop(listLop);
            rdbLop.Checked = true;
            RP_DSSV.Visible = false;
            this.RP_DSSV.RefreshReport();
        }
        private void FillDataCBBLop(List<LOP> listLop)
        {
            cbbLop.DataSource = listLop;
            cbbLop.ValueMember = "MALOP";
            cbbLop.DisplayMember = "TENLOP";
        }
        private void FillDataCBBKhoa(List<KHOA> listKhoa)
        {
            cbbKhoa.DataSource = listKhoa;
            cbbKhoa.ValueMember = "MAKHOA";
            cbbKhoa.DisplayMember = "TENKHOA";
        }

        private void rdbLop_CheckedChanged(object sender, EventArgs e)
        {
            cbbLop.Enabled = true;
            cbbKhoa.Enabled = false;
            grbDiemTB.Enabled = false;
        }

        private void rdbKhoa_CheckedChanged(object sender, EventArgs e)
        {
            cbbLop.Enabled = false;
            cbbKhoa.Enabled = true;
            grbDiemTB.Enabled = false;
        }

        private void rdbDiem_CheckedChanged(object sender, EventArgs e)
        {
            grbDiemTB.Enabled = true;
            cbbLop.Enabled = false;
            cbbKhoa.Enabled = false;

        }

        
        private void btnXuat_Click(object sender, EventArgs e)
        {
            RP_DSSV.Visible = true;
            ReportParameter[] param = new ReportParameter[3];
            if (rdbLop.Checked)
            {
                DateTime today = DateTime.Today;

                var listRP = dBContext.SINHVIENs.Where(p => p.MALOP == cbbLop.SelectedValue.ToString()).ToList();
                param[0] = new ReportParameter("NgayTK", string.Format(today.ToString("dd/MM/yyyy")));
                param[1] = new ReportParameter("Lop", cbbLop.SelectedValue.ToString());
                param[2] = new ReportParameter("TongSo",listRP.Count().ToString());
                if (listRP.Count()==0)
                {
                    MessageBox.Show($"Không có sinh viên nào thuộc lớp: {cbbLop.Text}", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    this.RP_DSSV.LocalReport.ReportPath = "./Report/RP_DSSV_TheoLop.rdlc";
                    this.RP_DSSV.LocalReport.SetParameters(param);
                    var reportDataSource = new ReportDataSource("DataSetThongKe", listRP);
                    this.RP_DSSV.LocalReport.DataSources.Clear();
                    this.RP_DSSV.LocalReport.DataSources.Add(reportDataSource);
                    this.RP_DSSV.RefreshReport();
                }
            }

            //============================================================================================================================================================

            if (rdbKhoa.Checked)
            {
                DateTime today = DateTime.Today;

                var listRP = dBContext.SINHVIENs.Where(p => p.LOP.KHOA.MAKHOA == cbbKhoa.SelectedValue.ToString()).ToList();
                param[0] = new ReportParameter("NgayTK", string.Format(today.ToString("dd/MM/yyyy")));
                param[1] = new ReportParameter("Khoa", cbbKhoa.SelectedValue.ToString());
                param[2] = new ReportParameter("TongSo", listRP.Count().ToString());
                if (listRP.Count() == 0)
                {
                    MessageBox.Show($"Không có sinh viên nào thuộc khoa: {cbbKhoa.Text}","Thông Báo!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    this.RP_DSSV.LocalReport.ReportPath = "./Report/RP_DSSV_TheoLop.rdlc";
                    this.RP_DSSV.LocalReport.SetParameters(param);
                    var reportDataSource = new ReportDataSource("DataSetThongKe", listRP);
                    this.RP_DSSV.LocalReport.DataSources.Clear();
                    this.RP_DSSV.LocalReport.DataSources.Add(reportDataSource);
                    this.RP_DSSV.RefreshReport();
                }
            }

            //============================================================================================================================================================

            if (rdbDiem.Checked)
            {
                if (rdbMiss.Checked)
                {
                    DateTime today = DateTime.Today;

                    var listRP = dBContext.SINHVIENs.Where(p => p.DIEMTB < 4).ToList();
                    param[0] = new ReportParameter("NgayTK", string.Format(today.ToString("dd/MM/yyyy")));
                    param[1] = new ReportParameter("DiemTB", rdbMiss.Text);
                    param[2] = new ReportParameter("TongSo", listRP.Count().ToString());
                    if (listRP.Count() == 0)
                    {
                        MessageBox.Show($"Không có sinh viên nào có: {rdbMiss.Text}", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        this.RP_DSSV.LocalReport.ReportPath = "./Report/RP_DSSV_TheoDiem.rdlc";
                        this.RP_DSSV.LocalReport.SetParameters(param);
                        var reportDataSource = new ReportDataSource("DataSetThongKe", listRP);
                        this.RP_DSSV.LocalReport.DataSources.Clear();
                        this.RP_DSSV.LocalReport.DataSources.Add(reportDataSource);
                        this.RP_DSSV.RefreshReport();
                    }
                }
                else
                {
                    DateTime today = DateTime.Today;

                    var listRP = dBContext.SINHVIENs.Where(p => p.DIEMTB >= 4).ToList();
                    param[0] = new ReportParameter("NgayTK", string.Format(today.ToString("dd/MM/yyyy")));
                    param[1] = new ReportParameter("DiemTB", rdbPass.Text);
                    param[2] = new ReportParameter("TongSo", listRP.Count().ToString());
                    if (listRP.Count() == 0)
                    {
                        MessageBox.Show($"Không có sinh viên nào có: {rdbPass.Text}", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        this.RP_DSSV.LocalReport.ReportPath = "./Report/RP_DSSV_TheoDiem.rdlc";
                        this.RP_DSSV.LocalReport.SetParameters(param);
                        var reportDataSource = new ReportDataSource("DataSetThongKe", listRP);
                        this.RP_DSSV.LocalReport.DataSources.Clear();
                        this.RP_DSSV.LocalReport.DataSources.Add(reportDataSource);
                        this.RP_DSSV.RefreshReport();
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.RP_DSSV.LocalReport.DataSources.Clear();
            RP_DSSV.Visible = false;
            RP_DanhSachSV_Load(sender, e);
        }
    }
}
