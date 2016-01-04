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
    public partial class FrmKiemKe : Form
    {
        public FrmKiemKe()
        {
            InitializeComponent();
        }

        private void FrmKiemKe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_VLXDDataSetChung.PhieuKiemKe' table. You can move, or remove it, as needed.
            this.phieuKiemKeTableAdapter.Fill(this.qL_VLXDDataSetChung.PhieuKiemKe);

        }
    }
}
