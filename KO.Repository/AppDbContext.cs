using KO.Core.Models;
using KO.Repository.Seeds;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace KO.Repository
{
    public  class AppDbContext : IdentityDbContext<AppUser, AppRole, string>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Brand>? Brands { get; set; }
        public DbSet<Product>? Products { get; set; }
        public DbSet<Comment>? Comments { get; set; }
        public DbSet<Feature>? Features { get; set; }
        public DbSet<Order>? Orders { get; set; }
        public DbSet<OrderDetail>? OrderDetails { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new ProductSeed());
            modelBuilder.ApplyConfiguration(new BrandSeed());
            modelBuilder.ApplyConfiguration(new AppUserSeed());
            modelBuilder.ApplyConfiguration(new AppRoleSeed());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=KODb");
        }
    }
}
