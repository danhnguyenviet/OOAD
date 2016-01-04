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
using BUS;
using DAL;
using DTO;

namespace GUI_QLVLXD
{
    public partial class FrmKhachHang : DevExpress.XtraEditors.XtraForm
    {
      
        public FrmKhachHang()
        {
            InitializeComponent();
            
        }

        private void FrmKhachHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_VLXDDataSetChung.KhachHang' table. You can move, or remove it, as needed.
            this.khachHangTableAdapter.Fill(this.qL_VLXDDataSetChung.KhachHang);
        }


    }
}