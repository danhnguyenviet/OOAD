using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DAL
{
    class DAL_NhanVien
    {
        static Connection connect;

        public DAL_NhanVien()
        {
            connect = new Connection();
        }
        public int GetSizeTable()
        {
            DataTable dt = connect.getDS("Select * from NhanVien");
            return dt.Rows.Count;
        }

        public void ThemNhanVien(string maNV, string hoTen, DateTime ngaySinh, int gioiTinh, int cMDN, string diaChi, DateTime ngayVL, string tenDangNhap, string matKhau)
        {

        }

        public void XoaNhanVien(string maNV)
        {

        }

        public void SuaNhanVien(string maNV)
        {
        }
    }
}
