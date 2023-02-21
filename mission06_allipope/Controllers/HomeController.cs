using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using mission06_allipope.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace mission06_allipope.Controllers
{
    public class HomeController : Controller
    {
        private MovieContext movieContext { get; set; }

        // Constructor
        public HomeController(MovieContext x)
        {
            movieContext = x;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MovieForm()
        {
            ViewBag.Categories = movieContext.Categories.ToList();
            
            return View("MovieForm", new MovieResponse());
        }

        [HttpPost]
        public IActionResult MovieForm (MovieResponse mr)
        {
            if (ModelState.IsValid)
            {
                movieContext.Add(mr);
                movieContext.SaveChanges();
                return View("Confirmation", mr);
            }

            else
            {
                ViewBag.Categories = movieContext.Categories.ToList();
                return View();
            }
        }

        public IActionResult Podcast ()
        {
            return View();
        }


        [HttpGet]
        public IActionResult MovieList ()
        {
            var movies = movieContext.Responses
                .Include(x => x.Category)
                .OrderBy(x => x.Title)
                .ToList();
            return View(movies);
        }


        [HttpGet]
        public IActionResult Edit (int id)
        {
            ViewBag.Categories = movieContext.Categories.ToList();
            var submission = movieContext.Responses.Single(x => x.MovieId == id);
            return View("MovieForm", submission);
        }

        [HttpPost]
        public IActionResult Edit (MovieResponse blah)
        {
            movieContext.Update(blah);
            movieContext.SaveChanges();
            return RedirectToAction("MovieList");
        }


        [HttpGet]
        public IActionResult Delete (int id)
        {
            var submission = movieContext.Responses.Single(x => x.MovieId == id);
            return View(submission);
        }

        [HttpPost]
        public IActionResult Delete (MovieResponse mr)
        {
            movieContext.Responses.Remove(mr);
            movieContext.SaveChanges();
            return RedirectToAction("MovieList");
        }

    }
}
