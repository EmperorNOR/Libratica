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
            return mail;


        }
    }
}