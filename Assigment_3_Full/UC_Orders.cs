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
    public partial class UC_Orders : UserControl
    {
        private BindingList<Class_Product> _availableProducts;
        private BindingList<Class_Order_Item> _currentOrderItems = new BindingList<Class_Order_Item>();
        private string _csvPath = "./shop-product-catalog.csv";

        public UC_Orders()
        {
            InitializeComponent();
            SetupOrderSystem();
        }

        private void SetupOrderSystem()
        {
            // Apply these settings to the Inventory grid
            DGV_Available.ReadOnly = true;
            DGV_Available.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_Available.MultiSelect = false; // Prevents selecting multiple rows at once

            // Apply these settings to the Current Order grid
            DGV_Current_Order.ReadOnly = true;
            DGV_Current_Order.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_Current_Order.MultiSelect = false;

            // Configure Inventory Grid (Left)
            DGV_Available.AutoGenerateColumns = false;
            DGV_Available.Columns.Clear();
            DGV_Available.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ProductID", HeaderText = "ID", Name = "colID", Width = 50 });
            DGV_Available.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ProductName", HeaderText = "Product Name", Name = "colName", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });

            // Configure Current Order Grid (Right)
            DGV_Current_Order.AutoGenerateColumns = false;
            DGV_Current_Order.Columns.Clear();
            DGV_Current_Order.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ProductID", HeaderText = "ID", Width = 50 });
            DGV_Current_Order.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ProductName", HeaderText = "Product", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            DGV_Current_Order.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "UnitPrice", HeaderText = "Price", DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" } });
            DGV_Current_Order.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Quantity", HeaderText = "Qty", Width = 50 });
            DGV_Current_Order.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Subtotal", HeaderText = "Subtotal", DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" } });

            DGV_Current_Order.DataSource = _currentOrderItems;
            DGV_Current_Order.AllowDrop = true;
        }

        private void UC_Orders_Load(object sender, EventArgs e)
        {

        }
    }
}
