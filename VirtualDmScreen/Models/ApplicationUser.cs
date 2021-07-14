using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace VirtualDmScreen.Models
{
    public class ApplicationUser : IdentityUser
    {
        // public virtual ICollection<Character> Characters { get; set; }
        public virtual Character SelectedCharacter { get; set; }

    //     public ApplicationUser() : base()
    //     {
    //         Characters = new HashSet<Character>();
    //     }

    //     public ApplicationUser(string userName) : base(userName)
    //     {
    //         Characters = new HashSet<Character>();
    //     }
    }
}