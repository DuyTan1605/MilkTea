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
using QuanLyQuanTraSua.DataAO;

namespace QuanLyQuanTraSua
{
    public partial class fDatHang : Form
    {
        private List<DTOTrangChu> table;
        public static int mProductID = -1;
        public static int mBillID = -1;
        public static FlowLayoutPanel flpHoaDon;
        public static int mTongTien = 0;
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
                Product product = new Product();
                //Console.WriteLine(item.ID + item.Size + item.TenMon + item.Gia + ' ' + item.KT_BanChay + ' ' + item.KT_DatBiet + item.LinkAnh);  //test
                if (item.KT_DatBiet == 1)
                {
                    product.ProductName = item.TenMon;
                    product.Image =
                        Image.FromFile(fTrangChu.ImageFolder+item.LinkAnh);
                    product.PictureBox.Click += product_Click;
                    product.PictureBox.Tag = item;
                    fLPSpecial.Controls.Add(product);
                }

            }
        }

        private void product_Click(object sender, EventArgs e)
        {
            mProductID = ((sender as PictureBox).Tag as DTOTrangChu).ID;
            fDatHang_ChinhSua f = new fDatHang_ChinhSua();
            f.ShowDialog();
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

        DTOTrangChu ShowDetail(int id)
        {
            List<DTOTrangChu> table = DAOTrangChu.Instance.LoadData();
            DTOTrangChu temp = null;
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
        public fDatHang()
        {
            InitializeComponent();
        }

        private void populate()
        {
            populateSpecList();
            populateBSList();
            populateOrtherList();
        }
        private void fDatHang_Load(object sender, EventArgs e)
        {
            table = DAOTrangChu.Instance.LoadData();
            populate();
            hideAutoScroll(panelSpecList);
            hideAutoScroll(panelBestSeller);
            hideAutoScroll(panelOrther);
            mProductID = fTrangChu.mProductID;
            flpHoaDon = fLPHoaDon;
            if (fTrangChu.mProductID == -1)
            {
                mBillID = DAOHoaDon.Instance.InsertNewBill();
            }
        }
        #endregion

        #region event

        private void btnMangDi_Click(object sender, EventArgs e)
        {
            fDatHang_MangDi fDatHangMangDi = new fDatHang_MangDi();
            this.Hide();
            fDatHangMangDi.ShowDialog();
            this.Show();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            fThanhToan fThanhToan = new fThanhToan();
            fThanhToan.ShowDialog();
            this.Show();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DAOHoaDon.Instance.DeleteBillByID(fDatHang.mBillID);
            this.Close(); //
        }

        private void fDatHang_Activated(object sender, EventArgs e)
        {
            if (fTrangChu.Finish)
                this.Close();
            if (fTrangChu.mProductID != -1)
            {
                fTrangChu.mProductID = -1;
                mBillID = DAOHoaDon.Instance.InsertNewBill();
                fDatHang_ChinhSua fdatHangChinhSua = new fDatHang_ChinhSua();
                fdatHangChinhSua.ShowDialog();
            }
            txtbTongTien.Text = mTongTien.ToString();
            txtbIDHoaDon.Text = mBillID.ToString();
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

        private void fLPHoaDon_ControlRemoved(object sender, ControlEventArgs e)
        {
            txtbTongTien.Text = mTongTien.ToString();
        }

        private void fDatHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            mProductID = -1;
            mBillID = -1;
            mTongTien = 0;
        }

        private void txtbIDHoaDon_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
