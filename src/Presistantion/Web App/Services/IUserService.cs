using MagpulShop.Domain.Entitys;
using Microsoft.AspNetCore.Identity;

namespace Web_app.Services
{
    public interface IUserService
    {
        Task<IdentityResult> RegisterUser(User user);
        Task<LoginResult> Login(string email, string password);
        Task<IQueryable> GetAll();
    }

    public class LoginResult
    {
        public bool Succeeded { get; }
        public string Token { get; }

        public LoginResult(bool succeeded, string token)
        {
            Succeeded = succeeded;
            Token = token;
        }
    }
}
