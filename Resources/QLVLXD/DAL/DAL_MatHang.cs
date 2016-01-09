using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DTO;

namespace DAL
{
    public class DAL_MatHang
    {
        public Connection helper = new Connection();

        public void InsertMatHang(DTO_MatHang mhDTO)
        {
            helper.ThucHienCauLenhSQL("INSERT INTO MatHang (MaMH, TenMH,TenNSX,MaDVT,ThueVAT) VALUES (N'" + mhDTO.MaMH + "',N'" + mhDTO.TenMH + "',N'" + mhDTO.TenNSX + "',N'" + mhDTO.MaDVT + "',N'" + mhDTO.ThueVAT + "')");
        }
        public void UpdateMatHang(DTO_MatHang mhDTO)
        {
            helper.ThucHienCauLenhSQL("UPDATE MatHang SET TenMH =N'" + mhDTO.TenMH + "', TenNSX =N'" + mhDTO.TenNSX + "', MaDVT =N'" + mhDTO.MaDVT + "', ThueVAT =N'" + mhDTO.ThueVAT + "' where MaMH = N'" + mhDTO.MaMH + "'");
        }
        public void DeleteMatHang(DTO_MatHang mhDTO)
        {
            helper.ThucHienCauLenhSQL("DELETE from MatHang Where MaMH = N'" + mhDTO.MaMH + "'");
        }
        public DataTable TaobangMatHang(string dieukien)
        {
            return helper.GetDataTable("select * from MatHang " + dieukien);
        }
    }
}
