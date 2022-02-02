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
        private hbroMoviesContext moviedbContext { get; set; }

        //Constructor
        public HomeController(hbroMoviesContext name)
        {
            moviedbContext = name;
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
            moviedbContext.Add(mr);
            moviedbContext.SaveChanges();

            return View("confirmation", mr);
        }

        public IActionResult MyPodcast()
        {
            return View();
        }

        public IActionResult MovieList ()
        {
            var applications = moviedbContext.responses.ToList();
            
            return View(applications);
        }
    }
}
