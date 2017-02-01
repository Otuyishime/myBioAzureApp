using System;
using System.ComponentModel.DataAnnotations;

namespace myBioApp.Models
{
    public class Email
    {
        [Required(ErrorMessage = "Name is Required")]
        public String Name { get; set; }

        [Required(ErrorMessage = "Email is Required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public String Email_Str { get; set; }

        [Required(ErrorMessage = "Phone number is Required")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Invalid Phone Number")]
        public String PhoneNumber { get; set; }

        [Required]
        [StringLength(maximumLength: 500)]
        public String Message { get; set; }
    }
}