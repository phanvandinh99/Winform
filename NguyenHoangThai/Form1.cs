using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenHoangThai
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
     
        private void btnHocSinh_Click(object sender, EventArgs e)
        {
            frmHocSinh hs = new frmHocSinh();
            hs.ShowDialog();
        }

        private void btnDiem_Click(object sender, EventArgs e)
        {
            frmDiem d = new frmDiem();
            d.ShowDialog();
        }
    }
}
