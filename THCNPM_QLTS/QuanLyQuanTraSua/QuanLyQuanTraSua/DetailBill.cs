using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyQuanTraSua.DataTO;

namespace QuanLyQuanTraSua
{
    public partial class DetailBill : UserControl
    {
        public Button BtnEdit;
        public Button BtnDelete;
        public DetailBill()
        {
            InitializeComponent();
            BtnEdit = btnEdit;
            BtnDelete = btnDelete;
        }

        public DetailBill(DetailBill detailBill)
        {
            InitializeComponent();
            ID = detailBill.ID;
            IDBill = detailBill.IDBill;
            IDProduct = detailBill.IDProduct;
            Name = detailBill.Name;
            Price = detailBill.Price;
            SizeValue = detailBill.SizeValue;
            btnEdit.Tag = detailBill;
            btnDelete.Tag = detailBill;
            BtnEdit = btnEdit;
            BtnDelete = btnDelete;
        }
        

        private string _name;

        [Category("Custom Props")]
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                textBoxName.Text = value;
            }
        }

        private int _price;

        [Category("Custom Props")]
        public int Price
        {
            get { return _price; }
            set
            {
                _price = value;
                textBoxPrice.Text = value.ToString() + " đ";
            }
        }

        private int _id;
        private int _idBill;
        private int _idProduct;
        private string _size;
        private string _duong;
        private string _da;
        private string _huong;
        private string _topping;
        private string _note;

        public int ID
        {
            get { return _id; }
            set
            {
                _id = value;
            }
        }

        public int IDBill
        {
            get { return _idBill; }
            set
            {
                _idBill = value;
            }
        }

        public int IDProduct
        {
            get { return _idProduct; }
            set
            {
                _idProduct = value;
            }
        }

        public string SizeValue
        {
            get { return _size; }
            set
            {
                _size = value;
            }
        }

        public string Duong { get { return _duong; }
            set
            {
                _duong = value;
            } }
        public string Da { get { return _da; }
            set
            {
                _da = value;
            } }
        public string Huong { get { return _huong; }
            set
            {
                _huong = value;
            } }
        public string Topping { get { return _topping; }
            set
            {
                _topping = value;
            } }
        public string Note
        {
            get { return _note; }
            set
            {
                _note = value;
            }
        }
    }
}
