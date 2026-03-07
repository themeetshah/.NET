using Microsoft.AspNetCore.Mvc;
using DemoAPI.Models;
namespace DemoAPI.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UserController : ControllerBase
    {
        private static List<User> users = new List<User>();

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(users);
        }

        [HttpPost]
        public IActionResult Add(User user)
        {
            users.Add(user);
            return Ok(users);
        }
    }
}