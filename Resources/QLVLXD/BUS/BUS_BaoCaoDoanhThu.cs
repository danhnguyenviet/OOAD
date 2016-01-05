using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using DTO;
namespace BUS
{
    public class BUS_BaoCaoDoanhThu
    {
        DAL_BaoCaoDoanhThu dal_baocaodaonhthu = new DAL_BaoCaoDoanhThu();
        DTO_BaoCaoDoanhThu dto_baocaodoanhthu = new DTO_BaoCaoDoanhThu();

        public DataTable LayDanhSachNhapXuatHang(DTO_BaoCaoDoanhThu doanhthu)
        {
            return dal_baocaodaonhthu.LayDanhSachPhieuNhap(doanhthu);
        }

        public DataTable LayDanhSachMatHang(DTO_BaoCaoDoanhThu doanhthu)
        {
            return dal_baocaodaonhthu.LayDanhSachMatHang(doanhthu);
        }

        public DataTable LaySLBan(DTO_BaoCaoDoanhThu doanhthu,string mamh)
        {
            return dal_baocaodaonhthu.LaySoLuongBan(doanhthu, mamh);
        }

        public DataTable LaySLNhap(DTO_BaoCaoDoanhThu doanhthu, string mamh)
        {
            return dal_baocaodaonhthu.LaySoLuongNhap(doanhthu, mamh);
        }

        public DataTable LayGiaTriNhap(DTO_BaoCaoDoanhThu doanhthu,string mamh)
        {
            return dal_baocaodaonhthu.LayGiaTriNhap(doanhthu,mamh);
        }

        public DataTable LayGiaTriBan(DTO_BaoCaoDoanhThu doanhthu, string mamh)
        {
            return dal_baocaodaonhthu.LayGiaTriBan(doanhthu, mamh);
        }

        public double TongGiaTriNhap(DTO_BaoCaoDoanhThu doanhthu, string mamh)
        {
            double tonggiatrinhap = 0;
            DataTable dt = new DataTable();
            dt = LayGiaTriNhap(doanhthu, mamh);
            if (dt.Rows.Count < 1)
                return 0;
            for (int i = 0; i < dt.Rows.Count;i++ )
            {
                
                string GiaNhap = (!dt.Rows[i]["GiaNhap"].ToString().Equals("")) ? dt.Rows[i]["GiaNhap"].ToString() : "0";
                string SLNhap = (!dt.Rows[i]["SLNhap"].ToString().Equals("")) ? dt.Rows[i]["SLNhap"].ToString() : "0";                
                tonggiatrinhap += (Double.Parse(GiaNhap) * Double.Parse(SLNhap));
            }
                return tonggiatrinhap;
        }

        public double TongGiaTriBan(DTO_BaoCaoDoanhThu doanhthu, string mamh)
        {
            double tonggiatriban = 0;
            DataTable dt = new DataTable();
            dt = LayGiaTriBan(doanhthu, mamh);
            if (dt.Rows.Count < 1)
                return 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                string GiaBan = (!dt.Rows[i]["GiaBan"].ToString().Equals("")) ? dt.Rows[i]["GiaBan"].ToString() : "0";
                string SLBan = (!dt.Rows[i]["SLBan"].ToString().Equals("")) ? dt.Rows[i]["SLBan"].ToString() : "0";
                tonggiatriban += (Double.Parse(GiaBan) * Double.Parse(SLBan));
            }
            return tonggiatriban;
        }

       /* public DataTable TaoDanhSachBaoCaoDoanhThu(DTO_BaoCaoDoanhThu doanhthu)
        {
            double TongNhap = 0;
            double TongXuat = 0;
            double TongDoanhThu = 0;
            
            DataTable ds = new DataTable();
            ds = LayDanhSachMatHang(dto_baocaodoanhthu);
            ds.Columns.Add("SLBan");
            ds.Columns.Add("SLNhap");
            ds.Columns.Add("GiaTriBan");
            ds.Columns.Add("GiaTriNhap");
            ds.Columns.Add("DoanhThu");
            ds.Columns.Add("TiLe");

            for (int i = 0; i < ds.Rows.Count; i++)
            {
                ds.Rows[i]["SLBan"] = LaySLBan(dto_baocaodoanhthu, ds.Rows[i]["MaMH"].ToString()).Rows[0][1].ToString();
                ds.Rows[i]["SLNhap"] = LaySLNhap(dto_baocaodoanhthu, ds.Rows[i]["MaMH"].ToString()).Rows[0][1].ToString();
                double GiaTriBan = TongGiaTriBan(dto_baocaodoanhthu, ds.Rows[i]["MaMH"].ToString());
                ds.Rows[i]["GiaTriBan"] = GiaTriBan;
                double GiaTriNhap = TongGiaTriNhap(dto_baocaodoanhthu, ds.Rows[i]["MaMH"].ToString());
                ds.Rows[i]["GiaTriNhap"] = GiaTriNhap;
                double DoanhThu = GiaTriNhap - GiaTriBan;
                ds.Rows[i]["DoanhThu"] = DoanhThu;
                TongNhap += GiaTriNhap;
                TongXuat += GiaTriBan;
                TongDoanhThu += DoanhThu;
            }
            for (int i = 0; i < ds.Rows.Count; i++)
            {
                ds.Rows[i]["TiLe"] = (Double.Parse(ds.Rows[i]["DoanhThu"].ToString()) * 100 / TongDoanhThu); 
            }
            ds.Columns.Remove("MaMH");
            return ds;
        }*/
    }
}
