using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanTraSua.DataTO
{
    public class DTOChiTietHoaDon
    {
        public DTOChiTietHoaDon(int id, int idHoaDon, int idMon,string duong,string da,string huong,string topping, string note)
        {
            this.ID = id;
            this.IDHoaDon = idHoaDon;
            this.IDMon = idMon;
            this.Duong = duong;
            this.Da = da;
            this.Huong = huong;
            this.Topping = topping;
            //this.SoLuong = soLuong;
            this.Note = note;
        }
        public DTOChiTietHoaDon(DataRow row)
        {
            this.ID = (int) row["ID"];
            this.IDHoaDon = (int)row["ID_HoaDon"];
            this.IDMon = (int)row["ID_Mon"];
            this.Duong = row["Duong"].ToString();
            this.Da = row["Da"].ToString();
            this.Huong = row["Huong"].ToString();
            this.Topping = row["Topping"].ToString();
            //this.SoLuong = (int)row["SoLuong"];
            this.Note = row["GhiChu"].ToString();
        }

        private int id;
        private int idHoaDon;
        private int idMon;
        private string duong;
        private string da;
        private string huong;
        private string topping;
        //private int soLuong;
        private string note;

        public int ID { get { return id; }
            set
            {
                id = value;
            } }
        public int IDHoaDon { get { return idHoaDon; }
            set
            {
                idHoaDon = value;
            } }
        public int IDMon { get { return idMon; }
            set
            {
                idMon = value;
            } }
        //public int SoLuong { get => soLuong; set => soLuong = value; }
        public string Note { get { return note; }
            set
            {
                note = value;
            } }
        public string Duong { get { return duong; }
            set
            {
                duong = value;
            } }
        public string Da { get { return da; }
            set
            {
                da = value;
            } }
        public string Huong { get { return huong; }
            set
            {
                huong = value;
            } }
        public string Topping
        {
            get { return topping; }
            set
            {
                topping = value;
            }
        }
    }
}
