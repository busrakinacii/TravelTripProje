using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Classes;

namespace TravelTripProje.Controllers
{
    public class RehberController : Controller
    {
        // GET: Rehber
        context c = new context();
        public ActionResult Index()
        {
            var sirala = c.Blogs.Take(10).ToList();
            return View(sirala);
        }
        public PartialViewResult Gorsel()
        {
            var g = c.Blogs.OrderByDescending(x => x.ID).Take(4).ToList();
            return PartialView(g);
        }

    }
}