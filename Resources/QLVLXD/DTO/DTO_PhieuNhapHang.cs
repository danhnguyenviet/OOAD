using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class DTO_PhieuNhapHang
    {
        private string _maPN;
        private string _maNV;
        private string _tenNV;
        private string _maNCC;
        private string _tenNCC;
        private DateTime _thoiGianLap;

        public string MaPN
        {
            get
            {
                return _maPN;
            }

            set
            {
                _maPN = value;
            }
        }

        public string MaNV
        {
            get
            {
                return _maNV;
            }

            set
            {
                _maNV = value;
            }
        }

        public DateTime ThoiGianLap
        {
            get
            {
                return _thoiGianLap;
            }

            set
            {
                _thoiGianLap = value;
            }
        }

        public string MaNCC
        {
            get
            {
                return _maNCC;
            }

            set
            {
                _maNCC = value;
            }
        }

        public string TenNV
        {
            get
            {
                return _tenNV;
            }

            set
            {
                _tenNV = value;
            }
        }

        public string TenNCC
        {
            get
            {
                return _tenNCC;
            }

            set
            {
                _tenNCC = value;
            }
        }
    }

}
