using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAdvert.Web.Models.Accounts
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Email ist ein Pflichtfeld")]
        [Display(Name = "Email - Address")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Sie müssen ein Passwort eingeben!")]
        [Display(Name = "Passwort")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Remember Me")]
        public bool RememberMe { get; set; }

    }
}
