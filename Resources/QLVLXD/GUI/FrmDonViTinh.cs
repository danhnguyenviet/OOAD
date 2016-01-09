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
    public partial class FrmDonViTinh : DevExpress.XtraEditors.XtraForm
    {
        bool Them;
        DTO_DonViTinh dvtDTO = new DTO_DonViTinh();
        BUS_DonViTinh dvtBUS = new BUS_DonViTinh();
        Connection helper = new Connection();

        public FrmDonViTinh()
        {
            InitializeComponent();

        }

        void KhoaDK()
        {
            txtMaDonViTinh.Enabled = false;
            txtTenDonViTinh.Enabled = false;
        }

        void MoDK()
        {
            txtMaDonViTinh.Enabled = false;
            txtTenDonViTinh.Enabled = true;
        }


        private void FrmDonViTinh_Load(object sender, EventArgs e)
        {
            dvtBUS = new BUS_DonViTinh();
            dgvDanhSachDonViTinh.DataSource = dvtBUS.TaobangDonViTinh("");
            KhoaDK();
            btnLuu.Enabled = false;
            txtMaDonViTinh.Text = dgvDanhSachDonViTinh.Rows[0].Cells[0].Value.ToString();
            txtTenDonViTinh.Text = dgvDanhSachDonViTinh.Rows[0].Cells[1].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            MoDK();
            SetNull();
            txtMaDonViTinh.Text = dvtBUS.TuTinhMa();
            Them = true;
        }

        void SetNull()
        {
            txtMaDonViTinh.Text = "";
            txtTenDonViTinh.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnXoa.Enabled = false;
            MoDK();
            txtMaDonViTinh.Enabled = false;
            Them = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn xóa khách hàng này ?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                dvtDTO.TenTS = txtMaDonViTinh.Text;
                dvtBUS.XoadulieuDonViTinh(dvtDTO);
                dgvDanhSachDonViTinh.DataSource = dvtBUS.TaobangDonViTinh("");
            }
            else
            { }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaDonViTinh.Text != "" && txtTenDonViTinh.Text != "")
            {
                dvtDTO.TenTS= txtMaDonViTinh.Text.ToString();
                dvtDTO.GiaTri = txtTenDonViTinh.Text.ToString();
                try
                {
                    if (Them)
                    {
                        dvtBUS.ThemdulieuDonViTinh(dvtDTO);
                    }
                    else
                    {
                        dvtBUS.SuadulieuDonViTinh(dvtDTO);
                    }
                }
                catch (Exception)
                {
                }


                KhoaDK();
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnThem.Enabled = true;
                btnLuu.Enabled = false;
                dgvDanhSachDonViTinh.DataSource = dvtBUS.TaobangDonViTinh("");
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng", "Lỗi");
            }

        }

        private void dgvDanhSachDonViTinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaDonViTinh.Text = dgvDanhSachDonViTinh.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenDonViTinh.Text = dgvDanhSachDonViTinh.Rows[e.RowIndex].Cells[1].Value.ToString();
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnThem.Enabled = true;
            }
            catch (Exception)
            {
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }
    }
}