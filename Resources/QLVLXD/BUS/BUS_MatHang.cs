using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using DTO;
using System.Data;
namespace BUS
{
    class BUS_MatHang
    {
        private DAL_MatHang mh = new DAL_MatHang();
        public DataTable TaobangMatHang(string dieukien)
        {
            return mh.TaobangMatHang(dieukien);
        }
        public void ThemdulieuMatHang(DTO_MatHang et)
        {
            //truyền vào đối tượng thôi.
            mh.InsertMatHang(et);
        }
        public void SuadulieuMatHang(DTO_MatHang et)
        {
            mh.UpdateMatHang(et);
        }
        public void XoadulieuMatHang(DTO_MatHang et)
        {
            mh.DeleteMatHang(et);
        }
    }
}
