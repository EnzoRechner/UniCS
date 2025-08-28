using Microsoft.AspNetCore.Mvc;
using DV._2023.T1F5N8.ITEHA.D3.Models;

namespace DV._2023.T1F5N8.ITEHA.D3.Controllers
{
    public class AuthController : Controller
    {
        // Hard-coded admin credentials for now
        private static readonly List<AdminUser> AdminUsers = new List<AdminUser>
        {
            new AdminUser { Username = "admin", Password = "Password123" },
            new AdminUser { Username = "superuser", Password = "Secret456" }
        };

        // GET: /Auth/Login
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        // POST: /Auth/Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(AdminUser model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = AdminUsers.FirstOrDefault(u =>
                u.Username.Equals(model.Username, StringComparison.OrdinalIgnoreCase) &&
                u.Password == model.Password
            );

            if (user != null)
            {
                // Successful login -> redirect to Employee list
                return RedirectToAction("Index", "Employee");
            }

            // Invalid login
            ModelState.AddModelError("", "Invalid username or password");
            return View(model);
        }
    }
}
