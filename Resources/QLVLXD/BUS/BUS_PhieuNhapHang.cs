using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using DTO;
using System.Data;

namespace BUS
{
    public class BUS_PhieuNhapHang
    {
        private DAL_PhieuNhapHang mh = new DAL_PhieuNhapHang();
        public DataTable TaobangPhieuNhapHang(string dieukien)
        {
            return mh.TaobangNhapHang(dieukien);
        }
        public void ThemdulieuPhieuNhapHang(DTO_PhieuNhapHang et)
        {
            //truyền vào đối tượng thôi.
            mh.InsertNhapHang(et);
        }
        public void SuadulieuPhieuNhapHang(DTO_PhieuNhapHang et)
        {
            mh.UpdateNhapHang(et);
        }
        public void XoadulieuPhieuNhapHang(DTO_PhieuNhapHang et)
        {
            mh.DeleteNhapHang(et);
        }

        
    }
}
