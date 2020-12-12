using System;
using MVcdemo.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVcdemo.Controllers
{
    public class BookingController : Controller
    {
        // GET: Booking
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult BookingDetails()
        {
            var b = new Booking() { Id = 1, PackName = "spa combo" };
            return View(b);
        }
    }
}