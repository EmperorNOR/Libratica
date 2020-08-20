using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library.Models;

namespace Library.BusinessLogic
{
    public class ProfileViewModel
    {
        public User User { get; set; }

        public UsersHasBooksModel book { get; set; }
    }
}