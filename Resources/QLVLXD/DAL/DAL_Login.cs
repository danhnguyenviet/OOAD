using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using DTO;

namespace DAL
{
    public class DAL_Login
    {
        
        Connection helper = new Connection();
        public DataTable LayThongTinUser(DTO_Login dangnhap)
        {
            return helper.GetDataTable("select TenDangNhap, MatKhau, Quyen from NhanVien where TenDangNhap = '"+dangnhap.TenDangNhap+"' and MatKhau = '"+dangnhap.MatKhau+"'");
        }

        public bool KetNoiServer()
        {
            try
            {
                SqlConnection sql = new SqlConnection(ConfigurationManager.ConnectionStrings["DAL.Properties.Settings.QL_VLXDConnectionString"].ConnectionString);
                 sql.Open();
                 sql.Close();
                 return true;
            }
            catch(Exception e){return false;}
        }
    }
}
