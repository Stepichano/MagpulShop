using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MagpulShop.Domain.Entitys;

namespace Web_app.Services
{
    public interface IProductService
    {
        Task<IQueryable> GetAll();
        Task<Product?> Get(int id);
        Task<IQueryable<Product>> GetByCategory(ProductCategory category);
        Task<IQueryable<Product>> GetBySubCategory(ProductSubCategory productSubCategory);
        Task<IQueryable<Product>>  GetByIdCategory(int id);
        Task<IQueryable<Product>> GetByIdSubCategory(int id);
        Task AddProduct(Product product);

    }
}
