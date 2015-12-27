using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    class DTO_KhachHang
    {
        private string maKH;
        private string hoTen;
        private string diaChi;
        private string sDT;

        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }

        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }

        public string MaKH
        {
            get { return maKH; }
            set { maKH = value; }
        }

        public string SDT
        {
            get { return sDT; }
            set { sDT = value; }
        }
    }
}
