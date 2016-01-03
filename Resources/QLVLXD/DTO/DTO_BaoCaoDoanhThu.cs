using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_BaoCaoDoanhThu
    {
        string _Nam;

        public string Nam
        {
            get { return _Nam; }
            set { _Nam = value; }
        }
        string _Thang;

        public string Thang
        {
            get { return _Thang; }
            set { _Thang = value; }
        }
    }
}
