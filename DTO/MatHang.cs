using System;
using DEMO.DAO;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO.DTO
{
    public class MatHang
    {
        public MatHang(string maMH, string tenMH, string tenLH, string tenNCC, int donGia)
        {
            this.MaMH = maMH;
            this.TenMH = tenMH;
            this.TenLH = tenLH;
            this.TenNCC = tenNCC;
            this.DonGia = donGia;
        }

        public MatHang(DataRow row)
        {
            this.MaMH = row["MaMH"].ToString();
            this.TenMH = row["TenMH"].ToString();
            this.TenLH = row["tenLH"].ToString();
            this.TenNCC = row["tenNCC"].ToString();
            this.DonGia = (int)row["DonGia"];
        }

        private string maMH;

        public string MaMH
        {
            get { return maMH; }
            set { maMH = value; }
        }

        private string tenMH;

        public string TenMH
        {
            get { return tenMH; }
            set { tenMH = value; }
        }

        private string tenLH;

        public string TenLH
        {
            get { return tenLH; }
            set { tenLH = value; }
        }

        private string tenNCC;

        public string TenNCC
        {
            get { return tenNCC; }
            set { tenNCC = value; }
        }

        private int donGia;

        public int DonGia
        {
            get { return donGia; }
            set { donGia = value; }
        }


    }
}
