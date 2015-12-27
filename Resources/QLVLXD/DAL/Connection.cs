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
        //Mở kết nối
        public void MoKetNoi()
        {
            connect = new SqlConnection(global::DAL.Properties.Settings.Default.QL_VLXDConnectionString);
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
    }
}
