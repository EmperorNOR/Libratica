using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Models
{
    [Table("books")]
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int book_id { get; set; }


        [Required(ErrorMessage = "You must fill in this field with a valid input")]
        [Display(Name = "Name")]
        public string book_name { get; set; }


        [Required(ErrorMessage = "You must fill in this field with a valid input")]
        [Display(Name = "Genre")]
        public string book_genre { get; set; }


        [Required(ErrorMessage = "You must fill in this field with a valid input")]
        [Display(Name = "Year of Release YYYY")]
        public int book_year { get; set; }


        [Required(ErrorMessage = "You must fill in this field with a valid input")]
        [Display(Name = "Description")]
        public string book_description { get; set; }


        public virtual IList<User> Users { get; set; }
    }
}