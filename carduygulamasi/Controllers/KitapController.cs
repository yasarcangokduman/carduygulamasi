using Microsoft.AspNetCore.Mvc;

namespace carduygulamasi.Controllers
{
    public class KitapController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
