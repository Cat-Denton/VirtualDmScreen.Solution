using System;
using System.Collections.Generic;

namespace VirtualDmScreen.Models
{
  public class DiceRoll
  {
    public int DiceRollId { get; set; }
    public int CharacterId { get; set; }
    public int NumberOfDice { get; set; }
    public int NumberOfSides { get; set; }
    public int Result { get; set; }
    public DateTime DateTimeStamp { get; set; }
    public virtual Character Character { get; set; }

    public void RollDice() 
    {
      var listOfRolls = new List<int>();
      int result = 0;
      for (int i = 1; i <= this.NumberOfDice; i++)
      {
        Random rnd = new Random();
        result = result + rnd.Next(1,this.NumberOfSides);
      } 
      Console.WriteLine("***********************************************************************************" + result + "**********************************************************************");
      this.Result = result;
    }
  }
}