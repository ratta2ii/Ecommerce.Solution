using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Models
{
    public class EcommerceContext : DbContext
    {
        public virtual DbSet<Product> Products {get;set;}
        public DbSet<Order> Orders {get;set;}
        public DbSet<OrderProduct> OrderProduct { get; set; }
        public EcommerceContext(DbContextOptions options) : base(options) 
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Product>()
            .HasData(
                new Product { ProductId = 1, Name = "Matilda", Image = "https://picsum.photos/200", Price = 50 },
                new Product { ProductId = 2, Name = "Rexie", Image = "https://picsum.photos/200", Price = 10 },
                new Product { ProductId = 3, Name = "Matilda", Image = "https://picsum.photos/200", Price = 24 },
                new Product { ProductId = 4, Name = "Pip", Image = "https://picsum.photos/200", Price = 43 },
                new Product { ProductId = 5, Name = "Bartholomew", Image = "https://picsum.photos/200", Price = 22 }
            );
}
    }
}

