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
    public partial class FrmPhieuNhap : DevExpress.XtraEditors.XtraForm
    {
        bool Them=true;

        BUS_PhieuNhapHang PhieuNhapBUS = new BUS_PhieuNhapHang();
        BUS_NhaCC NhaCungCap = new BUS_NhaCC();
        BUS_NhanVien NhanVien = new BUS_NhanVien();
        BUS_CTPhieuNhap ctphieunhapBUS = new BUS_CTPhieuNhap();
        BUS_MatHang mathangBUS = new BUS_MatHang();
        
        DAL_LoHang LoHang = new DAL_LoHang();

        DTO_LoHang lohangDTO = new DTO_LoHang();
        DTO_PhieuNhapHang phieunhapDTO = new DTO_PhieuNhapHang();
        DTO_CTPhieuNhap ctphieunhapDTO = new DTO_CTPhieuNhap();

        Connection help = new Connection();

        BindingList<DTO_LoHang> listlohangs = new BindingList<DTO_LoHang>();
        public FrmPhieuNhap()
        {
            InitializeComponent();
            //Init Thoi gian lập 
            dateThoiGianLap.DateTime = DateTime.Now;
            //listlohangs = new BindingList<DTO_LoHang>();
        }

        BindingList<DTO_PhieuNhapHang> LoadPhieuNhap()
        {
            DataTable tablePN = new DataTable();
            BindingList<DTO_PhieuNhapHang> listPNs = new BindingList<DTO_PhieuNhapHang>();
            
            tablePN = PhieuNhapBUS.TaobangPhieuNhapHang("");
            foreach (DataRow PN in tablePN.Rows)
            {
                DTO_PhieuNhapHang phieunhap = new DTO_PhieuNhapHang();
                phieunhap.MaPN = PN[0].ToString();
                phieunhap.MaNV = PN[1].ToString();
                phieunhap.MaNCC = PN[2].ToString();
                phieunhap.ThoiGianLap =DateTime.Parse(PN[3].ToString());
                phieunhap.TenNV = NhanVien.TaobangNhanVien("where MaNV='" + phieunhap.MaNV+"'").Rows[0][1].ToString();
                phieunhap.TenNCC = NhaCungCap.TaobangNhaCC("where MaNCC='" + phieunhap.MaNCC+"'").Rows[0][1].ToString();

                listPNs.Add(phieunhap);
            }

            return listPNs;
        }

        private void FrmPhieuNhap_Load(object sender, EventArgs e)
        {
            //load danh sách tất cả các phiếu nhập
            dgvDanhSachPhieuNhap.DataSource = LoadPhieuNhap();

            

            //load data combobox nhân viên
            cboNhanVien.DataSource = NhanVien.TaobangNhanVien("");
            cboNhanVien.DisplayMember = "TenNV";
            cboNhanVien.ValueMember = "MaNV";
            cboNhanVien.ResetText();
            //load data combobox nhà cung cấp
            cboNhaCungCap.DataSource = NhaCungCap.TaobangNhaCC("");
            cboNhaCungCap.DisplayMember = "TenNCC";
            cboNhaCungCap.ValueMember = "MaNCC";
            cboNhaCungCap.ResetText();
            //load data combobox mặt hàng
            cboMatHang.DataSource = mathangBUS.TaobangMatHang("");
            cboMatHang.DisplayMember = "TenMH";
            cboMatHang.ValueMember = "MaMH";
            cboMatHang.ResetText();

            dgvDanhSachLoHang.DataSource = listlohangs;
        }

        void KhoaDK()
        {
            txtMaPN.Enabled = false;
            cboNhanVien.Enabled = false;
            cboNhaCungCap.Enabled = false;
            dateThoiGianLap.Enabled = false;
            txtMaLH.Enabled = false;
            cboMatHang.Enabled = false;
            dateNgaySX.Enabled = false;
            txtHanSD.Enabled = false;
            txtSLNhap.Enabled = false;
            txtSLBan.Enabled = false;
            txtGiaBan.Enabled = false;
            txtGiaNhap.Enabled = false;
            //dgvDanhSachLoHang.Enabled = false;
            btnThemLH.Enabled = false;
        }
        void MoDK()
        {
            txtMaPN.Enabled = true;
            cboNhanVien.Enabled = true;
            cboNhaCungCap.Enabled = true;
            dateThoiGianLap.Enabled = true;
            txtMaLH.Enabled = true;
            cboMatHang.Enabled = true;
            dateNgaySX.Enabled = true;
            txtHanSD.Enabled = true;
            txtSLNhap.Enabled = true;
            txtSLBan.Enabled = true;
            txtGiaBan.Enabled = true;
            txtGiaNhap.Enabled = true;
            dgvDanhSachLoHang.Enabled = true;
            btnThemLH.Enabled = true;
        }

        void SetNull()
        {
            txtMaPN.Text = "";
            cboNhanVien.Text = "";
            cboNhaCungCap.Text = "";
            dateThoiGianLap.DateTime = DateTime.Now;
            txtMaLH.Text = "";
            cboMatHang.Text = "";
            dateNgaySX.Text = "";
            txtHanSD.Text = "";
            txtSLNhap.Text = "";
            txtSLBan.Text = "";
            txtGiaBan.Text = "";
            txtGiaNhap.Text = "";
            //listlohangs = null;       
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Them)
            {
                //Thêm phiếu nhập
                phieunhapDTO.MaPN = txtMaPN.Text;
                phieunhapDTO.MaNV = cboNhanVien.SelectedValue.ToString();
                phieunhapDTO.MaNCC = cboNhaCungCap.SelectedValue.ToString();
                phieunhapDTO.ThoiGianLap = dateThoiGianLap.DateTime;

                PhieuNhapBUS.ThemdulieuPhieuNhapHang(phieunhapDTO);
                //Chi tiết phiếu nhập
                foreach (var item in listlohangs)
                {
                    //Thêm lo hàng
                    LoHang.InsertLoHang(item);
                    //Thêm chi tiết phiếu
                    ctphieunhapDTO.MaPN = phieunhapDTO.MaPN;
                    ctphieunhapDTO.MaLH = item.MaLh;

                    ctphieunhapBUS.ThemdulieuCTPhieuNhapHang(ctphieunhapDTO);
                }
                btnThem.Enabled = true;
                dgvDanhSachPhieuNhap.DataSource= LoadPhieuNhap();
                KhoaDK();
            }
            else
            {
                //Sửa phiếu nhập
                phieunhapDTO.MaPN = txtMaPN.Text;
                phieunhapDTO.MaNV = cboNhanVien.SelectedValue.ToString();
                phieunhapDTO.MaNCC = cboNhaCungCap.SelectedValue.ToString();
                phieunhapDTO.ThoiGianLap = dateThoiGianLap.DateTime;

                PhieuNhapBUS.SuadulieuPhieuNhapHang(phieunhapDTO);
                //Xóa chi tiết phiếu nhập với mã phiếu nhập
                ctphieunhapBUS.XoadulieuCTPhieuNhapHang(txtMaPN.Text);
                //Xóa những lô hàng ứng với mã phiếu nhập 
                foreach (var item in listlohangs)
                {
                    LoHang.DeleteLoHang(item.MaLh);
                }
                
                //Chi tiết phiếu nhập
                foreach (var item in listlohangs)
                {
                    //Thêm lo hàng
                    LoHang.InsertLoHang(item);
                    //Thêm chi tiết phiếu
                    ctphieunhapDTO.MaPN = phieunhapDTO.MaPN;
                    ctphieunhapDTO.MaLH = item.MaLh;

                    ctphieunhapBUS.ThemdulieuCTPhieuNhapHang(ctphieunhapDTO);
                }
                btnThem.Enabled = true;
                dgvDanhSachPhieuNhap.DataSource = LoadPhieuNhap();
                KhoaDK();
                //SetNull();
            }
        }

        private void dgvDanhSachLoHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtGiaBan.Text = dgvDanhSachLoHang.Rows[e.RowIndex].Cells["giaban"].Value.ToString();
                txtGiaNhap.Text = dgvDanhSachLoHang.Rows[e.RowIndex].Cells["gianhap"].Value.ToString();
                txtHanSD.Text = dgvDanhSachLoHang.Rows[e.RowIndex].Cells["hansd"].Value.ToString();
                txtMaLH.Text = dgvDanhSachLoHang.Rows[e.RowIndex].Cells["malh"].Value.ToString();
                txtSLBan.Text = dgvDanhSachLoHang.Rows[e.RowIndex].Cells["slban"].Value.ToString();
                dateNgaySX.DateTime =DateTime.Parse(dgvDanhSachLoHang.Rows[e.RowIndex].Cells["ngaysx"].Value.ToString());
                txtSLNhap.Text = dgvDanhSachLoHang.Rows[e.RowIndex].Cells["slnhap"].Value.ToString();
                cboMatHang.Text = dgvDanhSachLoHang.Rows[e.RowIndex].Cells["tenmh"].Value.ToString();
                
            }
            catch (Exception)
            {
            }
        }


        private void btnThemLH_Click(object sender, EventArgs e)
        {
            
            DTO_LoHang itemlohang = new DTO_LoHang();
            itemlohang.GiaBan = txtGiaBan.Text;
            itemlohang.GiaNhap = txtGiaNhap.Text;
            itemlohang.HanSd = txtHanSD.Text;
            itemlohang.MaLh = txtMaLH.Text;
            itemlohang.SlBan = txtSLBan.Text;
            itemlohang.NgaySx = dateNgaySX.DateTime;
            itemlohang.SlNhap = txtSLNhap.Text;
            itemlohang.MaMh = cboMatHang.SelectedValue.ToString();
            itemlohang.TenMH = cboMatHang.Text;

            listlohangs.Add(itemlohang);
            //dgvDanhSachLoHang.DataSource = listlohangs;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //
            listlohangs.Clear();
            dgvDanhSachLoHang.DataSource = listlohangs;
            Them = true;
            MoDK();
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            txtMaPN.Enabled = true;
        
            SetNull();
            txtMaPN.Text = help.SearchDaTaGrid("PN", "PhieuNhap", "MaPN");
            txtMaLH.Text = help.SearchDaTaGrid("LH", "LoHang", "MaLH");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            txtMaPN.Enabled = false;
            MoDK();
            Them = false;
        }

        void SetNullchitiet()
        {
            txtMaLH.Text = "";
            cboMatHang.Text = "";
            dateNgaySX.Text = "";
            txtHanSD.Text = "";
            txtSLNhap.Text = "";
            txtSLBan.Text = "";
            txtGiaBan.Text = "";
            txtGiaNhap.Text = "";
        }

        private void dgvDanhSachPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                BindingList<DTO_LoHang> listlohangsPN = new BindingList<DTO_LoHang>();
                //Load phiếu nhập
                txtMaPN.Text = dgvDanhSachPhieuNhap.Rows[e.RowIndex].Cells[0].Value.ToString();
                cboNhanVien.Text = dgvDanhSachPhieuNhap.Rows[e.RowIndex].Cells[4].Value.ToString();
                cboNhaCungCap.Text = dgvDanhSachPhieuNhap.Rows[e.RowIndex].Cells[5].Value.ToString();
                dateThoiGianLap.DateTime = DateTime.Parse(dgvDanhSachPhieuNhap.Rows[e.RowIndex].Cells[2].Value.ToString());
                //Load chi tiết phiếu nhập
                DataTable tableMaLH = new DataTable();
                List<DataTable> listTableLoHang = new List<DataTable>();
                //lấy tất cả mã lô hàng với mã phiếu nhập cần tìm
                tableMaLH = help.GetDataTable("Select MaLH from ChiTietPhieuNhap where MaPN='" + txtMaPN.Text + "'");
                //Tạo bảng lô hàng với những phiếu nhập đó
                foreach (DataRow item in tableMaLH.Rows)
                {
                    DataTable tableLoHang = new DataTable();
                    tableLoHang = help.GetDataTable("Select * from LoHang where MaLH='" + item[0].ToString() + "'");
                    listTableLoHang.Add(tableLoHang);
                }
                //Thêm vào list lô hàng
                foreach (DataTable dt in listTableLoHang)
                {
                    DTO_LoHang itemlohang = new DTO_LoHang();
                    itemlohang.MaLh = dt.Rows[0][0].ToString();
                    itemlohang.MaMh = dt.Rows[0][1].ToString();
                    itemlohang.NgaySx =DateTime.Parse(dt.Rows[0][2].ToString());
                    itemlohang.HanSd = dt.Rows[0][3].ToString();
                    itemlohang.SlNhap = dt.Rows[0][4].ToString();
                    itemlohang.SlBan = dt.Rows[0][5].ToString();
                    itemlohang.GiaNhap = dt.Rows[0][6].ToString();
                    itemlohang.GiaBan = dt.Rows[0][7].ToString();
                    itemlohang.TenMH = mathangBUS.TaobangMatHang("where MaMH='" + itemlohang.MaMh + "'").Rows[0][1].ToString();

                    listlohangsPN.Add(itemlohang);             
                }
                dgvDanhSachLoHang.DataSource = listlohangsPN;
                //dgvDanhSachLoHang.
                //Xóa list lô hàng về null
                //listlohangs = null;
                listlohangs = listlohangsPN;
                btnLuu.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnThem.Enabled = true;
                KhoaDK();
                SetNullchitiet();
            }
            catch (Exception)
            {

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn xóa phiếu nhập này ?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                phieunhapDTO.MaPN = txtMaPN.Text;
                try
                {
                    PhieuNhapBUS.XoadulieuPhieuNhapHang(phieunhapDTO);
                }
                catch (Exception ex)
                {
                    DialogResult dialogloi = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                }                
                dgvDanhSachPhieuNhap.DataSource= LoadPhieuNhap();
            }
            else
            { }
        }

        private void txtHanSD_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtSLNhap_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtGiaNhap_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtSLBan_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtGiaBan_KeyPress(object sender, KeyPressEventArgs e)
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