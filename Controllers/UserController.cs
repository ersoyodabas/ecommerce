using System.Diagnostics;
using ecommerce.Models;
using ecommerce.Models.View;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ecommerce.Controllers
{
    public class UserController : Controller
    {
        private readonly ILogger<UserController> _logger;
        private readonly EcommerceDbContext _context;

        public UserController(ILogger<UserController> logger, EcommerceDbContext context)
        {
            _logger = logger;
            _context = context;
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
        public async Task<IActionResult> Register(UserViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Kullanýcý sayýsýný asenkron olarak veritabanýndan çek
                int userCount = await _context.users.CountAsync();
                _logger.LogInformation($"Toplam Kullanýcý Sayýsý: {userCount}");

                // Yeni kullanýcýyý oluþtur
                var newUser = new user
                {
                    name = model.name,
                    surname = model.surname,
                    phone_area = model.phone_area,
                    phone_number = model.phone_number,
                    gender = model.gender,
                };

                // Veritabanýna ekleyip kaydet (asenkron)
                _context.users.Add(newUser);
                await _context.SaveChangesAsync();

                return RedirectToAction("Index");
            }

            return View(model);
        }
    }
}
