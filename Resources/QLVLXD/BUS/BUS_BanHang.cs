using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_BanHang
    {
        private DAL_NhanVien _dal_NhanVien;
        private DAL_KhachHang _dal_KhachHang;
        private DAL_CTHoaDon _dal_CTHoaDon;
        private DAL_HDBanHang _dal_HDBanHang;
        private DAL_PhieuThanhToan _dal_PhieuThanhToan;
        private DAL_LoHang _dal_LoHang;

        public BUS_BanHang()
        {
            this._dal_KhachHang = new DAL_KhachHang();
            this._dal_NhanVien = new DAL_NhanVien();
            this._dal_CTHoaDon = new DAL_CTHoaDon();
            this._dal_HDBanHang = new DAL_HDBanHang();
            this._dal_PhieuThanhToan = new DAL_PhieuThanhToan();
            this._dal_LoHang = new DAL_LoHang();
        }

        /**
         * Lấy danh sách mã nhân viên và họ tên tương ứng
         */
        public DataTable LayDsMaVaTenNv()
        {
            return this._dal_NhanVien.LayMaVaTenNhanVien();
        }

        /**
         * Lấy danh sách mã khách hàng và họ tên tương ứng
         */
        public DataTable LayDsMaVaTenKh()
        {
            return this._dal_KhachHang.LayMaVaTenKhachHang();
        }

        /**
         * Lưu hóa đơn bán hàng
         * @DTO_HDBanHang: hdBanHang
         * @List<DTO_CTHoaDon>: dsCtHoaDon
         * @DTO_PhieuThanhToan: phieuThanhToan
         */
        public bool LuuHoaDonBanHang(DTO_HDBanHang hdBanHang, List<DTO_CTHoaDon> dsCtHoaDon,
            DTO_PhieuThanhToan phieuThanhToan)
        {
            this._dal_HDBanHang.ThemMoiHdBanHang(hdBanHang);

            foreach (DTO_CTHoaDon ctHoaDon in dsCtHoaDon)
            {
                this._dal_CTHoaDon.ThemCTHoaDon(ctHoaDon);
            }

            //this._dal_PhieuThanhToan.ThemMoiPhieuThanhToan(phieuThanhToan);

            return true;
        }

        // Lấy danh sách nhân viên bán hàng
        public DataTable LayDsNhanVienBh()
        {
            return this._dal_NhanVien.LayMaVaTenNhanVien();
        }

        // Lấy danh sách khách hàng
        public DataTable LayDsKhachHang()
        {
            return this._dal_KhachHang.LayMaVaTenKhachHang();
        }

        // Lấy danh sách hàng tồn hiện tại
        public DataTable LayDsHangTonHienTai()
        {
            return this._dal_LoHang.LayDsHangTonHienTai();
        }

        // Số lượng mặt hàng hợp lệ
        public bool SoLuongBanHopLe(string tenMh, int soLuong)
        {
            if (!this._dal_LoHang.LaySlHangTonHienTai(tenMh).ToString().Equals(""))
            {
                if (soLuong <= Double.Parse(this._dal_LoHang.LaySlHangTonHienTai(tenMh)))
                {
                    return true;
                }
            }

            return false;
        }

        // Lấy giá bán của mặt hàng theo tên
        public string LayGiaBan(string tenMh)
        {
            return this._dal_LoHang.LayGiaBan(tenMh);
        }


        // Lấy mã mặt hàng theo tên
        public string LayMaMatHang(string tenMh)
        {
            return this._dal_LoHang.LayMaMatHang(tenMh);
        }

        // Lấy danh sách lô hàng được bán
        public bool CapNhatThongTinLoHangVaCthd(string maMh, string slBan, string maHd)
        {
            return this._dal_LoHang.CapNhatThongTinLoHangVaCthd(maMh, slBan, maHd);
        }

        // Lưu hóa đơn bán hàng
        public bool LuuHdBanHang(DTO_HDBanHang hdBanHang)
        {
            this._dal_HDBanHang.ThemMoiHdBanHang(hdBanHang);
            return true;
        }

        // Lưu phiếu thanh toán
        public bool LuuPhieuThanhToan(DTO_PhieuThanhToan phieuThanhToan)
        {
            this._dal_PhieuThanhToan.ThemMoiPhieuThanhToan(phieuThanhToan);
            return true;
        }

        // Lấy tất cả hóa đơn bán hàng
        public DataTable LayTatCaHdbh()
        {
            return this._dal_HDBanHang.LayTatCaHdbh();
        }

        // Lấy chi tiết hóa đơn bán hàng theo mã
        public DataTable LayCthdbhTheoMa(string maHd)
        {
            return this._dal_CTHoaDon.LayCtHdbhTheoMaHd(maHd);
        }

        /**
         * Lấy tên mặt hàng theo mã lô hàng
         */
        public string LayTenMatHangTheoMaLh(string maLh)
        {
            return this._dal_CTHoaDon.LayTenMatHangTheoMaLh(maLh);
        }

        /**
         * Lấy giá bán theo mã lô hàng
         */
        public string LayGiaBanTheoMaLh(string maLh)
        {
            return this._dal_CTHoaDon.LayGiaBanTheoMaLh(maLh);
        }
    }
}
