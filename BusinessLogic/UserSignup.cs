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
        public static void CreateUser(string UserName, int UserAge, string UserAddress, string UserZipcode, string UserMail, string UserConfirmMail, string UserPassword, string UserConfirmPassword)
        {

            User data = new User
            {
                UserName = UserName,
                UserAge = UserAge,
                UserAddress = UserAddress,
                UserZipcode = UserZipcode,
                UserMail = UserMail,
                UserConfirmMail = UserConfirmMail,
                UserPassword = UserPassword,
                UserConfirmPassword = UserConfirmPassword

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