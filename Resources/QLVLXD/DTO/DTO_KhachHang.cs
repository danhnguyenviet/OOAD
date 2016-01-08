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

        private string _soDienThoai;

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

        public string SoDienThoai
        {
            get
            {
                return _soDienThoai;
            }

            set
            {
                _soDienThoai = value;
            }
        }

        public DTO_KhachHang(string MaKH = "", string HoTen = "", string DiaChi = "", string SoDienThoai = "")
        {
            this.MaKH = MaKH;
            this.HoTen = HoTen;
            this.DiaChi = DiaChi;
            this.SoDienThoai = SoDienThoai;
        }
    }
}
