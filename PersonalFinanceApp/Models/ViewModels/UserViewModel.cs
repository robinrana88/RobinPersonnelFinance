using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalFinanceApp.Models.ViewModels
{
    public class UserViewModel
    {

        public int UserId { get; set; }
        [Required(ErrorMessage = "Please Enter a Valid First Name.")]
        [StringLength(20, ErrorMessage = "First Name can be 2 to 20 Characters Long.", MinimumLength = 2)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please Enter a Valid Last Name.")]
        [StringLength(20, ErrorMessage = "Last Name can be 2 to 20 Characters Long.", MinimumLength = 2)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please Enter a Valid Email Address.")]
        [EmailAddress(ErrorMessage = "Please Enter a Valid Email Address.")]
        public string EmailAddress { get; set; }
        [Required]
        [Phone(ErrorMessage = "Please Enter a Valid Phone Number.")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Please Enter a Valid Address.")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Please Mark a Valid Gender.")]
        public string Gender { get; set; }
    }
}
