using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class BUS_Changepass
    {
        static string MatKhau;
        DAL_Changepass thaydoimatkhau = new DAL_Changepass();

        public Boolean KiemtraMatKhau(string TenDangNhap)
        {
            DataTable dt = thaydoimatkhau.LayMatKhauTheoID(TenDangNhap);
            if (dt.Rows.Count == 1)
            {
                MatKhau = dt.Rows[0]["MatKhau"].ToString();
                return true;
            }
            return false;
        }

        public Boolean KiemTraMatKhauXacNhan(string MatKhauMoi,string MatKhauXN)
        {
            if (MatKhauMoi.Equals(MatKhauXN))
            {
                thaydoimatkhau.SuaMatKhau(MatKhauXN);
                return true;
            }
            return false;
        }
    }
}
