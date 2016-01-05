using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLVLXD
{
    public partial class Demo : Form
    {
        public Demo()
        {
            InitializeComponent();
        }


        private void Demo_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_VLXDNhapHang.PhieuNhap' table. You can move, or remove it, as needed.
            //this.phieuNhapTableAdapter1.Fill(this.qL_VLXDNhapHang.PhieuNhap);

            //chitietphieuNhapTableAdapter.Fill(this.qL_VLXDNhapHang.ChiTietPhieuNhap);
        }

        private void gridView2_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            //MessageBox.Show("dsfsd");
        }

        private void gridView2_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {

            MessageBox.Show("dsdsdf");
            gridView3.EndInit();
        }
    }
}
