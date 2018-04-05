using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ohmcal.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult About(string boxA, string boxB, string boxC, string boxD, float boxE)
        {
            
         
           OhmValueCalculator ohm = new OhmValueCalculator();
           int val= ohm.CalculateOhmValue(boxA,boxB,boxC,boxD);
            
            ViewBag.Message = val;
            ViewBag.tol =  boxE;
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}