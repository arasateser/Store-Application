using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Config
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.ProductId);
            builder.Property(p => p.ProductName).IsRequired();
            builder.Property(p => p.Price).IsRequired();

            builder.HasData(
                 new Product() { ProductId = 1, CategoryId = 2, ProductName = "Computer", Price = 21_000 },
        new Product() { ProductId = 2, CategoryId = 2, ProductName = "Keyboard", Price = 1_000 },
        new Product() { ProductId = 3, CategoryId = 2, ProductName = "Mouse", Price = 2_000 },
        new Product() { ProductId = 4, CategoryId = 2, ProductName = "Monitor", Price = 21 },
        new Product() { ProductId = 5, CategoryId = 2, ProductName = "Deck", Price = 210 },
        new Product() { ProductId = 6, CategoryId = 2, ProductName = "MousePad", Price = 222 },
        new Product() { ProductId = 7, CategoryId = 1, ProductName = "Dune", Price = 696 },
        new Product() { ProductId = 8, CategoryId = 1, ProductName = "Prophecy", Price = 969 }
                );
        }
    }
}
