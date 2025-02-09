using ecommerce.Models;
using Microsoft.AspNetCore.Mvc;


namespace ecommerce.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult deneme()
        {
            string message = $"Hello World. {DateTime.Now.ToString()}";
            return View("deneme" , message);
        }
        public ViewResult text()
        {
            var names = new String[]
            {
                "Ali",
                "Veli",
                "Can"
            };
            return View(names);
        }

        public IActionResult example()
        {
            var list = new List<Employee>()
            {
                new Employee(){Id=1, FirstName="Ali", LastName="Veli", Age=20},
                new Employee(){Id=2, FirstName="Ahmet", LastName="can", Age=18},
            };
            return View("example", list);
        }
    }
}