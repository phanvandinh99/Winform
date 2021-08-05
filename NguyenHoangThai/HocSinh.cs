using NguyenHoangThai.Model;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace NguyenHoangThai
{
    public partial class frmHocSinh : Form
    {
        public frmHocSinh()
        {
            InitializeComponent();
        }
        // Khoi tao
        DatabaseQLHS db = new DatabaseQLHS();
        private void HienThi()
        {
            //dataGridView1.DataSource = db.HocSinh.ToList();
            dataGridView1.DataSource = (from hs in db.HocSinh
                                       select new
                                       { hs.MaHS, hs.TenHS,
                                           Ngay = hs.NgaySinh - hs.NgaySinh,
                                           hs.GioiTinh,
                                       }).ToList();
        }
        private void clear()
        {
            txtMaHS.Text = "";
            txtMaHS.Focus();
            txtTenHS.Text = "";
            txtNgaySinh.Text = "";
            txtGioiTinh.Text = "";
        }
        private void frmHocSinh_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        private void btnresert_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            HocSinh hs = new HocSinh();
            hs.MaHS = txtMaHS.Text;
            hs.TenHS = txtTenHS.Text;
            hs.NgaySinh = DateTime.ParseExact(txtNgaySinh.Text, "dd/mm/yyyy", CultureInfo.InvariantCulture);
            hs.GioiTinh = txtGioiTinh.Text;
            db.HocSinh.Add(hs);
            db.SaveChanges();
            clear();
            MessageBox.Show("Thêm Thành Công");
            HienThi();
        }
    }
}
