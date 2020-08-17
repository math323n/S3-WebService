using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NorthwindApi.DataAccess;
using NorthwindApi.Entities;

namespace Northwind.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class InvoicesController: ControllerBase
    {

        [HttpGet("{customerId}")]
        public List<Invoice> GetAllId(string customerId)
        {
            List<Invoice> invoices = new Repository().GetAllInvoicesById(customerId);
            return invoices;
        }

        [HttpGet]
        public List<Invoice> GetAll()
        {
            List<Invoice> invoices = new Repository().GetAllInvoices();
            return invoices;
        }
    }

}