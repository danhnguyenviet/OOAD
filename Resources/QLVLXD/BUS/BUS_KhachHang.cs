using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using DTO;
using System.Data;

namespace BUS
{
    public class BUS_KhachHang
    {
        private DAL_KhachHang kh = new DAL_KhachHang();
        public DataTable TaobangKhachHang(string dieukien)
        {
            return kh.TaobangKhachHang(dieukien);
        }
        public void ThemdulieuKhachHang(DTO_KhachHang et)
        {
            //truyền vào đối tượng thôi.
            kh.ThemKhachHang(et);
        }
        public void SuadulieuKhachHang(DTO_KhachHang et)
        {
            kh.CapNhatKhachHang(et);
        }
        public void XoadulieuKhachHang(DTO_KhachHang et)
        {
            kh.XoaKhachHang(et);
        }

        public string TuTinhMa()
        {
            int i = kh.LayKichThuocBang() + 1;
            string s;
            if (i < 10)
            {
                s = "KH00" + i.ToString();
            }
            else if (i >= 10 && i < 100)
            {
                s = "KH0" + i.ToString();
            }
            else
            {
                s = "KH" + i.ToString();
            }
            return s;
        }
    }
}
