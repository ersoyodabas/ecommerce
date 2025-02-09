using System.Diagnostics;
using ecommerce.Models;
using ecommerce.Models.View;
using Microsoft.AspNetCore.Mvc;

namespace ecommerce.Controllers
{
    public class UserController : Controller
    {
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(UserViewModel model)
        {
            return View();
        }

    }
}