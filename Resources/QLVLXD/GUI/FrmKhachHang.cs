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
        DTO_KhachHang khDTO=new DTO_KhachHang();
        BUS_KhachHang khBUS=new BUS_KhachHang();
        Connection helper = new Connection();
        
        public FrmKhachHang()
        {
            InitializeComponent();
            
        }

        void KhoaDK()
        {
            txtMaKhachHang.Enabled = false;
            txtHoTen.Enabled = false;
            textDiaChi.Enabled = false;
            dtNgayCapThe.Enabled = false;
        }

        void MoDK()
        {
            txtMaKhachHang.Enabled = true;
            txtHoTen.Enabled = true;
            textDiaChi.Enabled = true;
            dtNgayCapThe.Enabled = true;
        }

        private void FrmKhachHang_Load(object sender, EventArgs e)
        {
            khBUS = new BUS_KhachHang();
            dgvDanhSachKhachHang.DataSource = khBUS.TaobangKhachHang("");
            KhoaDK();
            SetNull();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            MoDK();
            SetNull();
            Them = true;
        }

        void SetNull()
        {
            txtMaKhachHang.Text = "";
            txtHoTen.Text = "";
            textDiaChi.Text = "";
            dtNgayCapThe.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            MoDK();
            txtMaKhachHang.Enabled = false;
            Them = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            khDTO.MaKH = txtMaKhachHang.Text;
            khBUS.XoadulieuKhachHang(khDTO);
            dgvDanhSachKhachHang.DataSource = khBUS.TaobangKhachHang("");
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            khDTO.MaKH = txtMaKhachHang.Text.ToString();
            khDTO.HoTen = txtHoTen.Text.ToString();
            khDTO.DiaChi = textDiaChi.Text.ToString();
            khDTO.NgayCapThe = dtNgayCapThe.DateTime;
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

        private void dgvDanhSachKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaKhachHang.Text = dgvDanhSachKhachHang.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtHoTen.Text = dgvDanhSachKhachHang.Rows[e.RowIndex].Cells[1].Value.ToString();
                textDiaChi.Text = dgvDanhSachKhachHang.Rows[e.RowIndex].Cells[2].Value.ToString();
                dtNgayCapThe.Text = dgvDanhSachKhachHang.Rows[e.RowIndex].Cells[3].Value.ToString();
                btnLuu.Enabled = true;
            }
            catch (Exception)
            {
            }
        }
    }
}