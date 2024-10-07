using Microsoft.EntityFrameworkCore;
using Entities.Models;

namespace StoreApp.Models
{
    public class RepositoryContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options)
        {

        }

        public RepositoryContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>()
                .HasData(
                new Product() { ProductId = 1, ProductName = "Computer", Price = 21_000 },
            new Product() { ProductId = 2, ProductName = "Keyboard", Price = 1_000 },
            new Product() { ProductId = 3, ProductName = "Mouse", Price = 2_000 },
            new Product() { ProductId = 4, ProductName = "Monitor", Price = 21 },
            new Product() { ProductId = 5, ProductName = "Deck", Price = 210 },
            new Product() { ProductId = 6, ProductName = "MousePad", Price = 222 }
        );
        }
    }
}
