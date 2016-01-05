using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI_QLVLXD;
using BUS;
using DTO;
namespace GUI_QLVLXD
{
    public partial class FrmBaoCaoDoanhThu : Form
    {
        DTO_BaoCaoDoanhThu dto_baocaodoanhthu = new DTO_BaoCaoDoanhThu();
        BUS_BaoCaoDoanhThu bus_baocaodoanhthu = new BUS_BaoCaoDoanhThu();
        public FrmBaoCaoDoanhThu()
        {
            InitializeComponent();

        }

        private void LayThongTinBaoCao()
        {
            
            dto_baocaodoanhthu.Thang = datetimeFrom.Text.Substring(0,2);
            dto_baocaodoanhthu.Nam = datetimeFrom.Text.Substring(3, 4);
        }

        private void LoadDuLieuLenReport()
        {
            
        }

        private void FrmBaoCaoDoanhThu_Load(object sender, EventArgs e)
        {
            double TongNhap = 0;
            double TongXuat = 0;
            double TongDoanhThu = 0;
            
            LayThongTinBaoCao();
            DataTable dsmh = new DataTable();
            DataTable ds = new DataTable();
            dsmh = bus_baocaodoanhthu.LayDanhSachMatHang(dto_baocaodoanhthu);
            ds = bus_baocaodoanhthu.LayDanhSachMatHang(dto_baocaodoanhthu);
            ds.Columns.Add("SLBan");
            ds.Columns.Add("SLNhap");
            ds.Columns.Add("GiaTriBan");
            ds.Columns.Add("GiaTriNhap");
            ds.Columns.Add("DoanhThu");
            ds.Columns.Add("TiLe");

            for (int i = 0; i < ds.Rows.Count; i++)
            {
                ds.Rows[i]["SLBan"] = bus_baocaodoanhthu.LaySLBan(dto_baocaodoanhthu, ds.Rows[i]["MaMH"].ToString()).Rows[0][1].ToString();
                ds.Rows[i]["SLNhap"] = bus_baocaodoanhthu.LaySLNhap(dto_baocaodoanhthu, ds.Rows[i]["MaMH"].ToString()).Rows[0][1].ToString();
                double GiaTriBan = bus_baocaodoanhthu.TongGiaTriBan(dto_baocaodoanhthu, ds.Rows[i]["MaMH"].ToString());
                ds.Rows[i]["GiaTriBan"] = GiaTriBan;
                double GiaTriNhap = bus_baocaodoanhthu.TongGiaTriNhap(dto_baocaodoanhthu, ds.Rows[i]["MaMH"].ToString());
                ds.Rows[i]["GiaTriNhap"] = GiaTriNhap;
                double DoanhThu = GiaTriNhap - GiaTriBan;
                ds.Rows[i]["DoanhThu"] = DoanhThu; TongNhap += GiaTriNhap;
                TongXuat += GiaTriBan;
                TongDoanhThu += DoanhThu;
            }


            for (int i = 0; i < ds.Rows.Count; i++)
            {
                ds.Rows[i]["TiLe"] = (Double.Parse(ds.Rows[i]["DoanhThu"].ToString()) * 100 / TongDoanhThu);
            }


            ds.Columns.Remove("MaMH");
            reportViewer1.Reset();
            reportViewer1.LocalReport.ReportEmbeddedResource = "GUI_QLVLXD.BaoCaoDoanhThu.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            Microsoft.Reporting.WinForms.ReportDataSource newDataSource = new Microsoft.Reporting.WinForms.ReportDataSource("BaocaoDoanhThu",ds);
            newDataSource.Name = "DataSet1";
            reportViewer1.LocalReport.DataSources.Add(newDataSource);

            List<Microsoft.Reporting.WinForms.ReportParameter> Parameters = new List<Microsoft.Reporting.WinForms.ReportParameter>();
            Microsoft.Reporting.WinForms.ReportParameter param = default(Microsoft.Reporting.WinForms.ReportParameter);
            param = new Microsoft.Reporting.WinForms.ReportParameter("TuNgay", dto_baocaodoanhthu.Thang +"/"+ dto_baocaodoanhthu.Nam);
            Parameters.Add(param);
            param = new Microsoft.Reporting.WinForms.ReportParameter("TongNhap", TongNhap+"");
            Parameters.Add(param);
            param = new Microsoft.Reporting.WinForms.ReportParameter("TongBan", TongXuat+"");
            Parameters.Add(param);
            param = new Microsoft.Reporting.WinForms.ReportParameter("TongDoanhThu", TongDoanhThu+"");
            Parameters.Add(param);
            reportViewer1.LocalReport.SetParameters(Parameters);
            this.reportViewer1.RefreshReport();
        }

    }
}
