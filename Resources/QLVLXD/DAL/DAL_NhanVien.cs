using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DAL
{
    public class DAL_NhanVien
    {
        private Connection connection;

        public DAL_NhanVien()
        {
            connection = new Connection();
        }

        /**
         * Lấy mã nhân viên và họ tên
         */
        public DataTable LayMaVaTenNhanVien()
        {
            return connection.GetDataTable("SELECT MaNV, TenNV FROM NhanVien");
        }
    }
}
