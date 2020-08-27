using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO.DTO
{
    public class HoaDon
    {
        public HoaDon(string maHD, string maKH)
        {
            this.MaHD = maHD;
            this.MaKH = maKH;
        }

        public HoaDon(DataRow row)
        {
            this.MaHD = row["MaHD"].ToString();
            this.MaKH = row["MaKH"].ToString();
        }

        private string maKH;

        public string MaKH
        {
            get { return maKH; }
            set { maKH = value; }
        }

        private string maHD;

        public string MaHD
        {
            get { return maHD; }
            set { maHD = value; }
        }

        
    }
}
