using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;
using ecommerce.Models;
using ecommerce.Models.View;
using Microsoft.AspNetCore.Identity;
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

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(UserViewModel model)
        {
            //parametredeki bilgilere ait veritaban�ndaki kullan�c�y� bul.

            user exist_user = _context.users.FirstOrDefault(o => o.email == model.email && o.password == model.password);
            if (exist_user == null)
            {
                ViewBag.ErrorMessage = "E posta veya �ifre yanl��";
            }
            return View(model);

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
                // Kullan�c� say�s�n� asenkron olarak veritaban�ndan �ek
                int existUserCount = await _context.users.Where(x => x.email == model.email).CountAsync();
                if(existUserCount > 0)
                {
                    ViewBag.ErrorMessage = "Girilen e posta zaten kay�tl�";
                    return View(model);
                }

                _logger.LogInformation($"Toplam Kullan�c� Say�s�: {existUserCount}");

                // Viewmodeldeki verileri entity class'a aktar veritaban�na g�ndermek �zere. 
                user entityUser = new user
                {
                    name = model.name,
                    surname = model.surname,
                    phone_area = model.phone_area,
                    phone_number = model.phone_number,
                    gender = model.gender,
                    create_time = DateTime.Now,
                    birth_date = model.birth_date,
                    email = model.email,
                    password = HashPasswordMD5(model.password)
                };

                // Veritaban�na ekleyip kaydet (asenkron)
                _context.users.Add(entityUser);
                await _context.SaveChangesAsync();
                TempData["SuccessMessage"] = "Kay�t i�lemi ba�ar�l�! Giri� yapabilirsiniz.";

                // Login sayfas�na y�nlendir
                return RedirectToAction("Login");
            }

            return View(model);
        }
        public static string HashPasswordMD5(string password)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(password);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    sb.Append(b.ToString("x2")); // Hexadecimal format
                }

                return sb.ToString();
            }
        }
    }
}
