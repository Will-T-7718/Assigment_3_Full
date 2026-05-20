using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        private void UC_Inventory_Load(object sender, EventArgs e)
        {
            string path = filePath;

            var tempData = Class_Inventory_Service.LoadFromCSV(path);
            _inventoryList.Clear();
            foreach (var item in tempData)
            {
                _inventoryList.Add(item);
            }

            dgv_Inventory.DataSource = _inventoryList;
        }

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
            _bindingSource.ResetBindings(false);
            ClearFields();
        }

        private bool ValidateInputs()
        {
            if (!Regex.IsMatch(txt_Name.Text, @"^[a-zA-Z0-9] +$"))
            {
                MessageBox.Show("Name Has Invalid Character");
                return false;
            }

            if (!decimal.TryParse(txt_Price.Text, out decimal price) || price < 0)
            {
                MessageBox.Show("Invalid Price");
                return false;
            }

            if (!int.TryParse(txt_Quantity.Text, out int qty) || qty < 0)
            {
                MessageBox.Show("Invalid Quantity");
                return false;
            }

            return true;
        }

        private void ClearFields()
        {
            txt_ID.Clear();
            txt_Name.Clear();
            txt_Price.Clear();
            txt_Brand.Clear();
            txt_Quantity.Clear();
        }

        private void btn_Update_Inventory_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txt_ID.Text, out int idToUpdate))
            {
                MessageBox.Show("Select a product from the grid");
                return;
            }

            var productToUpdate = _inventoryList.FirstOrDefault(p => p.Product_ID == idToUpdate);

            if (productToUpdate != null)
            {
                if (ValidateInputs())
                {

                }
            }
        }

        private void btn_Delete_Inventory_Click(object sender, EventArgs e)
        {
            string searchTerm = txt_Delete_Inventory.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                MessageBox.Show("enter a valid product ID or name");
                return;
            }

            Class_Product productToDelete = _inventoryList.FirstOrDefault(p =>
            p.Product_ID.ToString() == searchTerm ||
            p.Product_Name.Equals(searchTerm, StringComparison.OrdinalIgnoreCase));

            if (productToDelete != null)
            {

            }
        }

        private void btn_Clear_Inventory_Click(object sender, EventArgs e)
        {

        }
    }
}
