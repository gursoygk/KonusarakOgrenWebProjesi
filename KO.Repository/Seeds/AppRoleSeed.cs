using KO.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KO.Repository.Seeds
{
    internal class AppRoleSeed : IEntityTypeConfiguration<AppRole>
    {
        public void Configure(EntityTypeBuilder<AppRole> builder)
        {
            builder.HasData(
                new AppRole { Id = "1", Name = "SysAdmin" },
                new AppRole { Id = "2", Name = "Admin" },
                new AppRole { Id = "3", Name = "Customer" });
        }
    }
}
