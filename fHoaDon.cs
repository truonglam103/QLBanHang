using System;
using DEMO.DAO;
using DEMO.DTO;
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
    public partial class fHoaDon : Form
    {
        public fHoaDon()
        {
            InitializeComponent();
            LoadHD();
        }



        void LoadHD()
        {
            flpHoaDon.Controls.Clear();
            List<DTO.HoaDon> list = HoaDonDAO.Instance.GetListHD();
            foreach (DTO.HoaDon item in list)
            {
                Button btn = new Button() { Width = HoaDonDAO.btnWidth, Height = HoaDonDAO.btnHeight };

                btn.Click += btn_Click;
                btn.Tag = item.MaHD;


                btn.Text = item.MaHD + "\nKhách hàng: " + item.MaKH;



                flpHoaDon.Controls.Add(btn);
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            string id = ((sender as Button).Tag as string);


            dtgvHD.DataSource = HoaDonDAO.Instance.GetBillInfo(id);

            dtgvCTHD.DataSource = CTHoaDonDAO.Instance.GetCTHoaDon(id.ToString());
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
