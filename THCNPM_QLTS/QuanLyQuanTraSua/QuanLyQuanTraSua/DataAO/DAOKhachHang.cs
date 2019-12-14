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
    public class DAOKhachHang
    {
        private static DAOKhachHang instance;

        public static DAOKhachHang Instance {
            get { if (instance == null)
                    DAOKhachHang.instance = new DAOKhachHang();
                return DAOKhachHang.instance;
            }

            private set { DAOKhachHang.instance = value; } }

        private DAOKhachHang() { }

        public List<DTOKhachHang> LoadData()
        {
            List<DTOKhachHang> tableList = new List<DTOKhachHang>();
            DataTable data = DataProvider.Instance.ExcuteQuery("USP_GetListCustomer");
            foreach (DataRow item in data.Rows)
            {
                DTOKhachHang table = new DTOKhachHang(item);
                //if (item["NgaySinh"].ToString().Length != 0)
                //{
                //    Console.WriteLine(Convert.ToDateTime(item["NgaySinh"].ToString()));
                //}
                tableList.Add(table);  //ngay sinh null se in ra 1/1/0001
            }
            return tableList;
        }
        
        public bool insertCustomer(string name,string address,DateTime birthday,string phone,int type,string email, int point)
        {

            string query = String.Format("INSERT INTO KHACHHANG VALUES (N'{0}',N'{1}','{2}','{3}',{4},'{5}',{6})",name,address,birthday,phone,type,email,point);
            int res = DataProvider.Instance.ExcuteNonQuery(query);
            return res > 0;
        }
        public bool addCustomer(int flag,string name, string address, DateTime birthday, string phone, int type, string email, int point)
        {

            int data = DataProvider.Instance.ExcuteNonQuery("USP_CustomerAddOrEdit @flag,@name,@address,@birthday,@phone,@type,@email,@diem",new object[] { flag,name,address,birthday,phone,type,email,point});
            return data > 0;

        }

        public bool updateCustomer(int id,string name, string address, DateTime birthday, string phone, int type, string email, int point)
        { 

            string query = String.Format("UPDATE KHACHHANG SET HoTen=N'{0}',DiaChi=N'{1}',NgaySinh='{2}',SDT='{3}',LoaiKH={4},Email='{5}',DiemTichLuy={6} WHERE ID={7}", name, address,birthday, phone, type, email, point,id);
            int res = DataProvider.Instance.ExcuteNonQuery(query);// tra ve so dong duoc update, neu >0 la update thanh cong
            return res > 0;
        }

        public bool deleteCustomer(int id)
        {
            
            DAOHoaDon.Instance.DeleteBillByIdCustomer(id); //xoa bang hoa don chua id khach hang khi xoa khach ahng nay
            string query = String.Format("DELETE KHACHHANG WHERE ID={0}",id);
            int res = DataProvider.Instance.ExcuteNonQuery(query); // tra ve so dong bi xoa
            return res > 0;
        }

        public DTOKhachHang GetKhachHangBySDT(string sdt)
        {
            string query = string.Format("SELECT * FROM KHACHHANG WHERE SDT = '{0}'", sdt);
            DataTable db = DataProvider.Instance.ExcuteQuery(query);
            if (db.Rows.Count != 0)
            {
                return new DTOKhachHang(db.Rows[0]);
            }

            return null;
        }

        public void UpdatePoint(int id, int Point)
        {
            string query = String.Format("UPDATE KHACHHANG SET DiemTichLuy={0} WHERE ID={1}", Point, id);
            DataProvider.Instance.ExcuteNonQuery(query);
        }
        public List<DTOKhachHang> SearchData(string keyword)
        {
            List<DTOKhachHang> tableList = new List<DTOKhachHang>();
            DataTable data = DataProvider.Instance.ExcuteQuery("EXEC USP_SearchCustomerByName @keyword", new object[] { keyword });  //Procedure in sql, also can use select *...
            foreach (DataRow item in data.Rows)
            {
                DTOKhachHang table = new DTOKhachHang(item);
                    tableList.Add(table);
            }
            return tableList;
        }
    }
}
