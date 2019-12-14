using QuanLyQuanTraSua.DAO;
using QuanLyQuanTraSua.DataTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanTraSua.DataAO
{
    public class DAOChiTietHoaDon
    {
        private static DAOChiTietHoaDon instance;

        public static DAOChiTietHoaDon Instance
        {
            get
            {
                if (instance == null)
                    DAOChiTietHoaDon.instance = new DAOChiTietHoaDon();


                return DAOChiTietHoaDon.instance;
            }
            set { DAOChiTietHoaDon.instance = value; }
        }
        private DAOChiTietHoaDon() { }
        public void DeleteAllDetailBillByIDCustomer(int[] res)
        {
            for (int i = 0; i < res.Length; i++)
            {
                DataProvider.Instance.ExcuteNonQuery("DELETE CHITIETHOADON WHERE ID_HoaDon=" + res[i]);
            }
        }

        public void DeleteAllDetailBillByIDBill(int IDBill)
        {
            DataProvider.Instance.ExcuteNonQuery("DELETE CHITIETHOADON WHERE ID_HOADON = " + IDBill);
        }

        public DTOChiTietHoaDon InsertNewDetailBill(int idBill, int idProduct, string sugar, string ice, string flavor, string topping, string note)
        {
            DataProvider.Instance.ExcuteNonQuery("INSERT INTO CHITIETHOADON VALUES (" + idBill + "," + idProduct + ",'" + sugar + "','" + ice + "',N'" + flavor + "',N'" + topping + "',N'" + note + "')");
            DataTable table = DataProvider.Instance.ExcuteQuery("SELECT * FROM CHITIETHOADON");
            return new DTOChiTietHoaDon(table.Rows[table.Rows.Count - 1]);
        }

        public void DeleteDetailBillByID(int id)
        {
            DataProvider.Instance.ExcuteNonQuery("DELETE FROM CHITIETHOADON WHERE ID = " + id);
        }

        //public void UpdateDetailBillAmountByID(int idBill, int idProduct, int amount)
        //{
        //    DataProvider.Instance.ExcuteNonQuery("UPDATE CHITIETHOADON SET SoLuong = " + amount +
        //                                         " WHERE ID_HoaDon = " + idBill + " AND ID_Mon = " + idProduct);
        //}

        public DTOChiTietHoaDon GetDetailBillByID(int id)
        {
            DataTable data =
                DataProvider.Instance.ExcuteQuery("SELECT * FROM CHITIETHOADON WHERE ID = " + id);
            return new DTOChiTietHoaDon(data.Rows[0]);
        }

        public void UpdateDetailBillInfoByID(int id, int idProduct, string sugar, string ice, string flavor, string topping, string note)
        {
            string query = String.Format(
                "UPDATE CHITIETHOADON SET ID_Mon = {0}, Duong = '{1}', Da = '{2}', Huong = N'{3}', Topping = N'{4}', GhiChu = N'{5}'"
                + " WHERE ID = {6}", idProduct, sugar, ice, flavor, topping, note, id);
            DataProvider.Instance.ExcuteNonQuery(query);
        }
    }
}
