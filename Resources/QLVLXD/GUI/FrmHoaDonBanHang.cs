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
    public partial class FrmHoaDonBanHang : DevExpress.XtraEditors.XtraForm
    {
        private BUS_BanHang _bus_BanHang;
        private DataTable _dsMaVaTenNv;
        private DataTable _dsMaVaTenKh;
        private DataTable _dsMaVaTenMatHang;
        private DataTable _dsHdbh;
        private DataTable _dsCthd;

        public FrmHoaDonBanHang()
        {
            InitializeComponent();
            this._bus_BanHang = new BUS_BanHang();

            // Load danh sách nhân viên
            this._dsMaVaTenNv = this._bus_BanHang.LayDsMaVaTenNv();
            foreach (DataRow row in this._dsMaVaTenNv.Rows)
            {
                this.cbTenNvbh.Properties.Items.Add(row["TenNV"]);
            }

            // Load danh sách khách hàng
            this._dsMaVaTenKh = this._bus_BanHang.LayDsMaVaTenKh();
            foreach (DataRow row in this._dsMaVaTenKh.Rows)
            {
                this.cbTenKhachHang.Properties.Items.Add(row["HoTen"]);
            }

            // Load danh sách mặt hàng đang bán
            this._dsMaVaTenMatHang = this._bus_BanHang.LayDsHangTonHienTai();
            foreach (DataRow row in this._dsMaVaTenMatHang.Rows)
            {
                this.cbTenMatHang.Properties.Items.Add(row["TenMH"]);
            }

            this.dateNgayLap.Text = DateTime.Now.ToShortDateString();

            // Load tất cả các hóa đơn bán hàng
            int i = 1;
            this._dsHdbh = this._bus_BanHang.LayTatCaHdbh();
            foreach (DataRow row in this._dsHdbh.Rows)
            {
                this.dgvDsHdbh.Rows.Add(i, row["MaHD"], row["MaNV"], row["MaKH"], row["ThoiGianLap"], row["TongTien"]);
                i++;
            }
        }

        private bool TrungCthd()
        {
            try
            {
                foreach (DataGridViewRow row in dgvDanhSachMatHang.Rows)
                {
                    if (cbTenMatHang.Text.Equals(row.Cells[1].Value.ToString()))
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

        private bool CoTrongComboBox(ComboBoxEdit cbEdit)
        {
            if (cbEdit.Properties.Items.Contains(cbEdit.SelectedItem))
            {
                return true;
            }
            return false;
        }

        /**
         * Kiểm tra thông tin phiếu nhập
         */
        private bool ThongTinPhieuNhapHopLe()
        {
            if (cbTenNvbh.Text.Equals("") && cbTenKhachHang.Text.Equals(""))
            {
                return false;
            }

            return true;
        }

        /**
         * Kiểm tra thông tin chi tiết hóa đơn
         */
        private bool ChiTietHdHopLe()
        {
            if (dgvDanhSachMatHang.RowCount != 0)
            {
                if (dgvDanhSachMatHang.Rows[0].Cells[0].ToString().Equals(""))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

            if (cbTenMatHang.Text != "" && txtSoLuongBan.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        /**
         * Kiểm tra thông tin hóa đơn bán hàng
         */
        private bool HoaDonBanHangHopLe()
        {
            if (txtTraTruoc.Text.Equals(""))
            {
                return false;
            }
            else
            {
                if (ThongTinPhieuNhapHopLe() && ChiTietHdHopLe())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn thoát?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (HoaDonBanHangHopLe())
            {
                DTO_HDBanHang hdBanHang = new DTO_HDBanHang(txtMaHoaDon.Text, lbMaNvbh.Text, lbMaKh.Text,
                DateTime.Parse(dateNgayLap.Text), txtTongTien.Text);
                this._bus_BanHang.LuuHdBanHang(hdBanHang);

                //List<DTO_CTHoaDon> dsCtHoaDon = new List<DTO_CTHoaDon>();

                int i = 0;

                //List<string> dsMaLh = this._bus_BanHang.LayDsLoHangDuocBan();
                foreach (DataGridViewRow row in dgvDanhSachMatHang.Rows)
                {
                    this._bus_BanHang.CapNhatThongTinLoHangVaCthd(row.Cells[5].Value.ToString(),
                        row.Cells[2].Value.ToString(), txtMaHoaDon.Text);
                    //dsCtHoaDon.Add(ctHoaDon);
                }

                // Hard code
                DTO_PhieuThanhToan phieuThanhToan = new DTO_PhieuThanhToan(i.ToString(), txtTraTruoc.Text,
                    DateTime.Parse(dateNgayLap.Text), txtMaHoaDon.Text, lbMaNvbh.Text);
                this._bus_BanHang.LuuPhieuThanhToan(phieuThanhToan);

                MessageBox.Show("Lưu thành công!", "Thông báo");

                ResetForm();
            }
            else
            {
                MessageBox.Show("Hóa đơn không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dateNgayLap.Focus();
            }
        }

        private void ResetForm()
        {
            // RS mã hóa đơn

            //cbTenNvbh.Text = String.Empty;
            //cbTenKhachHang.Text = String.Empty;
            //cbTenMatHang.Text = String.Empty;
            //txtSoLuongBan.Text = String.Empty;

            while (dgvDanhSachMatHang.Rows.Count != 0)
            {
                dgvDanhSachMatHang.Rows.RemoveAt(0);
            }

            txtTongTien.Text = String.Empty;
            txtTraTruoc.Text = String.Empty;
            txtConNo.Text = String.Empty;

            dateNgayLap.Focus();
        }

        private void cbTenNvbh_Properties_Leave(object sender, EventArgs e)
        {
            if (!this.CoTrongComboBox(this.cbTenNvbh))
            {
                MessageBox.Show("Tên nhân viên bán hàng không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.cbTenNvbh.Focus();
            }
            else
            {
                int index = this.cbTenNvbh.SelectedIndex;
                foreach (DataRow row in this._dsMaVaTenNv.Rows)
                {
                    if (index > 0)
                    {
                        index--;
                        continue;
                    }
                    else
                    {
                        this.lbMaNvbh.Text = row["MaNV"].ToString();
                        this.lbMaNvbh.Visible = true;
                        break;
                    }
                }
            }
        }

        private void cbTenKhachHang_Leave(object sender, EventArgs e)
        {
            if (!this.CoTrongComboBox(this.cbTenKhachHang))
            {
                MessageBox.Show("Tên khách hàng không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.cbTenKhachHang.Focus();
            }
            else
            {
                int index = this.cbTenKhachHang.SelectedIndex;
                foreach (DataRow row in this._dsMaVaTenKh.Rows)
                {
                    if (index > 0)
                    {
                        index--;
                        continue;
                    }
                    else
                    {
                        this.lbMaKh.Text = row["MaKH"].ToString();
                        this.lbMaKh.Visible = true;
                        break;
                    }
                }
            }
        }

        private void cbTenMatHang_Leave(object sender, EventArgs e)
        {
            if (!this.CoTrongComboBox(this.cbTenMatHang))
            {
                MessageBox.Show("Tên mặt hàng không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.cbTenMatHang.Focus();
            }
            else
            {
                int index = this.cbTenMatHang.SelectedIndex;
                foreach (DataRow row in this._dsMaVaTenMatHang.Rows)
                {
                    if (index > 0)
                    {
                        index--;
                        continue;
                    }
                    else
                    {
                        this.lbMaMh.Text = row["MaMH"].ToString();
                        this.lbMaMh.Visible = true;
                        break;
                    }
                }
            }
        }

        private void txtSoLuongBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtSoLuongBan_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoLuongBan_EditValueChanged(object sender, EventArgs e)
        {
            if (txtSoLuongBan.Text.Length > 6)
            {
                txtSoLuongBan.Text = txtSoLuongBan.Text.Remove(txtSoLuongBan.Text.Length - 1, 1);
                txtSoLuongBan.Refresh();
            }
        }

        private int _stt = 0;
        private void btnThemMatHang_Click(object sender, EventArgs e)
        {
            if (!TrungCthd())
            {
                if (ChiTietHdHopLe())
                {
                    if (txtSoLuongBan.Text != "")
                    {
                        if (this._bus_BanHang.SoLuongBanHopLe(cbTenMatHang.Text, Int32.Parse(txtSoLuongBan.Text)))
                        {
                            double giaBan = Double.Parse(this._bus_BanHang.LayGiaBan(this.cbTenMatHang.Text));
                            dgvDanhSachMatHang.Rows.Add(this._stt + 1, this.cbTenMatHang.Text, this.txtSoLuongBan.Text, giaBan, giaBan * Double.Parse(txtSoLuongBan.Text), lbMaMh.Text);

                            this._stt++;

                            double tongTien = 0;
                            foreach (DataGridViewRow row in dgvDanhSachMatHang.Rows)
                            {
                                tongTien += Double.Parse(row.Cells[4].Value.ToString());
                            }

                            txtTongTien.Text = txtConNo.Text = tongTien.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Số lượng bán quá lớn hoặc hàng đã hết!\n Vui lòng kiểm tra lại!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtSoLuongBan.Focus();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Chi tiết hóa đơn không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cbTenMatHang.Focus();
                }
            }
            else
            {
                MessageBox.Show("Mặt hàng đã có trong danh sách", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbTenMatHang.Focus();
            }
        }

        private void dgvDanhSachMatHang_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            foreach (DataGridViewCell oneCell in dgvDanhSachMatHang.SelectedCells)
            {
                if (oneCell.Selected)
                {
                    dgvDanhSachMatHang.Rows.RemoveAt(oneCell.RowIndex);
                    this._stt--;
                }
            }
            int i = 1;
            foreach (DataGridViewRow row in dgvDanhSachMatHang.Rows)
            {
                row.Cells[0].Value = i;
                i++;
            }
        }

        private void txtTraTruoc_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                //if (Double.Parse(txtTraTruoc.Text) <= Double.Parse(txtTongTien.Text))
                //{
                txtConNo.Text = (Double.Parse(txtTongTien.Text) - Double.Parse(txtTraTruoc.Text)).ToString();
                //}
                //else
                //{
                //    //MessageBox.Show("Số tiền trả không được lớn hơn tổng tiền!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    txtTraTruoc.Text = txtTraTruoc.Text.Remove(txtTraTruoc.Text.Length - 1, 1);
                //    txtTraTruoc.Refresh();
                //}

                if (txtTraTruoc.Text.Length > 9)
                {
                    txtTraTruoc.Text = txtTraTruoc.Text.Remove(txtTraTruoc.Text.Length - 1, 1);
                    txtTraTruoc.Refresh();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Chưa có thông tin mặt hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbTenMatHang.Focus();
            }
        }

        private void txtTraTruoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void dgvDsHdbh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dateNgayLap.Enabled = false;
            cbTenNvbh.Enabled = false;
            cbTenMatHang.Enabled = false;
            txtTraTruoc.Enabled = false;
            txtTraTruoc.Text = "0";
            txtConNo.Text = "0";

            int rowIndex = dgvDsHdbh.CurrentCell.RowIndex;
            txtMaHoaDon.Text = dgvDsHdbh.Rows[rowIndex].Cells[1].Value.ToString();
            dateNgayLap.Text = DateTime.Now.ToShortDateString();
            txtTongTien.Text = dgvDsHdbh.Rows[rowIndex].Cells[5].Value.ToString();

            foreach (DataRow row in this._dsMaVaTenNv.Rows)
            {
                if (row["MaNV"].ToString() == dgvDsHdbh.Rows[rowIndex].Cells[2].Value.ToString())
                {
                    cbTenNvbh.Text = row["TenNV"].ToString();
                }
            }

            foreach (DataRow row in this._dsMaVaTenKh.Rows)
            {
                if (row["MaKH"].ToString() == dgvDsHdbh.Rows[rowIndex].Cells[3].Value.ToString())
                {
                    cbTenKhachHang.Text = row["HoTen"].ToString();
                }
            }

            dgvDanhSachMatHang.Rows.Clear();
            this._dsCthd = this._bus_BanHang.LayCthdbhTheoMa(dgvDsHdbh.Rows[rowIndex].Cells[1].Value.ToString());
            int i = 1;
            foreach (DataRow row in this._dsCthd.Rows)
            {
                string tenMh = this._bus_BanHang.LayTenMatHangTheoMaLh(row["MaLH"].ToString());
                string giaBan = this._bus_BanHang.LayGiaBan(tenMh);

                dgvDanhSachMatHang.Rows.Add(i, tenMh, row["SLBan"], giaBan,
                    Double.Parse(giaBan) * Double.Parse(row["SLBan"].ToString()));
                i++;
            }

            

        }

    }
}