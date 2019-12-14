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
    public partial class fThanhToan_Thuong : Form
    {
        private int money = fDatHang.mTongTien;
        bool thanhtoanThe;
        public fThanhToan_Thuong()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            string hinhThucThanhToan = null;
            if (thanhtoanThe)
            {
                hinhThucThanhToan = "Thẻ ngân hàng";
            }
            else
            {
                hinhThucThanhToan = "Tiền mặt";
            }
            DAOHoaDon.Instance.UpdateHinhThucThanhToan(fDatHang.mBillID,hinhThucThanhToan);
            DAOHoaDon.Instance.UpdateKTShip(fDatHang.mBillID,0);
            DAOHoaDon.Instance.UpdateNgayDat(fDatHang.mBillID,DateTime.Now);
            if (fThanhToan_ThanhVien.khachHang != null)
            {
                int p;
                if (fThanhToan_ThanhVien.Point)
                    p = fThanhToan_ThanhVien.khachHang.DiemTichLuy + fThanhToan_ThanhVien.PointReceive -
                        fDatHang.mTongTien / 1000;
                else
                    p = fThanhToan_ThanhVien.khachHang.DiemTichLuy + fThanhToan_ThanhVien.PointReceive;
                if (p < 0) p = 0;
                DAOKhachHang.Instance.UpdatePoint(fThanhToan_ThanhVien.khachHang.ID,p);
            }

            fTrangChu.Finish = true;
            this.Close();
        }

        private void rbtnCast_CheckedChanged(object sender, EventArgs e)
        {
            if (!rbtnCast.Checked)
            {
                disableNumericUpDown(nUDTienNhanDuoc);
                disableNumericUpDown(nUDTienThoi);
                thanhtoanThe = true;
            }
            else
            {
                nUDTienNhanDuoc.Value = money;
                nUDTienNhanDuoc.Minimum = money;
                nUDTienThoi.Value = 0;
                enableNumericUpDown(nUDTienNhanDuoc);
                enableNumericUpDown(nUDTienThoi);
                thanhtoanThe = false;
            }
        }

        private void disableNumericUpDown(NumericUpDown nUD)
        {
            nUD.ReadOnly = true;
            nUD.Controls[0].Visible = false;
        }

        private void enableNumericUpDown(NumericUpDown nUD)
        {
            nUD.ReadOnly = false;
            nUD.Controls[0].Visible = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fThanhToan_Thuong_Activated(object sender, EventArgs e)
        {
            if (fTrangChu.Finish) this.Close();
        }

        private void fThanhToan_Thuong_Load(object sender, EventArgs e)
        {
            money = fDatHang.mTongTien;
            if (fThanhToan_ThanhVien.Point)
            {
                money -= (fThanhToan_ThanhVien.khachHang.DiemTichLuy + fThanhToan_ThanhVien.PointReceive) * 1000;
                if (money < 0) money = 0;
            }
            disableNumericUpDown(nUDTienThoi);
            txtbTotalMoney.Text = money.ToString();
            nUDTienNhanDuoc.Value = money;
            nUDTienNhanDuoc.Minimum = money;
            nUDTienThoi.Value = 0;
            rbtnCast.Checked = true;
            thanhtoanThe = false;
            lbDateOfPayment.Text = DateTime.Today.ToString("dd-MM-yyyy");
        }

        private void nUDTienNhanDuoc_ValueChanged(object sender, EventArgs e)
        {
            nUDTienThoi.Value = nUDTienNhanDuoc.Value - money;
        }
    }
}
