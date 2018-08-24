using API.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _2i.Models
{
    public class _2iUserViewModel
    {
        public string CustomerId { get; set; }
           
            [Required]
            [Display(Name = "First name")]
            public string First_name { get; set; }

            [Required]
            [Display(Name = "Middle name")]
            public string Middle_name { get; set; }

            [Required]
            [Display(Name = "Last name")]
            public string Last_name { get; set; }

            [Display(Name = "Date Of Birth")]
            [DataType(DataType.Date)]
            public DateTime Birthdate { get; set; }
            [Display(Name = "Occupution")]
            public string Occupution { get; set; }

            [Display(Name = "Mobile Number")]
            [DataType(DataType.PhoneNumber)]
            public int Mobile_number { get; set; }

            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required]
            [Display(Name = "Nationality")]
            public string Nationality { get; set; }


            [Display(Name = "Ward")]
            public string Ward { get; set; }

            [Required]
            [Display(Name = "Division")]
            public string Division { get; set; }

            [Required]
            [Display(Name = "Street")]
            public string Street { get; set; }

            [Display(Name = "Date")]
            [DataType(DataType.Date)]
            public DateTime Date { get; set; }

        
    }
}