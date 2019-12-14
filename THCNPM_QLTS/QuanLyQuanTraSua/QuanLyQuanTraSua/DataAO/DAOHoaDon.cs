using QuanLyQuanTraSua.DAO;
using QuanLyQuanTraSua.DataTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanTraSua.DataAO
{
    public class DAOHoaDon
    {
        private static DAOHoaDon instance;

        public static DAOHoaDon Instance
        {
            get
            {
                if (instance == null)
                    DAOHoaDon.instance = new DAOHoaDon();
                return DAOHoaDon.instance;
            }
            set { DAOHoaDon.instance = value; }
        }
        private DAOHoaDon() { }
        public void DeleteBillByIdCustomer(int id)
        {
            DataTable x = DataProvider.Instance.ExcuteQuery("SELECT ID FROM HOADON WHERE ID_KhachHang=" + id);
            int []res = new int[100];
            int dem = 0;
            foreach(DataRow i in x.Rows)
            {
                res[dem] = (int)i["ID"];
                dem++;
            }
            Console.WriteLine(res.Length);
            DAOChiTietHoaDon.Instance.DeleteAllDetailBillByIDCustomer(res);
            DAOShip.Instance.DeleteAllShipBillByIDBill(res);
            string query = "DELETE HOADON WHERE ID_KhachHang="+id;
            DataProvider.Instance.ExcuteNonQuery(query);
        }

        public int InsertNewBill1(string id_khachhang,DateTime ngaydat,string HinhThucThanhToan, int kt_ship)
        {
            string query = String.Format("INSERT INTO HOADON VALUES ({0},N'{1}','{2}',{3})", id_khachhang,ngaydat,HinhThucThanhToan,kt_ship);
            DataTable table = DataProvider.Instance.ExcuteQuery(query);
            return (int)table.Rows[table.Rows.Count - 1]["ID"];
        }
        public int InsertNewBill()
        {
            DataProvider.Instance.ExcuteNonQuery("INSERT INTO HOADON VALUES (NULL, NULL, NULL ,NULL)");
            DataTable table = DataProvider.Instance.ExcuteQuery("SELECT * FROM HOADON");
            return (int)table.Rows[table.Rows.Count - 1]["ID"];
        }
        public void DeleteBillByID(int id)
        {
           
            DAOChiTietHoaDon.Instance.DeleteAllDetailBillByIDBill(id);
           
            DataProvider.Instance.ExcuteNonQuery("DELETE HOADON WHERE ID= " + id);
        }

        public void UpdateBillByID(int id, DTOHoaDon hoaDon)
        {
            string sqlFormattedDate = hoaDon.NgayDat.ToString("yyyy-MM-dd HH:mm:ss.fff");
            string strIdKhachHang = "NULL";
            string strHinhThucThanhToan = "NULL";
            if (hoaDon.ID_KhachHang != -1)
            {
                strIdKhachHang = hoaDon.ID_KhachHang.ToString();
            }
            if (hoaDon.HinhThucThanhToan != null)
            {
                strHinhThucThanhToan = "N'" + hoaDon.HinhThucThanhToan + "'";
            }
            string query = string.Format(
                "UPDATE HOADON SET ID_KhachHang = {0}, NgayDat = '{1}', HinhThucThanhToan = {2}, KT_Ship = {3}"
                + " WHERE ID = {4}", strIdKhachHang, sqlFormattedDate, strHinhThucThanhToan,hoaDon.KT_Ship,id);
            DataProvider.Instance.ExcuteNonQuery(query);
        }

        public void UpdateIDKhachHang(int id, int idKhachHang)
        {
            string query;
            if (idKhachHang > -1)
            {
                 query = string.Format(
                    "UPDATE HOADON SET ID_KhachHang = {0} "
                    + " WHERE ID = {1}", idKhachHang, id);
            }
            else
            {
                query = string.Format(
                    "UPDATE HOADON SET ID_KhachHang = NULL "
                    + " WHERE ID = {0}", id);
            }

            DataProvider.Instance.ExcuteNonQuery(query);
        }

        public void UpdateHinhThucThanhToan(int id, string hinhThucThanhToan)
        {
            string query = string.Format(
                "UPDATE HOADON SET HinhThucThanhToan = N'{0}' "
                + " WHERE ID = {1}", hinhThucThanhToan, id);
            DataProvider.Instance.ExcuteNonQuery(query);
        }

        public void UpdateKTShip(int id, int KT_Ship)
        {
            string query = string.Format(
                "UPDATE HOADON SET KT_Ship = {0} "
                + " WHERE ID = {1}", KT_Ship, id);
            DataProvider.Instance.ExcuteNonQuery(query);
        }

        public void UpdateNgayDat(int id, DateTime ngayDat)
        {
            string sqlFormattedDate = ngayDat.ToString("yyyy-MM-dd HH:mm:ss.fff");
            string query = string.Format(
                "UPDATE HOADON SET NgayDat = '{0}' "
                + " WHERE ID = {1}", sqlFormattedDate, id);
            DataProvider.Instance.ExcuteNonQuery(query);
        }
    }
}
