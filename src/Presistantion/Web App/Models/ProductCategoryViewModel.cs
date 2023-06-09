using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MagpulShop.Domain.Entitys;

namespace Web_app.Models
{
    public class ProductCategoryViewModel
    {
            public int Id { get; set; }
            public string? Name { get; set; }
            public ProductCategory ProductCategory { get; set; }
    }
}
