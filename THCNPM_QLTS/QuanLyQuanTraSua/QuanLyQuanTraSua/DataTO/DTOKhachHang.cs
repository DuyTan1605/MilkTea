using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanTraSua.DataTO
{
    public class DTOKhachHang
    {
        public DTOKhachHang(int id, string name,string address,string phone,string type,string email, int point, DateTime birthday)
        {
            this.ID = id;
            this.HoTen = name;
            this.DiaChi = address;
            this.NgaySinh = birthday;
            this.Sdt = phone;
            this.LoaiKH = type;
            this.Email = email;
            this.DiemTichLuy = point;
        }
        public DTOKhachHang(DataRow row)
        {
            this.ID = (int)row["ID"];
            this.HoTen = row["HoTen"].ToString();
            this.DiaChi = row["DiaChi"].ToString();
            if (row["NgaySinh"].ToString().Length != 0)
            {
                this.NgaySinh = Convert.ToDateTime(row["NgaySinh"].ToString()); // Convert birthday which is not null, null is defined with 1/1/1
            }
            this.Sdt = row["SDT"].ToString();
            this.LoaiKH =row["LoaiKH"].ToString();
            this.Email = row["Email"].ToString();
            this.DiemTichLuy = (int)row["DiemTichLuy"];
        }
        private int iD;
        private string hoTen;
        private string diaChi;
        private DateTime ngaySinh;
        private string sdt;
        private string loaiKH ;
        private string email;
        private int diemTichLuy;

        public int ID { get { return iD; }
            set
            {
                iD = value;
            } }
        public string HoTen { get { return hoTen; }
            set
            {
                hoTen = value;
            } }
        public string DiaChi { get { return diaChi; }
            set
            {
                diaChi = value;
            } }
        public string Sdt
        {
            get { return sdt; }
            set
            {
                sdt = value;
            } }
        public string LoaiKH { get { return loaiKH; }
            set
            {
                loaiKH = value;
            } }
        public string Email { get { return email; }
            set
            {
                email = value;
            } }
        public int DiemTichLuy { get { return diemTichLuy; }
            set
            {
                diemTichLuy = value;
            } }
        public DateTime NgaySinh
        {
            get { return ngaySinh; }
            set
            {
                ngaySinh = value;
            }
        }
    }
}
