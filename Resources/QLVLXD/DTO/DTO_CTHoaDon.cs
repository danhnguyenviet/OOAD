using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    /**
     * Ánh xạ đến bảng ChiTietHoaDon
     */
    public class DTO_CTHoaDon
    {
        private string _maHd;
        private string _maLh;
        private string _slBan;

        public DTO_CTHoaDon() { }

        public DTO_CTHoaDon(string maHd, string maLh, string slBan)
        {
            this._maHd = maHd;
            this._maLh = maLh;
            this._slBan = slBan;
        }

        public string SlBan
        {
            get { return _slBan; }
            set { _slBan = value; }
        }

        public string MaLh
        {
            get { return _maLh; }
            set { _maLh = value; }
        }

        public string MaHd
        {
            get { return _maHd; }
            set { _maHd = value; }
        }

    }
}
