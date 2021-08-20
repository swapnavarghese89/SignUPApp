using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using SignUPApp.Attributes;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SignUPApp.Models
{
    public class UserModel
    {
        [Required(ErrorMessage = "Please enter Username")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please enter Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter Password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please enter confirm password")]
        [Compare("Password", ErrorMessage = "Confirm password doesn't match")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Please enter contact number")]
        [RegularExpression("^[6, 7, 8, 9]\\d{9}$", ErrorMessage = "Please enter a valid contact number")]
        public string Contact { get; set; }

        //ADded country and city
        [Display(Name ="Country")]
        [Required(ErrorMessage = "Please select Country")]
        public string CountryId { get; set; }
        public CountryModel Country { get; set; }

        [Required(ErrorMessage = "Please select City")]
        [Display(Name = "City")]
        public string CityId { get; set; }
        public CityModel City { get; set; }

       
        [Required(ErrorMessage = "Please enter the gender")]
        public string Gender { get; set; }
       
        [ValidateCheckbox(ErrorMessage = "Please accept terms")]
        public bool Terms { get; set; }


    }
}
