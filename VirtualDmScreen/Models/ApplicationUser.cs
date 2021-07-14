using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace VirtualDmScreen.Models
{
    public class ApplicationUser : IdentityUser
    {
        public virtual Character Character { get; set; }
    }
}