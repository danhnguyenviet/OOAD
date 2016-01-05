using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class DTO_MatHang
    {
        string _MaMH;
        string _TenMH;
        string _TenNSX;
        string _MaDVT;
        float _ThueVAT;

        public float ThueVAT
        {
            get { return _ThueVAT; }
            set { _ThueVAT = value; }
        }

        public string MaDVT
        {
            get { return _MaDVT; }
            set { _MaDVT = value; }
        }

        public string TenNSX
        {
            get { return _TenNSX; }
            set { _TenNSX = value; }
        }

        public string TenMH
        {
            get { return _TenMH; }
            set { _TenMH = value; }
        }

        public string MaMH
        {
            get { return _MaMH; }
            set { _MaMH = value; }
        }

        public DTO_MatHang(string MaMH = "",string TenMH = "",string TenNSX = "", string MaDVT = "", float ThueVAT = 0)
        {
            this.MaMH = MaMH;
            this.TenMH = TenMH;
            this.TenNSX = TenNSX;
            this.MaDVT = MaDVT;
            this.ThueVAT = ThueVAT;
        }
    }
}
