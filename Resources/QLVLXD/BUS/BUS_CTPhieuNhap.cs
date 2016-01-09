using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_CTPhieuNhap
    {
        private DAL_CTPhieuNhap mh = new DAL_CTPhieuNhap();
        public DataTable TaobangCTPhieuNhapHang(string dieukien)
        {
            return mh.TaobangCTPhieuNhap(dieukien);
        }
        public void ThemdulieuCTPhieuNhapHang(DTO_CTPhieuNhap et)
        {
            //truyền vào đối tượng thôi.
            mh.InsertCTPhieuNhap(et);
        }
        public void XoadulieuCTPhieuNhapHang(string et)
        {
            mh.DeleteCTPhieuNhap(et);
        }

    }
}
