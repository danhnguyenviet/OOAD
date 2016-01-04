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
    public partial class FrmMatHang : Form
    {
        public FrmMatHang()
        {
            InitializeComponent();
        }

        private void FrmMatHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_VLXDDataSetChung.DonViTinh' table. You can move, or remove it, as needed.
            this.donViTinhTableAdapter.Fill(this.qL_VLXDDataSetChung.DonViTinh);
            // TODO: This line of code loads data into the 'qL_VLXDDataSetChung.MatHang' table. You can move, or remove it, as needed.
            this.matHangTableAdapter.Fill(this.qL_VLXDDataSetChung.MatHang);
            //repositoryItemComboBox1.ite
        }
    }
}
