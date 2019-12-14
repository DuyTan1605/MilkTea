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
    public partial class fThanhToan : Form
    {
        bool normalCustomer;
        public fThanhToan()
        {
            InitializeComponent();
        }

        private void btnCloseCuctomer_Click(object sender, EventArgs e)
        {
            fThanhToan_ThanhVien fThanhToan_ThanhVien = new fThanhToan_ThanhVien();
            fThanhToan_ThanhVien.ShowDialog();
        }

        private void btnMangDi_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            fDatHang_MangDi fDatHangMangDi = new fDatHang_MangDi();
            fDatHangMangDi.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DAOHoaDon.Instance.DeleteBillByID(fDatHang.mBillID);
            fTrangChu.Finish = true; 
            this.Close(); //
        }

        private void fThanhToan_Load(object sender, EventArgs e)
        {
            btnThanhToan.Enabled = false;
            fLPHoaDon.Controls.Clear();
            foreach (DetailBill item in fDatHang.flpHoaDon.Controls)
            {
                DetailBill detailBill = new DetailBill(item);
                detailBill.BtnDelete.Enabled = false;
                detailBill.BtnEdit.Enabled = false;
                fLPHoaDon.Controls.Add(detailBill);
            }
            txtbIDHoaDon.Text = fDatHang.mBillID.ToString();
            txtbTongTien.Text = fDatHang.mTongTien.ToString();
        }

        private void fThanhToan_Activated(object sender, EventArgs e)
        {
            if (fTrangChu.Finish)
                this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNormalCustomer_Click(object sender, EventArgs e)
        {
            fThanhToan_Thuong fThanhToan_Thuong = new fThanhToan_Thuong();
            fThanhToan_Thuong.ShowDialog();
        }
    }
}
