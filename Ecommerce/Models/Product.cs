using System.Collections.Generic;
using System;

namespace Ecommerce.Models  
{
    public class Product
    {
        public int ProductId { get; set; }
        public int Price { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Sku { get; set; }
        public string ProductImage { get; set; }
        // public int RemainingInventory { get; set; }
    }
}