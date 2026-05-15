using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assigment_3_Full
{
    public partial class UC_Inventory : UserControl
    {
        public UC_Inventory()
        {
            InitializeComponent();
        }

        private BindingList<Class_Product> _inventoryList = new BindingList<Class_Product>();
        private BindingSource _bindingSource = new BindingSource();

        string filePath = "./guh.csv";

        private void Add_Inventory_Button_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            int newID = _inventoryList.Count + 2600;
            decimal Price = decimal.Parse(txt_Price.Text);
            string Name = txt_Name.Text;
            string Brand = txt_Brand.Text;
            int Quantity = int.Parse(txt_Quantity.Text);

            Class_Product newProduct = new Class_Product(newID, Name, Brand, Price, Quantity);
            _inventoryList.Add(newProduct);

        }
    }
}
