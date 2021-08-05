using NguyenHoangThai.Model;
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
    public partial class frmDiem : Form
    {
        public frmDiem()
        {
            InitializeComponent();
        }
        DatabaseQLHS db = new DatabaseQLHS();
        private void HienThi()
        {
            //dataGridView1.DataSource = db.HocSinh.ToList();
            dataGridView1.DataSource = (from d in db.Diem
                                        select new
                                        {
                                            d.Toan,
                                            d.Ly,
                                            d.Hoa,
                                           DTB = 2*(d.Toan + d.Ly + d.Hoa)/4.0,
                                        }).ToList();
            //for (int i=0;i<=dataGridView1.Rows.Count;i++)
            //{
            //    for (int j = 0; j < dataGridView1.Columns.Count; j++)
            //    {
            //        if (dataGridView1.Rows[i].Cells[j].Value != "")
            //        {
            //            decimal T = Convert.ToDecimal(dataGridView1.Rows[i].Cells["Toan"].Value.ToString());// "Column Name" là tên cột đó - thuộc tính Name của Column ấy
            //            decimal L = Convert.ToDecimal(dataGridView1.Rows[i].Cells["Ly"].Value.ToString());
            //            decimal H = Convert.ToDecimal(dataGridView1.Rows[i].Cells["Hoa"].Value.ToString());
            //            decimal DTB = T + L + H;
            //             DTB = Convert.ToDecimal(dataGridView1.Rows[i].Cells["DTB"].Value.ToString());
            //            MessageBox.Show("DTB la:"+ DTB);
            //        }
            //    }
            //}    

        }

        private void frmDiem_Load(object sender, EventArgs e)
        {
            HienThi();
        }
    }
}
