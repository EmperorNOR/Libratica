﻿using System;
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
                UserName = user_name,
                UserAge = user_age,
                UserAddress = user_address,
                UserZipcode = user_zipcode,
                UserMail = user_mail,
                UserConfirmMail = user_confirmmail,
                UserPassword = user_password,
                UserConfirmPassword = user_confirmpassword

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