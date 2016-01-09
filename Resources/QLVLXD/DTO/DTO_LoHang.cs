using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    /**
     * Ánh xạ đến bảng LoHang
     */ 
    public class DTO_LoHang
    {
        private string _maLh;
        private string _maMh;
        private DateTime _ngaySx;
        private string _hanSd;
        private string _slNhap;
        private string _slBan;
        private string _giaNhap;
        private string _giaBan;
        private string _tenMH;

        public DTO_LoHang() { }

        public DTO_LoHang(string maLh, string maMh, DateTime ngaySx,
            string hanSd, string slNhap, string slBan, string giaNhap, string giaBan)
        {
            this._maLh = maLh;
            this._maMh = maMh;
            this._ngaySx = ngaySx;
            this._hanSd = hanSd;
            this._slNhap = slNhap;
            this._slBan = slBan;
            this._giaNhap = giaBan;
            this._giaBan = giaBan;
        }

        public string MaLh
        {
            get { return _maLh; }
            set { _maLh = value; }
        }

        public string MaMh
        {
            get { return _maMh; }
            set { _maMh = value; }
        }
        public string TenMH
        {
            get
            {
                return _tenMH;
            }

            set
            {
                _tenMH = value;
            }
        }

        public DateTime NgaySx
        {
            get { return _ngaySx; }
            set { _ngaySx = value; }
        }

        public string HanSd
        {
            get { return _hanSd; }
            set { _hanSd = value; }
        }

        public string SlNhap
        {
            get { return _slNhap; }
            set { _slNhap = value; }
        }
        public string GiaNhap
        {
            get { return _giaNhap; }
            set { _giaNhap = value; }
        }
        public string SlBan
        {
            get { return _slBan; }
            set { _slBan = value; }
        }


        public string GiaBan
        {
            get { return _giaBan; }
            set { _giaBan = value; }
        }


    }
}
