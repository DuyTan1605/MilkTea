using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanTraSua.DataTO
{
    public class DTOTrangChu
    {
       
        public DTOTrangChu(int id,string name,string size,int price,int is_spec,int is_trend,string link_image)
        {
            this.ID = id;
            this.TenMon = name;
            this.Size = size;
            this.Gia = price;
            this.KT_DatBiet = is_spec;
            this.KT_BanChay = is_trend;
            this.LinkAnh = link_image;
        }
        public DTOTrangChu(DataRow row)
        {
            this.ID = (int)row["ID"];
            this.TenMon = row["TenMon"].ToString();
            this.Size = row["Size"].ToString();
            this.Gia = int.Parse(row["Gia"].ToString());
            this.KT_DatBiet=(int)row["KT_DacBiet"];
            this.KT_BanChay = (int)row["KT_BanChay"];
            this.LinkAnh=row["LinkAnh"].ToString();
        }
        private int iD;
        private string tenMon;
        private string size;
        private int gia;
        private int kT_DatBiet;
        private int kT_BanChay;
        private string linkAnh;

        public int ID { get { return iD; }
            set
            {
                iD = value;
            } }
        public string TenMon
        {
            get { return tenMon; }
            set
            {
                tenMon = value;
            } }
        public int Gia { get { return gia; }
            set
            {
                gia = value;
            } }
        public int KT_DatBiet { get { return kT_DatBiet; }
            set
            {
                kT_DatBiet = value;
            } }
        public int KT_BanChay { get { return kT_BanChay; }
            set
            {
                kT_BanChay = value;
            } }
        public string LinkAnh { get { return linkAnh; }
            set
            {
                linkAnh = value;
            } }
        public string Size
        {
            get { return size; }
            set
            {
                size = value;
            }
        }
    }
}
