using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Magpul.Persistence.DbContexts;
using MagpulShop.Domain.Entitys;
using Microsoft.EntityFrameworkCore;

namespace Web_app.Services
{
    public class ProductService : IProductService
    {
        private readonly MagpulDbContext _dbContext;

        public ProductService(MagpulDbContext dbContext)
        {
            _dbContext = dbContext;

        }

        public async Task<IQueryable> GetAll()
        {
            var products = await _dbContext.Products.ToListAsync();

            return products.AsQueryable();
        }

        public async Task<Product?> Get(int id)
        {
            var product = await _dbContext.Products.FindAsync(id);

            return product;
        }


        public async Task<IQueryable<Product>> GetByCategory(ProductCategory category)
        {
            var products = await _dbContext.Products
                .Where(product => product.ProductCategory != null && product.ProductCategory.Name == category.Name)
                .ToListAsync();

            return products.AsQueryable();
        }
        public async Task<IQueryable<Product>> GetBySubCategory(ProductSubCategory productSubCategory)
        {
            var products = await _dbContext.Products
                .Where(product => product.SubProductCategory != null && product.SubProductCategory.Name == productSubCategory.Name)
                .ToListAsync();

            return products.AsQueryable();
        }
        public async Task<IQueryable<Product>> GetByIdCategory(int id)
        {
            var products = await _dbContext.Products
                .Where(product => product.ProductCategory != null && product.ProductCategory.Id == id)
                .ToListAsync();

            return products.AsQueryable();
        }
        public async Task<IQueryable<Product>> GetByIdSubCategory(int id)
        {
            var products = await _dbContext.Products
                .Where(product => product.SubProductCategory != null && product.SubProductCategory.Id == id)
                .ToListAsync();

            return products.AsQueryable();
        }

        public async Task AddProduct(Product product)
        { 
            _dbContext.Products.Add(product);

            await _dbContext.SaveChangesAsync();
        }
    }
}
