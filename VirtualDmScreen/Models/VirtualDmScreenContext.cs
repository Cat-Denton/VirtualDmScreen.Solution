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
        public virtual DbSet<DmTrackSelection> DmTrackSelections { get; set; }
        public virtual DbSet<DmImgSelection> DmImgSelections { get; set; }
        public virtual DbSet<DmChoice> DmChoices { get; set; }

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
            builder.Entity<DmTrackSelection>()
            .HasData(
                new DmTrackSelection { DmTrackSelectionId = 1, SpotifyTrack = "7ob4BKZ9yFXI06HvQaUXvp", TrackName = "Dragon Age"},
                new DmTrackSelection { DmTrackSelectionId = 2, SpotifyTrack = "2EelmLcDmP1h1BuRUu7h7W", TrackName = "City in the Clouds"},
                new DmTrackSelection { DmTrackSelectionId = 3, SpotifyTrack = "18O8Y4mZ2sNOBYBwBR1LVK", TrackName = "Willow's Theme"}
                
            );
            builder.Entity<DmImgSelection>()
            .HasData(
                new DmImgSelection { DmImgSelectionId = 1, ImgName = "Party of Adventurers", ImgPath = "/img/party.jpg"},
                new DmImgSelection { DmImgSelectionId = 2, ImgName = "White Dragon", ImgPath = "/img/whitedragon.jpg"},
                new DmImgSelection { DmImgSelectionId = 3, ImgName = "Red Dragon", ImgPath = "/img/reddragon.jpg"},
                new DmImgSelection { DmImgSelectionId = 4, ImgName = "Fire Breathing Dragon", ImgPath = "/img/firebreath.jpg"}
            );
            builder.Entity<DmChoice>()
            .HasData(
                new DmChoice { DmChoiceId = 1, DmTrackSelectionId = 1, DmImgSelectionId = 1}   
            );
            
        }
    }
}

// <iframe src="https://open.spotify.com/embed/track/2EelmLcDmP1h1BuRUu7h7W" width="100%" height="380" frameBorder="0" allowtransparency="true" allow="encrypted-media"></iframe>
// <iframe src="https://open.spotify.com/embed/track/18O8Y4mZ2sNOBYBwBR1LVK" width="100%" height="380" frameBorder="0" allowtransparency="true" allow="encrypted-media"></iframe>