using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            var customers = new List<Customer>{
                new Customer {Name = "customer 1"},
                new Customer {Name = "customer 2"},
            };
            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };
            return View(viewModel);
            //inicijalizacija na nashiot ViewModel i dodavanje na vrednosti na objektite koi sto se vo nego odnosno
            //Za koj film stanuva zbor i listata na Customers.




            //return Content("hello world");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index" , "Home", new { page = 1, sortBy="name" });
        }

        public ActionResult Edit( int id)
        {
            return Content("id = " + id);
        }

        public ActionResult Index (int? pageIndex, string sortBy)
        {
            if(!pageIndex .HasValue){
                pageIndex = 1;
            }
            if(string.IsNullOrWhiteSpace (sortBy))
            {
                sortBy = "Name";
            }

            return Content(string .Format ("Page Index = {0} & SortBy = {1}", pageIndex, sortBy));
        }

        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult MoviesIndex()
        {

            var movies = _context.Movies.ToList();
            var viewModel = new AllMoviesViewModel
            {
                Movies = movies
            };
            
            return View(viewModel);
        }

        public ActionResult Details(int id)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.Id == id);
            return View(movie);
        }

        //Definiranje na CustomRoute koga sakame za specificna akcija vo nekoj controller
        //prethodno mora da se ovozmozhi vo RouteConfig.cs so povikuvanje na - routes.MapMvcAttributeRoutes();
        [Route ("movies/released/{year:regex(\\d{4})}/{month:regex(\\d{2})}")]
        public ActionResult ByReleaseDate(int year,int month)
        {
            return Content(string.Format ("year ={0}/month={1}", year,month ));
        }
    }
}