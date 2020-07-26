using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using Library.Models;

namespace Library.BusinessLogic
{
    public class UserSignup
    {
        public static void CreateUser(string user_name, int user_age, string user_address, string user_zipcode, string user_mail, string user_password)
        {

            User data = new User
            {
                user_name = user_name,
                user_age = user_age,
                user_address = user_address,
                user_zipcode = user_zipcode,
                user_mail = user_mail,
                user_password = user_password

            };
            using (LibraryContext libraryContextUser = new LibraryContext())
            {
                libraryContextUser.Users.Add(data);
                libraryContextUser.SaveChanges();
            }
        }
    }
}