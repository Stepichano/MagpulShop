using MagpulShop.Domain.Entitys;
using Microsoft.EntityFrameworkCore;

namespace MagpulShop.Domain.Interfaces
{
    public interface IMagpulDbContext
    {
        public DbSet<Basket> Basket { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductSubCategory> SubProductCategories { get; set; }
        public DbSet<User> Users { get; set; }
        public Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
