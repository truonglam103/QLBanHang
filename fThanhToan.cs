using DEMO.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEMO
{
    public partial class fThanhToan : Form
    {
        public fThanhToan()
        {
            InitializeComponent();
            Load_CTHoaDon();
        }

        void Load_CTHoaDon()
        {
            string maHD = txtMaHD.Text;
            DataTable res = CTHoaDonDAO.Instance.GetCTHoaDon(maHD);
            dtgvBillInfo.DataSource = res;

            CultureInfo culture = new CultureInfo("vi-VN");

            txtTotal.Text = tinhTongTien(res).ToString("c", culture);

        }

        int tinhTongTien(DataTable hd)
        {
            int total = 0;
            foreach (DataRow item in hd.Rows)
            {
                total += ((int)item["SoLuong"] * (int)item["DonGia"]);
            }
            return total;
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanh toán thành công!!!");
        }

        private void fThuQuy_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Aqua;
            button2.BackColor = Color.Transparent;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.Aqua;
            button1.BackColor = Color.Transparent;
        }
    }
}
