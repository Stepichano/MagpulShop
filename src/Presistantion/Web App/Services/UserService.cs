using MagpulShop.Domain.Entitys;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Web_app.Services
{
    public class UserService : IUserService
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;



        public UserService(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task<IdentityResult> RegisterUser(User user)
        {
            // Register the user using the user manager
            var result = await _userManager.CreateAsync(user, user.Password);
            if (result.Succeeded)
            {
                // Optionally, sign in the user after registration
                await _signInManager.SignInAsync(user, isPersistent: false);
            }
            return result;
        }

        public async Task<LoginResult> Login(string email, string password)
        {
            // Sign in the user using the sign in manager
            var result = await _signInManager.PasswordSignInAsync(email, password, isPersistent: false, lockoutOnFailure: false);
            if (result.Succeeded)
            {
                // Generate and return a JWT token for the authenticated user
                var token = GenerateJwtToken(email);
                return new LoginResult(true, token);
            }
            else
            {
                return new LoginResult(false, null);
            }
        }

        public async Task<IQueryable> GetAll()
        {
            var users = await _userManager.Users.ToListAsync();
            return users.AsQueryable();
        }

    private string GenerateJwtToken(string email)
    {
        // Generate a JWT token for the given user email (you can use your preferred JWT library)
        // ...
        // Return the generated token
        return "generated_token";
    }
}
}