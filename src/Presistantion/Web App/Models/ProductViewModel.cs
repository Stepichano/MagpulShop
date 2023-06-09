using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MagpulShop.Domain.Entitys;

namespace Web_app.Models
{
    public class ProductViewModel : Profile
    {
        public int Id { get; set; }
        public int CountProduct { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public string? Image { get; set; }
        public ProductCategory? ProductCategory { get; set; }
        public ProductSubCategory? SubProductCategory { get; set; }
        public Discount? Discount { get; set; }
    }

}
