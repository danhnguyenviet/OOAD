﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLVLXD
{
    public partial class FrmNhaCungCap : Form
    {
        public FrmNhaCungCap()
        {
            InitializeComponent();
        }

        private void FrmNhaCungCap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_VLXDDataSetChung.NhaCC' table. You can move, or remove it, as needed.
            this.nhaCCTableAdapter.Fill(this.qL_VLXDDataSetChung.NhaCC);

        }
    }
}