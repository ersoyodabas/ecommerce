using ecommerce.Models;
using ecommerce.Models.View;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
//sayfada kullanılan kodların ait olduğu kütüphaneler yukarıdaki gibi sayfaya dahil edilir.

namespace ecommerce.Controllers
{
    public class ProductController : Controller
        //Controller'dan Product Controller'a miras verdik. (Yani Controller'ı soyadı gibi düşün.
        //O soyadına sahip olunca bütün her şeyden yararlanabiliyosun.
        
    {
        
        #region dipendency injection(DI)
        private readonly EcommerceDbContext _context;

        public ProductController( EcommerceDbContext context)
        {
            _context = context;
        }
        #endregion
        [HttpGet]
        //Sayfa ilk açıldığında HttpGet özelliğiyle açılıyor. (Verileri getir demek.)
        public async Task<IActionResult> Index() 
            //Index üzerine sağ tıklayıp go to view basınca bağlı olduğu view'a gidiyor.

        {
            // Veritabanından ürünleri çek
            try
            {
                 List<product> products = await _context.products.ToListAsync();
                ViewBag.products = products;
            }
            catch (Exception x)
            {

                throw; 
            }
         
            // Ürün listesini View'e gönder
            return View();
        }
        [HttpGet]

        public IActionResult Save()
        {
            return View();
        }
        [HttpPost]
        //Eğer sayfaya herhangi bir şey kaydetme işlemi olacaksa HttpPost kullanarak gönderme işlemi yapıyoruz.
        public IActionResult Save(ProductViewModel data)
        {
            return View();
        }
        public IActionResult Delete()
        {
            return View();
        }
        public IActionResult List()
        {
            return View();
        }
    }
}