using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using DTO;
namespace BUS
{
    public class BUS_BaoCaoCongNo
    {
        DAL_BaoCaoCongNo dal_baocaocongno = new DAL_BaoCaoCongNo();
        DTO_BaoCaoCongNo dto_baocaocongno = new DTO_BaoCaoCongNo();

        
        public DataTable LayDanhSachKhachHang(DTO_BaoCaoCongNo congno)
        {
            return dal_baocaocongno.LayDanhSachKhachHang(congno);
        }
        public DataTable LayDanhSachKetQua(DTO_BaoCaoCongNo congno)
        {
            return dal_baocaocongno.LayDanhSachKetQua(congno, "");
        }

        public List<DTO_BaoCaoCongNo> TaoDanhSachCongNo(DTO_BaoCaoCongNo congno)
        {
            List<DTO_BaoCaoCongNo> DSCongNo = new List<DTO_BaoCaoCongNo>();
            DataTable dt = new DataTable();
            double TongNo = 0;
            dt = dal_baocaocongno.LayDanhSachKetQua(congno, "");
            if (dt.Rows.Count < 1)
                return null;
            for (int i = 0; i < dt.Rows.Count;i++ )
            {
                DTO_BaoCaoCongNo baocao = new DTO_BaoCaoCongNo();
                baocao.MaKH = dt.Rows[i]["MaKH"].ToString();
                double TGD = (!dt.Rows[i][1].ToString().Equals("")) ? Double.Parse(dt.Rows[i][1].ToString()):0;
                baocao.TongGiaoDich = TGD;
                double DTra = (!dt.Rows[i][2].ToString().Equals("")) ? Double.Parse(dt.Rows[i][2].ToString()):0;
                baocao.DaTra = DTra;
                baocao.TongNo = TGD - DTra;
                DSCongNo.Add(baocao);
                TongNo += baocao.TongNo;
            }

            

            for(int i = 0;i < DSCongNo.Count;i++)
            {
                DSCongNo[i].Tile = (DSCongNo[i].TongNo * 100) / TongNo;
            }

            return SapXepDanhSachKH(DSCongNo);
        }

        public List<DTO_BaoCaoCongNo> SapXepDanhSachKH(List<DTO_BaoCaoCongNo> DSCongNo)
        {
            int index = 0;
            DTO_BaoCaoCongNo temp = new DTO_BaoCaoCongNo();

            for (int i = 0; i < DSCongNo.Count && i < 10; i++ )
            {
                index = i;
                temp = DSCongNo[i];
                for(int j = i+1 ; j < DSCongNo.Count ; j++)
                {
                    if (temp.Tile < DSCongNo[j].Tile)
                        index = j;
                }

                temp = DSCongNo[i];
                DSCongNo[i]= DSCongNo[index];
                DSCongNo[index] = temp;

            }

                return DSCongNo;
        }

       /* public double TongGiaTriNhap(DTO_BaoCaoCongNo congno, string mamh)
        {
            double tonggiatrinhap = 0;
            DataTable dt = new DataTable();
            dt = LayGiaTriNhap(congno, mamh);
            if (dt.Rows.Count < 1)
                return 0;
            for (int i = 0; i < dt.Rows.Count;i++ )
            {
                
                string GiaNhap = (!dt.Rows[i]["GiaNhap"].ToString().Equals("")) ? dt.Rows[i]["GiaNhap"].ToString() : "0";
                string SLNhap = (!dt.Rows[i]["SLNhap"].ToString().Equals("")) ? dt.Rows[i]["SLNhap"].ToString() : "0";                
                tonggiatrinhap += (Double.Parse(GiaNhap) * Double.Parse(SLNhap));
            }
                return tonggiatrinhap;
        }

        public double TongGiaTriBan(DTO_BaoCaoCongNo congno, string mamh)
        {
            double tonggiatriban = 0;
            DataTable dt = new DataTable();
            dt = LayGiaTriBan(congno, mamh);
            if (dt.Rows.Count < 1)
                return 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                string GiaBan = (!dt.Rows[i]["GiaBan"].ToString().Equals("")) ? dt.Rows[i]["GiaBan"].ToString() : "0";
                string SLBan = (!dt.Rows[i]["SLBan"].ToString().Equals("")) ? dt.Rows[i]["SLBan"].ToString() : "0";
                tonggiatriban += (Double.Parse(GiaBan) * Double.Parse(SLBan));
            }
            return tonggiatriban;
        }*/
    }
}
