using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Configuration;

namespace DAL
{
    public class Connection
    {
        public SqlConnection connect;
        //Mở kết nối
        public void MoKetNoi()
            //mầy làm tiếp đi
        {
            
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            connect = new SqlConnection(ConfigurationManager.ConnectionStrings["DAL.Properties.Settings.QL_VLXDConnectionString"].ConnectionString);
            try
            {
                connect.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ket Noi Khong Thanh Cong \n" + ex.Message, "Loi Ket Noi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }
        //Đóng kết nối
        public void DongKetNoi()
        {
            connect.Close();
        }
        //Thực hiện câu lệnh SQL thêm xóa sửa
        public void ThucHienCauLenhSQL(string strSQL)
        {
            MoKetNoi();
            SqlCommand sqlcmd = new SqlCommand(strSQL, connect);
            sqlcmd.ExecuteNonQuery();
            DongKetNoi();
        }

        //Thực hiện lấy dữ liệu từ database
        public DataTable GetDataTable(string strSQL)
        {
            MoKetNoi();
            DataTable dt = new DataTable();
            SqlDataAdapter sqlda = new SqlDataAdapter(strSQL, this.connect);
            sqlda.Fill(dt);
            DongKetNoi();
            return dt;
        }

        public string SearchDaTaGrid(string key, string table, string MaColumnName)
        {
            int Count = 0;
            string Ma = "";
            DataTable dt = new DataTable();//tao bang tam de luu
            dt = GetDataTable("Select " + MaColumnName + " From " + table);
            for (int i = 1; true; i++)
            {
                for (int j = 0; j < dt.Rows.Count; j++)
                {
                    if (dt.Rows[j][MaColumnName].ToString() != key + "" + i)
                    {
                        Count++;//dem so lan khac
                    }
                    else
                    {
                        Count = 0;
                        break;
                    }
                }
                if (Count == dt.Rows.Count)// new so lan khac bang so hang cua bang, nghia la khong co dong nao trung thi tu dong add
                {
                    Ma = key + "" + i;
                    break;
                }
            }
            return Ma;
        }
    }
}
