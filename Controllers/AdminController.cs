using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using SkillsCodeFirstEF.Models.Classes;

namespace SkillsCodeFirstEF.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();
       // yetenek listele
        public ActionResult Index()
        {
         
          var deger =   c.Skillss.ToList();
            return View(deger);
        }

        [HttpGet]
        public ActionResult YeniYetenek()
        {
            return View();
        }
        // yetenek ekle
        [HttpPost]
        public ActionResult YeniYetenek(Skills s)
        {
            c.Skillss.Add(s);
            c.SaveChanges();
            return View();

        }
        // yetenek sil
        public ActionResult YetenekSil(int id)
        {
            var deger = c.Skillss.Find(id);
            c.Skillss.Remove(deger);
            c.SaveChanges();
            return RedirectToAction("Index");

        }
        // Yetenek Getir
        [HttpGet]
        public ActionResult YetenekGetir(int id)
        {
            var deger = c.Skillss.Find(id);
            return View("YetenekGetir",deger);
        }
        [HttpPost]
        public ActionResult YetenekGetir(Skills y)
        {
            var deger = c.Skillss.Find(y.ID);
            deger.Explanation = y.Explanation;
            deger.Value = y.Value;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}