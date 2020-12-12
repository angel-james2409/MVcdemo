using MVcdemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;



namespace MVcdemo.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CusDetails()
        {
            var cus = new Customer() { Id= 1 , Name= "angel james"};
        
           return View(cus);
        }

    }
}