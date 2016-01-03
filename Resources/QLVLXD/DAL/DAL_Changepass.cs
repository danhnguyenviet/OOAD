using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAL
{
    public class DAL_Changepass
    {
        Connection helper = new Connection();
        public DataTable LayThongTinUser(DTO_Login dangnhap)
        {
            return helper.GetDataTable("select TenDangNhap, MatKhau, Quyen from NhanVien where TenDangNhap = '" + dangnhap.TenDangNhap + "' and MatKhau = '" + dangnhap.MatKhau + "'");
        }

        public DataTable LayMatKhauTheoID(string TenDangNhap)
        {
            return helper.GetDataTable("select MatKhau from NhanVien where TenDangNhap = '" + TenDangNhap + "'");
        }

        public void SuaMatKhau(string MatKhau)
        {
            helper.ThucHienCauLenhSQL("update NhanVien set MatKhau = '" + MatKhau + "'");
        }
    }
}
