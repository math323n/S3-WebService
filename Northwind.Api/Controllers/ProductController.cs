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
    public class ProductController : ControllerBase
    {
        /// <summary>
        /// Get all Products
        /// </summary>
        /// <returns products></returns>
        [HttpGet]
        public List<Product> GetAll()
        {
            return new Repository().GetAllProducts();
        }
    }
}