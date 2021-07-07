using System;

namespace VirtualDmScreen.Models
{
    public class Message
    {
        public int MessageId { get; set; }
        public int CharacterId { get; set; }
        public string Text { get; set; }
        public DateTime DateTimeStamp { get; set; }
        public virtual Character Character { get; set; } 
    }
}