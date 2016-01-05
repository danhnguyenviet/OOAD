using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_PhieuThanhToan
    {
        private string _maPhieuTt;
        private string _soTienNop;
        private DateTime _thoiGianNop;
        private string _maHd;
        private string _maNv;

        public DTO_PhieuThanhToan() { }

        public DTO_PhieuThanhToan(string maPhieuTt, string soTienNop,
            DateTime thoiGianNop, string maHd, string maNv)
        {
            this._maPhieuTt = maPhieuTt;
            this._soTienNop = soTienNop;
            this._thoiGianNop = thoiGianNop;
            this._maHd = maHd;
            this._maNv = maNv;
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

        public DateTime ThoiGianNop
        {
            get { return _thoiGianNop; }
            set { _thoiGianNop = value; }
        }

        public string SoTienNop
        {
            get { return _soTienNop; }
            set { _soTienNop = value; }
        }

        public string MaPhieuTt
        {
            get { return _maPhieuTt; }
            set { _maPhieuTt = value; }
        }
    }
}
