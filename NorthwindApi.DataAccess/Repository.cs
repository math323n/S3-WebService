﻿using Northwind.Entities;
using NorthwindApi.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace NorthwindApi.DataAccess
{
    public class Repository
    {
        // Connection string to connect to local database (Northwind)
        const string ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        #region methods
        /// <summary>
        /// Get all Invoices by entered Customer ID
        /// </summary>
        /// <param name="customerID"></param>
        /// <returns></returns>
        public List<Invoice> GetAllInvoicesById(string customerID)
        {
            string sql = $"SELECT CustomerName, ExtendedPrice, Freight FROM Invoices WHERE CustomerID LIKE '{customerID}'";
            DataRowCollection dataRows = Execute(sql);
            List<Invoice> invoices = ProcessInvoices(dataRows);
            return invoices;
        }

        /// <summary>
        /// Get all of the invoices
        /// </summary>
        /// <returns></returns>
        public List<Invoice> GetAllInvoices()
        {
            string sql = $"SELECT CustomerName, ExtendedPrice, Freight FROM Invoices";
            DataRowCollection dataRows = Execute(sql);
            List<Invoice> invoices = ProcessInvoices(dataRows);
            return invoices;
        }

        /// <summary>
        /// Get all of the products
        /// </summary>
        /// <returns></returns>
        public List<Product> GetAllProducts()
        {
            string sql = $"SELECT ProductID, ProductName, QuantityPerUnit, UnitPrice FROM Products";
            DataRowCollection dataRows = Execute(sql);
            List<Product> products = ProcessProducts(dataRows);
            return products;
        }

        /// <summary>
        /// Get all customers
        /// </summary>
        /// <returns></returns>
        public List<Customer> GetAllCustomers()
        {
            string sql = "SELECT CustomerID, CompanyName, ContactName, ContactTitle FROM Customers";
            DataRowCollection dataRows = Execute(sql);
            List<Customer> customers = ProcessCustomers(dataRows);
            return customers;
        }

        /// <summary>
        /// Execute SQL
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        private DataRowCollection Execute(string sql)
        {
            try
            {
                DataSet resultSet = new DataSet();
                using(SqlDataAdapter adapter = new SqlDataAdapter(new SqlCommand(sql, new SqlConnection(ConnectionString))))
                {
                    adapter.Fill(resultSet);
                }
                return resultSet.Tables[0].Rows;
            }
            catch(Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Process the customers and return them as list
        /// </summary>
        /// <param name="dataRows"></param>
        /// <returns></returns>
        private List<Customer> ProcessCustomers(DataRowCollection dataRows)
        {
            List<Customer> customers = new List<Customer>();
            foreach(DataRow row in dataRows)
            {
                string customerID = (string)row["CustomerID"];
                string companyName = (string)row["CompanyName"];
                string contactName = (string)row["ContactName"];
                string contactTitle = (string)row["ContactTitle"];
                Customer customer = new Customer(customerID, companyName, contactName, contactTitle);
                customers.Add(customer);
            }
            return customers;
        }

        /// <summary>
        /// Process the invoices and return them as a list
        /// </summary>
        /// <param name="dataRows"></param>
        /// <returns></returns>
        private List<Invoice> ProcessInvoices(DataRowCollection dataRows)
        {
            List<Invoice> invoices = new List<Invoice>();
            foreach(DataRow row in dataRows)
            {
                string customerName = (string)row["CustomerName"];
                decimal extendedPrice = (decimal)row["ExtendedPrice"];
                decimal freightPrice = (decimal)row["Freight"];
                Invoice invoice = new Invoice(customerName, extendedPrice, freightPrice);
                invoices.Add(invoice);
            }
            return invoices;
        }

        /// <summary>
        /// Process the products and return them as a list
        /// </summary>
        /// <param name="dataRows"></param>
        /// <returns></returns>
        private List<Product> ProcessProducts(DataRowCollection dataRows)
        {
            List<Product> products = new List<Product>();
            foreach(DataRow row in dataRows)
            {
                int productID = (int)row["ProductID"];
                string productName = (string)row["ProductName"];
                string quantityPerUnit = (string)row["QuantityPerUnit"];
                decimal unitPrice = (decimal)row["UnitPrice"];
                Product product = new Product(productID, productName, quantityPerUnit, unitPrice);
                products.Add(product);
            }
            return products;
        }
        #endregion
    }
}