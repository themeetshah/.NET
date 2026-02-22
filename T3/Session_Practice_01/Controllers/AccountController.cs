using Microsoft.AspNetCore.Mvc;
using Session_Practice_01.Models;

namespace Session_Practice_01.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (model.Username == "admin" && model.Password == "12345")
            {
                HttpContext.Session.SetString("username", model.Username);
                return RedirectToAction("Index", "Home");
            }

            ViewBag.Error = "invalid creds.";
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove("username");
            return RedirectToAction("Login");
        }
    }
}
