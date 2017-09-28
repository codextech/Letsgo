using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LetsGo.ViewModels
{
    public class CheckOutViewModel
    {



        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [RegularExpression("^((\\+92)|(0092))-{0,1}\\d{3}-{0,1}\\d{7}$|^\\d{11}$|^\\d{4}-\\d{7}$",
            ErrorMessage ="Please Give the Correct Contact Number")]
        public string Mobile { get; set; }

        public string Address { get; set; }

        [Required]
        [Display(Name = "No. of Persons")]
        [Range(1, Int32.MaxValue)]
        public int Persons { get; set; }


        [Required]
        public string City { get; set; }

        // Check OUt

        [Required]
        [Display(Name = "Card Holder Name")]
        public string CName { get; set; }

        [Required]
        [Display(Name = "Card Number")]
        public string CardNumber { get; set; }

        [Required]
        public string Cvv { get; set; }

        [Required]
        public string Month { get; set; }

        [Required]
        public string Year { get; set; }

        public decimal Total { get; set; }

    }
}