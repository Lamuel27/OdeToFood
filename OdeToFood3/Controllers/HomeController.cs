using OdeToFood2.Models;
using OdeToFood3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood2.Controllers
{
    public class HomeController : Controller
    {
        OdeToFoodDb _db = new OdeToFoodDb();


        public ActionResult Index()
        {
            var model = _db.Restaurants.ToList();

            return View(model);
        }

        public ActionResult About()
        {
            var model = new AboutModel();
            model.Name = "Lamuel";
            model.Location = "Wisconsin, USA";
            return View(model);
        }

        public ActionResult Contact()
        {
            var model = new ContactModel();
            model.Name = "Lamuel";
            model.Street = "1st Avenue";
            model.City = "Hopkins";
            model.State = "Minnesota";
            model.Zip = 54449;

            return View(model);
        }
        protected override void Dispose(bool disposing)
        {
            if (_db != null)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}