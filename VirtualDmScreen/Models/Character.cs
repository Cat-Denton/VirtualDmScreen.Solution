using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace VirtualDmScreen.Models
{
  public class Character
  {
    public int CharacterId { get; set; }
    [ForeignKey("ApplicationUser")]
    public string ApplicationUserId { get; set; }
    public string Name { get; set; }
    public string ImageUrl { get; set; }
    public int BoxId { get; set; } = 0;
    public virtual ApplicationUser User { get; set; }
    public virtual ICollection<Message> Messages { get; set; }
    public virtual ICollection<DiceRoll> DiceRolls { get; set; }
    public Character()
    {
      this.Messages = new HashSet<Message>();
      this.DiceRolls = new HashSet<DiceRoll>();
    }
  }
}