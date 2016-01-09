using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{

    public class DAL_CTPhieuNhap
    {
        public Connection helper = new Connection();

        public void InsertCTPhieuNhap(DTO_CTPhieuNhap nhDTO)
        {
            helper.ThucHienCauLenhSQL("INSERT INTO ChiTietPhieuNhap (MaPN, MaLH) VALUES (N'" + nhDTO.MaPN + "',N'" + nhDTO.MaLH + "')");
        }
        public void DeleteCTPhieuNhap(string nhDTO)
        {
            helper.ThucHienCauLenhSQL("DELETE from ChiTietPhieuNhap Where MaPN = N'" + nhDTO +"'");
        }
        public DataTable TaobangCTPhieuNhap(string dieukien)
        {
            return helper.GetDataTable("select * from ChiTietPhieuNhap " + dieukien);
        }
    }
}
