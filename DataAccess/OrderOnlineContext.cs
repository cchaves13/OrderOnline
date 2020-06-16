using Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class OrderOnlineContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Client> Clients { get; set; }

        public OrderOnlineContext() : base("OrderOnlineContext")
        {
           
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<OrderOnlineContext>(null);
            base.OnModelCreating(modelBuilder);
            
            // modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
