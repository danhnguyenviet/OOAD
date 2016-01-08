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
using System.Configuration;
using BUS;
using DTO;


namespace GUI_QLVLXD
{
    public partial class frmInfosql : Form
    {
        BUS_Infosql bus_thongtincaidat = new BUS_Infosql();
        DTO_Infosql dto_thongtincaidat = new DTO_Infosql();
        public frmInfosql()
        {
            InitializeComponent();
        }

        public void LayThongTinCaiDat()
        {
            dto_thongtincaidat.TenServer = Server.Text;
            dto_thongtincaidat.TenCoSoDuLieu = data.Text;
            dto_thongtincaidat.TenDangNhap = use.Text;
            dto_thongtincaidat.MatKhau = pass.Text;
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            LayThongTinCaiDat();
            bool HoanThanh;
            if (rdBtnSuaCSDL.Checked)
            {
                if (checkBoxLogin.Checked)
                    HoanThanh = bus_thongtincaidat.XayDungCoSoDuLieuMoi(dto_thongtincaidat, true, true);
                else
                    HoanThanh = bus_thongtincaidat.XayDungCoSoDuLieuMoi(dto_thongtincaidat, true, false);  
            }
            else
            {
                    if (checkBoxLogin.Checked)
                        HoanThanh = bus_thongtincaidat.XayDungCoSoDuLieuMoi(dto_thongtincaidat, false, true);
                    else
                        HoanThanh = bus_thongtincaidat.XayDungCoSoDuLieuMoi(dto_thongtincaidat, false, false);
            }
        
            if (HoanThanh)
            {
                Close();
                DialogResult rs = MessageBox.Show("Đã lưu thông tin cơ sở dữ liệu thành công \n Nhấn ok để khởi động lại phần mềm", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if(rs == DialogResult.OK)
                    Application.Restart();
                
            }
            else
                MessageBox.Show("Không Thể Lưu Cài Đặt Mới.\nKiểm Tra Lại Thông Tin Cài Đặt.\n", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxLogin.Checked)
            {
                use.Enabled = false;
                pass.Enabled = false;
            }
            else
            {
                use.Enabled = true;
                pass.Enabled = true;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtnSuaCSDL.Checked)
                data.Enabled = true;
            else
                data.Enabled = false;
        }
    }
}
