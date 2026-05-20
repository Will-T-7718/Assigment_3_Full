using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment_3_Full
{
    public class Class_Order_Item
    {
        public int Product_ID { get; set; }
        public string Product_Name { get; set; }
        public decimal Unit_Price { get; set; }
        public int Quantity { get; set; }
        public decimal Subtotal => Unit_Price * Quantity;
    }

    public class Order
    {
        public string OrderName { get; set; }
        public string Description { get; set; }
        public DateTime OrderDate { get; set; }
        public List<Class_Order_Item> Items { get; set; } = new List<Class_Order_Item>();
        public decimal TotalAmount { get; set; }
    }
}
