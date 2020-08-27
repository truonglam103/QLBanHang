using DEMO.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO.DAO
{
    public class HoaDonDAO
    {
        public static int btnWidth = 110;
        public static int btnHeight = 110;

        private static HoaDonDAO instance;

        public static HoaDonDAO Instance
        {
            get { if (instance == null) instance = new HoaDonDAO(); return HoaDonDAO.instance; }
            private set { HoaDonDAO.instance = value; }
        }

        private HoaDonDAO() { }

        public List<HoaDon> GetListHD()
        {
            List<HoaDon> list = new List<HoaDon>();
            string query = "SELECT MaHD, MaKH FROM HOA_DON";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                HoaDon bill = new HoaDon(item);
                list.Add(bill);
            }

            return list;
        }

        public DataTable GetBillInfo(string maHD)
        {
            string query = "EXEC USP_GetBillInfo N'" + maHD + "'";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);



            return data;
        }

    }
}
