using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    class DAL_KhachHang
    {
        static Connection connect;

        public DAL_KhachHang()
        {
            connect = new Connection();
        }
        public int GetSizeTable()
        {

            DataTable dt = connect.getDS("Select * from KhachHang");
            return dt.Rows.Count;

        }

        public void ThemKhachHang(string maKH, string hoTen, string diaChi, string sDT)
        {

        }

        public void XoaKhachHang(string maKH)
        {

        }

        public void SuaKhachHang(string maKH)
        { 
        }
    }
}
