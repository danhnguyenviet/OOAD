using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI_QLVLXD
{
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public static string username;
        public static string matkhau;
        public static string quyen;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnPhieuThanhToan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmPhieuThanhToan frmPtt = new FrmPhieuThanhToan();
            frmPtt.Show();
        }

        private void btnDoiMatKhau_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmChangepass cp = new frmChangepass();
            cp.ShowDialog();
            
        }

        private void btnQLNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            FrmNhanVien nv = new FrmNhanVien();
            nv.Dock = DockStyle.Fill;
            nv.MdiParent = this;
            nv.Show();
        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmLogin login = new FrmLogin();
            this.Hide();
            login.ShowDialog();
            
            
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmBackupRestore bs = new FrmBackupRestore();
            bs.ShowDialog();
        }

        private void btnPhieuBanHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            FrmNhanVien nv = new FrmNhanVien();
            nv.MdiParent = this;
            nv.Show();
        }

        private void btnThanhToan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            FrmPhieuThanhToan nv = new FrmPhieuThanhToan();
            nv.Dock = DockStyle.Fill;
            nv.MdiParent = this;
            nv.Show();
        }

        private void btnNhapKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            FrmPhieuNhap nv = new FrmPhieuNhap();
            nv.MdiParent = this;
            nv.Show();
        }

        private void btnKiemKe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            FrmKiemKe nv = new FrmKiemKe();
            nv.Dock = DockStyle.Fill;
            nv.MdiParent = this;
            nv.Show();
        }

        private void btnMatHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            FrmMatHang nv = new FrmMatHang();
            nv.Dock = DockStyle.Fill;
            nv.MdiParent = this;
            nv.Show();
        }

        private void btnDonViTinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            FrmDonViTinh nv = new FrmDonViTinh();
            nv.MdiParent = this;
            nv.Show();
        }

        private void btnNhaCC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            FrmNhaCungCap nv = new FrmNhaCungCap();
            nv.Dock = DockStyle.Fill;
            nv.MdiParent = this;
            nv.Show();
        }

        private void btnKhachHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            FrmKhachHang nv = new FrmKhachHang();
            nv.Dock = DockStyle.Fill;
            nv.MdiParent = this;
            nv.Show();
        }

        private void FrmMainClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            FrmBaoCaoCongNoKH nv = new FrmBaoCaoCongNoKH();
            nv.Dock = DockStyle.Fill;
            nv.MdiParent = this;
            nv.Show();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            FrmBaoCaoDoanhThu nv = new FrmBaoCaoDoanhThu();
            nv.Dock = DockStyle.Fill;
            nv.MdiParent = this;
            nv.Show();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            FrmBaoCaoTonKho nv = new FrmBaoCaoTonKho();
            nv.Dock = DockStyle.Fill;
            nv.MdiParent = this;
            nv.Show();
        }


>>>>>>> 86f40d1c4990c6b3e3bf6cad606d62396ff55546
    }
}
