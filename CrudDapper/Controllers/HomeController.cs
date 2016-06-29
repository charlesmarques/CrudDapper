using CrudDapper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CrudDapper.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        MobileMain _db = new MobileMain();
        public ActionResult Index()
        {
            return View(_db.GetAll());
        }

        // GET: Home/Details/5
        public ActionResult Details(string id)
        {
            
            return View(_db.GetMobileList(id));
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
        [HttpPost]
        public ActionResult Create(Mobiledata obj)
        {
               
            _db.Add(obj);

                return RedirectToAction("Index");
        }

        // GET: Home/Edit/5
        public ActionResult Edit(string id)
        {
            
            return View(_db.GetMobileList(id));
        }

        // POST: Home/Edit/5
        [HttpPost]
        public ActionResult Edit(Mobiledata obj)
        {
            _db.Updatemobile(obj);
            return RedirectToAction("Index");
          
        }

        // GET: Home/Delete/5
        [HttpGet]  
        public ActionResult Delete(string id)
        {
           
            return View(_db.GetMobileList(id));
        }

        // POST: Home/Delete/5
        [HttpPost]
        public ActionResult Delete(string id, string MobileName)
        {
            _db.DeleteMobile(id);
            return RedirectToAction("Index");   
        }
    }
}
