using AutoMapper;
using MagpulShop.Domain.Entitys;
using Web_app.Models;

namespace Web_app.MappingProfiles
{
    public class BasketProfile : Profile
    {
        public BasketProfile()
        {
            CreateMap<Basket, BasketVeiwModel>().ReverseMap();
        }
    }
}
