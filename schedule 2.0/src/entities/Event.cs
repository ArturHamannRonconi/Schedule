using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule.entities
{
    public class Event : Commitment
    {
        public string Local { get; set; }
        public List<string> Guests { get; set; } = new List<string>(); 

        public Event(
            string title, string description,
            DateTime beginDateTime, DateTime endDateTime,
            string local, string guest
        ) : base(title, description, beginDateTime, endDateTime)
        {
            Local = local;
            Guests.Add(guest);
        }

        public Event(
            string title, string description,
            DateTime beginDateTime, DateTime endDateTime,
            string local
        ) : base(title, description, beginDateTime, endDateTime)
        {
            Local = local;
        }

        public Event(
            Notification notification, string title, string description,
            DateTime beginDateTime, DateTime endDateTime,
            string local, string guest
        ) : base(notification, title, description, beginDateTime, endDateTime)
        {
            Local = local;
            Guests.Add(guest);
        }

        public Event(
           Notification notification, string title, string description,
           DateTime beginDateTime, DateTime endDateTime,
           string local
       ) : base(notification, title, description, beginDateTime, endDateTime)
        {
            Local = local;
        }

        public override string ToString()
        {
            return Title;
        }
    }
}
