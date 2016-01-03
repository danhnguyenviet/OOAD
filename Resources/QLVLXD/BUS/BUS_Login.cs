using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;
namespace BUS
{
    public class BUS_Login
    {
        DAL_Login dal_dangnhap = new DAL_Login();
        public Boolean KiemTraThongTinDangNhap(DTO_Login dto_dangnhap)
        {
            DataTable dt = dal_dangnhap.LayThongTinUser(dto_dangnhap);
            if (dt.Rows.Count == 1)
                return true;
            return false;
        }

        public DataTable LayDanhSachTheoID(DTO_Login dto_dangnhap)
        {
            return dal_dangnhap.LayThongTinUser(dto_dangnhap);
        }

        public bool KetNoiServer()
        {
            return dal_dangnhap.KetNoiServer();
        }
    }
}
