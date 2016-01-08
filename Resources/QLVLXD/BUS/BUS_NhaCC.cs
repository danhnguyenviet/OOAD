using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using DTO;
using System.Data;

namespace BUS
{
    public class BUS_NhaCC
    {
        private DAL_NhaCC ncc = new DAL_NhaCC();
        public DataTable TaobangNhaCC(string dieukien)
        {
            return ncc.TaobangNhaCC(dieukien);
        }
        public void ThemdulieuNhaCC(DTO_NhaCC et)
        {
            //truyền vào đối tượng thôi.
            ncc.InsertNhaCC(et);
        }
        public void SuadulieuNhaCC(DTO_NhaCC et)
        {
            ncc.UpdateNhaCC(et);
        }
        public void XoadulieuNhaCC(DTO_NhaCC et)
        {
            ncc.DeleteNhaCC(et);
        }
        public string TuTinhMa()
        {
            int i = ncc.LayKichThuocBang() + 1;
            string s;
            if (i < 10)
            {
                s = "NCC00" + i.ToString();
            }
            else if (i >= 10 && i < 100)
            {
                s = "NCC0" + i.ToString();
            }
            else
            {
                s = "KH" + i.ToString();
            }
            return s;
        }
    }
}
