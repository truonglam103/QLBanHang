using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO.DAO
{
    public class LoginDAO
    {
        private static LoginDAO instance;

        public static LoginDAO Instance
        {
            get { if (instance == null) instance = new LoginDAO(); return instance; }
            private set { instance = value; }
        }

        private LoginDAO() { }

        public DataTable Login(string username, string password)
        {
            string query = "SELECT * FROM dbo.NHAN_VIEN WHERE Username = N'" + username + "' AND Pass = N'" + password + "' ";

            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            return result;
        }
    }
}
