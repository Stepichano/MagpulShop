// UserController.cs

using System.Threading.Tasks;
using AutoMapper;
using MagpulShop.Domain.Entitys;
using MagpulShop.Domain.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Web_app.Models;
using Web_app.Services;
using System.Linq;

namespace MagpulShop.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public UserController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(UserViewModel model)
        {   
            var user = _mapper.Map<User>(model);

            // Call the registration method of the user service
            var result = await _userService.RegisterUser(user);
            if (result.Succeeded)
            {
                return Ok();
            }
            else
            {
                return BadRequest(result.Errors);
            }
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(UserViewModel model)
        {
            // Call the login method of the user service
            var result = await _userService.Login(model.Email, model.Password);
            if (result.Succeeded)
            {
                return Ok(result.Token);
            }
            else
            {
                return BadRequest();
            }
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var users = _userService.GetAll().Result.AsQueryable();

            var userViewModels = _mapper.ProjectTo<UserViewModel>(users);

            return Ok(userViewModels);
        }
    }
}