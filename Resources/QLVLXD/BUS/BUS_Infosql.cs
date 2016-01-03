using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
using DAL;
using DTO;
namespace BUS
{
    public class BUS_Infosql
    {
        DTO_Infosql dto_thaydoicaidat = new DTO_Infosql();
        DAL_Infosql dal_thaydoicaidat = new DAL_Infosql();

        public Boolean KetNoiServer(string ChuoiKetNoi)
        {
            try
            {
                dal_thaydoicaidat.KetNoiServer(ChuoiKetNoi);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public Boolean CapNhatDataSource(string ChuoiKetNoiMoi)
        {

            return dal_thaydoicaidat.CapNhatDataSource(ChuoiKetNoiMoi);
        }

        public Boolean XayDungCoSoDuLieuMoi(DTO_Infosql thongtincaidat, Boolean chinhsua, Boolean dangnhapbangwindow)
        {
            string ChuoiKetNoi = "";

            if (chinhsua)
            {
                if (dangnhapbangwindow)
                    ChuoiKetNoi = "Data Source=" + thongtincaidat.TenServer + ";Initial Catalog=" + thongtincaidat.TenCoSoDuLieu + ";Integrated Security=True";
                else
                {
                    ChuoiKetNoi = "Data Source=" + thongtincaidat.TenServer + ";Initial Catalog=" + thongtincaidat.TenCoSoDuLieu + ";uid=" + thongtincaidat.TenDangNhap + ";pwd=" + thongtincaidat.MatKhau;
                }
            }
            else
            {
                try
                {
                    if (dangnhapbangwindow)
                        ChuoiKetNoi = "Data Source=" + thongtincaidat.TenServer + ";Integrated Security=True";
                    else
                    {
                        ChuoiKetNoi = "Data Source=" + thongtincaidat.TenServer + ";uid=" + thongtincaidat.TenDangNhap + ";pwd=" + thongtincaidat.MatKhau;
                    }

                    System.Diagnostics.Process process = new System.Diagnostics.Process();
                    process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                    process.StartInfo.FileName = "sqlcmd.exe";
                    process.StartInfo.Arguments = "-S " + thongtincaidat.TenServer + " -E  -i script.sql";
                    process.Start();
                    process.WaitForExit();
                    ChuoiKetNoi += ";Initial Catalog=QL_VLXD";
                }
                catch
                {
                    return false;
                }
            }
            ChuoiKetNoi += ";Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";
            return CapNhatDataSource(ChuoiKetNoi);
        }
    }
}
