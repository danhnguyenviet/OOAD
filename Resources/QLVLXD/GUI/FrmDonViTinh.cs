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
    public partial class frmDonViTinh : DevExpress.XtraEditors.XtraForm
    {
        public frmDonViTinh()
        {
            InitializeComponent();
        }

        private void frmDonViTinh_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_VLXDDataSetChung.DonViTinh' table. You can move, or remove it, as needed.
            this.donViTinhTableAdapter.Fill(this.qL_VLXDDataSetChung.DonViTinh);

        }
    }
}