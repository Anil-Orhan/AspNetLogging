using Microsoft.AspNetCore.Mvc;
using NLog.Models;
using System.Diagnostics;

namespace NLog.Controllers
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
            _logger.LogInformation("Index page says hello");
            _logger.LogWarning("Index page says hello");
            _logger.LogError("Index page says hello");
            return View();
        }

        public IActionResult Privacy()
        {
            _logger.LogInformation("Privacy page says hello");
            _logger.LogWarning("Privacy page says hello");
            _logger.LogError("Privacy page says hello");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
