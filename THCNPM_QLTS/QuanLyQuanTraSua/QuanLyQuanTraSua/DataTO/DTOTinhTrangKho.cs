using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanTraSua.DataTO
{
   public class DTOTinhTrangKho
    {
        public DTOTinhTrangKho(int id, string name, string address, DateTime date, string status)
        {
            this.ID = id;
            this.TenNguyenLieu = name;
            this.XuatXu = address;
            this.TinhTrang = status;
            
        }
        public DTOTinhTrangKho(DataRow row)
        {
            this.ID = (int)row["ID"];
            this.TenNguyenLieu = row["TenNguyenLieu"].ToString();
            this.XuatXu = row["XuatXu"].ToString();
            this.NgayNhap = (DateTime)row["NgayNhap"];
            this.TinhTrang = row["TinhTrang"].ToString();
            
        }
        private int iD;
        private string tenNguyenLieu;
        private string xuatXu;
        private DateTime ngayNhap;
        private string tinhTrang;

        public int ID
        {
            get { return iD; }
            set
            {
                iD = value;
            }
        }

        public string TenNguyenLieu { get { return tenNguyenLieu; }
            set
            {
                tenNguyenLieu = value;
            } }
        public string XuatXu { get { return xuatXu; }
            set
            {
                xuatXu = value;
            } }
        public DateTime NgayNhap { get { return ngayNhap; }
            set
            {
                ngayNhap = value;
            } }
        public string TinhTrang
        {
            get { return tinhTrang; }
            set
            {
                tinhTrang = value;
            }
        }
    }
}
