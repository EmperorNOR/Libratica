using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library.Models;
using Library.ViewModels;

namespace Library.BusinessLogic
{
    public class ProfileInfo
    {
        public static ProfileViewModel ProfileLogic()
        {
           

            var email = HttpContext.Current.Request.Cookies["user"].Value.ToString();

            using (var context = new LibraryContext())
            {
                var user = context.Users.SingleOrDefault(u => u.user_mail.ToLower() == email.ToLower());
                var data = new User
                {
                    user_id = user.user_id,
                    user_name = user.user_name,
                    user_age = user.user_age,
                    user_address = user.user_address,
                    user_zipcode = user.user_zipcode,
                    user_mail = user.user_mail,
                   

                };
                var userhasbooks = context.UsersBooks.SingleOrDefault(u => u.users_user_id == user.user_id);
                var databooks = new UsersHasBooksModel
                {
                    users_user_id = userhasbooks.users_user_id,
                    books_book_id = userhasbooks.books_book_id
                };
                

                return (new ProfileViewModel { User = data, book = databooks});

            }
         
            }


    }
}