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
using DTO;
using DAL;
using BUS;

namespace GUI_QLVLXD
{
    public partial class FrmNhanVien : DevExpress.XtraEditors.XtraForm
    {
        bool Them;
        DTO_NhanVien nvDTO = new DTO_NhanVien();
        BUS_NhanVien nvBUS = new BUS_NhanVien();
        Connection helper = new Connection();

        public FrmNhanVien()
        {
            InitializeComponent();
            txtMatKhau.Properties.PasswordChar = '*';
            this.Dock = DockStyle.Fill;
        }

        void KhoaDK()
        {
            txtMaNhanVien.Enabled = false;
            txtHoTen.Enabled = false;
            dateNgaySinh.Enabled = false;
            rdbtnNam.Enabled = false;
            rdbtnNu.Enabled = false;
            txtCmnd.Enabled = false;
            txtDiaChi.Enabled = false;
            txtTenDangNhap.Enabled = false;
            txtMatKhau.Enabled = false;
            dateNgayVaoLam.Enabled = false;
        }

        void MoDK()
        {
            txtMaNhanVien.Enabled = false;
            txtHoTen.Enabled = true;
            dateNgaySinh.Enabled = true;
            rdbtnNam.Enabled = true;
            rdbtnNu.Enabled = true;
            txtCmnd.Enabled = true;
            txtDiaChi.Enabled = true;
            txtTenDangNhap.Enabled = true;
            txtMatKhau.Enabled = true;
            dateNgayVaoLam.Enabled = true;
        }

        void SetNull()
        {
            txtMaNhanVien.Text = "";
            txtHoTen.Text = "";
            dateNgaySinh.Text = "";
            rdbtnNam.Checked = false;
            rdbtnNu.Checked = false;
            txtCmnd.Text = "";
            txtDiaChi.Text = "";
            txtTenDangNhap.Text = "";
            txtMatKhau.Text = "";
            dateNgayVaoLam.Text = "";

        }

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            nvBUS = new BUS_NhanVien();
            dgvDanhSachNhanVien.DataSource = nvBUS.TaobangNhanVien("");
            KhoaDK();
            btnLuu.Enabled = false;

            txtMaNhanVien.Text = dgvDanhSachNhanVien.Rows[0].Cells[0].Value.ToString();
            txtHoTen.Text = dgvDanhSachNhanVien.Rows[0].Cells[1].Value.ToString();
            dateNgaySinh.Text = dgvDanhSachNhanVien.Rows[0].Cells[2].Value.ToString();
            txtCmnd.Text = dgvDanhSachNhanVien.Rows[0].Cells[4].Value.ToString();
            txtDiaChi.Text = dgvDanhSachNhanVien.Rows[0].Cells[5].Value.ToString();
            dateNgayVaoLam.Text = dgvDanhSachNhanVien.Rows[0].Cells[6].Value.ToString();
            txtTenDangNhap.Text = dgvDanhSachNhanVien.Rows[0].Cells[7].Value.ToString();
            txtMatKhau.Text = dgvDanhSachNhanVien.Rows[0].Cells[8].Value.ToString();
            if (Int32.Parse(dgvDanhSachNhanVien.Rows[0].Cells[3].Value.ToString()) == 1)
                rdbtnNam.Checked = true;
            else
                rdbtnNu.Checked = true;


        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            MoDK();
            SetNull();
            txtMaNhanVien.Text = nvBUS.TuTinhMa();
            Them = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnXoa.Enabled = false;
            MoDK();
            txtMaNhanVien.Enabled = false;
            Them = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn xóa nhân viên này ?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                nvDTO.MaNV = txtMaNhanVien.Text;
                nvBUS.XoadulieuNhanVien(nvDTO);
                dgvDanhSachNhanVien.DataSource = nvBUS.TaobangNhanVien("");
            }
            else
            { }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text != "" && txtCmnd.Text != "" && txtCmnd.Text != "" && txtMaNhanVien.Text != "" && txtMatKhau.Text != "" && dateNgaySinh.Text != "" && dateNgayVaoLam.Text != "")
            {
                if (DateTime.Now.Year - DateTime.Parse(dateNgaySinh.Text).Year < 18)
                {
                    MessageBox.Show("Nhân viên phải lớn hơn 18 tuổi", "Lỗi");
                }
                else
                {
                    nvDTO.MaNV = txtMaNhanVien.Text.ToString();
                    nvDTO.TenNV = txtHoTen.Text.ToString();
                    nvDTO.DiaChi = txtDiaChi.Text.ToString();
                    nvDTO.TenDN = txtTenDangNhap.Text.ToString();
                    nvDTO.MatKhau = txtMatKhau.Text.ToString();
                    nvDTO.CMND = Int32.Parse(txtCmnd.Text.ToString());
                    nvDTO.NgaySinh = Convert.ToDateTime(dateNgaySinh.Text.ToString());
                    nvDTO.NgayVL = Convert.ToDateTime(dateNgayVaoLam.Text.ToString());
                    if (rdbtnNu.Checked)
                        nvDTO.GioiTinh = 0;
                    else
                        nvDTO.GioiTinh = 1;

                    try
                    {
                        if (Them)
                        {
                            nvBUS.ThemdulieuNhanVien(nvDTO);
                        }
                        else
                        {
                            nvBUS.SuadulieuNhanVien(nvDTO);
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
                    dgvDanhSachNhanVien.DataSource = nvBUS.TaobangNhanVien("");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin nhân viên", "Lỗi");
            }
        }

        private void dgvDanhSachNhanVien_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaNhanVien.Text = dgvDanhSachNhanVien.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtHoTen.Text = dgvDanhSachNhanVien.Rows[e.RowIndex].Cells[1].Value.ToString();
                dateNgaySinh.Text = dgvDanhSachNhanVien.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtCmnd.Text = dgvDanhSachNhanVien.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtDiaChi.Text = dgvDanhSachNhanVien.Rows[e.RowIndex].Cells[5].Value.ToString();
                dateNgayVaoLam.Text = dgvDanhSachNhanVien.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtTenDangNhap.Text = dgvDanhSachNhanVien.Rows[e.RowIndex].Cells[7].Value.ToString();
                txtMatKhau.Text = dgvDanhSachNhanVien.Rows[e.RowIndex].Cells[8].Value.ToString();
                if (Int32.Parse(dgvDanhSachNhanVien.Rows[e.RowIndex].Cells[3].Value.ToString()) == 1)
                    rdbtnNam.Checked = true;
                else
                    rdbtnNu.Checked = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnThem.Enabled = true;
            }
            catch (Exception)
            {
            }
        }

        private void txtCmnd_KeyPress(object sender, KeyPressEventArgs e)
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