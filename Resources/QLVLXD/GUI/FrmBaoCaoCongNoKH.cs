using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace GUI_QLVLXD
{
    public partial class FrmBaoCaoCongNoKH : Form
    {
        DTO_BaoCaoCongNo dto_baocaocongno = new DTO_BaoCaoCongNo();
        BUS_BaoCaoCongNo bus_baocaocongno = new BUS_BaoCaoCongNo();
        public FrmBaoCaoCongNoKH()
        {
            InitializeComponent();
        }

        private void LayThongTinBaoCao()
        {
            dto_baocaocongno.TuNgay = datetimeFrom.Text;
            dto_baocaocongno.DenNgay = datetimeTo.Text;
        }

        private void LoadDuLieuLenReport()
        {

        }


        private void FrmBaoCaoCongNoKH_Load(object sender, EventArgs e)
        {
            LayThongTinBaoCao();
            List<DTO_BaoCaoCongNo> DSCongNo = new List<DTO_BaoCaoCongNo>();
            DSCongNo = bus_baocaocongno.TaoDanhSachCongNo(dto_baocaocongno);
           
            DataTable ds = new DataTable();
            ds = bus_baocaocongno.LayDanhSachKhachHang(dto_baocaocongno);
            ds.Columns.Add("TongTien");
            ds.Columns.Add("DaThanhToan");
            ds.Columns.Add("No");
            ds.Columns.Add("TiLe");
            ds.Columns.Add("NhanVien");

            for (int i = 0; i < ds.Rows.Count; i++)
            {
                try
                {
                    double TongTien = DSCongNo[i].TongGiaoDich;
                    ds.Rows[i]["TongTien"] = TongTien;
                    double DTT = DSCongNo[i].DaTra;
                    ds.Rows[i]["DaThanhToan"] = DTT;
                    double ConNo = DSCongNo[i].TongNo;
                    ds.Rows[i]["No"] = ConNo;
                    double Tile = DSCongNo[i].Tile;
                    ds.Rows[i]["Tile"] = Tile;
                }
                catch (Exception ex)
                {
                    int MacDinh = 0;
                    ds.Rows[i]["TongTien"] = MacDinh;
                    ds.Rows[i]["DaThanhToan"] = MacDinh;
                    ds.Rows[i]["No"] = MacDinh;
                    ds.Rows[i]["Tile"] = MacDinh;
                }

            }
            reportViewer1.Reset();
            reportViewer1.LocalReport.ReportEmbeddedResource = "GUI_QLVLXD.BaoCaoCongNoKH.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            Microsoft.Reporting.WinForms.ReportDataSource newDataSource = new Microsoft.Reporting.WinForms.ReportDataSource("BaocaoCongNoKH", ds);
            newDataSource.Name = "DataSet1";
            reportViewer1.LocalReport.DataSources.Add(newDataSource);

            List<Microsoft.Reporting.WinForms.ReportParameter> Parameters = new List<Microsoft.Reporting.WinForms.ReportParameter>();
            Microsoft.Reporting.WinForms.ReportParameter param = default(Microsoft.Reporting.WinForms.ReportParameter);
            param = new Microsoft.Reporting.WinForms.ReportParameter("TuNgay", dto_baocaocongno.TuNgay);
            Parameters.Add(param);
            param = new Microsoft.Reporting.WinForms.ReportParameter("DenNgay", dto_baocaocongno.DenNgay);
            Parameters.Add(param);
            reportViewer1.LocalReport.SetParameters(Parameters);
            this.reportViewer1.RefreshReport();
        }
    }
}
