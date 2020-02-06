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
        public bool Completed { get; set; }

        public virtual ICollection<OrderProduct> Cart { get; set; }
        public Order()
        {
            this.Cart = new HashSet<OrderProduct>();
        }

        public void AddProduct(OrderProduct newOrderProduct)
        {
            this.Cart.Add(newOrderProduct);
        }
    }
}