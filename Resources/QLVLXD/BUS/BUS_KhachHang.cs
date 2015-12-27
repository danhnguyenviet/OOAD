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
            kh.InsertKhachHang(et);
        }
        public void SuadulieuKhachHang(DTO_KhachHang et)
        {
            kh.UpdateKhachHang(et);
        }
        public void XoadulieuKhachHang(DTO_KhachHang et)
        {
            kh.DeleteKhachHang(et);
        }
    }
}
