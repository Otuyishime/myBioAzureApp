using System;
using System.ComponentModel.DataAnnotations;

namespace myBioApp.Models
{
    public class Email
    {
        public String Name { get; set; }

        [DataType(DataType.EmailAddress)]
        public String Email_Str { get; set; }

        [DataType(DataType.PhoneNumber)]
        public String PhoneNumber { get; set; }

        [Range(minimum:0, maximum:500)]
        public String Message { get; set; }
    }
}