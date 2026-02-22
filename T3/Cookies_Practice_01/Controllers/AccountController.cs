using Cookies_Practice_01.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Cookies_Practice_01.Controllers
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
                var identity = new ClaimsIdentity(claims, "CookieForAuth");
                var principal = new ClaimsPrincipal(identity);
                await HttpContext.SignInAsync("CookieForAuth", principal);
                return RedirectToAction("Index", "Home");
            }
            ViewBag.ErrorMessage = "Invalid username or password.";
            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync("CookieForAuth");
            return RedirectToAction("Login", "Account");
        }
    }
}
