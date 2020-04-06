using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace IceCreamShop.Models
{
    public class UserModel
    {
        private string firstName;
        private string lastName;
        private string email;
        private string phoneNum;
        private string age;
        private string options;
        private string password;

        [DisplayName("FirstName")]
        [Required]
        [MaxLength(20)]
        [MinLength(2)]
        public string FirstName { get => firstName; set => firstName = value; }

        [DisplayName("LastName")]
        [Required]
        [MaxLength(20)]
        [MinLength(2)]
        public string LastName { get => lastName; set => lastName = value; }

        [DisplayName("E-mail")]
        [EmailAddress]
        [Required]
        public string Email { get => email; set => email = value; }

        [DisplayName("Phone Number")]
        [Required]
        public string PhoneNum { get => phoneNum; set => phoneNum = value; }

        [DisplayName("Age")]
        [Required]
        public string Age { get => age; set => age = value; }

        [DisplayName("Password")]
        [Required]
        public string Password { get => password; set => password = value; }

        [DisplayName("Options")]
        public string Options { get => options; set => options = value; }
    }
}

