using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagpulShop.Domain.Entitys
{
    public class Basket
    {
        public int Id { get; set; }
        public int BasketItemsId { get; set; }
        public int Quantity { get; set; }
        public double Total { get; set; }

    }
}
