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

        public void ThemKhachHang(DTO_KhachHang khDTO)
        {
            helper.ThucHienCauLenhSQL("INSERT INTO KHACHHANG (MaKH, HoTen, DiaChi, Sdt) VALUES (N'" + khDTO.MaKH + "',N'" + khDTO.HoTen + "',N'" + khDTO.DiaChi + "',N'" + khDTO.SoDienThoai + "')");
        }
        public void CapNhatKhachHang(DTO_KhachHang khDTO)
        {
            helper.ThucHienCauLenhSQL("UPDATE KHACHHANG SET HoTen =N'" + khDTO.HoTen + "', DiaChi = N'" + khDTO.DiaChi + "', Sdt = N'" + khDTO.SoDienThoai + "' where MaKH = N'" + khDTO.MaKH + "'");
        }
        public void XoaKhachHang(DTO_KhachHang khDTO)
        {
            helper.ThucHienCauLenhSQL("DELETE from KHACHHANG Where MaKH=N'" + khDTO.MaKH + "'");
        }
        public DataTable TaobangKhachHang(string dieukien)
        {
            return helper.GetDataTable("select * from KHACHHANG " + dieukien);
        }
        public int LayKichThuocBang()
        {
            DataTable dt = helper.GetDataTable("Select * from KhachHang");
            return dt.Rows.Count;
        }

        public DataTable LayMaVaTenKhachHang()
        {
            DataTable dt = helper.GetDataTable("Select MaKH, HoTen from KhachHang");
            return dt; 
        }
    }
}
