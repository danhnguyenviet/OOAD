using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_CTPhieuNhap
    {
        public Connection helper = new Connection();

        public void InsertCTNhapHang(DTO_CTPhieuNhap ctPN_DTO)
        {
            helper.ThucHienCauLenhSQL("INSERT INTO CHITIETPHIEUNHAP (MaPN, MaLH) VALUES (N'" + ctPN_DTO.MaPN + "',N'" + ctPN_DTO.MaLH + "')");
        }
        public void UpdateCTNhapHang(DTO_CTPhieuNhap ctPN_DTO)
        {
            helper.ThucHienCauLenhSQL("UPDATE CHITIETPHIEUNHAP SET MaLH =N'" + ctPN_DTO.MaLH + "' where MaPN = N'" + ctPN_DTO.MaPN + "'");
        }
        public void DeleteCTNhapHang(DTO_CTPhieuNhap ctPN_DTO)
        {
            helper.ThucHienCauLenhSQL("DELETE from CHITIETPHIEUNHAP Where MaPN=N'" + ctPN_DTO.MaPN + "'");
        }
        public DataTable TaobangCTNhapHang(string dieukien)
        {
            return helper.GetDataTable("select * from CHITIETPHIEUNHAP " + dieukien);
        }
    }
}
