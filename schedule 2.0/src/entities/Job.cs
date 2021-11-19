using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule.entities
{
    public enum Priority
    {
        URGENT,
        HIGH,
        NORMAL,
        LOW,
        MINIMUM
    }
    public class Job : Commitment
    {
        public Priority Priorityy { get; set; }

        public Job(
            Notification notification,
            string title, string description,
            DateTime beginDateTime, DateTime endDateTime,
            Priority priority) : base(notification, title, description, beginDateTime, endDateTime)
        {
            Priorityy = priority;
        }
    }
}
