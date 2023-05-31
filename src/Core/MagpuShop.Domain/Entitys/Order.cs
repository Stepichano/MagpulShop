using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagpulShop.Domain.Entitys
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int BasketId { get; set; }
        public Basket Basket { get; set; }
        public string? Status { get; set; }
        public DateOnly Date { get; set; }
        public string? Address { get; set; }

    }
}
