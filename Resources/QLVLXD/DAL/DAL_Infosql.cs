using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
namespace DAL
{
    public class DAL_Infosql
    {
        public DAL_Infosql()
        {

        }

        public void KetNoiServer(string ChuoiKetNoiMoi)
        {
            SqlConnection sql = new SqlConnection(ChuoiKetNoiMoi);
            sql.Open();
            sql.Close();
        }

        public bool CapNhatDataSource(string ChuoiKetNoiMoi)
        {
           
            try
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.ConnectionStrings.ConnectionStrings["DAL.Properties.Settings.QL_VLXDConnectionString"].ConnectionString = ChuoiKetNoiMoi;
                //ConfigurationManager.ConnectionStrings["DAL.Properties.Settings.QL_VLXDConnectionString"].ConnectionString = ChuoiKetNoiMoi;
                
                config.Save();
                ConfigurationManager.RefreshSection("connectionStrings");
                return true;
            }
            catch (Exception e) { Console.WriteLine(e.Message); return false; }

        }
    
        
    }
}
