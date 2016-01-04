using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_DonViTinh
    {
        string _TenTS;
        string _GiaTri;

        public string GiaTri
        {
            get { return _GiaTri; }
            set { _GiaTri = value; }
        }

        public string TenTS
        {
            get { return _TenTS; }
            set { _TenTS = value; }
        }
    }
}
