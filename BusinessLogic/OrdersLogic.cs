using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library.ViewModels;
using Library.Models;

namespace Library.BusinessLogic
{
    public class OrdersLogic
    {
        public static OrdersViewModel OrderLogic()
        {


            var email = HttpContext.Current.Request.Cookies["user"].Value.ToString();

            using (var context = new LibraryContext())
            {
                var user = context.Users;
                List<User> data = new List<User>();
                foreach(var elem in user)
                { 
                    data.Add(new User { user_id = elem.user_id, user_name = elem.user_name, user_address = elem.user_address, user_zipcode = elem.user_zipcode, user_mail = elem.user_mail });
                    var userhasbooks = context.UsersBooks.Where(u => u.users_user_id == elem.user_id);
                    List<UsersHasBooksModel> databooks = new List<UsersHasBooksModel>();
                    foreach (var element in userhasbooks)
                    { 
                        databooks.Add(new UsersHasBooksModel { users_user_id = element.users_user_id, books_book_id = element.books_book_id });
                    }

                 

                }

                return (new OrdersViewModel { user = data, book = databooks });




            }

        }
    }
}