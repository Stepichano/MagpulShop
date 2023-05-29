using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace MagpulShop.Domain.Entitys
{
    public class Product
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public string? Image { get; set; }
        public int ProductCategoryId { get; set; }
        public int DiskountId { get; set; }

    }
}
