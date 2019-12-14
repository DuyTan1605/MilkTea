using QuanLyQuanTraSua.DAO;
using QuanLyQuanTraSua.DataTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanTraSua.DataA0
{
    public class DAOTrangChu
    {
        private static DAOTrangChu instance;

        public static DAOTrangChu Instance {
            get { if (instance == null)
                    instance = new DAOTrangChu();
                return DAOTrangChu.instance; }
            private set { DAOTrangChu.instance = value; } }

        private DAOTrangChu() { }

        //public int[] LoadData()
        //{
        //    string query = "SELECT * FROM MON";
        //    DataTable x = new DataTable();
        //    x = DataProvider.Instance.ExcuteQuery(query);
        //    DataRow[]x1= x.Select();
        //    int[] a = new int[100];
        //    int dem = 0;
        //    for(int i=0;i<x1.Length;i++)
        //    {
        //        //Console.WriteLine(x1[i]["ID"]);
        //        a[i] = Convert.ToInt32(x1[i]["ID"]);
        //        dem++;
        //    }
          
        //    return a;
        //}
        public List<DTOTrangChu>LoadData()
        {
            List<DTOTrangChu> tableList = new List<DTOTrangChu>();
            DataTable data = DataProvider.Instance.ExcuteQuery("USP_GetListDrink");  //Procedure in sql, also can use select *...
            foreach(DataRow item in data.Rows)
            {
                DTOTrangChu table = new DTOTrangChu(item);
                if (table.ID % 3 == 1)
                    tableList.Add(table);
            }
            return tableList;
        }
        public List<DTOTrangChu> SearchData(string keyword)
        {
            List<DTOTrangChu> tableList = new List<DTOTrangChu>();
            DataTable data = DataProvider.Instance.ExcuteQuery("EXEC USP_SearchProductByName @keyword", new object[]{keyword});  //Procedure in sql, also can use select *...
            foreach (DataRow item in data.Rows)
            {
                DTOTrangChu table = new DTOTrangChu(item);
                if (table.ID % 3 == 1)
                    tableList.Add(table);
            }
            return tableList;
        }

        public DTOTrangChu getProductByID(int id)
        {
            DataTable data = DataProvider.Instance.ExcuteQuery("EXEC USP_GetDrinkByID @id", new object[] { id });  //Procedure in sql, also can use select *...
            return new DTOTrangChu(data.Rows[0]);
        }

        public void UpdateProductByID(int id, string name, string size, int gia, int kt_dacbiet, int kt_banchay,
            string linkanh)
        {
            string query =
                string.Format(
                    "UPDATE MON SET TenMon = N'{0}', Size = N'{1}', Gia = {2}, KT_Dacbiet = {3}, KT_BanChay = {4}, LinkAnh = '{5}' WHERE ID = {6}",
                    name, size, gia, kt_dacbiet, kt_banchay, linkanh, id);
            DataProvider.Instance.ExcuteNonQuery(query);
        }

    }
}
