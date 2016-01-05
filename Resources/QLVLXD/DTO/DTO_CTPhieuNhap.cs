using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_CTPhieuNhap
    {
        private string _maPN;
        private string _maLH;

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

        public string MaLH
        {
            get
            {
                return _maLH;
            }

            set
            {
                _maLH = value;
            }
        }
    }
}
