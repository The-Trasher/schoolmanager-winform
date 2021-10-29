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
    public partial class RP_DanhSachDiemSV : Form
    {
        StudentDBContext dBContext = new StudentDBContext();
        public RP_DanhSachDiemSV()
        {
            InitializeComponent();
        }

        private void RP_DiemSV_Load(object sender, EventArgs e)
        {
            List<LOP> listLop = dBContext.LOPs.ToList();
            List<MONHOC> listMH = dBContext.MONHOCs.ToList();
            FillDataCBBLop(listLop);
            FillDataCBBMH(listMH);
            
            rdbMSSV.Checked = true;
            RP_Diem.Visible = false;
            this.RP_Diem.RefreshReport();
        }

       

        private void FillDataCBBLop(List<LOP> listLop)
        {
            cbbLop.DataSource = listLop;
            cbbLop.ValueMember = "MALOP";
            cbbLop.DisplayMember = "TENLOP";
        }
        private void FillDataCBBMH(List<MONHOC> listMH)
        {
            cbbMonHoc.DataSource = listMH;
            cbbMonHoc.ValueMember = "MAMH";
            cbbMonHoc.DisplayMember = "TENMH";
        }

        private void rdbMSSV_CheckedChanged(object sender, EventArgs e)
        {
            txtMSSV.Enabled = true;
            cbbLop.Enabled = false;
            cbbMonHoc.Enabled = false;
        }

        private void rdbLop_CheckedChanged(object sender, EventArgs e)
        {
            txtMSSV.Enabled = false;
            cbbLop.Enabled = true;
            cbbMonHoc.Enabled = false;
        }

        private void rdbMonHoc_CheckedChanged(object sender, EventArgs e)
        {
            txtMSSV.Enabled = false;
            cbbLop.Enabled = false;
            cbbMonHoc.Enabled = true;
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            ReportParameter[] param = new ReportParameter[3];
            RP_Diem.Visible = true;
            if(rdbMSSV.Checked)
            {
                if(txtMSSV.Text =="")
                {
                    MessageBox.Show("Vui lòng nhập MSSV !", "Thông Báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    List<RP_DiemSV> listDiem = new List<RP_DiemSV>();
                    DateTime today = DateTime.Today;

                    string HT = "";
                    var listRP = dBContext.DIEMSVs.Where(p => p.MSSV == txtMSSV.Text).ToList();
                    param[0] = new ReportParameter("NgayTK", string.Format(today.ToString("dd/MM/yyyy")));
                    param[1] = new ReportParameter("MSSV", txtMSSV.Text);
                    if (listRP.Count==0)
                    {
                        MessageBox.Show($"Không có điểm của sinh viên có MSSV: {txtMSSV.Text}", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        foreach (var item in listRP)
                        {
                            RP_DiemSV temp = new RP_DiemSV();
                            temp.MaMH = item.MAMH;
                            temp.TenMH = item.MONHOC.TENMH;
                            temp.DiemKT1 =(double) item.DIEMKTLAN1;
                            temp.DiemKT2 = (double)item.DIEMKTLAN2;
                            temp.DiemThi = (double)item.DIEMTHI;
                            temp.DiemTongKet = (double)item.DIEMTONGKET;
                            listDiem.Add(temp);
                            HT = item.SINHVIEN.HOTEN;
                        }
                        param[2] = new ReportParameter("HoTen",HT);

                        this.RP_Diem.LocalReport.ReportPath = "./Report/RP_Diem_TheoMSSV.rdlc";
                        this.RP_Diem.LocalReport.SetParameters(param);
                        var reportDataSource = new ReportDataSource("DataSetThongKe", listDiem);
                        this.RP_Diem.LocalReport.DataSources.Clear();
                        this.RP_Diem.LocalReport.DataSources.Add(reportDataSource);
                        this.RP_Diem.RefreshReport();
                    }
                }
            }

            //============================================================================================================================================================

            if (rdbMonHoc.Checked)
            {
                List<RP_DiemSV> listDiem = new List<RP_DiemSV>();
                DateTime today = DateTime.Today;

                var listRP = dBContext.DIEMSVs.Where(p => p.MAMH == cbbMonHoc.SelectedValue.ToString()).ToList();
                param[0] = new ReportParameter("NgayTK", string.Format(today.ToString("dd/MM/yyyy")));
                param[1] = new ReportParameter("MaMH", cbbMonHoc.SelectedValue.ToString());
                param[2] = new ReportParameter("TongSo", listRP.Count().ToString());
                if (listRP.Count == 0)
                {
                    MessageBox.Show($"Không có điểm của sinh viên nào cho môn: {cbbMonHoc.Text}", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    foreach (var item in listRP)
                    {
                        RP_DiemSV temp = new RP_DiemSV();
                        temp.MSSV = item.SINHVIEN.MSSV;
                        temp.Hoten = item.SINHVIEN.HOTEN;
                        temp.DiemKT1 = (double)item.DIEMKTLAN1;
                        temp.DiemKT2 = (double)item.DIEMKTLAN2;
                        temp.DiemThi = (double)item.DIEMTHI;
                        temp.DiemTongKet = (double)item.DIEMTONGKET;
                        listDiem.Add(temp);
                    }

                    this.RP_Diem.LocalReport.ReportPath = "./Report/RP_Diem_TheoMonHoc.rdlc";
                    this.RP_Diem.LocalReport.SetParameters(param);
                    var reportDataSource = new ReportDataSource("DataSetThongKe", listDiem);
                    this.RP_Diem.LocalReport.DataSources.Clear();
                    this.RP_Diem.LocalReport.DataSources.Add(reportDataSource);
                    this.RP_Diem.RefreshReport();
                }
            }

            //============================================================================================================================================================

            if (rdbLop.Checked)
            {
                DateTime today = DateTime.Today;

                var listRP = dBContext.SINHVIENs.Where(p => p.MALOP == cbbLop.SelectedValue.ToString()).ToList();
                param[0] = new ReportParameter("NgayTK", string.Format(today.ToString("dd/MM/yyyy")));
                param[1] = new ReportParameter("MaLop", cbbLop.SelectedValue.ToString());
                param[2] = new ReportParameter("TongSo", listRP.Count().ToString());
                if (listRP.Count == 0)
                {
                    MessageBox.Show($"Không có điểm của sinh viên nào cho lớp: {cbbLop.Text}", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {       
                    this.RP_Diem.LocalReport.ReportPath = "./Report/RP_Diem_TheoLop.rdlc";
                    this.RP_Diem.LocalReport.SetParameters(param);
                    var reportDataSource = new ReportDataSource("DataSetThongKe", listRP);
                    this.RP_Diem.LocalReport.DataSources.Clear();
                    this.RP_Diem.LocalReport.DataSources.Add(reportDataSource);
                    this.RP_Diem.RefreshReport();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.RP_Diem.LocalReport.DataSources.Clear();
            RP_Diem.Visible = false;
            RP_DiemSV_Load(sender, e);
        }
    }
}
