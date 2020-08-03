using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library.Models;
using System.Diagnostics;
using System.Data.Entity.Validation;

namespace Library.BusinessLogic
{
    public class LoginLogic
    {
        public void Login(string mail, string password)
        {
            User data = new User
            {
                user_mail = mail,
                user_password = password,
            };

            using (LibraryContext libraryContextlogin = new LibraryContext())
            {
                var login = libraryContextlogin.Users.FirstOrDefault(x => x.user_mail == mail && x.user_password == password);
                if (login != null)
                {
                    HttpCookie usercookie = new HttpCookie("user", data.user_mail);
                    usercookie.Expires.AddDays(10);
                    HttpContext.Current.Response.SetCookie(usercookie);

                }

                    
            }

            
        }

        public void Logout()
        {
            if(HttpContext.Current.Request.Cookies["user"] != null)
            {
                var x = new HttpCookie("user");
                x.Expires = DateTime.Now.AddDays(-1);
                HttpContext.Current.Response.Cookies.Add(x);
            }

            
        }
    }
}