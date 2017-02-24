using OdeToFood3.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood3.Controllers
{   
    //[Authorize] //Action filters can also be placed on controllers as well as methods
    [Log]
    public class CuisineController : Controller
    {
        // GET: Cuisine
        //[HttpPost] //You can only invoke this method during an HTTP Post message
        //[Authorize] //Action Filters - tells framework that user has to be logged in in order to use this method
        public ActionResult Search(string name = "french")

        {
            //throw new Exception("Something terrible has happened.");

            var message = Server.HtmlEncode(name);
            return Content(message); //returns a string, Controllers in MVC-Actions Results
            //return RedirectToAction("Index", "Home", new { name = name });
            //return RedirectToRoute("Default", new { controller = "Home", action="About" });
            //return File(Server.MapPath("~/Content/site.css"), "text/css"); //return a file (virtual/relative path), "content type"
            //return Json(new { Message = message, Name = "Katherine" }, JsonRequestBehavior.AllowGet); //returns Javascript with JS Object Notation
        }
    }
}