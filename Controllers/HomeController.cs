using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Library.Models;
using Library.BusinessLogic;
using Library.ViewModels;
using System.Threading.Tasks;

namespace Library.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

   
        public ActionResult Books()
        {
            var books = BookAdder.LoadBooks();
            var viewModel = new LibraticaViewModel
            {
                Books = books.ToList(),
            };

            return View(viewModel);
        }


        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult AddBooks(Book book) 
        {
        
            ViewBag.Message = "Admin page to add new books!";

            if (ModelState.IsValid)
            {
                BookAdder.CreateBook(book.book_name, book.book_genre, book.book_year, book.book_description);
                return RedirectToAction("Index");
            }

            return View();
        }

        public ActionResult LoginSignup(User user)
        {

            ViewBag.Message = "Signup for Libratica";

            if (ModelState.IsValid)
            {
                UserSignup.CreateUser(user.user_name, user.user_age, user.user_address, user.user_zipcode, user.user_mail, user.user_password);
                return RedirectToAction("Index");
           }

            return View();
        }
    }
}