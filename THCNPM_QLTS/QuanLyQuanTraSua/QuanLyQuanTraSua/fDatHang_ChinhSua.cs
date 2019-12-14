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
using QuanLyQuanTraSua.DataAO;
using QuanLyQuanTraSua.DataTO;

namespace QuanLyQuanTraSua
{
    public partial class fDatHang_ChinhSua : Form
    {
        private DTOTrangChu product;
        public static Boolean update = false;
        public static DetailBill detailBillUpdate;
        public fDatHang_ChinhSua()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            update = false;
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int size = cboBoxSize.SelectedIndex;
            int amount = (int)numericAmount.Value;
            
            if (size != 0)
                product = DAOTrangChu.Instance.getProductByID(fDatHang.mProductID + size);
            if (!update)
            {
                for (int i = 0; i < amount; i++)
                {
                    DTOChiTietHoaDon cthd = DAOChiTietHoaDon.Instance.InsertNewDetailBill(fDatHang.mBillID, fDatHang.mProductID + size, cboBoxToppingSugar.Text, cboBoxToppingIce.Text,
                        cboBoxSmell.Text, cboBoxTopping.Text, txtbNote.Text);
                    DetailBill detailBill = new DetailBill();
                    detailBill.ID = cthd.ID;
                    detailBill.IDBill = cthd.IDHoaDon;
                    detailBill.IDProduct = fDatHang.mProductID;
                    detailBill.Name = product.TenMon;
                    detailBill.Price = product.Gia;
                    detailBill.SizeValue = cboBoxSize.Text;
                    detailBill.BtnEdit.Click += editDetailBill;
                    detailBill.BtnEdit.Tag = detailBill;
                    detailBill.BtnDelete.Click += deleteDetailBill;
                    detailBill.BtnDelete.Tag = detailBill;
                    fDatHang.flpHoaDon.Controls.Add(detailBill);
                    fDatHang.mTongTien += product.Gia;
                }
            }
            else
            {
                fDatHang.mTongTien -= detailBillUpdate.Price;
                detailBillUpdate.Price = product.Gia;
                fDatHang.mTongTien += detailBillUpdate.Price;
                detailBillUpdate.SizeValue = cboBoxSize.Text;
                int index = fDatHang.flpHoaDon.Controls.GetChildIndex(detailBillUpdate);
                fDatHang.flpHoaDon.Controls.Add(detailBillUpdate);
                fDatHang.flpHoaDon.Controls.SetChildIndex(detailBillUpdate,index);
                DAOChiTietHoaDon.Instance.UpdateDetailBillInfoByID(detailBillUpdate.ID,detailBillUpdate.IDProduct + size,cboBoxToppingSugar.Text,cboBoxToppingIce.Text, cboBoxSmell.Text, cboBoxTopping.Text, txtbNote.Text);
            }

            this.Close();
        }

        private void deleteDetailBill(object sender, EventArgs e)
        {
            DetailBill detailBill = (sender as Button).Tag as DetailBill;
            fDatHang.mTongTien -= detailBill.Price;
            fDatHang.flpHoaDon.Controls.Remove(detailBill);
            DAOChiTietHoaDon.Instance.DeleteDetailBillByID(detailBill.ID);
        }

        private void editDetailBill(object sender, EventArgs e)
        {
            DetailBill detailBill = (sender as Button).Tag as DetailBill;
            fDatHang.mProductID = detailBill.IDProduct;
            fDatHang_ChinhSua.detailBillUpdate = detailBill;
            fDatHang_ChinhSua.update = true;
            fDatHang_ChinhSua f = new fDatHang_ChinhSua();
            f.ShowDialog();
        }

        private void fDatHang_ChinhSua_Load(object sender, EventArgs e)
        {
            product = DAOTrangChu.Instance.getProductByID(fDatHang.mProductID);
            pictureBoxProduct.Image = Image.FromFile(fTrangChu.ImageFolder + product.LinkAnh);
            lbProductName.Text = product.TenMon;
            if (update)
            {
                DTOChiTietHoaDon cthd =
                    DAOChiTietHoaDon.Instance.GetDetailBillByID(detailBillUpdate.ID);
                numericAmount.ReadOnly = true;
                cboBoxSize.Text = detailBillUpdate.SizeValue;
                cboBoxSmell.Text = cthd.Huong;
                cboBoxToppingIce.Text = cthd.Da;
                cboBoxToppingSugar.Text = cthd.Duong;
                cboBoxTopping.Text = cthd.Topping;
                txtbNote.Text = cthd.Note;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            fTrangChu.Finish = true; //
            this.Close(); //
        }

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
            this.Hide();
            fThanhToan.ShowDialog();
            this.Show();
        }

        private void fDatHang_ChinhSua_Activated(object sender, EventArgs e)
        {
            if (fTrangChu.Finish)
                this.Close();
        }

        private void fDatHang_ChinhSua_Leave(object sender, EventArgs e)
        {
            update = false;
            MessageBox.Show("Leave");
        }

        private void fDatHang_ChinhSua_FormClosed(object sender, FormClosedEventArgs e)
        {
            update = false;
        }
    }
}
