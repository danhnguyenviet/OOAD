using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DTO;

namespace DAL
{
    public class DAL_KhachHang
    {
        public Connection helper = new Connection();

        public void InsertKhachHang(DTO_KhachHang khDTO)
        {
            helper.ThucHienCauLenhSQL("INSERT INTO KHACHHANG (MaKH, HoTen, DiaChi, NgayCapThe) VALUES (N'" + khDTO.MaKH + "',N'" + khDTO.HoTen + "',N'" + khDTO.DiaChi + "',N'" + khDTO.NgayCapThe  + "')");
        }
        public void UpdateKhachHang(DTO_KhachHang khDTO)
        {
            helper.ThucHienCauLenhSQL("UPDATE KHACHHANG SET HoTen =N'" + khDTO.HoTen + "', DiaChi =N'" + khDTO.DiaChi + "', NgayCapThe =N'" + khDTO.NgayCapThe  + "' where MaKH = N'" + khDTO.MaKH + "'");
        }
        public void DeleteKhachHang(DTO_KhachHang khDTO)
        {
            helper.ThucHienCauLenhSQL("DELETE from KHACHHANG Where MaKH=N'" + khDTO.MaKH + "'");
        }
        public DataTable TaobangKhachHang(string dieukien)
        {
            return helper.GetDataTable("select * from KHACHHANG " + dieukien);
        }

        /**
         * Lấy mã khách hàng và họ tên
         */
        public DataTable LayMaVaTenKhachHang()
        {
            return helper.GetDataTable("SELECT MaKH, HoTen FROM KhachHang");
        }
    }
}
