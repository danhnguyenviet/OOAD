using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;
namespace DAL
{
    public class DAL_BaoCaoTonKho
    {
        Connection connect = new Connection();

        public DataTable LayDanhSachPhieuNhap(DTO_BaoCaoTonKho tonkho)
        {
            DataTable dt = new DataTable();
            connect.MoKetNoi();
            string sql = "select lh.MaMH,sum(lh.SLBan),sum(lh.SLNhap) from PhieuNhap as pn inner join ChiTietPhieuNhap as ctpn on pn.MaPN = ctpn.MaPN inner join LoHang as lh on ctpn.MaLH = lh.MaLH inner join MatHang as mh on mh.MaMH = lh.MaMH where pn.ThoiGianLap >= '"+tonkho.TuNgay+"' and pn.ThoiGianLap <= '"+tonkho.DenNgay+"' group by lh.MaMH";
            dt = connect.GetDataTable(sql);
            return dt;
        }


        public DataTable LaySoLuongBan(DTO_BaoCaoTonKho tonkho, string mamh)
        {
            DataTable dt = new DataTable();
            connect.MoKetNoi();
            string sql = "select mh.MaMH, COALESCE(sum(lh.SLBan),0) from LoHang as lh  right join MatHang as mh on mh.MaMH = lh.MaMH left join ChiTietHoaDon as ct on ct.MaLH = lh.MaLH left join HoaDon as hd on hd.MaHD = ct.MaHD where mh.MaMH = '" + mamh + "' and hd.ThoiGianLap >= '" + tonkho.TuNgay + "' and hd.ThoiGianLap <= '" + tonkho.DenNgay + "' group by mh.MaMH";
            dt = connect.GetDataTable(sql);
            if (dt.Rows.Count < 1)
            {
                DataRow dr = dt.NewRow();
                dr[0] = "";
                dr[1] = "0";
                dt.Rows.Add(dr);
            }
            return dt;
        }

        public DataTable LaySoLuongNhap(DTO_BaoCaoTonKho tonkho, string mamh)
        {
            DataTable dt = new DataTable();
            connect.MoKetNoi();
            string sql = "select mh.MaMH, COALESCE(sum(lh.SLNhap),0) from LoHang as lh  right join MatHang as mh on mh.MaMH = lh.MaMH left join ChiTietPhieuNhap as ct on ct.MaLH = lh.MaLH left join PhieuNhap as pn on pn.MaPN = ct.MaPN  where mh.MaMH = '" + mamh + "' and pn.ThoiGianLap >= '" + tonkho.TuNgay + "' and pn.ThoiGianLap <= '" + tonkho.DenNgay + "' group by mh.MaMH";
            dt = connect.GetDataTable(sql);
            if (dt.Rows.Count < 1)
            {
                DataRow dr = dt.NewRow();
                dr[0] = "";
                dr[1] = "0";
                dt.Rows.Add(dr);
            }
            return dt;
        }

        public DataTable LayDanhSachMatHang(DTO_BaoCaoTonKho tonkho)
        {
            DataTable dt = new DataTable();
            connect.MoKetNoi();
            string sql = "select mh.MaMH , mh.TenMH from MatHang as mh";
            dt = connect.GetDataTable(sql);
            return dt;
        }

        public DataTable LayGiaTriNhap(DTO_BaoCaoTonKho tonkho,string mamh)
        {
            DataTable dt = new DataTable();
            connect.MoKetNoi();
            string sql = "select mh.MaMH,lh.MaLH,lh.GiaNhap,lh.SLNhap from MatHang as mh left join LoHang as lh on lh.MaMH = mh.MaMH left join ChiTietPhieuNhap as ct on ct.MaLH = lh.MaLH left join PhieuNhap as pn on pn.MaPN = ct.MaPN where mh.MaMH = '" + mamh + "' and pn.ThoiGianLap >= '" + tonkho.TuNgay + "' and pn.ThoiGianLap <= '" + tonkho.DenNgay + "'";
            dt = connect.GetDataTable(sql);
            return dt;
        }

        public DataTable LayGiaTriBan(DTO_BaoCaoTonKho tonkho, string mamh)
        {
            DataTable dt = new DataTable();
            connect.MoKetNoi();
            string sql = "select mh.MaMH,lh.MaLH,lh.GiaBan,lh.SLBan from LoHang as lh  right join MatHang as mh on mh.MaMH = lh.MaMH left join ChiTietHoaDon as ct on ct.MaLH = lh.MaLH left join HoaDon as hd on hd.MaHD = ct.MaHD where mh.MaMH = '" + mamh + "' and hd.ThoiGianLap >= '" + tonkho.TuNgay + "' and hd.ThoiGianLap <= '" + tonkho.DenNgay + "'";
            dt = connect.GetDataTable(sql);
            return dt;
        }



    }
}
