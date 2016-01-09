using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
    public class DAL_CTHoaDon
    {
        private Connection connection;

        public DAL_CTHoaDon()
        {
            connection = new Connection();
        }

        /**
         * Thêm mới chi tiết hóa đơn bán hàng
         * @DTO_CTHoaDon: ctHoaDon
         */
        public bool ThemCTHoaDon(DTO_CTHoaDon ctHoaDon)
        {
            connection.ThucHienCauLenhSQL("INSERT INTO ChiTietHoaDon (MaHD, MaLH, SLBan) " +
                "VALUES (N'" + ctHoaDon.MaHd + "',N'" + ctHoaDon.MaLh + "', " + ctHoaDon.SlBan + ")");
            return true;
        }

        /**
         * Lấy thông tin chi tiết hóa đơn bán hàng theo mã hóa đơn
         * @string: dieuKien
         */
        public DataTable LayCtHdbhTheoMaHd(string maHd)
        {
            return connection.GetDataTable("SELECT * FROM ChiTietHoaDon WHERE MaHD='" + maHd + "'");
        }

        /**
         * Lấy tên mặt hàng theo mã lô hàng
         */
        public string LayTenMatHangTheoMaLh(string maLh)
        {
            DataTable dt = connection.GetDataTable("SELECT TenMH FROM MatHang WHERE MaMH IN (SELECT MaLH FROM LoHang WHERE MaLH='" + maLh + "')");
            return dt.Rows[0]["TenMH"].ToString();
        }

        /**
         * Lấy giá bán theo mã lô hàng
         */
        public string LayGiaBanTheoMaLh(string maLh)
        {
            DataTable dt = connection.GetDataTable("SELECT GiaBan FROM LoHang WHERE MaLH='" + maLh + "'");
            return dt.Rows[0]["GiaBan"].ToString();
        }
    }
}
