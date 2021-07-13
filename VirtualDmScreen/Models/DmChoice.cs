namespace VirtualDmScreen.Models
{
    public class DmChoice
    {
        public int DmChoiceId { get; set; }
        public int DmTrackSelectionId { get; set; }
        public int DmImgSelectionId { get; set; }
        public virtual DmTrackSelection DmTrackSelection { get; set; }
        public virtual DmImgSelection DmImgSelection { get; set; }
        
    }
}