using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library.Models;

namespace Library.ViewModels
{
    public class ProfileViewModel
    {
        public User User { get; set; }

        public List<UsersHasBooksModel> book { get; set; }
    }
}