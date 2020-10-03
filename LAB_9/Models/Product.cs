using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication7.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public float Price { get; set; }
        public List<Order> Orders { get; set; }
    }
}
