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
        public DataTable LayCtHdBanHang(string maHd)
        {
            return connection.GetDataTable("SELECT * FROM ChiTietHoaDon WHERE MaHD='" + maHd + "'");
        }
    }
}
