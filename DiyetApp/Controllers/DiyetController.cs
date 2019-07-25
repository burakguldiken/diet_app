using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DiyetApp.Models;

namespace DiyetApp.Controllers
{
    public class DiyetController : Controller
    {
        // GET: Diyet
        public ActionResult Index()
        {
            return View(Veritabani.ListeGonder); //Index.cshtml
        }

        [HttpGet]
        public ActionResult Ekle()
        {
            return View(); //Ekle.cshtml
        }

        [HttpPost]
        public ActionResult Ekle(Diyet diyet)
        {
            diyet.Tarih = DateTime.Now;
            diyet.Tamamlandimi = false;
            Veritabani.DiyetEkle(diyet);  //veritabanına eklenir

            return View("Index",Veritabani.ListeGonder);  // Index.cshtml sayfasına yönlendirilir kullanıcı ve son liste gönderilir.
        }

    }
}