using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MagpulShop.Domain.Entitys;

namespace Web_app.Models
{
    public class BasketVeiwModel
    {
        public int Id { get; set; }
        public ICollection<Product>? Products { get; set; }
        public int Quantity { get; set; }
        public double Total { get; set; }
    }
}
