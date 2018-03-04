using MyWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyWebApp.Controllers
{
    public class ProductsController : ApiController
    {
        Product[] products = new Product[]
        {
            new Product { Id= 1, ProductName= "Jordans", Price=1},
            new Product { Id= 1, ProductName= "Boost", Price= 3.75M},
            new Product { Id= 1, ProductName= "Nike", Price=16.99M}
        };

        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }

        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault((x) => x.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }


    }
}
