using AutoMapper;
using MagpulShop.Domain.Entitys;
using Web_app.Models;

namespace Web_app.MappingProfiles
{
    public class ProductCategoryProfile : Profile
    {
        public ProductCategoryProfile()
        {
            CreateMap<ProductCategory, ProductCategoryViewModel>().ReverseMap();
        }
    }
}
