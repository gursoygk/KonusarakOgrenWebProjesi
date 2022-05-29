using KO.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KO.Repository.Seeds
{
    public class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product { Id = 1, Name = "Kalem", BrandId = 1, Price = 5, Stock = 3 },
                new Product { Id = 2, Name = "Kitap", BrandId = 2, Price = 15, Stock = 2 },
                new Product { Id = 3, Name = "Defter", BrandId = 1, Price = 25, Stock = 1 });
        }
    }
}
