using System;
using Microsoft.EntityFrameworkCore;

namespace VirtualDmScreen.Models
{
    public class DmTrackSelection
    {
        public int DmTrackSelectionId { get; set; }
        public string TrackName { get; set; }
        public string SpotifyTrack { get; set; }
        
    }
}

