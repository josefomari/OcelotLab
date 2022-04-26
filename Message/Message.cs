using System;

namespace Message
{
    public class Message
    {
        public Guid UserID { get; set; }
        public DateTime Date { get; set; }
        public string Text { get; set; }
    }
}
