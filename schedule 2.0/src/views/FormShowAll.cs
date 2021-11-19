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
    public partial class FormShowAll : Form
    {
        private static List<Commitment> Schedule { get; set; }
        public FormShowAll(List<Commitment> schedule)
        {
            Schedule = schedule;
            InitializeComponent();
        }

        private void FormShowAll_Load(object sender, EventArgs e)
        {
            listDataGridCommitment();
            comboBoxCommitments.DataSource = Enum.GetValues(typeof(Commitments));
        }

        private void listDataGridCommitment()
        {
            dataGridViewCommitments.DataSource = null;
            dataGridViewCommitments.DataSource = Schedule;
        }

        private void listDataGridNotification()
        {
            dataGridViewNotifications.DataSource = null;
            var selectedItem = dataGridViewCommitments.CurrentRow.DataBoundItem;
            var commitment = selectedItem != null ? (Commitment) selectedItem : null;
            dataGridViewNotifications.DataSource = commitment.Notifications;
        }

        private void buttonList_Click(object sender, EventArgs e)
        {
            listDataGridCommitment();
            listDataGridNotification();
        }

        private void buttonOptions_Click(object sender, EventArgs e)
        {
            var option = (Commitments) comboBoxCommitments.SelectedItem;

            switch(option)
            {
                case Commitments.EVENT: OpenEventForm(); break;
                case Commitments.JOB: OpenJobForm(); break;
                case Commitments.REMINDER: OpenReminderForm(); break;
            }
        }

        private void OpenEventForm()
        {
            var beginDate = monthCalendarBeginDate.SelectionStart;
            var formEvent = new FormEvent(Schedule, beginDate);
            formEvent.ShowDialog();
        }

        private void OpenJobForm()
        {
            var beginDate = monthCalendarBeginDate.SelectionStart;
            var formJob = new FormJob(Schedule, beginDate);
            formJob.ShowDialog();
        }

        private void OpenReminderForm()
        {

        }

        private void monthCalendarBeginDate_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
