using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class DTO_NhaCC
    {
        private string _MaNCC;

        public string MaNCC
        {
            get { return _MaNCC; }
            set { _MaNCC = value; }
        }

        private string _TenNCC;

        public string TenNCC
        {
            get { return _TenNCC; }
            set { _TenNCC = value; }
        }

        private string _DiaChi;

        public string DiaChi
        {
            get { return _DiaChi; }
            set { _DiaChi = value; }
        }

        private string _SDT;

        public string SDT
        {
            get { return _SDT; }
            set { _SDT = value; }
        }



        public DTO_NhaCC(string MaNCC="",string TenNCC="",string DiaChi="", string SDT= "")
        {
            this._MaNCC = MaNCC;
            this.TenNCC = TenNCC;
            this.DiaChi = DiaChi;
            this.SDT = SDT;
        }
    }
}
