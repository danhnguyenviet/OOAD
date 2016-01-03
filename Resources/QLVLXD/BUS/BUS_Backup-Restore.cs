using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DAL;
using DTO;
namespace BUS
{
    public class BUS_Backup_Restore
    {
        DAL_Backup_Restore dal_backuprestore = new DAL_Backup_Restore();

        public SqlDataReader LayDanhSachCSDL()
        {
            return dal_backuprestore.LayDanhSachCSDL();
        }

        public bool SaoLuuDuLieu(DTO_Backup_Restore backuprestore)
        {
            return dal_backuprestore.SaoLuuCoSoDuLieu(backuprestore);
        }

        public bool PhucHoiDuLieu(DTO_Backup_Restore backuprestore)
        {
            return dal_backuprestore.PhucHoiCoSoDuLieu(backuprestore);
        }

    }
}
