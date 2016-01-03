using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Infosql
    {
        string _TenServer;
        string _TenCoSoDuLieu;
        string _TenDangNhap;
        string _MatKhau;


        public string TenCoSoDuLieu
        {
            get { return _TenCoSoDuLieu; }
            set { _TenCoSoDuLieu = value; }
        }

        public string TenDangNhap
        {
            get { return _TenDangNhap; }
            set { _TenDangNhap = value; }
        }


        public string MatKhau
        {
            get { return _MatKhau; }
            set { _MatKhau = value; }
        }



        public string TenServer
        {
            get { return _TenServer; }
            set { _TenServer = value; }
        }

    }
}
