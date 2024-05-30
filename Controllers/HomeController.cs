using Doctor_Booking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Doctor_Booking.Controllers
{
    public class HomeController : Controller
    {
        private Model1 db = new Model1();
        public ActionResult Index()
        {
            
            ViewBag.User = db.User.Where(u=>u.ID >6).Take(6).ToList();
            return View(db.Major.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "BookingDoctor Online Appointment System.";

            return View();
        }
    }
}