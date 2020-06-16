using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string Status { get; set; }
        public DateTime CreationDate { get; set; } 
        public string DeliverLocation { get; set; }
    }
}
