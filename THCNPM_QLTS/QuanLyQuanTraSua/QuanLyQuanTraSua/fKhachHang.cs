using QuanLyQuanTraSua.DataAO;
using QuanLyQuanTraSua.DataTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanTraSua
{
    public partial class fKhachHang : Form
    {
        private bool clear = false;
        #region method
        void ShowListCustomer()
        {
            List<DTOKhachHang> table = DAOKhachHang.Instance.LoadData();
            dataGridView1.Rows.Clear();
           foreach(DTOKhachHang item in table)
            {
                dataGridView1.Rows.Add(item.ID,item.HoTen,item.DiaChi,item.NgaySinh.ToString("dd-MM-yyyy"), item.Sdt,item.LoaiKH,item.Email,item.DiemTichLuy);
            }
                
        }
        DTOKhachHang GetCustomerById(int id)
        {
            List<DTOKhachHang> table = DAOKhachHang.Instance.LoadData();
            DTOKhachHang temp = null;
            foreach(DTOKhachHang item in table)
            {
                if(item.ID==id)
                {
                    temp = item;
                }
            }
            return temp;
        }
        
        #endregion
        #region event
        public fKhachHang()
        {
            InitializeComponent();
           

            //Console.WriteLine(GetCustomerById(2).HoTen);// In ra ho ten cua khach hang co id la 2
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddCloseCustomer_Click(object sender, EventArgs e)
        {
            fKhachhang_ThemSua fKhachHang_themsua = new fKhachhang_ThemSua();
            this.Hide();
            fKhachHang_themsua.ShowDialog();
            this.Show();
        }

        private void fKhachHang_Load(object sender, EventArgs e)
        {
            ShowListCustomer();//test list customer bang cach in ra
        }
        #endregion

        private void Button1_Click(object sender, EventArgs e)// Chinh du lieu de sua
        {
            //string name = "Hà Duy Tân".ToString();//neu co du lieu tu user nhap vao thi lay du lieu ra gan vao name, tuong tu cho du lieu khac
            //string sdt = "0918975845".ToString();
            //DateTime birthday = Convert.ToDateTime("1999-08-07");
            //string mail = "dreamleage1999@gmail.com".ToString();
            //string address = "Đồng Tháp".ToString();
            //float point = 100;
            //if (DAOKhachHang.Instance.updateCustomer(name, sdt, mail, address, point, 12, birthday)) //11 sau nay se thay bang id khach hang
            //{
            //    MessageBox.Show("Sửa thông tin khách hàng thành công");
            //    this.Close();
            //}
            //else
            //{
            //    MessageBox.Show("Sửa thông tin khách hàng thất bại");
            //    this.Close();
            //}
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (DAOKhachHang.Instance.deleteCustomer(12))//11 la id khach hang, sau nay muon xoa se lay id thay vao 11
            {
                MessageBox.Show("Xóa thành công");
                this.Close();
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
                this.Close();
            }
        }

        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.CurrentRow!=null)
            {
                DataGridViewRow dgvRow = dataGridView1.CurrentRow;
                string[] formats = {"M/d/yyyy h:mm:ss tt", "M/d/yyyy h:mm tt",
                     "MM/dd/yyyy hh:mm:ss", "M/d/yyyy h:mm:ss",
                     "M/d/yyyy hh:mm tt", "M/d/yyyy hh tt",
                     "M/d/yyyy h:mm", "M/d/yyyy h:mm",
                     "MM/dd/yyyy hh:mm", "M/dd/yyyy hh:mm",
                     "MM/d/yyyy HH:mm:ss.ffffff" , "dd-MM-yyyy"};
                // Console.WriteLine("res is" + (dgvRow.Cells["txtCustomerID"].Value));
                if (dgvRow.Cells["txtCustomerID"].Value != null)
                {
                    int temp=int.Parse( dgvRow.Cells["txtCustomerID"].Value.ToString());
                    string name = dgvRow.Cells["txtCustomerName"].Value == null ? "" : dgvRow.Cells["txtCustomerName"].Value.ToString();
                   
                    string address = dgvRow.Cells["txtCustomerAddress"].Value ==null ? "" : dgvRow.Cells["txtCustomerAddress"].Value.ToString();
                    //  DateTime birthday = Convert.ToDateTime(dgvRow.Cells["txtCustomerBirthday"].Value.ToString().Substring(0,10));
                   DateTime birthday = DateTime.ParseExact(dgvRow.Cells["txtCustomerBirthday"].Value.ToString(), formats, new CultureInfo("en-US"), DateTimeStyles.None);
                    string phone = dgvRow.Cells["txtCustomerPhone"].Value == null ? "" : dgvRow.Cells["txtCustomerPhone"].Value.ToString();
                    int type = int.Parse(dgvRow.Cells["txtCustomerType"].Value.ToString());
                    string email = dgvRow.Cells["txtCustomerEmail"].Value == null ? "" : dgvRow.Cells["txtCustomerEmail"].Value.ToString();
                    int point = int.Parse(dgvRow.Cells["txtCustomerPoint"].Value.ToString());
                    DAOKhachHang.Instance.updateCustomer(int.Parse(dgvRow.Cells["txtCustomerID"].Value.ToString()), name, address, birthday, phone, type, email, point);
                    //if (DAOKhachHang.Instance.updateCustomer(int.Parse(dgvRow.Cells["txtCustomerID"].Value.ToString()), name, address, birthday, phone, type, email, point) &&
                    //   (dgvRow.Cells["txtCustomerID"].Value==null || int.Parse(dgvRow.Cells["txtCustomerID"].Value.ToString())!=temp))

                    //{
                    //    MessageBox.Show("Sửa thông tin khách hàng có ID= " + dgvRow.Cells["txtCustomerID"].Value.ToString() + "thành công");
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Sửa thông tin khách hàng có ID=" + dgvRow.Cells["txtCustomerID"].Value.ToString() + "thất bại");
                    //}
                }
                else
                {
                    MessageBox.Show("Chọn Thêm  để thêm thành viên");
                    //if (DAOKhachHang.Instance.insertCustomer(name, address, birthday, phone, type, email, point))

                    //{
                    //    MessageBox.Show("Thêm khách hàng thành công");
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Thêm khách hàng thất bại");
                    //}
                }
            }
            
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.Columns[e.ColumnIndex].Name=="Xóa")

            {
                clear = true;
                DataGridViewRow dgvRow = dataGridView1.CurrentRow;
                Console.WriteLine(int.Parse(dgvRow.Cells["txtCustomerID"].Value.ToString()));
                if(MessageBox.Show("Bạn có muốn xóa thành viên này?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                  
                    if (DAOKhachHang.Instance.deleteCustomer(int.Parse(dgvRow.Cells["txtCustomerID"].Value.ToString())))
                    {
                        MessageBox.Show("Xóa thành công");
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại");
                    }
                }
            }
        }

        private void TxtbSeach_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
           List<DTOKhachHang> table = DAOKhachHang.Instance.SearchData(txtbSeach.Text);
            foreach (DTOKhachHang item in table)
            {
                dataGridView1.Rows.Add(item.ID, item.HoTen, item.DiaChi, item.NgaySinh.ToString(), item.Sdt, item.LoaiKH, item.Email, item.DiemTichLuy);
            }
        }

        private void fKhachHang_Activated(object sender, EventArgs e)
        {
            if(!clear) ShowListCustomer();
            clear = false;
        }
    }
}
