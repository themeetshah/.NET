using Microsoft.AspNetCore.Mvc;
using Module3.Models;
using Module3.Services;

namespace Module3.Controllers
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