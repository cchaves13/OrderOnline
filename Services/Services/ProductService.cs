using DataAccess;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class ProductService
    {
        public OrderOnlineContext DbContext = new OrderOnlineContext();

        public Product GetProductById(int id)
        {
            try
            {
                return DbContext.Products.FirstOrDefault();
            }
            catch (Exception e)
            {

                throw;
            }
           
        }

        public IEnumerable<Product> GetAllProducts()
        {
            try
            {
                return DbContext.Products.ToList();
            }
            catch (Exception e)
            {

                throw;
            }

        }

        public Product AddProduct(Product product)
        {
            if (product.Id > 0)
            {
                var productToEdit = DbContext.Products.FirstOrDefault(x => x.Id == product.Id);
                if(product != null)
                {
                    var ee = DbContext.Entry(productToEdit);
                    ee.CurrentValues.SetValues(product);
                }
            }
            else
            {
                product = DbContext.Products.Add(product);
            }
            
            
            DbContext.SaveChanges();
            
            return product;
        }

        public Boolean DeleteProduct(int productId)
        {
            try
            {
               var productToRemove = DbContext.Products.FirstOrDefault(x => x.Id== productId);
                DbContext.Products.Remove(productToRemove);
                DbContext.SaveChanges();
                return true;

            }
            catch (Exception)
            {

                return false;
            }
           
        }
    }
}
