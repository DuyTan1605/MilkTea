using QuanLyQuanTraSua.DataAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyQuanTraSua.DataA0;
using QuanLyQuanTraSua.DataTO;

namespace QuanLyQuanTraSua
{
    public partial class fSanPham_ChinhSua_Them : Form
    {
        public fSanPham_ChinhSua_Them()
        {
            InitializeComponent();
        }

        private void lbSize_Click(object sender, EventArgs e)
        {

        }

        private void rbBestSeller_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdSpecial_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbNormal_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnBackMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtbName.Text.ToString();
            string link = txtbPictureLink.Text.ToString();
            int price_S = int.Parse(txtbSizeS.Text.ToString());
            int price_M = int.Parse(txtbSizeS.Text.ToString());
            int price_L = int.Parse(txtbSizeS.Text.ToString());
            int check_spec = 0;
            int check_trend = 0;
            if (rbNormal.Checked)
            {
                check_spec = 0;
                check_trend = 0;
            }
            else if (rbBestSeller.Checked)
            {
                check_trend = 1;
                check_spec = 0;
            }
            else
            {
                check_spec = 1;
                check_trend = 0;
            }

            if (fSanPham.mProductID != -1)
            {
                DAOTrangChu.Instance.UpdateProductByID(fSanPham.mProductID, name, "S", price_S, check_spec, check_trend, link);
                DAOTrangChu.Instance.UpdateProductByID(fSanPham.mProductID + 1, name, "M", price_M, check_spec, check_trend, link);
                DAOTrangChu.Instance.UpdateProductByID(fSanPham.mProductID + 2, name, "L", price_L, check_spec, check_trend, link);
                this.Close();
            }
            else
            {
                if (DAOSanPham.Instance.insertProduct(name, "S", price_S, check_spec, check_trend, link) && DAOSanPham.Instance.insertProduct(name, "M", price_M, check_spec, check_trend, link)
                                                                                                         && DAOSanPham.Instance.insertProduct(name, "L", price_L, check_spec, check_trend, link))
                {
                    MessageBox.Show("Thêm món thành công");

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm món thất bại");
                    this.Close();

                }

            }
            // Console.WriteLine(name + link + price_S + check_trend + check_spec);
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

        private void btnAddProduct_Click(object sender, EventArgs e)
        {

        }

        private void fSanPham_ChinhSua_Them_Load(object sender, EventArgs e)
        {
            if (fSanPham.mProductID != -1)
            {
                txtbName.Text = fSanPham.sp.TenMon;
                txtbPictureLink.Text = fSanPham.sp.LinkAnh;
                if (fSanPham.sp.KT_BanChay == 1) rbBestSeller.Checked = true;
                else if (fSanPham.sp.KT_DatBiet == 1) rbSpecial.Checked = true;
                else rbNormal.Checked = true;
                txtbSizeS.Text = fSanPham.sp.Gia.ToString();
                DTOTrangChu spM = DAOTrangChu.Instance.getProductByID(fSanPham.mProductID + 1);
                DTOTrangChu spL = DAOTrangChu.Instance.getProductByID(fSanPham.mProductID + 2);
                txtbSizeM.Text = spM.Gia.ToString();
                txtbSizeL.Text = spL.Gia.ToString();
            }
        }

        private void fSanPham_ChinhSua_Them_FormClosed(object sender, FormClosedEventArgs e)
        {
            fSanPham.mProductID = -1;
        }
    }
}
