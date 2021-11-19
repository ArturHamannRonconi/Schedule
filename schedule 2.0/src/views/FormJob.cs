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
    public partial class FormJob : Form
    {
        public static List<Job> Jobs { get; set; } = new List<Job>();
        public static IEnumerable<dynamic> Schedule { get; set; }
        public DateTime beginDateTime;

        public FormJob(IEnumerable<dynamic> schedule, DateTime beginDateTime)
        {
            this.beginDateTime = beginDateTime;
            Schedule = schedule;
            schedule.ToList().ForEach(commitment => {
                if (commitment is Job) Jobs.Add(commitment);
            });

            InitializeComponent();
        }

        private void FormSchedule_Load(object sender, EventArgs e)
        {
            dateTimePickerBeginDate.Value = beginDateTime;
            comboBoxPriority.DataSource = Enum.GetValues(typeof(Priority));
            ListAllSchedule();
        }
        
        private Notification getNewNotification() => new Notification(
            (Unity)comboBoxUnity.SelectedItem,
            (short)numericUpDownTime.Value,
            textBoxType.Text, checkBoxRepeat.Checked
        );
        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                var notification = getNewNotification();
                var title = textBoxTitle.Text;
                var description = textBoxDescription.Text;
                var beginDateTime = dateTimePickerBeginDate.Value;
                var priority = (Priority)comboBoxPriority.SelectedItem;

                var isValidEndDate = DateTime.TryParse(
                    maskedTextBoxEndDate.Text,
                    out DateTime endDateTime
                );

                if (!isValidEndDate) throw new Exception("Invalid end date");

                var eventt = new Job(
                    notification, title,
                    description, beginDateTime,
                    endDateTime, priority
                );

                Jobs.Add(eventt);
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
            dataGridViewJob.DataSource = null;
            dataGridViewJob.DataSource = Jobs;
        }

        private void buttonList_Click(object sender, EventArgs e) => ListAllSchedule();

        public void ClearAllTextBox()
        {
            textBoxDescription.Text = "";
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

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var job = (Job)dataGridViewJob.CurrentRow.DataBoundItem;
            Jobs.Remove(job);
            Schedule.ToList().Remove(job);
            ListAllSchedule();
        }

        private void buttonAlter_Click(object sender, EventArgs e)
        {
            if (dataGridViewJob.CurrentRow.DataBoundItem == null) return;

            var job = (Job)dataGridViewJob.CurrentRow.DataBoundItem;
            var index = dataGridViewJob.Rows.IndexOf(dataGridViewJob.CurrentRow);

            var formAlterJob = new FormAlterJob(job, index);
            formAlterJob.ShowDialog();
            ListAllSchedule();
        }
    }
}
