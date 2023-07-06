using Microsoft.AspNetCore.Mvc;
using Performance.Models;
using System.Diagnostics;

namespace Performance.Controllers
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
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Add()
        {
            return View();
        }
        public IActionResult Modify()
        {
            return View();
        }
        public IActionResult Get()
        {
            return View();
        }
        public IActionResult Delete()
        {
            return View();
        }
        public IActionResult Sales()
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