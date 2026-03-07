using Microsoft.AspNetCore.Mvc;
using Module4.Models;
using Module4.Interfaces;

namespace Module4.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
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