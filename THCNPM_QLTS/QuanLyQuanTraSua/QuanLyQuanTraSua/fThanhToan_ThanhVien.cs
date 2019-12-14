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
    public partial class fThanhToan_ThanhVien : Form
    {
        public static bool Point = false;
        public static int PointReceive;
        public static DTOKhachHang khachHang = null;
        public fThanhToan_ThanhVien()
        {
            InitializeComponent();
        }

        private void fThanhToan_ThanhVien_Load(object sender, EventArgs e)
        {
            PointReceive = (fDatHang.mTongTien * 5) / 100000;
            txtbAccumulatedPointsReceived.Text = PointReceive.ToString();
            rbtnNo.Checked = true;
            btnNext.Enabled = false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
          //  fTrangChu.Finish = true;
          // this.Close();
            DAOHoaDon.Instance.UpdateIDKhachHang(fDatHang.mBillID, khachHang.ID);
            fThanhToan_Thuong fThanhToan_Thuong = new fThanhToan_Thuong();
            fThanhToan_Thuong.ShowDialog();
        }

        private void rbtnYes_CheckedChanged_1(object sender, EventArgs e)
        {
        }

        private void rbtnNo_CheckedChanged(object sender, EventArgs e)
        {
            if (!rbtnNo.Checked)
                Point = true;
            else Point = false;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DAOHoaDon.Instance.UpdateIDKhachHang(fDatHang.mBillID, -1);
            this.Close();
        }

        private void fThanhToan_ThanhVien_Activated(object sender, EventArgs e)
        {
            if (fTrangChu.Finish) this.Close();
        }

        private void txtbPhone_TextChanged(object sender, EventArgs e)
        {
            khachHang = DAOKhachHang.Instance.GetKhachHangBySDT(txtbPhone.Text);
            if (khachHang != null)
            {
                btnNext.Enabled = true;
                txtbName.Text = khachHang.HoTen;
                txtbAccumulatedPoints.Text = khachHang.DiemTichLuy.ToString();
            }
            else
            {
                btnNext.Enabled = false;
                txtbName.Text = "";
                txtbAccumulatedPoints.Text = "";
            }
        }
    }
}
