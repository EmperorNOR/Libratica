using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using Library.Models;
using System.Diagnostics;
using System.Data.Entity.Validation;

namespace Library.BusinessLogic
{
    public class UserSignup
    {
        public static void CreateUser(string user_name, int user_age, string user_address, string user_zipcode, string user_mail, string user_confirmmail, string user_password, string user_confirmpassword)
        {

            User data = new User
            {
                user_name = user_name,
                user_age = user_age,
                user_address = user_address,
                user_zipcode = user_zipcode,
                user_mail = user_mail,
                user_confirmmail = user_confirmmail,
                user_password = user_password,
                user_confirmpassword = user_confirmmail

            };
            using (LibraryContext libraryContextUser = new LibraryContext())
            {
                libraryContextUser.Users.Add(data);
                try
                {
                    libraryContextUser.SaveChanges();
                }
                catch (DbEntityValidationException ex)
                {
                    foreach (var entityValidationErrors in ex.EntityValidationErrors)
                    {
                        foreach (var validationError in entityValidationErrors.ValidationErrors)
                        {
                            Debug.WriteLine("Property: " + validationError.PropertyName + " Error: " + validationError.ErrorMessage);
                        }
                    }
                }

            }
        }
    }
}