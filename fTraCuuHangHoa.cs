using DEMO.DAO;
using DEMO.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEMO
{
    public partial class fTraCuuHangHoa : Form
    {
        public fTraCuuHangHoa()
        {
            InitializeComponent();
            pnlInfo.Hide();
            LoadMH();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        void LoadMH()
        {
            DataTable dsMatHang = MatHangDAO.Instance.GetListMH();
            dtgvMH.DataSource = dsMatHang;
            
        }

        private void btnSearchMH_Click(object sender, EventArgs e)
        {
            string tenMH = txtTenMH.Text;

            DataTable res = MatHangDAO.Instance.SearchByName(tenMH);
            if (res.Rows.Count > 0)
            {
                txtMaMH.Text = res.Rows[0].Field<string>("MaMH");
                txtTenMH2.Text = res.Rows[0].Field<string>("TenMH");
                txtTenLH.Text = res.Rows[0].Field<string>("TenLH");
                txtTenNCC.Text = res.Rows[0].Field<string>("TenNCC");
                txtDonGia.Text = res.Rows[0].Field<int>("DonGia").ToString();
            }
            else
            {
                MessageBox.Show("Không tìm thấy mặt hàng này!!!", "!!!");

            }

            pnlInfo.Show();




        }
    }
}
