using odeToFood.DL.ViewModels;
using odeToFood.UI.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace odeToFood.UI.Controllers
{
    public class HomeController : Controller, IDisposable
    {
        private readonly RestaurantDbContext _db;

        public HomeController()
        {
            _db = new RestaurantDbContext();
        }

        public ActionResult Index()
        {
            var model = _db.Restaurants.Select(x => new RestaurantReviewsViewModel
            {
               RestaurantName = x.Name,
               City  = x.City,
               Country = x.Country,
               Rating = x.Reviews.Max( y => y.Rating),
               RateDescription  = x.Reviews.Select(y => y.Description).FirstOrDefault()
            }).OrderByDescending(x => x.Rating)
            .Where(x => x.Rating > 8).ToList();
    

            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
            base.Dispose(disposing);
        }
    }
}
