using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanTraSua.DataTO
{
    public class DTOHoaDon
    {
        public DTOHoaDon(int idHoaDon,int idKhachHang,DateTime NgayDat,string HinhThucThanhToan, int kt_Ship)
        {
            this.ID = idHoaDon;
            this.ID_KhachHang = idKhachHang;
            this.NgayDat = NgayDat;
            this.HinhThucThanhToan = HinhThucThanhToan;
            this.KT_Ship = kt_Ship;
        }
        public DTOHoaDon(DataRow row)
        {
            this.ID = (int)row["ID"];
            this.ID_KhachHang = (int)row["ID_KhachHang"];
            this.NgayDat = Convert.ToDateTime(row["NgayDat"].ToString());
            this.HinhThucThanhToan = row["HinhThucThanhToan"].ToString();
            this.KT_Ship = (int)row["KT_Ship"];
        }
        private int iD;
        private int iD_KhachHang;
        private DateTime ngayDat;
        private string hinhThucThanhToan;
        private int kT_Ship;

        public int ID { get { return iD; }
            set
            {
                iD = value;
            } }
        public int ID_KhachHang { get { return iD_KhachHang; }
            set
            {
                iD_KhachHang = value;
            } }
        public DateTime NgayDat { get { return ngayDat; }
            set
            {
                ngayDat = value;
            } }
        public string HinhThucThanhToan { get { return hinhThucThanhToan; }
            set
            {
                hinhThucThanhToan = value;
            } }
        public int KT_Ship
        {
            get { return kT_Ship; }
            set
            {
                kT_Ship = value;
            }
        }
    }
}
