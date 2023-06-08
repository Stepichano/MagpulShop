namespace MagpulShop.Domain.Entitys
{
    public class Basket
    {
        public int Id { get; set; }
        public ICollection<Product> Products { get; set; }
        public int Quantity { get; set; }
        public double Total { get; set; }

    }
}
