using Cookies01.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Cookies01.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (model.Username == "admin" && model.Password == "12345")
            {
                var claims = new List<Claim> { new Claim(ClaimTypes.Name, model.Username) };
                var identity = new ClaimsIdentity(claims, "MyCookiesAuth");
                var principal = new ClaimsPrincipal(identity);
                await HttpContext.SignInAsync("MyCookiesAuth", principal);
                return RedirectToAction("Index", "Home");
            }
            ViewBag.Error = "Invalid credentials";
            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync("MyCookiesAuth");
            return RedirectToAction("Login");
        }
    }
}
