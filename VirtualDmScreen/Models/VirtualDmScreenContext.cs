using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace VirtualDmScreen.Models
{
    public class VirtualDmScreenContext : IdentityDbContext<ApplicationUser>
    {
        public virtual DbSet<DiceRoll> DiceRolls { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<Character> Characters { get; set; }

        public VirtualDmScreenContext(DbContextOptions options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder builder) 
        {
            base.OnModelCreating(builder);

            builder.Entity<ApplicationRole>().HasData(new List<ApplicationRole>
            {
                new ApplicationRole
                {
                    Id = "1", 
                    Name = "DM", 
                    NormalizedName = "DM"
                },
                new ApplicationRole 
                {
                    Id = "2", 
                    Name = "Player", 
                    NormalizedName = "PLAYER"
                },
            });
        }
    }
}