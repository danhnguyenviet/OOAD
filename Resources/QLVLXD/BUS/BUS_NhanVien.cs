using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_NhanVien
    {
        private DAL_NhanVien nv = new DAL_NhanVien();
        public DataTable TaobangNhanVien(string dieukien)
        {
            return nv.TaobangNhanVien(dieukien);
        }
        public void ThemdulieuNhanVien(DTO_NhanVien et)
        {
            //truyền vào đối tượng thôi.
            nv.ThemNhanVien(et);
        }
        public void SuadulieuNhanVien(DTO_NhanVien et)
        {
            nv.CapNhatNhanVien(et);
        }
        public void XoadulieuNhanVien(DTO_NhanVien et)
        {
            nv.XoaNhanVien(et);
        }

        public string TuTinhMa()
        {
            int i = nv.LayKichThuocBang() + 1;
            string s;
            if (i < 10)
            {
                s = "NV00" + i.ToString();
            }
            else if (i >= 10 && i < 100)
            {
                s = "NV0" + i.ToString();
            }
            else
            {
                s = "NV" + i.ToString();
            }
            return s;
        }
    }
}
