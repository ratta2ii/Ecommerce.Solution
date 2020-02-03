using System.Collections.Generic;
using System;

namespace Ecommerce.Models  
{
    public class Inventory
    {
        public int InventoryId { get; set; }
        public int ProductId { get; set; }
        public int RemainingNumber { get; set; }
       
    }
}