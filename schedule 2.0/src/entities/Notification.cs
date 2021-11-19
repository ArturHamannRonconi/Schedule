using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule.entities
{
    // Unity of time
    public enum Unity
    {
        SECONDS = 'S', MINUTES = 'I', HOURS = 'H',
        DAYS = 'D', WEEKS = 'W', MONTHS = 'M', YEARS = 'Y'
    }
    public class Notification
    {
        public short Time { get; set; }
        public string Type { get; set; }
        public bool Repeat { get; set; }

        private Unity unity;

        public Notification(Unity unity, short time, string type, bool repeat)
        {
            SetUnity(unity);
            Time = time;
            Type = type;
            Repeat = repeat;
        }
        public Unity GetUnity()
        {
            return unity;
        }
        private void SetUnity(Unity unity)
        {
            this.unity = unity;
        }

        public override string ToString()
        {
            return Type;
        }
    }
}
