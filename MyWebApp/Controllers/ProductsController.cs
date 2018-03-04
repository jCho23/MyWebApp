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

        };

        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }


    }
}
