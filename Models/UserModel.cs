using System;
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
        [Column("user_id")]
        public int UserId { get; set; }


        [Required(ErrorMessage = "You need to type in a name")]
        [Column("user_name")]
        [Display(Name ="Username")]
        public string UserName { get; set; }


        [Required(ErrorMessage = "You need to add your age to the site")]
        [Column("user_age")]
        [Display(Name = "Age")]
        public int UserAge { get; set; }


        [Required(ErrorMessage = "We require an address")]
        [Column("user_address")]
        [Display(Name = "Address")]
        public string UserAddress { get; set; }


        [Required(ErrorMessage = "We require a zipcode")]
        [Column("user_zipcode")]
        [Display(Name = "Zipcode")]
        public string UserZipcode { get; set; }


        [Required(ErrorMessage = "We require an email address")]
        [Column("user_mail")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Mail")]
        public string UserMail { get; set; }


        [Required]
        [DataType(DataType.EmailAddress)]
        [NotMapped]
        [Compare("user_mail", ErrorMessage = "Your email and confirm email does not match")]
        [Display(Name = "Confirm Email")]
        public string UserConfirmMail { get; set; }


        [Required]
        [Column("user_password")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string UserPassword { get; set; }


        [Required]
        [DataType(DataType.Password)]
        [NotMapped]
        [Compare("user_password", ErrorMessage ="Your password and confirm password does not match")]
        [Display(Name = "Confirm Password")]
        public string UserConfirmPassword { get; set; }
        public virtual IList<Book> Books { get; set; }
    }
}