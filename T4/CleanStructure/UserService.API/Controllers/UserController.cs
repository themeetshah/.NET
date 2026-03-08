using Microsoft.AspNetCore.Mvc;
using UserService.Core.Entities.Interfaces;
using UserService.Core.Entities.Models;

namespace UserService.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult GetAllUsers()
        {
            var users = _userService.GetAllUsers();
            return Ok(users);
        }

        [HttpPost]
        public IActionResult AddUser(User user)
        {
            _userService.AddUser(user);
            return Ok(_userService.GetAllUsers());
        }
    }
}