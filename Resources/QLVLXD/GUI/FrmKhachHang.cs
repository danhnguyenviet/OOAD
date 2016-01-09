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
        bool Them;
        DTO_KhachHang khDTO = new DTO_KhachHang();
        BUS_KhachHang khBUS = new BUS_KhachHang();
        Connection helper = new Connection();

        public FrmKhachHang()
        {
            InitializeComponent();

        }

        void KhoaDK()
        {
            txtMaKhachHang.Enabled = false;
            txtHoTen.Enabled = false;
            txtDiaChi.Enabled = false;
            txtSDT.Enabled = false;
        }

        void MoDK()
        {
            txtMaKhachHang.Enabled = false;
            txtHoTen.Enabled = true;
            txtDiaChi.Enabled = true;
            txtSDT.Enabled = true;
        }


        private void FrmKhachHang_Load(object sender, EventArgs e)
        {
            khBUS = new BUS_KhachHang();
            dgvDanhSachKhachHang.DataSource = khBUS.TaobangKhachHang("");
            KhoaDK();
            btnLuu.Enabled = false;
            txtMaKhachHang.Text = dgvDanhSachKhachHang.Rows[0].Cells[0].Value.ToString();
            txtHoTen.Text = dgvDanhSachKhachHang.Rows[0].Cells[1].Value.ToString();
            txtDiaChi.Text = dgvDanhSachKhachHang.Rows[0].Cells[2].Value.ToString();
            txtSDT.Text = dgvDanhSachKhachHang.Rows[0].Cells[3].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            MoDK();
            SetNull();
            txtMaKhachHang.Text = khBUS.TuTinhMa();
            Them = true;
        }

        void SetNull()
        {
            txtMaKhachHang.Text = "";
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
            txtMaKhachHang.Enabled = false;
            Them = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn xóa khách hàng này ?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                khDTO.MaKH = txtMaKhachHang.Text;
                khBUS.XoadulieuKhachHang(khDTO);
                dgvDanhSachKhachHang.DataSource = khBUS.TaobangKhachHang("");
            }
            else
            { }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text != "" && txtSDT.Text != "" && txtDiaChi.Text != "")
            {
                khDTO.MaKH = txtMaKhachHang.Text.ToString();
                khDTO.HoTen = txtHoTen.Text.ToString();
                khDTO.DiaChi = txtDiaChi.Text.ToString();
                khDTO.SoDienThoai = txtSDT.Text.ToString();
                try
                {
                    if (Them)
                    {
                        khBUS.ThemdulieuKhachHang(khDTO);
                    }
                    else
                    {
                        khBUS.SuadulieuKhachHang(khDTO);
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
                dgvDanhSachKhachHang.DataSource = khBUS.TaobangKhachHang("");
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng", "Lỗi");
            }

        }

        private void dgvDanhSachKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaKhachHang.Text = dgvDanhSachKhachHang.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtHoTen.Text = dgvDanhSachKhachHang.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDiaChi.Text = dgvDanhSachKhachHang.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtSDT.Text = dgvDanhSachKhachHang.Rows[e.RowIndex].Cells[3].Value.ToString();
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