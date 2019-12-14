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
    public partial class fBaocao : Form
    {
        public fBaocao()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            fBaoCaoThang fBaoCaoThang    = new fBaoCaoThang();
            this.Hide();
            fBaoCaoThang.ShowDialog();
            this.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            fTaiCuaHang fTaiCuaHang = new fTaiCuaHang();
            this.Hide();
            fTaiCuaHang.ShowDialog();
            this.Show();
        }

        private void fBaocao_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            fBenThuBa fBenThuBa = new fBenThuBa();
            this.Hide();
            fBenThuBa.ShowDialog();
            this.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fBaoCaoNgay fBaoCaoNgay = new fBaoCaoNgay();
            this.Hide();
            fBaoCaoNgay.ShowDialog();
            this.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            fBaoCaoNam fBaoCaoNam = new fBaoCaoNam();
            this.Hide();
            fBaoCaoNam.ShowDialog();
            this.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            fDatGiaoHang fDatGiaoHang = new fDatGiaoHang();
            this.Hide();
            fDatGiaoHang.ShowDialog();
            this.Show();
        }
    }
}
