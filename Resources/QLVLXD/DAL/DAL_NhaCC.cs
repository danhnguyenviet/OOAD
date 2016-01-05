using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DTO;

namespace DAL
{
    public class DAL_NhaCC
    {
        public Connection helper = new Connection();

        public void InsertNhaCC(DTO_NhaCC NccDTO)
        {
            helper.ThucHienCauLenhSQL("INSERT INTO NhaCC (MaNCC, TenNCC, DiaChi, SDT) VALUES (N'" + NccDTO.MaNCC + "',N'" + NccDTO.TenNCC + "',N'" + NccDTO.DiaChi + "',N'" + NccDTO.SDT  + "')");
        }
        public void UpdateNhaCC(DTO_NhaCC NccDTO)
        {
            helper.ThucHienCauLenhSQL("UPDATE NhaCC SET TenNCC =N'" + NccDTO.TenNCC + "', DiaChi =N'" + NccDTO.DiaChi + "', SDT =N'" + NccDTO.SDT  + "' where MaNCC = N'" + NccDTO.MaNCC + "'");
        }
        public void DeleteNhaCC(DTO_NhaCC NccDTO)
        {
            helper.ThucHienCauLenhSQL("DELETE from NhaCC Where MaNCC = N'" + NccDTO.MaNCC + "'");
        }
        public DataTable TaobangNhaCC(string dieukien)
        {
            return helper.GetDataTable("select * from NhaCC " + dieukien);
        }
    }
}
