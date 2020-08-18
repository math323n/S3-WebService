using System;
using System.Collections.Generic;
using System.Text;

namespace NorthwindApi.Entities
{
    public class Customer
    {
        public Customer(string customerID, string companyName, string contactName, string contactTitle)
        {
            CustomerID = customerID;
            CompanyName = companyName;
            ContactName = contactName;
            ContactTitle = contactTitle;
        }

        public string CustomerID { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
    }
}