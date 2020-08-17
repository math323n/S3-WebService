using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceAPI.Models
{
    public class InvoiceItem
    {
        protected int id;
        protected string shipName;
        protected string shipAddress;
        protected string shipCity;
        protected string shipRegion;
        protected string shipPostalCode;
        protected string shipCountry;
        protected string customerId;
        protected string customerName;
        protected string address;
        protected string city;
        protected string region;
        protected string postalCode;
        protected string country;
        protected string salesPerson;
        protected int orderId;
        protected DateTime orderDate;
        protected DateTime requiredDate;
        protected DateTime shippedDate;
        protected string shipperName;
        protected int productId;
        protected string productName;
        protected decimal unitPrice;
        protected int quantity;
        protected decimal discount;
        protected decimal extendedPrice;
        protected decimal freight;


        /// <summary>
        /// Creates a new instance of the <see cref="Invoice"/> class
        /// </summary>
        /// <param name="id"></param>
        /// <param name="shipName"></param>
        /// <param name="shipAddress"></param>
        /// <param name="shipCity"></param>
        /// <param name="shipRegion"></param>
        /// <param name="shipPostalCode"></param>
        /// <param name="shipCountry"></param>
        /// <param name="customerId"></param>
        /// <param name="customerName"></param>
        /// <param name="address"></param>
        /// <param name="city"></param>
        /// <param name="region"></param>
        /// <param name="postalCode"></param>
        /// <param name="country"></param>
        /// <param name="salesPerson"></param>
        /// <param name="orderId"></param>
        /// <param name="orderDate"></param>
        /// <param name="requiredDate"></param>
        /// <param name="shippedDate"></param>
        /// <param name="shipperName"></param>
        /// <param name="productId"></param>
        /// <param name="productName"></param>
        /// <param name="unitPrice"></param>
        /// <param name="quantity"></param>
        /// <param name="discount"></param>
        /// <param name="extendedPrice"></param>
        /// <param name="freight"></param>
        public InvoiceItem(int id, string shipName, string shipAddress, string shipCity, string shipRegion, string shipPostalCode, string shipCountry, string customerId, string customerName, string address, string city, string region, string postalCode, string country, string salesPerson, int orderId, DateTime orderDate, DateTime requiredDate, DateTime shippedDate, string shipperName, int productId, string productName, decimal unitPrice, int quantity, decimal discount, decimal extendedPrice, decimal freight)
        {
            Id = id;
            ShipName = shipName;
            ShipAddress = shipAddress;
            ShipCity = shipCity;
            ShipRegion = shipRegion;
            ShipPostalCode = shipPostalCode;
            ShipCountry = shipCountry;
            CustomerId = customerId;
            CustomerName = customerName;
            Address = address;
            City = city;
            Region = region;
            PostalCode = postalCode;
            Country = country;
            SalesPerson = salesPerson;
            OrderId = orderId;
            OrderDate = orderDate;
            RequiredDate = requiredDate;
            ShippedDate = shippedDate;
            ShipperName = shipperName;
            ProductId = productId;
            ProductName = productName;
            UnitPrice = unitPrice;
            Quantity = quantity;
            Discount = discount;
            ExtendedPrice = extendedPrice;
            Freight = freight;
        }

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public string ShipName
        {
            get
            {
                return shipName;
            }
            set
            {
                shipName = value;
            }
        }

        public string ShipAddress
        {
            get
            {
                return shipAddress;
            }
            set
            {
                shipAddress = value;
            }
        }

        public string ShipCity
        {
            get
            {
                return shipCity;
            }
            set
            {
                shipCity = value;
            }
        }

        public string ShipRegion
        {
            get
            {
                return shipRegion;
            }
            set
            {
                shipRegion = value;
            }
        }

        public string ShipPostalCode
        {
            get
            {
                return shipPostalCode;
            }
            set
            {
                shipPostalCode = value;
            }
        }

        public string ShipCountry
        {
            get
            {
                return shipCountry;
            }
            set
            {
                shipCountry = value;
            }
        }

        public string CustomerId
        {
            get
            {
                return customerId;
            }
            set
            {
                customerId = value;
            }
        }

        public string CustomerName
        {
            get
            {
                return customerName;
            }
            set
            {
                customerName = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }

        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }

        public string Region
        {
            get
            {
                return region;
            }
            set
            {
                region = value;
            }
        }

        public string PostalCode
        {
            get
            {
                return postalCode;
            }
            set
            {
                postalCode = value;
            }
        }

        public string Country
        {
            get
            {
                return country;
            }
            set
            {
                country = value;
            }
        }

        public string SalesPerson
        {
            get
            {
                return salesPerson;
            }
            set
            {
                salesPerson = value;
            }
        }

        public int OrderId
        {
            get
            {
                return orderId;
            }
            set
            {
                orderId = value;
            }
        }

        public DateTime OrderDate
        {
            get
            {
                return orderDate;
            }
            set
            {
                orderDate = value;
            }
        }

        public DateTime RequiredDate
        {
            get
            {
                return requiredDate;
            }
            set
            {
                requiredDate = value;
            }
        }

        public DateTime ShippedDate
        {
            get
            {
                return shippedDate;
            }
            set
            {
                shippedDate = value;
            }
        }

        public string ShipperName
        {
            get
            {
                return shipperName;
            }
            set
            {
                shipperName = value;
            }
        }

        public int ProductId
        {
            get
            {
                return productId;
            }
            set
            {
                productId = value;
            }
        }

        public string ProductName
        {
            get
            {
                return productName;
            }
            set
            {
                productName = value;
            }
        }

        public decimal UnitPrice
        {
            get
            {
                return unitPrice;
            }
            set
            {
                unitPrice = value;
            }
        }

        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
            }
        }

        public decimal Discount
        {
            get
            {
                return discount;
            }
            set
            {
                discount = value;
            }
        }

        public decimal ExtendedPrice
        {
            get
            {
                return extendedPrice;
            }
            set
            {
                extendedPrice = value;
            }
        }

        public decimal Freight
        {
            get
            {
                return freight;
            }
            set
            {
                freight = value;
            }
        }
    }
}
