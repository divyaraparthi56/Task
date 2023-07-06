using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using unittest_mvc_20_06_23_hw_.Models;
using UserService;

namespace unittest_mvc_20_06_23_hw_.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUserMessageService _userMessageService;

        public HomeController(IUserMessageService userMessageService,ILogger<HomeController> logger)
        {
            _logger = logger;
            _userMessageService= userMessageService;
        }

        public IActionResult Index()
        {
            ViewBag.Message = _userMessageService.GetMessageFromDb();
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