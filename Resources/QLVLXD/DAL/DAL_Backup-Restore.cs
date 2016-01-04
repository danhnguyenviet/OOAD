using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAL
{
    public class DAL_Backup_Restore
    {
        string sql;
        SqlCommand cmd;
        SqlDataReader reader;
        Connection connection = new Connection();

        public SqlDataReader LayDanhSachCSDL()
        {
            connection.MoKetNoi();
            //sql = "EXEC sp_databases";
            sql = "Select * From sys.databases d where d.database_id>4";
            cmd = new SqlCommand(sql, connection.connect);
            reader = cmd.ExecuteReader();
            return reader;
        }

        public bool SaoLuuCoSoDuLieu(DTO_Backup_Restore bare)
        {
            try
            {
                if (bare.ThuMucBackup.Equals(""))
                    return false;
                connection.MoKetNoi();
                sql = "BACKUP DATABASE " + bare.TenCoSoDuLieu + " TO DISK = '" + bare.ThuMucBackup + "\\" + bare.TenCoSoDuLieu + "-" + DateTime.Now.Day+"-"+DateTime.Now.Month+"-"+DateTime.Now.Year+".bak'";
                //sql = "BACKUP DATABASE " + bare.TenCoSoDuLieu + " TO DISK = 'D:\\backup\\data.bak'";
                cmd = new SqlCommand(sql, connection.connect);
                cmd.ExecuteNonQuery();
                //connection.DongKetNoi();
                return true;
            }

            catch (Exception e) { Console.WriteLine(e.Message); return false; }
        }

        public bool PhucHoiCoSoDuLieu(DTO_Backup_Restore bare)
        {
            try
            {
                if (bare.FileRestore.Equals(""))
                    return false;
                connection.MoKetNoi();
                sql = "USE master;";
                sql += " ALTER DATABASE "+bare.TenCoSoDuLieu+" SET SINGLE_USER WITH ROLLBACK IMMEDIATE;";
                sql += " RESTORE DATABASE " + bare.TenCoSoDuLieu + " FROM DISK = '"+bare.FileRestore+"' WITH REPLACE;";
                sql += " ALTER DATABASE " + bare.TenCoSoDuLieu + " SET MULTI_USER;";
                cmd = new SqlCommand(sql, connection.connect);
                cmd.ExecuteNonQuery();
                //connection.DongKetNoi();
                return true;
            }

            catch (Exception e) { Console.WriteLine(e.Message); return false; }
        }
    }
}
