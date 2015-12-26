using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS;


namespace QL_VLXD
{
    public partial class Form1 : Form
    {
        BUS_Form1 busForm = new BUS_Form1();
        public Form1()
        {
            int a = busForm.getSize();
            
            InitializeComponent();
            label1.Text = a.ToString();
        }
    }
}
