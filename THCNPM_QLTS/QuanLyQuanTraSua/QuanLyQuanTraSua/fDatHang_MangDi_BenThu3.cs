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
    public partial class fDatHang_MangDi_BenThu3 : Form
    {
        public static string doiTac;
        public fDatHang_MangDi_BenThu3()
        {
            InitializeComponent();
        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            DTOHoaDon bill = new DTOHoaDon(fDatHang.mBillID,-1,DateTime.Now, null,1);
            DAOHoaDon.Instance.UpdateBillByID(fDatHang.mBillID,bill);
            DAOShip.Instance.InsertShip(fDatHang.mBillID,doiTac,"NULL", "NULL", "NULL", "NULL", "NULL");
            fTrangChu.Finish = true;
            this.Close();
        }

        private void btnVato_Click(object sender, EventArgs e)
        {
            doiTac = "Vato";
        }

        private void btnGrab_Click(object sender, EventArgs e)
        {
            doiTac = "Grab";
        }

        private void btnGoViet_Click(object sender, EventArgs e)
        {
            doiTac = "Go Viet";
        }

        private void btnBeamin_Click(object sender, EventArgs e)
        {
            doiTac = "Baemin";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fDatHang_MangDi_BenThu3_Activated(object sender, EventArgs e)
        {
            if (fTrangChu.Finish)
                this.Close();
        }

        private void fDatHang_MangDi_BenThu3_Load(object sender, EventArgs e)
        {

        }
    }
}
