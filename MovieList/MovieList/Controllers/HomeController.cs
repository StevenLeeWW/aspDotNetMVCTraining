﻿using Microsoft.AspNetCore.Mvc;
using MovieList.Models;
using Microsoft.EntityFrameworkCore;

namespace MovieList.Controllers
{
    public class HomeController : Controller
    {
        private MovieContext context { get; set; }
        public HomeController(MovieContext context)
        {
            this.context = context;
        }

        //[HttpGet]
        public IActionResult Index()
        {
            var movies = context.Movies.Include(m => m.Genre).OrderBy(m => m.Name).ToList();
            return View(movies);
        }
        
    }
}
