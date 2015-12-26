using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;


namespace BUS
{
    public class BUS_Form1
    {
        DAL_Form1 f = new DAL_Form1();
        public int getSize()
        {
            return f.GetSizeTable();
        }
    }
}
