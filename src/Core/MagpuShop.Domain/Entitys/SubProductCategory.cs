namespace MagpulShop.Domain.Entitys
{
    public class SubProductCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ProductCategory ProductCategory { get; set; }

    }
}
