using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MasteringAzure.Models;
using Microsoft.Extensions.Logging;

namespace MasteringAzure.Controllers
{
    public class HomeController : Controller
    {
        private ILogger _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            _logger.LogInformation($"Index {DateTime.Now}");
            return View();
        }

        public IActionResult About()
        {
            _logger.LogInformation($"About {DateTime.Now}");

            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            _logger.LogInformation($"Contact {DateTime.Now}");

            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            _logger.LogInformation($"Privacy {DateTime.Now}");

            return View();
        }

        public IActionResult NullRef()
        {
            _logger.LogInformation($"NullRef {DateTime.Now}");
            int? nullthing = null;

            var foo = nullthing / nullthing;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            _logger.LogInformation($"Error {DateTime.Now}");

            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
