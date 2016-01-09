using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace GUI_QLVLXD
{
    public partial class FrmPhieuNhap : DevExpress.XtraEditors.XtraForm
    {
        public FrmPhieuNhap()
        {
            InitializeComponent();
        }

        private void FrmPhieuNhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_VLXDDataSetChung.LoHang' table. You can move, or remove it, as needed.
            this.loHangTableAdapter.Fill(this.qL_VLXDDataSetChung.LoHang);
            // TODO: This line of code loads data into the 'qL_VLXDDataSetChung.NhaCC' table. You can move, or remove it, as needed.
            this.nhaCCTableAdapter.Fill(this.qL_VLXDDataSetChung.NhaCC);
            // TODO: This line of code loads data into the 'qL_VLXDDataSetChung.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.qL_VLXDDataSetChung.NhanVien);
            // TODO: This line of code loads data into the 'qL_VLXDDataSetChung.PhieuNhap' table. You can move, or remove it, as needed.
            this.phieuNhapTableAdapter.Fill(this.qL_VLXDDataSetChung.PhieuNhap);

            this.chiTietPhieuNhapTableAdapter1.Fill(this.qL_VLXDDataSetChung.ChiTietPhieuNhap);

           //cardView2.DataSource = qL_VLXDDataSetChung.LoHang;
            //this.loHangTableAdapter.Fill(this.qL_VLXDDataSetChung.LoHang);
        }
    }
}