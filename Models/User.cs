using System;
using System.ComponentModel.DataAnnotations;

namespace formsubmission.Models
{
    public class User
    {
        // First Name
        [Required]
        [MinLength(4)]
       public string FirstName {get;set;}
       // Last Name
       [Required]
        [MinLength(4)]
       public string LastName {get;set;}
       // Age
       [Required]
       [Range(0, 140)]
       public int Age {get;set;}
       // Email Address
       [Required]
       [EmailAddress]
       public string Email {get;set;}
       // Password
       [Required]
       [DataType(DataType.Password)]
       public string Password {get;set;}
    }
}