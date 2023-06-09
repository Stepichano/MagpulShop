using AutoMapper;
using MagpulShop.Domain.Entitys;
using Web_app.Models;

namespace Web_app.MappingProfiles
{
    public class ProducSubCategoryProfile : Profile
    {
        public ProducSubCategoryProfile()
        {
            CreateMap<ProductSubCategory, ProductSubCategoryVeiwModel>().ReverseMap();
        }
    }
}
