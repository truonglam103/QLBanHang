using DEMO.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO.DAO
{
    public class MatHangDAO
    {
        private static MatHangDAO instance;
        private object Datatable;

        public static MatHangDAO Instance
        {
            get { if (instance == null) instance = new MatHangDAO(); return MatHangDAO.instance; }
            private set { MatHangDAO.instance = value; }
        }

        private MatHangDAO() { }

        public DataTable GetListMH()
        {
            string query = "SELECT * FROM MAT_HANG";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }

        public DataTable SearchByName(string tenMH)
        {
            string query = "EXEC USP_LayThongTinMH N'" + tenMH + "'";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            

            return data;
        }


    }
}
