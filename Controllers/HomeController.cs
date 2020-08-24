using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Library.Models;
using Library.BusinessLogic;
using Library.ViewModels;
using System.Threading.Tasks;
using System.Diagnostics;

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

        public ActionResult RentBooks(int bookID)
        {
            var email = HttpContext.Request.Cookies["user"].Value.ToString();

            using (var context = new LibraryContext())
            {
                var user = context.Users.SingleOrDefault(u => u.user_mail.ToLower() == email.ToLower());
                var data = new User
                {
                    user_id = user.user_id

                };

                if (HttpContext.Request.Cookies.AllKeys.Contains("user"))
                {

                    
                        RentBook.RentingBook(user.user_id, bookID);
                    
                }
            }


            return RedirectToAction("Index");
        }


        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult AddBooks(Book book) 
        {
            //Get cookie, check if user is logined
            if(HttpContext.Request.Cookies.AllKeys.Contains("user"))
            {
                  var cookievalue = Request.Cookies["user"].Value.ToString();
                //Check if the logined user is the Admin, if i used identetiy i would have checked on roles here
                if (cookievalue == "admin@live.com")
                {
                    ViewBag.Message = "Admin page to add new books!";

                    if (ModelState.IsValid)
                    {
                        BookAdder.CreateBook(book.book_name, book.book_genre, book.book_year, book.book_description);
                        return RedirectToAction("Index");
                    }

                    return View();
                }
                else
                {
                    return RedirectToAction("Index");
                }
            }
            else
            {
                return RedirectToAction("Index");
            }
           
        }

        public ActionResult LoginSignup(User user)
        {

            ViewBag.Message = "Signup for Libratica";
            //If form has valid input, create user.
            if (ModelState.IsValid)
            {
                UserSignup.CreateUser(user.user_name, user.user_age, user.user_address, user.user_zipcode, user.user_mail, user.user_confirmmail, user.user_password, user.user_confirmpassword);
                return RedirectToAction("Index");
           }

            return View();
        }

        public ActionResult Login(User user)
        {
                var loginmethod = new LoginLogic();
                loginmethod.Login(user.user_mail, user.user_password);
            return View();
            
        }

        public ActionResult Profile()
        {
            var profileinfo = ProfileInfo.ProfileLogic();
            return View(profileinfo);
        }

        public ActionResult Logoff()
        {
            var logoff = new LoginLogic();
            logoff.Logout();
           
            return RedirectToAction("Index");
        }

        public ActionResult Orders()
        {
            //Another check if user is logged in and is an admin.
            var cookievalue = Request.Cookies["user"].Value.ToString();
            if (cookievalue == "admin@live.com")
            {
                var orders = OrdersLogic.OrderLogic();
                //New model with data from OrdersLogic
                var viewmodel = new OrdersViewModel
                {
                    user = orders.user.ToList(),
                    book = orders.book.ToList()
                };
                return View(viewmodel);
            }
            else
            {
                return RedirectToAction("Index");
            }

        }

    }
}