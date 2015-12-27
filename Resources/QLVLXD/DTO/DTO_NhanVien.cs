using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    class DTO_NhanVien
    {
        private string maNV;
        private string tenNV;
        private DateTime ngaySinh;
        private int gioiTinh;
        private int cMND;
        private string diaChi;
        private DateTime ngayVL;
        private string tenDN;
        private string matKhau;

        public string TenDN
        {
            get { return tenDN; }
            set { tenDN = value; }
        }

        public DateTime NgayVL
        {
            get { return ngayVL; }
            set { ngayVL = value; }
        }

        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }

        public int CMND
        {
            get { return cMND; }
            set { cMND = value; }
        }

        public int GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }

        public DateTime NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }

        public string TenNV
        {
            get { return tenNV; }
            set { tenNV = value; }
        }

        public string MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }

        public string MatKhau
        {
            get { return matKhau; }
            set { matKhau = value; }
        }
    }
}
