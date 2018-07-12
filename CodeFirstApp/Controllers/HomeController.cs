using CodeFirstApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeFirstApp.Controllers{

    public class HomeController : Controller{

        private DataEntities db = new DataEntities();

        public ActionResult Index(){
            return View();
        }

        public ActionResult About(){
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact(){
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Create(){
            return View();
        }

        [HttpPost]
        public ActionResult Create(Clientes cliente){

            if (ModelState.IsValid){
                db.Clientes.Add(cliente);
                db.SaveChanges();
                RedirectToAction("Index");
            }
            
            return View(cliente);
        }


    }
}