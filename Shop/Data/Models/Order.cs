using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Models
{
    public class Order
    {
        [BindNever]
        public int id { get; set;}
        [StringLength(20)]
        [Required(ErrorMessage = "Name cant be empty")]
        [Display(Name ="Name")]
        public string name { get; set; }
        [StringLength(20)]
        [Required(ErrorMessage = "Surname cant be empty")]
        [Display(Name = "Surname")]
        public string surname { get; set; }
        [StringLength(20)]
        [Required(ErrorMessage = "Adress cant be empty")]
        [Display(Name = "Adress")]
        public string adress { get; set; }
        [Display(Name = "Phone number ")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(25)]
        [Required(ErrorMessage ="Phone nubmer too short")]
        public string phone { get; set; }
        
        [Required(ErrorMessage = "Email cant be empty")]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }
        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime orderTime { get; set; }
        public List<OrderDetail> orderDetails { get; set; }


    }
}
