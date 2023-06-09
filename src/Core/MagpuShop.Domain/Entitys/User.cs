using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace MagpulShop.Domain.Entitys
{
    public class User : IdentityUser
    {
        [Key]
        public int Id { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string Password { get; set; }

        public string? Name { get; set; }

        public string? Address { get; set; }

        public string?OwnerId { get; set; }
    }
}
