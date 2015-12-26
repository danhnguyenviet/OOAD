using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DAL
{
    public class DAL_Form1
    {
        static Connection connect;
        
        public DAL_Form1()
        {
            connect = new Connection();
        }
        public int GetSizeTable()
        {

            DataTable dt = connect.getDS("Select * from DonViTinh");
            return dt.Rows.Count;
    
        }
    }
}
