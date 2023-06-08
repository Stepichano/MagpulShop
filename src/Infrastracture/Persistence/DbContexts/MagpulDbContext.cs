using System;
using System.Configuration;
using MagpulShop.Domain.Entitys;
using MagpulShop.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.IdentityModel.Protocols;
using Microsoft.Extensions.Configuration.Json;

namespace Magpul.Persistence.DbContexts
{
    public class MagpulDbContext : DbContext, IMagpulDbContext, IdentityDbContext<User>
    {
        public DbSet<Basket> Basket { get; set; } = null!;
        public DbSet<Discount> Discounts { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<ProductCategory> ProductCategories { get; set; } = null!;
        public DbSet<SubProductCategory> SubProductCategories { get; set; } = null!;
        public DbSet<User> Users { get; set; } = null!;

        public MagpulDbContext(DbContextOptions<MagpulDbContext> options) : base(options)
        {
            Database.EnsureCreatedAsync();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MagpulDbContext).Assembly);
        }
    }
}
