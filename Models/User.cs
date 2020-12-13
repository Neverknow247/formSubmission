using System.ComponentModel.DataAnnotations;
namespace formSubmission.Models
{
    public class User
    {
        [Required]
        [MinLength(4)]
        [Display(Name = "Your First Name:")] 
        public string FirstName { get; set; }

        [Required]
        [MinLength(4)]
        [Display(Name = "Your Last Name:")] 
        public string LastName { get; set; }

        [Required]
        [Range(1,150)]
        [Display(Name = "Your Age:")] 
        public int Age { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MinLength(8)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}