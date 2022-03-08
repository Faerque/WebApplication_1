using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication_1.Models;
using WebApplication_1.ViewModels;

namespace WebApplication_1.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie()
            {
                Name = "Shrek"
            };

            var customers = new List<Customer>
            {
                new Customer {Name = "Customer 1"},
                new Customer {Name = "Customer 2"},
                new Customer {Name = "Customer 3"}

            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
            // To render
        }

        [Route("movies/released/{year}/{month:regex(\\d{4}):range(1,12)}")]

        public ActionResult ByReleasedDate(int year, int month)
        {

            return Content(year+"/"+month);
        }

    }
}