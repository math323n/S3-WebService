using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Northwind.Entities;
using NorthwindApi.DataAccess;

namespace Northwind.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class OrderController: ControllerBase
    {
        /// <summary>
        /// Gets all orders by entered ID
        /// </summary>
        /// <param name="isShipped"></param>
        /// <param name="customerID"></param>
        /// <returns></returns>
        [HttpGet("{isShipped}/{customerId}")]
        // Type /order/true or false/CustomerID, false are non-shipped, and vice versa.
        public List<Order> GetAllByCustomerID(bool isShipped, string customerID)
        {
            List<Order> orders = new Repository().GetAllOrdersByID(customerID);
            List<Order> completedOrders = new List<Order>();
            List<Order> nonCompletedOrders = new List<Order>();
            foreach(Order order in orders)
            {
                if(order.IsShipped)
                {
                    completedOrders.Add(order);

                }
                else
                {
                    nonCompletedOrders.Add(order);
                }
            }
            if(isShipped)
            {
                return completedOrders;
            }
            else
            {
                return nonCompletedOrders;
            }
        }

        /// <summary>
        /// Gets all orders by shipped or not
        /// </summary>
        /// <param name="isShipped"></param>
        /// <returns></returns>
        [HttpGet("{isShipped}")]
        //Type /order/true or false for all completed or non-completed orders
        public List<Order> GetAllByShipped(bool isShipped)
        {
            List<Order> orders = new Repository().GetAllOrders();
            List<Order> completedOrders = new List<Order>();
            List<Order> nonCompletedOrders = new List<Order>();
            foreach(Order order in orders)
            {
                if(order.IsShipped)
                {
                    completedOrders.Add(order);

                }
                else
                {
                    nonCompletedOrders.Add(order);
                }
            }
            if(isShipped)
            {
                return completedOrders;
            }
            else
            {
                return nonCompletedOrders;
            }
        }

        /// <summary>
        /// Get all Products
        /// </summary>
        /// <returns products></returns>
        [HttpGet]
        public List<Order> GetAll()
        {
            return new Repository().GetAllOrders();
        }
    }
}