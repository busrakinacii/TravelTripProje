using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Classes;

namespace TravelTripProje.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        context c = new context();
        public ActionResult Index()
        {
            var degerler = c.Blogs.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniBlog()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YeniBlog(blog p)
        {
            c.Blogs.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult BlogSil(int id)
        {
            var b = c.Blogs.Find(id);
            c.Blogs.Remove(b);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult BlogGetir(int id)
        {
            var bl = c.Blogs.Find(id);
            return View("BlogGetir", bl);
        }
        public ActionResult BlogGuncelle(blog b)
        {
            var blg = c.Blogs.Find(b.ID);
            blg.Aciklama = b.Aciklama;
            blg.Tarih = b.Tarih;
            blg.Baslik = b.Baslik;
            blg.BlogImage = b.BlogImage;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult YorumListesi()
        {
            var yorumlar = c.Comments.ToList();
            return View(yorumlar);
        }

    }
}