using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood3.Controllers
{
    //[Authorize]

    public class CuisineController : Controller
    {
        public ActionResult Search(string name = "french")
        {
            //throw new Exception("Something terrible has happened");

            var message = Server.HtmlEncode(name);

            
            return Content(message);
        }

    }
}

//return Json(new { Message = message, Name = "Lamuel" }, JsonRequestBehavior.AllowGet);
//return File(Server.MapPath("~/Content/site.css"), "text/css");
//return RedirectToRoute("Default", new { controller = "Home", action = "About" });