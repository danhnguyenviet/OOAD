using GUI_QLVLXD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI_QLVLXD
{
    public partial class FrmLogin : Form
    {
        BUS_Login bus_dangnhap = new BUS_Login();
        DTO_Login dto_dangnhap = new DTO_Login();


        public void LayThongTinDangNhap()
        {
            dto_dangnhap.TenDangNhap = txtUser.Text;
            dto_dangnhap.MatKhau = txtPass.Text;
        }


        public FrmLogin()
        {
            InitializeComponent();
            if(!bus_dangnhap.KetNoiServer())
            {
               
                MessageBox.Show("Ket Noi Khong Thanh Cong \n","Loi Ket Noi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 
                frmInfosql frm = new frmInfosql();
                frm.ShowDialog();
                Hide();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            LayThongTinDangNhap();
            DataTable dangnhap_datatable = bus_dangnhap.LayDanhSachTheoID(dto_dangnhap);
            int SoRecord = dangnhap_datatable.Rows.Count;
            if (SoRecord == 1)
            {
                FrmMain.username = dangnhap_datatable.Rows[0]["TenDangNhap"].ToString();
                FrmMain.quyen = dangnhap_datatable.Rows[0]["Quyen"].ToString();
                FrmMain form = new FrmMain();
                form.Show();
                Hide();
            }
            else
                MessageBox.Show("Sai Tên Đăng Nhập Hoặc Mật Khẩu!", "ĐĂNG NHẬP", MessageBoxButtons.OK);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
