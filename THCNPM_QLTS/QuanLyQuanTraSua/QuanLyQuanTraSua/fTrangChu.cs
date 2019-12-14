using QuanLyQuanTraSua.DataA0;
using QuanLyQuanTraSua.DataTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace QuanLyQuanTraSua
{
    public partial class fTrangChu : Form
    {
        public static Boolean Finish = false;
        public static Int32 mProductID = -1;
        private List<DTOTrangChu> table;

        public static string ImageFolder =
            @"C:\Users\HA DUY TAN\Documents\img\";
        #region methodDatabase
        void clearFLP(FlowLayoutPanel fLP)
        {
            fLP.Controls.Clear();
        }

        void populateSpecList()     // Tra ve list mon
        {
            clearFLP(fLPSpecial);
            foreach (DTOTrangChu item in table)
            {
                //Console.WriteLine(item.ID + item.Size + item.TenMon + item.Gia + ' ' + item.KT_BanChay + ' ' + item.KT_DatBiet + item.LinkAnh);  //test
                if (item.KT_DatBiet == 1)
                {
                    Product product = new Product();
                    product.ProductName = item.TenMon;
                    product.Image =
                        Image.FromFile(ImageFolder + item.LinkAnh);
                    product.PictureBox.Click += product_Click;
                    product.PictureBox.Tag = item;
                    fLPSpecial.Controls.Add(product);
                }

            }
        }

        private void product_Click(object sender, EventArgs e)
        {
            mProductID = ((sender as PictureBox).Tag as DTOTrangChu).ID;
            btnOrder_Click(sender, e);
        }

        void populateBSList()     // Tra ve list mon
        {
            clearFLP(fLPBestSeller);
            foreach (DTOTrangChu item in table)
            {
                Product product = new Product();
                //Console.WriteLine(item.ID + item.Size + item.TenMon + item.Gia + ' ' + item.KT_BanChay + ' ' + item.KT_DatBiet + item.LinkAnh);  //test
                if (item.KT_BanChay == 1)
                {
                    product.ProductName = item.TenMon;
                    product.Image =
                        Image.FromFile(ImageFolder+item.LinkAnh);
                    product.PictureBox.Click += product_Click;
                    product.PictureBox.Tag = item;
                    fLPBestSeller.Controls.Add(product);
                }

            }
        }

        void populateOrtherList()     // Tra ve list mon
        {
            clearFLP(fLPOrther);
            foreach (DTOTrangChu item in table)
            {
                Product product = new Product();
                //Console.WriteLine(item.ID + item.Size + item.TenMon + item.Gia + ' ' + item.KT_BanChay + ' ' + item.KT_DatBiet + item.LinkAnh);  //test
                if (item.KT_BanChay == 0 && item.KT_DatBiet==0)
                {
                    product.ProductName = item.TenMon;
                    product.Image =
                        Image.FromFile(ImageFolder+item.LinkAnh);
                    product.PictureBox.Click += product_Click;
                    product.PictureBox.Tag = item;
                    fLPOrther.Controls.Add(product);
                }

            }
        }

        DTOTrangChu ShowDetail(int id)
        {
            List<DTOTrangChu> table = DAOTrangChu.Instance.LoadData();
            DTOTrangChu temp=null;
            foreach (DTOTrangChu item in table)
            {
                if (item.ID == id)
                {
                    Console.WriteLine(item.ID + item.TenMon + item.Gia + ' ' + item.KT_BanChay + ' ' + item.KT_DatBiet + item.LinkAnh);
                    temp = item;
                }
            }
            return temp;
        }// tra ve thong tin cu the cua mon thong qua id
        #endregion

        #region implement
        public fTrangChu()
        {
            InitializeComponent();

            //LoadListDrink(); // test danh sach mon bang console.writeline
           ShowDetail(2); //test id mon  bang console.writeline
        }

        private void populate()
        {
            populateSpecList();
            populateBSList();
            populateOrtherList();
        }

        private void fTrangChu_Load(object sender, EventArgs e)
        {
            Finish = false;
            table = DAOTrangChu.Instance.LoadData();
            populate();
            hideAutoScroll(panelSpecList);
            hideAutoScroll(panelBestSeller);
            hideAutoScroll(panelOrther);
        }
        #endregion

        #region event

        private void btnOrder_Click(object sender, EventArgs e)
        {
            fDatHang fDatHang = new fDatHang();
            this.Hide();
            fDatHang.ShowDialog();
            this.Show();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            fKhachHang fKhachHang = new fKhachHang();
            this.Hide();
            fKhachHang.ShowDialog();
            this.Show();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            fSanPham fSanPham = new fSanPham();
            this.Hide();
            fSanPham.ShowDialog();
            this.Show();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            fBaocao fBaocao = new fBaocao();
            this.Hide();
            fBaocao.ShowDialog();
            this.Show();
        }

        private void fTrangChu_Activated(object sender, EventArgs e)
        {
            Finish = false;
        }

        private void btnSpecNext_Click(object sender, EventArgs e)
        {
            int change = fLPSpecial.HorizontalScroll.Value + fLPSpecial.HorizontalScroll.SmallChange * 20;
            fLPSpecial.AutoScrollPosition = new Point(change, 0);
        }

        private void btnSpecPrevious_Click(object sender, EventArgs e)
        {
            int change = fLPSpecial.HorizontalScroll.Value - fLPSpecial.HorizontalScroll.SmallChange * 20;
            fLPSpecial.AutoScrollPosition = new Point(change, 0);

        }

        private void btnBSNext_Click(object sender, EventArgs e)
        {
            int change = fLPBestSeller.HorizontalScroll.Value + fLPBestSeller.HorizontalScroll.SmallChange * 20;
            fLPBestSeller.AutoScrollPosition = new Point(change, 0);
        }

        private void btnBSPrevious_Click(object sender, EventArgs e)
        {
            int change = fLPBestSeller.HorizontalScroll.Value - fLPBestSeller.HorizontalScroll.SmallChange * 20;
            fLPBestSeller.AutoScrollPosition = new Point(change, 0);
        }

        private void btnOtherNext_Click(object sender, EventArgs e)
        {
            int change = fLPOrther.HorizontalScroll.Value + fLPOrther.HorizontalScroll.SmallChange * 20;
            fLPOrther.AutoScrollPosition = new Point(change, 0);
        }

        private void btnOtherPrevious_Click(object sender, EventArgs e)
        {
            int change = fLPOrther.HorizontalScroll.Value - fLPOrther.HorizontalScroll.SmallChange * 20;
            fLPOrther.AutoScrollPosition = new Point(change, 0);
        }
        private void txtbSearch_TextChanged(object sender, EventArgs e)
        {
            table.Clear();
            table = DAOTrangChu.Instance.SearchData(txtbSearch.Text);
            populate();
        }
        #endregion

        #region helper
        private void hideAutoScroll(Panel panel)
        {
            int vertScrollWidth = SystemInformation.VerticalScrollBarWidth;
            int hozScrollHeight = SystemInformation.HorizontalScrollBarHeight;
            panel.Height = panel.Height - hozScrollHeight;
            panel.Width = panel.Width - vertScrollWidth;
        }
        #endregion
    }
}
