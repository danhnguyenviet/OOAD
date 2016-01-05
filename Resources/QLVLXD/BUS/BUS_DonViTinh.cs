using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUS
{
    class BUS_DonViTinh
    {
        private DAL_DonViTinh dvt = new DAL_DonViTinh();
        public DataTable TaobangDonViTinh(string dieukien)
        {
            return dvt.TaobangDonViTinh(dieukien);
        }
        public void ThemdulieuDonViTinh(DTO_DonViTinh et)
        {
            //truyền vào đối tượng thôi.
            dvt.InsertDonViTinh(et);
        }
        public void SuadulieuDonViTinh(DTO_DonViTinh et)
        {
            dvt.UpdateDonViTinh(et);
        }
        public void XoadulieuDonViTinh(DTO_DonViTinh et)
        {
            dvt.DeleteDonViTinh(et);
        }
    }
}
