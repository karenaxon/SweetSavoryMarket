using System.IO;
using System;
using System.Security.AccessControl;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace SweetSavory.Models
{
  public class ApplicationUser : IdentityUser
  {
    // [Required]
    // [Display(Name = "First Name")]
    // public string FirstName { get; set; }

    // [Required]
    // [Display(Name = "Last Name")]
    // public string LastName { get; set; }

    // [Required]
    // [Display(Name = "User Name")]
    // public string UserName { get; set; }
    
    // [Required]
    // [EmailAddress]
    // [Display(Name = "Email")]
    // public string Email { get; set; }

    // [Required]
    // [DataType(DataType.Password)]
    // [Display(Name = "Password")]
    // public string Password { get; set; }
  }
}