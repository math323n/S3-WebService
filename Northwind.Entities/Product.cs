using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind.Entities
{
    public class Product
    {
        public Product(int productID, string productName, string quantityPerUnit, decimal unitPrice)
        {
            ProductID = productID;
            ProductName = productName;
            QuantityPerUnit = quantityPerUnit;
            UnitPrice = unitPrice;
        }

        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
