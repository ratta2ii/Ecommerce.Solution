using System.Collections.Generic;
using System;

namespace Ecommerce.Models  
{
    public class Order
    {
        public int OrderId { get; set; }
        // public int CustomerId { get; set; }
        public DateTime Date { get; set; }
        public  ICollection<OrderProduct> OrderProducts { get; set; }
        public  static List<Product> Cart { get; set; }
        public Order()
        {
            OrderProducts= new HashSet<OrderProduct>();
            Cart = new List<Product>();
        }
        public void AddProduct(Product new_product)
        {
            Cart.Add(new_product);
        }
        public static List<Product> GetOrderedProducts()
        {
                return Cart;
        }

        
    }
}