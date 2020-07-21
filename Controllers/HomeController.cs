using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Library.Models;

namespace Library.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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

        public ActionResult AddBooks(Book book) 
        {
        
            ViewBag.Message = "Your contact page.";

            using (LibraryContext libraryContext = new LibraryContext())
            {
                //var Books = libraryContext
            }
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }

            return View();
        }
    }
}