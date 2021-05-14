using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAdvert.Web.Models.Accounts
{
    public class SignupModel
    {
        [Required (ErrorMessage = "Email muss angegeben werden")]
        [EmailAddress]
        [Display(Name="Email:")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(6,ErrorMessage = "Passwort muß mindestens 6 Zeichen lang sein")]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Passwort wiederholen")]
        [Compare("Password",ErrorMessage = "Die Passwörter stimmen nicht überein")]
        public string ConfirmPassword { get; set; }
    }
}
