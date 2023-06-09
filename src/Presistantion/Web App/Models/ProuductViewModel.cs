using System.ComponentModel.DataAnnotations;
using MagpulShop.Domain.Entitys;

namespace Web_app.Models
{
    public class ProuductViewModel
    {
        [Required]
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
