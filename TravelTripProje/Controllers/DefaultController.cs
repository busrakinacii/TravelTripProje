﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Classes;

namespace TravelTripProje.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        context c = new context();
        [Authorize]
        public ActionResult Index()
        {

            var deger = c.Blogs.ToList();
            return View(deger);
        }
        public ActionResult About()
        {
            return View();
        }
        public PartialViewResult Partial1()
        {
            var degerler = c.Blogs.OrderByDescending(x => x.ID).Take(2).ToList();
            return PartialView(degerler);
        }

        public PartialViewResult Partial2()
        {
            var deger = c.Blogs.Where(x => x.ID == 1).ToList();
            return PartialView(deger);
        }
        public PartialViewResult Partial3()
        {
            var deger = c.Blogs.Take(4).ToList();
            return PartialView(deger);
        }

        public PartialViewResult Partial4()
        {
            var degerler = c.Blogs.OrderByDescending(x => x.ID).Take(4).ToList();
            return PartialView(degerler);
        }


    }
}