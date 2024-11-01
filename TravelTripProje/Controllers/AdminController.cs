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
        [Authorize]
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
        public ActionResult YorumSil(int id)
        {
            var y = c.Comments.Find(id);
            c.Comments.Remove(y);
            c.SaveChanges();
            return RedirectToAction("YorumListesi");
        }
        public ActionResult YorumGetir(int id)
        {
            var yr = c.Comments.Find(id);
            return View("YorumGetir", yr);
        }
        public ActionResult YorumGuncelle(comment y)
        {
            var yrm = c.Comments.Find(y.ID);
            yrm.KullaniciAdi = y.KullaniciAdi;
            yrm.Mail = y.Mail;
            yrm.Yorum = y.Yorum;
            c.SaveChanges();
            return RedirectToAction("YorumListesi");
        }
        public ActionResult MesajListesi()
        {
            var mesajlar = c.Communications.ToList();
            return View(mesajlar);
        }
        public ActionResult MesajSil(int id)
        {
            var y = c.Communications.Find(id);
            c.Communications.Remove(y);
            c.SaveChanges();
            return RedirectToAction("MesajListesi");
        }
        public ActionResult MesajGetir(int id)
        {
            var yr = c.Communications.Find(id);
            return View("MesajGetir", yr);
        }
        public ActionResult HakkimdaGetir(int id=1)
        {
            var yr = c.Abouts.Find(id);
            return View();
        }
        public ActionResult HakkimdaGuncelle(about y)
        {
            var hak = c.Abouts.Find(y.ID);
            hak.Aciklama = y.Aciklama;
            hak.FotoUrl = y.FotoUrl;
            c.SaveChanges();
            return View();
        }

        //public ActionResult HakkimdaGetir(int id = 1)
        //{
        //    var hak = c.Comments.Find(id);
        //    return View("HakkimdaGetir", hak);
        //}



    }
}