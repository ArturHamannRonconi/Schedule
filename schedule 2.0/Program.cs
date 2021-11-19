using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using Schedule.views;
using Schedule.entities;

namespace Schedule
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var notification = new Notification(Unity.DAYS, 3, "Seila", true);

            var schedule = new List<Commitment>() {
                new Event(
                    notification, "Título", "Descrição",
                    new DateTime(2021, 11, 13),
                    new DateTime(2021, 11, 16),
                    "Otacílio Costa", "Brenda"
                )
            };
            Application.Run(new FormShowAll(schedule));
        }
    }
}
