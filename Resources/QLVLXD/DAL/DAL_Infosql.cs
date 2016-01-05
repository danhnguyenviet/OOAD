using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
namespace DAL
{
    public class DAL_Infosql
    {

        string script = null;
        public DAL_Infosql()
        {

        }

        public void KetNoiServer(string ChuoiKetNoiMoi)
        {
            SqlConnection sql = new SqlConnection(ChuoiKetNoiMoi);
            sql.Open();
            sql.Close();
        }

        public void TaoCoSoDuLieuMoi(string path)
        {
            string chuoiketnoi = "Data source = "+path+" ; Initial catalog = master ; integrated security = true";
            SqlCommand smd;
            SqlConnection sql = new SqlConnection(chuoiketnoi);
            sql.Open();
            script = File.ReadAllText("../../script.sql");
            string[] ScriptSplitter = script.Split(new string[] { "GO" }, StringSplitOptions.None);

                foreach (string str in ScriptSplitter)
                {
                    using (smd = sql.CreateCommand())
                    {
                        smd.CommandText = str;
                        smd.ExecuteNonQuery();
                    }
                }
                sql.Close();
        }

        public bool CapNhatDataSource(string ChuoiKetNoiMoi)
        {
           
            try
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
                config.ConnectionStrings.ConnectionStrings["DAL.Properties.Settings.QL_VLXDConnectionString"].ConnectionString = ChuoiKetNoiMoi;
               
                config.Save(ConfigurationSaveMode.Full,true);
                ConfigurationManager.RefreshSection("connectionStrings");
                return true;
            }
            catch (Exception e) { Console.WriteLine(e.Message); return false; }

        }
    
        
    }
}
