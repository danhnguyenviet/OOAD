using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI_QLVLXD;
using BUS;

namespace GUI_QLVLXD
{
    public partial class frmChangepass : Form
    {
        BUS_Changepass bus_thaydoimatkhau = new BUS_Changepass();


        public frmChangepass()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (bus_thaydoimatkhau.KiemtraMatKhau(FrmMain.username))
            {
                if (bus_thaydoimatkhau.KiemTraMatKhauXacNhan(txtnew.Text,txtconfirm.Text))
                {
                    
                    MessageBox.Show("Mật khẩu của bạn đã được thay đổi thành công !");
                    Hide();
                }
                else
                {
                    MessageBox.Show("Mật khẩu mới và xác nhận mật khẩu không đồng nhất vui long kiểm tra lại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Sai mật khẩu, vui lòng kiểm tra lại mật khẩu cũ của bạn !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
