using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HELP_Desk.Models
{
    public class ApplicationUserViewModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
