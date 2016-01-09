using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace DAL
{
    public class DAL_LoHang
    {


        private Connection connection;
        private DAL_CTHoaDon _cthd;

        public DAL_LoHang()
        {
            this.connection = new Connection();
            this._cthd = new DAL_CTHoaDon();
        }
        //Tạo bảng lo hàng
        public DataTable TaobangLoHang(string dieukien)
        {
            return connection.GetDataTable("select * from LOHANG " + dieukien);
        }
        //Thêm lo hàng mới
        public void InsertLoHang(DTO_LoHang lhDTO)
        {
            connection.ThucHienCauLenhSQL("INSERT INTO LoHang (MaLH, MaMH,NgaySX,HanSD,SLNhap,SLBan,GiaNhap,GiaBan) VALUES (N'" + lhDTO.MaLh + "',N'" + lhDTO.MaMh + "',N'" + lhDTO.NgaySx.ToShortDateString() + "',N'" + lhDTO.HanSd + "',N'" + lhDTO.SlNhap + "',N'" + lhDTO.SlBan + "',N'" + lhDTO.GiaNhap + "',N'" + lhDTO.GiaBan + "')");
        }
        //Xóa lô hàng
        public void DeleteLoHang(string mhDTO)
        {
            connection.ThucHienCauLenhSQL("DELETE from LoHang Where MaLH = N'" + mhDTO + "'");
        }


        // Load distinct danh sách lô hàng có số lượng bán lớn nhất
        public DataTable LayDsHangTonHienTai()
        {
            return connection.GetDataTable("SELECT MatHang.MaMH, TenMH FROM MatHang INNER JOIN " +
                "(SELECT DISTINCT MaMH FROM LoHang) AS A ON MatHang.MaMH=A.MaMH");
        }

        // Lấy số lượng hàng tồn hiện tại
        public string LaySlHangTonHienTai(string tenMh)
        {
            DataTable dsHangTon = connection.GetDataTable("SELECT (SUM(SLNhap) - SUM(SLBan)) AS SLTon FROM LoHang " +
                "WHERE LoHang.MaMH IN " +
                "(SELECT MaMH FROM MatHang WHERE MatHang.TenMH=N'" + tenMh + "')" +
                "AND LoHang.SLNhap<>LoHang.SLBan");
            return dsHangTon.Rows[0]["SLTon"].ToString();
        }

        // Lấy giá bán của mặt hàng theo tên
        public string LayGiaBan(string tenMh)
        {
            DataTable dsHangTon = connection.GetDataTable("SELECT DISTINCT GiaBan FROM LoHang WHERE MaMH IN " +
                "(SELECT MaMH FROM MatHang WHERE MatHang.TenMH=N'" + tenMh + "')");

            return dsHangTon.Rows[0]["GiaBan"].ToString();
        }

        // Lấy mã mặt hàng theo tên
        public string LayMaMatHang(string tenMh)
        {
            DataTable dsHangTon = connection.GetDataTable("SELECT MaMH FROM MatHang WHERE TenMH=N'" + tenMh + "')");

            return dsHangTon.Rows[0]["MaMH"].ToString();
        }

        public DataTable LayMotMatHangTon(string maMh)
        {
            return connection.GetDataTable("SELECT TOP(1) * FROM LoHang WHERE SLBan<>SLNhap AND MaMH=N'" + maMh + "'");
        }

        // Cập nhập thông tin lô hàng và chi tiết hóa đơn
        public bool CapNhatThongTinLoHang(List<string> dsMaLh, string slBan, string maHd)
        {
            double soLuongBan = Double.Parse(slBan);

            if (dsMaLh.Count == 1)
            {
                connection.ThucHienCauLenhSQL("UPDATE LoHang SET SLBan=SLBan + " + soLuongBan +
                    " WHERE LoHang.MaLH='" + dsMaLh[0] + "'");

                DTO_CTHoaDon temp_cthd = new DTO_CTHoaDon(maHd, dsMaLh[0], soLuongBan.ToString());
                this._cthd.ThemCTHoaDon(temp_cthd);
            }
            if (dsMaLh.Count > 1)
            {
                for (int i = 0; i < dsMaLh.Count; i++)
                {
                    if (i < (dsMaLh.Count - 1))
                    {
                        DataTable hangTon = connection.GetDataTable("SELECT SLNhap, SLBan FROM LoHang WHERE MaLH=N'" + dsMaLh[i] + "')");
                        soLuongBan -= Double.Parse(hangTon.Rows[0]["SLNhap"].ToString()) - Double.Parse(hangTon.Rows[0]["SLBan"].ToString());
                        connection.ThucHienCauLenhSQL("UPDATE LoHang SET SLBan=SLNhap WHERE LoHang.MaLH='" + dsMaLh[i] + "'");

                        DTO_CTHoaDon temp_cthd = new DTO_CTHoaDon(maHd, dsMaLh[i],
                            (Double.Parse(hangTon.Rows[0]["SLNhap"].ToString()) - Double.Parse(hangTon.Rows[0]["SLBan"].ToString())).ToString());
                        this._cthd.ThemCTHoaDon(temp_cthd);
                    }
                    else
                    {
                        connection.ThucHienCauLenhSQL("UPDATE LoHang SET SLBan=SLBan + " + soLuongBan +
                        " WHERE LoHang.MaLH='" + dsMaLh[i] + "'");

                        DTO_CTHoaDon temp_cthd = new DTO_CTHoaDon(maHd, dsMaLh[0], soLuongBan.ToString());
                        this._cthd.ThemCTHoaDon(temp_cthd);
                    }

                }
            }

            return true;

            #region old algorithsm
            //DataTable dttenMh = connection.GetDataTable("SELECT TenMH FROM MatHang WHERE MaMH=N'" + maMh + "')");
            //string tenMh = dttenMh.Rows[0]["TenMH"].ToString();

            //DataTable hangTon = LayMotMatHangTon(maMh);
            //double soLuongTon = Double.Parse(hangTon.Rows[0]["SLNhap"].ToString()) - Double.Parse(hangTon.Rows[0]["SLBan"].ToString());
            

            //while (soLuongBan > 0)
            //{
            //    if (soLuongTon >= soLuongBan)
            //    {
            //        double tempNum = soLuongBan + Double.Parse(hangTon.Rows[0]["SLBan"].ToString());
            //        connection.ThucHienCauLenhSQL("UPDATE LoHang SET SLBan=" + tempNum +
            //            "WHERE LoHang.MaLH='" + hangTon.Rows[0]["MaLH"] + "'");
            //        soLuongBan = 0;

            //        dsMaLh.Add(hangTon.Rows[0]["MaLH"].ToString());

            //        break;
            //    }
            //    else
            //    {
            //        connection.ThucHienCauLenhSQL("UPDATE LoHang SET SLBan=" + hangTon.Rows[0]["SLNhap"] +
            //            "WHERE LoHang.MaLH='" + hangTon.Rows[0]["MaLH"] + "'");
            //        soLuongBan -= soLuongTon;

            //        dsMaLh.Add(hangTon.Rows[0]["MaLH"].ToString());

            //        hangTon = LayMotMatHangTon(maMh);
            //    }
            //}

            //return true;
            #endregion
        }

        // Cập nhật thông tin lô hàng và chi tiết hóa đơn
        public bool CapNhatThongTinLoHangVaCthd(string maMh, string slBan, string maHd)
        {

            //List<string> dsMaLh = new List<string>();

            double soLuongBan = Double.Parse(slBan);

            DataTable dttenMh = connection.GetDataTable("SELECT TenMH FROM MatHang WHERE MaMH=N'" + maMh + "'");
            string tenMh = dttenMh.Rows[0]["TenMH"].ToString();

            DataTable hangTon = LayMotMatHangTon(maMh);
            double soLuongTon = Double.Parse(hangTon.Rows[0]["SLNhap"].ToString()) - Double.Parse(hangTon.Rows[0]["SLBan"].ToString());


            while (soLuongBan > 0)
            {
                if (soLuongTon >= soLuongBan)
                {
                    connection.ThucHienCauLenhSQL("UPDATE LoHang SET SLBan=SLBan + " + soLuongBan +
                    " WHERE LoHang.MaLH='" + hangTon.Rows[0]["MaLH"].ToString() + "'");

                    DTO_CTHoaDon temp_cthd = new DTO_CTHoaDon(maHd, hangTon.Rows[0]["MaLH"].ToString(), soLuongBan.ToString());
                    this._cthd.ThemCTHoaDon(temp_cthd);
                    
                    soLuongBan = 0;

                    //dsMaLh.Add(hangTon.Rows[0]["MaLH"].ToString());

                    break;
                }
                else
                {
                    connection.ThucHienCauLenhSQL("UPDATE LoHang SET SLBan=SLNhap" +
                    " WHERE LoHang.MaLH='" + hangTon.Rows[0]["MaLH"].ToString() + "'");

                    DTO_CTHoaDon temp_cthd = new DTO_CTHoaDon(maHd, hangTon.Rows[0]["MaLH"].ToString(), 
                        (Double.Parse(hangTon.Rows[0]["SLNhap"].ToString()) - Double.Parse(hangTon.Rows[0]["SLBan"].ToString())).ToString());
                    this._cthd.ThemCTHoaDon(temp_cthd);

                    soLuongBan -= soLuongTon;
                    
                    //dsMaLh.Add(hangTon.Rows[0]["MaLH"].ToString());

                    hangTon = LayMotMatHangTon(maMh);
                    soLuongTon = Double.Parse(hangTon.Rows[0]["SLNhap"].ToString()) - Double.Parse(hangTon.Rows[0]["SLBan"].ToString());
                }
            }

            return true;
        }

        public void sdfkja()
        {
            
        }
    }
}
