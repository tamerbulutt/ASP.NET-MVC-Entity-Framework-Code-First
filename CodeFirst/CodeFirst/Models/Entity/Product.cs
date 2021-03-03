using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirst.Models.Entity
{
    public class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
    }
}