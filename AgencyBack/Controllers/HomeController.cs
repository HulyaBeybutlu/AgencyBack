using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AgencyBack.Models;

namespace AgencyBack.Controllers
{
    public class HomeController : Controller
    {
        AgencyEntities db = new AgencyEntities();
        public ActionResult Index()
        {
            ViewBag.section1 = db.Section1.First();
            ViewBag.service = db.SectionServices.ToList();
            ViewBag.portfolio = db.SectionPortfolios.ToList();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}