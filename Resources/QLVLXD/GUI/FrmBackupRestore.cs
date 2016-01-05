using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BUS;
using DTO;
namespace GUI_QLVLXD
{
    public partial class FrmBackupRestore : DevExpress.XtraEditors.XtraForm
    {
        DTO_Backup_Restore dto_backuprestore = new DTO_Backup_Restore();
        BUS_Backup_Restore bus_backuprestore = new BUS_Backup_Restore();
        public FrmBackupRestore()
        {
            InitializeComponent();
            LayDanhSachCoSoDuLieu();
           
        }

        private void LayThongTinSaoLuuPhucHoi()
        {
            dto_backuprestore.TenCoSoDuLieu = cbxCoSoDuLieu.Text;
            dto_backuprestore.ThuMucBackup = txtThuMucLuu.Text;
            dto_backuprestore.FileRestore = txtThuMucLuuRestore.Text;
        }

        private void LayDanhSachCoSoDuLieu()
        {
            cbxCoSoDuLieu.Properties.Items.Clear();
            SqlDataReader reader = bus_backuprestore.LayDanhSachCSDL();
            while (reader.Read())
            {
                cbxCoSoDuLieu.Properties.Items.Add(reader[0].ToString());
            }
            cbxCoSoDuLieu.SelectedIndex = 0;
        }

       
        private void btnBackup_Click(object sender, EventArgs e)
        {
            LayThongTinSaoLuuPhucHoi();

            if (bus_backuprestore.SaoLuuDuLieu(dto_backuprestore))
                MessageBox.Show("Sao Lưu Dữ Liệu Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Sao Lưu Dữ Liệu Thất Bại\nVui Lòng Kiểm Tra Lại Thư mục Lưu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }

        private void btnChonThuMuc_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            
            if(fbd.ShowDialog() == DialogResult.OK)
            {
                txtThuMucLuu.Text = fbd.SelectedPath;
            }
        }

        private void btnChonThuMucRestore_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Backup File(*.bak)|*.bak|All File(*.*)|*.*";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                txtThuMucLuuRestore.Text = ofd.FileName;
            }

        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            LayThongTinSaoLuuPhucHoi();
            if (bus_backuprestore.PhucHoiDuLieu(dto_backuprestore))
                MessageBox.Show("Phục Hồi Dữ Liệu Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Phục Hồi Dữ Liệu Thất Bại\nVui Lòng Kiểm Tra Lại File Đã Chọn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
           

        }


    }
}
