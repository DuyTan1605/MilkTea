using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanTraSua
{
    public partial class Product : UserControl
    {
        public PictureBox PictureBox;
        public Product()
        {
            InitializeComponent();
            PictureBox = picProduct;
        }

        #region Properties

        private Image _image;

        [Category("Custom Props")]
        public Image Image
        {
            get { return _image; }
            set { _image = value;
                picProduct.Image = value;
            }
        }

        private string _productName;

        [Category("Custom Props")]
        public string ProductName
        {
            get { return _productName; }
            set { _productName = value;
                tbProductName.Text = value;
            }
        }

        #endregion

        private void Product_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Silver;
        }

        private void Product_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Control;
        }
    }
}
