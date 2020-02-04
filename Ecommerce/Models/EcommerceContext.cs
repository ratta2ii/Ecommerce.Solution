using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Models
{
    public class EcommerceContext : IdentityDbContext<ApplicationUser>
    {
        public virtual DbSet<Product> Products {get;set;}
        public DbSet<Order> Orders {get;set;}
        public DbSet<OrderProduct> OrderProduct { get; set; }
        public EcommerceContext(DbContextOptions options) : base(options) {}
    }
}

