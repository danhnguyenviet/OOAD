using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class DTO_NhanVien
    {
        private string _maNv;
        private string _tenNv;
        private DateTime _ngaySinh;
        private int _gioiTinh;
        private string _cmnd;
        private string _diaChi;
        private DateTime _ngayVl;
        private string _tenDangNhap;
        private string _matKhau;
        private string _quyen;

        public DTO_NhanVien() { }

        public DTO_NhanVien(string maNv, string tenNv, DateTime ngaySinh, int gioiTinh, string cmnd,
            string diaChi, DateTime ngayVl, string tenDangNhap, string matKhau, string quyen)
        {
            this._maNv = maNv;
            this._tenNv = tenNv;
            this._ngaySinh = ngaySinh;
            this._gioiTinh = gioiTinh;
            this._cmnd = cmnd;
            this._diaChi = diaChi;
            this._ngayVl = ngayVl;
            this._tenDangNhap = tenDangNhap;
            this._matKhau = matKhau;
            this._quyen = quyen;
        }

        public string Quyen
        {
            get { return _quyen; }
            set { _quyen = value; }
        }

        public string MatKhau
        {
            get { return _matKhau; }
            set { _matKhau = value; }
        }

        public string TenDangNhap
        {
            get { return _tenDangNhap; }
            set { _tenDangNhap = value; }
        }

        public DateTime NgayVl
        {
            get { return _ngayVl; }
            set { _ngayVl = value; }
        }

        public string DiaChi
        {
            get { return _diaChi; }
            set { _diaChi = value; }
        }

        public string Cmnd
        {
            get { return _cmnd; }
            set { _cmnd = value; }
        }

        public int GioiTinh
        {
            get { return _gioiTinh; }
            set { _gioiTinh = value; }
        }

        public DateTime NgaySinh
        {
            get { return _ngaySinh; }
            set { _ngaySinh = value; }
        }

        public string TenNv
        {
            get { return _tenNv; }
            set { _tenNv = value; }
        }

        public string MaNv
        {
            get { return _maNv; }
            set { _maNv = value; }
        }
    }
}
