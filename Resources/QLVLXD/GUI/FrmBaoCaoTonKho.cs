using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI_QLVLXD
{
    public partial class FrmBaoCaoTonKho : Form
    {
        DTO_BaoCaoTonKho dto_baocaotonkho = new DTO_BaoCaoTonKho();
        BUS_BaoCaoTonKho bus_baocaotonkho = new BUS_BaoCaoTonKho();
        public FrmBaoCaoTonKho()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void LayThongTinBaoCao()
        {
            dto_baocaotonkho.TuNgay = datetimeFrom.Text;
            dto_baocaotonkho.DenNgay = datetimeTo.Text;
        }

        private void LoadDuLieuLenReport()
        {

        }

        private void FrmBaoCaoTonKho_Load(object sender, EventArgs e)
        {
            LayThongTinBaoCao();
            DataTable dsmh = new DataTable();
            DataTable ds = new DataTable();
            dsmh = bus_baocaotonkho.LayDanhSachMatHang(dto_baocaotonkho);
            ds = bus_baocaotonkho.LayDanhSachMatHang(dto_baocaotonkho);
            ds.Columns.Add("SLBan");
            ds.Columns.Add("SLNhap");
            ds.Columns.Add("SLTon");
            ds.Columns.Add("SLThuc");

            for (int i = 0; i < ds.Rows.Count; i++)
            {
                ds.Rows[i]["SLBan"] = bus_baocaotonkho.LaySLBan(dto_baocaotonkho, ds.Rows[i]["MaMH"].ToString()).Rows[0][1].ToString();
                ds.Rows[i]["SLNhap"] = bus_baocaotonkho.LaySLNhap(dto_baocaotonkho, ds.Rows[i]["MaMH"].ToString()).Rows[0][1].ToString();
                double SLTon = Double.Parse(ds.Rows[i]["SLNhap"].ToString()) - Double.Parse(ds.Rows[i]["SLBan"].ToString());//bus_baocaotonkho.TongGiaTriBan(dto_baocaotonkho, ds.Rows[i]["MaMH"].ToString());
                ds.Rows[i]["SLTon"] = SLTon.ToString();
                double SLThuc = 0;//bus_baocaotonkho.TongGiaTriNhap(dto_baocaotonkho, ds.Rows[i]["MaMH"].ToString());
                ds.Rows[i]["SLThuc"] = SLThuc.ToString();
            }

            ds.Columns.Remove("MaMH");
            reportViewer1.Reset();
            reportViewer1.LocalReport.ReportEmbeddedResource = "GUI_QLVLXD.BaoCaoTonKho.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            Microsoft.Reporting.WinForms.ReportDataSource newDataSource = new Microsoft.Reporting.WinForms.ReportDataSource("BaocaoTonKho", ds);
            newDataSource.Name = "DataSet1";
            reportViewer1.LocalReport.DataSources.Add(newDataSource);

            List<Microsoft.Reporting.WinForms.ReportParameter> Parameters = new List<Microsoft.Reporting.WinForms.ReportParameter>();
            Microsoft.Reporting.WinForms.ReportParameter param = default(Microsoft.Reporting.WinForms.ReportParameter);
            param = new Microsoft.Reporting.WinForms.ReportParameter("TuNgay", dto_baocaotonkho.TuNgay);
            Parameters.Add(param);
            param = new Microsoft.Reporting.WinForms.ReportParameter("DenNgay", dto_baocaotonkho.DenNgay);
            Parameters.Add(param);
            reportViewer1.LocalReport.SetParameters(Parameters);
            this.reportViewer1.RefreshReport();
        }
    }
}
