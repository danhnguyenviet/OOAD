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
    public class BUS_BaoCaoTonKho
    {
        DAL_BaoCaoTonKho dal_baocaotonkho = new DAL_BaoCaoTonKho();
        DTO_BaoCaoTonKho dto_baocaotonkho = new DTO_BaoCaoTonKho();

        public DataTable LayDanhSachNhapXuatHang(DTO_BaoCaoTonKho tonkho)
        {
            return dal_baocaotonkho.LayDanhSachPhieuNhap(tonkho);
        }

        public DataTable LayDanhSachMatHang(DTO_BaoCaoTonKho tonkho)
        {
            return dal_baocaotonkho.LayDanhSachMatHang(tonkho);
        }

        public DataTable LaySLBan(DTO_BaoCaoTonKho tonkho,string mamh)
        {
            return dal_baocaotonkho.LaySoLuongBan(tonkho, mamh);
        }

        public DataTable LaySLNhap(DTO_BaoCaoTonKho tonkho, string mamh)
        {
            return dal_baocaotonkho.LaySoLuongNhap(tonkho, mamh);
        }

        public DataTable LayGiaTriNhap(DTO_BaoCaoTonKho tonkho,string mamh)
        {
            return dal_baocaotonkho.LayGiaTriNhap(tonkho,mamh);
        }

        public DataTable LayGiaTriBan(DTO_BaoCaoTonKho tonkho, string mamh)
        {
            return dal_baocaotonkho.LayGiaTriBan(tonkho, mamh);
        }

       /* public double TongGiaTriNhap(DTO_BaoCaoTonKho tonkho, string mamh)
        {
            double tonggiatrinhap = 0;
            DataTable dt = new DataTable();
            dt = LayGiaTriNhap(tonkho, mamh);
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

        public double TongGiaTriBan(DTO_BaoCaoTonKho tonkho, string mamh)
        {
            double tonggiatriban = 0;
            DataTable dt = new DataTable();
            dt = LayGiaTriBan(tonkho, mamh);
            if (dt.Rows.Count < 1)
                return 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                string GiaBan = (!dt.Rows[i]["GiaBan"].ToString().Equals("")) ? dt.Rows[i]["GiaBan"].ToString() : "0";
                string SLBan = (!dt.Rows[i]["SLBan"].ToString().Equals("")) ? dt.Rows[i]["SLBan"].ToString() : "0";
                tonggiatriban += (Double.Parse(GiaBan) * Double.Parse(SLBan));
            }
            return tonggiatriban;
        }*/
    }
}
