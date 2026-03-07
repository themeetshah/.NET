using Microsoft.AspNetCore.Mvc;
using Module2.Models;
using Module2.Services;

namespace Module2.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UserController : ControllerBase
    {
        private readonly UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_userService.GetAllUsers());
        }

        [HttpPost]
        public IActionResult Add(User user)
        {
            _userService.AddUser(user);
            return Ok(_userService.GetAllUsers());
        }
    }
}