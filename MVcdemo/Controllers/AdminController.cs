using MVcdemo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;




namespace MVcdemo.Controllers
{
    public class AdminController : Controller
    {
        private Context _context;
        public AdminController()
        {
            _context = new Context();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Admin
        public ActionResult Index()
        {
            var adminlist = _context.admins.ToList();

            return View(adminlist);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Email,RetypeEmail,Phone,Snic,Age,City,Address,DateTime")] Admin admin)
        {
            if (ModelState.IsValid)
            {
                _context.admins.Add(admin);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(admin);
        }
        public ActionResult Edit(int? id)
        {


            if (id == null)
            {

                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Admin a = _context.admins.Find(id);
            if (a == null)
            {
                return HttpNotFound();
            }
            return View(a);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Email,RetypeEmail,Phone,Snic,Age,City,Address,DateTime")] Admin admin)
        {
            if (ModelState.IsValid)
            {
                _context.Entry(admin).State = EntityState.Modified;
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(admin);
        }
        public ActionResult Delete(int? id)
        {


            if (id == null)
            {

                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Admin a = _context.admins.Find(id);
            if (a == null)
            {
                return HttpNotFound();
            }
            return View(a);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Admin admin = _context.admins.Find(id);
            _context.admins.Remove(admin);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Details(int? id)
        {


            if (id == null)
            {

                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Admin a = _context.admins.Find(id);
            if (a == null)
            {
                return HttpNotFound();
            }
            return View(a);
        }
    }
}

   