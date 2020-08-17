using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library.Models;

namespace Library.BusinessLogic
{
    public class ProfileInfo
    {
        public static User ProfileLogic()
        {
           //string mail = HttpContext.Current.Request.Cookies["user"].Value.ToString();

            var email = HttpContext.Current.Request.Cookies["user"].Value.ToString();

            using (var context = new LibraryContext())
            {
                var user = context.Users.SingleOrDefault(u => u.user_mail.ToLower() == email.ToLower());
                var data = new User
                {
                    user_name = user.user_name,
                    user_age = user.user_age,
                    user_address = user.user_address,
                    user_zipcode = user.user_zipcode,
                    user_mail = user.user_mail,

                };
                return (data);

            }
           


            }
    }
}