using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Lab_21_Coffee_Shop.Models
{
    public class User
    {
        [Required] // attributes 
        [RegularExpression(@"^[a-zA-Z]{2,}$")]
        public string FirstName { get; set; }

        [Required]
        [RegularExpression(@"^[a-zA-Z]{2,}$")]
        public string LastName { set; get; }
        
        [Required]
        [RegularExpression(@"^([0-9A-z]{5,30})(@[0-9A-z]{5,10}).([0-9A-z]{2,3})$")]
        public string UserEmail { set; get; }

        [Required]
        [RegularExpression(@"^(\d{3})-(\d{3})-(\d{4})$")]
        public string PhoneNumber { set; get; }

        [Required]
        [RegularExpression(@"^[A-z0-9]{2,}$")]
        public string UserPassword { set; get; }

        public User()
        {
            FirstName = "";
            LastName = "";
            UserEmail = "";
            PhoneNumber = "";
            UserPassword = "";
        }
        public User(string fn, string ln, string ue, string pn, string up)
        {
            FirstName = fn;
            LastName = ln;
            UserEmail = ue;
            PhoneNumber = pn;
            UserPassword = up;

        }
    }
}