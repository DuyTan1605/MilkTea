using QuanLyQuanTraSua.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyQuanTraSua.DataTO;

namespace QuanLyQuanTraSua.DataAO
{
    public class DAOSanPham
    {
        private static DAOSanPham instance;

        public static DAOSanPham Instance
        {
            get
            {
                if (instance == null)
                    DAOSanPham.instance = new DAOSanPham();
                return DAOSanPham.instance;
            }
            set { DAOSanPham.instance = value; }
        }
        private DAOSanPham() { }
        public bool insertProduct(string name,string size, int price, int is_spec, int is_trend, string link_image)
        {

            string query = string.Format("INSERT INTO MON (TenMon,Size,Gia,KT_DacBiet,KT_BanChay,LinkAnh) VALUES (N'{0}','{1}',{2},{3},{4},'{5}')", name,size, price, is_spec, is_trend, link_image);
            int res = DataProvider.Instance.ExcuteNonQuery(query);
            return res > 0;
        }

        public DTOTrangChu getProductByID(int id)
        {
            string query = string.Format("SELECT * FROM MON WHERE ID = {0}", id);
            return new DTOTrangChu(DataProvider.Instance.ExcuteQuery(query).Rows[0]);
        }
        
    }
}