using QuanLyQuanTraSua.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanTraSua
{
    public partial class fBenThuBa : Form
    {
        public fBenThuBa()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FBenThuBa_Load(object sender, EventArgs e)
        {
            DataTable x = DataProvider.Instance.ExcuteQuery("SELECT ID_HoaDon FROM SHIP WHERE ID_Shipper IS NOT NULL");
            int[] res = new int[100];
            int dem = 0;
            foreach (DataRow i in x.Rows)
            {
                res[dem] = (int)i["ID_HoaDon"];
                dem++;
            }
            int[] res1 = new int[100];
            int dem1 = 0;
            for (int i = 0; i < res.Length; i++)
            {
                DataTable x1 = DataProvider.Instance.ExcuteQuery("SELECT ID_Mon FROM CHITIETHOADON WHERE ID_HoaDon=" + res[i]);
                foreach (DataRow j in x1.Rows)
                {
                    res1[dem1] = (int)j["ID_Mon"];
                    dem1++;
                }
            }

            DataTable data = DataProvider.Instance.ExcuteQuery("SELECT * FROM SHIP WHERE ID_Shipper IS NOT NULL");
            int S = 0;
            for (int i = 0; i < res1.Length; i++)
            {
                DataTable x2 = DataProvider.Instance.ExcuteQuery("SELECT Gia FROM MON WHERE ID=" + res1[i]);
                foreach (DataRow j in x2.Rows)
                {
                    S += (int)j["Gia"];
                }
            }
            Console.WriteLine(S);
            txtbTotal.Text = (data.Rows.Count).ToString();
            dataGridView1.DataSource = data;
            txtbMoney.Text = S.ToString() + " VND";
        
    }
    }
}
