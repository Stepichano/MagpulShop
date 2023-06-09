using System.ComponentModel.DataAnnotations;

namespace Web_app.Models
{
    public class UserViewModel
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
