using System.ComponentModel.DataAnnotations;

namespace DoctorWebForum.Models
{
    public class RegisterViewModel
    {
        public string Id { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Username")]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "Medical Field / Specialization")]
        public string MedicalField { get; set; }

        [Required]
        [Display(Name = "Experience(in years)")]
        public int Experience { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Your Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        [Required]
        [Display(Name = "About You (Your Personal or Professional life, Qualifications, Experiences, Achievements and so on...)")]
        public string AboutMe { get; set; }

        [Required]
        [Display(Name = "Should Account Be Made Private?")]
        public bool IsPrivate { get; set; }
    }
}
