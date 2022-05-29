using KO.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KO.Repository.Seeds
{
    internal class BrandSeed : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.HasData(
                new Brand { Id = 1, Name = "Marka_1" },
                new Brand { Id = 2, Name = "Marka_2" });
        }
    }
}
