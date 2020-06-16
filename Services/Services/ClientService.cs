using DataAccess;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class ClientService
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
    }
}
