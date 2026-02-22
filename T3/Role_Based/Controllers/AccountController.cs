using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using Role_Based.Models;
using System.Security.Claims;

namespace Role_Based.Controllers
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
                var claims = new List<Claim> {
                    new Claim(ClaimTypes.Name, model.Username),
                    new Claim(ClaimTypes.Role, "Admin"), // ============ Added role claim
                };
                var identity = new ClaimsIdentity(claims, "MyCookiesAuth");
                var principal = new ClaimsPrincipal(identity);
                await HttpContext.SignInAsync("MyCookiesAuth", principal);
                return RedirectToAction("Index", "Home");
            } else if (model.Username == "peon" && model.Password == "chai pee lo")
            {
                var claims = new List<Claim> {
                    new Claim(ClaimTypes.Name, model.Username),
                    new Claim("Department", "PEON") // ============ Added custom claim for policy
                };
                var identity = new ClaimsIdentity(claims, "MyCookiesAuth");
                var principal = new ClaimsPrincipal(identity);
                await HttpContext.SignInAsync("MyCookiesAuth", principal);
                return RedirectToAction("Privacy", "Home");
            }
                ViewBag.Error = "Invalid credentials";
            return View();
        }
        public async Task<IActionResult> Logout()
        {
            // Implement logout logic here (e.g., sign out the user)
            return RedirectToAction("Login");
        }
        public IActionResult AccessDenied()
        {
            return RedirectToAction("Login", "Account");
        }
    }
}
