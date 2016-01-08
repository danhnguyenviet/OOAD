using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DAL_DonViTinh
    {
        public Connection helper = new Connection();

        public void InsertDonViTinh(DTO_DonViTinh DvtDTO)
        {
            helper.ThucHienCauLenhSQL("INSERT INTO DonViTinh (MaDVT, TenDVT) VALUES (N'" + DvtDTO.TenTS + "',N'"+DvtDTO.GiaTri+"')");
        }
        public void UpdateDonViTinh(DTO_DonViTinh DvtDTO)
        {
            helper.ThucHienCauLenhSQL("UPDATE DonViTinh SET TenDVT =N'" + DvtDTO.GiaTri + "' where MaDVT = N'" + DvtDTO.TenTS + "'");
        }
        public void DeleteDonViTinh(DTO_DonViTinh DvtDTO)
        {
            helper.ThucHienCauLenhSQL("DELETE from DonViTinh Where MaDVT=N'" + DvtDTO.TenTS + "'");
        }
        public DataTable TaobangDonViTinh(string dieukien)
        {
            return helper.GetDataTable("select * from DonViTinh " + dieukien);
        }
        public int LayKichThuocBang()
        {
            DataTable dt = helper.GetDataTable("Select * from DonViTinh");
            return dt.Rows.Count;
        }
    }
}
