using carduygulamasi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace carduygulamasi.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            KitapModel Kitap = new KitapModel();
            Kitap.KitapAdi = "SANTRANÇ";
            Kitap.Kitapyazar = "STEFAN ZWEİG";
            Kitap.KitapId = "Seri NO:"+1;
            Kitap.SayfaSayisi = "Sayfa Sayısı:"+72;
            ViewBag.Kitap = Kitap;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}