using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Schedule.entities;

namespace Schedule.views
{
    public partial class FormReminder : Form
    {
        public static List<Reminder> Reminders { get; set; } = new List<Reminder>();
        public static IEnumerable<dynamic> Schedule { get; set; }
        public DateTime beginDateTime;

        public FormReminder(IEnumerable<dynamic> schedule, DateTime beginDateTime)
        {
            this.beginDateTime = beginDateTime;
            Schedule = schedule;
            schedule.ToList().ForEach(commitment => {
                if (commitment is Reminder) Reminders.Add(commitment);
            });
            InitializeComponent();
        }

        private void buttonAlter_Click(object sender, EventArgs e)
        {

        }

        private void buttonList_Click(object sender, EventArgs e) => ListAllSchedule();

        public void ListAllSchedule()
        {
            dataGridViewEvent.DataSource = null;
            dataGridViewEvent.DataSource = Reminders;
        }
    }
}
