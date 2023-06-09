using System.ComponentModel.DataAnnotations;

namespace MagpulShop.Domain.Entitys
{
    public class ProductSubCategory
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public ProductCategory ProductCategory { get; set; }

    }
}
