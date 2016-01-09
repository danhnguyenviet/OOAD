using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DAL
{
    public class DAL_PhieuNhapHang
    {
        public Connection helper = new Connection();

        public void InsertNhapHang(DTO_PhieuNhapHang pnhDTO)
        {
            helper.ThucHienCauLenhSQL("INSERT INTO PHIEUNHAP (MaPN, MaNV, MaNCC, ThoiGianLap) VALUES (N'" + pnhDTO.MaPN + "',N'" + pnhDTO.MaNV + "',N'" + pnhDTO.MaNCC + "',N'" + pnhDTO.ThoiGianLap + "')");
        }
        public void UpdateNhapHang(DTO_PhieuNhapHang pnhDTO)
        {
            helper.ThucHienCauLenhSQL("UPDATE PHIEUNHAP SET MaNV =N'" + pnhDTO.MaNV + "', MaNCC =N'" + pnhDTO.MaNCC + "', ThoiGianLap ='" + pnhDTO.ThoiGianLap + "' where MaPN = N'" + pnhDTO.MaPN + "'");
        }
        public void DeleteNhapHang(DTO_PhieuNhapHang pnhDTO)
        {
            helper.ThucHienCauLenhSQL("DELETE from PHIEUNHAP Where MaPN=N'" + pnhDTO.MaPN + "'");
        }
        public DataTable TaobangNhapHang(string dieukien)
        {
            return helper.GetDataTable("select * from PHIEUNHAP " + dieukien);
        }
    }
}
