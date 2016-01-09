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
using DTO;

namespace GUI_QLVLXD
{
    public partial class FrmNhaCungCap : DevExpress.XtraEditors.XtraForm
    {
        bool Them;
        DTO_NhaCC NccDTO = new DTO_NhaCC();
        BUS_NhaCC NccBUS = new BUS_NhaCC();

        public FrmNhaCungCap()
        {
            InitializeComponent();
        }

        void KhoaDK()
        {
            txtMaNCC.Enabled = false;
            txtHoTen.Enabled = false;
            txtDiaChi.Enabled = false;
            txtSDT.Enabled = false;
        }

        void MoDK()
        {
            txtMaNCC.Enabled = false;
            txtHoTen.Enabled = true;
            txtDiaChi.Enabled = true;
            txtSDT.Enabled = true;
        }


        private void FrmNhaCC_Load(object sender, EventArgs e)
        {
            NccBUS = new BUS_NhaCC();
            dgvDanhSachNCC.DataSource = NccBUS.TaobangNhaCC("");
            KhoaDK();
            btnLuu.Enabled = false;
            txtMaNCC.Text = dgvDanhSachNCC.Rows[0].Cells[0].Value.ToString();
            txtHoTen.Text = dgvDanhSachNCC.Rows[0].Cells[1].Value.ToString();
            txtDiaChi.Text = dgvDanhSachNCC.Rows[0].Cells[2].Value.ToString();
            txtSDT.Text = dgvDanhSachNCC.Rows[0].Cells[3].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            MoDK();
            SetNull();
            txtMaNCC.Text = NccBUS.TuTinhMa();
            Them = true;
        }

        void SetNull()
        {
            txtMaNCC.Text = "";
            txtHoTen.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnXoa.Enabled = false;
            MoDK();
            txtMaNCC.Enabled = false;
            Them = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn xóa khách hàng này ?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                NccDTO.MaNCC = txtMaNCC.Text;
                NccBUS.XoadulieuNhaCC(NccDTO);
                dgvDanhSachNCC.DataSource = NccBUS.TaobangNhaCC("");
            }
            else
            { }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text != "" && txtSDT.Text != "" && txtDiaChi.Text != "")
            {
                NccDTO.MaNCC = txtMaNCC.Text.ToString();
                NccDTO.TenNCC = txtHoTen.Text.ToString();
                NccDTO.DiaChi = txtDiaChi.Text.ToString();
                NccDTO.SDT = txtSDT.Text.ToString();
                try
                {
                    if (Them)
                    {
                        NccBUS.ThemdulieuNhaCC(NccDTO);
                    }
                    else
                    {
                        NccBUS.SuadulieuNhaCC(NccDTO);
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
                dgvDanhSachNCC.DataSource = NccBUS.TaobangNhaCC("");
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng", "Lỗi");
            }

        }

        private void dgvDanhSachNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaNCC.Text = dgvDanhSachNCC.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtHoTen.Text = dgvDanhSachNCC.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDiaChi.Text = dgvDanhSachNCC.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtSDT.Text = dgvDanhSachNCC.Rows[e.RowIndex].Cells[3].Value.ToString();
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