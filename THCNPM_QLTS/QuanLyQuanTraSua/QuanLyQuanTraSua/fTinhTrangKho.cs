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
    public partial class fTinhTrangKho : Form
    {
        private bool clear = false;
        void loadListMaterial()
        {
            List<DTOTinhTrangKho> table = DAOTinhTrangKho.Instance.LoadData();
            foreach (DTOTinhTrangKho item in table)
            {
                Console.WriteLine(item.ID +item.TenNguyenLieu + item.TinhTrang + item.NgayNhap + item.XuatXu + item.TinhTrang);
            }
        }
        void ShowListMaterial()
        {
            List<DTOTinhTrangKho> table = DAOTinhTrangKho.Instance.LoadData();
            dataGridView1.Rows.Clear();
            foreach (DTOTinhTrangKho item in table)
            {
                dataGridView1.Rows.Add(item.ID, item.TenNguyenLieu,item.XuatXu,item.NgayNhap,item.TinhTrang);
            }

        }
        DTOTinhTrangKho getMaterialById(int id)
        {
            List<DTOTinhTrangKho> table = DAOTinhTrangKho.Instance.LoadData();
            DTOTinhTrangKho temp = null;
            foreach (DTOTinhTrangKho item in table)
            {
               if(item.ID==id)
                {
                    temp = item;
                }
            }
            return temp;
        }

       
        public fTinhTrangKho()
        {
            InitializeComponent();
           
            //Console.WriteLine(getMaterialById(1).TenNguyenLieu);
        }

        //Thieu sua,xoa cho nguyen lieu
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            List<DTOTinhTrangKho> table = DAOTinhTrangKho.Instance.SearchData(txtbSearch.Text);
            foreach (DTOTinhTrangKho item in table)
            {
                dataGridView1.Rows.Add(item.ID, item.TenNguyenLieu,item.XuatXu,item.NgayNhap,item.TinhTrang);
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            fThemNguyenLieu fThemNguyenLieu = new fThemNguyenLieu();
            this.Hide();
            fThemNguyenLieu.ShowDialog();
            this.Show();
        }

        private void FTinhTrangKho_Load_1(object sender, EventArgs e)
        {
            ShowListMaterial();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Xóa")

            {
                clear = true;
                DataGridViewRow dgvRow = dataGridView1.CurrentRow;
                Console.WriteLine(int.Parse(dgvRow.Cells["txtIDMaterial"].Value.ToString()));
                if (MessageBox.Show("Bạn có muốn xóa nguyên liệu này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    if (DAOTinhTrangKho.Instance.deleteMaterial(int.Parse(dgvRow.Cells["txtIDMaterial"].Value.ToString())))
                    {
                        MessageBox.Show("Xóa nguyên liệu thành công");
                    }
                    else
                    {
                        MessageBox.Show("Xóa nguyên liệu thất bại");
                    }
                }
            }
        }

        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            string[] formats = {"M/d/yyyy h:mm:ss tt", "M/d/yyyy h:mm tt",
                     "MM/dd/yyyy hh:mm:ss", "M/d/yyyy h:mm:ss",
                     "M/d/yyyy hh:mm tt", "M/d/yyyy hh tt",
                     "M/d/yyyy h:mm", "M/d/yyyy h:mm",
                     "MM/dd/yyyy hh:mm", "M/dd/yyyy hh:mm",
                     "MM/d/yyyy HH:mm:ss.ffffff" };
            if (dataGridView1.CurrentRow != null)
            {
                DataGridViewRow dgvRow = dataGridView1.CurrentRow;
                if (dgvRow.Cells["txtIDMaterial"].Value != null)
                {
                    int temp = int.Parse(dgvRow.Cells["txtIDMaterial"].Value.ToString());
                    string name = dgvRow.Cells["txtNameMaterial"].Value == null ? "" : dgvRow.Cells["txtNameMaterial"].Value.ToString();

                    string address = dgvRow.Cells["txtComeFrom"].Value == null ? "" : dgvRow.Cells["txtComeFrom"].Value.ToString();
                    //  DateTime birthday = Convert.ToDateTime(dgvRow.Cells["txtCustomerBirthday"].Value.ToString().Substring(0,10));
                    DateTime dateimport = DateTime.ParseExact(dgvRow.Cells["txtDayImport"].Value.ToString(), formats, new CultureInfo("en-US"), DateTimeStyles.None);
                    string status = dgvRow.Cells["txtStatus"].Value == null ? "" : dgvRow.Cells["txtStatus"].Value.ToString();
                   DAOTinhTrangKho.Instance.updateMaterial(name,address,dateimport,status, int.Parse(dgvRow.Cells["txtIDMaterial"].Value.ToString()));
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
                    MessageBox.Show("Chọn Thêm  để thêm nguyên liệu");
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

        private void fTinhTrangKho_Activated(object sender, EventArgs e)
        {
            if(!clear) ShowListMaterial();
            clear = false;
        }
    }
}
