using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DAL;
using DTO;
namespace GUI_QLVLXD
{
    public partial class FrmMatHang : Form
    {
        bool Them;

        BUS_DonViTinh donvitinhBUS = new BUS_DonViTinh();
        BUS_NhaCC nhacungcapBUS = new BUS_NhaCC();
        BUS_MatHang mathangBUS = new BUS_MatHang();

        DTO_MatHang mathangDTO = new DTO_MatHang();

        BindingList<DTO_MatHang> listmathangs = new BindingList<DTO_MatHang>(); 

        Connection help = new Connection();

        public FrmMatHang()
        {
            InitializeComponent();
        }

        BindingList<DTO_MatHang> LoadMatHang()
        {
            DataTable tableMH = new DataTable();
            BindingList<DTO_MatHang> listMHs = new BindingList<DTO_MatHang>();

            tableMH = mathangBUS.TaobangMatHang("");
            foreach (DataRow MH in tableMH.Rows)
            {
                DTO_MatHang mathang = new DTO_MatHang();
                mathang.MaMH = MH[0].ToString();
                mathang.TenMH = MH[1].ToString();
                mathang.TenNSX = MH[2].ToString();
                mathang.MaDVT = MH[3].ToString();
                mathang.ThueVAT =float.Parse(MH[4].ToString());

                mathang.NhaSX = nhacungcapBUS.TaobangNhaCC("where MaNCC='" + mathang.TenNSX + "'").Rows[0][1].ToString();
                mathang.DonViTinh = donvitinhBUS.TaobangDonViTinh("where MaDVT='" + mathang.MaDVT + "'").Rows[0][1].ToString();

                listMHs.Add(mathang);
            }
            return listMHs;
        }

        void KhoiTao()
        {
            //load đơn vị tính
            cboDVT.DataSource = donvitinhBUS.TaobangDonViTinh("");
            cboDVT.DisplayMember = "TenDVT";
            cboDVT.ValueMember = "MaDVT";
            //load nhà sản xuất
            cboNhaSX.DataSource = nhacungcapBUS.TaobangNhaCC("");
            cboNhaSX.DisplayMember = "TenNCC";
            cboNhaSX.ValueMember = "MaNCC";
            //load datagridview
            dgvDanhSachMatHang.DataSource = LoadMatHang();
        }

        private void FrmMatHang_Load(object sender, EventArgs e)
        {
            KhoiTao();
        }

        void Khoa()
        {
            txtMaMH.Enabled = false;
            txtTenMH.Enabled = false;
            txtThue.Enabled = false;
            cboDVT.Enabled = false;
            cboNhaSX.Enabled = false;
        }
        void MoDK()
        {
            txtMaMH.Enabled = true;
            txtTenMH.Enabled = true;
            txtThue.Enabled = true;
            cboDVT.Enabled = true;
            cboNhaSX.Enabled = true;
        }
        void SetNull()
        {
            txtMaMH.Text = "";
            txtTenMH.Text = "";
            txtThue.Text = "";
            cboDVT.Text = "";
            cboNhaSX.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            MoDK();
            SetNull();
            txtMaMH.Text = help.SearchDaTaGrid("MH", "MatHang", "MaMH");
            Them = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnXoa.Enabled = false;
            MoDK();
            txtMaMH.Enabled = false;
            Them = false;       
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtThue.Text != "" && txtTenMH.Text != "" && txtMaMH.Text != "" && cboDVT.Text != "" && cboNhaSX.Text != "" )
            {
                mathangDTO.MaMH = txtMaMH.Text;
                mathangDTO.TenMH = txtTenMH.Text;
                mathangDTO.MaDVT = cboDVT.SelectedValue.ToString();
                mathangDTO.TenNSX = cboNhaSX.SelectedValue.ToString();
                mathangDTO.ThueVAT = float.Parse(txtThue.Text);
                try
                {
                    if (Them)
                    {
                        try
                        {
                            mathangBUS.ThemdulieuMatHang(mathangDTO);
                        }
                        catch (Exception ex)
                        {
                            DialogResult dialogloi = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                        }
                       
                    }
                    else
                    {
                        try
                        {
                            mathangBUS.SuadulieuMatHang(mathangDTO);
                        }
                        catch (Exception ex)
                        {
                            DialogResult dialogloi = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                        }
                       
                    }
                }
                catch (Exception)
                {
                }

                Khoa();
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnThem.Enabled = true;
                btnLuu.Enabled = false;
                KhoiTao();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin mặt hàng", "Lỗi");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn xóa mặt hàng này ?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                mathangDTO.MaMH = txtMaMH.Text;
                try
                {
                    mathangBUS.XoadulieuMatHang(mathangDTO);
                }
                catch (Exception ex)
                {
                    DialogResult dialogloi = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                }
                
                KhoiTao();
            }
            else
            { }
        }

        private void dgvDanhSachMatHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaMH.Text = dgvDanhSachMatHang.Rows[e.RowIndex].Cells["Column1"].Value.ToString();
                txtTenMH.Text = dgvDanhSachMatHang.Rows[e.RowIndex].Cells["Column2"].Value.ToString();
                cboDVT.Text = dgvDanhSachMatHang.Rows[e.RowIndex].Cells["Column7"].Value.ToString();
                cboNhaSX.Text = dgvDanhSachMatHang.Rows[e.RowIndex].Cells["Column6"].Value.ToString();
                txtThue.Text = dgvDanhSachMatHang.Rows[e.RowIndex].Cells["Column5"].Value.ToString();
               
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnThem.Enabled = true;
            }
            catch (Exception)
            {
            }
            Khoa();
        }
    }
}
