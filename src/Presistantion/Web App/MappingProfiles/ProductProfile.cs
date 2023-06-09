using AutoMapper;
using MagpulShop.Domain.Entitys;
using Web_app.Models;

namespace Web_app.MappingProfiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductViewModel>().ReverseMap();
        }
    }
}
