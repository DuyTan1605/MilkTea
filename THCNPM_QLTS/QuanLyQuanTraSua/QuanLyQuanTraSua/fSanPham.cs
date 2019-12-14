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

namespace QuanLyQuanTraSua
{
    public partial class fSanPham : Form
    {




        public static Boolean Finish = false;
        public static Int32 mProductID = -1;
        public static DTOTrangChu sp;
        private List<DTOTrangChu> table;


        public fSanPham()
        {
            InitializeComponent();
        }

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
                        Image.FromFile(fTrangChu.ImageFolder + item.LinkAnh);
                    product.PictureBox.Click += product_Click;
                    product.PictureBox.Tag = item;
                    fLPSpecial.Controls.Add(product);
                }

            }
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
                        Image.FromFile(fTrangChu.ImageFolder + item.LinkAnh);
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
                if (item.KT_BanChay == 0 && item.KT_DatBiet == 0)
                {
                    product.ProductName = item.TenMon;
                    product.Image =
                        Image.FromFile(fTrangChu.ImageFolder + item.LinkAnh);
                    product.PictureBox.Click += product_Click;
                    product.PictureBox.Tag = item;
                    fLPOrther.Controls.Add(product);
                }

            }
        }

        private void product_Click(object sender, EventArgs e)
        {
            mProductID = ((sender as PictureBox).Tag as DTOTrangChu).ID;
            sp = DAOTrangChu.Instance.getProductByID(mProductID);
            fSanPham_ChinhSua_Them f = new fSanPham_ChinhSua_Them();
            f.ShowDialog();
        }

        private void populate()
        {
            populateSpecList();
            populateBSList();
            populateOrtherList();
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnStatusProduct_Click(object sender, EventArgs e)
        {
            fTinhTrangKho fTinhtrangkho = new fTinhTrangKho();
            this.Hide();
            fTinhtrangkho.ShowDialog();
            this.Show();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            fSanPham_ChinhSua_Them fSanPham_ChinhSua_Them = new fSanPham_ChinhSua_Them();
            fSanPham_ChinhSua_Them.ShowDialog();
        }

        private void fSanPham_Activated(object sender, EventArgs e)
        {
            table = DAOTrangChu.Instance.LoadData();

            populate();

            if (fTrangChu.Finish == true)
            {
                this.Close();
            }
        }

        private void FSanPham_Load(object sender, EventArgs e)
        {
            Finish = false;
            table = DAOTrangChu.Instance.LoadData();

            populate();

            hideAutoScroll(panelSpecList);
            hideAutoScroll(panelBestSeller);
            hideAutoScroll(panelOrther);
        }
        private void hideAutoScroll(Panel panel)
        {
            int vertScrollWidth = SystemInformation.VerticalScrollBarWidth;
            int hozScrollHeight = SystemInformation.HorizontalScrollBarHeight;
            panel.Height = panel.Height - hozScrollHeight;
            panel.Width = panel.Width - vertScrollWidth;
        }




        private void BtnOtherNext_Click(object sender, EventArgs e)
        {
            int change = fLPOrther.HorizontalScroll.Value + fLPOrther.HorizontalScroll.SmallChange * 20;
            fLPOrther.AutoScrollPosition = new Point(change, 0);
        }

        private void BtnOtherPrevious_Click(object sender, EventArgs e)
        {
            int change = fLPOrther.HorizontalScroll.Value - fLPOrther.HorizontalScroll.SmallChange * 20;
            fLPOrther.AutoScrollPosition = new Point(change, 0);
        }

        private void BtnBSPrevious_Click(object sender, EventArgs e)
        {
            int change = fLPBestSeller.HorizontalScroll.Value - fLPBestSeller.HorizontalScroll.SmallChange * 20;
            fLPBestSeller.AutoScrollPosition = new Point(change, 0);
        }

        private void BtnBSNext_Click(object sender, EventArgs e)
        {
            int change = fLPBestSeller.HorizontalScroll.Value + fLPBestSeller.HorizontalScroll.SmallChange * 20;
            fLPBestSeller.AutoScrollPosition = new Point(change, 0);
        }

        private void BtnSpecPrevious_Click(object sender, EventArgs e)
        {
            int change = fLPSpecial.HorizontalScroll.Value - fLPSpecial.HorizontalScroll.SmallChange * 20;
            fLPSpecial.AutoScrollPosition = new Point(change, 0);
        }

        private void BtnSpecNext_Click(object sender, EventArgs e)
        {
            int change = fLPSpecial.HorizontalScroll.Value + fLPSpecial.HorizontalScroll.SmallChange * 20;
            fLPSpecial.AutoScrollPosition = new Point(change, 0);
        }

        private void TxtbSearch_TextChanged(object sender, EventArgs e)
        {
            table.Clear();
            table = DAOTrangChu.Instance.SearchData(txtbSearch.Text);
            populate();
        }

        private void fSanPham_FormClosed(object sender, FormClosedEventArgs e)
        {
            mProductID = -1;
        }
    }
}
