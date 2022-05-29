using KO.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.AspNetCore.Identity;

namespace KO.Repository.Seeds
{
    internal class AppUserSeed : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.HasData(
                new AppUser { Id = new Guid().ToString(), UserName = "SysAdmin", PasswordHash = "1234" , AppRoleId = 1},
                new AppUser { Id = new Guid().ToString(), UserName = "Admin", PasswordHash = "1234", AppRoleId = 2 },
                new AppUser { Id = new Guid().ToString(), UserName = "Customer", PasswordHash = "1234", AppRoleId = 3 });
        }
    }
}
