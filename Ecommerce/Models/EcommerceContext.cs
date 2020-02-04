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
                    new Product { ProductId = 1, Name = "Backpack", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Arcu non odio euismod lacinia at. Consequat interdum varius sit amet mattis vulputate enim nulla. Scelerisque mauris pellentesque pulvinar pellentesque habitant morbi tristique. Sit amet volutpat consequat mauris nunc congue nisi vitae. Lorem mollis aliquam ut porttitor leo a. Nibh tellus molestie nunc non. Urna cursus eget nunc scelerisque. Nullam vehicula ipsum a arcu cursus vitae congue. Facilisis sed odio morbi quis commodo odio aenean. Orci ac auctor augue mauris.", Price = 57, Sku = "187420-1217", ProductImage = "https://picsum.photos/200" },
                    new Product { ProductId = 2, Name = "Tent", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Arcu non odio euismod lacinia at. Consequat interdum varius sit amet mattis vulputate enim nulla. Scelerisque mauris pellentesque pulvinar pellentesque habitant morbi tristique. Sit amet volutpat consequat mauris nunc congue nisi vitae. Lorem mollis aliquam ut porttitor leo a. Nibh tellus molestie nunc non. Urna cursus eget nunc scelerisque. Nullam vehicula ipsum a arcu cursus vitae congue. Facilisis sed odio morbi quis commodo odio aenean. Orci ac auctor augue mauris.", Price = 129, Sku = "187420-1217", ProductImage = "https://picsum.photos/200" },
                    new Product { ProductId = 4, Name = "Boots", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Arcu non odio euismod lacinia at. Consequat interdum varius sit amet mattis vulputate enim nulla. Scelerisque mauris pellentesque pulvinar pellentesque habitant morbi tristique. Sit amet volutpat consequat mauris nunc congue nisi vitae. Lorem mollis aliquam ut porttitor leo a. Nibh tellus molestie nunc non. Urna cursus eget nunc scelerisque. Nullam vehicula ipsum a arcu cursus vitae congue. Facilisis sed odio morbi quis commodo odio aenean. Orci ac auctor augue mauris.", Price = 199, Sku = "187420-1217", ProductImage = "https://picsum.photos/200" },
                    new Product { ProductId = 5, Name = "Sleeping Bag", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Arcu non odio euismod lacinia at. Consequat interdum varius sit amet mattis vulputate enim nulla. Scelerisque mauris pellentesque pulvinar pellentesque habitant morbi tristique. Sit amet volutpat consequat mauris nunc congue nisi vitae. Lorem mollis aliquam ut porttitor leo a. Nibh tellus molestie nunc non. Urna cursus eget nunc scelerisque. Nullam vehicula ipsum a arcu cursus vitae congue. Facilisis sed odio morbi quis commodo odio aenean. Orci ac auctor augue mauris.", Price = 99, Sku = "187420-1217", ProductImage = "https://picsum.photos/200" }
        );
        }

    }
}
