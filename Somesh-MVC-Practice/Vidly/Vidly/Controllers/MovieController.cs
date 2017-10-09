using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie/Index
        public ActionResult Index()
        {
            var Movie = GetMovie();
            return View(Movie);
        }

        public ActionResult Details (int id)
        {
            var Movie = GetMovie().SingleOrDefault(c => c.ID == id);
            if (Movie == null)
                return HttpNotFound();

            return View(Movie);
        }

        private IEnumerable<Movie> GetMovie()
        {
            return new List<Movie>
            {
                new Movie{ID=1,Name="Shrek"},
                new Movie{ID=2, Name="Sully"}
            };
        }
    }
}