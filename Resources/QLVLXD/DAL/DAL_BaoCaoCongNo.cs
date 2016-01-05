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
    public class DAL_BaoCaoCongNo
    {
        Connection connect = new Connection();

        public DataTable LayDanhSachKhachHang(DTO_BaoCaoCongNo congno)
        {
            DataTable dt = new DataTable();
            connect.MoKetNoi();
            string sql = "select MaKH, HoTen from KhachHang";
            dt = connect.GetDataTable(sql);
            return dt;
        }

        public DataTable LayDanhSachKetQua(DTO_BaoCaoCongNo congno,string makh)
        {
            DataTable dt = new DataTable();
            connect.MoKetNoi();
            string sql = "select kh.Makh, COALESCE(sum(hd.tongtien),0), COALESCE(sum(tt.SoTienNop),0) from  KhachHang as kh left join HoaDon as hd on kh.MaKH = hd.MaKH left join PhieuThanhToan as tt on hd.MaHD = tt.MaHD left join NhanVien as nv on hd.MaNV = nv.MaNV where hd.ThoiGianLap >= '"+congno.TuNgay+"' and hd.ThoiGianLap <= '"+congno.DenNgay+"' and tt.ThoiGianNop >= '"+congno.TuNgay+"' and tt.ThoiGianNop <= '"+congno.DenNgay+"' group by kh.MaKH";
            dt = connect.GetDataTable(sql);
            return dt;
        }



    }
}
