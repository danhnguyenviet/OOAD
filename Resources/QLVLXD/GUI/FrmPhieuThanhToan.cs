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
    public partial class FrmPhieuThanhToan : DevExpress.XtraEditors.XtraForm
    {
        private BUS_BanHang _bus_BanHang;
        private BUS_ThanhToan _bus_ThanhToan;
        private DataTable _dsMaVaTenNv;
        private DataTable _dsHdChuaTtXong;
        private DataTable _dsPttHienTai;

        public FrmPhieuThanhToan()
        {
            InitializeComponent();
            this._bus_BanHang = new BUS_BanHang();
            this._bus_ThanhToan = new BUS_ThanhToan();

            // Load danh sách nhân viên
            this._dsMaVaTenNv = this._bus_BanHang.LayDsMaVaTenNv();
            foreach (DataRow row in this._dsMaVaTenNv.Rows)
            {
                this.cbTenNhanVien.Properties.Items.Add(row["TenNV"]);
            }

            // Load các hóa đơn chưa thanh toán xong
            this._dsHdChuaTtXong = this._bus_ThanhToan.LayDshdChuaTtXong();
            foreach (DataRow row in this._dsHdChuaTtXong.Rows)
            {
                this.cbMaHoaDon.Properties.Items.Add(row["MaHD"]);
            }

            this.dateNgayNop.Text = DateTime.Now.ToShortDateString();

            // Load tất cả các phiếu thanh toán lên datagridview
            int i = 1;
            this._dsPttHienTai = this._bus_ThanhToan.LayTatCaPtt();
            foreach (DataRow row in this._dsPttHienTai.Rows)
            {
                dgvPhieuThanhToan.Rows.Add(i, row["MaPhieuTT"], row["SoTienNop"], row["ThoiGianNop"], row["MaHD"], row["MaNV"]);
                i++;
            }
        }

        /**
         * Kiểm tra thông tin phiếu thanh toán
         */
        private bool PhieuThanhToanHopLe()
        {
            if (txtMaPhieuThanhToan.Text != "" && dateNgayNop.Text != "" && txtConNo.Text != "" &&
                cbTenNhanVien.Text != "" && cbMaHoaDon.Text != "" && txtSoTienNop.Text != "")
            {
                return true;
            }

            return false;
        }

        private bool CoTrongComboBox(ComboBoxEdit cbEdit)
        {
            if (cbEdit.Properties.Items.Contains(cbEdit.SelectedItem))
            {
                return true;
            }
            return false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn thoát?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void cbTenNhanVien_Leave(object sender, EventArgs e)
        {
            if (!this.CoTrongComboBox(this.cbTenNhanVien))
            {
                MessageBox.Show("Tên nhân viên không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.cbTenNhanVien.Focus();
            }
            else
            {
                int index = this.cbTenNhanVien.SelectedIndex;
                foreach (DataRow row in this._dsMaVaTenNv.Rows)
                {
                    if (index > 0)
                    {
                        index--;
                        continue;
                    }
                    else
                    {
                        this.lbMaNv.Text = row["MaNV"].ToString();
                        this.lbMaNv.Visible = true;
                        break;
                    }
                }
            }
        }

        private void cbMaHoaDon_Leave(object sender, EventArgs e)
        {
            if (!this.CoTrongComboBox(this.cbMaHoaDon))
            {
                MessageBox.Show("Mã hóa đơn không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.cbMaHoaDon.Focus();
            }
            else
            {
                foreach (DataRow row in this._dsHdChuaTtXong.Rows)
                {
                    if (row["MaHD"].ToString() == cbMaHoaDon.Text)
                    {
                        lbConNo.Text = txtConNo.Text = (Double.Parse(row["TongTien"].ToString()) - Double.Parse(row["SoTienNop"].ToString())).ToString();
                        break;
                    }
                    else
                    {
                        txtConNo.Text = lbConNo.Text = "";
                    }
                }
            }
        }

        private void txtSoTienNop_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                //if (Double.Parse(txtSoTienNop.Text) <= Double.Parse(lbConNo.Text))
                //{
                    txtConNo.Text = (Double.Parse(lbConNo.Text) - Double.Parse(txtSoTienNop.Text)).ToString();
                //}
                //else
                //{
                //    //MessageBox.Show("Số tiền trả không được lớn hơn tổng tiền!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    txtSoTienNop.Text = txtSoTienNop.Text.Remove(txtSoTienNop.Text.Length - 1, 1);
                //    txtSoTienNop.Refresh();
                //}

                if (txtSoTienNop.Text.Length > 9)
                {
                    txtSoTienNop.Text = txtSoTienNop.Text.Remove(txtSoTienNop.Text.Length - 1, 1);
                    txtSoTienNop.Refresh();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng kiểm tra thông tin hóa đơn hoặc số tiền nộp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtConNo.Text = lbConNo.Text;
                cbMaHoaDon.Focus();
            }
        }

        private bool TrungMaHd()
        {
            try
            {
                foreach (DataGridViewRow row in dgvPhieuThanhToan.Rows)
                {
                    if (txtMaPhieuThanhToan.Text.Equals(row.Cells[1].Value.ToString()))
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return true;
        }

        private void txtSoTienNop_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void cbMaHoaDon_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        public void ResetForm()
        {
            //cbTenNhanVien.Text = String.Empty;
            //cbMaHoaDon.Text = String.Empty;
            // Load các hóa đơn chưa thanh toán xong
            this.cbMaHoaDon.Properties.Items.Clear();
            this.cbMaHoaDon.Text = "";
            this._dsHdChuaTtXong = this._bus_ThanhToan.LayDshdChuaTtXong();
            foreach (DataRow row in this._dsHdChuaTtXong.Rows)
            {
                this.cbMaHoaDon.Properties.Items.Add(row["MaHD"]);
            }
            txtSoTienNop.Text = "0";
            txtConNo.Text = "0";
            dateNgayNop.Focus();
        }

        private void btnLuuPhieuThanhToan_Click(object sender, EventArgs e)
        {
            if (!TrungMaHd())
            {
                if (PhieuThanhToanHopLe())
                {
                    if (Double.Parse(txtSoTienNop.Text) <= Double.Parse(lbConNo.Text))
                    {
                        DTO_PhieuThanhToan ptt = new DTO_PhieuThanhToan(txtMaPhieuThanhToan.Text, txtSoTienNop.Text,
                        DateTime.Parse(dateNgayNop.Text), cbMaHoaDon.Text, lbMaNv.Text);
                        this._bus_ThanhToan.LuuPhieuThanhToan(ptt);

                        MessageBox.Show("Lưu thành công!", "Thông báo");

                        ResetForm();
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng kiểm tra số tiền nộp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtSoTienNop.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Phiếu thanh toán không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dateNgayNop.Focus();
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn muốn tạo mới phiếu thanh toán!", "Thông báo", 
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    txtMaPhieuThanhToan.Enabled = true;
                    dateNgayNop.Enabled = true;
                    cbTenNhanVien.Enabled = true;
                    txtMaPhieuThanhToan.Enabled = true;
                    cbMaHoaDon.Enabled = true;
                    txtSoTienNop.Enabled = true;
                    lbMaNv.Visible = false;
                    ResetForm();
                }
            }
        }

        private void dgvPhieuThanhToan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaPhieuThanhToan.Enabled = false;
            dateNgayNop.Enabled = false;
            cbTenNhanVien.Enabled = false;
            txtMaPhieuThanhToan.Enabled = false;
            cbMaHoaDon.Enabled = false;
            txtSoTienNop.Enabled = false;

            int rowIndex = dgvPhieuThanhToan.CurrentCell.RowIndex;
            txtMaPhieuThanhToan.Text = dgvPhieuThanhToan.Rows[rowIndex].Cells[1].Value.ToString();
            dateNgayNop.Text = dgvPhieuThanhToan.Rows[rowIndex].Cells[3].Value.ToString();
            cbMaHoaDon.Text = dgvPhieuThanhToan.Rows[rowIndex].Cells[4].Value.ToString();
            lbMaNv.Text = dgvPhieuThanhToan.Rows[rowIndex].Cells[5].Value.ToString();
            lbMaNv.Visible = true;
            lbConNo.Text = "0";
            txtSoTienNop.Text = dgvPhieuThanhToan.Rows[rowIndex].Cells[2].Value.ToString();

            foreach (DataRow row in this._dsMaVaTenNv.Rows)
            {
                if (row["MaNV"].ToString() == lbMaNv.Text)
                {
                    cbTenNhanVien.Text = row["TenNV"].ToString();
                    break;
                }
            }

            this._dsHdChuaTtXong = this._bus_ThanhToan.LayDshdChuaTtXong();
            foreach (DataRow row in this._dsHdChuaTtXong.Rows)
            {
                if (row["MaHD"].ToString() == cbMaHoaDon.Text)
                {
                    lbConNo.Text = txtConNo.Text = (Double.Parse(row["TongTien"].ToString()) - Double.Parse(row["SoTienNop"].ToString())).ToString();
                }
                else
                {
                    lbConNo.Text = txtConNo.Text = "0";
                }
            }
        }
    }
}