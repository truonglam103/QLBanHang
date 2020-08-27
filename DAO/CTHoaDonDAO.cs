using DEMO.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO.DAO
{
    public class CTHoaDonDAO
    {
        private static CTHoaDonDAO instance;

        public static CTHoaDonDAO Instance
        {
            get { if (instance == null) instance = new CTHoaDonDAO(); return CTHoaDonDAO.instance; }
            private set { CTHoaDonDAO.instance = value; }
        }

        private CTHoaDonDAO() { }


        public DataTable GetCTHoaDon(string maHD)
        {
            string query = "EXEC USP_LayThongTinHD '" + maHD + "'";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }
    }

    

}
