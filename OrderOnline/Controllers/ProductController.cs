using Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Entities.Models;
using System.Web.Http.Cors;

namespace OrderOnline.Controllers
{
    //[EnableCors(origins: "*", headers: "**", methods: "*")]
    public class ProductController : ApiController
    {
        ProductService ProductService = new ProductService();

        
        // GET api/values
        public IEnumerable<Product> Get()
        {
            return ProductService.GetAllProducts(); ;
        }

        // GET api/values/5
        public Product Get(int id)
        {
            return ProductService.GetProductById(id);
        }

        public Product Post(Product product)
        {
            return ProductService.AddProduct(product);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        [HttpPost]
        [Route("api/product/delete/{productId}")]
        public Boolean Delete(int productId)
        {
            return ProductService.DeleteProduct(productId);
        }
    }
}
