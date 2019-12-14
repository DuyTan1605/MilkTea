using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyQuanTraSua.DAO;

namespace QuanLyQuanTraSua.DataAO
{
    class DAOShip
    {
        private static DAOShip instance;

        public static DAOShip Instance
        {
            get
            {
                if (instance == null)
                    instance = new DAOShip();
                return DAOShip.instance;
            }
            private set { DAOShip.instance = value; }
        }

        public void InsertShip(int idHoaDon, string tenBenThu3, string tenNguoiGiao, string sdtNguoiGiao, string tenNguoiNhan, string sdtNguoiNhan, string diaChiNhan)
        {
            string idShipper = "NULL";
            if (tenBenThu3 != null)
            {
                string queryFindIdShipper = string.Format("SELECT * FROM SHIPPER WHERE CtyQuanLi = '{0}'", tenBenThu3);
                DataTable db = DataProvider.Instance.ExcuteQuery(queryFindIdShipper);
                idShipper = db.Rows[db.Rows.Count - 1]["ID"].ToString();
            }
            string query = string.Format("INSERT INTO SHIP VALUES ({0}, {1}, {2}, {3}, {4}, {5}, {6})",
                idHoaDon, idShipper, tenNguoiGiao, sdtNguoiGiao, tenNguoiNhan, sdtNguoiNhan, diaChiNhan);
            DataProvider.Instance.ExcuteQuery(query);
        }
        public void DeleteAllShipBillByIDBill(int []res)
        {
            for (int i = 0; i < res.Length; i++)
            {
                DataProvider.Instance.ExcuteNonQuery("DELETE SHIP WHERE ID_HoaDon=" + res[i]);
            }
        }
    }
}
