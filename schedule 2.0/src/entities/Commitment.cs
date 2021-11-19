using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule.entities
{
    enum Commitments
    {
        EVENT, REMINDER, JOB
    }
    public abstract class Commitment
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime BeginDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public List<Notification> Notifications { get; set; }

        public Commitment(
            string title, string description,
            DateTime beginDateTime, DateTime endDateTime
        )
        {
            Notifications = new List<Notification>();
            Title = title;
            Description = description;
            BeginDateTime = beginDateTime;
            EndDateTime = endDateTime;
            Notifications = new List<Notification>();
        }
        public Commitment(
            Notification notification, string title, string description,
            DateTime beginDateTime, DateTime endDateTime
        )
        {
            Notifications = new List<Notification>();
            Title = title;
            Description = description;
            BeginDateTime = beginDateTime;
            EndDateTime = endDateTime;
            Notifications = new List<Notification>();
            Notifications.Add(notification);
        }
    }
}
