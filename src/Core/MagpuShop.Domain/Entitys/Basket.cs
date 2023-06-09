using System.ComponentModel.DataAnnotations;

namespace MagpulShop.Domain.Entitys
{
    public class Basket
    {
        [Key]
        public int Id { get; set; }
        public ICollection<Product>? Products { get; set; }
        public int Quantity { get; set; }
        public double Total { get; set; }

    }
}
