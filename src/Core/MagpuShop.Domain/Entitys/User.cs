using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace MagpulShop.Domain.Entitys
{
    public class User : IdentityUser
    {   
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

    }
}
