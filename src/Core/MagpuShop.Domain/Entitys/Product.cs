namespace MagpulShop.Domain.Entitys
{
    public class Product
    {
        public int Id { get; set; }
        public int CountProduct { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
        public ProductCategory ProductCategory { get; set; }
        public SubProductCategory SubProductCategory { get; set; }
        public Discount Discount { get; set; }

    }
}
