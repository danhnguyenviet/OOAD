using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using DTO;

namespace BUS
{
    public class BUS_ThanhToan
    {
        private DAL_PhieuThanhToan _phieuThanhToan;

        public BUS_ThanhToan()
        {
            this._phieuThanhToan = new DAL_PhieuThanhToan();
        }

        /**
         * Lấy danh sách hóa đơn chưa thanh toán xong
         */
        public DataTable LayDshdChuaTtXong()
        {
            return this._phieuThanhToan.LayDshdChuaTtXong();
        }

        /**
         * Lưu phiếu thanh toán
         */
        public bool LuuPhieuThanhToan(DTO_PhieuThanhToan phieuThanhToan)
        {
            return this._phieuThanhToan.ThemMoiPhieuThanhToan(phieuThanhToan);
        }
    }
}
