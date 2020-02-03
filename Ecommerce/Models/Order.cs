using System.Collections.Generic;
using System;

namespace Ecommerce.Models  
{
    public class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int Total { get; set; }
        public DateTime Date { get; set; }
        public virtual ICollection<Product> Cart { get; set; }
        public Order()
        {
            this.Cart = new HashSet<Product>();
        }
    }
}