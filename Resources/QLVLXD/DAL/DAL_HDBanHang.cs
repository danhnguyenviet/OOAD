using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DTO;

namespace DAL
{
    public class DAL_HDBanHang
    {
        private Connection connection;

        public DAL_HDBanHang()
        {
            connection = new Connection();
        }

        /**
         * Thêm mới một hóa đơn bán hàng
         * @DTO_HDBanHang: hdBanHang
         */
        public bool ThemMoiHdBanHang(DTO_HDBanHang hdBanHang)
        {
            connection.ThucHienCauLenhSQL("INSERT INTO HoaDon (MaHD, MaNV, MaKH, ThoiGianLap, TongTien) " +
                "VALUES (N'" + hdBanHang.MaHd + "',N'" + hdBanHang.MaNv + "',N'" + hdBanHang.MaKh +
                "',N'" + hdBanHang.ThoiGianLap.ToShortDateString() + "'," + hdBanHang.TongTien + ")");
            return true;
        }

        /**
         * Sửa thông tin hóa đơn bán hàng
         * @DTO_HDBanHang: hdBanHang
         */
        public bool SuaHdBanHang(DTO_HDBanHang hdBanHang)
        {
            connection.ThucHienCauLenhSQL("UPDATE HoaDon SET MaNV =N'" + hdBanHang.MaNv + "', MaKH =N'" +
                hdBanHang.MaKh + "', ThoiGianLap =N'" + hdBanHang.ThoiGianLap + "', TongTien=" + hdBanHang.TongTien + 
                " WHERE MaHD = N'" + hdBanHang.MaHd + "'");
            return true;
        }

        /**
         * Xóa hóa đơn bán hàng
         * @string: maHd
         */
        public bool XoaHdBanHang(string maHd)
        {
            connection.ThucHienCauLenhSQL("DELETE FROM HoaDon Where MaHD=N'" + maHd + "'");
            return true;
        }

        /**
         * Lấy thông tin hóa đơn bán hàng theo điều kiện
         * @string: dieuKien
         */
        public DataTable LayHdBanHang(string dieuKien)
        {
            return connection.GetDataTable("SELECT * FROM HoaDon " + dieuKien);
        }

        /**
         * Load tất cả các hóa đơn bán hàng
         */
        public DataTable LayTatCaHdbh()
        {
            return connection.GetDataTable("SELECT * FROM HoaDon");
        }


    }
}
