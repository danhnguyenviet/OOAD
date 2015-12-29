using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class DTO_KhachHang
    {
        private string _maKH;

        private string _hoTen;

        private string _DiaChi;

        private DateTime _ngayCapThe;

        public string MaKH
        {
            get
            {
                return _maKH;
            }

            set
            {
                _maKH = value;
            }
        }

        public string HoTen
        {
            get
            {
                return _hoTen;
            }

            set
            {
                _hoTen = value;
            }
        }

        public string DiaChi
        {
            get
            {
                return _DiaChi;
            }

            set
            {
                _DiaChi = value;
            }
        }

        public DateTime NgayCapThe
        {
            get
            {
                return _ngayCapThe;
            }

            set
            {
                _ngayCapThe = value;
            }
        }

        public DTO_KhachHang(string MaKH="",string HoTen="",string DiaChi="", DateTime NgayCapThe= new DateTime())
        {
            this.MaKH = MaKH;
            this.HoTen = HoTen;
            this.DiaChi = DiaChi;
            this.NgayCapThe = NgayCapThe;
        }
    }
}
