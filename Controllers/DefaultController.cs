using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using SkillsCodeFirstEF.Models.Classes;

namespace SkillsCodeFirstEF.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            Context x = new Context();
            var val = x.Skillss.ToList();
            var a = x.Hedass.ToList();
            return View(val);
        }
    
    }
}