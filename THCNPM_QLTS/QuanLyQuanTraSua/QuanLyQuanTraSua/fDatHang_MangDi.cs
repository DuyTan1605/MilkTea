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
    public partial class fDatHang_MangDi : Form
    {
        public int KT_Ship = 0;
        public fDatHang_MangDi()
        {
            InitializeComponent();
        }

        private void fDatHang_MangDi_Load(object sender, EventArgs e)
        {
            KT_Ship = 1;
            fLPHoaDon.Controls.Clear();
            foreach (DetailBill item in fDatHang.flpHoaDon.Controls)
            {
                DetailBill detailBill = new DetailBill(item);
                detailBill.BtnDelete.Enabled = false;
                detailBill.BtnEdit.Enabled = false;
                fLPHoaDon.Controls.Add(detailBill);
            }
            btnMangDi.Enabled = false;
            txtbIDHoaDon.Text = fDatHang.mBillID.ToString();
            txtbTongTien.Text = fDatHang.mTongTien.ToString();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            KT_Ship = 0;
            this.Hide();
            this.Close();
            fThanhToan fThanhToan = new fThanhToan();
            fThanhToan.ShowDialog();
        }


        private void btnBenThu3_Click(object sender, EventArgs e)
        {
            fDatHang_MangDi_BenThu3 fDatHangMangDiBenThu3 = new fDatHang_MangDi_BenThu3();
            fDatHangMangDiBenThu3.ShowDialog();
        }

        private void btnQuan_Click(object sender, EventArgs e)
        {
            fDatHang_MangDi_ShopShip fDatHangMangDiShopShip = new fDatHang_MangDi_ShopShip();
            fDatHangMangDiShopShip.ShowDialog();
        }

        private void fDatHang_MangDi_Activated(object sender, EventArgs e)
        {
            KT_Ship = 1;
            if (fTrangChu.Finish)
                this.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DAOHoaDon.Instance.DeleteBillByID(fDatHang.mBillID);
            fTrangChu.Finish = true; //
            this.Close(); //

        }

        private void fLPHoaDon_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fDatHang_MangDi_FormClosed(object sender, FormClosedEventArgs e)
        {
            KT_Ship = 0;
        }
    }
}
