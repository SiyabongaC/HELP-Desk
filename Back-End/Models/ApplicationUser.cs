using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HELP_Desk.Models
{
    public class ApplicationUser: IdentityUser
    {
        [Column(TypeName ="nvarchar(50)")]
        public string name { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string surname { get; set; }
    }
}
