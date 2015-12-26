using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace DAL
{
    public class Connection
    {
        SqlConnection connect;
        SqlDataAdapter da;
        SqlCommand command;
        public Connection()
        {
            Connect();
        }

        public void Connect()
        {
            connect = new SqlConnection(global::DAL.Properties.Settings.Default.QL_VLXDConnectionString);
            try
            {
                connect.Open();
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ket Noi Khong Thanh Cong \n" + ex.Message, "Loi Ket Noi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        public DataTable getDS(string sql)
        {
            DataTable table = new DataTable();
            da = new SqlDataAdapter(sql, connect);
            da.Fill(table);
            return table;
        }

        public bool ExecuteNonQueryPara(string sql, string[] parameters, object[] value)
        {
            int number = 0;
            try
            {
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                }
                command = new SqlCommand(sql, connect);
                SqlParameter p;
                for (int i = 0; i < parameters.Length; i++)
                {
                    p = new SqlParameter(parameters[i], value[i]);
                    command.Parameters.Add(p);
                }
                number = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            if (number > 0)
                return true;
            else
                return false;
        }
    }
}
