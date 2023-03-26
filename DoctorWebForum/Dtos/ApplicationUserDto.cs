using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DoctorWebForum.Dtos
{
    //Data Objects used in passing data to API
    public class ApplicationUserDto
    {
        public string Id { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public int Experience { get; set; }

        [Required]
        public string MedicalField { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string AboutMe { get; set; }

        [Required]
        public bool IsPrivate { get; set; }
    }
}