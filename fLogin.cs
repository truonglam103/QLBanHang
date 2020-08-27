using DEMO.DAO;
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
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            txtUsername.Text = null;
            txtPassword.Text = null;
            DataTable result = Login(username, password);
            if (result.Rows.Count != 0)
            {
                switch (GetTypeOfAccount(result))
                {
                    case 1:
                        {
                            fTraCuuHangHoa f = new fTraCuuHangHoa();
                            this.Hide();
                            f.ShowDialog();
                            this.Show();
                            break;
                        }

                    case 2:
                        {
                            fThanhToan f = new fThanhToan();
                            this.Hide();
                            f.ShowDialog();
                            this.Show();
                            break;
                        }

                    case 3:
                        {
                            fHoaDon f = new fHoaDon();
                            this.Hide();
                            f.ShowDialog();
                            this.Show();
                            break;
                        }

                    case 4:
                        {
                            fThanhToan f = new fThanhToan();
                            this.Hide();
                            f.ShowDialog();
                            this.Show();
                            break;
                        }

                }
                


            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!!!", "!!!");
            }
        }

        DataTable Login(string username, string password)
        {
            return LoginDAO.Instance.Login(username, password);
        }

        int GetTypeOfAccount(DataTable t)
        {
            string type = t.Rows[0].Field<string>("ChucVu");
            
            if (String.Compare(type, "Quản lý", true) == 0)
            {
                return 1;
            }
            else if(String.Compare(type, "NVDT", true) == 0)
            {
                return 2;
            }
            else if (String.Compare(type, "NVBH", true) == 0)
            {
                return 3;
            }
            else return 4;
        }

    }
}
