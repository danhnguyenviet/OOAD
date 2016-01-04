using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Backup_Restore
    {
        string _TenCoSoDuLieu;
        string _ThuMucBackup;
        string _FileRestore;

        public string FileRestore
        {
            get { return _FileRestore; }
            set { _FileRestore = value; }
        }


        public string ThuMucBackup
        {
            get { return _ThuMucBackup; }
            set { _ThuMucBackup = value; }
        }

        public string TenCoSoDuLieu
        {
            get { return _TenCoSoDuLieu; }
            set { _TenCoSoDuLieu = value; }
        }
    }
}
