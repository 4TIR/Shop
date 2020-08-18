using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Models
{
    public class User
    {
        public int id { get; set; }

        [Required(ErrorMessage = "Name cant be empty")]
        [Display(Name = "Name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last Name cant be empty")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Email cant be empty")]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Email cant be empty")]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}
