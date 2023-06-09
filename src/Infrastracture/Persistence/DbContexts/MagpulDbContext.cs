using MagpulShop.Domain.Entitys;
using MagpulShop.Domain.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Magpul.Persistence.DbContexts
{
    public class MagpulDbContext : IdentityDbContext<User>, IMagpulDbContext
    {
        public DbSet<Basket> Basket { get; set; } = null!;
        public DbSet<Discount> Discounts { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<ProductCategory> ProductCategories { get; set; } = null!;
        public DbSet<ProductSubCategory> SubProductCategories { get; set; } = null!;
        public DbSet<User> Users { get; set; } = null!;

        public MagpulDbContext(DbContextOptions<MagpulDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)

        {
            modelBuilder.Entity<IdentityUserLogin<string>>()
                .HasKey(login => new { login.LoginProvider, login.ProviderKey });
            modelBuilder.Entity<IdentityUserRole<string>>()
                .HasKey(r => new { r.UserId, r.RoleId });
            modelBuilder.Entity<IdentityUserToken<string>>()
                .HasKey(t => new { t.UserId, t.LoginProvider, t.Name });
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MagpulDbContext).Assembly);
        }
    }
}
