using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LHBOL
{
    [Table("User")]
    public class User : IdentityUser
    {
        //[Key]
        // public string UserId { get; set; }
        //// public string Name { get; set; }
        // public string UserEmail { get; set; }
        // public string Password { get; set; }
        //public int LockoutEnabled  { get; set; } 
        //public int PhoneNumberConfirmed { get; set; }
        //public int TwoFactorEnabled { get; set; }
        //public int LockoutEnabled { get; set; }
        //public int EmailConfirmed { get; set; }
        public string Contact { get; set; }
        public IEnumerable<Episodes> Episodes { get; set; }
    }
}
