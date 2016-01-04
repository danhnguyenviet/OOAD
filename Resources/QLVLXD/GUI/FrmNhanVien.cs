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
    public partial class FrmNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public FrmNhanVien()
        {
            InitializeComponent();
        }

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_VLXDDataSetChung.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.qL_VLXDDataSetChung.NhanVien);

        }
    }
}