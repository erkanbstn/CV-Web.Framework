using CV.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CV.Controllers
{
    public class HomePageController : Controller
    {
        Tables s = new Tables();
        public ActionResult Home()
        {
            return View();
        }
        public PartialViewResult Links()
        {
            s.ResultLink = Baglanti.db.TLinks.ToList();
            s.ResultHome = Baglanti.db.THome.ToList();
            return PartialView(s);
        }
        public PartialViewResult Profiles()
        {
            s.ResultHome = Baglanti.db.THome.ToList();
            return PartialView(s);
        }
       
        public PartialViewResult Services()
        {
            s.ResultServices = Baglanti.db.TServices.ToList();
            return PartialView(s);
        }
        public PartialViewResult Portfolio()
        {
            s.ResultPortfolio1 = Baglanti.db.TPortfolio1.ToList();
            s.ResultPortfolio2 = Baglanti.db.TPortfolio2.ToList();
            return PartialView(s);
        }
        public PartialViewResult Resume()
        {
            s.ResultResume1 = Baglanti.db.TResume1.ToList();
            s.ResultResume2 = Baglanti.db.TResume2.ToList();
            return PartialView(s);
        }
        public PartialViewResult Skills()
        {
            s.ResultSkills = Baglanti.db.TSkills.ToList();
            return PartialView(s);
        }
        public PartialViewResult Facts()
        {
            s.ResultFacts = Baglanti.db.TFacts.ToList();
            return PartialView(s);
        }
        public PartialViewResult About()
        {
            s.ResultAbout = Baglanti.db.TAbout.ToList();
            return PartialView(s);
        }
        public PartialViewResult Footer()
        {
            s.ResultLink = Baglanti.db.TLinks.Where(b=>b.Link=="linkedin").ToList();
            return PartialView(s);
        }
        [HttpGet]
        public PartialViewResult Contact()
        {
            s.ResultContact = Baglanti.db.TContact.ToList();
            return PartialView(s);
        }
        [HttpPost]
        public PartialViewResult Contact(TMessages t)
        {
            s.ResultContact = Baglanti.db.TContact.ToList();
            Baglanti.db.TMessages.Add(t);
            Baglanti.db.SaveChanges();
            return PartialView(s);
        }
    }
}