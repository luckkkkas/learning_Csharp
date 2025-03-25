using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCApi.Models.ViewModels;

namespace MVCApi.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index() //esse nome é o endpoint
        {
           
            return View();
        }

        public IActionResult Privacy() //esse nome é o endpoint
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() //esse nome é o endpoint
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
