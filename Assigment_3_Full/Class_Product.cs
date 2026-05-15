using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment_3_Full
{
    internal class Class_Product
    {
        // These names must be used in the DataPropertyName of the DataGridView columns
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductBrand { get; set; }
        public decimal ProductPrice { get; set; }
        public int ProductQuantity { get; set; }

        // This is the constructor that builds a Product object
        public Class_Product(int ID, string Name, string Brand, decimal Price, int Quantity)
        {
            ProductID = ID;
            ProductName = Name;
            ProductBrand = Brand;
            ProductPrice = Price;
            ProductQuantity = Quantity;
        }

    }
}
