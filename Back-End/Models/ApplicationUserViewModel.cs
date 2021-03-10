using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HELP_Desk.Models
{
    public class ApplicationUserViewModel
    {

        [Required(ErrorMessage = "Name cannot be Empty.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Surname cannot be Empty.")]
        public string Surname { get; set; }
        //public string UserName { get; set; }
        [Required(ErrorMessage = "Email cannot be Empty."), EmailAddress(ErrorMessage = "Email is not valid.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password cannot be Empty.")]
        public string Password { get; set; }
    }
}
