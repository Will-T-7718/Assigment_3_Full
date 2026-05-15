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
            dgvAvailable.ReadOnly = true;
            dgvAvailable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAvailable.MultiSelect = false; // Prevents selecting multiple rows at once

            // Apply these settings to the Current Order grid
            dgvCurrentOrder.ReadOnly = true;
            dgvCurrentOrder.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCurrentOrder.MultiSelect = false;

            // Configure Inventory Grid (Left)
            dgvAvailable.AutoGenerateColumns = false;
            dgvAvailable.Columns.Clear();
            dgvAvailable.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ProductID", HeaderText = "ID", Name = "colID", Width = 50 });
            dgvAvailable.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ProductName", HeaderText = "Product Name", Name = "colName", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });

            // Configure Current Order Grid (Right)
            dgvCurrentOrder.AutoGenerateColumns = false;
            dgvCurrentOrder.Columns.Clear();
            dgvCurrentOrder.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ProductID", HeaderText = "ID", Width = 50 });
            dgvCurrentOrder.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ProductName", HeaderText = "Product", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dgvCurrentOrder.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "UnitPrice", HeaderText = "Price", DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" } });
            dgvCurrentOrder.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Quantity", HeaderText = "Qty", Width = 50 });
            dgvCurrentOrder.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Subtotal", HeaderText = "Subtotal", DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" } });

            dgvCurrentOrder.DataSource = _currentOrderItems;
            dgvCurrentOrder.AllowDrop = true;
        }

        private void UC_Orders_Load(object sender, EventArgs e)
        {
+
        }
    }
}
