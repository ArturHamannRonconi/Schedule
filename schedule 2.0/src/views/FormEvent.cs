using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

using Schedule.entities;


namespace Schedule.views
{
    public partial class FormEvent : Form
    {
        public static List<Event> Eventss { get; set; } = new List<Event>();
        public static IEnumerable<dynamic> Schedule { get; set; }
        public DateTime beginDateTime;

        public FormEvent(IEnumerable<dynamic> schedule, DateTime beginDateTime)
        {
            Console.WriteLine("Hello World!");

            this.beginDateTime = beginDateTime;
            Schedule = schedule;
            schedule.ToList().ForEach(commitment => {
                if (commitment is Event) Eventss.Add(commitment);
            });
            InitializeComponent();
        }

        private void FormEvent_Load(object sender, EventArgs e)
        {
            dateTimePickerBeginDate.Value = beginDateTime;
            ListAllSchedule();
        }

        private Notification getNewNotification() => new Notification(
            (Unity) Enum.Parse(typeof(Unity), comboBoxUnity.SelectedItem.ToString()),
            (short)numericUpDownTime.Value,
            textBoxType.Text, checkBoxRepeat.Checked
        );
        private void buttonSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                var notification = getNewNotification();
                var title = textBoxTitle.Text;
                var description = textBoxDescription.Text;
                var beginDateTime = dateTimePickerBeginDate.Value;
                var local = textBoxLocal.Text;
                var firstGuest = textBoxFirstGuest.Text;

                var isValidEndDate = DateTime.TryParse(
                    maskedTextBoxEndDate.Text,
                    out DateTime endDateTime
                );

                if (!isValidEndDate) throw new Exception("Invalid end date");

                var eventt = new Event(
                    notification, title,
                    description, beginDateTime,
                    endDateTime, local, firstGuest
                );

                Eventss.Add(eventt);
                Schedule.ToList().Add(eventt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            ClearAllTextBox();
            ListAllSchedule();
        }

        public void ListAllSchedule()
        {
            dataGridViewEvent.DataSource = null;
            dataGridViewEvent.DataSource = Eventss;
        }

        private void buttonList_Click_1(object sender, EventArgs e) => ListAllSchedule();

        public void ClearAllTextBox()
        {
            textBoxDescription.Text = "";
            textBoxFirstGuest.Text = "";
            textBoxLocal.Text = "";
            textBoxTitle.Text = "";
            textBoxType.Text = "";
        }

        private void listBoxCommitment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelDescription_Click(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click_1(object sender, EventArgs e)
        {
            var eventer = (Event)dataGridViewEvent.CurrentRow.DataBoundItem;
            Eventss.Remove(eventer);
            Schedule.ToList().Remove(eventer);
            ListAllSchedule();
        }

        private void buttonAlter_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewEvent.CurrentRow.DataBoundItem == null) return;

            var eventer = (Event)dataGridViewEvent.CurrentRow.DataBoundItem;
            var index = dataGridViewEvent.Rows.IndexOf(dataGridViewEvent.CurrentRow);

            var formAlterJob = new FormAlterEvent(eventer, index);
            formAlterJob.ShowDialog();
            ListAllSchedule();
        }
    }
}
