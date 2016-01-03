using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_BaoCaoCongNo
    {
        string _TuNgay;
        string _MaKH;
        double _TongGiaoDich;
        double _DaTra;

        public double DaTra
        {
            get { return _DaTra; }
            set { _DaTra = value; }
        }
        double _TongNo;
        double _Tile;

        public string MaKH
        {
            get { return _MaKH; }
            set { _MaKH = value; }
        }


        public double TongGiaoDich
        {
            get { return _TongGiaoDich; }
            set { _TongGiaoDich = value; }
        }

        public double TongNo
        {
            get { return _TongNo; }
            set { _TongNo = value; }
        }

        public double Tile
        {
            get { return _Tile; }
            set { _Tile = value; }
        }

        public string TuNgay
        {
            get { return _TuNgay; }
            set { _TuNgay = value; }
        }
        string _DenNgay;

        public string DenNgay
        {
            get { return _DenNgay; }
            set { _DenNgay = value; }
        }
    }
}
