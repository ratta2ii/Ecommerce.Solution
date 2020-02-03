using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Models
{
    public class EcommerceContext : IdentityDbContext<ApplicationUser>
    {
        public virtual DbSet<Product> Products {get;set;}
        public DbSet<Customer> Customers {get;set;}
        public EcommerceContext(DbContextOptions options) : base(options) {}
    }
}

