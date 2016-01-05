using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    /**
     * Ánh xạ đến bảng HoaDon
     */
    public class DTO_HDBanHang
    {
        private string _maHd;
        private string _maNv;
        private string _maKh;
        private DateTime _thoiGianLap;
        private string _tongTien;

        public DTO_HDBanHang() { }

        public DTO_HDBanHang(string maHd, string maNv, string maKh,
            DateTime ngayLap, string tongTien)
        {
            this._maHd = maHd;
            this._maNv = maNv;
            this._maKh = maKh;
            this._thoiGianLap = ngayLap;
            this._tongTien = tongTien;
        }

        public string TongTien
        {
            get { return _tongTien; }
            set { _tongTien = value; }
        }

        public DateTime ThoiGianLap
        {
            get { return _thoiGianLap; }
            set { _thoiGianLap = value; }
        }

        public string MaKh
        {
            get { return _maKh; }
            set { _maKh = value; }
        }

        public string MaNv
        {
            get { return _maNv; }
            set { _maNv = value; }
        }

        public string MaHd
        {
            get { return _maHd; }
            set { _maHd = value; }
        }
    }
}
