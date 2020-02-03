using System.Collections.Generic;
using System;

namespace Ecommerce.Models  
{
    public class Product
    {
        public int ProductId { get; set; }
        public int Price { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        // public int RemainingInventory { get; set; }
    }
}