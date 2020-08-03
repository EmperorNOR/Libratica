using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library.Models;

namespace Library.BusinessLogic
{
    public class ProfileInfo
    {
        public static string ProfileLogic()
        {
           string mail = HttpContext.Current.Request.Cookies["user"].Value.ToString();

            //using (LibraryContext libraryContextlogin = new LibraryContext())
            //{
            //    var login = libraryContextlogin.Users.FirstOrDefault(x => x.user_mail == HttpContext.Current.Request.Cookies["user"].Value.ToString());
            //    if (login != null)
            //    {
            //        User data = new User
            //        {
            //            user_name = libraryContextlogin.Users.Find.mail,
            //            user_age = user_age,
            //            user_address = user_address,
            //            user_zipcode = user_zipcode,
            //            user_mail = user_mail,
            //            user_confirmmail = user_confirmmail,
            //            user_password = user_password,
            //            user_confirmpassword = user_confirmpassword

            //        //};

            //   // }
                return mail;
           


            }
    }
}