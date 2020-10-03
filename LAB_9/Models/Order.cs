using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication7.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public string Amount { get; set; }
        public DateTime Orderdate { get; set; }
    }
}
