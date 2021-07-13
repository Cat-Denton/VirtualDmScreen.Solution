namespace VirtualDmScreen.Models
{
    public class DmChoice
    {
        public int DmChoiceId { get; set; }
        public int DmTrackSelectionId { get; set; }
        public virtual DmTrackSelection DmTrackSelection { get; set; }
        
    }
}