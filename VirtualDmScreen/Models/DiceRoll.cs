using System;

namespace VirtualDmScreen.Models
{
  public class DiceRoll
  {
    public int DiceRollId { get; set; }
    public int CharacterId { get; set; }
    public int NumberOfDice { get; set; }
    public int NumberOfSides { get; set; }
    public DateTime DateTimeStamp { get; set; }
    public virtual Character Character { get; set; }
  }
}