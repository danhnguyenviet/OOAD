﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Data;

namespace DAL
{
    public class DAL_NhanVien
    {
        public Connection helper = new Connection();

        public void ThemNhanVien(DTO_NhanVien nvDTO)
        {
            helper.ThucHienCauLenhSQL("INSERT INTO NhanVien (MaNV, TenNV, NgaySinh, GioiTinh, CMND, DiaChi, NgayVL, TenDangNhap, MatKhau) VALUES (N'" + nvDTO.MaNV + "',N'" + nvDTO.TenNV + "',N'" + nvDTO.NgaySinh + "',N'" + nvDTO.GioiTinh + "',N'" + nvDTO.CMND + "',N'" + nvDTO.DiaChi + "',N'" + nvDTO.NgayVL + "',N'" + nvDTO.TenDN + "',N'" + nvDTO.MatKhau + "')");
        }
        public void CapNhatNhanVien(DTO_NhanVien nvDTO)
        {
            helper.ThucHienCauLenhSQL("UPDATE NhanVien SET TenNV =N'" + nvDTO.TenNV + "', NgaySinh = N'" + nvDTO.NgaySinh + "', GioiTinh = N'" + nvDTO.GioiTinh + "', CMND = N'" + nvDTO.CMND + "', DiaChi = N'" + nvDTO.DiaChi + "', NgayVL = N'" + nvDTO.NgayVL + "', TenDangNhap = N'" + nvDTO.TenDN + "', MatKhau = N'" + nvDTO.MatKhau + "' where MaNV = N'" + nvDTO.MaNV + "'");
        }
        public void XoaNhanVien(DTO_NhanVien nvDTO)
        {
            helper.ThucHienCauLenhSQL("DELETE from NhanVien Where MaNV=N'" + nvDTO.MaNV + "'");
        }
        public DataTable TaobangNhanVien(string dieukien)
        {
            return helper.GetDataTable("select * from NhanVien " + dieukien);
        }
        public int LayKichThuocBang()
        {
            DataTable dt = helper.GetDataTable("Select * from NhanVien");
            return dt.Rows.Count;
        }

        public DataTable LayDsMaVaTenNv()
        {
            DataTable dt = helper.GetDataTable("Select MaNV, TenNV from NhanVien");
            return dt;
        }
    }
}
