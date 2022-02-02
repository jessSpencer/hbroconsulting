using hbroconsulting.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace hbroconsulting.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private hbroMoviesContext _theContext { get; set; }

        //Constructor
        public HomeController(ILogger<HomeController> logger, hbroMoviesContext name)
        { 
            _logger = logger;
            _theContext = name;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Movies()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Movies(movieresponse mr)
        {
            _theContext.Add(mr);
            _theContext.SaveChanges();

            return View("confirmation", mr);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult MyPodcast()
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
