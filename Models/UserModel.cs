﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Models
{
    [Table("users")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int user_id { get; set; }


        [Required(ErrorMessage = "You need to type in a name")]
        [Display(Name ="Username")]
        public string user_name { get; set; }


        [Required(ErrorMessage = "You need to add your age to the site")]
        [Display(Name = "Age")]
        public int user_age { get; set; }


        [Required(ErrorMessage = "We require an address")]
        [Column("user_address")]
        [Display(Name = "Address")]
        public string user_address { get; set; }


        [Required(ErrorMessage = "We require a zipcode")]
        [Display(Name = "Zipcode")]
        public string user_zipcode { get; set; }


        [Required(ErrorMessage = "We require an email address")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Mail")]
        public string user_mail { get; set; }


        [Required]
        [DataType(DataType.EmailAddress)]
        [NotMapped]
        [Compare("user_mail", ErrorMessage = "Your email and confirm email does not match")]
        [Display(Name = "Confirm Email")]
        public string user_confirmmail { get; set; }


        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string user_password { get; set; }


        [Required]
        [DataType(DataType.Password)]
        [NotMapped]
        [Compare("user_password", ErrorMessage ="Your password and confirm password does not match")]
        [Display(Name = "Confirm Password")]
        public string user_confirmpassword { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }
}