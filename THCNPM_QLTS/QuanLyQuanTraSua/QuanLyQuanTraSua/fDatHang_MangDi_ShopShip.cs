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
using QuanLyQuanTraSua.DataTO;

namespace QuanLyQuanTraSua
{
    public partial class fDatHang_MangDi_ShopShip : Form
    {
        public fDatHang_MangDi_ShopShip()
        {
            InitializeComponent();
        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            DTOHoaDon bill = new DTOHoaDon(fDatHang.mBillID, -1, DateTime.Now, null, 1);
            DAOHoaDon.Instance.UpdateBillByID(fDatHang.mBillID, bill);
            string nguoiGiao, sdtNguoiGiao, nguoiNhan, sdtNguoiNhan, diaChi;
            nguoiGiao = string.Format("N'{0}'", txtbNguoiGiao.Text);
            sdtNguoiGiao = string.Format("'{0}'", txtbSDTNguoiGiao.Text);
            nguoiNhan = string.Format("N'{0}'", txtbNguoiNhan.Text);
            sdtNguoiNhan = string.Format("'{0}'", txtbSDTNguoiNhan.Text);
            diaChi = string.Format("N'{0}'", txtbDiaChi.Text);
            DAOShip.Instance.InsertShip(fDatHang.mBillID, null, nguoiGiao,sdtNguoiGiao,nguoiNhan,sdtNguoiNhan,diaChi);
            fTrangChu.Finish = true;
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fDatHang_MangDi_ShopShip_Load(object sender, EventArgs e)
        {
            lbIDHoaDon.Text = fDatHang.mBillID.ToString();
        }

        private void fDatHang_MangDi_ShopShip_Activated(object sender, EventArgs e)
        {
            if (fTrangChu.Finish)
                this.Close();
        }

        private void lbShopShip_Click(object sender, EventArgs e)
        {

        }
    }
}
