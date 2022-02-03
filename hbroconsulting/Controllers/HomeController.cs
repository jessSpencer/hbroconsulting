using hbroconsulting.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            ViewBag.Categories = moviedbContext.Categories.ToList();

            return View();
        }

        [HttpPost]
        public IActionResult Movies(movieresponse mr)
        {
            if (ModelState.IsValid)
            {
                moviedbContext.Add(mr);
                moviedbContext.SaveChanges();

                return View("confirmation", mr);
            }
            else
            {
                ViewBag.Categories = moviedbContext.Categories.ToList();

                return View();
            }

        }

        public IActionResult MyPodcast()
        {
            return View();
        }

        public IActionResult MovieList ()
        {
            var applications = moviedbContext.responses
                .Include(x => x.Category)
                .Where(x => x.Director != "Gibili")
                .OrderBy(x => x.Director)
                .ToList();
            
            return View(applications);
        }

        [HttpGet]
        public IActionResult Edit(int movieid)
        {
            ViewBag.Categories = moviedbContext.Categories.ToList();

            var entry = moviedbContext.responses.Single(x => x.MovieId == movieid); 

            return View("Movies", entry);
        }

        [HttpPost]
        public IActionResult Edit(movieresponse z)
        {
            if (ModelState.IsValid)
            {
                moviedbContext.Update(z);
                moviedbContext.SaveChanges();

                return RedirectToAction("MovieList");
            }
            else
            {
                ViewBag.Categories = moviedbContext.Categories.ToList();

                return View("Movies");
            }
        }

        [HttpGet]
        public IActionResult Delete(int movieid)
        {
            var entry = moviedbContext.responses.Single(x => x.MovieId == movieid);

            return View(entry);
        }

        [HttpPost]
        public IActionResult Delete(movieresponse mr)
        {
            moviedbContext.responses.Remove(mr);
            moviedbContext.SaveChanges();

            return RedirectToAction("MovieList");
        }
    }
}
