using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Classes;

namespace TravelTripProje.Controllers
{
    public class IletisimController : Controller
    {
        // GET: Iletisim
        context c = new context();
        public ActionResult Index()
        {
            var degerler = c.AddressBlogs.ToList();
            return View(degerler);
        }
        [HttpGet]
        public PartialViewResult Mesaj()
        {
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult Mesaj(communication com)
        {
            c.Communications.Add(com);
            c.SaveChanges();
            return PartialView();
        }

    }
}