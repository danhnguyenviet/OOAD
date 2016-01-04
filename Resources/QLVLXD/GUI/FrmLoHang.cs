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
    public partial class FrmLoHang : DevExpress.XtraEditors.XtraForm
    {
        public FrmLoHang()
        {
            InitializeComponent();
        }

        private void FrmLoHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_VLXDDataSetChung.MatHang' table. You can move, or remove it, as needed.
            this.matHangTableAdapter.Fill(this.qL_VLXDDataSetChung.MatHang);
            // TODO: This line of code loads data into the 'qL_VLXDDataSetChung.LoHang' table. You can move, or remove it, as needed.
            this.loHangTableAdapter.Fill(this.qL_VLXDDataSetChung.LoHang);

        }
    }
}