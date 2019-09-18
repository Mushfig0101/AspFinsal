using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Indecor.Models
{
    public class UserControl:IdentityUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }       
        public string IdentityCard { get; set; }
    }
}
