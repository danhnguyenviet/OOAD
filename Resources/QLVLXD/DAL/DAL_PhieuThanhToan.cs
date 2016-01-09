using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
    public class DAL_PhieuThanhToan
    {
        private Connection connection;

        public DAL_PhieuThanhToan()
        {
            connection = new Connection();
        }

        /**
         * Thêm mới một phiếu thanh toán
         * @DTO_PhieuThanhToan: phieuThanhToan
         */
        public bool ThemMoiPhieuThanhToan(DTO_PhieuThanhToan phieuThanhToan)
        {
            connection.ThucHienCauLenhSQL("INSERT INTO PhieuThanhToan (MaPhieuTT, SoTienNop, ThoiGianNop, MaHD, MaNV) " +
                "VALUES (N'" + phieuThanhToan.MaPhieuTt + "', " + phieuThanhToan.SoTienNop + ",N'" + phieuThanhToan.ThoiGianNop.ToShortDateString() +
                "', N'" + phieuThanhToan.MaHd + "', N'" + phieuThanhToan.MaNv + "')");
            return true;
        }

        /**
         * Sửa thông tin phiếu thanh toán
         * @DTO_PhieuThanhToan: phieuThanhToan
         */
        public bool SuaPhieuThanhToan(DTO_PhieuThanhToan phieuThanhToan)
        {
            connection.ThucHienCauLenhSQL("UPDATE PhieuThanhToan SET SoTienNop=" + phieuThanhToan.SoTienNop + ", ThoiGianNop=N'" +
                phieuThanhToan.ThoiGianNop + "', MaHD =N'" + phieuThanhToan.MaHd + "', MaNV=N'" + phieuThanhToan.MaNv + "'");
            return true;
        }

        /**
         * Xóa hóa phiếu thanh toán
         * @string: maPhieuTT
         */
        public bool XoaPhieuThanhToan(string maPhieuTT)
        {
            connection.ThucHienCauLenhSQL("DELETE FROM PhieuThanhToan WHERE MaPhieuTT=N'" + maPhieuTT + "'");
            return true;
        }

        /**
         * Lấy danh sách hóa đơn chưa thanh toán xong
         */
        public DataTable LayDshdChuaTtXong()
        {
            return connection.GetDataTable("SELECT HoaDon.MaHD, TongTien, A.SoTienNop FROM HoaDon INNER JOIN " +
                "(SELECT MaHD, SUM(SoTienNop) AS SoTienNop FROM PhieuThanhToan " +
                "GROUP BY MaHD) AS A " +
                "ON HoaDon.MaHD=A.MaHD " +
                "WHERE A.SoTienNop < HoaDon.TongTien");
        }

        /**
         * Lấy tất cả các phiếu thanh toán hiện có
         */
        public DataTable LayTatCaPtt()
        {
            return connection.GetDataTable("SELECT * FROM PhieuThanhToan");
        }
    }
}
