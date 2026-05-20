using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment_3_Full
{
    internal class Class_Product
    {
        public int Product_ID { get; set; }
        public string Product_Name { get; set; }
        public string Product_Brand { get; set; }
        public decimal Product_Price { get; set; }
        public int Product_Quantity { get; set; }

        // This is the constructor that builds a Product object
        public Class_Product(int ID, string Name, string Brand, decimal Price, int Quantity)
        {
            Product_ID = ID;
            Product_Name = Name;
            Product_Brand = Brand;
            Product_Price = Price;
            Product_Quantity = Quantity;
        }

    }
}
