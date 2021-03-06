using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule.entities
{
    public enum DayOfWeek
    {
        SUNDAY, MONDAY,
        TUESDAY, WEDNESDAY,
        THURSDAY, FRIDAY,
        SATURDAY
    }
    public enum Ends
    {
        NEVER, IN_DATE,
        SO_MANY_TIMES
    }

    public struct Repeat
    {
        public short Amount { get; set; }
        public Unity Unityy { get; set; }
        public DayOfWeek[] DayOfWeeks { get; set; }

        public Repeat(short amount, Unity unity)
        {
            Amount = amount;
            Unityy = unity;
            DayOfWeeks = new DayOfWeek[amount];
        }
    }

    public class Reminder : Commitment
    {
        public Repeat Repeatt { get; set; }
        public Ends End { get; set; }
        public dynamic WhenEnds { get; set; }

        public Reminder(
            Notification notification, 
            string title, string description,
            DateTime beginDateTime, DateTime endDateTime,
            Repeat repeat, Ends end,
            dynamic whenEnd
            ) : base(notification, title, description, beginDateTime, endDateTime)
        {
            Repeatt = repeat;
            End = end;
            WhenEnds = whenEnd;
        }
    }
}
